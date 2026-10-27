using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001947 RID: 6471
[NullableContext(2)]
[Nullable(0)]
public class MediumItemGridWarningPanelComponent : MediumItemGridComponent
{
	// Token: 0x0600BD0A RID: 48394 RVA: 0x002AC65E File Offset: 0x002AA85E
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_RoleComOccupy";
	}

	// Token: 0x0600BD0B RID: 48395 RVA: 0x002AC668 File Offset: 0x002AA868
	protected override UniTask OnBeforeStartAsync()
	{
		MediumItemGridWarningPanelComponent.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MediumItemGridWarningPanelComponent.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BD0C RID: 48396 RVA: 0x002AC6AC File Offset: 0x002AA8AC
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

	// Token: 0x04005550 RID: 21840
	private CommonWarningItem WarningItem;
}
