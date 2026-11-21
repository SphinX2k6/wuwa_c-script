using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003904 RID: 14596
	[NullableContext(1)]
	[Nullable(0)]
	public class MapMoveRightComponent : HotKeyComponent
	{
		// Token: 0x06025C40 RID: 154688 RVA: 0x00A9E35C File Offset: 0x00A9C55C
		public MapMoveRightComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C41 RID: 154689 RVA: 0x00A9E368 File Offset: 0x00A9C568
		protected override void OnInit()
		{
			string axisName = base.GetAxisName();
			WorldMapModel.Instance.WorldMapAxisInteractValidation.InitAxisLock(axisName);
		}

		// Token: 0x06025C42 RID: 154690 RVA: 0x00A9E38C File Offset: 0x00A9C58C
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			if (focusListener == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
				return;
			}
			NavigationGroup navigationGroup = focusListener.GetNavigationGroup();
			if (StringUtils.IsEmpty(navigationGroup.GroupName))
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (navigationGroup.GroupName != "GroupCursor")
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x06025C43 RID: 154691 RVA: 0x00A9E3F0 File Offset: 0x00A9C5F0
		protected override void OnInputAxis(string axisName, float value)
		{
			WorldMapAxisInteractValidation worldMapAxisInteractValidation = WorldMapModel.Instance.WorldMapAxisInteractValidation;
			worldMapAxisInteractValidation.InputAxis(axisName, value);
			if (!worldMapAxisInteractValidation.IsInValid)
			{
				EventSystem.Instance.Emit<float>(EEventName.NavigationTriggerMapRight, value);
			}
		}
	}
}
