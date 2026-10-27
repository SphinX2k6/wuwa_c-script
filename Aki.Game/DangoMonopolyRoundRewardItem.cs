using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200124B RID: 4683
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoMonopolyRoundRewardItem : GridProxyAbstract<IDangoMonopolyRoundRewardItemData>
{
	// Token: 0x06007F29 RID: 32553 RVA: 0x001AEECC File Offset: 0x001AD0CC
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyRoundRewardItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyRoundRewardItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007F2A RID: 32554 RVA: 0x001AEF10 File Offset: 0x001AD110
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUISprite))
		};
	}

	// Token: 0x06007F2B RID: 32555 RVA: 0x001AEF80 File Offset: 0x001AD180
	public override void Refresh(IDangoMonopolyRoundRewardItemData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		bool isReceived = this.ItemData.IsReceived;
		UUISprite sprite = base.GetSprite(0);
		if (sprite != null)
		{
			sprite.SetUIActive(false);
		}
		UUISprite sprite2 = base.GetSprite(3);
		if (sprite2 != null)
		{
			sprite2.SetUIActive(isReceived);
		}
		UUIText text = base.GetText(2);
		text.SetText(this.ItemData.Position.ToString(), true);
		UUIItem uuiitem = text;
		bool bUseChangeColor = isReceived;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = this.ItemData,
			ItemConfigId = new int?(this.ItemData.ItemId),
			IsRedDotVisible = new bool?(this.ItemData.IsCanReceived),
			IsReceivedVisible = new bool?(this.ItemData.IsReceived),
			IsReceivableVisible = new bool?(this.ItemData.IsCanReceived),
			BottomText = this.GetCountStr()
		};
		this.RewardItem.Apply<PropSmallItemGrid>(parameters);
	}

	// Token: 0x06007F2C RID: 32556 RVA: 0x001AF080 File Offset: 0x001AD280
	public string GetCountStr()
	{
		if (this.ItemData.Count > 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
			defaultInterpolatedStringHandler.AppendLiteral("x ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.ItemData.Count);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return "";
	}

	// Token: 0x06007F2D RID: 32557 RVA: 0x001AF0CF File Offset: 0x001AD2CF
	private void OnClickReward(MediumItemGridExtendCallback _)
	{
		Action<IDangoMonopolyRoundRewardItemData> clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack(this.ItemData);
	}

	// Token: 0x040039E0 RID: 14816
	private IDangoMonopolyRoundRewardItemData ItemData;

	// Token: 0x040039E1 RID: 14817
	public SmallItemGrid RewardItem;

	// Token: 0x040039E2 RID: 14818
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IDangoMonopolyRoundRewardItemData> ClickCallBack;

	// Token: 0x02007861 RID: 30817
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04027AB1 RID: 162481
		SpriteCurrent,
		// Token: 0x04027AB2 RID: 162482
		ItemReward,
		// Token: 0x04027AB3 RID: 162483
		TxtCount,
		// Token: 0x04027AB4 RID: 162484
		SpriteFinish
	}
}
