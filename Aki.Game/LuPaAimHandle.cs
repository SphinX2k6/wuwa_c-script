using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using Cysharp.Threading.Tasks;

// Token: 0x02001F31 RID: 7985
[NullableContext(2)]
[Nullable(0)]
public class LuPaAimHandle : HudUnitHandleBase
{
	// Token: 0x0600F645 RID: 63045 RVA: 0x003B74BE File Offset: 0x003B56BE
	protected override void OnInitialize()
	{
		base.OnInitialize();
		this.TryActivate();
	}

	// Token: 0x0600F646 RID: 63046 RVA: 0x003B74CC File Offset: 0x003B56CC
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRole));
		EventSystem.Instance.Add<EntityHandle>(EEventName.SpecialSkillLuPaSwitchLockTarget, new Action<EntityHandle>(this.OnSwitchLockTarget));
	}

	// Token: 0x0600F647 RID: 63047 RVA: 0x003B7503 File Offset: 0x003B5703
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRole));
		EventSystem.Instance.Remove<EntityHandle>(EEventName.SpecialSkillLuPaSwitchLockTarget, new Action<EntityHandle>(this.OnSwitchLockTarget));
	}

	// Token: 0x0600F648 RID: 63048 RVA: 0x003B753A File Offset: 0x003B573A
	private void OnChangeRole(int newEntityId, int oldEntityId)
	{
		this.TryActivate();
	}

	// Token: 0x0600F649 RID: 63049 RVA: 0x003B7542 File Offset: 0x003B5742
	private void OnSwitchLockTarget(EntityHandle target)
	{
		this.LockTarget = target;
		this.RefreshLockState();
	}

	// Token: 0x0600F64A RID: 63050 RVA: 0x003B7551 File Offset: 0x003B5751
	private void RefreshAimVisible()
	{
		if (this.AimUnit == null)
		{
			return;
		}
		this.AimUnit.SetTargetVisible(this.IsAiming);
	}

	// Token: 0x0600F64B RID: 63051 RVA: 0x003B756D File Offset: 0x003B576D
	private void RefreshLockState()
	{
		if (this.AimUnit == null)
		{
			return;
		}
		EntityHandle lockTarget = this.LockTarget;
		if (lockTarget != null && lockTarget.Valid)
		{
			this.AimUnit.SetLockState(true);
			return;
		}
		this.AimUnit.SetLockState(false);
	}

	// Token: 0x0600F64C RID: 63052 RVA: 0x003B75A8 File Offset: 0x003B57A8
	private void TryActivate()
	{
		BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
		if (curRoleData == null || curRoleData.CreatureRoleId != 1207)
		{
			this.Deactivate();
			return;
		}
		this.TagTask = curRoleData.GameplayTagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.瞄准镜头.露帕瞄准"]), new BaseTagComponent.TTagSwitchedCallback(this.OnAimTagChanged), null);
		this.IsAiming = curRoleData.GameplayTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.瞄准镜头.露帕瞄准"]);
		this.BuffComponent = curRoleData.BuffComponent;
		if (this.IsAiming)
		{
			this.Activate();
		}
	}

	// Token: 0x0600F64D RID: 63053 RVA: 0x003B764C File Offset: 0x003B584C
	private void Activate()
	{
		if (this.AimUnit != null)
		{
			this.RefreshAimVisible();
			return;
		}
		if (this.IsLoadingAimUnit)
		{
			return;
		}
		this.IsLoadingAimUnit = true;
		base.NewHudUnit<LuPaAimUnit>(typeof(LuPaAimUnit), "UiItem_AimLuPa", true, false).ContinueWith(delegate(LuPaAimUnit aimUnit)
		{
			this.AimUnit = aimUnit;
			this.RefreshAimVisible();
			this.RefreshLockState();
		}).Forget(delegate(Exception _)
		{
			this.IsLoadingAimUnit = false;
		}, true);
	}

	// Token: 0x0600F64E RID: 63054 RVA: 0x003B76B2 File Offset: 0x003B58B2
	private void Deactivate()
	{
		if (this.TagTask != null)
		{
			this.TagTask.EndTask();
			this.TagTask = null;
		}
		this.BuffComponent = null;
		this.IsAiming = false;
		this.LockTarget = null;
		this.RefreshAimVisible();
	}

	// Token: 0x0600F64F RID: 63055 RVA: 0x003B76E9 File Offset: 0x003B58E9
	private void OnAimTagChanged(int tagId, bool tagExist)
	{
		this.IsAiming = tagExist;
		if (this.IsAiming)
		{
			this.Activate();
			return;
		}
		this.RefreshAimVisible();
	}

	// Token: 0x0600F650 RID: 63056 RVA: 0x003B7708 File Offset: 0x003B5908
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
		if (!this.IsAiming || this.AimUnit == null || this.BuffComponent == null)
		{
			return;
		}
		if (this.Buff == null || this.BuffComponent.GetBuffByHandle(this.BuffHandle) == null)
		{
			this.Buff = this.BuffComponent.GetBuffById(12076110101L);
			IActiveBuff buff = this.Buff;
			this.BuffHandle = ((buff != null) ? buff.Handle : 0);
		}
		if (this.Buff != null && this.Buff.Duration > 0f)
		{
			this.AimUnit.SetProgress(this.Buff.GetRemainDuration() / this.Buff.Duration);
		}
	}

	// Token: 0x040071F9 RID: 29177
	private const long BUFF_ID = 12076110101L;

	// Token: 0x040071FA RID: 29178
	private bool IsLoadingAimUnit;

	// Token: 0x040071FB RID: 29179
	private LuPaAimUnit AimUnit;

	// Token: 0x040071FC RID: 29180
	private ITagTask TagTask;

	// Token: 0x040071FD RID: 29181
	private bool IsAiming;

	// Token: 0x040071FE RID: 29182
	private CharacterBuffComponent BuffComponent;

	// Token: 0x040071FF RID: 29183
	private IActiveBuff Buff;

	// Token: 0x04007200 RID: 29184
	private int BuffHandle;

	// Token: 0x04007201 RID: 29185
	private EntityHandle LockTarget;
}
