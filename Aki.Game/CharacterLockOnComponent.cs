using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x020030D8 RID: 12504
[NullableContext(1)]
[Nullable(0)]
public class CharacterLockOnComponent : BaseLockOnComponent, IComponentDependency
{
	// Token: 0x170024D1 RID: 9425
	// (get) Token: 0x0601AC71 RID: 109681 RVA: 0x00738898 File Offset: 0x00736A98
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Type[] Dependencies
	{
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		get
		{
			return new Type[]
			{
				typeof(CharacterUnifiedStateComponent)
			};
		}
	}

	// Token: 0x0601AC72 RID: 109682 RVA: 0x007388AD File Offset: 0x00736AAD
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

	// Token: 0x0601AC73 RID: 109683 RVA: 0x007388E8 File Offset: 0x00736AE8
	private void OnStateInherit(Entity lastEntity, bool _)
	{
		CharacterLockOnComponent component = lastEntity.GetComponent<CharacterLockOnComponent>();
		this.IsLookAt = component.IsLookAt;
		this.IgnoreInfos = new List<LockOnInfo>(component.IgnoreInfos);
		base.SetCurrentInfo(component.GetCurrentInfo);
		this.RestoreIgnoreTarget = component.RestoreIgnoreTarget;
		this.SetShowTarget(component.ShowTarget, component.ShowTargetSocket, false);
	}

	// Token: 0x0601AC74 RID: 109684 RVA: 0x00738948 File Offset: 0x00736B48
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

	// Token: 0x0601AC75 RID: 109685 RVA: 0x00738AB4 File Offset: 0x00736CB4
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

	// Token: 0x0601AC76 RID: 109686 RVA: 0x00738B70 File Offset: 0x00736D70
	protected override void OnDisable(string reason)
	{
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent == null)
		{
			return;
		}
		tagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.拥有锁定目标"]));
	}

	// Token: 0x0601AC77 RID: 109687 RVA: 0x00738B97 File Offset: 0x00736D97
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

	// Token: 0x0601AC78 RID: 109688 RVA: 0x00738BC8 File Offset: 0x00736DC8
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

	// Token: 0x0601AC79 RID: 109689 RVA: 0x00738D30 File Offset: 0x00736F30
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

	// Token: 0x0601AC7A RID: 109690 RVA: 0x00738D90 File Offset: 0x00736F90
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

	// Token: 0x0601AC7B RID: 109691 RVA: 0x00738F34 File Offset: 0x00737134
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

	// Token: 0x0601AC7C RID: 109692 RVA: 0x00738FF5 File Offset: 0x007371F5
	protected override void ClearLockOnTarget()
	{
		base.ClearLockOnTarget();
		this.ExitLockDirection();
		this.ForceLookAt(null, false);
	}

	// Token: 0x0601AC7D RID: 109693 RVA: 0x0073900C File Offset: 0x0073720C
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

	// Token: 0x0601AC7E RID: 109694 RVA: 0x007391DC File Offset: 0x007373DC
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

	// Token: 0x0601AC7F RID: 109695 RVA: 0x00739250 File Offset: 0x00737450
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

	// Token: 0x0601AC80 RID: 109696 RVA: 0x00739434 File Offset: 0x00737634
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

	// Token: 0x0601AC81 RID: 109697 RVA: 0x00739574 File Offset: 0x00737774
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

	// Token: 0x0601AC82 RID: 109698 RVA: 0x00739628 File Offset: 0x00737828
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

	// Token: 0x0601AC83 RID: 109699 RVA: 0x0073972C File Offset: 0x0073792C
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

	// Token: 0x0601AC84 RID: 109700 RVA: 0x00739784 File Offset: 0x00737984
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

	// Token: 0x0601AC85 RID: 109701 RVA: 0x007397B8 File Offset: 0x007379B8
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

	// Token: 0x0601AC86 RID: 109702 RVA: 0x00739810 File Offset: 0x00737A10
	private bool QuitCompensateLockDirection()
	{
		if (this.IsCompensateLockDirection() && this.BuffComponent != null)
		{
			this.BuffComponent.RemoveBuff(1001006001L, -1, "角色强锁补偿buff", null, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x0601AC87 RID: 109703 RVA: 0x00739862 File Offset: 0x00737A62
	public bool IsCompensateLockDirection()
	{
		return this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["被动.功能.多波次锁定补偿"]);
	}

	// Token: 0x0601AC88 RID: 109704 RVA: 0x00739880 File Offset: 0x00737A80
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

	// Token: 0x0601AC89 RID: 109705 RVA: 0x007399A8 File Offset: 0x00737BA8
	protected override int GetSelfCamp()
	{
		return (int)this.ActorComp.Actor.Camp;
	}

	// Token: 0x0601AC8A RID: 109706 RVA: 0x007399BC File Offset: 0x00737BBC
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

	// Token: 0x0601AC8B RID: 109707 RVA: 0x00739AE8 File Offset: 0x00737CE8
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

	// Token: 0x0601AC8C RID: 109708 RVA: 0x00739C44 File Offset: 0x00737E44
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

	// Token: 0x0601AC8D RID: 109709 RVA: 0x00739CB8 File Offset: 0x00737EB8
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

	// Token: 0x0601AC8E RID: 109710 RVA: 0x00739D5C File Offset: 0x00737F5C
	public bool SpeedUpCleanTarget()
	{
		CharacterMoveComponent component = base.Entity.GetComponent<CharacterMoveComponent>();
		return component != null && component.Valid && component.Speed > 70f && !this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]);
	}

	// Token: 0x0601AC8F RID: 109711 RVA: 0x00739DAC File Offset: 0x00737FAC
	public void ResetTarget()
	{
		if (this.IsLookAt || !base.IsHardLock)
		{
			return;
		}
		this.DetectHardLockTargets(false);
	}

	// Token: 0x0601AC90 RID: 109712 RVA: 0x00739DC8 File Offset: 0x00737FC8
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

	// Token: 0x0601AC91 RID: 109713 RVA: 0x0073A076 File Offset: 0x00738276
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

	// Token: 0x0601AC92 RID: 109714 RVA: 0x0073A0A3 File Offset: 0x007382A3
	[NullableContext(2)]
	public void SetPredictedLockOnTarget(LockOnInfo predictedInfo)
	{
		this.PredictedInfo = predictedInfo;
	}

	// Token: 0x0601AC93 RID: 109715 RVA: 0x0073A0AC File Offset: 0x007382AC
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterLockOnComponent characterLockOnComponent = (CharacterLockOnComponent)componentTemplate;
		if (base.CanResetComponentProperty("StatTickMoveDir") && characterLockOnComponent.StatTickMoveDir != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.StatTickMoveDir), "StatTickMoveDir"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("StatTickCurrentInfo") && characterLockOnComponent.StatTickCurrentInfo != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.StatTickCurrentInfo), "StatTickCurrentInfo"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("StatCheck") && characterLockOnComponent.StatCheck != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.StatCheck), "StatCheck"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (characterLockOnComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("UnifiedStateComponent"))
		{
			if (characterLockOnComponent.UnifiedStateComponent == null)
			{
				this.UnifiedStateComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterUnifiedStateComponent>(this.UnifiedStateComponent), "UnifiedStateComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("InputComponent"))
		{
			if (characterLockOnComponent.InputComponent == null)
			{
				this.InputComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterInputComponent>(this.InputComponent), "InputComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("BuffComponent"))
		{
			if (characterLockOnComponent.BuffComponent == null)
			{
				this.BuffComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterBuffComponent>(this.BuffComponent), "BuffComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagListeners") && characterLockOnComponent.TagListeners != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<ITagTask>>(this.TagListeners), "TagListeners"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("MoveDirCache") && characterLockOnComponent.MoveDirCache != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.MoveDirCache), "MoveDirCache"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("IsForceLock"))
		{
			this.IsForceLock = characterLockOnComponent.IsForceLock;
		}
		if (base.CanResetComponentProperty("ForceLockId"))
		{
			this.ForceLockId = characterLockOnComponent.ForceLockId;
		}
		if (base.CanResetComponentProperty("ForceLockEntityAddDispose"))
		{
			if (characterLockOnComponent.ForceLockEntityAddDispose == null)
			{
				this.ForceLockEntityAddDispose = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TCbDispose>(this.ForceLockEntityAddDispose), "ForceLockEntityAddDispose"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsHardLockInternal"))
		{
			this.IsHardLockInternal = characterLockOnComponent.IsHardLockInternal;
		}
		if (base.CanResetComponentProperty("PredictedInfo"))
		{
			if (characterLockOnComponent.PredictedInfo == null)
			{
				this.PredictedInfo = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<LockOnInfo>(this.PredictedInfo), "PredictedInfo"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400CED2 RID: 52946
	private const string LOCK_DIR_COMPENSATE_REASON = "角色强锁补偿buff";

	// Token: 0x0400CED3 RID: 52947
	private readonly Stat StatTickMoveDir = Stat.Create("CharacterLockOnComponent.StatTickMoveDir", "", "");

	// Token: 0x0400CED4 RID: 52948
	private readonly Stat StatTickCurrentInfo = Stat.Create("CharacterLockOnComponent.StatTickCurrentInfo", "", "");

	// Token: 0x0400CED5 RID: 52949
	private readonly Stat StatCheck = Stat.Create("CharacterLockOnComponent.StatCheck", "", "");

	// Token: 0x0400CED6 RID: 52950
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400CED7 RID: 52951
	[Nullable(2)]
	private CharacterUnifiedStateComponent UnifiedStateComponent;

	// Token: 0x0400CED8 RID: 52952
	[Nullable(2)]
	private CharacterInputComponent InputComponent;

	// Token: 0x0400CED9 RID: 52953
	[Nullable(2)]
	private CharacterBuffComponent BuffComponent;

	// Token: 0x0400CEDA RID: 52954
	private readonly List<ITagTask> TagListeners = new List<ITagTask>();

	// Token: 0x0400CEDB RID: 52955
	private readonly global::Vector MoveDirCache = global::Vector.Create();

	// Token: 0x0400CEDC RID: 52956
	private bool IsForceLock;

	// Token: 0x0400CEDD RID: 52957
	private int ForceLockId;

	// Token: 0x0400CEDE RID: 52958
	[Nullable(2)]
	private TCbDispose ForceLockEntityAddDispose;

	// Token: 0x0400CEDF RID: 52959
	private bool IsHardLockInternal;

	// Token: 0x0400CEE0 RID: 52960
	[Nullable(2)]
	private LockOnInfo PredictedInfo;
}
