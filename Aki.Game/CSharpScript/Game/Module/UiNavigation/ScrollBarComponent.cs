using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049C3 RID: 18883
	public class ScrollBarComponent : ScrollBarComponentBase
	{
		// Token: 0x060311D3 RID: 201171 RVA: 0x00B64ECE File Offset: 0x00B630CE
		public ScrollBarComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311D4 RID: 201172 RVA: 0x00B64ED7 File Offset: 0x00B630D7
		protected override void HandleScrollBarChange(float value)
		{
			UiNavigationNewController.Instance.ScrollBarChangeSchedule(value);
		}
	}
}
