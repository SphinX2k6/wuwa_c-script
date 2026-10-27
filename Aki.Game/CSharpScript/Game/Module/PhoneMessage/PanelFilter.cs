using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhoneMessage
{
	// Token: 0x020050F5 RID: 20725
	[NullableContext(2)]
	[Nullable(0)]
	internal class PanelFilter : GridProxyAbstract<int>
	{
		// Token: 0x06034FCF RID: 217039 RVA: 0x00C8CF81 File Offset: 0x00C8B181
		public void SetOnFilterTogItemClick(Action<int, bool> callback)
		{
			this.OnFilterTogItemClick = callback;
		}

		// Token: 0x06034FD0 RID: 217040 RVA: 0x00C8CF8A File Offset: 0x00C8B18A
		public void SetIsFilterSelected(Func<int, bool> callback)
		{
			this.IsFilterSelected = callback;
		}

		// Token: 0x06034FD1 RID: 217041 RVA: 0x00C8CF94 File Offset: 0x00C8B194
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIExtendToggle))
			};
		}

		// Token: 0x06034FD2 RID: 217042 RVA: 0x00C8CFF0 File Offset: 0x00C8B1F0
		protected override void OnStart()
		{
			UUIGridLayout gridLayout = base.GetGridLayout(1);
			this.BigFilterTogItemLayout = new GenericLayout<FilterTogItem, int>(gridLayout, new Func<FilterTogItem>(this.CreateFilterTogItem), null, false, true);
		}

		// Token: 0x06034FD3 RID: 217043 RVA: 0x00C8D020 File Offset: 0x00C8B220
		public override void Refresh(int filterTypeId, bool isSelected, int gridIndex)
		{
			this.FilterTypeId = new int?(filterTypeId);
			ChatFilterType? chatFilterTypeConfig = PhoneMsgConfig.Instance.GetChatFilterTypeConfig(this.FilterTypeId.Value);
			if (chatFilterTypeConfig == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), chatFilterTypeConfig.Value.Title ?? "", Array.Empty<object>());
			IEnumerable<ChatPartnerFilter> chatPartnerFilterConfigListByFilterType = PhoneMsgConfig.Instance.GetChatPartnerFilterConfigListByFilterType(this.FilterTypeId.Value);
			List<int> list = new List<int>();
			foreach (ChatPartnerFilter chatPartnerFilter in chatPartnerFilterConfigListByFilterType)
			{
				list.Add(chatPartnerFilter.Id);
			}
			GenericLayout<FilterTogItem, int> bigFilterTogItemLayout = this.BigFilterTogItemLayout;
			if (bigFilterTogItemLayout == null)
			{
				return;
			}
			bigFilterTogItemLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06034FD4 RID: 217044 RVA: 0x00C8D0F8 File Offset: 0x00C8B2F8
		[NullableContext(1)]
		private FilterTogItem CreateFilterTogItem()
		{
			FilterTogItem filterTogItem = new FilterTogItem();
			filterTogItem.SetOnFilterTogItemClick(this.OnFilterTogItemClick);
			filterTogItem.SetIsFilterSelected(this.IsFilterSelected);
			return filterTogItem;
		}

		// Token: 0x06034FD5 RID: 217045 RVA: 0x00C8D117 File Offset: 0x00C8B317
		public override void Clear()
		{
		}

		// Token: 0x0401C36B RID: 115563
		public int? FilterTypeId;

		// Token: 0x0401C36C RID: 115564
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<FilterTogItem, int> BigFilterTogItemLayout;

		// Token: 0x0401C36D RID: 115565
		private Action<int, bool> OnFilterTogItemClick;

		// Token: 0x0401C36E RID: 115566
		private Func<int, bool> IsFilterSelected;
	}
}
