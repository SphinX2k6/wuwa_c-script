using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029BF RID: 10687
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerRecordItem : GridProxyAbstract<ShipTowerRecordItemData>
{
	// Token: 0x06016275 RID: 90741 RVA: 0x0059A328 File Offset: 0x00598528
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUITexture))
		};
	}

	// Token: 0x06016276 RID: 90742 RVA: 0x0059A3B0 File Offset: 0x005985B0
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerRecordItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerRecordItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016277 RID: 90743 RVA: 0x0059A3F3 File Offset: 0x005985F3
	public override void Refresh(ShipTowerRecordItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x06016278 RID: 90744 RVA: 0x0059A3FC File Offset: 0x005985FC
	public void Refresh(ShipTowerRecordItemData data)
	{
		this.ItemData = data;
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetText(this.ItemData.Title, true);
		}
		UUIText text2 = base.GetText(1);
		if (text2 != null)
		{
			text2.SetText(this.ItemData.Score.ToString(), true);
		}
		UUIText text3 = base.GetText(2);
		if (text3 != null)
		{
			text3.SetText(this.ItemData.Wave.ToString(), true);
		}
		List<ShipTowerMediumItemData> list = (this.ItemData.TeamList != null) ? new List<ShipTowerMediumItemData>(this.ItemData.TeamList) : new List<ShipTowerMediumItemData>();
		list.Add(new ShipTowerMediumItemData
		{
			Id = this.ItemData.BuffId,
			Count = 1,
			IsBuff = new bool?(true),
			SkillBranchId = 0
		});
		GenericLayout<ShipTowerMediumItem, ShipTowerMediumItemData> rewardLayout = this.RewardLayout;
		if (rewardLayout == null)
		{
			return;
		}
		rewardLayout.RefreshByData(list, null, false);
	}

	// Token: 0x06016279 RID: 90745 RVA: 0x0059A4E2 File Offset: 0x005986E2
	private ShipTowerMediumItem CreateMediumItem()
	{
		ShipTowerMediumItem shipTowerMediumItem = new ShipTowerMediumItem();
		shipTowerMediumItem.RefreshCallBack = new Action<ShipTowerMediumItemData>(shipTowerMediumItem.RefreshRecord);
		return shipTowerMediumItem;
	}

	// Token: 0x0400A501 RID: 42241
	private ShipTowerRecordItemData ItemData;

	// Token: 0x0400A502 RID: 42242
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerMediumItem, ShipTowerMediumItemData> RewardLayout;

	// Token: 0x0400A503 RID: 42243
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerRecordItemData> ClickCallBack;

	// Token: 0x02008FDA RID: 36826
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E959 RID: 190809
		public const int TextName = 0;

		// Token: 0x0402E95A RID: 190810
		public const int TextScore = 1;

		// Token: 0x0402E95B RID: 190811
		public const int TextWave = 2;

		// Token: 0x0402E95C RID: 190812
		public const int HLayoutTeam = 3;

		// Token: 0x0402E95D RID: 190813
		public const int TextureBuffIcon = 4;
	}
}
