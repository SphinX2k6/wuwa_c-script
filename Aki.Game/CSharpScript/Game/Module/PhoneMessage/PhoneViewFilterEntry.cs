using System;
using System.Collections.Generic;
using System.Text;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhoneMessage
{
	// Token: 0x020040C1 RID: 16577
	internal class PhoneViewFilterEntry : UiPanelBase
	{
		// Token: 0x06029EB7 RID: 171703 RVA: 0x00BD9D40 File Offset: 0x00BD7F40
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnBtnFilterClick)),
				new ValueTuple<int, Delegate>(3, new Action(this.OnBtnDeleteClick))
			};
		}

		// Token: 0x06029EB8 RID: 171704 RVA: 0x00BD9DEB File Offset: 0x00BD7FEB
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.OnPhoneMsgFilterChanged, new Action(this.OnFilterChanged));
			this.ResetFilter();
		}

		// Token: 0x06029EB9 RID: 171705 RVA: 0x00BD9E0F File Offset: 0x00BD800F
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.OnPhoneMsgFilterChanged, new Action(this.OnFilterChanged));
		}

		// Token: 0x06029EBA RID: 171706 RVA: 0x00BD9E2D File Offset: 0x00BD802D
		private void OnFilterChanged()
		{
			this.RefreshFilterInfoTips();
		}

		// Token: 0x06029EBB RID: 171707 RVA: 0x00BD9E35 File Offset: 0x00BD8035
		private void OnBtnFilterClick()
		{
			UiManager.Instance.OpenView(EUiViewName.PhoneViewFilterPanel, null, null);
		}

		// Token: 0x06029EBC RID: 171708 RVA: 0x00BD9E48 File Offset: 0x00BD8048
		private void OnBtnDeleteClick()
		{
			base.GetItem(1).SetUIActive(false);
			this.ResetFilter();
		}

		// Token: 0x06029EBD RID: 171709 RVA: 0x00BD9E60 File Offset: 0x00BD8060
		public void RefreshFilterInfoTips()
		{
			UUIItem item = base.GetItem(1);
			UUIText text = base.GetText(2);
			if (PhoneMsgModel.Instance.SelectedFilterIdSet.Count == 0)
			{
				text.SetText("", true);
				item.SetUIActive(false);
				return;
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (int filterId in PhoneMsgModel.Instance.SelectedFilterIdSet)
			{
				ChatPartnerFilter? chatPartnerFilterConfig = PhoneMsgConfig.Instance.GetChatPartnerFilterConfig(filterId);
				if (chatPartnerFilterConfig != null)
				{
					string value = ConfigMultiTextLang.GetLocalTextNew(chatPartnerFilterConfig.Value.Name, null) ?? "";
					stringBuilder.Append(value);
					stringBuilder.Append(',');
				}
			}
			stringBuilder.Remove(stringBuilder.Length - 1, 1);
			text.SetText(stringBuilder.ToString(), true);
			item.SetUIActive(true);
		}

		// Token: 0x06029EBE RID: 171710 RVA: 0x00BD9F5C File Offset: 0x00BD815C
		public void ResetFilter()
		{
			PhoneMsgModel.Instance.ClearSelectedFilterIdSet();
		}
	}
}
