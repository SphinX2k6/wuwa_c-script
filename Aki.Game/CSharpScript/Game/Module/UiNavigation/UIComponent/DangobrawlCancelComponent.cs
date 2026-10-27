using System;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x020049F6 RID: 18934
	public class DangobrawlCancelComponent : DangobrawlHotKeyComponentBase
	{
		// Token: 0x0603128A RID: 201354 RVA: 0x00B67259 File Offset: 0x00B65459
		public DangobrawlCancelComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603128B RID: 201355 RVA: 0x00B67264 File Offset: 0x00B65464
		protected override bool ShouldShow()
		{
			bool flag = DangobrawlHotKeyComponentBase.InputPlatform.GetValueOrDefault() == EInputPlatform.Gamepad;
			bool flag2 = DangobrawlHotKeyComponentBase.IsDragging || DangobrawlHotKeyComponentBase.IsHolding || DangobrawlHotKeyComponentBase.IsSticky;
			return flag && flag2;
		}

		// Token: 0x0603128C RID: 201356 RVA: 0x00B6729A File Offset: 0x00B6549A
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
