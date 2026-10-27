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
	// Token: 0x020062A5 RID: 25253
	public class PrizeDrawingRewardItem : UiPanelBase
	{
		// Token: 0x0603F88C RID: 260236 RVA: 0x00F5D381 File Offset: 0x00F5B581
		public PrizeDrawingRewardItem(int itemId, int count, int maxAmount)
		{
			this.ItemId = itemId;
			this.Count = count;
			this.MaxAmount = maxAmount;
		}

		// Token: 0x0603F88D RID: 260237 RVA: 0x00F5D3AC File Offset: 0x00F5B5AC
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

		// Token: 0x0603F88E RID: 260238 RVA: 0x00F5D49C File Offset: 0x00F5B69C
		protected override UniTask OnBeforeStartAsync()
		{
			PrizeDrawingRewardItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PrizeDrawingRewardItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F88F RID: 260239 RVA: 0x00F5D4E0 File Offset: 0x00F5B6E0
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

		// Token: 0x0603F890 RID: 260240 RVA: 0x00F5D53C File Offset: 0x00F5B73C
		public void Refresh(int acquiredCount, bool animBanned = false)
		{
			for (int i = 0; i < this.GotItemList.Count; i++)
			{
				this.GotItemList[i].RefreshGotState(i + 1 <= acquiredCount, animBanned);
			}
		}

		// Token: 0x04021365 RID: 136037
		[Nullable(1)]
		private readonly List<GotItem> GotItemList = new List<GotItem>();

		// Token: 0x04021366 RID: 136038
		private readonly int ItemId;

		// Token: 0x04021367 RID: 136039
		private readonly int Count;

		// Token: 0x04021368 RID: 136040
		private readonly int MaxAmount;

		// Token: 0x0200C487 RID: 50311
		private enum EPrizeItemType
		{
			// Token: 0x0403B4C1 RID: 242881
			TexIcon,
			// Token: 0x0403B4C2 RID: 242882
			TxtName,
			// Token: 0x0403B4C3 RID: 242883
			TxtTotal,
			// Token: 0x0403B4C4 RID: 242884
			PnlGrid,
			// Token: 0x0403B4C5 RID: 242885
			PrizeItem,
			// Token: 0x0403B4C6 RID: 242886
			TxtCount
		}
	}
}
