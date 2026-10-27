using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011C4 RID: 4548
public class AwardItem : UiPanelBase
{
	// Token: 0x06007917 RID: 30999 RVA: 0x001979A8 File Offset: 0x00195BA8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007918 RID: 31000 RVA: 0x00197A98 File Offset: 0x00195C98
	[NullableContext(1)]
	public void Refresh(TimePointRewardData data, IntPair rewardItem)
	{
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(rewardItem.Item1);
		if (itemConfigData == null)
		{
			return;
		}
		string text = itemConfigData.Icon;
		if (itemConfigData.ItemDataType == InventoryDefine.EItemDataType.PlayerHeadItem)
		{
			PlayerHeadRe? playerHeadRe;
			text = (((ConfigPlayerHeadReById.GetConfig(rewardItem.Item1, true) != null) ? playerHeadRe.GetValueOrDefault().RoleHeadIconCircle : null) ?? text);
		}
		base.SetTextureByPath(text, base.GetTexture(2), null, null);
		base.GetText(3).SetText(rewardItem.Item2.ToString(), true);
	}

	// Token: 0x06007919 RID: 31001 RVA: 0x00197B34 File Offset: 0x00195D34
	[NullableContext(1)]
	public void RefreshState(TimePointRewardData data)
	{
		bool uiactive = data.RewardState == ETimePointRewardState.Lock;
		bool uiactive2 = data.RewardState == ETimePointRewardState.UnlockAndUnClaimed;
		bool uiactive3 = data.RewardState == ETimePointRewardState.UnlockAndClaimed;
		base.GetSprite(0).SetUIActive(uiactive);
		base.GetSprite(1).SetUIActive(uiactive2);
		base.GetSprite(4).SetUIActive(uiactive3);
		base.GetSprite(5).SetUIActive(uiactive3);
	}

	// Token: 0x020077B1 RID: 30641
	private class EComponents
	{
		// Token: 0x0402775F RID: 161631
		public const int DefaultBgSprite = 0;

		// Token: 0x04027760 RID: 161632
		public const int SelectBgSprite = 1;

		// Token: 0x04027761 RID: 161633
		public const int IconTexture = 2;

		// Token: 0x04027762 RID: 161634
		public const int CountText = 3;

		// Token: 0x04027763 RID: 161635
		public const int MaskSprite = 4;

		// Token: 0x04027764 RID: 161636
		public const int ReceivedBgSprite = 5;
	}
}
