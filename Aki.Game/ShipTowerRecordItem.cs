using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F3A RID: 7994
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerRecordItem : GridProxyAbstract<ShipTowerRecordItemData>
{
	// Token: 0x06013C7B RID: 81019 RVA: 0x005C52B4 File Offset: 0x005C34B4
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

	// Token: 0x06013C7C RID: 81020 RVA: 0x005C533C File Offset: 0x005C353C
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerRecordItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerRecordItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013C7D RID: 81021 RVA: 0x005C537F File Offset: 0x005C357F
	public override void Refresh(ShipTowerRecordItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x06013C7E RID: 81022 RVA: 0x005C5388 File Offset: 0x005C3588
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

	// Token: 0x06013C7F RID: 81023 RVA: 0x005C546E File Offset: 0x005C366E
	private ShipTowerMediumItem CreateMediumItem()
	{
		ShipTowerMediumItem shipTowerMediumItem = new ShipTowerMediumItem();
		shipTowerMediumItem.RefreshCallBack = new Action<ShipTowerMediumItemData>(shipTowerMediumItem.RefreshRecord);
		return shipTowerMediumItem;
	}

	// Token: 0x0400A8EB RID: 43243
	private ShipTowerRecordItemData ItemData;

	// Token: 0x0400A8EC RID: 43244
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerMediumItem, ShipTowerMediumItemData> RewardLayout;

	// Token: 0x0400A8ED RID: 43245
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerRecordItemData> ClickCallBack;

	// Token: 0x02008222 RID: 33314
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A056 RID: 172118
		public const int TextName = 0;

		// Token: 0x0402A057 RID: 172119
		public const int TextScore = 1;

		// Token: 0x0402A058 RID: 172120
		public const int TextWave = 2;

		// Token: 0x0402A059 RID: 172121
		public const int HLayoutTeam = 3;

		// Token: 0x0402A05A RID: 172122
		public const int TextureBuffIcon = 4;
	}
}
