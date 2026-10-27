using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Item
{
	// Token: 0x020069DA RID: 27098
	[NullableContext(2)]
	[Nullable(0)]
	public class TuningStandGridStartItem : TuningStandGridBase
	{
		// Token: 0x060436BA RID: 276154 RVA: 0x01079CFD File Offset: 0x01077EFD
		[NullableContext(1)]
		public TuningStandGridStartItem(TuningGridData data) : base(data)
		{
		}

		// Token: 0x060436BB RID: 276155 RVA: 0x01079D08 File Offset: 0x01077F08
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

		// Token: 0x060436BC RID: 276156 RVA: 0x01079DFD File Offset: 0x01077FFD
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			base.GetItem(2).SetUIActive(false);
			base.GetItem(3).SetUIActive(false);
			this.InitLongPress();
			this.InitGrid();
		}

		// Token: 0x060436BD RID: 276157 RVA: 0x01079E36 File Offset: 0x01078036
		protected override void OnResetGrid()
		{
			this.StopAllAnim();
		}

		// Token: 0x060436BE RID: 276158 RVA: 0x01079E40 File Offset: 0x01078040
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

		// Token: 0x060436BF RID: 276159 RVA: 0x01079E8C File Offset: 0x0107808C
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

		// Token: 0x060436C0 RID: 276160 RVA: 0x01079FAB File Offset: 0x010781AB
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

		// Token: 0x060436C1 RID: 276161 RVA: 0x01079FDF File Offset: 0x010781DF
		protected override void OnToggleUnHover()
		{
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x060436C2 RID: 276162 RVA: 0x01079FF3 File Offset: 0x010781F3
		protected override void OnTogglePress()
		{
			TuningStandModel.Instance.OnPress(base.Data);
			this.OnRefreshGrid();
		}

		// Token: 0x060436C3 RID: 276163 RVA: 0x0107A00B File Offset: 0x0107820B
		protected override void OnToggleRelease()
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			TuningStandModel.Instance.OnRelease(base.Data);
		}

		// Token: 0x060436C4 RID: 276164 RVA: 0x0107A030 File Offset: 0x01078230
		protected override void OnToggleCancel()
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			TuningStandModel.Instance.OnRelease(base.Data);
		}

		// Token: 0x060436C5 RID: 276165 RVA: 0x0107A058 File Offset: 0x01078258
		protected void InitLongPress()
		{
			this.LongPress = new LongPressButtonItem(null, new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), null);
			this.LongPress.Initialize(base.GetExtendToggle(5), null, new Action(this.OnTogglePress), new Action(this.OnToggleRelease), new Action(this.OnToggleCancel));
			base.GetExtendToggle(5).OnHover.Add(new Action(this.OnToggleHover));
			base.GetExtendToggle(5).OnUnHover.Add(new Action(this.OnToggleUnHover));
		}

		// Token: 0x060436C6 RID: 276166 RVA: 0x0107A0FC File Offset: 0x010782FC
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

		// Token: 0x060436C7 RID: 276167 RVA: 0x0107A1B5 File Offset: 0x010783B5
		public override void PlayInAnim(float dist)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("In", true, new float?(dist / 10f + 1f));
		}

		// Token: 0x060436C8 RID: 276168 RVA: 0x0107A1E0 File Offset: 0x010783E0
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

		// Token: 0x040232EC RID: 144108
		private LongPressButtonItem LongPress;

		// Token: 0x040232ED RID: 144109
		protected LevelSequencePlayer SequencePlayer;
	}
}
