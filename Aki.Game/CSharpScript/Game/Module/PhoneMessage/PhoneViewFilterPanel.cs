using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhoneMessage
{
	// Token: 0x020040C3 RID: 16579
	[NullableContext(1)]
	[Nullable(0)]
	internal class PhoneViewFilterPanel : UiViewBase
	{
		// Token: 0x06029EC0 RID: 171712 RVA: 0x00BD9F70 File Offset: 0x00BD8170
		public PhoneViewFilterPanel(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06029EC1 RID: 171713 RVA: 0x00BD9F84 File Offset: 0x00BD8184
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

		// Token: 0x06029EC2 RID: 171714 RVA: 0x00BDA048 File Offset: 0x00BD8248
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

		// Token: 0x06029EC3 RID: 171715 RVA: 0x00BDA150 File Offset: 0x00BD8350
		private PanelFilter CreateFilterItem()
		{
			PanelFilter panelFilter = new PanelFilter();
			panelFilter.SetOnFilterTogItemClick(new Action<int, bool>(this.OnFilterTogItemClick));
			panelFilter.SetIsFilterSelected(new Func<int, bool>(this.CheckIsTempFilterSelected));
			return panelFilter;
		}

		// Token: 0x06029EC4 RID: 171716 RVA: 0x00BDA17B File Offset: 0x00BD837B
		private bool CheckIsTempFilterSelected(int filterId)
		{
			return this.TempSelectedFilterIdSet.Contains(filterId);
		}

		// Token: 0x06029EC5 RID: 171717 RVA: 0x00BDA18C File Offset: 0x00BD838C
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

		// Token: 0x06029EC6 RID: 171718 RVA: 0x00BDA224 File Offset: 0x00BD8424
		private void OnBtnConfirmClick()
		{
			PhoneMsgModel.Instance.SetSelectedFilterIdSet(this.TempSelectedFilterIdSet);
			base.CloseMe(null);
		}

		// Token: 0x06029EC7 RID: 171719 RVA: 0x00BDA23D File Offset: 0x00BD843D
		private void OnFilterTogItemClick(int filterId, bool isSelected)
		{
			if (isSelected)
			{
				this.TempSelectedFilterIdSet.Add(filterId);
				return;
			}
			this.TempSelectedFilterIdSet.Remove(filterId);
		}

		// Token: 0x04016D98 RID: 93592
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<PanelFilter, int> FilterLayout;

		// Token: 0x04016D99 RID: 93593
		private HashSet<int> TempSelectedFilterIdSet = new HashSet<int>();
	}
}
