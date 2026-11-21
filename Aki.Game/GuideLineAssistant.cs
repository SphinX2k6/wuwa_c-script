using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Teleport;
using GuideLineProcess;
using UnrealEngine;

// Token: 0x02001B20 RID: 6944
[NullableContext(1)]
[Nullable(0)]
public class GuideLineAssistant : ControllerAssistantBase
{
	// Token: 0x060114E7 RID: 70887 RVA: 0x00517CBC File Offset: 0x00515EBC
	public GuideLineAssistant(IReadOnlyList<BtType> btTypes)
	{
		this.BtTypes = btTypes;
		this.CurBtType = ((this.BtTypes.Count > 0) ? this.BtTypes[0] : BtType.Invalid);
	}

	// Token: 0x060114E8 RID: 70888 RVA: 0x00517D4B File Offset: 0x00515F4B
	protected override void OnInit()
	{
	}

	// Token: 0x060114E9 RID: 70889 RVA: 0x00517D4D File Offset: 0x00515F4D
	protected override void OnDestroy()
	{
		this.ProcessList.Clear();
		this.DestroyGuideSpline();
		this.QuestGuidePoints.Empty(true);
	}

	// Token: 0x060114EA RID: 70890 RVA: 0x00517D6C File Offset: 0x00515F6C
	public override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.GeneralLogicTreeWakeUp, new Action(this.SpawnQuestGuideLine));
		EventSystem.Instance.Add<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnUseSkill));
		EventSystem.Instance.Add<BtType, long?>(EEventName.OnLogicTreeTrackUpdate, new Action<BtType, long?>(this.OnQuestTrackUpdate));
		EventSystem.Instance.Add<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(EEventName.OnLogicTreeNodeStatusChange, new Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(this.OnNodeStatusUpdate));
		EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.RefreshSpawn));
	}

	// Token: 0x060114EB RID: 70891 RVA: 0x00517E04 File Offset: 0x00516004
	public override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.GeneralLogicTreeWakeUp, new Action(this.SpawnQuestGuideLine));
		EventSystem.Instance.Remove<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnUseSkill));
		EventSystem.Instance.Remove<BtType, long?>(EEventName.OnLogicTreeTrackUpdate, new Action<BtType, long?>(this.OnQuestTrackUpdate));
		EventSystem.Instance.Remove<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(EEventName.OnLogicTreeNodeStatusChange, new Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(this.OnNodeStatusUpdate));
		EventSystem.Instance.Remove<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.RefreshSpawn));
	}

	// Token: 0x060114EC RID: 70892 RVA: 0x00517E9A File Offset: 0x0051609A
	private void OnUseSkill(int charId, int skillId, bool isAutonomousProxy)
	{
		if (skillId == 210004)
		{
			GeneralLogicTreeModel.Instance.UpdateGuideLineStartShowTime();
		}
	}

	// Token: 0x060114ED RID: 70893 RVA: 0x00517EB0 File Offset: 0x005160B0
	private void OnQuestTrackUpdate(BtType contextType, long? _ = null)
	{
		bool flag = false;
		for (int i = 0; i < this.BtTypes.Count; i++)
		{
			if (this.BtTypes[i] == contextType)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			return;
		}
		this.CurBtType = contextType;
		GeneralLogicTreeModel.Instance.UpdateGuideLineStartShowTime();
		if (!this.CheckCanShowGuideLine())
		{
			return;
		}
		this.RefreshSpawn(null);
	}

	// Token: 0x060114EE RID: 70894 RVA: 0x00517F10 File Offset: 0x00516110
	private void OnNodeStatusUpdate(GeneralContext context, NodeStatus oldStatus, NodeStatus newStatus, ENodeStatusUpdateReason reason)
	{
		if (context.Type.GetValueOrDefault() == EGeneralContextType.GeneralLogicTree)
		{
			GeneralLogicTreeContext generalLogicTreeContext = context as GeneralLogicTreeContext;
			if (generalLogicTreeContext != null)
			{
				LogicTreeContainer currentTrack = this.GetCurrentTrack(new BtType?(generalLogicTreeContext.BtType));
				if (((currentTrack != null) ? currentTrack.Id : 0) != generalLogicTreeContext.TreeConfigId || newStatus != NodeStatus.Activated)
				{
					return;
				}
				this.OnQuestTrackUpdate(generalLogicTreeContext.BtType, null);
				return;
			}
		}
	}

	// Token: 0x060114EF RID: 70895 RVA: 0x00517F75 File Offset: 0x00516175
	public void SpawnQuestGuideLine()
	{
		this.DestroyGuideSpline();
		ResourceSystem.Instance.LoadTypeAsync(EBpTypeName.BP_Fx_WayFinding_C.ToEnumString(), delegate
		{
			this.PersistentSpline = (ActorSystem.Instance.Get(BP_Fx_WayFinding_C.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true) as BP_Fx_WayFinding_C);
		}, "js_undefined");
		this.DisableQuestGuideLine();
		this.PathPointsPersistent = new TArray<FVectorDouble>();
	}

	// Token: 0x060114F0 RID: 70896 RVA: 0x00517FAF File Offset: 0x005161AF
	private void DestroyGuideSpline()
	{
		if (ObjectUtils.IsValid(this.PersistentSpline))
		{
			ActorSystem.Instance.Put("GuideLineAssistant.DestroyGuideSpline", this.PersistentSpline, null);
		}
		this.PersistentSpline = null;
	}

	// Token: 0x060114F1 RID: 70897 RVA: 0x00517FDC File Offset: 0x005161DC
	public void Tick(float delta)
	{
		this.UpdateCurSpawn(delta);
		this.UpdateProcess();
		if (!this.CheckCanShowGuideLine())
		{
			if (this.CurSpawn > 0f && this.TriggeredSpawn)
			{
				this.DisableQuestGuideLine();
			}
			this.TriggeredSpawn = false;
			return;
		}
		bool flag = this.UpdateMovingState();
		if (!this.TriggeredSpawn || (flag && !this.Moving))
		{
			this.RefreshSpawn(null);
		}
	}

	// Token: 0x060114F2 RID: 70898 RVA: 0x00518044 File Offset: 0x00516244
	private void UpdateProcess()
	{
		if (this.ProcessList.Count == 0)
		{
			return;
		}
		if (this.CurProcess != null)
		{
			return;
		}
		this.CurProcess = this.ProcessList[0];
		GuideLineProcess.EProcessType processType = this.CurProcess.ProcessType;
		if (processType == GuideLineProcess.EProcessType.StartShow)
		{
			this.UpdateQuestGuideline();
			return;
		}
		if (processType != GuideLineProcess.EProcessType.EndShow)
		{
			return;
		}
		this.ChangeAnimType(EAnimType.Hide);
	}

	// Token: 0x060114F3 RID: 70899 RVA: 0x0051809C File Offset: 0x0051629C
	[NullableContext(2)]
	private void RefreshSpawn(TeleportContext teleportContext = null)
	{
		this.CurProcess = null;
		this.ProcessList.Clear();
		if (this.CurSpawn > 0f)
		{
			this.ProcessList.Add(new GuideLineProcess.EndShowProcess());
		}
		this.ProcessList.Add(new GuideLineProcess.StartShowProcess());
		this.TriggeredSpawn = true;
	}

	// Token: 0x060114F4 RID: 70900 RVA: 0x005180EF File Offset: 0x005162EF
	private void DisableQuestGuideLine()
	{
		this.ProcessList.Add(new GuideLineProcess.EndShowProcess());
		if (ObjectUtils.IsValid(this.PersistentSpline))
		{
			BP_Fx_WayFinding_C persistentSpline = this.PersistentSpline;
			if (persistentSpline == null)
			{
				return;
			}
			persistentSpline.StopEffect();
		}
	}

	// Token: 0x060114F5 RID: 70901 RVA: 0x00518120 File Offset: 0x00516320
	public bool CheckCanShowGuideLine()
	{
		if (PlotModel.Instance.IsInHighLevelPlot())
		{
			return false;
		}
		LogicTreeContainer currentTrack = this.GetCurrentTrack(null);
		if (currentTrack == null || !currentTrack.CanShowGuideLine())
		{
			this.DisableQuestGuideLine();
			return false;
		}
		if (currentTrack.IsAlwaysShowGuideLine())
		{
			return true;
		}
		double guideLineStartShowTime = GeneralLogicTreeModel.Instance.GetGuideLineStartShowTime();
		if (this.GuideLineShowTime == 0.0)
		{
			string globalConfig = QuestNewConfig.Instance.GetGlobalConfig("GuideLineShowTime");
			if (!string.IsNullOrEmpty(globalConfig))
			{
				double.TryParse(globalConfig, out this.GuideLineShowTime);
			}
		}
		return TimeUtil.Instance.GetServerTime() - guideLineStartShowTime <= this.GuideLineShowTime;
	}

	// Token: 0x060114F6 RID: 70902 RVA: 0x005181C0 File Offset: 0x005163C0
	private bool UpdateMovingState()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		BaseMoveComponent baseMoveComponent;
		if (getCurrentEntity == null)
		{
			baseMoveComponent = null;
		}
		else
		{
			WorldEntity entity = getCurrentEntity.Entity;
			baseMoveComponent = ((entity != null) ? entity.GetComponent<BaseMoveComponent>() : null);
		}
		BaseMoveComponent baseMoveComponent2 = baseMoveComponent;
		if (baseMoveComponent2 == null)
		{
			this.SetMovingState(false);
			return false;
		}
		return this.SetMovingState(baseMoveComponent2.IsMoving);
	}

	// Token: 0x060114F7 RID: 70903 RVA: 0x0051820C File Offset: 0x0051640C
	private void UpdateCurSpawn(float delta)
	{
		if (this.CurProcess == null || !ObjectUtils.IsValid(this.PersistentSpline))
		{
			return;
		}
		this.TimeElapse = MathUtils.Instance.Clamp(this.TimeElapse + delta / 50f, 0f, 1f);
		this.CurSpawn = MathUtils.Instance.Lerp(this.LerpStartSpawn, this.LerpTargetSpawn, this.TimeElapse);
		this.PersistentSpline.NS_Fx_WayFinding.SetNiagaraVariableFloat("Spawn", this.CurSpawn);
		if (this.TimeElapse >= 1f && this.LastTimeElapse < 1f)
		{
			this.FinishLerp();
		}
		this.LastTimeElapse = this.TimeElapse;
	}

	// Token: 0x060114F8 RID: 70904 RVA: 0x005182C0 File Offset: 0x005164C0
	private void FinishLerp()
	{
		this.CurProcess.Finished = true;
		this.ProcessList.RemoveAt(0);
		this.CurProcess = null;
	}

	// Token: 0x060114F9 RID: 70905 RVA: 0x005182E4 File Offset: 0x005164E4
	private void UpdateQuestGuideline()
	{
		if (!ObjectUtils.IsValid(this.PersistentSpline))
		{
			Log.Instance.Error(ELogModule.Quest, ELogAuthor.YSQ, "GuideLineAssistant:UE.BP_Fx_WayFinding_C还未加载", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		LogicTreeContainer currentTrack = this.GetCurrentTrack(null);
		if (currentTrack == null)
		{
			this.DisableQuestGuideLine();
			return;
		}
		BehaviorNodeBase showGuideLineNode = currentTrack.GetShowGuideLineNode();
		if (showGuideLineNode == null)
		{
			this.DisableQuestGuideLine();
			return;
		}
		global::Vector nodeTrackPosition = currentTrack.GetNodeTrackPosition(showGuideLineNode.NodeId);
		global::Vector playerLocation = GeneralLogicTreeUtil.Instance.GetPlayerLocation();
		if (nodeTrackPosition == null || playerLocation == null)
		{
			this.DisableQuestGuideLine();
			return;
		}
		this.StartVector.Set(playerLocation.X, playerLocation.Y, playerLocation.Z);
		UObject world = GlobalData.World;
		FVector fvector = this.StartVector.ToUeVectorOld();
		FVector fvector2 = nodeTrackPosition.ToUeVectorOld();
		URoadNetNavigationPath uroadNetNavigationPath = URoadNetNavigationSystem.RoadNet_FindPathToLocationSynchronously(world, fvector, fvector2);
		if (uroadNetNavigationPath == null || uroadNetNavigationPath.PathPoints.Num() == 0)
		{
			this.DisableQuestGuideLine();
			return;
		}
		double num = (double)uroadNetNavigationPath.Length;
		double? num2 = currentTrack.GetGuideLineHideDistance(showGuideLineNode.NodeId) * (double)100;
		if (num <= num2.GetValueOrDefault() & num2 != null)
		{
			this.DisableQuestGuideLine();
			return;
		}
		this.PathPointsPersistent.Empty(true);
		for (int i = 0; i < uroadNetNavigationPath.PathPoints.Num(); i++)
		{
			FVectorDouble value = UKismetMathLibrary.Conv_VectorToVectorDouble(uroadNetNavigationPath.PathPoints.Get(i));
			this.PathPointsPersistent.Add(value);
		}
		this.UpdatePersistentSpline(this.PersistentSpline.Spline, this.PathPointsPersistent, 4);
		this.PersistentSpline.EnsureEffect();
		BehaviorNodeBase currentActiveChildQuestNode = currentTrack.GetCurrentActiveChildQuestNode();
		if (currentActiveChildQuestNode != null)
		{
			this.PersistentSpline.NS_Fx_WayFinding.SetIntParameter(FNameUtil.GetDynamicFName("Type") ?? FNameUtil.NONE, (int)currentActiveChildQuestNode.NavigationStyle);
		}
	}

	// Token: 0x060114FA RID: 70906 RVA: 0x005184D8 File Offset: 0x005166D8
	private void UpdatePersistentSpline(USplineComponent spline, TArray<FVectorDouble> pathPoints, int stepFactor)
	{
		spline.ClearSplinePoints(true);
		TArray<FVectorDouble> tarray = new TArray<FVectorDouble>();
		for (int i = 0; i < pathPoints.Num() - 1; i++)
		{
			FVectorDouble fvectorDouble = pathPoints.Get(i);
			FVectorDouble fvectorDouble2 = pathPoints.Get(i + 1);
			tarray.Add(fvectorDouble);
			if (Math.Abs(fvectorDouble2.Z - fvectorDouble.Z) > 2000.0)
			{
				break;
			}
			if (i + 1 == pathPoints.Num() - 1)
			{
				tarray.Add(fvectorDouble2);
			}
		}
		spline.D_SetSplinePoints(tarray, ESplineCoordinateSpace.World, true);
		this.QuestGuidePoints.Empty(true);
		float splineLength = spline.GetSplineLength();
		for (int j = 0; j < spline.GetNumberOfSplinePoints() - 1; j++)
		{
			float distanceAlongSplineAtSplinePoint = spline.GetDistanceAlongSplineAtSplinePoint(j);
			float distanceAlongSplineAtSplinePoint2 = spline.GetDistanceAlongSplineAtSplinePoint(j + 1);
			float num = (distanceAlongSplineAtSplinePoint2 - distanceAlongSplineAtSplinePoint) / (float)stepFactor;
			float num2 = distanceAlongSplineAtSplinePoint;
			while (num2 <= distanceAlongSplineAtSplinePoint2 && num2 <= splineLength)
			{
				FVectorDouble fvectorDouble3 = spline.D_GetLocationAtDistanceAlongSpline(num2, ESplineCoordinateSpace.World);
				FVectorDouble fvectorDouble4 = default(FVectorDouble);
				bool flag = UNavigationSystemV1.D_K2_ProjectPointToNavigation(GlobalData.World, fvectorDouble3, ref fvectorDouble4, null, default(TSubclassOf<UNavigationQueryFilter>), this.ProjectQueryExtVector.ToUeVector(false), -1.0);
				FVectorDouble value = fvectorDouble3;
				if (flag)
				{
					value = fvectorDouble4;
				}
				this.QuestGuidePoints.Add(value);
				num2 += num;
			}
		}
		spline.D_SetSplinePoints(this.QuestGuidePoints, ESplineCoordinateSpace.World, true);
		this.ChangeAnimType(EAnimType.Show);
	}

	// Token: 0x060114FB RID: 70907 RVA: 0x00518634 File Offset: 0x00516834
	private void ChangeAnimType(EAnimType type)
	{
		this.LerpStartSpawn = this.CurSpawn;
		this.TimeElapse = 0f;
		this.LastTimeElapse = 0f;
		if (type == EAnimType.Show)
		{
			this.LerpTargetSpawn = 2f;
			return;
		}
		if (type != EAnimType.Hide)
		{
			return;
		}
		this.LerpTargetSpawn = 0f;
	}

	// Token: 0x060114FC RID: 70908 RVA: 0x00518683 File Offset: 0x00516883
	private bool SetMovingState(bool value)
	{
		if (this.Moving != value)
		{
			this.Moving = value;
			return true;
		}
		return false;
	}

	// Token: 0x060114FD RID: 70909 RVA: 0x00518698 File Offset: 0x00516898
	[NullableContext(2)]
	private LogicTreeContainer GetCurrentTrack(BtType? btType = null)
	{
		BtType btType2 = btType ?? this.CurBtType;
		LogicTreeContainer result = null;
		switch (btType2)
		{
		case BtType.Quest:
		case BtType.Recall:
			result = QuestNewModel.Instance.GetCurTrackedQuest();
			break;
		case BtType.LevelPlay:
			result = LevelPlayModel.Instance.GetTrackLevelPlayInfo();
			break;
		}
		return result;
	}

	// Token: 0x04009833 RID: 38963
	private const int QUERY_VALUE = 500;

	// Token: 0x04009834 RID: 38964
	private const int SPLIT_Z_LIMIT = 2000;

	// Token: 0x04009835 RID: 38965
	private readonly IReadOnlyList<BtType> BtTypes = Array.Empty<BtType>();

	// Token: 0x04009836 RID: 38966
	private BtType CurBtType;

	// Token: 0x04009837 RID: 38967
	[Nullable(2)]
	private BP_Fx_WayFinding_C PersistentSpline;

	// Token: 0x04009838 RID: 38968
	[Nullable(2)]
	private TArray<FVectorDouble> PathPointsPersistent;

	// Token: 0x04009839 RID: 38969
	private readonly List<GuideLineProcess.PendingProcess> ProcessList = new List<GuideLineProcess.PendingProcess>();

	// Token: 0x0400983A RID: 38970
	[Nullable(2)]
	private GuideLineProcess.PendingProcess CurProcess;

	// Token: 0x0400983B RID: 38971
	private double GuideLineShowTime;

	// Token: 0x0400983C RID: 38972
	private readonly TArray<FVectorDouble> QuestGuidePoints = new TArray<FVectorDouble>();

	// Token: 0x0400983D RID: 38973
	private readonly global::Vector StartVector = global::Vector.Create();

	// Token: 0x0400983E RID: 38974
	private readonly global::Vector ProjectQueryExtVector = global::Vector.Create(500.0, 500.0, 500.0);

	// Token: 0x0400983F RID: 38975
	private float LerpStartSpawn;

	// Token: 0x04009840 RID: 38976
	private float LerpTargetSpawn;

	// Token: 0x04009841 RID: 38977
	private float LastTimeElapse;

	// Token: 0x04009842 RID: 38978
	private float CurSpawn;

	// Token: 0x04009843 RID: 38979
	private float TimeElapse;

	// Token: 0x04009844 RID: 38980
	private bool Moving;

	// Token: 0x04009845 RID: 38981
	private bool TriggeredSpawn;
}
