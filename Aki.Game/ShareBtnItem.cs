using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020025DE RID: 9694
public class ShareBtnItem : UiPanelBase
{
	// Token: 0x06013B4B RID: 80715 RVA: 0x004F02D8 File Offset: 0x004EE4D8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickShare))
		};
	}

	// Token: 0x06013B4C RID: 80716 RVA: 0x004F036B File Offset: 0x004EE56B
	private void OnClickShare()
	{
		if (this.ClickCallback != null)
		{
			this.ClickCallback();
		}
	}

	// Token: 0x06013B4D RID: 80717 RVA: 0x004F0380 File Offset: 0x004EE580
	[NullableContext(1)]
	public void SetClickCallBack(Action callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x06013B4E RID: 80718 RVA: 0x004F0389 File Offset: 0x004EE589
	public void SetShareActionId(EShareActionId shareId)
	{
		this.ShareActionId = shareId;
		this.SetShareTips();
	}

	// Token: 0x06013B4F RID: 80719 RVA: 0x004F0398 File Offset: 0x004EE598
	private void SetShareTips()
	{
		bool flag = ChannelModel.Instance.CouldGetShareReward(this.ShareActionId);
		base.GetItem(1).SetUIActive(flag);
		if (flag)
		{
			ShareReward? config = ConfigShareRewardById.GetConfig((int)this.ShareActionId, true);
			base.GetText(3).SetText(config.Value.GetReward(1).ToString(), true);
			base.GetTexture(2).SetUIActive(true);
			string icon = ItemConfig.Instance.GetConfig(config.Value.GetReward(0).Value).Value.Icon;
			base.SetTextureByPath(icon, base.GetTexture(2), null, null);
		}
	}

	// Token: 0x0400946F RID: 37999
	private EShareActionId ShareActionId = EShareActionId.Photo;

	// Token: 0x04009470 RID: 38000
	[Nullable(2)]
	private Action ClickCallback;

	// Token: 0x02008C16 RID: 35862
	private enum EChildType
	{
		// Token: 0x0402D7B0 RID: 186288
		ShareBtn,
		// Token: 0x0402D7B1 RID: 186289
		ShareTips,
		// Token: 0x0402D7B2 RID: 186290
		Icon,
		// Token: 0x0402D7B3 RID: 186291
		TxtCost
	}
}
