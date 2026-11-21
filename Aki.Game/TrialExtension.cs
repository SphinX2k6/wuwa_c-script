using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001090 RID: 4240
public class TrialExtension : ISlotExtension
{
	// Token: 0x0600A86E RID: 43118 RVA: 0x00319128 File Offset: 0x00317328
	[NullableContext(1)]
	public UniTask OnAttach(ISlotMountPoint mount, int position)
	{
		TrialExtension.<OnAttach>d__1 <OnAttach>d__;
		<OnAttach>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnAttach>d__.<>4__this = this;
		<OnAttach>d__.mount = mount;
		<OnAttach>d__.<>1__state = -1;
		<OnAttach>d__.<>t__builder.Start<TrialExtension.<OnAttach>d__1>(ref <OnAttach>d__);
		return <OnAttach>d__.<>t__builder.Task;
	}

	// Token: 0x0600A86F RID: 43119 RVA: 0x00319173 File Offset: 0x00317373
	public void OnDetach()
	{
		this.TrialLabelItem = null;
	}

	// Token: 0x0600A870 RID: 43120 RVA: 0x0031917C File Offset: 0x0031737C
	[NullableContext(1)]
	public void OnRefresh(IRoleSlotDisplayData data)
	{
		if (this.TrialLabelItem == null)
		{
			return;
		}
		int configId = data.ConfigId;
		if (!RoleUtils.IsTrialRole(configId))
		{
			this.TrialLabelItem.SetUiActive(false);
			return;
		}
		if (RoleUtils.GetTrialRoleType(configId) == ETrialRoleType.None)
		{
			this.TrialLabelItem.SetUiActive(false);
			return;
		}
		this.TrialLabelItem.SetUiActive(true);
		this.TrialLabelItem.Refresh(configId);
	}

	// Token: 0x040061D9 RID: 25049
	[Nullable(2)]
	private RoleTrialLabelItem TrialLabelItem;
}
