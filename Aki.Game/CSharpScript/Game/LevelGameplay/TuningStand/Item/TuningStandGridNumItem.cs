using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Item
{
	// Token: 0x020069D8 RID: 27096
	[NullableContext(2)]
	[Nullable(0)]
	public class TuningStandGridNumItem : TuningStandGridBase
	{
		// Token: 0x060436A7 RID: 276135 RVA: 0x010796BC File Offset: 0x010778BC
		[NullableContext(1)]
		public TuningStandGridNumItem(TuningGridData data) : base(data)
		{
		}

		// Token: 0x060436A8 RID: 276136 RVA: 0x010796C8 File Offset: 0x010778C8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUISprite)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem))
			};
		}

		// Token: 0x060436A9 RID: 276137 RVA: 0x0107981C File Offset: 0x01077A1C
		protected override UniTask OnBeforeStartAsync()
		{
			TuningStandGridNumItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TuningStandGridNumItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060436AA RID: 276138 RVA: 0x0107985F File Offset: 0x01077A5F
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.InitLongPress();
			base.GetItem(4).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			this.InitGrid();
		}

		// Token: 0x060436AB RID: 276139 RVA: 0x01079898 File Offset: 0x01077A98
		protected override void OnBeforeDestroy()
		{
			this.LineLeft = null;
			this.LineRight = null;
			this.LineTop = null;
			this.LineBottom = null;
		}

		// Token: 0x060436AC RID: 276140 RVA: 0x010798B8 File Offset: 0x01077AB8
		protected override void InitGrid()
		{
			string[] array;
			if (!TuningStandDefine.gridSpriteMap.TryGetValue(this.GridType.Value, out array))
			{
				return;
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(array[0]);
			this.SetSpriteByPath(resourcePath, base.GetSprite(1), false, null, null);
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath(array[2]);
			this.SetSpriteByPath(resourcePath2, base.GetSprite(3), false, null, null);
			string resourcePath3 = UiResourceConfig.Instance.GetResourcePath(array[1]);
			this.SetSpriteByPath(resourcePath3, base.GetSprite(6), false, null, null);
			this.OnRefreshGrid();
		}

		// Token: 0x060436AD RID: 276141 RVA: 0x0107995D File Offset: 0x01077B5D
		protected override void OnResetGrid()
		{
			this.ResetLine();
			this.OnRefreshGrid();
		}

		// Token: 0x060436AE RID: 276142 RVA: 0x0107996C File Offset: 0x01077B6C
		public override void OnRefreshGrid()
		{
			EGridBelongType state = base.Data.GetCurGridState().State;
			this.RefreshLine();
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(state == EGridBelongType.Empty);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(state == EGridBelongType.Type1);
			}
			UUIItem item3 = base.GetItem(2);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(state == EGridBelongType.Type2);
		}

		// Token: 0x060436AF RID: 276143 RVA: 0x010799D4 File Offset: 0x01077BD4
		protected override void OnToggleHover()
		{
			EGridCheckReturnState egridCheckReturnState = TuningStandModel.Instance.OnHover(base.Data);
			if (egridCheckReturnState == EGridCheckReturnState.Error)
			{
				UUIItem item = base.GetItem(8);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				TuningStandModel.Instance.TryStartBubbleFlow(ETuningStandBubbleTriggerType.InvalidLink);
				return;
			}
			if (egridCheckReturnState == EGridCheckReturnState.Valid)
			{
				this.OnRefreshGrid();
			}
		}

		// Token: 0x060436B0 RID: 276144 RVA: 0x01079A20 File Offset: 0x01077C20
		protected override void OnToggleUnHover()
		{
			UUIItem item = base.GetItem(8);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x060436B1 RID: 276145 RVA: 0x01079A34 File Offset: 0x01077C34
		protected override void OnTogglePress()
		{
			TuningStandModel.Instance.OnPress(base.Data);
		}

		// Token: 0x060436B2 RID: 276146 RVA: 0x01079A46 File Offset: 0x01077C46
		protected override void OnToggleRelease()
		{
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			TuningStandModel.Instance.OnRelease(base.Data);
		}

		// Token: 0x060436B3 RID: 276147 RVA: 0x01079A6B File Offset: 0x01077C6B
		protected override void OnToggleCancel()
		{
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			TuningStandModel.Instance.OnRelease(base.Data);
		}

		// Token: 0x060436B4 RID: 276148 RVA: 0x01079A90 File Offset: 0x01077C90
		protected void InitLongPress()
		{
			this.LongPress = new LongPressButtonItem(null, new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), null);
			this.LongPress.Initialize(base.GetExtendToggle(9), null, new Action(this.OnTogglePress), new Action(this.OnToggleRelease), new Action(this.OnToggleCancel));
			base.GetExtendToggle(9).OnHover.Add(new Action(this.OnToggleHover));
			base.GetExtendToggle(9).OnUnHover.Add(new Action(this.OnToggleUnHover));
		}

		// Token: 0x060436B5 RID: 276149 RVA: 0x01079B36 File Offset: 0x01077D36
		public override void PlayInAnim(float dist)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("In", true, new float?(dist / 10f + 1f));
		}

		// Token: 0x060436B6 RID: 276150 RVA: 0x01079B60 File Offset: 0x01077D60
		private void RefreshLine()
		{
			ETuningStandPrevDirect prevDirection = base.GetPrevDirection();
			this.LineLeft.Refresh(prevDirection == ETuningStandPrevDirect.Left, base.Data.GetCurGridState().State);
			this.LineRight.Refresh(prevDirection == ETuningStandPrevDirect.Right, base.Data.GetCurGridState().State);
			this.LineTop.Refresh(prevDirection == ETuningStandPrevDirect.Top, base.Data.GetCurGridState().State);
			this.LineBottom.Refresh(prevDirection == ETuningStandPrevDirect.Bottom, base.Data.GetCurGridState().State);
		}

		// Token: 0x060436B7 RID: 276151 RVA: 0x01079BF0 File Offset: 0x01077DF0
		private void ResetLine()
		{
			this.LineLeft.HideLine();
			this.LineRight.HideLine();
			this.LineTop.HideLine();
			this.LineBottom.HideLine();
		}

		// Token: 0x060436B8 RID: 276152 RVA: 0x01079C20 File Offset: 0x01077E20
		public override void OnLinkMiss(bool isEnd)
		{
			if (!isEnd)
			{
				LevelSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer != null && sequencePlayer.IsPlayingSequence("Loop"))
				{
					LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
					if (sequencePlayer2 == null)
					{
						return;
					}
					sequencePlayer2.StopSequenceByKey("Loop", false, true);
				}
				return;
			}
			LevelSequencePlayer sequencePlayer3 = this.SequencePlayer;
			if (sequencePlayer3 == null)
			{
				return;
			}
			sequencePlayer3.PlayOrReplaySequenceByName("Loop", false, null);
		}

		// Token: 0x060436B9 RID: 276153 RVA: 0x01079C80 File Offset: 0x01077E80
		public override void StartRevolving()
		{
			this.LineLeft.Refresh(false, base.Data.GetCurGridState().State);
			this.LineRight.Refresh(false, base.Data.GetCurGridState().State);
			this.LineTop.Refresh(false, base.Data.GetCurGridState().State);
			this.LineBottom.Refresh(false, base.Data.GetCurGridState().State);
		}

		// Token: 0x040232DB RID: 144091
		private LongPressButtonItem LongPress;

		// Token: 0x040232DC RID: 144092
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x040232DD RID: 144093
		private TuningStandGridLine LineLeft;

		// Token: 0x040232DE RID: 144094
		private TuningStandGridLine LineRight;

		// Token: 0x040232DF RID: 144095
		private TuningStandGridLine LineTop;

		// Token: 0x040232E0 RID: 144096
		private TuningStandGridLine LineBottom;
	}
}
