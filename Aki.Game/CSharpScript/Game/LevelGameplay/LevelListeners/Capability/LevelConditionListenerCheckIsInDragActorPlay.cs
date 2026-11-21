using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.LevelListeners.Capability
{
	// Token: 0x02005C63 RID: 23651
	public class LevelConditionListenerCheckIsInDragActorPlay : LevelListenerBase
	{
		// Token: 0x0603A119 RID: 237849 RVA: 0x01057614 File Offset: 0x01055814
		private void OnDragActorPlayActivationChanged(bool active)
		{
			TListenerCallbackFunc callback = this.Callback;
			if (callback == null)
			{
				return;
			}
			callback(null, Array.Empty<object>());
		}

		// Token: 0x0603A11A RID: 237850 RVA: 0x0105762C File Offset: 0x0105582C
		[NullableContext(1)]
		protected override void OnListen(object listeningInfo, TListenerCallbackFunc callback, [Nullable(2)] GeneralContext context = null, params object[] otherParams)
		{
			EventSystem.Instance.Add<bool>(EEventName.DragActorPlayActivationChanged, new Action<bool>(this.OnDragActorPlayActivationChanged));
		}

		// Token: 0x0603A11B RID: 237851 RVA: 0x0105764A File Offset: 0x0105584A
		protected override void OnUnListen()
		{
			EventSystem.Instance.Remove(EEventName.DragActorPlayActivationChanged, new Action<bool>(this.OnDragActorPlayActivationChanged));
		}
	}
}
