using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.SeekTrace;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003942 RID: 14658
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class SeekTraceBaseMoveComponent : HotKeyComponent
	{
		// Token: 0x06025D16 RID: 154902 RVA: 0x00A9FFCE File Offset: 0x00A9E1CE
		protected SeekTraceBaseMoveComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D17 RID: 154903
		protected abstract ESeekTraceMoveDirection GetMoveDirection();

		// Token: 0x06025D18 RID: 154904 RVA: 0x00A9FFD7 File Offset: 0x00A9E1D7
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x06025D19 RID: 154905 RVA: 0x00A9FFE2 File Offset: 0x00A9E1E2
		protected override void OnPress(HotKeyMap config)
		{
			EventSystem.Instance.Emit<ESeekTraceMoveDirection, bool>(EEventName.SeekTraceMoveActionInput, this.GetMoveDirection(), true);
		}

		// Token: 0x06025D1A RID: 154906 RVA: 0x00A9FFFB File Offset: 0x00A9E1FB
		protected override void OnRelease(HotKeyMap config)
		{
			EventSystem.Instance.Emit<ESeekTraceMoveDirection, bool>(EEventName.SeekTraceMoveActionInput, this.GetMoveDirection(), false);
		}

		// Token: 0x06025D1B RID: 154907 RVA: 0x00AA0014 File Offset: 0x00A9E214
		protected override void OnInputAxis(string axisName, float value)
		{
			EventSystem.Instance.Emit<ESeekTraceMoveDirection, float>(EEventName.SeekTraceMoveAxisInput, this.GetMoveDirection(), value);
		}
	}
}
