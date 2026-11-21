using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Item
{
	// Token: 0x02005B31 RID: 23345
	[NullableContext(2)]
	[Nullable(0)]
	public class TuningStandGridEndItem : TuningStandGridBase
	{
		// Token: 0x060396C7 RID: 235207 RVA: 0x0101D2C3 File Offset: 0x0101B4C3
		[NullableContext(1)]
		public TuningStandGridEndItem(TuningGridData data) : base(data)
		{
		}

		// Token: 0x060396C8 RID: 235208 RVA: 0x0101D2CC File Offset: 0x0101B4CC
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

		// Token: 0x060396C9 RID: 235209 RVA: 0x0101D420 File Offset: 0x0101B620
		protected override UniTask OnBeforeStartAsync()
		{
			TuningStandGridEndItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TuningStandGridEndItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060396CA RID: 235210 RVA: 0x0101D463 File Offset: 0x0101B663
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			base.GetItem(5).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			this.InitLongPress();
			this.InitGrid();
		}

		// Token: 0x060396CB RID: 235211 RVA: 0x0101D49C File Offset: 0x0101B69C
		protected override void OnBeforeDestroy()
		{
			this.LineLeft = null;
			this.LineRight = null;
			this.LineTop = null;
			this.LineBottom = null;
		}

		// Token: 0x060396CC RID: 235212 RVA: 0x0101D4BA File Offset: 0x0101B6BA
		protected override void OnResetGrid()
		{
			this.ResetLine();
			this.StopAllAnim();
			this.RefreshLine();
		}

		// Token: 0x060396CD RID: 235213 RVA: 0x0101D4D0 File Offset: 0x0101B6D0
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

		// Token: 0x060396CE RID: 235214 RVA: 0x0101D5D4 File Offset: 0x0101B7D4
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

		// Token: 0x060396CF RID: 235215 RVA: 0x0101D664 File Offset: 0x0101B864
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

		// Token: 0x060396D0 RID: 235216 RVA: 0x0101D6B0 File Offset: 0x0101B8B0
		protected override void OnToggleUnHover()
		{
			UUIItem item = base.GetItem(8);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x060396D1 RID: 235217 RVA: 0x0101D6C4 File Offset: 0x0101B8C4
		protected override void OnTogglePress()
		{
		}

		// Token: 0x060396D2 RID: 235218 RVA: 0x0101D6C6 File Offset: 0x0101B8C6
		protected override void OnToggleRelease()
		{
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			TuningStandModel.Instance.OnRelease(base.Data);
		}

		// Token: 0x060396D3 RID: 235219 RVA: 0x0101D6EB File Offset: 0x0101B8EB
		protected override void OnToggleCancel()
		{
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			TuningStandModel.Instance.OnRelease(base.Data);
		}

		// Token: 0x060396D4 RID: 235220 RVA: 0x0101D710 File Offset: 0x0101B910
		protected void InitLongPress()
		{
			this.LongPress = new LongPressButtonItem(null, new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), null);
			this.LongPress.Initialize(base.GetExtendToggle(9), null, new Action(this.OnTogglePress), new Action(this.OnToggleRelease), new Action(this.OnToggleCancel));
			base.GetExtendToggle(9).OnHover.Add(new Action(this.OnToggleHover));
			base.GetExtendToggle(9).OnUnHover.Add(new Action(this.OnToggleUnHover));
		}

		// Token: 0x060396D5 RID: 235221 RVA: 0x0101D7B8 File Offset: 0x0101B9B8
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

		// Token: 0x060396D6 RID: 235222 RVA: 0x0101D81B File Offset: 0x0101BA1B
		public override void PlayInAnim(float dist)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("In", true, new float?(dist / 10f + 1f));
		}

		// Token: 0x060396D7 RID: 235223 RVA: 0x0101D848 File Offset: 0x0101BA48
		private void RefreshLine()
		{
			ETuningStandPrevDirect prevDirection = base.GetPrevDirection();
			this.LineLeft.Refresh(prevDirection == ETuningStandPrevDirect.Left, base.Data.GetCurGridState().State);
			this.LineRight.Refresh(prevDirection == ETuningStandPrevDirect.Right, base.Data.GetCurGridState().State);
			this.LineTop.Refresh(prevDirection == ETuningStandPrevDirect.Top, base.Data.GetCurGridState().State);
			this.LineBottom.Refresh(prevDirection == ETuningStandPrevDirect.Bottom, base.Data.GetCurGridState().State);
		}

		// Token: 0x060396D8 RID: 235224 RVA: 0x0101D8D8 File Offset: 0x0101BAD8
		private void ResetLine()
		{
			this.LineLeft.HideLine();
			this.LineRight.HideLine();
			this.LineTop.HideLine();
			this.LineBottom.HideLine();
		}

		// Token: 0x060396D9 RID: 235225 RVA: 0x0101D908 File Offset: 0x0101BB08
		public override void StartRevolving()
		{
			this.LineLeft.Refresh(false, base.Data.GetCurGridState().State);
			this.LineRight.Refresh(false, base.Data.GetCurGridState().State);
			this.LineTop.Refresh(false, base.Data.GetCurGridState().State);
			this.LineBottom.Refresh(false, base.Data.GetCurGridState().State);
		}

		// Token: 0x0401E4B3 RID: 124083
		private LongPressButtonItem LongPress;

		// Token: 0x0401E4B4 RID: 124084
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x0401E4B5 RID: 124085
		private TuningStandGridLine LineLeft;

		// Token: 0x0401E4B6 RID: 124086
		private TuningStandGridLine LineRight;

		// Token: 0x0401E4B7 RID: 124087
		private TuningStandGridLine LineTop;

		// Token: 0x0401E4B8 RID: 124088
		private TuningStandGridLine LineBottom;
	}
}
