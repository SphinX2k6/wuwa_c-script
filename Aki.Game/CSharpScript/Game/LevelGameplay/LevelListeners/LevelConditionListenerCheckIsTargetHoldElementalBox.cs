using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.LevelListeners
{
	// Token: 0x02005C59 RID: 23641
	public class LevelConditionListenerCheckIsTargetHoldElementalBox : LevelListenerBase
	{
		// Token: 0x0603A0D6 RID: 237782 RVA: 0x010559B1 File Offset: 0x01053BB1
		private void OnCoreChanged()
		{
			TListenerCallbackFunc callback = this.Callback;
			if (callback == null)
			{
				return;
			}
			callback(null, Array.Empty<object>());
		}

		// Token: 0x0603A0D7 RID: 237783 RVA: 0x010559C9 File Offset: 0x01053BC9
		[NullableContext(1)]
		protected override void OnListen(object listeningInfo, TListenerCallbackFunc callback, [Nullable(2)] GeneralContext context = null, params object[] otherParams)
		{
			if (!EventSystem.Instance.Has(EEventName.OnElementalFoundationCoreChanged, new Action(this.OnCoreChanged)))
			{
				EventSystem.Instance.Add(EEventName.OnElementalFoundationCoreChanged, new Action(this.OnCoreChanged));
			}
		}

		// Token: 0x0603A0D8 RID: 237784 RVA: 0x01055A04 File Offset: 0x01053C04
		protected override void OnUnListen()
		{
			if (EventSystem.Instance.Has(EEventName.OnElementalFoundationCoreChanged, new Action(this.OnCoreChanged)))
			{
				EventSystem.Instance.Remove(EEventName.OnElementalFoundationCoreChanged, new Action(this.OnCoreChanged));
			}
		}
	}
}
