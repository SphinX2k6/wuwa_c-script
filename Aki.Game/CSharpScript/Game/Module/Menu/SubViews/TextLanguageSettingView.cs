using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x0200542F RID: 21551
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TextLanguageSettingView : LanguageSettingViewBase<TextLanguageToggle>
	{
		// Token: 0x060370C0 RID: 225472 RVA: 0x00D0B79C File Offset: 0x00D0999C
		public TextLanguageSettingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060370C1 RID: 225473 RVA: 0x00D0B7A5 File Offset: 0x00D099A5
		[return: Nullable(2)]
		protected override TextLanguageToggle CreateToggle(UUIItem uiItem, int index, bool isToggled)
		{
			TextLanguageToggle textLanguageToggle = new TextLanguageToggle();
			textLanguageToggle.Initialize(uiItem, index, isToggled);
			return textLanguageToggle;
		}

		// Token: 0x060370C2 RID: 225474 RVA: 0x00D0B7B8 File Offset: 0x00D099B8
		protected override void OnRefreshView(TextLanguageToggle newToggle)
		{
			string mainText = this.MenuDataIns.OptionsNameList[newToggle.GetIndex()];
			newToggle.SetMainText(mainText);
		}

		// Token: 0x060370C3 RID: 225475 RVA: 0x00D0B7E3 File Offset: 0x00D099E3
		protected override void OnSelected(TextLanguageToggle newToggle, EToggleState newToggleState)
		{
			newToggle.SetSpriteActive(true);
		}
	}
}
