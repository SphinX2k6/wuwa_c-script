using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x02002630 RID: 9776
[NullableContext(1)]
[Nullable(0)]
public class CharacterLockOnComponent : BaseLockOnComponent
{
	// Token: 0x17002657 RID: 9815
	// (get) Token: 0x06018689 RID: 99977 RVA: 0x0075E380 File Offset: 0x0075C580
	public override Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(CharacterUnifiedStateComponent)
			};
		}
	}

	// Token: 0x0601868A RID: 99978 RVA: 0x0075E395 File Offset: 0x0075C595
	protected override void OnTargetDeadOrRemoved()
	{
		if (this.IsLookAt)
		{
			this.ForceLookAt(null, false);
			return;
		}
		if (base.IsHardLock)
		{
			this.DetectHardLockTargets(true);
			return;
		}
		base.SetCurrentInfo(null);
		this.SetShowTarget(null, "", false);
	}

	// Token: 0x0601868B RID: 99979 RVA: 0x0075E3D0 File Offset: 0x0075C5D0
	private void OnStateInherit(Entity lastEntity, bool _)
	{
		CharacterLockOnComponent component = lastEntity.GetComponent<CharacterLockOnComponent>();
		this.IsLookAt = component.IsLookAt;
		this.IgnoreInfos = new List<LockOnInfo>(component.IgnoreInfos);
		base.SetCurrentInfo(component.GetCurrentInfo);
		this.RestoreIgnoreTarget = component.RestoreIgnoreTarget;
		this.SetShowTarget(component.ShowTarget, component.ShowTargetSocket, false);
	}

	// Token: 0x0601868C RID: 99980 RVA: 0x0075E430 File Offset: 0x0075C630
	protected override bool OnStart()
	{
		base.OnStart();
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		this.CreatureComp = base.Entity.GetComponent<CreatureDataComponent>();
		RoleInfo? roleConfig = this.CreatureComp.GetRoleConfig();
		int softLockConfigId = (roleConfig != null) ? roleConfig.GetValueOrDefault().LockOnDefaultId : 0;
		roleConfig = this.CreatureComp.GetRoleConfig();
		base.SetLockOnConfig(softLockConfigId, (roleConfig != null) ? roleConfig.GetValueOrDefault().LockOnLookOnId : 0);
		this.UnifiedStateComponent = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		this.InputComponent = base.Entity.GetComponent<CharacterInputComponent>();
		this.BuffComponent = base.Entity.GetComponent<CharacterBuffComponent>();
		EventSystem.Instance.Add(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		EventSystem.Instance.AddWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
		this.TagListeners.Add(this.TagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.不可锁定.强锁定.结束恢复"]), new BaseTagComponent.TTagSwitchedCallback(this.OnRestoreTargetTagAddOrRemove), null));
		this.TagListeners.Add(this.TagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.特殊锁定.切换强锁配置.远距离强锁"]), new BaseTagComponent.TTagSwitchedCallback(this.OnForceLockTagAddOrRemove), null));
		return true;
	}

	// Token: 0x0601868D RID: 99981 RVA: 0x0075E59C File Offset: 0x0075C79C
	protected override bool OnEnd()
	{
		base.OnEnd();
		EventSystem.Instance.Remove(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		EventSystem.Instance.RemoveWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
		foreach (ITagTask tagTask in this.TagListeners)
		{
			tagTask.EndTask();
		}
		this.TagListeners.Clear();
		if (this.ForceLockEntityAddDispose != null)
		{
			this.ForceLockEntityAddDispose();
			this.ForceLockEntityAddDispose = null;
		}
		return true;
	}

	// Token: 0x0601868E RID: 99982 RVA: 0x0075E658 File Offset: 0x0075C858
	protected override void OnDisable(string reason)
	{
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent == null)
		{
			return;
		}
		tagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.拥有锁定目标"]));
	}

	// Token: 0x0601868F RID: 99983 RVA: 0x0075E67F File Offset: 0x0075C87F
	protected override void OnTick(float delta)
	{
		this.TickMoveDir();
		this.TickCurrentInfo();
		base.Check(delta);
		base.UpdateTargetsIsLock(delta);
		this.SendRequestMessageIfHardLockStateChanged();
		this.RefreshHardLockDebug();
		base.OnTick(delta);
	}

	// Token: 0x06018690 RID: 99984 RVA: 0x0075E6B0 File Offset: 0x0075C8B0
	private void RefreshHardLockDebug()
	{
		if (!LockOnDebug.IsShowDebugLine || !base.IsHardLock)
		{
			return;
		}
		LockOnInfo getCurrentInfo = base.GetCurrentInfo;
		bool flag;
		if (getCurrentInfo == null)
		{
			flag = true;
		}
		else
		{
			EntityHandle entityHandle = getCurrentInfo.EntityHandle;
			flag = !((entityHandle != null) ? new bool?(entityHandle.Valid) : null).GetValueOrDefault();
		}
		if (flag)
		{
			LockOnDebug.Clear();
			return;
		}
		global::Vector vector = global::Vector.Create();
		global::Vector vector2 = global::Vector.Create();
		base.GetSkillBoneLocation(getCurrentInfo.EntityHandle, getCurrentInfo.SocketName, this.TmpVector1);
		this.TmpVector1.Subtraction(base.ActorLocationProxy, this.TmpVector2);
		float distance = (float)this.TmpVector2.Size();
		float angle = 0f;
		if (!this.TmpVector2.IsNearlyZero(1E-08))
		{
			CameraController.Instance.MainModel.CameraRotator.Quaternion(null).RotateVector(global::Vector.ForwardVectorProxy, vector);
			angle = (float)(Math.Acos(Math.Clamp(vector.CosineAngle2D(this.TmpVector2, 9.999999747378752E-05), -1.0, 1.0)) * 57.295780181884766);
			this.TmpVector2.Normalize(1E-08);
			vector2.DeepCopy(this.TmpVector2);
		}
		LockOnDebug.Clear();
		LockOnDebug.Push(getCurrentInfo);
		LockOnDebug.SetDebugString(getCurrentInfo, angle, distance, this.InputDirect, vector2);
		LockOnDebug.SetDebugArrow(getCurrentInfo, EColorType.Black);
	}

	// Token: 0x06018691 RID: 99985 RVA: 0x0075E818 File Offset: 0x0075CA18
	[NullableContext(2)]
	protected override void SetAndShowTarget(LockOnInfo bestInfo, bool showTarget)
	{
		base.SetCurrentInfo(bestInfo);
		if (bestInfo != null)
		{
			EntityHandle entityHandle = bestInfo.EntityHandle;
			if (((entityHandle != null) ? new bool?(entityHandle.Valid) : null).GetValueOrDefault())
			{
				LockOnDebug.SetDebugArrow(bestInfo, EColorType.Green);
			}
		}
		if (showTarget)
		{
			this.SetShowTargetBySkill(base.GetCurrentTarget(), base.GetCurrentTargetSocketName());
		}
	}

	// Token: 0x06018692 RID: 99986 RVA: 0x0075E878 File Offset: 0x0075CA78
	public override bool SetShowTarget([Nullable(2)] EntityHandle target, string socketName = "", bool isHardLock = false)
	{
		CharacterActorComponent characterActorComponent;
		if (target == null)
		{
			characterActorComponent = null;
		}
		else
		{
			WorldEntity entity = target.Entity;
			characterActorComponent = ((entity != null) ? entity.GetComponent<CharacterActorComponent>() : null);
		}
		CharacterActorComponent characterActorComponent2 = characterActorComponent;
		string text = socketName;
		if (target != null && target.Valid)
		{
			bool? flag;
			if (characterActorComponent2 == null)
			{
				flag = null;
			}
			else
			{
				CameraLockOnConfig cameraLockOnConfig = characterActorComponent2.CameraLockOnConfig;
				flag = ((cameraLockOnConfig != null) ? new bool?(cameraLockOnConfig.IsEnabled) : null);
			}
			bool? flag2 = flag;
			if (flag2.GetValueOrDefault() && !this.IsLookAt)
			{
				text = characterActorComponent2.CameraLockOnConfig.CameraLockOnBoneName;
			}
			if (!base.HasShowTarget)
			{
				BaseTagComponent tagComponent = this.TagComponent;
				if (tagComponent != null)
				{
					tagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.拥有锁定目标"]));
				}
			}
			SceneTeamController.Instance.EmitEvent<int, string, bool>(base.Entity, EEventName.CharSetShowTarget, target.Id, text, isHardLock);
		}
		else if (base.HasShowTarget)
		{
			BaseTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 != null)
			{
				tagComponent2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.拥有锁定目标"]));
			}
			SceneTeamController instance = SceneTeamController.Instance;
			Entity entity2 = base.Entity;
			EEventName name = EEventName.CharEndShowTarget;
			EntityHandle showTarget = base.ShowTarget;
			instance.EmitEvent<int, string, bool>(entity2, name, (showTarget != null) ? showTarget.Id : -1, base.ShowTargetSocket, base.IsHardLock);
		}
		this.ShowTargetSetTime = Time.Instance.WorldTime;
		if (base.ShowTarget == target && base.ShowTargetSocket == text)
		{
			return true;
		}
		if (target == null)
		{
			this.ShowTargetInternal = null;
			this.ShowTargetSocketInternal = "";
			GlobalData.BpEventManager.小队技能目标改变时.Broadcast(null);
			return false;
		}
		this.ShowTargetInternal = target;
		this.ShowTargetSocketInternal = text;
		if (characterActorComponent2 != null)
		{
			GlobalData.BpEventManager.小队技能目标改变时.Broadcast(characterActorComponent2.Actor);
		}
		return true;
	}

	// Token: 0x06018693 RID: 99987 RVA: 0x0075EA1C File Offset: 0x0075CC1C
	private bool SetShowTargetBySkill([Nullable(2)] EntityHandle target, string socketName = "")
	{
		if (base.IsHardLock)
		{
			return false;
		}
		if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.新版控物"]))
		{
			return false;
		}
		if (target == null || !target.Valid || !target.Entity.Active)
		{
			return this.SetShowTarget(null, "", false);
		}
		CharacterActorComponent component = target.Entity.GetComponent<CharacterActorComponent>();
		if (component == null)
		{
			return this.SetShowTarget(target, socketName, false);
		}
		if (string.IsNullOrEmpty(socketName))
		{
			return component.LockOnParts.Count <= 0 && this.SetShowTarget(target, socketName, false);
		}
		LockOnPart valueOrDefault = component.LockOnParts.GetValueOrDefault(socketName);
		return valueOrDefault != null && valueOrDefault.SoftLockValid && this.SetShowTarget(target, socketName, false);
	}

	// Token: 0x06018694 RID: 99988 RVA: 0x0075EADD File Offset: 0x0075CCDD
	protected override void ClearLockOnTarget()
	{
		base.ClearLockOnTarget();
		this.ExitLockDirection();
		this.ForceLookAt(null, false);
	}

	// Token: 0x06018695 RID: 99989 RVA: 0x0075EAF4 File Offset: 0x0075CCF4
	[NullableContext(2)]
	public void ForceLookAt(LockOnInfo target, bool enable)
	{
		if (enable)
		{
			LockOnInfo target2 = target;
			if (!LockOnUtils.IsValidLockOnTarget((target2 != null) ? target2.EntityHandle : null, null, null, false))
			{
				CombatLog.Instance.Error(CombatLog.EDebugModule.LockOn, base.Entity, "无效的看向目标！", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.IsLookAt)
			{
				LockOnInfo target3 = target;
				if (target3 == null || !target3.Different(base.GetCurrentInfo))
				{
					CombatLog.Instance.Error(CombatLog.EDebugModule.LockOn, base.Entity, "重复进入看向状态！", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
			}
			if (this.IgnoreInfos.Exists((LockOnInfo element) => !element.Different(target)))
			{
				CombatLog.Instance.Error(CombatLog.EDebugModule.LockOn, base.Entity, "忽略锁定期间不能进入看向状态！", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
		}
		bool isLookAt = this.IsLookAt;
		if (enable)
		{
			this.IsLookAt = true;
			if (base.IsHardLock)
			{
				LockOnInfo target4 = target;
				if (target4 == null || !target4.Different(base.GetCurrentInfo))
				{
					return;
				}
			}
			else
			{
				if (this.UnifiedStateComponent.DirectionState == ECharDirectionState.AimDirection)
				{
					base.SetCurrentInfo(target);
					return;
				}
				this.UnifiedStateComponent.SetDirectionState(ECharDirectionState.LookAtDirection);
			}
			base.SetCurrentInfo(target);
			LockOnInfo target5 = target;
			EntityHandle target6 = (target5 != null) ? target5.EntityHandle : null;
			LockOnInfo target7 = target;
			this.SetShowTarget(target6, (target7 != null) ? target7.SocketName : null, false);
		}
		else if (this.IsLookAt)
		{
			LockOnInfo target8 = target;
			if (target8 == null || !target8.Different(base.GetCurrentInfo))
			{
				this.IsLookAt = false;
				if (!base.IsHardLock && this.UnifiedStateComponent.DirectionState == ECharDirectionState.LookAtDirection)
				{
					this.UnifiedStateComponent.SetDirectionState(ECharDirectionState.FaceDirection);
				}
			}
		}
		bool isLookAt2 = this.IsLookAt;
	}

	// Token: 0x06018696 RID: 99990 RVA: 0x0075ECC4 File Offset: 0x0075CEC4
	public bool TryRestoreLookAt()
	{
		if (!this.IsLookAt || base.IsHardLock)
		{
			return false;
		}
		LockOnInfo getCurrentInfo = base.GetCurrentInfo;
		if (!LockOnUtils.IsValidLockOnTarget((getCurrentInfo != null) ? getCurrentInfo.EntityHandle : null, null, null, false))
		{
			this.IsLookAt = false;
			return false;
		}
		this.UnifiedStateComponent.SetDirectionState(ECharDirectionState.LookAtDirection);
		this.SetShowTarget((getCurrentInfo != null) ? getCurrentInfo.EntityHandle : null, (getCurrentInfo != null) ? getCurrentInfo.SocketName : null, false);
		return true;
	}

	// Token: 0x06018697 RID: 99991 RVA: 0x0075ED38 File Offset: 0x0075CF38
	public void ForceIgnore(LockOnInfo target, bool enable)
	{
		if (enable)
		{
			if (this.IgnoreInfos.Exists((LockOnInfo ignoreInfo) => !ignoreInfo.Different(target)))
			{
				CombatLog.Instance.Error(CombatLog.EDebugModule.LockOn, base.Entity, "重复进入忽略锁定状态！", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.IsLookAt)
			{
				LockOnInfo getCurrentInfo = base.GetCurrentInfo;
				if (getCurrentInfo != null && !getCurrentInfo.Different(target))
				{
					CombatLog.Instance.Error(CombatLog.EDebugModule.LockOn, base.Entity, "看向状态期间不能忽略锁定！", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
			}
		}
		if (enable)
		{
			this.IgnoreInfos.Add(target);
			if (base.GetCurrentInfo == null || target.Different(base.GetCurrentInfo))
			{
				return;
			}
			if (base.IsHardLock)
			{
				this.RestoreIgnoreTarget = base.GetCurrentInfo;
			}
			base.SetCurrentInfo(null);
			this.SetShowTarget(null, "", false);
			if (this.UnifiedStateComponent.DirectionState != ECharDirectionState.AimDirection)
			{
				this.UnifiedStateComponent.SetDirectionState(ECharDirectionState.FaceDirection);
				return;
			}
		}
		else
		{
			if (this.IgnoreInfos.Exists((LockOnInfo ignoreInfo) => !ignoreInfo.Different(target)))
			{
				this.IgnoreInfos = this.IgnoreInfos.FindAll((LockOnInfo ignoreInfo) => ignoreInfo.Different(target));
			}
			if (this.RestoreIgnoreTarget != null && !this.RestoreIgnoreTarget.Different(target))
			{
				if (!base.IsHardLock && LockOnUtils.IsValidLockOnTarget(target.EntityHandle, null, null, false) && this.UnifiedStateComponent.DirectionState != ECharDirectionState.AimDirection)
				{
					base.SetCurrentInfo(this.RestoreIgnoreTarget);
					this.SetShowTarget(this.RestoreIgnoreTarget.EntityHandle, this.RestoreIgnoreTarget.SocketName, false);
					base.SVarHardLockedQueue.Push(this.RestoreIgnoreTarget);
					this.UnifiedStateComponent.SetDirectionState(ECharDirectionState.LockDirection);
				}
				this.RestoreIgnoreTarget = null;
			}
		}
	}

	// Token: 0x06018698 RID: 99992 RVA: 0x0075EF1C File Offset: 0x0075D11C
	private void TickCurrentInfo()
	{
		if (this.IsLookAt)
		{
			return;
		}
		if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.新版控物"]))
		{
			this.ClearLockOnTarget();
			return;
		}
		LockOnInfo getCurrentInfo = base.GetCurrentInfo;
		bool flag;
		if (getCurrentInfo == null)
		{
			flag = false;
		}
		else
		{
			EntityHandle entityHandle = getCurrentInfo.EntityHandle;
			flag = ((entityHandle != null) ? new bool?(entityHandle.Valid) : null).GetValueOrDefault();
		}
		if (flag && this.HardLockConfig != null)
		{
			Aki.Config.LockOnConfig value = this.HardLockConfig.Value;
			if (base.IsHardLock)
			{
				global::Vector tmpVector = this.TmpVector1;
				base.GetSkillBoneLocation(base.GetCurrentInfo.EntityHandle, base.GetCurrentInfo.SocketName, tmpVector);
				if (base.IsEntityContainsDisableHardLockTag(base.GetCurrentInfo.EntityHandle) || base.CannotBeDetected(value, base.GetCurrentInfo.EntityHandle, tmpVector))
				{
					this.ExitLockDirection();
					return;
				}
			}
			else if (base.IsEntityContainsDisableSoftLockTag(base.GetCurrentInfo.EntityHandle) || base.CannotBeDetected(value, base.GetCurrentInfo.EntityHandle, base.GetCurrentInfo.EntityHandle.Entity.GetComponent<BaseActorComponent>().ActorLocationProxy))
			{
				base.SetCurrentInfo(null);
				this.SetShowTarget(null, "", false);
			}
		}
	}

	// Token: 0x06018699 RID: 99993 RVA: 0x0075F05C File Offset: 0x0075D25C
	private void TickMoveDir()
	{
		if (this.InputComponent == null)
		{
			return;
		}
		global::Vector moveDirectionCache = this.InputComponent.GetMoveDirectionCache();
		if (this.InputComponent.GetCameraInput().Item1 != 0f || !this.MoveDirCache.Equals(moveDirectionCache, 1E-08))
		{
			this.MoveDirCache.Set(moveDirectionCache.X, moveDirectionCache.Y, 0.0);
			this.InputDirect.DeepCopy(this.ActorComp.InputDirectProxy);
			if (!this.MoveDirCache.IsNearlyZero(1E-08))
			{
				this.HasChangeInput = true;
			}
		}
		if (this.SpeedUpCleanTarget())
		{
			this.HasChangeInput = true;
		}
	}

	// Token: 0x0601869A RID: 99994 RVA: 0x0075F110 File Offset: 0x0075D310
	public void EnterLockDirection()
	{
		if (!this.IsLookAt)
		{
			if (base.IsHardLock)
			{
				return;
			}
			if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.方向状态.瞄准方向"]))
			{
				return;
			}
			if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.新版控物"]))
			{
				return;
			}
			if (CameraController.Instance.MainModel.FightCamera.LogicComponent.IsDisableResetFocus != 0f)
			{
				return;
			}
			if (this.IsForceLock)
			{
				LockOnInfo getCurrentInfo = base.GetCurrentInfo;
				bool flag;
				if (getCurrentInfo == null)
				{
					flag = false;
				}
				else
				{
					EntityHandle entityHandle = getCurrentInfo.EntityHandle;
					flag = ((entityHandle != null) ? new bool?(entityHandle.Valid) : null).GetValueOrDefault();
				}
				if (flag && this.UnifiedStateComponent.DirectionState == ECharDirectionState.LockDirection)
				{
					return;
				}
			}
			this.DetectHardLockTargets(true);
			if (base.GetCurrentInfo == null)
			{
				base.ResetFocus();
				return;
			}
			this.CheckCount = 0;
		}
		base.SVarHardLockedQueue.Push(base.GetCurrentInfo);
		this.UnifiedStateComponent.SetDirectionState(ECharDirectionState.LockDirection);
	}

	// Token: 0x0601869B RID: 99995 RVA: 0x0075F214 File Offset: 0x0075D414
	public void ExitLockDirection()
	{
		if (base.IsHardLock)
		{
			if (this.IsForceLock)
			{
				return;
			}
			if (this.IsLookAt)
			{
				this.UnifiedStateComponent.SetDirectionState(ECharDirectionState.LookAtDirection);
				return;
			}
			this.SetShowTarget(null, "", false);
			base.SVarHardLockedQueue.Clear();
			this.UnifiedStateComponent.SetDirectionState(ECharDirectionState.FaceDirection);
		}
	}

	// Token: 0x0601869C RID: 99996 RVA: 0x0075F26C File Offset: 0x0075D46C
	private void OnBattleStateChanged(bool isInFight)
	{
		bool flag = this.IsCompensateLockDirection();
		if (!isInFight)
		{
			this.CompensateLockDirection();
			return;
		}
		if (flag)
		{
			this.ExitLockDirection();
			this.QuitCompensateLockDirection();
			this.EnterLockDirection();
		}
	}

	// Token: 0x0601869D RID: 99997 RVA: 0x0075F2A0 File Offset: 0x0075D4A0
	private void CompensateLockDirection()
	{
		if (!base.IsHardLock)
		{
			return;
		}
		CharacterBuffComponent buffComponent = this.BuffComponent;
		if (buffComponent == null)
		{
			return;
		}
		long buffId = 1001006001L;
		AddBuffParam addBuffParam = new AddBuffParam();
		CharacterBuffComponent buffComponent2 = this.BuffComponent;
		addBuffParam.InstigatorId = ((buffComponent2 != null) ? buffComponent2.CreatureDataId : 0L);
		addBuffParam.Reason = "角色强锁补偿buff";
		buffComponent.AddBuff(buffId, addBuffParam);
	}

	// Token: 0x0601869E RID: 99998 RVA: 0x0075F2F8 File Offset: 0x0075D4F8
	private bool QuitCompensateLockDirection()
	{
		if (this.IsCompensateLockDirection() && this.BuffComponent != null)
		{
			this.BuffComponent.RemoveBuff(1001006001L, -1, "角色强锁补偿buff", null, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x0601869F RID: 99999 RVA: 0x0075F34A File Offset: 0x0075D54A
	public bool IsCompensateLockDirection()
	{
		return this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["被动.功能.多波次锁定补偿"]);
	}

	// Token: 0x060186A0 RID: 100000 RVA: 0x0075F368 File Offset: 0x0075D568
	private void DetectHardLockTargets(bool clearCache)
	{
		if (this.HardLockConfig == null)
		{
			return;
		}
		if (clearCache)
		{
			base.SVarHardLockedQueue.Clear();
		}
		Aki.Config.LockOnConfig value = this.HardLockConfig.Value;
		List<LockOnInfo> list = base.DetectAlternativeTargets(value, true);
		while (list.Count > 0)
		{
			bool flag = true;
			for (int i = 0; i < list.Count; i++)
			{
				if (!base.SVarHardLockedQueue.Has(list[i]))
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				break;
			}
			base.SVarHardLockedQueue.Pop();
		}
		LockOnInfo lockOnInfo = base.FindTheBest(base.GetVipList(list, true), ESkillTargetPriority.镜头方向优先, true, value.ToleranceAngle, 0.0);
		base.SetCurrentInfo(lockOnInfo);
		if (lockOnInfo == null)
		{
			this.SetShowTarget(null, "", false);
			this.ExitLockDirection();
			return;
		}
		base.SVarHardLockedQueue.Push(lockOnInfo);
		this.SetShowTarget(lockOnInfo.EntityHandle, lockOnInfo.SocketName, true);
		this.TimeElapsedSinceLastLock = 0f;
		if (lockOnInfo != null)
		{
			EntityHandle entityHandle = lockOnInfo.EntityHandle;
			if (((entityHandle != null) ? new bool?(entityHandle.Valid) : null).GetValueOrDefault())
			{
				LockOnDebug.SetDebugArrow(lockOnInfo, EColorType.Black);
			}
		}
	}

	// Token: 0x060186A1 RID: 100001 RVA: 0x0075F490 File Offset: 0x0075D690
	protected override int GetSelfCamp()
	{
		return (int)this.ActorComp.Actor.Camp;
	}

	// Token: 0x060186A2 RID: 100002 RVA: 0x0075F4A4 File Offset: 0x0075D6A4
	private void OnRestoreTargetTagAddOrRemove(int tagId, bool tagExist)
	{
		if (tagExist)
		{
			if (base.IsHardLock)
			{
				this.OldInfoAtRemoveDisableHardLockTag = base.GetCurrentInfo;
			}
			return;
		}
		LockOnInfo oldInfoAtRemoveDisableHardLockTag = this.OldInfoAtRemoveDisableHardLockTag;
		WorldEntity worldEntity;
		if (oldInfoAtRemoveDisableHardLockTag == null)
		{
			worldEntity = null;
		}
		else
		{
			EntityHandle entityHandle = oldInfoAtRemoveDisableHardLockTag.EntityHandle;
			worldEntity = ((entityHandle != null) ? entityHandle.Entity : null);
		}
		WorldEntity worldEntity2 = worldEntity;
		if (this.OldInfoAtRemoveDisableHardLockTag == null || (worldEntity2 == null || !worldEntity2.Valid))
		{
			return;
		}
		CharacterActorComponent component = worldEntity2.GetComponent<CharacterActorComponent>();
		if (component == null || !component.Valid)
		{
			return;
		}
		FightCamera fightCamera = CameraModel.Instance.MainModel.FightCamera;
		FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
		if (fightCameraLogicComponent == null || !fightCameraLogicComponent.CheckPositionInScreen(component.ActorLocationProxy, fightCameraLogicComponent.CameraAdjustController.CheckInScreenMinX, fightCameraLogicComponent.CameraAdjustController.CheckInScreenMaxX, fightCameraLogicComponent.CameraAdjustController.CheckInScreenMinY, fightCameraLogicComponent.CameraAdjustController.CheckInScreenMaxY))
		{
			return;
		}
		if (!base.IsHardLock)
		{
			this.EnterLockDirection();
		}
		else
		{
			base.SetCurrentInfo(this.OldInfoAtRemoveDisableHardLockTag);
			this.SetShowTarget(base.GetCurrentInfo.EntityHandle, base.GetCurrentInfo.SocketName, false);
			base.SVarHardLockedQueue.Push(base.GetCurrentInfo);
		}
		this.OldInfoAtRemoveDisableHardLockTag = null;
	}

	// Token: 0x060186A3 RID: 100003 RVA: 0x0075F5D0 File Offset: 0x0075D7D0
	private void OnForceLockTagAddOrRemove(int tagId, bool tagExist)
	{
		RoleInfo? roleConfig;
		if (!tagExist)
		{
			roleConfig = this.CreatureComp.GetRoleConfig();
			int softLockConfigId = (roleConfig != null) ? roleConfig.GetValueOrDefault().LockOnDefaultId : 0;
			roleConfig = this.CreatureComp.GetRoleConfig();
			base.SetLockOnConfig(softLockConfigId, (roleConfig != null) ? roleConfig.GetValueOrDefault().LockOnLookOnId : 0);
			this.IsForceLock = false;
			if (this.ForceLockEntityAddDispose != null)
			{
				this.ForceLockEntityAddDispose();
				this.ForceLockEntityAddDispose = null;
			}
			this.ExitLockDirection();
			return;
		}
		if (this.ForceLockId == 0)
		{
			this.ForceLockId = ConfigCommonParamById.GetIntConfig("SwitchLockOnWithTag").GetValueOrDefault();
		}
		roleConfig = this.CreatureComp.GetRoleConfig();
		base.SetLockOnConfig((roleConfig != null) ? roleConfig.GetValueOrDefault().LockOnDefaultId : 0, this.ForceLockId);
		this.EnterLockDirection();
		this.IsForceLock = true;
		LockOnInfo getCurrentInfo = base.GetCurrentInfo;
		bool flag;
		if (getCurrentInfo == null)
		{
			flag = false;
		}
		else
		{
			EntityHandle entityHandle = getCurrentInfo.EntityHandle;
			bool? flag2 = (entityHandle != null) ? new bool?(entityHandle.Valid) : null;
			bool flag3 = false;
			flag = (flag2.GetValueOrDefault() == flag3 & flag2 != null);
		}
		if (flag && this.ForceLockEntityAddDispose == null)
		{
			this.ForceLockEntityAddDispose = EntityAddListener.ListenMonsterAddOnce(delegate(EntityHandle handle)
			{
				this.ForceLockEntityAddDispose = null;
				this.EnterLockDirection();
			}, base.Entity.Id);
		}
	}

	// Token: 0x060186A4 RID: 100004 RVA: 0x0075F72C File Offset: 0x0075D92C
	private void SendRequestMessageIfHardLockStateChanged()
	{
		bool isHardLock = base.IsHardLock;
		if (this.IsHardLockInternal != isHardLock)
		{
			CombatNet instance = CombatNet.Instance;
			EPushMessageId id = isHardLock ? EPushMessageId.EnterViewDirectionPush : EPushMessageId.ExitViewDirectionPush;
			Entity entity = base.Entity;
			IMessage message2;
			if (!isHardLock)
			{
				IMessage message = ExitViewDirectionPush.Create();
				message2 = message;
			}
			else
			{
				IMessage message = EnterViewDirectionPush.Create();
				message2 = message;
			}
			instance.Send(id, entity, message2, null, null, null);
			this.IsHardLockInternal = isHardLock;
		}
	}

	// Token: 0x060186A5 RID: 100005 RVA: 0x0075F7A0 File Offset: 0x0075D9A0
	public void RefreshCurrentLockState([Nullable(2)] EntityHandle target, string refreshSocket = "")
	{
		LockOnInfo getCurrentInfo = base.GetCurrentInfo;
		if (((getCurrentInfo != null) ? getCurrentInfo.EntityHandle : null) != target)
		{
			return;
		}
		CharacterActorComponent characterActorComponent;
		if (target == null)
		{
			characterActorComponent = null;
		}
		else
		{
			WorldEntity entity = target.Entity;
			characterActorComponent = ((entity != null) ? entity.GetComponent<CharacterActorComponent>() : null);
		}
		CharacterActorComponent characterActorComponent2 = characterActorComponent;
		if (characterActorComponent2 == null)
		{
			return;
		}
		LockOnInfo getCurrentInfo2 = base.GetCurrentInfo;
		string text = (getCurrentInfo2 != null) ? getCurrentInfo2.SocketName : null;
		if (!string.IsNullOrEmpty(text) && text == refreshSocket && characterActorComponent2.LockOnParts.ContainsKey(text))
		{
			LockOnPart lockOnPart = characterActorComponent2.LockOnParts[text];
			if (!lockOnPart.HardLockValid)
			{
				this.ExitLockDirection();
			}
			if (!lockOnPart.SoftLockValid)
			{
				this.SetShowTarget(null, "", false);
			}
		}
	}

	// Token: 0x060186A6 RID: 100006 RVA: 0x0075F844 File Offset: 0x0075DA44
	public bool SpeedUpCleanTarget()
	{
		CharacterMoveComponent component = base.Entity.GetComponent<CharacterMoveComponent>();
		return component != null && component.Valid && component.Speed > 70f && !this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]);
	}

	// Token: 0x060186A7 RID: 100007 RVA: 0x0075F894 File Offset: 0x0075DA94
	public void ResetTarget()
	{
		if (this.IsLookAt || !base.IsHardLock)
		{
			return;
		}
		this.DetectHardLockTargets(false);
	}

	// Token: 0x060186A8 RID: 100008 RVA: 0x0075F8B0 File Offset: 0x0075DAB0
	public bool ChangeShowTarget(Vector2D inputDirect, float angleCoefficient, float distCoefficient)
	{
		if (this.IsLookAt || !base.IsHardLock || this.HardLockConfig == null || base.GetCurrentInfo == null)
		{
			return false;
		}
		List<LockOnInfo> list = base.DetectAlternativeTargets(this.HardLockConfig.Value, true);
		global::Vector actorLocationProxy = base.ActorLocationProxy;
		base.GetSkillBoneLocation(base.GetCurrentInfo.EntityHandle, base.GetCurrentInfo.SocketName, this.TmpVector1);
		this.TmpVector2.DeepCopy(actorLocationProxy);
		this.TmpVector2.Z = this.TmpVector1.Z;
		this.TmpVector1.SubtractionEqual(actorLocationProxy);
		MathUtils.Instance.LookRotationUpFirst(this.TmpVector1, global::Vector.UpVectorProxy, this.InverseQuat);
		this.InverseQuat.Inverse(this.InverseQuat);
		double num = inputDirect.SizeSquared();
		LockOnInfo lockOnInfo = null;
		double num2 = 1E+50;
		for (int i = 0; i < list.Count; i++)
		{
			LockOnInfo lockOnInfo2 = list[i];
			if (LockOnUtils.IsValidLockOnTarget(lockOnInfo2.EntityHandle, null, null, false) && !lockOnInfo2.Equal(base.GetCurrentInfo))
			{
				base.GetSkillBoneLocation(lockOnInfo2.EntityHandle, lockOnInfo2.SocketName, this.TmpVector1);
				this.TmpVector1.SubtractionEqual(this.TmpVector2);
				this.InverseQuat.RotateVector(this.TmpVector1, this.TmpVector1);
				if (Math.Abs(this.TmpVector1.X) >= 1E-08 || Math.Abs(this.TmpVector1.Y) >= 1E-08)
				{
					double num3 = Math.Atan2(this.TmpVector1.Y, this.TmpVector1.X) * 57.295780181884766;
					double num4 = Math.Asin(this.TmpVector1.Z / this.TmpVector1.Size()) * 57.295780181884766;
					double num5 = Math.Sqrt(num3 * num3 + num4 * num4);
					this.TmpVector2D.X = num3;
					this.TmpVector2D.Y = num4;
					double num6 = this.TmpVector2D.DotProduct(inputDirect);
					if (num6 >= 0.0)
					{
						double num7 = Math.Acos(num6 / Math.Sqrt(this.TmpVector2D.SizeSquared() * num)) * 57.295780181884766;
						double num8 = (double)angleCoefficient * num7 / 180.0 + (double)distCoefficient * num5;
						if (num8 < num2)
						{
							num2 = num8;
							lockOnInfo = lockOnInfo2;
						}
					}
				}
			}
		}
		if (lockOnInfo != null)
		{
			base.SetCurrentInfo(lockOnInfo);
			this.SetShowTarget(lockOnInfo.EntityHandle, lockOnInfo.SocketName, true);
			LockOnDebug.SetDebugArrow(lockOnInfo, EColorType.Black);
			return true;
		}
		return false;
	}

	// Token: 0x060186A9 RID: 100009 RVA: 0x0075FB5E File Offset: 0x0075DD5E
	[NullableContext(2)]
	public LockOnInfo GetPredictedLockOnTarget()
	{
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.预测锁定"]))
		{
			return this.PredictedInfo;
		}
		return null;
	}

	// Token: 0x060186AA RID: 100010 RVA: 0x0075FB8B File Offset: 0x0075DD8B
	[NullableContext(2)]
	public void SetPredictedLockOnTarget(LockOnInfo predictedInfo)
	{
		this.PredictedInfo = predictedInfo;
	}

	// Token: 0x060186AB RID: 100011 RVA: 0x0075FB94 File Offset: 0x0075DD94
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterLockOnComponent characterLockOnComponent = (CharacterLockOnComponent)componentTemplate;
		if (characterLockOnComponent.StatTickMoveDir != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.StatTickMoveDir), "StatTickMoveDir"))
		{
			return false;
		}
		if (characterLockOnComponent.StatTickCurrentInfo != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.StatTickCurrentInfo), "StatTickCurrentInfo"))
		{
			return false;
		}
		if (characterLockOnComponent.StatCheck != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.StatCheck), "StatCheck"))
		{
			return false;
		}
		if (characterLockOnComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (characterLockOnComponent.UnifiedStateComponent == null)
		{
			this.UnifiedStateComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UnifiedStateComponent), "UnifiedStateComponent"))
		{
			return false;
		}
		if (characterLockOnComponent.InputComponent == null)
		{
			this.InputComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InputComponent), "InputComponent"))
		{
			return false;
		}
		if (characterLockOnComponent.BuffComponent == null)
		{
			this.BuffComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffComponent), "BuffComponent"))
		{
			return false;
		}
		if (characterLockOnComponent.TagListeners != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagListeners), "TagListeners"))
		{
			return false;
		}
		if (characterLockOnComponent.MoveDirCache != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveDirCache), "MoveDirCache"))
		{
			return false;
		}
		this.IsForceLock = characterLockOnComponent.IsForceLock;
		this.ForceLockId = characterLockOnComponent.ForceLockId;
		if (characterLockOnComponent.ForceLockEntityAddDispose == null)
		{
			this.ForceLockEntityAddDispose = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ForceLockEntityAddDispose), "ForceLockEntityAddDispose"))
		{
			return false;
		}
		this.IsHardLockInternal = characterLockOnComponent.IsHardLockInternal;
		if (characterLockOnComponent.PredictedInfo == null)
		{
			this.PredictedInfo = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PredictedInfo), "PredictedInfo"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x17002658 RID: 9816
	// (get) Token: 0x060186AC RID: 100012 RVA: 0x0075FD84 File Offset: 0x0075DF84
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002659 RID: 9817
	// (get) Token: 0x060186AD RID: 100013 RVA: 0x0075FD87 File Offset: 0x0075DF87
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700265A RID: 9818
	// (get) Token: 0x060186AE RID: 100014 RVA: 0x0075FD8A File Offset: 0x0075DF8A
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700265B RID: 9819
	// (get) Token: 0x060186AF RID: 100015 RVA: 0x0075FD8D File Offset: 0x0075DF8D
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400D2C2 RID: 53954
	private const string LOCK_DIR_COMPENSATE_REASON = "角色强锁补偿buff";

	// Token: 0x0400D2C3 RID: 53955
	private readonly Stat StatTickMoveDir = Stat.Create("CharacterLockOnComponent.StatTickMoveDir", "", "");

	// Token: 0x0400D2C4 RID: 53956
	private readonly Stat StatTickCurrentInfo = Stat.Create("CharacterLockOnComponent.StatTickCurrentInfo", "", "");

	// Token: 0x0400D2C5 RID: 53957
	private readonly Stat StatCheck = Stat.Create("CharacterLockOnComponent.StatCheck", "", "");

	// Token: 0x0400D2C6 RID: 53958
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D2C7 RID: 53959
	[Nullable(2)]
	private CharacterUnifiedStateComponent UnifiedStateComponent;

	// Token: 0x0400D2C8 RID: 53960
	[Nullable(2)]
	private CharacterInputComponent InputComponent;

	// Token: 0x0400D2C9 RID: 53961
	[Nullable(2)]
	private CharacterBuffComponent BuffComponent;

	// Token: 0x0400D2CA RID: 53962
	private readonly List<ITagTask> TagListeners = new List<ITagTask>();

	// Token: 0x0400D2CB RID: 53963
	private readonly global::Vector MoveDirCache = global::Vector.Create();

	// Token: 0x0400D2CC RID: 53964
	private bool IsForceLock;

	// Token: 0x0400D2CD RID: 53965
	private int ForceLockId;

	// Token: 0x0400D2CE RID: 53966
	[Nullable(2)]
	private TCbDispose ForceLockEntityAddDispose;

	// Token: 0x0400D2CF RID: 53967
	private bool IsHardLockInternal;

	// Token: 0x0400D2D0 RID: 53968
	[Nullable(2)]
	private LockOnInfo PredictedInfo;
}
