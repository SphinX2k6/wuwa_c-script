using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049D4 RID: 18900
	public class SliderComponent : HotKeyComponent
	{
		// Token: 0x06031208 RID: 201224 RVA: 0x00B65480 File Offset: 0x00B63680
		public SliderComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031209 RID: 201225 RVA: 0x00B65489 File Offset: 0x00B63689
		protected virtual void SetValue(float value)
		{
			UiNavigationNewController.Instance.SliderComponentSetValue(base.GetBindButtonTag(), value);
		}

		// Token: 0x0401A4CB RID: 107723
		private const float INTERVAL = 0.05f;

		// Token: 0x0401A4CC RID: 107724
		private const float DEAD_AREA = 0.4f;
	}
}
