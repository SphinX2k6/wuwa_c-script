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
	// Token: 0x02005919 RID: 22809
	public class SolarSchoolPrizeDrawingFinalRewardItem : UiPanelBase
	{
		// Token: 0x060383B2 RID: 230322 RVA: 0x00FB89AD File Offset: 0x00FB6BAD
		public SolarSchoolPrizeDrawingFinalRewardItem(int itemId, int count)
		{
			this.ItemId = itemId;
			this.Count = count;
		}

		// Token: 0x060383B3 RID: 230323 RVA: 0x00FB89C4 File Offset: 0x00FB6BC4
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
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

		// Token: 0x060383B4 RID: 230324 RVA: 0x00FB8B0F File Offset: 0x00FB6D0F
		private void OnClickIcon()
		{
			SolarSchoolUtils.ShowItemDetailPopup(this.ItemId, 0, null);
		}

		// Token: 0x060383B5 RID: 230325 RVA: 0x00FB8B20 File Offset: 0x00FB6D20
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolPrizeDrawingFinalRewardItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolPrizeDrawingFinalRewardItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060383B6 RID: 230326 RVA: 0x00FB8B64 File Offset: 0x00FB6D64
		private UniTask Initialize(int itemId, int count)
		{
			SolarSchoolPrizeDrawingFinalRewardItem.<Initialize>d__8 <Initialize>d__;
			<Initialize>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.itemId = itemId;
			<Initialize>d__.count = count;
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<SolarSchoolPrizeDrawingFinalRewardItem.<Initialize>d__8>(ref <Initialize>d__);
			return <Initialize>d__.<>t__builder.Task;
		}

		// Token: 0x060383B7 RID: 230327 RVA: 0x00FB8BB7 File Offset: 0x00FB6DB7
		public void Refresh(bool isGot, bool animBanned = false)
		{
			SolarSchoolPrizeDrawingGotItem gotItem = this.GotItem;
			if (gotItem == null)
			{
				return;
			}
			gotItem.RefreshGotState(isGot, animBanned);
		}

		// Token: 0x0401D99D RID: 121245
		[Nullable(2)]
		private SolarSchoolPrizeDrawingGotItem GotItem;

		// Token: 0x0401D99E RID: 121246
		private readonly int ItemId;

		// Token: 0x0401D99F RID: 121247
		private readonly int Count;

		// Token: 0x0200B4DD RID: 46301
		private enum EComp
		{
			// Token: 0x04037EBA RID: 229050
			TexIcon,
			// Token: 0x04037EBB RID: 229051
			TxtName,
			// Token: 0x04037EBC RID: 229052
			SprGot,
			// Token: 0x04037EBD RID: 229053
			PnlTagCur,
			// Token: 0x04037EBE RID: 229054
			TxtCount,
			// Token: 0x04037EBF RID: 229055
			GotItem,
			// Token: 0x04037EC0 RID: 229056
			BtnIcon
		}
	}
}
