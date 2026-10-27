using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006800 RID: 26624
	public class DangoBrawlHandBookFilterItem : UiPanelBase
	{
		// Token: 0x06042680 RID: 272000 RVA: 0x010201B8 File Offset: 0x0101E3B8
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

		// Token: 0x06042681 RID: 272001 RVA: 0x010202C3 File Offset: 0x0101E4C3
		protected override void OnStart()
		{
			base.GetItem(1).SetUIActive(false);
		}

		// Token: 0x06042682 RID: 272002 RVA: 0x010202D4 File Offset: 0x0101E4D4
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

		// Token: 0x06042683 RID: 272003 RVA: 0x010203A0 File Offset: 0x0101E5A0
		private void OnClickBtnFilter()
		{
			Action onClickFilter = this.OnClickFilter;
			if (onClickFilter == null)
			{
				return;
			}
			onClickFilter();
		}

		// Token: 0x06042684 RID: 272004 RVA: 0x010203B2 File Offset: 0x0101E5B2
		private void OnClickBtnDelete()
		{
			Action onClickDelete = this.OnClickDelete;
			if (onClickDelete == null)
			{
				return;
			}
			onClickDelete();
		}

		// Token: 0x040229C8 RID: 141768
		[Nullable(2)]
		public Action OnClickFilter;

		// Token: 0x040229C9 RID: 141769
		[Nullable(2)]
		public Action OnClickDelete;

		// Token: 0x0200C971 RID: 51569
		private enum EFilterItemComponent
		{
			// Token: 0x0403CD42 RID: 249154
			BtnFilter,
			// Token: 0x0403CD43 RID: 249155
			FilterTipsItem,
			// Token: 0x0403CD44 RID: 249156
			TxtFilterInfo,
			// Token: 0x0403CD45 RID: 249157
			BtnDelete
		}
	}
}
