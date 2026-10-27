using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb
{
	// Token: 0x02005276 RID: 21110
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleVsView : UiViewBase
	{
		// Token: 0x06035FE6 RID: 221158 RVA: 0x00CC71BA File Offset: 0x00CC53BA
		public PhantomArenaBattleVsView(UiViewInfo uiViewInfo) : base(uiViewInfo)
		{
		}

		// Token: 0x06035FE7 RID: 221159 RVA: 0x00CC71C3 File Offset: 0x00CC53C3
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnAnimStop), false);
		}

		// Token: 0x06035FE8 RID: 221160 RVA: 0x00CC71EE File Offset: 0x00CC53EE
		protected override void OnAfterShow()
		{
			if (UiManager.Instance.IsViewHide(EUiViewName.PhantomArenaBattleLoading))
			{
				this.OnLoadingHide();
			}
		}

		// Token: 0x06035FE9 RID: 221161 RVA: 0x00CC7207 File Offset: 0x00CC5407
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPhantomArenaBattleLoadingHide, new Action(this.OnLoadingHide));
		}

		// Token: 0x06035FEA RID: 221162 RVA: 0x00CC7225 File Offset: 0x00CC5425
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaBattleLoadingHide, new Action(this.OnLoadingHide));
		}

		// Token: 0x06035FEB RID: 221163 RVA: 0x00CC7244 File Offset: 0x00CC5444
		private void OnAnimStop(string _)
		{
			PhantomArenaBattleDetailsViewProxy param = new PhantomArenaBattleDetailsViewProxy();
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaBattleDetailsView, param, delegate(bool _, int _)
			{
				PhantomArenaBattleController.RequestBvbLoadingFinish();
				base.CloseMe(null);
			});
		}

		// Token: 0x06035FEC RID: 221164 RVA: 0x00CC7274 File Offset: 0x00CC5474
		private void OnLoadingHide()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.PlayLevelSequenceByName("Start01", false, null, false);
			}
			AudioSystem.Instance.SetState("arena_battle", "battle_3d", true);
		}

		// Token: 0x06035FED RID: 221165 RVA: 0x00CC72B7 File Offset: 0x00CC54B7
		protected override string OnGetLoopAudioEvent()
		{
			if (PhantomArenaBattleModel.Instance.IsOldBvb)
			{
				return this.ViewInfo.LoopAudioEvent;
			}
			return "play_ui_music_3_0_arena_card_battle";
		}

		// Token: 0x0401C977 RID: 117111
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x0200B478 RID: 46200
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036AD4 RID: 223956
			public const int OwnArea = 0;

			// Token: 0x04036AD5 RID: 223957
			public const int OpponentArea = 1;

			// Token: 0x04036AD6 RID: 223958
			public const int BackBtn = 2;

			// Token: 0x04036AD7 RID: 223959
			public const int SkipBtn = 3;

			// Token: 0x04036AD8 RID: 223960
			public const int DraggableComponent = 4;

			// Token: 0x04036AD9 RID: 223961
			public const int NiagaraPoint = 5;

			// Token: 0x04036ADA RID: 223962
			public const int TxtSpeed = 6;

			// Token: 0x04036ADB RID: 223963
			public const int NiagaraPointMe = 7;

			// Token: 0x04036ADC RID: 223964
			public const int CameraMoveItem = 8;

			// Token: 0x04036ADD RID: 223965
			public const int DamageStatisticsItem = 9;
		}
	}
}
