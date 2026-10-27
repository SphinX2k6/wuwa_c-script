using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.LevelListeners
{
	// Token: 0x02006ADF RID: 27359
	public class LevelConditionListenerCheckFollowShooterActive : LevelListenerBase
	{
		// Token: 0x06043F78 RID: 278392 RVA: 0x010ABDE3 File Offset: 0x010A9FE3
		private void FollowerEnableChangeEventHandle(bool isEnable)
		{
			TListenerCallbackFunc callback = this.Callback;
			if (callback == null)
			{
				return;
			}
			callback(ClientEventContext.Create(EEventName.OnPlayerFollowerEnableChange, new object[]
			{
				isEnable
			}), Array.Empty<object>());
		}

		// Token: 0x06043F79 RID: 278393 RVA: 0x010ABE13 File Offset: 0x010AA013
		[NullableContext(1)]
		protected override void OnListen(object listeningInfo, TListenerCallbackFunc callback, [Nullable(2)] GeneralContext context = null, params object[] otherParams)
		{
			if (!EventSystem.Instance.Has(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.FollowerEnableChangeEventHandle)))
			{
				EventSystem.Instance.Add<bool>(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.FollowerEnableChangeEventHandle));
			}
		}

		// Token: 0x06043F7A RID: 278394 RVA: 0x010ABE50 File Offset: 0x010AA050
		protected override void OnUnListen()
		{
			if (new Action<bool>(this.FollowerEnableChangeEventHandle) != null && EventSystem.Instance.Has(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.FollowerEnableChangeEventHandle)))
			{
				EventSystem.Instance.Remove(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.FollowerEnableChangeEventHandle));
			}
		}
	}
}
