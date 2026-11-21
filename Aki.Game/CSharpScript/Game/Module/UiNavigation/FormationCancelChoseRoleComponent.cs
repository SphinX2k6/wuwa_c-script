using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038D7 RID: 14551
	public class FormationCancelChoseRoleComponent : HotKeyComponent
	{
		// Token: 0x06025B51 RID: 154449 RVA: 0x00A9BFE2 File Offset: 0x00A9A1E2
		public FormationCancelChoseRoleComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
			FormationViewDragController.AddCustomShieldHotKeyComponentSetData(this.HotKeyMapIndex);
		}

		// Token: 0x06025B52 RID: 154450 RVA: 0x00A9BFF6 File Offset: 0x00A9A1F6
		protected override void OnPress(HotKeyMap config)
		{
			if (FormationViewDragController.GamePadSelectModel)
			{
				FormationViewDragController.Instance.CancelDrag();
			}
		}

		// Token: 0x06025B53 RID: 154451 RVA: 0x00A9C00C File Offset: 0x00A9A20C
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (bindButtonTag == null || StringUtils.IsEmpty(bindButtonTag))
			{
				return;
			}
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			if (focusListener == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (!base.IsLinkListener(focusListener.GetOwner()))
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (!FormationViewDragController.GetDragItemUiActive())
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			HotKeyViewDefine.ELogicMode logicMode = HotKeyViewDefine.ELogicMode.ListenerActive;
			TArray<string> tagArray = focusListener.TagArray;
			base.SetVisibleMode(logicMode, ((tagArray != null) ? tagArray.FindIndex(bindButtonTag) : -1) >= 0, false);
		}
	}
}
