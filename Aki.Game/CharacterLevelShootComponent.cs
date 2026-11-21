using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.LevelGamePlay.AimLine;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.NewWorld.SceneItem.Model;
using UnrealEngine;

// Token: 0x020025CE RID: 9678
[NullableContext(1)]
[Nullable(0)]
public class CharacterLevelShootComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x06018154 RID: 98644 RVA: 0x00738725 File Offset: 0x00736925
	static CharacterLevelShootComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterLevelShootComponent.CreateStaticDefaultValue), new Action(CharacterLevelShootComponent.ResetStaticDefaultValue));
	}

	// Token: 0x170025AA RID: 9642
	// (get) Token: 0x06018155 RID: 98645 RVA: 0x0073874E File Offset: 0x0073694E
	private static List<Vector> VectorPool
	{
		get
		{
			return CharacterLevelShootComponent._vectorPool;
		}
	}

	// Token: 0x170025AB RID: 9643
	// (get) Token: 0x06018156 RID: 98646 RVA: 0x00738755 File Offset: 0x00736955
	private static List<List<Vector>> VectorArrayPool
	{
		get
		{
			return CharacterLevelShootComponent._vectorArrayPool;
		}
	}

	// Token: 0x06018157 RID: 98647 RVA: 0x0073875C File Offset: 0x0073695C
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
		this.SplinePoints = new List<Vector>();
		this.StartTrackLocation = Vector.Create();
		this.TrackDir = Vector.Create();
		this.EndTrackLocation = Vector.Create();
		this.TempVector = Vector.Create();
		this.FireVector = Vector.Create();
		this.HitReboundInfoMap = new Dictionary<int, List<Vector>>();
		return true;
	}

	// Token: 0x06018158 RID: 98648 RVA: 0x007387D9 File Offset: 0x007369D9
	protected override void OnActivate()
	{
		this.InitBulletTraceElement();
		this.OnArmFireBulletTask = this.TagComp.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.瞄准模式.射击通知"]), new BaseTagComponent.TTagSwitchedCallback(this.OnArmShoot), null);
	}

	// Token: 0x06018159 RID: 98649 RVA: 0x00738814 File Offset: 0x00736A14
	public override bool End()
	{
		this.ActorComp = null;
		this.TagComp = null;
		this.BulletTraceElement = null;
		this.SplinePoints = null;
		this.StartTrackLocation = null;
		this.TrackDir = null;
		this.EndTrackLocation = null;
		this.TempVector = null;
		ITagTask onArmFireBulletTask = this.OnArmFireBulletTask;
		if (onArmFireBulletTask != null)
		{
			onArmFireBulletTask.EndTask();
		}
		this.OnArmFireBulletTask = null;
		this.FireVector = null;
		this.HitReboundInfoMap = null;
		return true;
	}

	// Token: 0x0601815A RID: 98650 RVA: 0x00738880 File Offset: 0x00736A80
	private void InitBulletTraceElement()
	{
		if (this.BulletTraceElement == null)
		{
			this.BulletTraceElement = new UTraceLineElement();
			this.BulletTraceElement.bIsSingle = true;
			this.BulletTraceElement.bIgnoreSelf = true;
			this.BulletTraceElement.SetTraceTypeQuery(KuroTraceTypeQuery.Visible);
		}
		this.BulletTraceElement.WorldContextObject = this.ActorComp.Owner;
	}

	// Token: 0x0601815B RID: 98651 RVA: 0x007388DE File Offset: 0x00736ADE
	public void OnEnterAimShoot()
	{
		if (!this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.显示射击轨迹"]))
		{
			return;
		}
		if (this.IsActive)
		{
			return;
		}
		this.IsActive = true;
		LevelAimLineController.Instance.PlayEffect("/Game/Aki/Effect/EffectGroup/BigWorld/DA_Fx_Group_SignalSpline.DA_Fx_Group_SignalSpline");
	}

	// Token: 0x0601815C RID: 98652 RVA: 0x0073891D File Offset: 0x00736B1D
	public void OnExitAimShoot()
	{
		if (!this.IsActive)
		{
			return;
		}
		this.IsActive = false;
		LevelAimLineController.Instance.StopEffect();
	}

	// Token: 0x0601815D RID: 98653 RVA: 0x0073893A File Offset: 0x00736B3A
	private void OnArmShoot(int tagId, bool tagExist)
	{
	}

	// Token: 0x0601815E RID: 98654 RVA: 0x0073893C File Offset: 0x00736B3C
	protected override void OnTick(float delta)
	{
		if (!this.IsActive)
		{
			return;
		}
		this.UpdateAimInstructionSpline();
	}

	// Token: 0x0601815F RID: 98655 RVA: 0x0073894D File Offset: 0x00736B4D
	public Vector GetEndPointPosition(Vector start, Vector dir)
	{
		dir.Multiply((double)this.TrackLength, this.EndTrackLocation);
		start.Addition(this.EndTrackLocation, this.EndTrackLocation);
		return this.EndTrackLocation;
	}

	// Token: 0x06018160 RID: 98656 RVA: 0x0073897C File Offset: 0x00736B7C
	private Vector GetVector()
	{
		if (CharacterLevelShootComponent.VectorPool.Count < 1)
		{
			return Vector.Create();
		}
		List<Vector> vectorPool = CharacterLevelShootComponent.VectorPool;
		Vector result = vectorPool[vectorPool.Count - 1];
		CharacterLevelShootComponent.VectorPool.RemoveAt(CharacterLevelShootComponent.VectorPool.Count - 1);
		return result;
	}

	// Token: 0x06018161 RID: 98657 RVA: 0x007389B9 File Offset: 0x00736BB9
	private void ReleaseVector(Vector value)
	{
		value.Set(0.0, 0.0, 0.0);
		CharacterLevelShootComponent.VectorPool.Add(value);
	}

	// Token: 0x06018162 RID: 98658 RVA: 0x007389E7 File Offset: 0x00736BE7
	private List<Vector> GetVectorArray()
	{
		if (CharacterLevelShootComponent.VectorArrayPool.Count < 1)
		{
			return new List<Vector>();
		}
		List<List<Vector>> vectorArrayPool = CharacterLevelShootComponent.VectorArrayPool;
		List<Vector> result = vectorArrayPool[vectorArrayPool.Count - 1];
		CharacterLevelShootComponent.VectorArrayPool.RemoveAt(CharacterLevelShootComponent.VectorArrayPool.Count - 1);
		return result;
	}

	// Token: 0x06018163 RID: 98659 RVA: 0x00738A24 File Offset: 0x00736C24
	private void ReleaseVectorArray(List<Vector> value)
	{
		foreach (Vector value2 in value)
		{
			this.ReleaseVector(value2);
		}
		value.Clear();
		CharacterLevelShootComponent.VectorArrayPool.Add(value);
	}

	// Token: 0x06018164 RID: 98660 RVA: 0x00738A84 File Offset: 0x00736C84
	private void UpdateAimInstructionSpline()
	{
		FTransformDouble ftransformDouble = this.ActorComp.SkeletalMesh.D_GetSocketTransform(new FName("WeaponProp01_2"), ERelativeTransformSpace.RTS_World);
		APlayerCameraManager characterCameraManager = Global.CharacterCameraManager;
		Vector trackDir = this.TrackDir;
		FVector actorForwardVector = characterCameraManager.GetActorForwardVector();
		trackDir.FromUeVector(actorForwardVector);
		this.TrackDir.Multiply(CharacterLevelShootComponent.FireBulletPositionOffset, this.TempVector);
		Vector startTrackLocation = this.StartTrackLocation;
		FVectorDouble fvectorDouble = characterCameraManager.D_GetCameraLocation();
		startTrackLocation.FromUeVector(fvectorDouble);
		this.StartTrackLocation.Addition(this.TempVector, this.StartTrackLocation);
		this.EndTrackLocation = this.GetEndPointPosition(this.StartTrackLocation, this.TrackDir);
		TraceElementCommon.Instance.SetStartLocation(this.BulletTraceElement, this.StartTrackLocation);
		TraceElementCommon.Instance.SetEndLocation(this.BulletTraceElement, this.EndTrackLocation);
		Vector startTrackLocation2 = this.StartTrackLocation;
		fvectorDouble = ftransformDouble.GetLocation();
		startTrackLocation2.FromUeVector(fvectorDouble);
		this.SplinePoints.Add(this.StartTrackLocation);
		bool flag = TraceElementCommon.Instance.LineTrace(this.BulletTraceElement, "CharacterLevelShootComponent_PreCalculateBulletTrack");
		bool flag2 = false;
		bool flag3 = false;
		if (flag)
		{
			UKuroHitResult hitResult = this.BulletTraceElement.HitResult;
			while (hitResult.GetHitCount() > 0)
			{
				Vector vector = this.GetVector();
				TraceElementCommon.Instance.GetImpactPoint(hitResult, 0, vector);
				this.SplinePoints.Add(vector);
				this.SplinePoints[this.SplinePoints.Count - 1].Subtraction(this.SplinePoints[this.SplinePoints.Count - 2], this.TrackDir);
				this.TrackDir.Normalize(9.99999993922529E-09);
				TWeakObjectPtr<AActor> weak = hitResult.Actors.Get(0);
				EntityHandle entityByActor = SceneInteractionModel.Instance.GetEntityByActor(weak, false);
				if (entityByActor == null)
				{
					flag2 = true;
					break;
				}
				SceneItemReboundComponent component = entityByActor.Entity.GetComponent<SceneItemReboundComponent>();
				if (component == null)
				{
					flag2 = true;
					break;
				}
				if (this.HitReboundInfoMap.ContainsKey(entityByActor.Id))
				{
					List<Vector> list = this.HitReboundInfoMap[entityByActor.Id];
					for (int i = 0; i < list.Count; i += 2)
					{
						Vector inB = list[i];
						Vector inB2 = list[i + 1];
						if (vector.Equals(inB, 9.999999747378752E-05) && this.TrackDir.Equals(inB2, 9.999999747378752E-05))
						{
							flag3 = true;
							break;
						}
					}
					if (flag3)
					{
						break;
					}
					list.Add(vector);
					Vector vector2 = this.GetVector();
					vector2.DeepCopy(this.TrackDir);
					list.Add(vector2);
					if (list.Count > 10)
					{
						flag3 = true;
						break;
					}
				}
				else
				{
					List<Vector> vectorArray = this.GetVectorArray();
					vectorArray.Add(vector);
					Vector vector3 = this.GetVector();
					vector3.DeepCopy(this.TrackDir);
					vectorArray.Add(vector3);
					this.HitReboundInfoMap[entityByActor.Id] = vectorArray;
				}
				if (!component.CalculateReflectDir(this.TrackDir, this.TrackDir, weak, true))
				{
					flag2 = true;
					break;
				}
				this.TrackDir.Multiply(0.10000000149011612, this.TempVector);
				vector.Addition(this.TempVector, this.TempVector);
				this.EndTrackLocation = this.GetEndPointPosition(vector, this.TrackDir);
				TraceElementCommon.Instance.SetStartLocation(this.BulletTraceElement, this.TempVector);
				TraceElementCommon.Instance.SetEndLocation(this.BulletTraceElement, this.EndTrackLocation);
				TraceElementCommon.Instance.LineTrace(this.BulletTraceElement, "CharacterLevelShootComponent_PreCalculateBulletTrack");
			}
		}
		int num = -1;
		if (!flag2 && !flag3)
		{
			num = this.SplinePoints.Count;
			this.SplinePoints.Add(this.EndTrackLocation);
		}
		if (this.SplinePoints.Count > 1)
		{
			this.SplinePoints[1].Subtraction(this.SplinePoints[0], this.FireVector);
			this.FireVector.Normalize(9.99999993922529E-09);
			LevelAimLineController.Instance.UpdatePoints(this.SplinePoints, EAimLineType.Line);
		}
		else
		{
			Log.Instance.Warn(ELogModule.Level, ELogAuthor.WLJ, "[LevelShoot]Length of SplinePoints less then 2", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		if (num > -1 && num < this.SplinePoints.Count)
		{
			this.SplinePoints.RemoveAt(num);
		}
		for (int j = 1; j < this.SplinePoints.Count; j++)
		{
			this.ReleaseVector(this.SplinePoints[j]);
		}
		foreach (List<Vector> value in this.HitReboundInfoMap.Values)
		{
			this.ReleaseVectorArray(value);
		}
		this.SplinePoints.Clear();
		this.HitReboundInfoMap.Clear();
	}

	// Token: 0x06018165 RID: 98661 RVA: 0x00738F78 File Offset: 0x00737178
	public static void CreateStaticDefaultValue()
	{
		CharacterLevelShootComponent._vectorPool = new List<Vector>();
		CharacterLevelShootComponent._vectorArrayPool = new List<List<Vector>>();
	}

	// Token: 0x06018166 RID: 98662 RVA: 0x00738F8E File Offset: 0x0073718E
	public static void ResetStaticDefaultValue()
	{
		CharacterLevelShootComponent._vectorPool = null;
		CharacterLevelShootComponent._vectorArrayPool = null;
	}

	// Token: 0x06018167 RID: 98663 RVA: 0x00738F9C File Offset: 0x0073719C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterLevelShootComponent characterLevelShootComponent = (CharacterLevelShootComponent)componentTemplate;
		if (characterLevelShootComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (characterLevelShootComponent.TagComp == null)
		{
			this.TagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
		{
			return false;
		}
		this.IsActive = characterLevelShootComponent.IsActive;
		if (characterLevelShootComponent.BulletTraceElement == null)
		{
			this.BulletTraceElement = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BulletTraceElement), "BulletTraceElement"))
		{
			return false;
		}
		if (characterLevelShootComponent.SplinePoints == null)
		{
			this.SplinePoints = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SplinePoints), "SplinePoints"))
		{
			return false;
		}
		if (characterLevelShootComponent.StartTrackLocation == null)
		{
			this.StartTrackLocation = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StartTrackLocation), "StartTrackLocation"))
		{
			return false;
		}
		if (characterLevelShootComponent.TrackDir == null)
		{
			this.TrackDir = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TrackDir), "TrackDir"))
		{
			return false;
		}
		if (characterLevelShootComponent.EndTrackLocation == null)
		{
			this.EndTrackLocation = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.EndTrackLocation), "EndTrackLocation"))
		{
			return false;
		}
		if (characterLevelShootComponent.TempVector == null)
		{
			this.TempVector = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector), "TempVector"))
		{
			return false;
		}
		if (characterLevelShootComponent.HitReboundInfoMap == null)
		{
			this.HitReboundInfoMap = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.HitReboundInfoMap), "HitReboundInfoMap"))
		{
			return false;
		}
		if (characterLevelShootComponent.OnArmFireBulletTask == null)
		{
			this.OnArmFireBulletTask = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnArmFireBulletTask), "OnArmFireBulletTask"))
		{
			return false;
		}
		if (characterLevelShootComponent.FireVector == null)
		{
			this.FireVector = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FireVector), "FireVector"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x170025AC RID: 9644
	// (get) Token: 0x06018168 RID: 98664 RVA: 0x007391A1 File Offset: 0x007373A1
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025AD RID: 9645
	// (get) Token: 0x06018169 RID: 98665 RVA: 0x007391A4 File Offset: 0x007373A4
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400CEF0 RID: 52976
	private const string PROFILE_BULLECT_TRACK = "CharacterLevelShootComponent_PreCalculateBulletTrack";

	// Token: 0x0400CEF1 RID: 52977
	private const string DEMO_LEVEL_AIM_LINE_EFFECT_PATH = "/Game/Aki/Effect/EffectGroup/BigWorld/DA_Fx_Group_SignalSpline.DA_Fx_Group_SignalSpline";

	// Token: 0x0400CEF2 RID: 52978
	private const float REFLECT_START_OFFSET = 0.1f;

	// Token: 0x0400CEF3 RID: 52979
	private const string BULLET_FIRE_BONE_NAME = "WeaponProp01_2";

	// Token: 0x0400CEF4 RID: 52980
	private const int MAX_HIT_COUNT_ON_ONE = 10;

	// Token: 0x0400CEF5 RID: 52981
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400CEF6 RID: 52982
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400CEF7 RID: 52983
	private readonly int TrackLength = 5000;

	// Token: 0x0400CEF8 RID: 52984
	[StaticVariableRuleIgnore]
	private static readonly Vector FireBulletPositionOffset = Vector.ForwardVectorProxy;

	// Token: 0x0400CEF9 RID: 52985
	private bool IsActive;

	// Token: 0x0400CEFA RID: 52986
	[Nullable(2)]
	private UTraceLineElement BulletTraceElement;

	// Token: 0x0400CEFB RID: 52987
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<Vector> SplinePoints;

	// Token: 0x0400CEFC RID: 52988
	[Nullable(2)]
	private Vector StartTrackLocation;

	// Token: 0x0400CEFD RID: 52989
	[Nullable(2)]
	private Vector TrackDir;

	// Token: 0x0400CEFE RID: 52990
	[Nullable(2)]
	private Vector EndTrackLocation;

	// Token: 0x0400CEFF RID: 52991
	[Nullable(2)]
	private Vector TempVector;

	// Token: 0x0400CF00 RID: 52992
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<int, List<Vector>> HitReboundInfoMap;

	// Token: 0x0400CF01 RID: 52993
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<Vector> _vectorPool;

	// Token: 0x0400CF02 RID: 52994
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static List<List<Vector>> _vectorArrayPool;

	// Token: 0x0400CF03 RID: 52995
	[Nullable(2)]
	private ITagTask OnArmFireBulletTask;

	// Token: 0x0400CF04 RID: 52996
	[Nullable(2)]
	private Vector FireVector;
}
