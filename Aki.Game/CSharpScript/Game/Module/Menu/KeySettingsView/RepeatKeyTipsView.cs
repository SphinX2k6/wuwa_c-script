using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x0200546C RID: 21612
	[NullableContext(2)]
	[Nullable(0)]
	public class RepeatKeyTipsView : UiViewBase
	{
		// Token: 0x060372AE RID: 225966 RVA: 0x00D153F3 File Offset: 0x00D135F3
		[NullableContext(1)]
		public RepeatKeyTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060372AF RID: 225967 RVA: 0x00D153FC File Offset: 0x00D135FC
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

		// Token: 0x060372B0 RID: 225968 RVA: 0x00D154FF File Offset: 0x00D136FF
		private void OnConfirmButtonClicked()
		{
			this.IsConfirm = true;
			base.CloseMe(null);
		}

		// Token: 0x060372B1 RID: 225969 RVA: 0x00D1550F File Offset: 0x00D1370F
		private void OnCancelButtonClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x060372B2 RID: 225970 RVA: 0x00D15518 File Offset: 0x00D13718
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

		// Token: 0x060372B3 RID: 225971 RVA: 0x00D15668 File Offset: 0x00D13868
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

		// Token: 0x0401D19F RID: 119199
		private KeySettingRowData CurrentKeySettingRowData;

		// Token: 0x0401D1A0 RID: 119200
		private KeySettingRowData RepeatKeySettingRowData;

		// Token: 0x0401D1A1 RID: 119201
		private EInputControllerType InputControllerType;

		// Token: 0x0401D1A2 RID: 119202
		private Action<bool> OnCloseCallback;

		// Token: 0x0401D1A3 RID: 119203
		private bool IsConfirm;

		// Token: 0x0200B6E9 RID: 46825
		[NullableContext(0)]
		public class EChildType
		{
			// Token: 0x040376A5 RID: 226981
			public const int CurrentInputText = 0;

			// Token: 0x040376A6 RID: 226982
			public const int CurrentFromKeyNameText = 1;

			// Token: 0x040376A7 RID: 226983
			public const int CurrentToKeyNameText = 2;

			// Token: 0x040376A8 RID: 226984
			public const int RepeatInputText = 3;

			// Token: 0x040376A9 RID: 226985
			public const int RepeatFromKeyNameText = 4;

			// Token: 0x040376AA RID: 226986
			public const int RepeatToKeyNameText = 5;

			// Token: 0x040376AB RID: 226987
			public const int ConfirmButton = 6;

			// Token: 0x040376AC RID: 226988
			public const int CancelButton = 7;
		}
	}
}
