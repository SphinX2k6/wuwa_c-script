using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x0200444F RID: 17487
	[NullableContext(2)]
	[Nullable(0)]
	public class RepeatKeyTipsView : UiViewBase
	{
		// Token: 0x0602C1F7 RID: 180727 RVA: 0x00C6480B File Offset: 0x00C62A0B
		[NullableContext(1)]
		public RepeatKeyTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602C1F8 RID: 180728 RVA: 0x00C64814 File Offset: 0x00C62A14
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(6, new Action(this.OnConfirmButtonClicked)),
				new ValueTuple<int, Delegate>(7, new Action(this.OnCancelButtonClicked))
			};
		}

		// Token: 0x0602C1F9 RID: 180729 RVA: 0x00C64917 File Offset: 0x00C62B17
		private void OnConfirmButtonClicked()
		{
			this.IsConfirm = true;
			base.CloseMe(null);
		}

		// Token: 0x0602C1FA RID: 180730 RVA: 0x00C64927 File Offset: 0x00C62B27
		private void OnCancelButtonClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602C1FB RID: 180731 RVA: 0x00C64930 File Offset: 0x00C62B30
		protected override void OnStart()
		{
			IRepeatKeyInfo repeatKeyInfo = this.OpenParam as IRepeatKeyInfo;
			this.CurrentKeySettingRowData = repeatKeyInfo.CurrentKeySettingRowData;
			this.RepeatKeySettingRowData = repeatKeyInfo.RepeatKeySettingRowData;
			this.InputControllerType = repeatKeyInfo.InputControllerType;
			this.OnCloseCallback = repeatKeyInfo.OnCloseCallback;
			string settingName = this.CurrentKeySettingRowData.GetSettingName();
			string currentKeyNameRichText = this.CurrentKeySettingRowData.GetCurrentKeyNameRichText(this.InputControllerType, "+");
			string settingName2 = this.RepeatKeySettingRowData.GetSettingName();
			string currentKeyNameRichText2 = this.RepeatKeySettingRowData.GetCurrentKeyNameRichText(this.InputControllerType, "+");
			if (StringUtils.IsBlank(currentKeyNameRichText))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "NoneText", Array.Empty<object>());
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "NoneText", Array.Empty<object>());
			}
			else
			{
				UUIText text = base.GetText(1);
				if (text != null)
				{
					text.SetText(currentKeyNameRichText, true);
				}
				UUIText text2 = base.GetText(5);
				if (text2 != null)
				{
					text2.SetText(currentKeyNameRichText, true);
				}
			}
			UUIText text3 = base.GetText(4);
			if (text3 != null)
			{
				text3.SetText(currentKeyNameRichText2, true);
			}
			UUIText text4 = base.GetText(2);
			if (text4 != null)
			{
				text4.SetText(currentKeyNameRichText2, true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), settingName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), settingName2, Array.Empty<object>());
		}

		// Token: 0x0602C1FC RID: 180732 RVA: 0x00C64A80 File Offset: 0x00C62C80
		protected override void OnBeforeDestroy()
		{
			if (this.OnCloseCallback != null)
			{
				this.OnCloseCallback(this.IsConfirm);
			}
			this.CurrentKeySettingRowData = null;
			this.RepeatKeySettingRowData = null;
			this.InputControllerType = EInputControllerType.None;
			this.OnCloseCallback = null;
		}

		// Token: 0x04017C38 RID: 97336
		private KeySettingRowData CurrentKeySettingRowData;

		// Token: 0x04017C39 RID: 97337
		private KeySettingRowData RepeatKeySettingRowData;

		// Token: 0x04017C3A RID: 97338
		private EInputControllerType InputControllerType;

		// Token: 0x04017C3B RID: 97339
		private Action<bool> OnCloseCallback;

		// Token: 0x04017C3C RID: 97340
		private bool IsConfirm;

		// Token: 0x0200A121 RID: 41249
		[NullableContext(0)]
		public class EChildType
		{
			// Token: 0x040320FA RID: 205050
			public const int CurrentInputText = 0;

			// Token: 0x040320FB RID: 205051
			public const int CurrentFromKeyNameText = 1;

			// Token: 0x040320FC RID: 205052
			public const int CurrentToKeyNameText = 2;

			// Token: 0x040320FD RID: 205053
			public const int RepeatInputText = 3;

			// Token: 0x040320FE RID: 205054
			public const int RepeatFromKeyNameText = 4;

			// Token: 0x040320FF RID: 205055
			public const int RepeatToKeyNameText = 5;

			// Token: 0x04032100 RID: 205056
			public const int ConfirmButton = 6;

			// Token: 0x04032101 RID: 205057
			public const int CancelButton = 7;
		}
	}
}
