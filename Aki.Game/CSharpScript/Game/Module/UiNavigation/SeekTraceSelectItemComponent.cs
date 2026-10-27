using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049CD RID: 18893
	public class SeekTraceSelectItemComponent : HotKeyComponent
	{
		// Token: 0x060311EE RID: 201198 RVA: 0x00B6510D File Offset: 0x00B6330D
		public SeekTraceSelectItemComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311EF RID: 201199 RVA: 0x00B65116 File Offset: 0x00B63316
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x060311F0 RID: 201200 RVA: 0x00B65121 File Offset: 0x00B63321
		protected override void OnPress(HotKeyMap config)
		{
			EventSystem.Instance.Emit(EEventName.SeekTraceSelectItemInput);
		}
	}
}
