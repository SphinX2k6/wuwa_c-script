using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhoneMessage
{
	// Token: 0x020040C5 RID: 16581
	[NullableContext(2)]
	[Nullable(0)]
	internal class PanelFilter : GridProxyAbstract<int>
	{
		// Token: 0x06029EC8 RID: 171720 RVA: 0x00BDA25D File Offset: 0x00BD845D
		public void SetOnFilterTogItemClick(Action<int, bool> callback)
		{
			this.OnFilterTogItemClick = callback;
		}

		// Token: 0x06029EC9 RID: 171721 RVA: 0x00BDA266 File Offset: 0x00BD8466
		public void SetIsFilterSelected(Func<int, bool> callback)
		{
			this.IsFilterSelected = callback;
		}

		// Token: 0x06029ECA RID: 171722 RVA: 0x00BDA270 File Offset: 0x00BD8470
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIExtendToggle))
			};
		}

		// Token: 0x06029ECB RID: 171723 RVA: 0x00BDA2CC File Offset: 0x00BD84CC
		protected override void OnStart()
		{
			UUIGridLayout gridLayout = base.GetGridLayout(1);
			this.BigFilterTogItemLayout = new GenericLayout<FilterTogItem, int>(gridLayout, new Func<FilterTogItem>(this.CreateFilterTogItem), null, false, true);
		}

		// Token: 0x06029ECC RID: 171724 RVA: 0x00BDA2FC File Offset: 0x00BD84FC
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

		// Token: 0x06029ECD RID: 171725 RVA: 0x00BDA3D4 File Offset: 0x00BD85D4
		[NullableContext(1)]
		private FilterTogItem CreateFilterTogItem()
		{
			FilterTogItem filterTogItem = new FilterTogItem();
			filterTogItem.SetOnFilterTogItemClick(this.OnFilterTogItemClick);
			filterTogItem.SetIsFilterSelected(this.IsFilterSelected);
			return filterTogItem;
		}

		// Token: 0x06029ECE RID: 171726 RVA: 0x00BDA3F3 File Offset: 0x00BD85F3
		public override void Clear()
		{
		}

		// Token: 0x04016D9E RID: 93598
		public int? FilterTypeId;

		// Token: 0x04016D9F RID: 93599
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<FilterTogItem, int> BigFilterTogItemLayout;

		// Token: 0x04016DA0 RID: 93600
		private Action<int, bool> OnFilterTogItemClick;

		// Token: 0x04016DA1 RID: 93601
		private Func<int, bool> IsFilterSelected;
	}
}
