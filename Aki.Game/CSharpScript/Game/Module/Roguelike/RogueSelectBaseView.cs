using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003E00 RID: 15872
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueSelectBaseView : UiViewBase
	{
		// Token: 0x06028858 RID: 165976 RVA: 0x00B5E1E4 File Offset: 0x00B5C3E4
		public RogueSelectBaseView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06028859 RID: 165977 RVA: 0x00B5E1F0 File Offset: 0x00B5C3F0
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoguelikeDataUpdate, new Action(this.OnDescModelChange));
			EventSystem.Instance.Add(EEventName.RoguelikeCloseGainSelectView, new Action(this.CloseMySelf));
			EventSystem.Instance.Add(EEventName.RoguelikeChooseDataResult, new Action<RogueGainEntry, RogueGainEntry, bool, int, RoguelikeChooseDataResultResponse>(this.RoguelikeChooseDataResult));
			EventSystem.Instance.Add(EEventName.RoguelikeRefreshGain, new Action<int>(this.RoguelikeRefreshGain));
		}

		// Token: 0x0602885A RID: 165978 RVA: 0x00B5E270 File Offset: 0x00B5C470
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeDataUpdate, new Action(this.OnDescModelChange));
			EventSystem.Instance.Remove(EEventName.RoguelikeCloseGainSelectView, new Action(this.CloseMySelf));
			EventSystem.Instance.Remove(EEventName.RoguelikeChooseDataResult, new Action<RogueGainEntry, RogueGainEntry, bool, int, RoguelikeChooseDataResultResponse>(this.RoguelikeChooseDataResult));
			EventSystem.Instance.Remove(EEventName.RoguelikeRefreshGain, new Action<int>(this.RoguelikeRefreshGain));
		}

		// Token: 0x0602885B RID: 165979 RVA: 0x00B5E2F0 File Offset: 0x00B5C4F0
		protected virtual void OnDescModelChange()
		{
		}

		// Token: 0x0602885C RID: 165980 RVA: 0x00B5E2F2 File Offset: 0x00B5C4F2
		protected void CloseMySelf()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602885D RID: 165981 RVA: 0x00B5E2FB File Offset: 0x00B5C4FB
		protected virtual void RoguelikeChooseDataResult(RogueGainEntry newRogueGainEntry, RogueGainEntry oldRogueGainEntry, bool isSuccess, int bindId, RoguelikeChooseDataResultResponse response)
		{
		}

		// Token: 0x0602885E RID: 165982 RVA: 0x00B5E2FD File Offset: 0x00B5C4FD
		protected virtual void RoguelikeRefreshGain(int index)
		{
		}

		// Token: 0x0602885F RID: 165983 RVA: 0x00B5E2FF File Offset: 0x00B5C4FF
		protected void RecycleUiPoolActor()
		{
			if (this.UiPoolActorPrivate != null)
			{
				UiActorPool.Instance.RecycleAsync(this.UiPoolActorPrivate, this.UiPoolActorPrivate.Path);
			}
		}

		// Token: 0x04015FE3 RID: 90083
		[Nullable(2)]
		protected UiPoolActor UiPoolActorPrivate;
	}
}
