using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000E04 RID: 3588
[NullableContext(2)]
[Nullable(0)]
public class MediumItemGridWarningPanelComponent : MediumItemGridComponent
{
	// Token: 0x0600910D RID: 37133 RVA: 0x002B74A2 File Offset: 0x002B56A2
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_RoleComOccupy";
	}

	// Token: 0x0600910E RID: 37134 RVA: 0x002B74AC File Offset: 0x002B56AC
	protected override UniTask OnBeforeStartAsync()
	{
		MediumItemGridWarningPanelComponent.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MediumItemGridWarningPanelComponent.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600910F RID: 37135 RVA: 0x002B74F0 File Offset: 0x002B56F0
	protected override void OnRefresh(object data)
	{
		MediumWarningPanelInfo mediumWarningPanelInfo = data as MediumWarningPanelInfo;
		if (mediumWarningPanelInfo == null)
		{
			return;
		}
		if (!string.IsNullOrEmpty(mediumWarningPanelInfo.IconPath))
		{
			CommonWarningItem warningItem = this.WarningItem;
			if (warningItem != null)
			{
				warningItem.SetWarningIcon(mediumWarningPanelInfo.IconPath);
			}
		}
		CommonWarningItem warningItem2 = this.WarningItem;
		if (warningItem2 != null)
		{
			warningItem2.SetIconVisible(mediumWarningPanelInfo.IconPath != null);
		}
		CommonWarningItem warningItem3 = this.WarningItem;
		if (warningItem3 != null)
		{
			warningItem3.SetShowText(mediumWarningPanelInfo.TipText);
		}
		this.SetActive(true);
	}

	// Token: 0x040055FD RID: 22013
	private CommonWarningItem WarningItem;
}
