using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200393D RID: 14653
	public class ScrollBarComponent : ScrollBarComponentBase
	{
		// Token: 0x06025D09 RID: 154889 RVA: 0x00A9FE1E File Offset: 0x00A9E01E
		public ScrollBarComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D0A RID: 154890 RVA: 0x00A9FE27 File Offset: 0x00A9E027
		protected override void HandleScrollBarChange(float value)
		{
			UiNavigationNewController.Instance.ScrollBarChangeSchedule(value);
		}
	}
}
