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
	// Token: 0x020036F1 RID: 14065
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardItemBar : UiPanelBase
	{
		// Token: 0x060249A9 RID: 149929 RVA: 0x00A571E8 File Offset: 0x00A553E8
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

		// Token: 0x060249AA RID: 149930 RVA: 0x00A57274 File Offset: 0x00A55474
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

		// Token: 0x060249AB RID: 149931 RVA: 0x00A572C8 File Offset: 0x00A554C8
		private CommonItemSmallItemGrid CreatePropItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = ((TItem data) => this.FinishReward)
			};
		}

		// Token: 0x060249AC RID: 149932 RVA: 0x00A572E1 File Offset: 0x00A554E1
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

		// Token: 0x060249AD RID: 149933 RVA: 0x00A572FF File Offset: 0x00A554FF
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

		// Token: 0x060249AE RID: 149934 RVA: 0x00A57325 File Offset: 0x00A55525
		public void SetTitleNewTxt(string newTxtId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), newTxtId, Array.Empty<object>());
		}

		// Token: 0x04014585 RID: 83333
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x04014586 RID: 83334
		private bool FinishReward;

		// Token: 0x02009435 RID: 37941
		[NullableContext(0)]
		public static class ERewardItemBarChildCom
		{
			// Token: 0x0402E59C RID: 189852
			public const int UiTextInstanceTitle = 0;

			// Token: 0x0402E59D RID: 189853
			public const int UiItemContainer = 1;

			// Token: 0x0402E59E RID: 189854
			public const int UiItemItem = 2;
		}
	}
}
