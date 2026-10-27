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
	// Token: 0x020062A3 RID: 25251
	public class PrizeDrawingFinalRewardItem : UiPanelBase
	{
		// Token: 0x0603F87B RID: 260219 RVA: 0x00F5CD9B File Offset: 0x00F5AF9B
		public PrizeDrawingFinalRewardItem(int itemId, int count)
		{
			this.ItemId = itemId;
			this.Count = count;
		}

		// Token: 0x0603F87C RID: 260220 RVA: 0x00F5CDB4 File Offset: 0x00F5AFB4
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603F87D RID: 260221 RVA: 0x00F5CEA4 File Offset: 0x00F5B0A4
		protected override UniTask OnBeforeStartAsync()
		{
			PrizeDrawingFinalRewardItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PrizeDrawingFinalRewardItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F87E RID: 260222 RVA: 0x00F5CEE8 File Offset: 0x00F5B0E8
		private UniTask Initialize(int itemId, int count)
		{
			PrizeDrawingFinalRewardItem.<Initialize>d__7 <Initialize>d__;
			<Initialize>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.itemId = itemId;
			<Initialize>d__.count = count;
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<PrizeDrawingFinalRewardItem.<Initialize>d__7>(ref <Initialize>d__);
			return <Initialize>d__.<>t__builder.Task;
		}

		// Token: 0x0603F87F RID: 260223 RVA: 0x00F5CF3B File Offset: 0x00F5B13B
		public void Refresh(bool isGot, bool animBanned = false)
		{
			GotItem gotItem = this.GotItem;
			if (gotItem == null)
			{
				return;
			}
			gotItem.RefreshGotState(isGot, animBanned);
		}

		// Token: 0x0402135F RID: 136031
		[Nullable(2)]
		private GotItem GotItem;

		// Token: 0x04021360 RID: 136032
		private readonly int ItemId;

		// Token: 0x04021361 RID: 136033
		private readonly int Count;

		// Token: 0x0200C481 RID: 50305
		private enum EComp
		{
			// Token: 0x0403B4A1 RID: 242849
			TexIcon,
			// Token: 0x0403B4A2 RID: 242850
			TxtName,
			// Token: 0x0403B4A3 RID: 242851
			SprGot,
			// Token: 0x0403B4A4 RID: 242852
			PnlTagCur,
			// Token: 0x0403B4A5 RID: 242853
			TxtCount,
			// Token: 0x0403B4A6 RID: 242854
			GotItem
		}
	}
}
