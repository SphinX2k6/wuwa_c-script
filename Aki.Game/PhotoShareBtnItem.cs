using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020025DD RID: 9693
public class PhotoShareBtnItem : GridProxyAbstract<EChannelShare>
{
	// Token: 0x06013B41 RID: 80705 RVA: 0x004F00F4 File Offset: 0x004EE2F4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickShare))
		};
	}

	// Token: 0x06013B42 RID: 80706 RVA: 0x004F015C File Offset: 0x004EE35C
	protected override void OnStart()
	{
		this.ShareGap = CommonConfig.Instance.GetShareGap().GetValueOrDefault(1);
		this.Transition = (base.GetSprite(0).GetOwner().GetComponentByClass(UUISpriteTransition.StaticClass()) as UUISpriteTransition);
	}

	// Token: 0x06013B43 RID: 80707 RVA: 0x004F01A8 File Offset: 0x004EE3A8
	private void OnClickShare()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		if (serverTime - this.LastClickTime < (double)this.ShareGap)
		{
			ScrollingTipsController.Instance.ShowTipsById("CannotShare", Array.Empty<object>());
			return;
		}
		this.LastClickTime = serverTime;
		int channelShareId = this.ChannelShareId;
		SharePlatform? config = ConfigSharePlatformById.GetConfig(channelShareId, true);
		if (config == null)
		{
			return;
		}
		int shareId = config.Value.ShareId;
		Action<EChannelShare, int> clickCallback = this.ClickCallback;
		if (clickCallback == null)
		{
			return;
		}
		clickCallback((EChannelShare)shareId, channelShareId);
	}

	// Token: 0x06013B44 RID: 80708 RVA: 0x004F0229 File Offset: 0x004EE429
	[NullableContext(1)]
	public void SetClickCallBack(Action<EChannelShare, int> callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x06013B45 RID: 80709 RVA: 0x004F0232 File Offset: 0x004EE432
	public override void Refresh(EChannelShare data, bool isSelected, int gridIndex)
	{
		this.Update((int)data);
		this.RefreshPanel();
	}

	// Token: 0x06013B46 RID: 80710 RVA: 0x004F0241 File Offset: 0x004EE441
	public void Update(int channelShareId)
	{
		this.ChannelShareId = channelShareId;
	}

	// Token: 0x06013B47 RID: 80711 RVA: 0x004F024C File Offset: 0x004EE44C
	public void RefreshPanel()
	{
		SharePlatform? config = ConfigSharePlatformById.GetConfig(this.ChannelShareId, true);
		if (config == null)
		{
			return;
		}
		this.SetSpriteByPath(config.Value.Icon, base.GetSprite(0), false, null, delegate(bool result)
		{
			UUISpriteTransition transition = this.Transition;
			if (transition == null)
			{
				return;
			}
			transition.SetAllTransitionSprite(base.GetSprite(0).GetSprite());
		});
	}

	// Token: 0x06013B48 RID: 80712 RVA: 0x004F02A2 File Offset: 0x004EE4A2
	protected override void OnBeforeDestroy()
	{
		this.Transition = null;
	}

	// Token: 0x0400946A RID: 37994
	private int ChannelShareId;

	// Token: 0x0400946B RID: 37995
	[Nullable(2)]
	private UUISpriteTransition Transition;

	// Token: 0x0400946C RID: 37996
	private double LastClickTime;

	// Token: 0x0400946D RID: 37997
	[Nullable(2)]
	private Action<EChannelShare, int> ClickCallback;

	// Token: 0x0400946E RID: 37998
	private int ShareGap = 1;

	// Token: 0x02008C15 RID: 35861
	private enum EChildType
	{
		// Token: 0x0402D7AD RID: 186285
		Icon,
		// Token: 0x0402D7AE RID: 186286
		Button
	}
}
