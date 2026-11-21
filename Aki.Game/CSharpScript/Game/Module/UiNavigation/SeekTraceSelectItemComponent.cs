using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003947 RID: 14663
	public class SeekTraceSelectItemComponent : HotKeyComponent
	{
		// Token: 0x06025D24 RID: 154916 RVA: 0x00AA005D File Offset: 0x00A9E25D
		public SeekTraceSelectItemComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D25 RID: 154917 RVA: 0x00AA0066 File Offset: 0x00A9E266
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x06025D26 RID: 154918 RVA: 0x00AA0071 File Offset: 0x00A9E271
		protected override void OnPress(HotKeyMap config)
		{
			EventSystem.Instance.Emit(EEventName.SeekTraceSelectItemInput);
		}
	}
}
