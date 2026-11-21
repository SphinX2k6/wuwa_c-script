using System;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003909 RID: 14601
	public class MapTravelTaskNavigationNextComponent : NavigationGroupNextComponent
	{
		// Token: 0x06025C4E RID: 154702 RVA: 0x00A9E549 File Offset: 0x00A9C749
		public MapTravelTaskNavigationNextComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C4F RID: 154703 RVA: 0x00A9E552 File Offset: 0x00A9C752
		protected override void JumpToNextGroupListener()
		{
			EventSystem.Instance.Emit(EEventName.MapTravelTaskNavigationNext);
		}

		// Token: 0x06025C50 RID: 154704 RVA: 0x00A9E564 File Offset: 0x00A9C764
		protected override void OnRelease(HotKeyMap config)
		{
			EventSystem.Instance.Emit(EEventName.MapTravelTaskNavigationNext);
		}
	}
}
