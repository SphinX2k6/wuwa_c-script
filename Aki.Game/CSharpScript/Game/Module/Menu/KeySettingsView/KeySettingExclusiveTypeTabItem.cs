using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x02004444 RID: 17476
	[NullableContext(1)]
	[Nullable(0)]
	public class KeySettingExclusiveTypeTabItem : CommonTabItemBase
	{
		// Token: 0x0602C16F RID: 180591 RVA: 0x00C60E28 File Offset: 0x00C5F028
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleClick))
			};
		}

		// Token: 0x0602C170 RID: 180592 RVA: 0x00C60EA5 File Offset: 0x00C5F0A5
		protected override void OnStart()
		{
			base.OnStart();
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0602C171 RID: 180593 RVA: 0x00C60EC0 File Offset: 0x00C5F0C0
		protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
		{
			CommonTabData data2 = data.Data;
			base.UpdateTabIcon(((data2 != null) ? data2.GetIcon() : null) ?? "");
			UUIText text = base.GetText(2);
			LguiUtil instance = LguiUtil.Instance;
			UUIText uiText = text;
			CommonTabData data3 = data.Data;
			string text2;
			if (data3 == null)
			{
				text2 = null;
			}
			else
			{
				CommonTabTitleData titleData = data3.GetTitleData();
				text2 = ((titleData != null) ? titleData.TextId : null);
			}
			instance.SetLocalTextNew(uiText, text2 ?? "", Array.Empty<object>());
		}

		// Token: 0x0602C172 RID: 180594 RVA: 0x00C60F2D File Offset: 0x00C5F12D
		protected override UUIExtendToggle GetTabToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x0602C173 RID: 180595 RVA: 0x00C60F38 File Offset: 0x00C5F138
		protected override void OnUpdateTabIcon(string iconPath)
		{
			base.SetTextureByPath(iconPath, base.GetTexture(1), null, null);
		}

		// Token: 0x0602C174 RID: 180596 RVA: 0x00C60F60 File Offset: 0x00C5F160
		protected override void OnSetToggleState(EToggleState state, bool bFire)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(state, bFire, false, false);
			}
		}

		// Token: 0x0602C175 RID: 180597 RVA: 0x00C60F83 File Offset: 0x00C5F183
		private void ToggleClick(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.SelectedCallBack(base.GridIndex);
			}
		}

		// Token: 0x0200A10E RID: 41230
		[NullableContext(0)]
		public class EComponent
		{
			// Token: 0x04032098 RID: 204952
			public const int Toggle = 0;

			// Token: 0x04032099 RID: 204953
			public const int TexIcon = 1;

			// Token: 0x0403209A RID: 204954
			public const int TxtName = 2;
		}
	}
}
