using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049C5 RID: 18885
	public class VerticalScrollBarComponent : ScrollBarComponentBase
	{
		// Token: 0x060311D7 RID: 201175 RVA: 0x00B64F01 File Offset: 0x00B63101
		public VerticalScrollBarComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311D8 RID: 201176 RVA: 0x00B64F0A File Offset: 0x00B6310A
		protected override void HandleScrollBarChange(float value)
		{
			UiNavigationNewController.Instance.VerticalScrollBarChangeSchedule(value * 4.5f);
		}

		// Token: 0x0401A4C5 RID: 107717
		private const float SCROLL_COEFFICIENT = 4.5f;
	}
}
