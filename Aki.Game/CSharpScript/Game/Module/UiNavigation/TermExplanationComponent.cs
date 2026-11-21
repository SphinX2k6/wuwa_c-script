using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003961 RID: 14689
	[NullableContext(1)]
	[Nullable(0)]
	public class TermExplanationComponent : HotKeyComponent
	{
		// Token: 0x06025D6C RID: 154988 RVA: 0x00AA07A1 File Offset: 0x00A9E9A1
		public TermExplanationComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D6D RID: 154989 RVA: 0x00AA07AA File Offset: 0x00A9E9AA
		protected override void OnPress(HotKeyMap config)
		{
			TermExplanationController.Instance.OpenTermExplanationViewDirectly();
		}

		// Token: 0x06025D6E RID: 154990 RVA: 0x00AA07B6 File Offset: 0x00A9E9B6
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			this.RefreshVisible();
		}

		// Token: 0x06025D6F RID: 154991 RVA: 0x00AA07BE File Offset: 0x00A9E9BE
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnTermExplanationRegisteredTextContentChange, new Action<IReadOnlyList<int>>(this.OnTextChange));
		}

		// Token: 0x06025D70 RID: 154992 RVA: 0x00AA07DC File Offset: 0x00A9E9DC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnTermExplanationRegisteredTextContentChange, new Action<IReadOnlyList<int>>(this.OnTextChange));
		}

		// Token: 0x06025D71 RID: 154993 RVA: 0x00AA07FC File Offset: 0x00A9E9FC
		private void RefreshVisible()
		{
			bool isActive = TermExplanationController.Instance.HasAnyTermInCurrentTexts();
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, isActive, false);
		}

		// Token: 0x06025D72 RID: 154994 RVA: 0x00AA081D File Offset: 0x00A9EA1D
		private void OnTextChange(IReadOnlyList<int> readOnlyList)
		{
			this.RefreshVisible();
		}
	}
}
