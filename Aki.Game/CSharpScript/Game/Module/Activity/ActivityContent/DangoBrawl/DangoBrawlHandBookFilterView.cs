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
	// Token: 0x02006803 RID: 26627
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlHandBookFilterView : UiViewBase
	{
		// Token: 0x06042694 RID: 272020 RVA: 0x010207E4 File Offset: 0x0101E9E4
		public DangoBrawlHandBookFilterView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06042695 RID: 272021 RVA: 0x010207F8 File Offset: 0x0101E9F8
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

		// Token: 0x06042696 RID: 272022 RVA: 0x01020988 File Offset: 0x0101EB88
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlHandBookFilterView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlHandBookFilterView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042697 RID: 272023 RVA: 0x010209CC File Offset: 0x0101EBCC
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

		// Token: 0x06042698 RID: 272024 RVA: 0x01020A35 File Offset: 0x0101EC35
		private void OnClickSortList(List<int> occupationIds)
		{
			this.SelectedOccupationIds.Clear();
			this.SelectedOccupationIds.AddRange(occupationIds);
		}

		// Token: 0x06042699 RID: 272025 RVA: 0x01020A4E File Offset: 0x0101EC4E
		private void OnBtnResetClick()
		{
			DangoBrawlHandBookFilterSortItem baseSortItem = this.BaseSortItem;
			if (baseSortItem != null)
			{
				baseSortItem.ResetSelection();
			}
			this.SelectedOccupationIds.Clear();
		}

		// Token: 0x0604269A RID: 272026 RVA: 0x01020A6C File Offset: 0x0101EC6C
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

		// Token: 0x040229D0 RID: 141776
		[Nullable(2)]
		private DangoBrawlHandBookFilterOpenData OpenData;

		// Token: 0x040229D1 RID: 141777
		[Nullable(2)]
		private DangoBrawlHandBookFilterSortItem BaseSortItem;

		// Token: 0x040229D2 RID: 141778
		private readonly List<int> SelectedOccupationIds = new List<int>();

		// Token: 0x0200C974 RID: 51572
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403CD53 RID: 249171
			BtnReset,
			// Token: 0x0403CD54 RID: 249172
			BtnConfirm,
			// Token: 0x0403CD55 RID: 249173
			PnlBaseSort,
			// Token: 0x0403CD56 RID: 249174
			PnlAttributeSort,
			// Token: 0x0403CD57 RID: 249175
			TxtTitle,
			// Token: 0x0403CD58 RID: 249176
			PnlHor,
			// Token: 0x0403CD59 RID: 249177
			TxtTips,
			// Token: 0x0403CD5A RID: 249178
			PnlIcon
		}
	}
}
