using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001BD1 RID: 7121
public class TrialExtension : ISlotExtension
{
	// Token: 0x0600D45C RID: 54364 RVA: 0x0030DFB4 File Offset: 0x0030C1B4
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

	// Token: 0x0600D45D RID: 54365 RVA: 0x0030DFFF File Offset: 0x0030C1FF
	public void OnDetach()
	{
		this.TrialLabelItem = null;
	}

	// Token: 0x0600D45E RID: 54366 RVA: 0x0030E008 File Offset: 0x0030C208
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

	// Token: 0x0400610A RID: 24842
	[Nullable(2)]
	private RoleTrialLabelItem TrialLabelItem;
}
