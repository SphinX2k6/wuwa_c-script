using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.MapRogue;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200498E RID: 18830
	public class MapRogueQuicklyMoveComponent : HotKeyComponent
	{
		// Token: 0x06031115 RID: 200981 RVA: 0x00B635B8 File Offset: 0x00B617B8
		public MapRogueQuicklyMoveComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031116 RID: 200982 RVA: 0x00B635C4 File Offset: 0x00B617C4
		protected override void OnPress(HotKeyMap config)
		{
			MapRogueGameInfo gameInfo = MapRogueModel.Instance.GameInfo;
			if (gameInfo == null)
			{
				return;
			}
			gameInfo.OnMove(null);
		}

		// Token: 0x06031117 RID: 200983 RVA: 0x00B635EE File Offset: 0x00B617EE
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
