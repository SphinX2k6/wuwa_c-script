using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.WorldMap;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200498D RID: 18829
	public class MapFocusPlayerComponent : MapInteractComponentBase
	{
		// Token: 0x06031112 RID: 200978 RVA: 0x00B63505 File Offset: 0x00B61705
		public MapFocusPlayerComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031113 RID: 200979 RVA: 0x00B6350E File Offset: 0x00B6170E
		protected override void OnPress(HotKeyMap config)
		{
			EventSystem.Instance.Emit(EEventName.WorldMapShowTrackList);
		}

		// Token: 0x06031114 RID: 200980 RVA: 0x00B63520 File Offset: 0x00B61720
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (string.IsNullOrEmpty(bindButtonTag))
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			if (focusListener == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (StringUtils.IsEmpty(focusListener.GetNavigationGroup().GroupName))
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			TArray<string> tagArray = focusListener.TagArray;
			if (tagArray == null || !tagArray.Contains(bindButtonTag))
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (WorldMapModel.Instance.WorldExtraUiCount > 0)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
