using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.LevelListeners
{
	// Token: 0x02005C57 RID: 23639
	public class LevelConditionListenerCheckFollowShooterActive : LevelListenerBase
	{
		// Token: 0x0603A0CA RID: 237770 RVA: 0x0105565B File Offset: 0x0105385B
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

		// Token: 0x0603A0CB RID: 237771 RVA: 0x0105568B File Offset: 0x0105388B
		[NullableContext(1)]
		protected override void OnListen(object listeningInfo, TListenerCallbackFunc callback, [Nullable(2)] GeneralContext context = null, params object[] otherParams)
		{
			if (!EventSystem.Instance.Has(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.FollowerEnableChangeEventHandle)))
			{
				EventSystem.Instance.Add<bool>(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.FollowerEnableChangeEventHandle));
			}
		}

		// Token: 0x0603A0CC RID: 237772 RVA: 0x010556C8 File Offset: 0x010538C8
		protected override void OnUnListen()
		{
			if (new Action<bool>(this.FollowerEnableChangeEventHandle) != null && EventSystem.Instance.Has(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.FollowerEnableChangeEventHandle)))
			{
				EventSystem.Instance.Remove(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.FollowerEnableChangeEventHandle));
			}
		}
	}
}
