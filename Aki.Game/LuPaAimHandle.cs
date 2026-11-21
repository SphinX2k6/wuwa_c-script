using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using Cysharp.Threading.Tasks;

// Token: 0x020013F3 RID: 5107
[NullableContext(2)]
[Nullable(0)]
public class LuPaAimHandle : HudUnitHandleBase
{
	// Token: 0x0600CA64 RID: 51812 RVA: 0x003C2FAA File Offset: 0x003C11AA
	protected override void OnInitialize()
	{
		base.OnInitialize();
		this.TryActivate();
	}

	// Token: 0x0600CA65 RID: 51813 RVA: 0x003C2FB8 File Offset: 0x003C11B8
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRole));
		EventSystem.Instance.Add<EntityHandle>(EEventName.SpecialSkillLuPaSwitchLockTarget, new Action<EntityHandle>(this.OnSwitchLockTarget));
	}

	// Token: 0x0600CA66 RID: 51814 RVA: 0x003C2FEF File Offset: 0x003C11EF
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRole));
		EventSystem.Instance.Remove<EntityHandle>(EEventName.SpecialSkillLuPaSwitchLockTarget, new Action<EntityHandle>(this.OnSwitchLockTarget));
	}

	// Token: 0x0600CA67 RID: 51815 RVA: 0x003C3026 File Offset: 0x003C1226
	private void OnChangeRole(int newEntityId, int oldEntityId)
	{
		this.TryActivate();
	}

	// Token: 0x0600CA68 RID: 51816 RVA: 0x003C302E File Offset: 0x003C122E
	private void OnSwitchLockTarget(EntityHandle target)
	{
		this.LockTarget = target;
		this.RefreshLockState();
	}

	// Token: 0x0600CA69 RID: 51817 RVA: 0x003C303D File Offset: 0x003C123D
	private void RefreshAimVisible()
	{
		if (this.AimUnit == null)
		{
			return;
		}
		this.AimUnit.SetTargetVisible(this.IsAiming);
	}

	// Token: 0x0600CA6A RID: 51818 RVA: 0x003C3059 File Offset: 0x003C1259
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

	// Token: 0x0600CA6B RID: 51819 RVA: 0x003C3094 File Offset: 0x003C1294
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

	// Token: 0x0600CA6C RID: 51820 RVA: 0x003C3138 File Offset: 0x003C1338
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

	// Token: 0x0600CA6D RID: 51821 RVA: 0x003C319E File Offset: 0x003C139E
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

	// Token: 0x0600CA6E RID: 51822 RVA: 0x003C31D5 File Offset: 0x003C13D5
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

	// Token: 0x0600CA6F RID: 51823 RVA: 0x003C31F4 File Offset: 0x003C13F4
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

	// Token: 0x040072DA RID: 29402
	private const long BUFF_ID = 12076110101L;

	// Token: 0x040072DB RID: 29403
	private bool IsLoadingAimUnit;

	// Token: 0x040072DC RID: 29404
	private LuPaAimUnit AimUnit;

	// Token: 0x040072DD RID: 29405
	private ITagTask TagTask;

	// Token: 0x040072DE RID: 29406
	private bool IsAiming;

	// Token: 0x040072DF RID: 29407
	private CharacterBuffComponent BuffComponent;

	// Token: 0x040072E0 RID: 29408
	private IActiveBuff Buff;

	// Token: 0x040072E1 RID: 29409
	private int BuffHandle;

	// Token: 0x040072E2 RID: 29410
	private EntityHandle LockTarget;
}
