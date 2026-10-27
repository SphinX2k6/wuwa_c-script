using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.LevelGamePlay.AimLine;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.NewWorld.SceneItem.Model;
using UnrealEngine;

// Token: 0x02003077 RID: 12407
[NullableContext(1)]
[Nullable(0)]
public class CharacterLevelShootComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x0601A791 RID: 108433 RVA: 0x00712198 File Offset: 0x00710398
	static CharacterLevelShootComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterLevelShootComponent.CreateStaticDefaultValue), new Action(CharacterLevelShootComponent.ResetStaticDefaultValue));
	}

	// Token: 0x1700246E RID: 9326
	// (get) Token: 0x0601A792 RID: 108434 RVA: 0x007121C1 File Offset: 0x007103C1
	private static List<Vector> VectorPool
	{
		get
		{
			return CharacterLevelShootComponent._vectorPool;
		}
	}

	// Token: 0x1700246F RID: 9327
	// (get) Token: 0x0601A793 RID: 108435 RVA: 0x007121C8 File Offset: 0x007103C8
	private static List<List<Vector>> VectorArrayPool
	{
		get
		{
			return CharacterLevelShootComponent._vectorArrayPool;
		}
	}

	// Token: 0x0601A794 RID: 108436 RVA: 0x007121D0 File Offset: 0x007103D0
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

	// Token: 0x0601A795 RID: 108437 RVA: 0x0071224D File Offset: 0x0071044D
	protected override void OnActivate()
	{
		this.InitBulletTraceElement();
		this.OnArmFireBulletTask = this.TagComp.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.瞄准模式.射击通知"]), new BaseTagComponent.TTagSwitchedCallback(this.OnArmShoot), null);
	}

	// Token: 0x0601A796 RID: 108438 RVA: 0x00712288 File Offset: 0x00710488
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

	// Token: 0x0601A797 RID: 108439 RVA: 0x007122F4 File Offset: 0x007104F4
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

	// Token: 0x0601A798 RID: 108440 RVA: 0x00712352 File Offset: 0x00710552
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

	// Token: 0x0601A799 RID: 108441 RVA: 0x00712391 File Offset: 0x00710591
	public void OnExitAimShoot()
	{
		if (!this.IsActive)
		{
			return;
		}
		this.IsActive = false;
		LevelAimLineController.Instance.StopEffect();
	}

	// Token: 0x0601A79A RID: 108442 RVA: 0x007123AE File Offset: 0x007105AE
	private void OnArmShoot(int tagId, bool tagExist)
	{
	}

	// Token: 0x0601A79B RID: 108443 RVA: 0x007123B0 File Offset: 0x007105B0
	protected override void OnTick(float delta)
	{
		if (!this.IsActive)
		{
			return;
		}
		this.UpdateAimInstructionSpline();
	}

	// Token: 0x0601A79C RID: 108444 RVA: 0x007123C1 File Offset: 0x007105C1
	public Vector GetEndPointPosition(Vector start, Vector dir)
	{
		dir.Multiply((double)this.TrackLength, this.EndTrackLocation);
		start.Addition(this.EndTrackLocation, this.EndTrackLocation);
		return this.EndTrackLocation;
	}

	// Token: 0x0601A79D RID: 108445 RVA: 0x007123F0 File Offset: 0x007105F0
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

	// Token: 0x0601A79E RID: 108446 RVA: 0x0071242D File Offset: 0x0071062D
	private void ReleaseVector(Vector value)
	{
		value.Set(0.0, 0.0, 0.0);
		CharacterLevelShootComponent.VectorPool.Add(value);
	}

	// Token: 0x0601A79F RID: 108447 RVA: 0x0071245B File Offset: 0x0071065B
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

	// Token: 0x0601A7A0 RID: 108448 RVA: 0x00712498 File Offset: 0x00710698
	private void ReleaseVectorArray(List<Vector> value)
	{
		foreach (Vector value2 in value)
		{
			this.ReleaseVector(value2);
		}
		value.Clear();
		CharacterLevelShootComponent.VectorArrayPool.Add(value);
	}

	// Token: 0x0601A7A1 RID: 108449 RVA: 0x007124F8 File Offset: 0x007106F8
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

	// Token: 0x0601A7A2 RID: 108450 RVA: 0x007129EC File Offset: 0x00710BEC
	public static void CreateStaticDefaultValue()
	{
		CharacterLevelShootComponent._vectorPool = new List<Vector>();
		CharacterLevelShootComponent._vectorArrayPool = new List<List<Vector>>();
	}

	// Token: 0x0601A7A3 RID: 108451 RVA: 0x00712A02 File Offset: 0x00710C02
	public static void ResetStaticDefaultValue()
	{
		CharacterLevelShootComponent._vectorPool = null;
		CharacterLevelShootComponent._vectorArrayPool = null;
	}

	// Token: 0x0601A7A4 RID: 108452 RVA: 0x00712A10 File Offset: 0x00710C10
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterLevelShootComponent characterLevelShootComponent = (CharacterLevelShootComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (characterLevelShootComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComp"))
		{
			if (characterLevelShootComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsActive"))
		{
			this.IsActive = characterLevelShootComponent.IsActive;
		}
		if (base.CanResetComponentProperty("BulletTraceElement"))
		{
			if (characterLevelShootComponent.BulletTraceElement == null)
			{
				this.BulletTraceElement = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceLineElement>(this.BulletTraceElement), "BulletTraceElement"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SplinePoints"))
		{
			if (characterLevelShootComponent.SplinePoints == null)
			{
				this.SplinePoints = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<Vector>>(this.SplinePoints), "SplinePoints"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("StartTrackLocation"))
		{
			if (characterLevelShootComponent.StartTrackLocation == null)
			{
				this.StartTrackLocation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.StartTrackLocation), "StartTrackLocation"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TrackDir"))
		{
			if (characterLevelShootComponent.TrackDir == null)
			{
				this.TrackDir = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TrackDir), "TrackDir"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("EndTrackLocation"))
		{
			if (characterLevelShootComponent.EndTrackLocation == null)
			{
				this.EndTrackLocation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.EndTrackLocation), "EndTrackLocation"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TempVector"))
		{
			if (characterLevelShootComponent.TempVector == null)
			{
				this.TempVector = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TempVector), "TempVector"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("HitReboundInfoMap"))
		{
			if (characterLevelShootComponent.HitReboundInfoMap == null)
			{
				this.HitReboundInfoMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, List<Vector>>>(this.HitReboundInfoMap), "HitReboundInfoMap"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("OnArmFireBulletTask"))
		{
			if (characterLevelShootComponent.OnArmFireBulletTask == null)
			{
				this.OnArmFireBulletTask = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.OnArmFireBulletTask), "OnArmFireBulletTask"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("FireVector"))
		{
			if (characterLevelShootComponent.FireVector == null)
			{
				this.FireVector = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.FireVector), "FireVector"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400CB15 RID: 51989
	private const string PROFILE_BULLECT_TRACK = "CharacterLevelShootComponent_PreCalculateBulletTrack";

	// Token: 0x0400CB16 RID: 51990
	private const string DEMO_LEVEL_AIM_LINE_EFFECT_PATH = "/Game/Aki/Effect/EffectGroup/BigWorld/DA_Fx_Group_SignalSpline.DA_Fx_Group_SignalSpline";

	// Token: 0x0400CB17 RID: 51991
	private const float REFLECT_START_OFFSET = 0.1f;

	// Token: 0x0400CB18 RID: 51992
	private const string BULLET_FIRE_BONE_NAME = "WeaponProp01_2";

	// Token: 0x0400CB19 RID: 51993
	private const int MAX_HIT_COUNT_ON_ONE = 10;

	// Token: 0x0400CB1A RID: 51994
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400CB1B RID: 51995
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400CB1C RID: 51996
	private readonly int TrackLength = 5000;

	// Token: 0x0400CB1D RID: 51997
	[StaticVariableRuleIgnore]
	private static readonly Vector FireBulletPositionOffset = Vector.ForwardVectorProxy;

	// Token: 0x0400CB1E RID: 51998
	private bool IsActive;

	// Token: 0x0400CB1F RID: 51999
	[Nullable(2)]
	private UTraceLineElement BulletTraceElement;

	// Token: 0x0400CB20 RID: 52000
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<Vector> SplinePoints;

	// Token: 0x0400CB21 RID: 52001
	[Nullable(2)]
	private Vector StartTrackLocation;

	// Token: 0x0400CB22 RID: 52002
	[Nullable(2)]
	private Vector TrackDir;

	// Token: 0x0400CB23 RID: 52003
	[Nullable(2)]
	private Vector EndTrackLocation;

	// Token: 0x0400CB24 RID: 52004
	[Nullable(2)]
	private Vector TempVector;

	// Token: 0x0400CB25 RID: 52005
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<int, List<Vector>> HitReboundInfoMap;

	// Token: 0x0400CB26 RID: 52006
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<Vector> _vectorPool;

	// Token: 0x0400CB27 RID: 52007
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static List<List<Vector>> _vectorArrayPool;

	// Token: 0x0400CB28 RID: 52008
	[Nullable(2)]
	private ITagTask OnArmFireBulletTask;

	// Token: 0x0400CB29 RID: 52009
	[Nullable(2)]
	private Vector FireVector;
}
