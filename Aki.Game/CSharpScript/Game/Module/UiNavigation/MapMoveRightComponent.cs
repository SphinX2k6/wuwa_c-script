using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200498A RID: 18826
	[NullableContext(1)]
	[Nullable(0)]
	public class MapMoveRightComponent : HotKeyComponent
	{
		// Token: 0x0603110A RID: 200970 RVA: 0x00B6340C File Offset: 0x00B6160C
		public MapMoveRightComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603110B RID: 200971 RVA: 0x00B63418 File Offset: 0x00B61618
		protected override void OnInit()
		{
			string axisName = base.GetAxisName();
			WorldMapModel.Instance.WorldMapAxisInteractValidation.InitAxisLock(axisName);
		}

		// Token: 0x0603110C RID: 200972 RVA: 0x00B6343C File Offset: 0x00B6163C
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

		// Token: 0x0603110D RID: 200973 RVA: 0x00B634A0 File Offset: 0x00B616A0
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
