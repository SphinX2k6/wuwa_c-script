using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.MapRogue;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003908 RID: 14600
	public class MapRogueQuicklyMoveComponent : HotKeyComponent
	{
		// Token: 0x06025C4B RID: 154699 RVA: 0x00A9E508 File Offset: 0x00A9C708
		public MapRogueQuicklyMoveComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C4C RID: 154700 RVA: 0x00A9E514 File Offset: 0x00A9C714
		protected override void OnPress(HotKeyMap config)
		{
			MapRogueGameInfo gameInfo = MapRogueModel.Instance.GameInfo;
			if (gameInfo == null)
			{
				return;
			}
			gameInfo.OnMove(null);
		}

		// Token: 0x06025C4D RID: 154701 RVA: 0x00A9E53E File Offset: 0x00A9C73E
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
