using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200318A RID: 12682
[NullableContext(1)]
[Nullable(0)]
public abstract class SpecialSkillAimingBase : SpecialSkillBase
{
	// Token: 0x170025BD RID: 9661
	// (get) Token: 0x0601B493 RID: 111763
	protected abstract int AimingTagId { get; }

	// Token: 0x170025BE RID: 9662
	// (get) Token: 0x0601B494 RID: 111764
	protected abstract EEventName SwitchLockTargetEventName { get; }

	// Token: 0x0601B495 RID: 111765 RVA: 0x00771AB7 File Offset: 0x0076FCB7
	protected SpecialSkillAimingBase(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0601B496 RID: 111766 RVA: 0x00771AF8 File Offset: 0x0076FCF8
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

	// Token: 0x0601B497 RID: 111767 RVA: 0x00771B97 File Offset: 0x0076FD97
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

	// Token: 0x0601B498 RID: 111768 RVA: 0x00771BC8 File Offset: 0x0076FDC8
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

	// Token: 0x0601B499 RID: 111769 RVA: 0x00771C19 File Offset: 0x0076FE19
	protected virtual void OnAimingStart()
	{
	}

	// Token: 0x0601B49A RID: 111770 RVA: 0x00771C1B File Offset: 0x0076FE1B
	protected virtual void OnAimingEnd()
	{
		this.TimeCount = 0f;
	}

	// Token: 0x0601B49B RID: 111771
	protected abstract void DoOnTargetLocked(EntityHandle target, string socketName);

	// Token: 0x0601B49C RID: 111772
	protected abstract void DoOnTargetUnlocked(EntityHandle target, string socketName);

	// Token: 0x0601B49D RID: 111773
	protected abstract void LockOn();

	// Token: 0x0601B49E RID: 111774 RVA: 0x00771C28 File Offset: 0x0076FE28
	protected void OnTargetLocked(EntityHandle target, string socketName)
	{
		this.DoOnTargetLocked(target, socketName);
	}

	// Token: 0x0601B49F RID: 111775 RVA: 0x00771C32 File Offset: 0x0076FE32
	protected void OnTargetUnlocked(EntityHandle target, string socketName)
	{
		this.DoOnTargetUnlocked(target, socketName);
	}

	// Token: 0x0601B4A0 RID: 111776 RVA: 0x00771C3C File Offset: 0x0076FE3C
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

	// Token: 0x0601B4A1 RID: 111777 RVA: 0x00771C70 File Offset: 0x0076FE70
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

	// Token: 0x0601B4A2 RID: 111778 RVA: 0x00771CD0 File Offset: 0x0076FED0
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

	// Token: 0x0601B4A3 RID: 111779 RVA: 0x00771D00 File Offset: 0x0076FF00
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

	// Token: 0x0601B4A4 RID: 111780 RVA: 0x00771D34 File Offset: 0x0076FF34
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

	// Token: 0x0601B4A5 RID: 111781 RVA: 0x007720E4 File Offset: 0x007702E4
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

	// Token: 0x0601B4A6 RID: 111782 RVA: 0x00772290 File Offset: 0x00770490
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

	// Token: 0x0601B4A7 RID: 111783 RVA: 0x00772390 File Offset: 0x00770590
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

	// Token: 0x0601B4A8 RID: 111784 RVA: 0x00772400 File Offset: 0x00770600
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

	// Token: 0x0601B4A9 RID: 111785 RVA: 0x00772484 File Offset: 0x00770684
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

	// Token: 0x0400D520 RID: 54560
	private const string PROFILE_KEY = "SpecialSkillAimingBase_TraceDetectBlock";

	// Token: 0x0400D521 RID: 54561
	protected readonly int GapTime = 200;

	// Token: 0x0400D522 RID: 54562
	protected readonly int Distance = 5000;

	// Token: 0x0400D523 RID: 54563
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D524 RID: 54564
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400D525 RID: 54565
	[Nullable(2)]
	private ITagTask TagTask;

	// Token: 0x0400D526 RID: 54566
	private bool EnableLockOn;

	// Token: 0x0400D527 RID: 54567
	[Nullable(2)]
	private AimingLockOnInfo LockOnTarget;

	// Token: 0x0400D528 RID: 54568
	private float TimeCount;

	// Token: 0x0400D529 RID: 54569
	private readonly Vector2D ScreenPos = new Vector2D();

	// Token: 0x0400D52A RID: 54570
	private readonly global::Vector TmpBoneLocation = global::Vector.Create();

	// Token: 0x0400D52B RID: 54571
	private readonly global::Vector TmpActorLocation = global::Vector.Create();

	// Token: 0x0400D52C RID: 54572
	[Nullable(2)]
	private UTraceLineElement AimingLineTrace;
}
