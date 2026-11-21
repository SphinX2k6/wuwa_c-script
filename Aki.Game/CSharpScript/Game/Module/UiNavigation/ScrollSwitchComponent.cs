using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003941 RID: 14657
	[NullableContext(1)]
	[Nullable(0)]
	public class ScrollSwitchComponent : HotKeyComponent
	{
		// Token: 0x06025D12 RID: 154898 RVA: 0x00A9FF49 File Offset: 0x00A9E149
		public ScrollSwitchComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D13 RID: 154899 RVA: 0x00A9FF52 File Offset: 0x00A9E152
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.FindScrollbar(true);
		}

		// Token: 0x06025D14 RID: 154900 RVA: 0x00A9FF60 File Offset: 0x00A9E160
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

		// Token: 0x06025D15 RID: 154901 RVA: 0x00A9FFAC File Offset: 0x00A9E1AC
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			NavigationScrollbarData scrollbarData = viewHandle.GetScrollbarData();
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, scrollbarData.HasActiveScrollbarList(), false);
		}

		// Token: 0x04014D3A RID: 85306
		private const float THRESHOLD = 0.6f;

		// Token: 0x04014D3B RID: 85307
		private bool IsTrigger;
	}
}
