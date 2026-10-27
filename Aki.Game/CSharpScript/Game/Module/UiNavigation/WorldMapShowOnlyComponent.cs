using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049EA RID: 18922
	public class WorldMapShowOnlyComponent : HotKeyComponent
	{
		// Token: 0x06031243 RID: 201283 RVA: 0x00B659AB File Offset: 0x00B63BAB
		public WorldMapShowOnlyComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031244 RID: 201284 RVA: 0x00B659B4 File Offset: 0x00B63BB4
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

		// Token: 0x06031245 RID: 201285 RVA: 0x00B65A00 File Offset: 0x00B63C00
		protected override bool OnIsOccupancyFightInput()
		{
			return false;
		}
	}
}
