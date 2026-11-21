using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb
{
	// Token: 0x02004246 RID: 16966
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleVsView : UiViewBase
	{
		// Token: 0x0602AEE1 RID: 175841 RVA: 0x00C148BA File Offset: 0x00C12ABA
		public PhantomArenaBattleVsView(UiViewInfo uiViewInfo) : base(uiViewInfo)
		{
		}

		// Token: 0x0602AEE2 RID: 175842 RVA: 0x00C148C3 File Offset: 0x00C12AC3
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnAnimStop), false);
		}

		// Token: 0x0602AEE3 RID: 175843 RVA: 0x00C148EE File Offset: 0x00C12AEE
		protected override void OnAfterShow()
		{
			if (UiManager.Instance.IsViewHide(EUiViewName.PhantomArenaBattleLoading))
			{
				this.OnLoadingHide();
			}
		}

		// Token: 0x0602AEE4 RID: 175844 RVA: 0x00C14907 File Offset: 0x00C12B07
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPhantomArenaBattleLoadingHide, new Action(this.OnLoadingHide));
		}

		// Token: 0x0602AEE5 RID: 175845 RVA: 0x00C14925 File Offset: 0x00C12B25
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaBattleLoadingHide, new Action(this.OnLoadingHide));
		}

		// Token: 0x0602AEE6 RID: 175846 RVA: 0x00C14944 File Offset: 0x00C12B44
		private void OnAnimStop(string _)
		{
			PhantomArenaBattleDetailsViewProxy param = new PhantomArenaBattleDetailsViewProxy();
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaBattleDetailsView, param, delegate(bool _, int _)
			{
				PhantomArenaBattleController.RequestBvbLoadingFinish();
				base.CloseMe(null);
			});
		}

		// Token: 0x0602AEE7 RID: 175847 RVA: 0x00C14974 File Offset: 0x00C12B74
		private void OnLoadingHide()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.PlayLevelSequenceByName("Start01", false, null, false);
			}
			AudioSystem.Instance.SetState("arena_battle", "battle_3d", true);
		}

		// Token: 0x0602AEE8 RID: 175848 RVA: 0x00C149B7 File Offset: 0x00C12BB7
		protected override string OnGetBgm()
		{
			if (PhantomArenaBattleModel.Instance.IsOldBvb)
			{
				return this.ViewInfo.LoopAudioEvent;
			}
			return "play_ui_music_3_0_arena_card_battle";
		}

		// Token: 0x040173AC RID: 95148
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x02009EB0 RID: 40624
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04031527 RID: 202023
			public const int OwnArea = 0;

			// Token: 0x04031528 RID: 202024
			public const int OpponentArea = 1;

			// Token: 0x04031529 RID: 202025
			public const int BackBtn = 2;

			// Token: 0x0403152A RID: 202026
			public const int SkipBtn = 3;

			// Token: 0x0403152B RID: 202027
			public const int DraggableComponent = 4;

			// Token: 0x0403152C RID: 202028
			public const int NiagaraPoint = 5;

			// Token: 0x0403152D RID: 202029
			public const int TxtSpeed = 6;

			// Token: 0x0403152E RID: 202030
			public const int NiagaraPointMe = 7;

			// Token: 0x0403152F RID: 202031
			public const int CameraMoveItem = 8;

			// Token: 0x04031530 RID: 202032
			public const int DamageStatisticsItem = 9;
		}
	}
}
