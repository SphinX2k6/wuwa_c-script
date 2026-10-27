using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004989 RID: 18825
	[NullableContext(1)]
	[Nullable(0)]
	public class MapMoveForwardComponent : HotKeyComponent
	{
		// Token: 0x06031106 RID: 200966 RVA: 0x00B6334D File Offset: 0x00B6154D
		public MapMoveForwardComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031107 RID: 200967 RVA: 0x00B63358 File Offset: 0x00B61558
		protected override void OnInit()
		{
			string axisName = base.GetAxisName();
			WorldMapModel.Instance.WorldMapAxisInteractValidation.InitAxisLock(axisName);
		}

		// Token: 0x06031108 RID: 200968 RVA: 0x00B6337C File Offset: 0x00B6157C
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

		// Token: 0x06031109 RID: 200969 RVA: 0x00B633E0 File Offset: 0x00B615E0
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
