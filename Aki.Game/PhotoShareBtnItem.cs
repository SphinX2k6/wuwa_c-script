using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001AC8 RID: 6856
public class PhotoShareBtnItem : GridProxyAbstract<EChannelShare>
{
	// Token: 0x06011023 RID: 69667 RVA: 0x004FEE24 File Offset: 0x004FD024
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

	// Token: 0x06011024 RID: 69668 RVA: 0x004FEE8C File Offset: 0x004FD08C
	protected override void OnStart()
	{
		this.ShareGap = CommonConfig.Instance.GetShareGap().GetValueOrDefault(1);
		this.Transition = (base.GetSprite(0).GetOwner().GetComponentByClass(UUISpriteTransition.StaticClass()) as UUISpriteTransition);
	}

	// Token: 0x06011025 RID: 69669 RVA: 0x004FEED8 File Offset: 0x004FD0D8
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

	// Token: 0x06011026 RID: 69670 RVA: 0x004FEF59 File Offset: 0x004FD159
	[NullableContext(1)]
	public void SetClickCallBack(Action<EChannelShare, int> callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x06011027 RID: 69671 RVA: 0x004FEF62 File Offset: 0x004FD162
	public override void Refresh(EChannelShare data, bool isSelected, int gridIndex)
	{
		this.Update((int)data);
		this.RefreshPanel();
	}

	// Token: 0x06011028 RID: 69672 RVA: 0x004FEF71 File Offset: 0x004FD171
	public void Update(int channelShareId)
	{
		this.ChannelShareId = channelShareId;
	}

	// Token: 0x06011029 RID: 69673 RVA: 0x004FEF7C File Offset: 0x004FD17C
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

	// Token: 0x0601102A RID: 69674 RVA: 0x004FEFD2 File Offset: 0x004FD1D2
	protected override void OnBeforeDestroy()
	{
		this.Transition = null;
	}

	// Token: 0x040095C1 RID: 38337
	private int ChannelShareId;

	// Token: 0x040095C2 RID: 38338
	[Nullable(2)]
	private UUISpriteTransition Transition;

	// Token: 0x040095C3 RID: 38339
	private double LastClickTime;

	// Token: 0x040095C4 RID: 38340
	[Nullable(2)]
	private Action<EChannelShare, int> ClickCallback;

	// Token: 0x040095C5 RID: 38341
	private int ShareGap = 1;

	// Token: 0x02007D9E RID: 32158
	private enum EChildType
	{
		// Token: 0x04028AC5 RID: 166597
		Icon,
		// Token: 0x04028AC6 RID: 166598
		Button
	}
}
