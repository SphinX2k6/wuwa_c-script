using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005750 RID: 22352
	public class DangoBrawlHandBookFilterItem : UiPanelBase
	{
		// Token: 0x060371D5 RID: 225749 RVA: 0x00F616FC File Offset: 0x00F5F8FC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnFilter));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickBtnDelete));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060371D6 RID: 225750 RVA: 0x00F61807 File Offset: 0x00F5FA07
		protected override void OnStart()
		{
			base.GetItem(1).SetUIActive(false);
		}

		// Token: 0x060371D7 RID: 225751 RVA: 0x00F61818 File Offset: 0x00F5FA18
		[NullableContext(1)]
		public void RefreshFilterInfo(IReadOnlyList<int> ids)
		{
			List<string> list = new List<string>(ids.Count);
			foreach (int id in ids)
			{
				DangoBrawlOccupation? occupationConfigById = DangoBrawlConfig.Instance.GetOccupationConfigById(id);
				if (occupationConfigById != null)
				{
					string localTextNew = ConfigMultiTextLang.GetLocalTextNew(occupationConfigById.Value.Name, null);
					if (!string.IsNullOrEmpty(localTextNew))
					{
						list.Add(localTextNew);
					}
				}
			}
			bool flag = list.Count > 0;
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (flag)
			{
				UUIText text = base.GetText(2);
				if (text == null)
				{
					return;
				}
				text.SetText(string.Join(",", list), true);
			}
		}

		// Token: 0x060371D8 RID: 225752 RVA: 0x00F618E4 File Offset: 0x00F5FAE4
		private void OnClickBtnFilter()
		{
			Action onClickFilter = this.OnClickFilter;
			if (onClickFilter == null)
			{
				return;
			}
			onClickFilter();
		}

		// Token: 0x060371D9 RID: 225753 RVA: 0x00F618F6 File Offset: 0x00F5FAF6
		private void OnClickBtnDelete()
		{
			Action onClickDelete = this.OnClickDelete;
			if (onClickDelete == null)
			{
				return;
			}
			onClickDelete();
		}

		// Token: 0x0401D225 RID: 119333
		[Nullable(2)]
		public Action OnClickFilter;

		// Token: 0x0401D226 RID: 119334
		[Nullable(2)]
		public Action OnClickDelete;

		// Token: 0x0200B33E RID: 45886
		private enum EFilterItemComponent
		{
			// Token: 0x0403762F RID: 226863
			BtnFilter,
			// Token: 0x04037630 RID: 226864
			FilterTipsItem,
			// Token: 0x04037631 RID: 226865
			TxtFilterInfo,
			// Token: 0x04037632 RID: 226866
			BtnDelete
		}
	}
}
