using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing.Components
{
	// Token: 0x02005223 RID: 21027
	public class PrizeDrawingRewardItem : UiPanelBase
	{
		// Token: 0x0603454D RID: 214349 RVA: 0x00EA42DE File Offset: 0x00EA24DE
		public PrizeDrawingRewardItem(int itemId, int count, int maxAmount)
		{
			this.ItemId = itemId;
			this.Count = count;
			this.MaxAmount = maxAmount;
		}

		// Token: 0x0603454E RID: 214350 RVA: 0x00EA4308 File Offset: 0x00EA2508
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603454F RID: 214351 RVA: 0x00EA43F8 File Offset: 0x00EA25F8
		protected override UniTask OnBeforeStartAsync()
		{
			PrizeDrawingRewardItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PrizeDrawingRewardItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034550 RID: 214352 RVA: 0x00EA443C File Offset: 0x00EA263C
		private UniTask Initialize(int itemId, int count, int rewardMaxAmount)
		{
			PrizeDrawingRewardItem.<Initialize>d__8 <Initialize>d__;
			<Initialize>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.itemId = itemId;
			<Initialize>d__.count = count;
			<Initialize>d__.rewardMaxAmount = rewardMaxAmount;
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<PrizeDrawingRewardItem.<Initialize>d__8>(ref <Initialize>d__);
			return <Initialize>d__.<>t__builder.Task;
		}

		// Token: 0x06034551 RID: 214353 RVA: 0x00EA4498 File Offset: 0x00EA2698
		public void Refresh(int acquiredCount, bool animBanned = false)
		{
			for (int i = 0; i < this.GotItemList.Count; i++)
			{
				this.GotItemList[i].RefreshGotState(i + 1 <= acquiredCount, animBanned);
			}
		}

		// Token: 0x0401BC94 RID: 113812
		[Nullable(1)]
		private readonly List<GotItem> GotItemList = new List<GotItem>();

		// Token: 0x0401BC95 RID: 113813
		private readonly int ItemId;

		// Token: 0x0401BC96 RID: 113814
		private readonly int Count;

		// Token: 0x0401BC97 RID: 113815
		private readonly int MaxAmount;

		// Token: 0x0200AE6E RID: 44654
		private enum EPrizeItemType
		{
			// Token: 0x04035E23 RID: 220707
			TexIcon,
			// Token: 0x04035E24 RID: 220708
			TxtName,
			// Token: 0x04035E25 RID: 220709
			TxtTotal,
			// Token: 0x04035E26 RID: 220710
			PnlGrid,
			// Token: 0x04035E27 RID: 220711
			PrizeItem,
			// Token: 0x04035E28 RID: 220712
			TxtCount
		}
	}
}
