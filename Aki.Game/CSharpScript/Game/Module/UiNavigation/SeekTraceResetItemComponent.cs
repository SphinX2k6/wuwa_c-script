using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.SeekTrace;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049CE RID: 18894
	public class SeekTraceResetItemComponent : HotKeyComponent
	{
		// Token: 0x060311F1 RID: 201201 RVA: 0x00B65133 File Offset: 0x00B63333
		public SeekTraceResetItemComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311F2 RID: 201202 RVA: 0x00B6513C File Offset: 0x00B6333C
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, SeekTraceModel.Instance.SelectedItem != null, false);
		}

		// Token: 0x060311F3 RID: 201203 RVA: 0x00B65153 File Offset: 0x00B63353
		protected override void OnPress(HotKeyMap config)
		{
			EventSystem.Instance.Emit(EEventName.SeekTraceResetItemInput);
		}
	}
}
