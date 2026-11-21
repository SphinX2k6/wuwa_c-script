using System;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x02003970 RID: 14704
	public class DangobrawlCancelComponent : DangobrawlHotKeyComponentBase
	{
		// Token: 0x06025DC0 RID: 155072 RVA: 0x00AA2215 File Offset: 0x00AA0415
		public DangobrawlCancelComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025DC1 RID: 155073 RVA: 0x00AA2220 File Offset: 0x00AA0420
		protected override bool ShouldShow()
		{
			bool flag = DangobrawlHotKeyComponentBase.InputPlatform.GetValueOrDefault() == EInputPlatform.Gamepad;
			bool flag2 = DangobrawlHotKeyComponentBase.IsDragging || DangobrawlHotKeyComponentBase.IsHolding || DangobrawlHotKeyComponentBase.IsSticky;
			return flag && flag2;
		}

		// Token: 0x06025DC2 RID: 155074 RVA: 0x00AA2256 File Offset: 0x00AA0456
		protected override void OnRelease(HotKeyMap config)
		{
			DangoBrawlTouchController touch = DangobrawlHotKeyComponentBase.Touch;
			if (touch == null)
			{
				return;
			}
			touch.CancelInteractionIfAny();
		}
	}
}
