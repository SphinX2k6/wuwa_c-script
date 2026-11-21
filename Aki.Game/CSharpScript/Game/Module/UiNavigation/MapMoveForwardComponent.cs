using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003903 RID: 14595
	[NullableContext(1)]
	[Nullable(0)]
	public class MapMoveForwardComponent : HotKeyComponent
	{
		// Token: 0x06025C3C RID: 154684 RVA: 0x00A9E29D File Offset: 0x00A9C49D
		public MapMoveForwardComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C3D RID: 154685 RVA: 0x00A9E2A8 File Offset: 0x00A9C4A8
		protected override void OnInit()
		{
			string axisName = base.GetAxisName();
			WorldMapModel.Instance.WorldMapAxisInteractValidation.InitAxisLock(axisName);
		}

		// Token: 0x06025C3E RID: 154686 RVA: 0x00A9E2CC File Offset: 0x00A9C4CC
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

		// Token: 0x06025C3F RID: 154687 RVA: 0x00A9E330 File Offset: 0x00A9C530
		protected override void OnInputAxis(string axisName, float value)
		{
			WorldMapAxisInteractValidation worldMapAxisInteractValidation = WorldMapModel.Instance.WorldMapAxisInteractValidation;
			worldMapAxisInteractValidation.InputAxis(axisName, value);
			if (!worldMapAxisInteractValidation.IsInValid)
			{
				EventSystem.Instance.Emit<float>(EEventName.NavigationTriggerMapForward, value);
			}
		}
	}
}
