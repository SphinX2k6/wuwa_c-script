using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.LevelListeners.Capability
{
	// Token: 0x02006AEB RID: 27371
	public class LevelConditionListenerCheckIsInDragActorPlay : LevelListenerBase
	{
		// Token: 0x06043FC7 RID: 278471 RVA: 0x010ADD98 File Offset: 0x010ABF98
		private void OnDragActorPlayActivationChanged(bool active)
		{
			TListenerCallbackFunc callback = this.Callback;
			if (callback == null)
			{
				return;
			}
			callback(null, Array.Empty<object>());
		}

		// Token: 0x06043FC8 RID: 278472 RVA: 0x010ADDB0 File Offset: 0x010ABFB0
		[NullableContext(1)]
		protected override void OnListen(object listeningInfo, TListenerCallbackFunc callback, [Nullable(2)] GeneralContext context = null, params object[] otherParams)
		{
			EventSystem.Instance.Add<bool>(EEventName.DragActorPlayActivationChanged, new Action<bool>(this.OnDragActorPlayActivationChanged));
		}

		// Token: 0x06043FC9 RID: 278473 RVA: 0x010ADDCE File Offset: 0x010ABFCE
		protected override void OnUnListen()
		{
			EventSystem.Instance.Remove(EEventName.DragActorPlayActivationChanged, new Action<bool>(this.OnDragActorPlayActivationChanged));
		}
	}
}
