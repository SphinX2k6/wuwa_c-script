using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200495F RID: 18783
	public class FormationCancelChoseRoleComponent : HotKeyComponent
	{
		// Token: 0x06031021 RID: 200737 RVA: 0x00B61102 File Offset: 0x00B5F302
		public FormationCancelChoseRoleComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
			FormationViewDragController.AddCustomShieldHotKeyComponentSetData(this.HotKeyMapIndex);
		}

		// Token: 0x06031022 RID: 200738 RVA: 0x00B61116 File Offset: 0x00B5F316
		protected override void OnPress(HotKeyMap config)
		{
			if (FormationViewDragController.GamePadSelectModel)
			{
				FormationViewDragController.Instance.CancelDrag();
			}
		}

		// Token: 0x06031023 RID: 200739 RVA: 0x00B6112C File Offset: 0x00B5F32C
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
