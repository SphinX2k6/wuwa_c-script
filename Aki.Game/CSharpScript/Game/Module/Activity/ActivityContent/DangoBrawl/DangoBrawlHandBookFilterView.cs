using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005753 RID: 22355
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlHandBookFilterView : UiViewBase
	{
		// Token: 0x060371E9 RID: 225769 RVA: 0x00F61D28 File Offset: 0x00F5FF28
		public DangoBrawlHandBookFilterView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060371EA RID: 225770 RVA: 0x00F61D3C File Offset: 0x00F5FF3C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnResetClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnBtnConfirmClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060371EB RID: 225771 RVA: 0x00F61ECC File Offset: 0x00F600CC
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlHandBookFilterView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlHandBookFilterView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060371EC RID: 225772 RVA: 0x00F61F10 File Offset: 0x00F60110
		protected override void OnBeforeShow()
		{
			this.OpenData = (this.OpenParam as DangoBrawlHandBookFilterOpenData);
			this.SelectedOccupationIds.Clear();
			DangoBrawlHandBookFilterOpenData openData = this.OpenData;
			if (((openData != null) ? openData.SelectedOccupationIds : null) != null)
			{
				this.SelectedOccupationIds.AddRange(this.OpenData.SelectedOccupationIds);
			}
			DangoBrawlHandBookFilterSortItem baseSortItem = this.BaseSortItem;
			if (baseSortItem == null)
			{
				return;
			}
			baseSortItem.SetSelectedIds(this.SelectedOccupationIds);
		}

		// Token: 0x060371ED RID: 225773 RVA: 0x00F61F79 File Offset: 0x00F60179
		private void OnClickSortList(List<int> occupationIds)
		{
			this.SelectedOccupationIds.Clear();
			this.SelectedOccupationIds.AddRange(occupationIds);
		}

		// Token: 0x060371EE RID: 225774 RVA: 0x00F61F92 File Offset: 0x00F60192
		private void OnBtnResetClick()
		{
			DangoBrawlHandBookFilterSortItem baseSortItem = this.BaseSortItem;
			if (baseSortItem != null)
			{
				baseSortItem.ResetSelection();
			}
			this.SelectedOccupationIds.Clear();
		}

		// Token: 0x060371EF RID: 225775 RVA: 0x00F61FB0 File Offset: 0x00F601B0
		private void OnBtnConfirmClick()
		{
			DangoBrawlHandBookFilterOpenData openData = this.OpenData;
			if (openData != null)
			{
				Action<List<int>> onConfirm = openData.OnConfirm;
				if (onConfirm != null)
				{
					onConfirm(this.SelectedOccupationIds);
				}
			}
			base.CloseMe(null);
		}

		// Token: 0x0401D22D RID: 119341
		[Nullable(2)]
		private DangoBrawlHandBookFilterOpenData OpenData;

		// Token: 0x0401D22E RID: 119342
		[Nullable(2)]
		private DangoBrawlHandBookFilterSortItem BaseSortItem;

		// Token: 0x0401D22F RID: 119343
		private readonly List<int> SelectedOccupationIds = new List<int>();

		// Token: 0x0200B341 RID: 45889
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04037640 RID: 226880
			BtnReset,
			// Token: 0x04037641 RID: 226881
			BtnConfirm,
			// Token: 0x04037642 RID: 226882
			PnlBaseSort,
			// Token: 0x04037643 RID: 226883
			PnlAttributeSort,
			// Token: 0x04037644 RID: 226884
			TxtTitle,
			// Token: 0x04037645 RID: 226885
			PnlHor,
			// Token: 0x04037646 RID: 226886
			TxtTips,
			// Token: 0x04037647 RID: 226887
			PnlIcon
		}
	}
}
