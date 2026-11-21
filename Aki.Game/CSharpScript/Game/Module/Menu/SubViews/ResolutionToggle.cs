using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02004411 RID: 17425
	public class ResolutionToggle : LanguageToggleBase
	{
		// Token: 0x0602C005 RID: 180229 RVA: 0x00C5AB88 File Offset: 0x00C58D88
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
		}

		// Token: 0x0602C006 RID: 180230 RVA: 0x00C5AB90 File Offset: 0x00C58D90
		[NullableContext(1)]
		public void SetMainRawText(string text)
		{
			this.MainText.SetText(text, true);
		}

		// Token: 0x0602C007 RID: 180231 RVA: 0x00C5AB9F File Offset: 0x00C58D9F
		protected override void OnStart()
		{
			base.OnStart();
			base.GetText(2).SetUIActive(false);
		}
	}
}
