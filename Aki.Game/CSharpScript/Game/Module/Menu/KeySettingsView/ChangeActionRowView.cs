using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x0200443C RID: 17468
	public class ChangeActionRowView : UiPanelBase
	{
		// Token: 0x0602C13B RID: 180539 RVA: 0x00C60150 File Offset: 0x00C5E350
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

		// Token: 0x0602C13C RID: 180540 RVA: 0x00C601CD File Offset: 0x00C5E3CD
		protected override void OnBeforeDestroy()
		{
			this.KeySettingRowData = null;
		}

		// Token: 0x0602C13D RID: 180541 RVA: 0x00C601D6 File Offset: 0x00C5E3D6
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

		// Token: 0x0602C13E RID: 180542 RVA: 0x00C601F4 File Offset: 0x00C5E3F4
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
			string[] collection = array2;
			string keyNameRichTextByKeyNameList = this.KeySettingRowData.GetKeyNameRichTextByKeyNameList(inputControllerType, new List<string>(collection), "/");
			UUIText text3 = base.GetText(2);
			if (text3 == null)
			{
				return;
			}
			text3.SetText(keyNameRichTextByKeyNameList, true);
		}

		// Token: 0x0602C13F RID: 180543 RVA: 0x00C602A5 File Offset: 0x00C5E4A5
		[NullableContext(1)]
		public void BindOnSelected(Action<ChangeActionRowView, bool> onSelected)
		{
			this.OnSelectedCallback = onSelected;
		}

		// Token: 0x0602C140 RID: 180544 RVA: 0x00C602AE File Offset: 0x00C5E4AE
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

		// Token: 0x04017BE6 RID: 97254
		[Nullable(2)]
		private KeySettingRowData KeySettingRowData;

		// Token: 0x04017BE7 RID: 97255
		public bool IsRevert;

		// Token: 0x04017BE8 RID: 97256
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ChangeActionRowView, bool> OnSelectedCallback;

		// Token: 0x0200A108 RID: 41224
		public class EChildType
		{
			// Token: 0x0403207C RID: 204924
			public const int ExtendToggle = 0;

			// Token: 0x0403207D RID: 204925
			public const int ActionNameText = 1;

			// Token: 0x0403207E RID: 204926
			public const int ActionKeyText = 2;
		}
	}
}
