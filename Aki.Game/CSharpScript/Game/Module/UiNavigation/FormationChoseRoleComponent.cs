using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004960 RID: 18784
	public class FormationChoseRoleComponent : HotKeyComponent
	{
		// Token: 0x06031024 RID: 200740 RVA: 0x00B611AB File Offset: 0x00B5F3AB
		public FormationChoseRoleComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
			FormationViewDragController.AddCustomShieldHotKeyComponentSetData(this.HotKeyMapIndex);
		}

		// Token: 0x06031025 RID: 200741 RVA: 0x00B611BF File Offset: 0x00B5F3BF
		protected override void OnPress(HotKeyMap config)
		{
			if (FormationViewDragController.GamePadSelectModel)
			{
				return;
			}
			FormationViewDragController.OnGamePadPress();
		}

		// Token: 0x06031026 RID: 200742 RVA: 0x00B611CE File Offset: 0x00B5F3CE
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

		// Token: 0x06031027 RID: 200743 RVA: 0x00B611F8 File Offset: 0x00B5F3F8
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
