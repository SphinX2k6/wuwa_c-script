using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Item
{
	// Token: 0x02005B36 RID: 23350
	[NullableContext(2)]
	[Nullable(0)]
	public class TuningStandGridStartItem : TuningStandGridBase
	{
		// Token: 0x060396F6 RID: 235254 RVA: 0x0101E1B1 File Offset: 0x0101C3B1
		[NullableContext(1)]
		public TuningStandGridStartItem(TuningGridData data) : base(data)
		{
		}

		// Token: 0x060396F7 RID: 235255 RVA: 0x0101E1BC File Offset: 0x0101C3BC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem))
			};
		}

		// Token: 0x060396F8 RID: 235256 RVA: 0x0101E2B1 File Offset: 0x0101C4B1
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			base.GetItem(2).SetUIActive(false);
			base.GetItem(3).SetUIActive(false);
			this.InitLongPress();
			this.InitGrid();
		}

		// Token: 0x060396F9 RID: 235257 RVA: 0x0101E2EA File Offset: 0x0101C4EA
		protected override void OnResetGrid()
		{
			this.StopAllAnim();
		}

		// Token: 0x060396FA RID: 235258 RVA: 0x0101E2F4 File Offset: 0x0101C4F4
		protected override void InitGrid()
		{
			this.CurSelected = false;
			bool flag = this.GridType.GetValueOrDefault() == ETuningStandGridType.Start1;
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(flag);
		}

		// Token: 0x060396FB RID: 235259 RVA: 0x0101E340 File Offset: 0x0101C540
		public override void OnRefreshGrid()
		{
			if (TuningStandModel.Instance.GetIsPressing())
			{
				int? curIndex = TuningStandModel.Instance.GetCurIndex();
				if (TuningStandModel.Instance.GetGridList()[curIndex.Value].GetCurGridState().State == base.Data.StaticState.State && !this.CurSelected)
				{
					this.CurSelected = true;
					this.StopAllAnim();
					this.SequencePlayer.PlayOrReplaySequenceByName("Drag", false, null);
					return;
				}
			}
			else
			{
				if (!this.CurSelected && base.Data.StaticState.Next != null)
				{
					this.CurSelected = true;
					this.StopAllAnim();
					this.SequencePlayer.PlayOrReplaySequenceByName("Drag", false, null);
					return;
				}
				if (this.CurSelected && base.Data.StaticState.Next == null)
				{
					this.CurSelected = false;
					this.StopAllAnim();
					this.SequencePlayer.PlayOrReplaySequenceByName("Unfold", false, null);
				}
			}
		}

		// Token: 0x060396FC RID: 235260 RVA: 0x0101E45F File Offset: 0x0101C65F
		protected override void OnToggleHover()
		{
			if (TuningStandModel.Instance.OnHover(base.Data) == EGridCheckReturnState.Error)
			{
				UUIItem item = base.GetItem(4);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				TuningStandModel.Instance.TryStartBubbleFlow(ETuningStandBubbleTriggerType.InvalidLink);
			}
		}

		// Token: 0x060396FD RID: 235261 RVA: 0x0101E493 File Offset: 0x0101C693
		protected override void OnToggleUnHover()
		{
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x060396FE RID: 235262 RVA: 0x0101E4A7 File Offset: 0x0101C6A7
		protected override void OnTogglePress()
		{
			TuningStandModel.Instance.OnPress(base.Data);
			this.OnRefreshGrid();
		}

		// Token: 0x060396FF RID: 235263 RVA: 0x0101E4BF File Offset: 0x0101C6BF
		protected override void OnToggleRelease()
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			TuningStandModel.Instance.OnRelease(base.Data);
		}

		// Token: 0x06039700 RID: 235264 RVA: 0x0101E4E4 File Offset: 0x0101C6E4
		protected override void OnToggleCancel()
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			TuningStandModel.Instance.OnRelease(base.Data);
		}

		// Token: 0x06039701 RID: 235265 RVA: 0x0101E50C File Offset: 0x0101C70C
		protected void InitLongPress()
		{
			this.LongPress = new LongPressButtonItem(null, new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), null);
			this.LongPress.Initialize(base.GetExtendToggle(5), null, new Action(this.OnTogglePress), new Action(this.OnToggleRelease), new Action(this.OnToggleCancel));
			base.GetExtendToggle(5).OnHover.Add(new Action(this.OnToggleHover));
			base.GetExtendToggle(5).OnUnHover.Add(new Action(this.OnToggleUnHover));
		}

		// Token: 0x06039702 RID: 235266 RVA: 0x0101E5B0 File Offset: 0x0101C7B0
		private void StopAllAnim()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null && sequencePlayer.IsPlayingSequence("Drag"))
			{
				this.SequencePlayer.StopSequenceByKey("Drag", false, false);
			}
			LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
			if (sequencePlayer2 != null && sequencePlayer2.IsPlayingSequence("Unfold"))
			{
				this.SequencePlayer.StopSequenceByKey("Unfold", false, false);
			}
			LevelSequencePlayer sequencePlayer3 = this.SequencePlayer;
			if (sequencePlayer3 != null && sequencePlayer3.IsPlayingSequence("UnLoop"))
			{
				this.SequencePlayer.StopSequenceByKey("UnLoop", false, false);
			}
			LevelSequencePlayer sequencePlayer4 = this.SequencePlayer;
			if (sequencePlayer4 != null && sequencePlayer4.IsPlayingSequence("Loop"))
			{
				this.SequencePlayer.StopSequenceByKey("Loop", false, false);
			}
		}

		// Token: 0x06039703 RID: 235267 RVA: 0x0101E669 File Offset: 0x0101C869
		public override void PlayInAnim(float dist)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("In", true, new float?(dist / 10f + 1f));
		}

		// Token: 0x06039704 RID: 235268 RVA: 0x0101E694 File Offset: 0x0101C894
		public override void StartRevolving()
		{
			this.StopAllAnim();
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName("Up", false, null, false);
		}

		// Token: 0x0401E4DC RID: 124124
		private LongPressButtonItem LongPress;

		// Token: 0x0401E4DD RID: 124125
		protected LevelSequencePlayer SequencePlayer;
	}
}
