using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree.Express;
using UnrealEngine;

// Token: 0x02001D59 RID: 7513
[NullableContext(2)]
[Nullable(0)]
public class NodeTrackEffect : IStaticVariableResetter
{
	// Token: 0x0600E46E RID: 58478 RVA: 0x0035AE80 File Offset: 0x00359080
	static NodeTrackEffect()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(NodeTrackEffect.CreateStaticDefaultValue), new Action(NodeTrackEffect.ResetStaticDefaultValue));
	}

	// Token: 0x0600E46F RID: 58479 RVA: 0x0035AEA0 File Offset: 0x003590A0
	[NullableContext(1)]
	public NodeTrackEffect(BehaviorTreeExpressionComponent owner, int nodeId, ITrackEffectAutoChange effectOption)
	{
		if (NodeTrackEffect.LineTrace == null)
		{
			NodeTrackEffect.InitLineTrace();
		}
		this.NodeId = nodeId;
		this.Owner = owner;
		this.TrackEffectEnterRange = (double)effectOption.EnterRange;
		this.TrackEffectLeaveRange = (double)effectOption.LeaveRange;
		this.HitLocation = Vector.Create();
	}

	// Token: 0x0600E470 RID: 58480 RVA: 0x0035AEF2 File Offset: 0x003590F2
	public void Destroy()
	{
		this.End();
		this.Owner = null;
	}

	// Token: 0x0600E471 RID: 58481 RVA: 0x0035AF01 File Offset: 0x00359101
	private static void InitLineTrace()
	{
		UTraceLineElement utraceLineElement = new UTraceLineElement();
		utraceLineElement.WorldContextObject = GlobalData.World;
		utraceLineElement.bIsSingle = true;
		utraceLineElement.SetTraceTypeQuery(KuroTraceTypeQuery.Water);
		NodeTrackEffect.LineTrace = utraceLineElement;
	}

	// Token: 0x0600E472 RID: 58482 RVA: 0x0035AF2C File Offset: 0x0035912C
	public void OnBattleViewActive()
	{
		double trackDistance = this.Owner.GetTrackDistance(this.NodeId);
		this.IsInEnterRange = (trackDistance < this.TrackEffectEnterRange);
		NodeTrackEffect.SetTrackEffectActive(this.LongLightBeam, !this.IsInEnterRange);
		NodeTrackEffect.SetTrackEffectActive(this.ShortLightBeam, this.IsInEnterRange);
		if (this.Timer == null || !this.Timer.IsPause())
		{
			return;
		}
		this.Timer.Resume();
	}

	// Token: 0x0600E473 RID: 58483 RVA: 0x0035AFA1 File Offset: 0x003591A1
	public void OnBattleViewHide()
	{
		this.SetTrackedEffectHidden();
		if (this.Timer == null || this.Timer.IsPause())
		{
			return;
		}
		this.Timer.Pause();
	}

	// Token: 0x0600E474 RID: 58484 RVA: 0x0035AFCC File Offset: 0x003591CC
	public unsafe void Start()
	{
		this.IsInEnterRange = false;
		this.LoadedCompleteCount = 0;
		string trackEffectPath = QuestNewConfig.Instance.GetTrackEffectPath(ETrackEffect.LongLightBeam.ToEnumString());
		if (StringUtils.IsEmpty(trackEffectPath))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GeneralLogicTree;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "找不到追踪特效配置路径";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("trackEffectType", ETrackEffect.LongLightBeam);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		string trackEffectPath2 = QuestNewConfig.Instance.GetTrackEffectPath(ETrackEffect.ShortLightBeam.ToEnumString());
		if (StringUtils.IsEmpty(trackEffectPath2))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GeneralLogicTree;
			ELogAuthor author2 = ELogAuthor.YSQ;
			string message2 = "找不到追踪特效配置路径";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("trackEffectType", ETrackEffect.ShortLightBeam);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		Vector nodeTrackPosition = this.Owner.GetNodeTrackPosition(this.NodeId);
		if (nodeTrackPosition == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.GeneralLogicTree;
			ELogAuthor author3 = ELogAuthor.YSQ;
			string message3 = "找不到追踪位置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("trackEffectType", ETrackEffect.ShortLightBeam);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("nodeId", this.NodeId);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.LongLightBeam = this.CreateTrackEffect(ETrackEffect.LongLightBeam, trackEffectPath, nodeTrackPosition);
		this.ShortLightBeam = this.CreateTrackEffect(ETrackEffect.ShortLightBeam, trackEffectPath2, nodeTrackPosition);
	}

	// Token: 0x0600E475 RID: 58485 RVA: 0x0035B114 File Offset: 0x00359314
	public void End()
	{
		if (this.Timer != null && TimerSystem.Instance.Has(this.Timer))
		{
			TimerSystem.Instance.Remove(this.Timer);
		}
		this.Timer = null;
		EffectSystem instance = EffectSystem.Instance;
		if (this.LongLightBeam != 0 && instance.IsValid(this.LongLightBeam))
		{
			instance.StopEffectById(this.LongLightBeam, "[TrackEffectExpress.End]", true, null);
		}
		this.LongLightBeam = 0;
		if (this.ShortLightBeam != 0 && instance.IsValid(this.ShortLightBeam))
		{
			instance.StopEffectById(this.ShortLightBeam, "[TrackEffectExpress.End]", true, null);
		}
		this.ShortLightBeam = 0;
	}

	// Token: 0x0600E476 RID: 58486 RVA: 0x0035B1CC File Offset: 0x003593CC
	[NullableContext(1)]
	private int CreateTrackEffect(ETrackEffect effectType, string effectPath, IVector trackPosition)
	{
		UTraceLineElement lineTrace = NodeTrackEffect.LineTrace;
		TraceElementCommon.Instance.SetStartLocation(lineTrace, trackPosition);
		lineTrace.SetEndLocation(trackPosition.X, trackPosition.Y, trackPosition.Z + 1000.0);
		this.HitLocation.FromUeVector(trackPosition);
		bool flag = TraceElementCommon.Instance.LineTrace(lineTrace, "TrackedMark_CreateTrackEffect");
		UKuroHitResult hitResult = lineTrace.HitResult;
		if (flag && hitResult.bBlockingHit)
		{
			this.HitLocation.Z = (double)hitResult.LocationZ_Array.Get(0);
		}
		this.HitLocation.Z -= 5.0;
		EffectSystem instance = EffectSystem.Instance;
		UObject world = GlobalData.World;
		FVectorDouble fvectorDouble = this.HitLocation.ToUeVector(false);
		FTransformDouble? ftransformDouble = new FTransformDouble?(new FTransformDouble(ref Rotator.ZeroRotator, ref fvectorDouble, ref Vector.OneVector));
		return instance.SpawnEffect(world, ftransformDouble, effectPath, "[TrackEffectExpress.CreateTrackEffect]", null, EEffectType.Scene, null, delegate(ELoadEffectResult result, int handle)
		{
			if (result != ELoadEffectResult.Success)
			{
				return;
			}
			this.OnEffectLoadComplete(effectType, handle);
		}, null, false, false);
	}

	// Token: 0x0600E477 RID: 58487 RVA: 0x0035B2D0 File Offset: 0x003594D0
	private void OnEffectLoadComplete(ETrackEffect effectType, int handle)
	{
		EffectSystem.Instance.RegisterCustomCheckOwnerFunc(handle, (int _) => this.Owner != null);
		double trackDistance = this.Owner.GetTrackDistance(this.NodeId);
		this.IsInEnterRange = (trackDistance < this.TrackEffectEnterRange);
		bool bActive = (effectType == ETrackEffect.LongLightBeam) ? (!this.IsInEnterRange) : this.IsInEnterRange;
		NodeTrackEffect.SetTrackEffectActive(handle, bActive);
		this.LoadedCompleteCount++;
		if (this.LoadedCompleteCount != 2)
		{
			return;
		}
		this.Timer = TimerSystem.Instance.Forever(new TTimerAction(this.UpdateTrackEffect), 1000f, 1f, null, null, true);
	}

	// Token: 0x0600E478 RID: 58488 RVA: 0x0035B374 File Offset: 0x00359574
	private void UpdateTrackEffect(float _)
	{
		if (this.IsOccupied)
		{
			this.SetTrackedEffectHidden();
			return;
		}
		double trackDistance = this.Owner.GetTrackDistance(this.NodeId);
		if (trackDistance <= 0.0)
		{
			this.SetTrackedEffectHidden();
			return;
		}
		if (!this.IsInEnterRange && trackDistance < this.TrackEffectEnterRange)
		{
			this.IsInEnterRange = true;
			NodeTrackEffect.SetTrackEffectActive(this.LongLightBeam, false);
			NodeTrackEffect.SetTrackEffectActive(this.ShortLightBeam, true);
		}
		if (this.IsInEnterRange && trackDistance >= this.TrackEffectLeaveRange)
		{
			this.IsInEnterRange = false;
			NodeTrackEffect.SetTrackEffectActive(this.LongLightBeam, true);
			NodeTrackEffect.SetTrackEffectActive(this.ShortLightBeam, false);
		}
	}

	// Token: 0x0600E479 RID: 58489 RVA: 0x0035B415 File Offset: 0x00359615
	private void SetTrackedEffectHidden()
	{
		NodeTrackEffect.SetTrackEffectActive(this.LongLightBeam, false);
		NodeTrackEffect.SetTrackEffectActive(this.ShortLightBeam, false);
	}

	// Token: 0x0600E47A RID: 58490 RVA: 0x0035B42F File Offset: 0x0035962F
	private static void SetTrackEffectActive(int handle, bool bActive)
	{
		EffectSystem.Instance.SetEffectHidden(handle, !bActive, null, false);
	}

	// Token: 0x0600E47B RID: 58491 RVA: 0x0035B442 File Offset: 0x00359642
	public void OnExpressOccupied()
	{
		this.IsOccupied = true;
	}

	// Token: 0x0600E47C RID: 58492 RVA: 0x0035B44B File Offset: 0x0035964B
	public void OnExpressOccupationRelease()
	{
		this.IsOccupied = false;
	}

	// Token: 0x0600E47D RID: 58493 RVA: 0x0035B454 File Offset: 0x00359654
	public static void CreateStaticDefaultValue()
	{
		NodeTrackEffect.LineTrace = null;
	}

	// Token: 0x0600E47E RID: 58494 RVA: 0x0035B45C File Offset: 0x0035965C
	public static void ResetStaticDefaultValue()
	{
		NodeTrackEffect.LineTrace = null;
	}

	// Token: 0x0400694D RID: 26957
	[Nullable(1)]
	private const string PROFILE_KEY = "TrackedMark_CreateTrackEffect";

	// Token: 0x0400694E RID: 26958
	private const int OFFSET_Z = 1000;

	// Token: 0x0400694F RID: 26959
	private static UTraceLineElement LineTrace;

	// Token: 0x04006950 RID: 26960
	private BehaviorTreeExpressionComponent Owner;

	// Token: 0x04006951 RID: 26961
	private readonly int NodeId;

	// Token: 0x04006952 RID: 26962
	private int LongLightBeam;

	// Token: 0x04006953 RID: 26963
	private int ShortLightBeam;

	// Token: 0x04006954 RID: 26964
	private readonly double TrackEffectEnterRange;

	// Token: 0x04006955 RID: 26965
	private readonly double TrackEffectLeaveRange;

	// Token: 0x04006956 RID: 26966
	private readonly Vector HitLocation;

	// Token: 0x04006957 RID: 26967
	private TimerHandle Timer;

	// Token: 0x04006958 RID: 26968
	private int LoadedCompleteCount;

	// Token: 0x04006959 RID: 26969
	private bool IsInEnterRange;

	// Token: 0x0400695A RID: 26970
	private bool IsOccupied;
}
