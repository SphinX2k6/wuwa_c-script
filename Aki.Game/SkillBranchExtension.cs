using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001BCE RID: 7118
[NullableContext(1)]
[Nullable(0)]
public class SkillBranchExtension : ISlotExtension
{
	// Token: 0x0600D447 RID: 54343 RVA: 0x0030D987 File Offset: 0x0030BB87
	public SkillBranchExtension()
	{
		this.ToggleHandler = new FormationSkillBranchToggleHandler(() => this.ToggleItem);
	}

	// Token: 0x0600D448 RID: 54344 RVA: 0x0030D9A8 File Offset: 0x0030BBA8
	public UniTask OnAttach(ISlotMountPoint mount, int position)
	{
		SkillBranchExtension.<OnAttach>d__3 <OnAttach>d__;
		<OnAttach>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnAttach>d__.<>4__this = this;
		<OnAttach>d__.mount = mount;
		<OnAttach>d__.<>1__state = -1;
		<OnAttach>d__.<>t__builder.Start<SkillBranchExtension.<OnAttach>d__3>(ref <OnAttach>d__);
		return <OnAttach>d__.<>t__builder.Task;
	}

	// Token: 0x0600D449 RID: 54345 RVA: 0x0030D9F4 File Offset: 0x0030BBF4
	public void OnDetach()
	{
		if (this.ToggleItem == null)
		{
			return;
		}
		EventSystem.Instance.Remove<int>(EEventName.OnRoleSkillBranchChanged, new Action<int>(this.ToggleHandler.OnRoleSkillBranchChanged));
		EventSystem.Instance.Remove<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.ToggleHandler.OnRoleSkillBranchChanged));
		this.ToggleHandler.Clear();
		this.ToggleItem = null;
	}

	// Token: 0x0600D44A RID: 54346 RVA: 0x0030DA5E File Offset: 0x0030BC5E
	public void OnRefresh(IRoleSlotDisplayData data)
	{
		if (this.ToggleItem == null)
		{
			return;
		}
		this.ToggleHandler.Refresh(data.ConfigId, data.SkillBranch);
	}

	// Token: 0x0600D44B RID: 54347 RVA: 0x0030DA80 File Offset: 0x0030BC80
	public void OnSlotStartMove()
	{
		FormationRoleSlotSkillBranchToggleItem toggleItem = this.ToggleItem;
		if (toggleItem == null)
		{
			return;
		}
		toggleItem.SetUiActive(false);
	}

	// Token: 0x0600D44C RID: 54348 RVA: 0x0030DA93 File Offset: 0x0030BC93
	public void OnSlotStopMove()
	{
		this.ToggleHandler.ApplyLastDto();
	}

	// Token: 0x04006108 RID: 24840
	[Nullable(2)]
	private FormationRoleSlotSkillBranchToggleItem ToggleItem;

	// Token: 0x04006109 RID: 24841
	private readonly FormationSkillBranchToggleHandler ToggleHandler;
}
