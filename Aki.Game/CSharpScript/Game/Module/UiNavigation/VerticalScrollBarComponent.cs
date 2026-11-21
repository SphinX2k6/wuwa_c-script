using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200393F RID: 14655
	public class VerticalScrollBarComponent : ScrollBarComponentBase
	{
		// Token: 0x06025D0D RID: 154893 RVA: 0x00A9FE51 File Offset: 0x00A9E051
		public VerticalScrollBarComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D0E RID: 154894 RVA: 0x00A9FE5A File Offset: 0x00A9E05A
		protected override void HandleScrollBarChange(float value)
		{
			UiNavigationNewController.Instance.VerticalScrollBarChangeSchedule(value * 4.5f);
		}

		// Token: 0x04014D37 RID: 85303
		private const float SCROLL_COEFFICIENT = 4.5f;
	}
}
