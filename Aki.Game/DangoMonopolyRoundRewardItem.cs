using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020006FF RID: 1791
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoMonopolyRoundRewardItem : GridProxyAbstract<IDangoMonopolyRoundRewardItemData>
{
	// Token: 0x060052C0 RID: 21184 RVA: 0x001B7B84 File Offset: 0x001B5D84
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyRoundRewardItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyRoundRewardItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060052C1 RID: 21185 RVA: 0x001B7BC8 File Offset: 0x001B5DC8
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

	// Token: 0x060052C2 RID: 21186 RVA: 0x001B7C38 File Offset: 0x001B5E38
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

	// Token: 0x060052C3 RID: 21187 RVA: 0x001B7D38 File Offset: 0x001B5F38
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

	// Token: 0x060052C4 RID: 21188 RVA: 0x001B7D87 File Offset: 0x001B5F87
	private void OnClickReward(MediumItemGridExtendCallback _)
	{
		Action<IDangoMonopolyRoundRewardItemData> clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack(this.ItemData);
	}

	// Token: 0x04003A78 RID: 14968
	private IDangoMonopolyRoundRewardItemData ItemData;

	// Token: 0x04003A79 RID: 14969
	public SmallItemGrid RewardItem;

	// Token: 0x04003A7A RID: 14970
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IDangoMonopolyRoundRewardItemData> ClickCallBack;

	// Token: 0x020069EC RID: 27116
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04022DE2 RID: 142818
		SpriteCurrent,
		// Token: 0x04022DE3 RID: 142819
		ItemReward,
		// Token: 0x04022DE4 RID: 142820
		TxtCount,
		// Token: 0x04022DE5 RID: 142821
		SpriteFinish
	}
}
