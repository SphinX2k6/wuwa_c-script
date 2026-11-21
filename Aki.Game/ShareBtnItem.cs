using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001AC9 RID: 6857
public class ShareBtnItem : UiPanelBase
{
	// Token: 0x0601102D RID: 69677 RVA: 0x004FF008 File Offset: 0x004FD208
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

	// Token: 0x0601102E RID: 69678 RVA: 0x004FF09B File Offset: 0x004FD29B
	private void OnClickShare()
	{
		if (this.ClickCallback != null)
		{
			this.ClickCallback();
		}
	}

	// Token: 0x0601102F RID: 69679 RVA: 0x004FF0B0 File Offset: 0x004FD2B0
	[NullableContext(1)]
	public void SetClickCallBack(Action callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x06011030 RID: 69680 RVA: 0x004FF0B9 File Offset: 0x004FD2B9
	public void SetShareActionId(EShareActionId shareId)
	{
		this.ShareActionId = shareId;
		this.SetShareTips();
	}

	// Token: 0x06011031 RID: 69681 RVA: 0x004FF0C8 File Offset: 0x004FD2C8
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

	// Token: 0x040095C6 RID: 38342
	private EShareActionId ShareActionId = EShareActionId.Photo;

	// Token: 0x040095C7 RID: 38343
	[Nullable(2)]
	private Action ClickCallback;

	// Token: 0x02007D9F RID: 32159
	private enum EChildType
	{
		// Token: 0x04028AC8 RID: 166600
		ShareBtn,
		// Token: 0x04028AC9 RID: 166601
		ShareTips,
		// Token: 0x04028ACA RID: 166602
		Icon,
		// Token: 0x04028ACB RID: 166603
		TxtCost
	}
}
