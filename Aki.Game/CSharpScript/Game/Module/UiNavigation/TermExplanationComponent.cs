using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049E7 RID: 18919
	[NullableContext(1)]
	[Nullable(0)]
	public class TermExplanationComponent : HotKeyComponent
	{
		// Token: 0x06031236 RID: 201270 RVA: 0x00B65851 File Offset: 0x00B63A51
		public TermExplanationComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031237 RID: 201271 RVA: 0x00B6585A File Offset: 0x00B63A5A
		protected override void OnPress(HotKeyMap config)
		{
			TermExplanationController.Instance.OpenTermExplanationViewDirectly();
		}

		// Token: 0x06031238 RID: 201272 RVA: 0x00B65866 File Offset: 0x00B63A66
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			this.RefreshVisible();
		}

		// Token: 0x06031239 RID: 201273 RVA: 0x00B6586E File Offset: 0x00B63A6E
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnTermExplanationRegisteredTextContentChange, new Action<IReadOnlyList<int>>(this.OnTextChange));
		}

		// Token: 0x0603123A RID: 201274 RVA: 0x00B6588C File Offset: 0x00B63A8C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnTermExplanationRegisteredTextContentChange, new Action<IReadOnlyList<int>>(this.OnTextChange));
		}

		// Token: 0x0603123B RID: 201275 RVA: 0x00B658AC File Offset: 0x00B63AAC
		private void RefreshVisible()
		{
			bool isActive = TermExplanationController.Instance.HasAnyTermInCurrentTexts();
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, isActive, false);
		}

		// Token: 0x0603123C RID: 201276 RVA: 0x00B658CD File Offset: 0x00B63ACD
		private void OnTextChange(IReadOnlyList<int> readOnlyList)
		{
			this.RefreshVisible();
		}
	}
}
