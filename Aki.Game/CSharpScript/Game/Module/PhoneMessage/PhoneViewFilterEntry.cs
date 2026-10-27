using System;
using System.Collections.Generic;
using System.Text;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhoneMessage
{
	// Token: 0x020050F1 RID: 20721
	internal class PhoneViewFilterEntry : UiPanelBase
	{
		// Token: 0x06034FBE RID: 217022 RVA: 0x00C8CA64 File Offset: 0x00C8AC64
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

		// Token: 0x06034FBF RID: 217023 RVA: 0x00C8CB0F File Offset: 0x00C8AD0F
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.OnPhoneMsgFilterChanged, new Action(this.OnFilterChanged));
			this.ResetFilter();
		}

		// Token: 0x06034FC0 RID: 217024 RVA: 0x00C8CB33 File Offset: 0x00C8AD33
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.OnPhoneMsgFilterChanged, new Action(this.OnFilterChanged));
		}

		// Token: 0x06034FC1 RID: 217025 RVA: 0x00C8CB51 File Offset: 0x00C8AD51
		private void OnFilterChanged()
		{
			this.RefreshFilterInfoTips();
		}

		// Token: 0x06034FC2 RID: 217026 RVA: 0x00C8CB59 File Offset: 0x00C8AD59
		private void OnBtnFilterClick()
		{
			UiManager.Instance.OpenView(EUiViewName.PhoneViewFilterPanel, null, null);
		}

		// Token: 0x06034FC3 RID: 217027 RVA: 0x00C8CB6C File Offset: 0x00C8AD6C
		private void OnBtnDeleteClick()
		{
			base.GetItem(1).SetUIActive(false);
			this.ResetFilter();
		}

		// Token: 0x06034FC4 RID: 217028 RVA: 0x00C8CB84 File Offset: 0x00C8AD84
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

		// Token: 0x06034FC5 RID: 217029 RVA: 0x00C8CC80 File Offset: 0x00C8AE80
		public void ResetFilter()
		{
			PhoneMsgModel.Instance.ClearSelectedFilterIdSet();
		}
	}
}
