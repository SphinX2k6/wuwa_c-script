using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x02005461 RID: 21601
	[NullableContext(1)]
	[Nullable(0)]
	public class KeySettingExclusiveTypeTabItem : CommonTabItemBase
	{
		// Token: 0x06037226 RID: 225830 RVA: 0x00D11A10 File Offset: 0x00D0FC10
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

		// Token: 0x06037227 RID: 225831 RVA: 0x00D11A8D File Offset: 0x00D0FC8D
		protected override void OnStart()
		{
			base.OnStart();
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06037228 RID: 225832 RVA: 0x00D11AA8 File Offset: 0x00D0FCA8
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

		// Token: 0x06037229 RID: 225833 RVA: 0x00D11B15 File Offset: 0x00D0FD15
		protected override UUIExtendToggle GetTabToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x0603722A RID: 225834 RVA: 0x00D11B20 File Offset: 0x00D0FD20
		protected override void OnUpdateTabIcon(string iconPath)
		{
			base.SetTextureByPath(iconPath, base.GetTexture(1), null, null);
		}

		// Token: 0x0603722B RID: 225835 RVA: 0x00D11B48 File Offset: 0x00D0FD48
		protected override void OnSetToggleState(EToggleState state, bool bFire)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(state, bFire, false, false);
			}
		}

		// Token: 0x0603722C RID: 225836 RVA: 0x00D11B6B File Offset: 0x00D0FD6B
		private void ToggleClick(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.SelectedCallBack(base.GridIndex);
			}
		}

		// Token: 0x0200B6D6 RID: 46806
		[NullableContext(0)]
		public class EComponent
		{
			// Token: 0x04037643 RID: 226883
			public const int Toggle = 0;

			// Token: 0x04037644 RID: 226884
			public const int TexIcon = 1;

			// Token: 0x04037645 RID: 226885
			public const int TxtName = 2;
		}
	}
}
