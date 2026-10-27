using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049C7 RID: 18887
	[NullableContext(1)]
	[Nullable(0)]
	public class ScrollSwitchComponent : HotKeyComponent
	{
		// Token: 0x060311DC RID: 201180 RVA: 0x00B64FF9 File Offset: 0x00B631F9
		public ScrollSwitchComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311DD RID: 201181 RVA: 0x00B65002 File Offset: 0x00B63202
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.FindScrollbar(true);
		}

		// Token: 0x060311DE RID: 201182 RVA: 0x00B65010 File Offset: 0x00B63210
		protected override void OnInputAxis(string axisName, float value)
		{
			if (this.IsTrigger)
			{
				if (value == 0f)
				{
					this.IsTrigger = false;
				}
				return;
			}
			if (Math.Abs(value) <= 0.6f)
			{
				return;
			}
			UiNavigationNewController.Instance.FindScrollbar(value < 0f);
			this.IsTrigger = true;
		}

		// Token: 0x060311DF RID: 201183 RVA: 0x00B6505C File Offset: 0x00B6325C
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			NavigationScrollbarData scrollbarData = viewHandle.GetScrollbarData();
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, scrollbarData.HasActiveScrollbarList(), false);
		}

		// Token: 0x0401A4C8 RID: 107720
		private const float THRESHOLD = 0.6f;

		// Token: 0x0401A4C9 RID: 107721
		private bool IsTrigger;
	}
}
