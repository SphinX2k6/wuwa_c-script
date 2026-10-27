using System;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02005430 RID: 21552
	public class TextLanguageToggle : LanguageToggleBase
	{
		// Token: 0x060370C4 RID: 225476 RVA: 0x00D0B7EC File Offset: 0x00D099EC
		protected override void OnStart()
		{
			base.OnStart();
			base.GetText(2).SetUIActive(false);
		}

		// Token: 0x060370C5 RID: 225477 RVA: 0x00D0B801 File Offset: 0x00D09A01
		public void SetSpriteActive(bool isShow)
		{
		}
	}
}
