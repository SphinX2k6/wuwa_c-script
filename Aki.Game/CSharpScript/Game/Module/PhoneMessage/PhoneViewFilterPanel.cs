using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhoneMessage
{
	// Token: 0x020050F3 RID: 20723
	[NullableContext(1)]
	[Nullable(0)]
	internal class PhoneViewFilterPanel : UiViewBase
	{
		// Token: 0x06034FC7 RID: 217031 RVA: 0x00C8CC94 File Offset: 0x00C8AE94
		public PhoneViewFilterPanel(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034FC8 RID: 217032 RVA: 0x00C8CCA8 File Offset: 0x00C8AEA8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnBtnResetClick)),
				new ValueTuple<int, Delegate>(1, new Action(this.OnBtnConfirmClick))
			};
		}

		// Token: 0x06034FC9 RID: 217033 RVA: 0x00C8CD6C File Offset: 0x00C8AF6C
		protected override void OnStart()
		{
			this.TempSelectedFilterIdSet = new HashSet<int>();
			foreach (int item in PhoneMsgModel.Instance.SelectedFilterIdSet)
			{
				this.TempSelectedFilterIdSet.Add(item);
			}
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(2);
			if (verticalLayout != null)
			{
				this.FilterLayout = new GenericLayout<PanelFilter, int>(verticalLayout, new Func<PanelFilter>(this.CreateFilterItem), null, false, true);
			}
			IEnumerable<ChatFilterType> allChatFilterTypeConfigList = PhoneMsgConfig.Instance.GetAllChatFilterTypeConfigList();
			if (allChatFilterTypeConfigList == null)
			{
				return;
			}
			List<int> list = new List<int>();
			foreach (ChatFilterType chatFilterType in allChatFilterTypeConfigList)
			{
				list.Add(chatFilterType.Id);
			}
			GenericLayout<PanelFilter, int> filterLayout = this.FilterLayout;
			if (filterLayout == null)
			{
				return;
			}
			filterLayout.RefreshByDataAsync(list, false, null);
		}

		// Token: 0x06034FCA RID: 217034 RVA: 0x00C8CE74 File Offset: 0x00C8B074
		private PanelFilter CreateFilterItem()
		{
			PanelFilter panelFilter = new PanelFilter();
			panelFilter.SetOnFilterTogItemClick(new Action<int, bool>(this.OnFilterTogItemClick));
			panelFilter.SetIsFilterSelected(new Func<int, bool>(this.CheckIsTempFilterSelected));
			return panelFilter;
		}

		// Token: 0x06034FCB RID: 217035 RVA: 0x00C8CE9F File Offset: 0x00C8B09F
		private bool CheckIsTempFilterSelected(int filterId)
		{
			return this.TempSelectedFilterIdSet.Contains(filterId);
		}

		// Token: 0x06034FCC RID: 217036 RVA: 0x00C8CEB0 File Offset: 0x00C8B0B0
		private void OnBtnResetClick()
		{
			this.TempSelectedFilterIdSet.Clear();
			PhoneMsgModel.Instance.ClearSelectedFilterIdSet();
			IEnumerable<ChatFilterType> allChatFilterTypeConfigList = PhoneMsgConfig.Instance.GetAllChatFilterTypeConfigList();
			if (allChatFilterTypeConfigList == null)
			{
				return;
			}
			List<int> list = new List<int>();
			foreach (ChatFilterType chatFilterType in allChatFilterTypeConfigList)
			{
				list.Add(chatFilterType.Id);
			}
			GenericLayout<PanelFilter, int> filterLayout = this.FilterLayout;
			if (filterLayout == null)
			{
				return;
			}
			filterLayout.RefreshByDataAsync(list, false, null);
		}

		// Token: 0x06034FCD RID: 217037 RVA: 0x00C8CF48 File Offset: 0x00C8B148
		private void OnBtnConfirmClick()
		{
			PhoneMsgModel.Instance.SetSelectedFilterIdSet(this.TempSelectedFilterIdSet);
			base.CloseMe(null);
		}

		// Token: 0x06034FCE RID: 217038 RVA: 0x00C8CF61 File Offset: 0x00C8B161
		private void OnFilterTogItemClick(int filterId, bool isSelected)
		{
			if (isSelected)
			{
				this.TempSelectedFilterIdSet.Add(filterId);
				return;
			}
			this.TempSelectedFilterIdSet.Remove(filterId);
		}

		// Token: 0x0401C365 RID: 115557
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<PanelFilter, int> FilterLayout;

		// Token: 0x0401C366 RID: 115558
		private HashSet<int> TempSelectedFilterIdSet = new HashSet<int>();
	}
}
