using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.SeekTrace;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003948 RID: 14664
	public class SeekTraceResetItemComponent : HotKeyComponent
	{
		// Token: 0x06025D27 RID: 154919 RVA: 0x00AA0083 File Offset: 0x00A9E283
		public SeekTraceResetItemComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D28 RID: 154920 RVA: 0x00AA008C File Offset: 0x00A9E28C
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, SeekTraceModel.Instance.SelectedItem != null, false);
		}

		// Token: 0x06025D29 RID: 154921 RVA: 0x00AA00A3 File Offset: 0x00A9E2A3
		protected override void OnPress(HotKeyMap config)
		{
			EventSystem.Instance.Emit(EEventName.SeekTraceResetItemInput);
		}
	}
}
