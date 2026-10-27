using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews
{
	// Token: 0x020047C0 RID: 18368
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardItemBar : UiPanelBase
	{
		// Token: 0x060301D9 RID: 197081 RVA: 0x00B273DC File Offset: 0x00B255DC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060301DA RID: 197082 RVA: 0x00B27468 File Offset: 0x00B25668
		protected override void OnStart()
		{
			this.RewardLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetGridLayout(1), new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, true);
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetText(ConfigMultiTextLang.GetLocalTextNew("PassReward", null) ?? "", true);
		}

		// Token: 0x060301DB RID: 197083 RVA: 0x00B274BC File Offset: 0x00B256BC
		private CommonItemSmallItemGrid CreatePropItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = ((TItem data) => this.FinishReward)
			};
		}

		// Token: 0x060301DC RID: 197084 RVA: 0x00B274D5 File Offset: 0x00B256D5
		[NullableContext(2)]
		public void RebuildRewardsByData(List<TItem> data = null)
		{
			GenericLayout<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
			if (rewardLayout == null)
			{
				return;
			}
			rewardLayout.RefreshByData(data ?? new List<TItem>(), null, false);
		}

		// Token: 0x060301DD RID: 197085 RVA: 0x00B274F3 File Offset: 0x00B256F3
		public void RebuildRewardsByLevelRewardData(CommonLevelPlayPanelRewardData data)
		{
			this.FinishReward = data.FinishRecord;
			GenericLayout<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
			if (rewardLayout == null)
			{
				return;
			}
			rewardLayout.RefreshByData(data.ItemList, null, false);
		}

		// Token: 0x060301DE RID: 197086 RVA: 0x00B27519 File Offset: 0x00B25719
		public void SetTitleNewTxt(string newTxtId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), newTxtId, Array.Empty<object>());
		}

		// Token: 0x04019ED4 RID: 106196
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x04019ED5 RID: 106197
		private bool FinishReward;

		// Token: 0x0200AA82 RID: 43650
		[NullableContext(0)]
		public static class ERewardItemBarChildCom
		{
			// Token: 0x04033E13 RID: 212499
			public const int UiTextInstanceTitle = 0;

			// Token: 0x04033E14 RID: 212500
			public const int UiItemContainer = 1;

			// Token: 0x04033E15 RID: 212501
			public const int UiItemItem = 2;
		}
	}
}
