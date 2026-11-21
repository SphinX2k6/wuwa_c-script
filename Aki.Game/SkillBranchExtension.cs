using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200108D RID: 4237
[NullableContext(1)]
[Nullable(0)]
public class SkillBranchExtension : ISlotExtension
{
	// Token: 0x0600A859 RID: 43097 RVA: 0x00318AFB File Offset: 0x00316CFB
	public SkillBranchExtension()
	{
		this.ToggleHandler = new FormationSkillBranchToggleHandler(() => this.ToggleItem);
	}

	// Token: 0x0600A85A RID: 43098 RVA: 0x00318B1C File Offset: 0x00316D1C
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

	// Token: 0x0600A85B RID: 43099 RVA: 0x00318B68 File Offset: 0x00316D68
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

	// Token: 0x0600A85C RID: 43100 RVA: 0x00318BD2 File Offset: 0x00316DD2
	public void OnRefresh(IRoleSlotDisplayData data)
	{
		if (this.ToggleItem == null)
		{
			return;
		}
		this.ToggleHandler.Refresh(data.ConfigId, data.SkillBranch);
	}

	// Token: 0x0600A85D RID: 43101 RVA: 0x00318BF4 File Offset: 0x00316DF4
	public void OnSlotStartMove()
	{
		FormationRoleSlotSkillBranchToggleItem toggleItem = this.ToggleItem;
		if (toggleItem == null)
		{
			return;
		}
		toggleItem.SetUiActive(false);
	}

	// Token: 0x0600A85E RID: 43102 RVA: 0x00318C07 File Offset: 0x00316E07
	public void OnSlotStopMove()
	{
		this.ToggleHandler.ApplyLastDto();
	}

	// Token: 0x040061D7 RID: 25047
	[Nullable(2)]
	private FormationRoleSlotSkillBranchToggleItem ToggleItem;

	// Token: 0x040061D8 RID: 25048
	private readonly FormationSkillBranchToggleHandler ToggleHandler;
}
