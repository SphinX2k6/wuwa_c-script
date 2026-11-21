using System;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02004413 RID: 17427
	public class TextLanguageToggle : LanguageToggleBase
	{
		// Token: 0x0602C00D RID: 180237 RVA: 0x00C5AC0C File Offset: 0x00C58E0C
		protected override void OnStart()
		{
			base.OnStart();
			base.GetText(2).SetUIActive(false);
		}

		// Token: 0x0602C00E RID: 180238 RVA: 0x00C5AC21 File Offset: 0x00C58E21
		public void SetSpriteActive(bool isShow)
		{
		}
	}
}
