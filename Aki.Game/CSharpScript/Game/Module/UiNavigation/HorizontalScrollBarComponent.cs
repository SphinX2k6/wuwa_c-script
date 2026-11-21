using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200393E RID: 14654
	public class HorizontalScrollBarComponent : ScrollBarComponentBase
	{
		// Token: 0x06025D0B RID: 154891 RVA: 0x00A9FE34 File Offset: 0x00A9E034
		public HorizontalScrollBarComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D0C RID: 154892 RVA: 0x00A9FE3D File Offset: 0x00A9E03D
		protected override void HandleScrollBarChange(float value)
		{
			UiNavigationNewController.Instance.HorizontalScrollBarChangeSchedule(-value * 4.5f);
		}

		// Token: 0x04014D36 RID: 85302
		private const float SCROLL_COEFFICIENT = 4.5f;
	}
}
