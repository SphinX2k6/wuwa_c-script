using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049C4 RID: 18884
	public class HorizontalScrollBarComponent : ScrollBarComponentBase
	{
		// Token: 0x060311D5 RID: 201173 RVA: 0x00B64EE4 File Offset: 0x00B630E4
		public HorizontalScrollBarComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311D6 RID: 201174 RVA: 0x00B64EED File Offset: 0x00B630ED
		protected override void HandleScrollBarChange(float value)
		{
			UiNavigationNewController.Instance.HorizontalScrollBarChangeSchedule(-value * 4.5f);
		}

		// Token: 0x0401A4C4 RID: 107716
		private const float SCROLL_COEFFICIENT = 4.5f;
	}
}
