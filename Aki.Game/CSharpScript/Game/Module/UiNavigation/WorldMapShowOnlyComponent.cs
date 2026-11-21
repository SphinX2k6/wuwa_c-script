using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003964 RID: 14692
	public class WorldMapShowOnlyComponent : HotKeyComponent
	{
		// Token: 0x06025D79 RID: 155001 RVA: 0x00AA08FB File Offset: 0x00A9EAFB
		public WorldMapShowOnlyComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D7A RID: 155002 RVA: 0x00AA0904 File Offset: 0x00A9EB04
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			if (ActivityMowingRiskController.Instance.CheckInInstanceDungeon())
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (InstanceDungeonEntranceController.Instance.CheckInstanceShieldView(EUiViewName.WorldMapView))
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x06025D7B RID: 155003 RVA: 0x00AA0950 File Offset: 0x00A9EB50
		protected override bool OnIsOccupancyFightInput()
		{
			return false;
		}
	}
}
