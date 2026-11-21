using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038D8 RID: 14552
	public class FormationChoseRoleComponent : HotKeyComponent
	{
		// Token: 0x06025B54 RID: 154452 RVA: 0x00A9C08B File Offset: 0x00A9A28B
		public FormationChoseRoleComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
			FormationViewDragController.AddCustomShieldHotKeyComponentSetData(this.HotKeyMapIndex);
		}

		// Token: 0x06025B55 RID: 154453 RVA: 0x00A9C09F File Offset: 0x00A9A29F
		protected override void OnPress(HotKeyMap config)
		{
			if (FormationViewDragController.GamePadSelectModel)
			{
				return;
			}
			FormationViewDragController.OnGamePadPress();
		}

		// Token: 0x06025B56 RID: 154454 RVA: 0x00A9C0AE File Offset: 0x00A9A2AE
		protected override void OnRelease(HotKeyMap config)
		{
			if (FormationViewDragController.DragStartMoveFirstRelease)
			{
				FormationViewDragController.DragStartMoveFirstRelease = false;
				return;
			}
			if (FormationViewDragController.GamePadSelectModel)
			{
				FormationViewDragController.Instance.DragConfirm();
				return;
			}
			FormationViewDragController.OnGamePadRelease();
		}

		// Token: 0x06025B57 RID: 154455 RVA: 0x00A9C0D8 File Offset: 0x00A9A2D8
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
			HotKeyViewDefine.ELogicMode logicMode = HotKeyViewDefine.ELogicMode.ListenerActive;
			TArray<string> tagArray = focusListener.TagArray;
			base.SetVisibleMode(logicMode, ((tagArray != null) ? tagArray.FindIndex(bindButtonTag) : -1) >= 0, false);
		}
	}
}
