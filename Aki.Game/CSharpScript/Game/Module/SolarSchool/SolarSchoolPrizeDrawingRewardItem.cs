using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200591A RID: 22810
	public class SolarSchoolPrizeDrawingRewardItem : UiPanelBase
	{
		// Token: 0x060383B8 RID: 230328 RVA: 0x00FB8BCB File Offset: 0x00FB6DCB
		public SolarSchoolPrizeDrawingRewardItem(int itemId, int count, int maxAmount)
		{
			this.ItemId = itemId;
			this.Count = count;
			this.MaxAmount = maxAmount;
		}

		// Token: 0x060383B9 RID: 230329 RVA: 0x00FB8BF4 File Offset: 0x00FB6DF4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickIcon));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060383BA RID: 230330 RVA: 0x00FB8D3F File Offset: 0x00FB6F3F
		private void OnClickIcon()
		{
			SolarSchoolUtils.ShowItemDetailPopup(this.ItemId, 0, null);
		}

		// Token: 0x060383BB RID: 230331 RVA: 0x00FB8D50 File Offset: 0x00FB6F50
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolPrizeDrawingRewardItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolPrizeDrawingRewardItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060383BC RID: 230332 RVA: 0x00FB8D94 File Offset: 0x00FB6F94
		private UniTask Initialize(int itemId, int count, int rewardMaxAmount)
		{
			SolarSchoolPrizeDrawingRewardItem.<Initialize>d__9 <Initialize>d__;
			<Initialize>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.itemId = itemId;
			<Initialize>d__.count = count;
			<Initialize>d__.rewardMaxAmount = rewardMaxAmount;
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<SolarSchoolPrizeDrawingRewardItem.<Initialize>d__9>(ref <Initialize>d__);
			return <Initialize>d__.<>t__builder.Task;
		}

		// Token: 0x060383BD RID: 230333 RVA: 0x00FB8DF0 File Offset: 0x00FB6FF0
		public void Refresh(int acquiredCount, bool animBanned = false)
		{
			for (int i = 0; i < this.GotItemList.Count; i++)
			{
				this.GotItemList[i].RefreshGotState(i + 1 <= acquiredCount, animBanned);
			}
		}

		// Token: 0x0401D9A0 RID: 121248
		[Nullable(1)]
		private readonly List<SolarSchoolPrizeDrawingGotItem> GotItemList = new List<SolarSchoolPrizeDrawingGotItem>();

		// Token: 0x0401D9A1 RID: 121249
		private readonly int ItemId;

		// Token: 0x0401D9A2 RID: 121250
		private readonly int Count;

		// Token: 0x0401D9A3 RID: 121251
		private readonly int MaxAmount;

		// Token: 0x0200B4E0 RID: 46304
		private enum EPrizeItemType
		{
			// Token: 0x04037ECC RID: 229068
			TexIcon,
			// Token: 0x04037ECD RID: 229069
			TxtName,
			// Token: 0x04037ECE RID: 229070
			TxtTotal,
			// Token: 0x04037ECF RID: 229071
			PnlGrid,
			// Token: 0x04037ED0 RID: 229072
			PrizeItem,
			// Token: 0x04037ED1 RID: 229073
			TxtCount,
			// Token: 0x04037ED2 RID: 229074
			BtnIcon
		}
	}
}
