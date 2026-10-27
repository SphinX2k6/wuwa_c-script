using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Item
{
	// Token: 0x020069D5 RID: 27093
	[NullableContext(2)]
	[Nullable(0)]
	public class TuningStandGridEndItem : TuningStandGridBase
	{
		// Token: 0x0604368B RID: 276107 RVA: 0x01078E0F File Offset: 0x0107700F
		[NullableContext(1)]
		public TuningStandGridEndItem(TuningGridData data) : base(data)
		{
		}

		// Token: 0x0604368C RID: 276108 RVA: 0x01078E18 File Offset: 0x01077018
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
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

		// Token: 0x0604368D RID: 276109 RVA: 0x01078F6C File Offset: 0x0107716C
		protected override UniTask OnBeforeStartAsync()
		{
			TuningStandGridEndItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TuningStandGridEndItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604368E RID: 276110 RVA: 0x01078FAF File Offset: 0x010771AF
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			base.GetItem(5).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			this.InitLongPress();
			this.InitGrid();
		}

		// Token: 0x0604368F RID: 276111 RVA: 0x01078FE8 File Offset: 0x010771E8
		protected override void OnBeforeDestroy()
		{
			this.LineLeft = null;
			this.LineRight = null;
			this.LineTop = null;
			this.LineBottom = null;
		}

		// Token: 0x06043690 RID: 276112 RVA: 0x01079006 File Offset: 0x01077206
		protected override void OnResetGrid()
		{
			this.ResetLine();
			this.StopAllAnim();
			this.RefreshLine();
		}

		// Token: 0x06043691 RID: 276113 RVA: 0x0107901C File Offset: 0x0107721C
		protected override void InitGrid()
		{
			string[] array;
			if (!TuningStandDefine.gridSpriteMap.TryGetValue(this.GridType.Value, out array))
			{
				return;
			}
			this.CurSelected = false;
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(array[0]);
			this.SetSpriteByPath(resourcePath, base.GetSprite(1), false, null, null);
			this.SetSpriteByPath(resourcePath, base.GetSprite(3), false, null, null);
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath(array[2]);
			this.SetSpriteByPath(resourcePath2, base.GetSprite(4), false, null, null);
			string resourcePath3 = UiResourceConfig.Instance.GetResourcePath(array[1]);
			this.SetSpriteByPath(resourcePath3, base.GetSprite(6), false, null, null);
			ETuningStandGridType gridType = base.Data.GridType;
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(gridType == ETuningStandGridType.End1);
			}
			UUIItem item2 = base.GetItem(0);
			if (item2 != null)
			{
				item2.SetUIActive(gridType == ETuningStandGridType.End2);
			}
			this.OnRefreshGrid();
		}

		// Token: 0x06043692 RID: 276114 RVA: 0x01079120 File Offset: 0x01077320
		public override void OnRefreshGrid()
		{
			bool state = base.Data.GetCurGridState().State != EGridBelongType.Empty;
			this.RefreshLine();
			if (!state)
			{
				if (this.CurSelected)
				{
					this.CurSelected = false;
					this.StopAllAnim();
					LevelSequencePlayer sequencePlayer = this.SequencePlayer;
					if (sequencePlayer == null)
					{
						return;
					}
					sequencePlayer.PlayLevelSequenceByName("Move", false, null, false);
					return;
				}
			}
			else if (!this.CurSelected)
			{
				this.CurSelected = true;
				this.StopAllAnim();
				LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
				if (sequencePlayer2 == null)
				{
					return;
				}
				sequencePlayer2.PlayLevelSequenceByName("Select", false, null, false);
			}
		}

		// Token: 0x06043693 RID: 276115 RVA: 0x010791B0 File Offset: 0x010773B0
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

		// Token: 0x06043694 RID: 276116 RVA: 0x010791FC File Offset: 0x010773FC
		protected override void OnToggleUnHover()
		{
			UUIItem item = base.GetItem(8);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06043695 RID: 276117 RVA: 0x01079210 File Offset: 0x01077410
		protected override void OnTogglePress()
		{
		}

		// Token: 0x06043696 RID: 276118 RVA: 0x01079212 File Offset: 0x01077412
		protected override void OnToggleRelease()
		{
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			TuningStandModel.Instance.OnRelease(base.Data);
		}

		// Token: 0x06043697 RID: 276119 RVA: 0x01079237 File Offset: 0x01077437
		protected override void OnToggleCancel()
		{
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			TuningStandModel.Instance.OnRelease(base.Data);
		}

		// Token: 0x06043698 RID: 276120 RVA: 0x0107925C File Offset: 0x0107745C
		protected void InitLongPress()
		{
			this.LongPress = new LongPressButtonItem(null, new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), null);
			this.LongPress.Initialize(base.GetExtendToggle(9), null, new Action(this.OnTogglePress), new Action(this.OnToggleRelease), new Action(this.OnToggleCancel));
			base.GetExtendToggle(9).OnHover.Add(new Action(this.OnToggleHover));
			base.GetExtendToggle(9).OnUnHover.Add(new Action(this.OnToggleUnHover));
		}

		// Token: 0x06043699 RID: 276121 RVA: 0x01079304 File Offset: 0x01077504
		private void StopAllAnim()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null && sequencePlayer.IsPlayingSequence("Move"))
			{
				this.SequencePlayer.StopSequenceByKey("Move", false, false);
			}
			LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
			if (sequencePlayer2 != null && sequencePlayer2.IsPlayingSequence("Select"))
			{
				this.SequencePlayer.StopSequenceByKey("Select", false, false);
			}
		}

		// Token: 0x0604369A RID: 276122 RVA: 0x01079367 File Offset: 0x01077567
		public override void PlayInAnim(float dist)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("In", true, new float?(dist / 10f + 1f));
		}

		// Token: 0x0604369B RID: 276123 RVA: 0x01079394 File Offset: 0x01077594
		private void RefreshLine()
		{
			ETuningStandPrevDirect prevDirection = base.GetPrevDirection();
			this.LineLeft.Refresh(prevDirection == ETuningStandPrevDirect.Left, base.Data.GetCurGridState().State);
			this.LineRight.Refresh(prevDirection == ETuningStandPrevDirect.Right, base.Data.GetCurGridState().State);
			this.LineTop.Refresh(prevDirection == ETuningStandPrevDirect.Top, base.Data.GetCurGridState().State);
			this.LineBottom.Refresh(prevDirection == ETuningStandPrevDirect.Bottom, base.Data.GetCurGridState().State);
		}

		// Token: 0x0604369C RID: 276124 RVA: 0x01079424 File Offset: 0x01077624
		private void ResetLine()
		{
			this.LineLeft.HideLine();
			this.LineRight.HideLine();
			this.LineTop.HideLine();
			this.LineBottom.HideLine();
		}

		// Token: 0x0604369D RID: 276125 RVA: 0x01079454 File Offset: 0x01077654
		public override void StartRevolving()
		{
			this.LineLeft.Refresh(false, base.Data.GetCurGridState().State);
			this.LineRight.Refresh(false, base.Data.GetCurGridState().State);
			this.LineTop.Refresh(false, base.Data.GetCurGridState().State);
			this.LineBottom.Refresh(false, base.Data.GetCurGridState().State);
		}

		// Token: 0x040232C3 RID: 144067
		private LongPressButtonItem LongPress;

		// Token: 0x040232C4 RID: 144068
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x040232C5 RID: 144069
		private TuningStandGridLine LineLeft;

		// Token: 0x040232C6 RID: 144070
		private TuningStandGridLine LineRight;

		// Token: 0x040232C7 RID: 144071
		private TuningStandGridLine LineTop;

		// Token: 0x040232C8 RID: 144072
		private TuningStandGridLine LineBottom;
	}
}
