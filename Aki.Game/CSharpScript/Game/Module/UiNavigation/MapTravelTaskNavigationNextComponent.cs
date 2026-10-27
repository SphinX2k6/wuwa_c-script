using System;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200498F RID: 18831
	public class MapTravelTaskNavigationNextComponent : NavigationGroupNextComponent
	{
		// Token: 0x06031118 RID: 200984 RVA: 0x00B635F9 File Offset: 0x00B617F9
		public MapTravelTaskNavigationNextComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031119 RID: 200985 RVA: 0x00B63602 File Offset: 0x00B61802
		protected override void JumpToNextGroupListener()
		{
			EventSystem.Instance.Emit(EEventName.MapTravelTaskNavigationNext);
		}

		// Token: 0x0603111A RID: 200986 RVA: 0x00B63614 File Offset: 0x00B61814
		protected override void OnRelease(HotKeyMap config)
		{
			EventSystem.Instance.Emit(EEventName.MapTravelTaskNavigationNext);
		}
	}
}
