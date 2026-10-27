using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.LevelListeners
{
	// Token: 0x02006AE1 RID: 27361
	public class LevelConditionListenerCheckIsTargetHoldElementalBox : LevelListenerBase
	{
		// Token: 0x06043F84 RID: 278404 RVA: 0x010AC139 File Offset: 0x010AA339
		private void OnCoreChanged()
		{
			TListenerCallbackFunc callback = this.Callback;
			if (callback == null)
			{
				return;
			}
			callback(null, Array.Empty<object>());
		}

		// Token: 0x06043F85 RID: 278405 RVA: 0x010AC151 File Offset: 0x010AA351
		[NullableContext(1)]
		protected override void OnListen(object listeningInfo, TListenerCallbackFunc callback, [Nullable(2)] GeneralContext context = null, params object[] otherParams)
		{
			if (!EventSystem.Instance.Has(EEventName.OnElementalFoundationCoreChanged, new Action(this.OnCoreChanged)))
			{
				EventSystem.Instance.Add(EEventName.OnElementalFoundationCoreChanged, new Action(this.OnCoreChanged));
			}
		}

		// Token: 0x06043F86 RID: 278406 RVA: 0x010AC18C File Offset: 0x010AA38C
		protected override void OnUnListen()
		{
			if (EventSystem.Instance.Has(EEventName.OnElementalFoundationCoreChanged, new Action(this.OnCoreChanged)))
			{
				EventSystem.Instance.Remove(EEventName.OnElementalFoundationCoreChanged, new Action(this.OnCoreChanged));
			}
		}
	}
}
