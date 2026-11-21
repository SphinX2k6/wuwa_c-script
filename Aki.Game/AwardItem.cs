using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000678 RID: 1656
public class AwardItem : UiPanelBase
{
	// Token: 0x06004CAE RID: 19630 RVA: 0x001A0658 File Offset: 0x0019E858
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

	// Token: 0x06004CAF RID: 19631 RVA: 0x001A0748 File Offset: 0x0019E948
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

	// Token: 0x06004CB0 RID: 19632 RVA: 0x001A07E4 File Offset: 0x0019E9E4
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

	// Token: 0x0200693C RID: 26940
	private class EComponents
	{
		// Token: 0x04022A91 RID: 141969
		public const int DefaultBgSprite = 0;

		// Token: 0x04022A92 RID: 141970
		public const int SelectBgSprite = 1;

		// Token: 0x04022A93 RID: 141971
		public const int IconTexture = 2;

		// Token: 0x04022A94 RID: 141972
		public const int CountText = 3;

		// Token: 0x04022A95 RID: 141973
		public const int MaskSprite = 4;

		// Token: 0x04022A96 RID: 141974
		public const int ReceivedBgSprite = 5;
	}
}
