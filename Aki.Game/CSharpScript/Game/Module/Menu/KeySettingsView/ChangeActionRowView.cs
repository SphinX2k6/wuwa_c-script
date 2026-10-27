using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x02005459 RID: 21593
	public class ChangeActionRowView : UiPanelBase
	{
		// Token: 0x060371F2 RID: 225778 RVA: 0x00D10D38 File Offset: 0x00D0EF38
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnExtendToggleStateChanged))
			};
		}

		// Token: 0x060371F3 RID: 225779 RVA: 0x00D10DB5 File Offset: 0x00D0EFB5
		protected override void OnBeforeDestroy()
		{
			this.KeySettingRowData = null;
		}

		// Token: 0x060371F4 RID: 225780 RVA: 0x00D10DBE File Offset: 0x00D0EFBE
		private void OnExtendToggleStateChanged(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			Action<ChangeActionRowView, bool> onSelectedCallback = this.OnSelectedCallback;
			if (onSelectedCallback == null)
			{
				return;
			}
			onSelectedCallback(this, this.IsRevert);
		}

		// Token: 0x060371F5 RID: 225781 RVA: 0x00D10DDC File Offset: 0x00D0EFDC
		[NullableContext(1)]
		public void Refresh(KeySettingRowData keySettingRowData, EInputControllerType inputControllerType, bool bRevert)
		{
			this.KeySettingRowData = keySettingRowData;
			this.IsRevert = bRevert;
			List<string> list = this.KeySettingRowData.GetDisplayKeyName(inputControllerType) ?? new List<string>();
			string text = list[0];
			string text2 = list[1];
			string settingName = this.KeySettingRowData.GetSettingName();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), settingName, Array.Empty<object>());
			string[] array2;
			if (!bRevert)
			{
				string[] array = new string[2];
				array[0] = text;
				array2 = array;
				array[1] = text2;
			}
			else
			{
				string[] array3 = new string[2];
				array3[0] = text2;
				array2 = array3;
				array3[1] = text;
			}
			string[] source = array2;
			string keyNameRichTextByKeyNameList = this.KeySettingRowData.GetKeyNameRichTextByKeyNameList(inputControllerType, source.ToList<string>(), "/");
			UUIText text3 = base.GetText(2);
			if (text3 == null)
			{
				return;
			}
			text3.SetText(keyNameRichTextByKeyNameList, true);
		}

		// Token: 0x060371F6 RID: 225782 RVA: 0x00D10E8D File Offset: 0x00D0F08D
		[NullableContext(1)]
		public void BindOnSelected(Action<ChangeActionRowView, bool> onSelected)
		{
			this.OnSelectedCallback = onSelected;
		}

		// Token: 0x060371F7 RID: 225783 RVA: 0x00D10E96 File Offset: 0x00D0F096
		public void SetSelected(bool bSelected)
		{
			if (bSelected)
			{
				UUIExtendToggle extendToggle = base.GetExtendToggle(0);
				if (extendToggle == null)
				{
					return;
				}
				extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
				return;
			}
			else
			{
				UUIExtendToggle extendToggle2 = base.GetExtendToggle(0);
				if (extendToggle2 == null)
				{
					return;
				}
				extendToggle2.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				return;
			}
		}

		// Token: 0x0401D14D RID: 119117
		[Nullable(2)]
		private KeySettingRowData KeySettingRowData;

		// Token: 0x0401D14E RID: 119118
		public bool IsRevert;

		// Token: 0x0401D14F RID: 119119
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ChangeActionRowView, bool> OnSelectedCallback;

		// Token: 0x0200B6D0 RID: 46800
		public class EChildType
		{
			// Token: 0x04037627 RID: 226855
			public const int ExtendToggle = 0;

			// Token: 0x04037628 RID: 226856
			public const int ActionNameText = 1;

			// Token: 0x04037629 RID: 226857
			public const int ActionKeyText = 2;
		}
	}
}
