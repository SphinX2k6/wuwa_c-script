using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020026F7 RID: 9975
[NullableContext(1)]
[Nullable(0)]
public abstract class SpecialSkillAimingBase : SpecialSkillBase
{
	// Token: 0x170027AE RID: 10158
	// (get) Token: 0x06018F98 RID: 102296
	protected abstract int AimingTagId { get; }

	// Token: 0x170027AF RID: 10159
	// (get) Token: 0x06018F99 RID: 102297
	protected abstract EEventName SwitchLockTargetEventName { get; }

	// Token: 0x06018F9A RID: 102298 RVA: 0x0079941B File Offset: 0x0079761B
	protected SpecialSkillAimingBase(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x06018F9B RID: 102299 RVA: 0x0079945C File Offset: 0x0079765C
	public override void OnStart()
	{
		this.ActorComp = this.SpecialSkillComponent.Entity.GetComponent<CharacterActorComponent>();
		this.TagComp = this.SpecialSkillComponent.Entity.GetComponent<BaseTagComponent>();
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null && actorComp.IsAutonomousProxy)
		{
			this.LockOnTarget = new AimingLockOnInfo();
			BaseTagComponent tagComp = this.TagComp;
			this.TagTask = ((tagComp != null) ? tagComp.ListenForTagAddOrRemove(new int?(this.AimingTagId), delegate(int tagId, bool tagExist)
			{
				this.OnAimingTagChanged(tagExist);
			}, null) : null);
			this.OnAimingTagChanged(this.TagComp.HasTag(this.AimingTagId));
		}
	}

	// Token: 0x06018F9C RID: 102300 RVA: 0x007994FB File Offset: 0x007976FB
	public override void OnEnd()
	{
		this.ClearLockOnTarget();
		ITagTask tagTask = this.TagTask;
		if (tagTask != null)
		{
			tagTask.EndTask();
		}
		if (this.EnableLockOn)
		{
			this.EnableLockOn = false;
			this.OnAimingEnd();
		}
	}

	// Token: 0x06018F9D RID: 102301 RVA: 0x0079952C File Offset: 0x0079772C
	public override void OnTick(float delta)
	{
		if (!this.EnableLockOn)
		{
			return;
		}
		if (this.TimeCount == 0f)
		{
			this.LockOn();
		}
		this.TimeCount += delta;
		if (this.TimeCount > (float)this.GapTime)
		{
			this.TimeCount = 0f;
		}
	}

	// Token: 0x06018F9E RID: 102302 RVA: 0x0079957D File Offset: 0x0079777D
	protected virtual void OnAimingStart()
	{
	}

	// Token: 0x06018F9F RID: 102303 RVA: 0x0079957F File Offset: 0x0079777F
	protected virtual void OnAimingEnd()
	{
		this.TimeCount = 0f;
	}

	// Token: 0x06018FA0 RID: 102304
	protected abstract void DoOnTargetLocked(EntityHandle target, string socketName);

	// Token: 0x06018FA1 RID: 102305
	protected abstract void DoOnTargetUnlocked(EntityHandle target, string socketName);

	// Token: 0x06018FA2 RID: 102306
	protected abstract void LockOn();

	// Token: 0x06018FA3 RID: 102307 RVA: 0x0079958C File Offset: 0x0079778C
	protected void OnTargetLocked(EntityHandle target, string socketName)
	{
		this.DoOnTargetLocked(target, socketName);
	}

	// Token: 0x06018FA4 RID: 102308 RVA: 0x00799596 File Offset: 0x00797796
	protected void OnTargetUnlocked(EntityHandle target, string socketName)
	{
		this.DoOnTargetUnlocked(target, socketName);
	}

	// Token: 0x06018FA5 RID: 102309 RVA: 0x007995A0 File Offset: 0x007977A0
	private void OnAimingTagChanged(bool tagExist)
	{
		if (this.EnableLockOn == tagExist)
		{
			return;
		}
		this.ClearLockOnTarget();
		this.EnableLockOn = tagExist;
		this.TimeCount = 0f;
		if (tagExist)
		{
			this.OnAimingStart();
			return;
		}
		this.OnAimingEnd();
	}

	// Token: 0x06018FA6 RID: 102310 RVA: 0x007995D4 File Offset: 0x007977D4
	private void ClearLockOnTarget()
	{
		AimingLockOnInfo lockOnTarget = this.LockOnTarget;
		if (((lockOnTarget != null) ? lockOnTarget.Target : null) == null)
		{
			return;
		}
		this.OnTargetUnlocked(this.LockOnTarget.Target, this.LockOnTarget.SocketName);
		this.LockOnTarget.Reset();
		EventSystem.Instance.Emit<EntityHandle, string>(this.SwitchLockTargetEventName, null, "");
	}

	// Token: 0x06018FA7 RID: 102311 RVA: 0x00799634 File Offset: 0x00797834
	protected void LockOnCircle(int distance, int radius)
	{
		this.LockOnShape(distance, delegate(Vector2D screenPos)
		{
			double num = screenPos.Size();
			if (num > (double)radius)
			{
				return double.MaxValue;
			}
			return num;
		});
	}

	// Token: 0x06018FA8 RID: 102312 RVA: 0x00799664 File Offset: 0x00797864
	protected void LockOnRect(int distance, int halfWidth, int halfHeight)
	{
		this.LockOnShape(distance, delegate(Vector2D screenPos)
		{
			double num = Math.Abs(screenPos.X);
			double num2 = Math.Abs(screenPos.Y);
			if (num > (double)halfWidth || num2 > (double)halfHeight)
			{
				return double.MaxValue;
			}
			return screenPos.Size();
		});
	}

	// Token: 0x06018FA9 RID: 102313 RVA: 0x00799698 File Offset: 0x00797898
	private void LockOnShape(int distance, Func<Vector2D, double> getShapeScore)
	{
		List<EntityHandle> list = new List<EntityHandle>();
		CreatureModel.Instance.GetEntitiesInRange((float)distance, EEntityTypeQuery.Character, list, true, false);
		ECamp camp = this.ActorComp.Actor.Camp;
		AimingCandidate aimingCandidate = null;
		HashSet<EntityHandle> hashSet = new HashSet<EntityHandle>();
		foreach (EntityHandle entityHandle in list)
		{
			if (LockOnUtils.IsValidLockOnTarget(entityHandle, null, null, false))
			{
				WorldEntity entity = entityHandle.Entity;
				if (((entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null) != null)
				{
					BaseCharacterComponent component = entityHandle.Entity.GetComponent<BaseCharacterComponent>();
					if (component != null && CampUtils.GetCampRelationship(component.Actor.Camp, camp) == ERelation.Enemy)
					{
						CreatureDataComponent component2 = entityHandle.Entity.GetComponent<CreatureDataComponent>();
						if (((component2 != null) ? new EEntityType?(component2.GetEntityType()) : null).GetValueOrDefault() == EEntityType.Monster)
						{
							hashSet.Add(entityHandle);
							CharacterActorComponent component3 = entityHandle.Entity.GetComponent<CharacterActorComponent>();
							Dictionary<string, UPrimitiveComponent> dictionary = (component3 != null) ? component3.GetMapPartCollision() : null;
							if (component3 != null && component3.LockOnParts.Count > 0)
							{
								using (Dictionary<string, LockOnPart>.Enumerator enumerator2 = component3.LockOnParts.GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										KeyValuePair<string, LockOnPart> keyValuePair = enumerator2.Current;
										LockOnPart value = keyValuePair.Value;
										if (value.SoftLockValid)
										{
											AimingCandidate aimingCandidate2 = this.CheckLockOnPoint(entityHandle, "", value.BoneNameString, getShapeScore);
											if (aimingCandidate2 != null && (aimingCandidate == null || aimingCandidate2.Score < aimingCandidate.Score))
											{
												aimingCandidate = aimingCandidate2;
											}
										}
									}
									continue;
								}
							}
							if (dictionary != null && dictionary.Count > 0)
							{
								using (Dictionary<string, UPrimitiveComponent>.Enumerator enumerator3 = dictionary.GetEnumerator())
								{
									while (enumerator3.MoveNext())
									{
										KeyValuePair<string, UPrimitiveComponent> keyValuePair2 = enumerator3.Current;
										string key = keyValuePair2.Key;
										AimingCandidate aimingCandidate3 = this.CheckLockOnPoint(entityHandle, key, "", getShapeScore);
										if (aimingCandidate3 != null && (aimingCandidate == null || aimingCandidate3.Score < aimingCandidate.Score))
										{
											aimingCandidate = aimingCandidate3;
										}
									}
									continue;
								}
							}
							AimingCandidate aimingCandidate4 = this.CheckLockOnPoint(entityHandle, "", "", getShapeScore);
							if (aimingCandidate4 != null && (aimingCandidate == null || aimingCandidate4.Score < aimingCandidate.Score))
							{
								aimingCandidate = aimingCandidate4;
							}
						}
					}
				}
			}
		}
		EntityHandle entityHandle2 = (aimingCandidate != null) ? aimingCandidate.Handle : null;
		string text = ((aimingCandidate != null) ? aimingCandidate.SocketName : null) ?? "";
		if (aimingCandidate != null)
		{
			this.TmpActorLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
			AActor owner = aimingCandidate.Handle.Entity.GetComponent<BaseActorComponent>().Owner;
			AActor aactor = this.TraceDetectBlock(this.TmpActorLocation, aimingCandidate.TargetLocation, owner);
			if (aactor != null)
			{
				EntityHandle entityHandle3 = this.FindHandleByActor(aactor, hashSet);
				if (entityHandle3 != null)
				{
					entityHandle2 = entityHandle3;
					text = "";
				}
			}
		}
		if (entityHandle2 != this.LockOnTarget.Target || text != this.LockOnTarget.SocketName)
		{
			if (this.LockOnTarget.Target != null)
			{
				this.OnTargetUnlocked(this.LockOnTarget.Target, this.LockOnTarget.SocketName);
			}
			if (entityHandle2 != null)
			{
				this.OnTargetLocked(entityHandle2, text);
			}
			this.LockOnTarget.Target = entityHandle2;
			this.LockOnTarget.SocketName = text;
			EventSystem.Instance.Emit<EntityHandle, string>(this.SwitchLockTargetEventName, entityHandle2, text);
		}
	}

	// Token: 0x06018FAA RID: 102314 RVA: 0x00799A48 File Offset: 0x00797C48
	[return: Nullable(2)]
	protected unsafe AimingCandidate CheckLockOnPoint(EntityHandle handle, string partName, string socketName, Func<Vector2D, double> getShapeScore)
	{
		global::Vector lockOnPointLocation = this.GetLockOnPointLocation(handle, partName, socketName);
		if (lockOnPointLocation == null)
		{
			return null;
		}
		if (!HudUnitUtils.PositionUtil.ProjectWorldToScreen(lockOnPointLocation.ToUeVector(false), this.ScreenPos))
		{
			return null;
		}
		double num = getShapeScore(this.ScreenPos);
		if (num == 1.7976931348623157E+308)
		{
			return null;
		}
		WorldEntity entity = handle.Entity;
		AActor aactor;
		if (entity == null)
		{
			aactor = null;
		}
		else
		{
			BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
			aactor = ((component != null) ? component.Owner : null);
		}
		AActor aactor2 = aactor;
		if (aactor2 != null && aactor2.IsValid() && !aactor2.WasRecentlyPassVisibilityTest(0.1f))
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
			Entity entity2 = this.SpecialSkillComponent.Entity;
			string message = "SpecialSkillAimingBase.CheckLockOnPoint - Target not recently pass visibility test";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Target", handle.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Part", partName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Socket", socketName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ScreenX", this.ScreenPos.X);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("ScreenY", this.ScreenPos.Y);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("VisibilityTolerance", 0.1f);
			instance.Warn(flag, entity2, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			return null;
		}
		global::Vector targetLocation = global::Vector.Create(lockOnPointLocation);
		return new AimingCandidate
		{
			Handle = handle,
			SocketName = socketName,
			Score = num,
			TargetLocation = targetLocation
		};
	}

	// Token: 0x06018FAB RID: 102315 RVA: 0x00799BF4 File Offset: 0x00797DF4
	[return: Nullable(2)]
	private AActor TraceDetectBlock(global::Vector from, global::Vector to, [Nullable(2)] AActor targetActor)
	{
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp != null && tagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.索敌无视遮挡"]))
		{
			return null;
		}
		if (this.AimingLineTrace == null)
		{
			this.AimingLineTrace = UE.NewObject<UTraceLineElement>(null, null, EObjectFlags.RF_NoFlags);
			this.AimingLineTrace.bIsSingle = true;
			this.AimingLineTrace.bIgnoreSelf = true;
			this.AimingLineTrace.AddObjectTypeQuery(KuroObjectTypeQuery.PawnMonster);
		}
		UTraceLineElement aimingLineTrace = this.AimingLineTrace;
		aimingLineTrace.WorldContextObject = this.ActorComp.Owner;
		aimingLineTrace.SetDrawDebugTrace(EDrawDebugTrace.ForOneFrame);
		TraceElementCommon.Instance.SetStartLocation(aimingLineTrace, from);
		TraceElementCommon.Instance.SetEndLocation(aimingLineTrace, to);
		if (!TraceElementCommon.Instance.LineTrace(aimingLineTrace, "SpecialSkillAimingBase_TraceDetectBlock") || !aimingLineTrace.HitResult.bBlockingHit)
		{
			return null;
		}
		TWeakObjectPtr<AActor> weak = aimingLineTrace.HitResult.Actors.Get(0);
		AActor aactor = CreatureModel.Instance.GetEntityActorByChildActor(weak) ?? weak;
		if (aactor == targetActor)
		{
			return null;
		}
		return aactor;
	}

	// Token: 0x06018FAC RID: 102316 RVA: 0x00799CF4 File Offset: 0x00797EF4
	[return: Nullable(2)]
	private EntityHandle FindHandleByActor(AActor hitActor, HashSet<EntityHandle> validHandles)
	{
		foreach (EntityHandle entityHandle in validHandles)
		{
			WorldEntity entity = entityHandle.Entity;
			BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
			if (((baseActorComponent != null) ? baseActorComponent.Owner : null) == hitActor)
			{
				return entityHandle;
			}
		}
		return null;
	}

	// Token: 0x06018FAD RID: 102317 RVA: 0x00799D64 File Offset: 0x00797F64
	[return: Nullable(2)]
	private global::Vector GetLockOnPointLocation(EntityHandle handle, string partName, string socketName)
	{
		if (!string.IsNullOrEmpty(socketName))
		{
			this.GetBoneLocation(handle, socketName, this.TmpBoneLocation);
			return this.TmpBoneLocation;
		}
		if (!string.IsNullOrEmpty(partName))
		{
			WorldEntity entity = handle.Entity;
			CharacterActorComponent characterActorComponent = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
			if (characterActorComponent != null)
			{
				global::Vector tmpBoneLocation = this.TmpBoneLocation;
				FVectorDouble boneLocation = characterActorComponent.GetBoneLocation(partName);
				tmpBoneLocation.FromUeVector(boneLocation);
				return this.TmpBoneLocation;
			}
		}
		WorldEntity entity2 = handle.Entity;
		BaseActorComponent baseActorComponent = (entity2 != null) ? entity2.GetComponent<BaseActorComponent>() : null;
		if (baseActorComponent == null)
		{
			return null;
		}
		return baseActorComponent.ActorLocationProxy;
	}

	// Token: 0x06018FAE RID: 102318 RVA: 0x00799DE8 File Offset: 0x00797FE8
	protected void GetBoneLocation(EntityHandle target, string boneName, global::Vector @out)
	{
		if (target.Entity == null)
		{
			@out.Reset();
			return;
		}
		FTransformDouble? targetSocketTransform = SkillUtils.GetTargetSocketTransform(target.Entity, boneName, ERelativeTransformSpace.RTS_World, "瞄准特殊技能", ESocketTransformDefault.BaseActor);
		if (targetSocketTransform != null)
		{
			FVectorDouble location = targetSocketTransform.Value.GetLocation();
			@out.FromUeVector(location);
			return;
		}
		@out.Reset();
	}

	// Token: 0x0400D983 RID: 55683
	private const string PROFILE_KEY = "SpecialSkillAimingBase_TraceDetectBlock";

	// Token: 0x0400D984 RID: 55684
	protected readonly int GapTime = 200;

	// Token: 0x0400D985 RID: 55685
	protected readonly int Distance = 5000;

	// Token: 0x0400D986 RID: 55686
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D987 RID: 55687
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400D988 RID: 55688
	[Nullable(2)]
	private ITagTask TagTask;

	// Token: 0x0400D989 RID: 55689
	private bool EnableLockOn;

	// Token: 0x0400D98A RID: 55690
	[Nullable(2)]
	private AimingLockOnInfo LockOnTarget;

	// Token: 0x0400D98B RID: 55691
	private float TimeCount;

	// Token: 0x0400D98C RID: 55692
	private readonly Vector2D ScreenPos = new Vector2D();

	// Token: 0x0400D98D RID: 55693
	private readonly global::Vector TmpBoneLocation = global::Vector.Create();

	// Token: 0x0400D98E RID: 55694
	private readonly global::Vector TmpActorLocation = global::Vector.Create();

	// Token: 0x0400D98F RID: 55695
	[Nullable(2)]
	private UTraceLineElement AimingLineTrace;
}
