using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E37 RID: 20023
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueSelectBaseView : UiViewBase
	{
		// Token: 0x060339ED RID: 211437 RVA: 0x00C14CBC File Offset: 0x00C12EBC
		public RogueSelectBaseView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060339EE RID: 211438 RVA: 0x00C14CC8 File Offset: 0x00C12EC8
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoguelikeDataUpdate, new Action(this.OnDescModelChange));
			EventSystem.Instance.Add(EEventName.RoguelikeCloseGainSelectView, new Action(this.CloseMySelf));
			EventSystem.Instance.Add(EEventName.RoguelikeChooseDataResult, new Action<RogueGainEntry, RogueGainEntry, bool, int, RoguelikeChooseDataResultResponse>(this.RoguelikeChooseDataResult));
			EventSystem.Instance.Add(EEventName.RoguelikeRefreshGain, new Action<int>(this.RoguelikeRefreshGain));
		}

		// Token: 0x060339EF RID: 211439 RVA: 0x00C14D48 File Offset: 0x00C12F48
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeDataUpdate, new Action(this.OnDescModelChange));
			EventSystem.Instance.Remove(EEventName.RoguelikeCloseGainSelectView, new Action(this.CloseMySelf));
			EventSystem.Instance.Remove(EEventName.RoguelikeChooseDataResult, new Action<RogueGainEntry, RogueGainEntry, bool, int, RoguelikeChooseDataResultResponse>(this.RoguelikeChooseDataResult));
			EventSystem.Instance.Remove(EEventName.RoguelikeRefreshGain, new Action<int>(this.RoguelikeRefreshGain));
		}

		// Token: 0x060339F0 RID: 211440 RVA: 0x00C14DC8 File Offset: 0x00C12FC8
		protected virtual void OnDescModelChange()
		{
		}

		// Token: 0x060339F1 RID: 211441 RVA: 0x00C14DCA File Offset: 0x00C12FCA
		protected void CloseMySelf()
		{
			base.CloseMe(null);
		}

		// Token: 0x060339F2 RID: 211442 RVA: 0x00C14DD3 File Offset: 0x00C12FD3
		protected virtual void RoguelikeChooseDataResult(RogueGainEntry newRogueGainEntry, RogueGainEntry oldRogueGainEntry, bool isSuccess, int bindId, RoguelikeChooseDataResultResponse response)
		{
		}

		// Token: 0x060339F3 RID: 211443 RVA: 0x00C14DD5 File Offset: 0x00C12FD5
		protected virtual void RoguelikeRefreshGain(int index)
		{
		}

		// Token: 0x060339F4 RID: 211444 RVA: 0x00C14DD7 File Offset: 0x00C12FD7
		protected void RecycleUiPoolActor()
		{
			if (this.UiPoolActorPrivate != null)
			{
				UiActorPool.Instance.RecycleAsync(this.UiPoolActorPrivate, this.UiPoolActorPrivate.Path);
			}
		}

		// Token: 0x0401B610 RID: 112144
		[Nullable(2)]
		protected UiPoolActor UiPoolActorPrivate;
	}
}
