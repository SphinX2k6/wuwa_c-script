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
	// Token: 0x02005221 RID: 21025
	public class PrizeDrawingFinalRewardItem : UiPanelBase
	{
		// Token: 0x0603453C RID: 214332 RVA: 0x00EA3CF7 File Offset: 0x00EA1EF7
		public PrizeDrawingFinalRewardItem(int itemId, int count)
		{
			this.ItemId = itemId;
			this.Count = count;
		}

		// Token: 0x0603453D RID: 214333 RVA: 0x00EA3D10 File Offset: 0x00EA1F10
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

		// Token: 0x0603453E RID: 214334 RVA: 0x00EA3E00 File Offset: 0x00EA2000
		protected override UniTask OnBeforeStartAsync()
		{
			PrizeDrawingFinalRewardItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PrizeDrawingFinalRewardItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603453F RID: 214335 RVA: 0x00EA3E44 File Offset: 0x00EA2044
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

		// Token: 0x06034540 RID: 214336 RVA: 0x00EA3E97 File Offset: 0x00EA2097
		public void Refresh(bool isGot, bool animBanned = false)
		{
			GotItem gotItem = this.GotItem;
			if (gotItem == null)
			{
				return;
			}
			gotItem.RefreshGotState(isGot, animBanned);
		}

		// Token: 0x0401BC8E RID: 113806
		[Nullable(2)]
		private GotItem GotItem;

		// Token: 0x0401BC8F RID: 113807
		private readonly int ItemId;

		// Token: 0x0401BC90 RID: 113808
		private readonly int Count;

		// Token: 0x0200AE68 RID: 44648
		private enum EComp
		{
			// Token: 0x04035E03 RID: 220675
			TexIcon,
			// Token: 0x04035E04 RID: 220676
			TxtName,
			// Token: 0x04035E05 RID: 220677
			SprGot,
			// Token: 0x04035E06 RID: 220678
			PnlTagCur,
			// Token: 0x04035E07 RID: 220679
			TxtCount,
			// Token: 0x04035E08 RID: 220680
			GotItem
		}
	}
}
