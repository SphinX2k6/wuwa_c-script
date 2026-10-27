using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x0200542E RID: 21550
	public class ResolutionToggle : LanguageToggleBase
	{
		// Token: 0x060370BC RID: 225468 RVA: 0x00D0B768 File Offset: 0x00D09968
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
		}

		// Token: 0x060370BD RID: 225469 RVA: 0x00D0B770 File Offset: 0x00D09970
		[NullableContext(1)]
		public void SetMainRawText(string text)
		{
			this.MainText.SetText(text, true);
		}

		// Token: 0x060370BE RID: 225470 RVA: 0x00D0B77F File Offset: 0x00D0997F
		protected override void OnStart()
		{
			base.OnStart();
			base.GetText(2).SetUIActive(false);
		}
	}
}
