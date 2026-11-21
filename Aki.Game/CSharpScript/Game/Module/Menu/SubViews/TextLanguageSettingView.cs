using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02004412 RID: 17426
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TextLanguageSettingView : LanguageSettingViewBase<TextLanguageToggle>
	{
		// Token: 0x0602C009 RID: 180233 RVA: 0x00C5ABBC File Offset: 0x00C58DBC
		public TextLanguageSettingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602C00A RID: 180234 RVA: 0x00C5ABC5 File Offset: 0x00C58DC5
		[return: Nullable(2)]
		protected override TextLanguageToggle CreateToggle(UUIItem uiItem, int index, bool isToggled)
		{
			TextLanguageToggle textLanguageToggle = new TextLanguageToggle();
			textLanguageToggle.Initialize(uiItem, index, isToggled);
			return textLanguageToggle;
		}

		// Token: 0x0602C00B RID: 180235 RVA: 0x00C5ABD8 File Offset: 0x00C58DD8
		protected override void OnRefreshView(TextLanguageToggle newToggle)
		{
			string mainText = this.MenuDataIns.OptionsNameList[newToggle.GetIndex()];
			newToggle.SetMainText(mainText);
		}

		// Token: 0x0602C00C RID: 180236 RVA: 0x00C5AC03 File Offset: 0x00C58E03
		protected override void OnSelected(TextLanguageToggle newToggle, EToggleState newToggleState)
		{
			newToggle.SetSpriteActive(true);
		}
	}
}
