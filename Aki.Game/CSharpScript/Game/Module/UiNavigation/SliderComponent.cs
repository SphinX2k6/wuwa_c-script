using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200394E RID: 14670
	public class SliderComponent : HotKeyComponent
	{
		// Token: 0x06025D3E RID: 154942 RVA: 0x00AA03D0 File Offset: 0x00A9E5D0
		public SliderComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D3F RID: 154943 RVA: 0x00AA03D9 File Offset: 0x00A9E5D9
		protected virtual void SetValue(float value)
		{
			UiNavigationNewController.Instance.SliderComponentSetValue(base.GetBindButtonTag(), value);
		}

		// Token: 0x04014D3D RID: 85309
		private const float INTERVAL = 0.05f;

		// Token: 0x04014D3E RID: 85310
		private const float DEAD_AREA = 0.4f;
	}
}
