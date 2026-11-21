using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Item
{
	// Token: 0x02005B34 RID: 23348
	[NullableContext(2)]
	[Nullable(0)]
	public class TuningStandGridNumItem : TuningStandGridBase
	{
		// Token: 0x060396E3 RID: 235235 RVA: 0x0101DB70 File Offset: 0x0101BD70
		[NullableContext(1)]
		public TuningStandGridNumItem(TuningGridData data) : base(data)
		{
		}

		// Token: 0x060396E4 RID: 235236 RVA: 0x0101DB7C File Offset: 0x0101BD7C
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

		// Token: 0x060396E5 RID: 235237 RVA: 0x0101DCD0 File Offset: 0x0101BED0
		protected override UniTask OnBeforeStartAsync()
		{
			TuningStandGridNumItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TuningStandGridNumItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060396E6 RID: 235238 RVA: 0x0101DD13 File Offset: 0x0101BF13
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.InitLongPress();
			base.GetItem(4).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			this.InitGrid();
		}

		// Token: 0x060396E7 RID: 235239 RVA: 0x0101DD4C File Offset: 0x0101BF4C
		protected override void OnBeforeDestroy()
		{
			this.LineLeft = null;
			this.LineRight = null;
			this.LineTop = null;
			this.LineBottom = null;
		}

		// Token: 0x060396E8 RID: 235240 RVA: 0x0101DD6C File Offset: 0x0101BF6C
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

		// Token: 0x060396E9 RID: 235241 RVA: 0x0101DE11 File Offset: 0x0101C011
		protected override void OnResetGrid()
		{
			this.ResetLine();
			this.OnRefreshGrid();
		}

		// Token: 0x060396EA RID: 235242 RVA: 0x0101DE20 File Offset: 0x0101C020
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

		// Token: 0x060396EB RID: 235243 RVA: 0x0101DE88 File Offset: 0x0101C088
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

		// Token: 0x060396EC RID: 235244 RVA: 0x0101DED4 File Offset: 0x0101C0D4
		protected override void OnToggleUnHover()
		{
			UUIItem item = base.GetItem(8);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x060396ED RID: 235245 RVA: 0x0101DEE8 File Offset: 0x0101C0E8
		protected override void OnTogglePress()
		{
			TuningStandModel.Instance.OnPress(base.Data);
		}

		// Token: 0x060396EE RID: 235246 RVA: 0x0101DEFA File Offset: 0x0101C0FA
		protected override void OnToggleRelease()
		{
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			TuningStandModel.Instance.OnRelease(base.Data);
		}

		// Token: 0x060396EF RID: 235247 RVA: 0x0101DF1F File Offset: 0x0101C11F
		protected override void OnToggleCancel()
		{
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			TuningStandModel.Instance.OnRelease(base.Data);
		}

		// Token: 0x060396F0 RID: 235248 RVA: 0x0101DF44 File Offset: 0x0101C144
		protected void InitLongPress()
		{
			this.LongPress = new LongPressButtonItem(null, new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), null);
			this.LongPress.Initialize(base.GetExtendToggle(9), null, new Action(this.OnTogglePress), new Action(this.OnToggleRelease), new Action(this.OnToggleCancel));
			base.GetExtendToggle(9).OnHover.Add(new Action(this.OnToggleHover));
			base.GetExtendToggle(9).OnUnHover.Add(new Action(this.OnToggleUnHover));
		}

		// Token: 0x060396F1 RID: 235249 RVA: 0x0101DFEA File Offset: 0x0101C1EA
		public override void PlayInAnim(float dist)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("In", true, new float?(dist / 10f + 1f));
		}

		// Token: 0x060396F2 RID: 235250 RVA: 0x0101E014 File Offset: 0x0101C214
		private void RefreshLine()
		{
			ETuningStandPrevDirect prevDirection = base.GetPrevDirection();
			this.LineLeft.Refresh(prevDirection == ETuningStandPrevDirect.Left, base.Data.GetCurGridState().State);
			this.LineRight.Refresh(prevDirection == ETuningStandPrevDirect.Right, base.Data.GetCurGridState().State);
			this.LineTop.Refresh(prevDirection == ETuningStandPrevDirect.Top, base.Data.GetCurGridState().State);
			this.LineBottom.Refresh(prevDirection == ETuningStandPrevDirect.Bottom, base.Data.GetCurGridState().State);
		}

		// Token: 0x060396F3 RID: 235251 RVA: 0x0101E0A4 File Offset: 0x0101C2A4
		private void ResetLine()
		{
			this.LineLeft.HideLine();
			this.LineRight.HideLine();
			this.LineTop.HideLine();
			this.LineBottom.HideLine();
		}

		// Token: 0x060396F4 RID: 235252 RVA: 0x0101E0D4 File Offset: 0x0101C2D4
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

		// Token: 0x060396F5 RID: 235253 RVA: 0x0101E134 File Offset: 0x0101C334
		public override void StartRevolving()
		{
			this.LineLeft.Refresh(false, base.Data.GetCurGridState().State);
			this.LineRight.Refresh(false, base.Data.GetCurGridState().State);
			this.LineTop.Refresh(false, base.Data.GetCurGridState().State);
			this.LineBottom.Refresh(false, base.Data.GetCurGridState().State);
		}

		// Token: 0x0401E4CB RID: 124107
		private LongPressButtonItem LongPress;

		// Token: 0x0401E4CC RID: 124108
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x0401E4CD RID: 124109
		private TuningStandGridLine LineLeft;

		// Token: 0x0401E4CE RID: 124110
		private TuningStandGridLine LineRight;

		// Token: 0x0401E4CF RID: 124111
		private TuningStandGridLine LineTop;

		// Token: 0x0401E4D0 RID: 124112
		private TuningStandGridLine LineBottom;
	}
}
