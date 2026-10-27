using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.SeekTrace;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049C8 RID: 18888
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class SeekTraceBaseMoveComponent : HotKeyComponent
	{
		// Token: 0x060311E0 RID: 201184 RVA: 0x00B6507E File Offset: 0x00B6327E
		protected SeekTraceBaseMoveComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311E1 RID: 201185
		protected abstract ESeekTraceMoveDirection GetMoveDirection();

		// Token: 0x060311E2 RID: 201186 RVA: 0x00B65087 File Offset: 0x00B63287
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x060311E3 RID: 201187 RVA: 0x00B65092 File Offset: 0x00B63292
		protected override void OnPress(HotKeyMap config)
		{
			EventSystem.Instance.Emit<ESeekTraceMoveDirection, bool>(EEventName.SeekTraceMoveActionInput, this.GetMoveDirection(), true);
		}

		// Token: 0x060311E4 RID: 201188 RVA: 0x00B650AB File Offset: 0x00B632AB
		protected override void OnRelease(HotKeyMap config)
		{
			EventSystem.Instance.Emit<ESeekTraceMoveDirection, bool>(EEventName.SeekTraceMoveActionInput, this.GetMoveDirection(), false);
		}

		// Token: 0x060311E5 RID: 201189 RVA: 0x00B650C4 File Offset: 0x00B632C4
		protected override void OnInputAxis(string axisName, float value)
		{
			EventSystem.Instance.Emit<ESeekTraceMoveDirection, float>(EEventName.SeekTraceMoveAxisInput, this.GetMoveDirection(), value);
		}
	}
}
