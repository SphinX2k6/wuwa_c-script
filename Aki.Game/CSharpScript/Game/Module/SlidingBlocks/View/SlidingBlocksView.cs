using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.SlidingBlocks.View.Control;
using CSharpScript.Game.Module.SlidingBlocks.View.Mission;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks.View
{
	// Token: 0x02004B97 RID: 19351
	[NullableContext(2)]
	[Nullable(0)]
	public class SlidingBlocksView : UiTickViewBase, IUiProhibitRefreshData
	{
		// Token: 0x0603223D RID: 205373 RVA: 0x00BA5FBE File Offset: 0x00BA41BE
		[NullableContext(1)]
		public SlidingBlocksView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603223E RID: 205374 RVA: 0x00BA5FC8 File Offset: 0x00BA41C8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603223F RID: 205375 RVA: 0x00BA61A4 File Offset: 0x00BA43A4
		protected override UniTask OnBeforeStartAsync()
		{
			SlidingBlocksView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SlidingBlocksView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032240 RID: 205376 RVA: 0x00BA61E8 File Offset: 0x00BA43E8
		private UniTask InitControlItem()
		{
			SlidingBlocksView.<InitControlItem>d__13 <InitControlItem>d__;
			<InitControlItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitControlItem>d__.<>4__this = this;
			<InitControlItem>d__.<>1__state = -1;
			<InitControlItem>d__.<>t__builder.Start<SlidingBlocksView.<InitControlItem>d__13>(ref <InitControlItem>d__);
			return <InitControlItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032241 RID: 205377 RVA: 0x00BA622C File Offset: 0x00BA442C
		private UniTask InitPrepareCountDownItem()
		{
			SlidingBlocksView.<InitPrepareCountDownItem>d__14 <InitPrepareCountDownItem>d__;
			<InitPrepareCountDownItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPrepareCountDownItem>d__.<>4__this = this;
			<InitPrepareCountDownItem>d__.<>1__state = -1;
			<InitPrepareCountDownItem>d__.<>t__builder.Start<SlidingBlocksView.<InitPrepareCountDownItem>d__14>(ref <InitPrepareCountDownItem>d__);
			return <InitPrepareCountDownItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032242 RID: 205378 RVA: 0x00BA6270 File Offset: 0x00BA4470
		private UniTask InitMissionItem()
		{
			SlidingBlocksView.<InitMissionItem>d__15 <InitMissionItem>d__;
			<InitMissionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMissionItem>d__.<>4__this = this;
			<InitMissionItem>d__.<>1__state = -1;
			<InitMissionItem>d__.<>t__builder.Start<SlidingBlocksView.<InitMissionItem>d__15>(ref <InitMissionItem>d__);
			return <InitMissionItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032243 RID: 205379 RVA: 0x00BA62B4 File Offset: 0x00BA44B4
		private UniTask InitNextTetrominoItem()
		{
			SlidingBlocksView.<InitNextTetrominoItem>d__16 <InitNextTetrominoItem>d__;
			<InitNextTetrominoItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitNextTetrominoItem>d__.<>4__this = this;
			<InitNextTetrominoItem>d__.<>1__state = -1;
			<InitNextTetrominoItem>d__.<>t__builder.Start<SlidingBlocksView.<InitNextTetrominoItem>d__16>(ref <InitNextTetrominoItem>d__);
			return <InitNextTetrominoItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032244 RID: 205380 RVA: 0x00BA62F8 File Offset: 0x00BA44F8
		private UniTask InitCaptionItem()
		{
			SlidingBlocksView.<InitCaptionItem>d__17 <InitCaptionItem>d__;
			<InitCaptionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaptionItem>d__.<>4__this = this;
			<InitCaptionItem>d__.<>1__state = -1;
			<InitCaptionItem>d__.<>t__builder.Start<SlidingBlocksView.<InitCaptionItem>d__17>(ref <InitCaptionItem>d__);
			return <InitCaptionItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032245 RID: 205381 RVA: 0x00BA633C File Offset: 0x00BA453C
		private UniTask InitEndlessSpeedUpTips()
		{
			SlidingBlocksView.<InitEndlessSpeedUpTips>d__18 <InitEndlessSpeedUpTips>d__;
			<InitEndlessSpeedUpTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitEndlessSpeedUpTips>d__.<>4__this = this;
			<InitEndlessSpeedUpTips>d__.<>1__state = -1;
			<InitEndlessSpeedUpTips>d__.<>t__builder.Start<SlidingBlocksView.<InitEndlessSpeedUpTips>d__18>(ref <InitEndlessSpeedUpTips>d__);
			return <InitEndlessSpeedUpTips>d__.<>t__builder.Task;
		}

		// Token: 0x06032246 RID: 205382 RVA: 0x00BA637F File Offset: 0x00BA457F
		protected override void OnStart()
		{
			this.RegisterExtraUiProhibitRefresh();
			this.EnableInput(false);
		}

		// Token: 0x06032247 RID: 205383 RVA: 0x00BA6390 File Offset: 0x00BA4590
		protected override void OnAfterShow()
		{
			ControlItem controlItem = this.ControlItem;
			if (controlItem != null)
			{
				controlItem.Show(null);
			}
			NextTetrominoItem nextTetrominoItem = this.NextTetrominoItem;
			if (nextTetrominoItem != null)
			{
				nextTetrominoItem.Show(null);
			}
			MissionItem missionItem = this.MissionItem;
			if (missionItem != null)
			{
				missionItem.Show(null);
			}
			CaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.Show(null);
			}
			if (SlidingBlocksModel.Instance.GameData.PlayMode != ETetrisPlayMode.MainLine)
			{
				BattleUiModel.Instance.ChildViewData.AddBattleUiCommonChildVisibleReason(EBattleUiCommonChildVisibleReason.SurvivorsRogue);
				EventSystem.Instance.Emit(EEventName.ActiveBattleView);
			}
			if (this.MissionViewItems != null)
			{
				foreach (MissionViewItem missionViewItem in this.MissionViewItems)
				{
					missionViewItem.OnPanelShow();
				}
			}
		}

		// Token: 0x06032248 RID: 205384 RVA: 0x00BA6464 File Offset: 0x00BA4664
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SlidingBlockEndlessSpeedLevel, new Action(this.OnEndlessSpeedUp));
		}

		// Token: 0x06032249 RID: 205385 RVA: 0x00BA6482 File Offset: 0x00BA4682
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SlidingBlockEndlessSpeedLevel, new Action(this.OnEndlessSpeedUp));
		}

		// Token: 0x0603224A RID: 205386 RVA: 0x00BA64A0 File Offset: 0x00BA46A0
		protected override void OnAfterHide()
		{
			if (SlidingBlocksModel.Instance.GameData.PlayMode != ETetrisPlayMode.MainLine)
			{
				BattleUiModel.Instance.ChildViewData.RemoveBattleUiCommonChildVisibleReason(EBattleUiCommonChildVisibleReason.SurvivorsRogue);
			}
			if (this.MissionViewItems != null)
			{
				foreach (MissionViewItem missionViewItem in this.MissionViewItems)
				{
					missionViewItem.OnPanelHide();
				}
			}
		}

		// Token: 0x0603224B RID: 205387 RVA: 0x00BA651C File Offset: 0x00BA471C
		protected override void OnBeforeDestroy()
		{
			this.EnableInput(true);
			this.UnRegisterExtraUiProhibitRefresh();
			ControlItem controlItem = this.ControlItem;
			if (controlItem != null)
			{
				controlItem.Destroy(null);
			}
			PrepareCountDownItem prepareCountDownItem = this.PrepareCountDownItem;
			if (prepareCountDownItem != null)
			{
				prepareCountDownItem.Destroy(null);
			}
			NextTetrominoItem nextTetrominoItem = this.NextTetrominoItem;
			if (nextTetrominoItem != null)
			{
				nextTetrominoItem.Destroy(null);
			}
			MissionItem missionItem = this.MissionItem;
			if (missionItem != null)
			{
				missionItem.Destroy(null);
			}
			CaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.Destroy(null);
			}
			if (this.MissionViewItems != null)
			{
				foreach (MissionViewItem missionViewItem in this.MissionViewItems)
				{
					missionViewItem.Destroy(null);
				}
			}
		}

		// Token: 0x0603224C RID: 205388 RVA: 0x00BA65DC File Offset: 0x00BA47DC
		protected override void OnTick(float delta)
		{
			this.UpdateGameTime();
			ControlItem controlItem = this.ControlItem;
			if (controlItem != null)
			{
				controlItem.OnTick(delta);
			}
			PrepareCountDownItem prepareCountDownItem = this.PrepareCountDownItem;
			if (prepareCountDownItem != null)
			{
				prepareCountDownItem.OnTick(delta);
			}
			NextTetrominoItem nextTetrominoItem = this.NextTetrominoItem;
			if (nextTetrominoItem != null)
			{
				nextTetrominoItem.OnTick(delta);
			}
			MissionItem missionItem = this.MissionItem;
			if (missionItem != null)
			{
				missionItem.OnTick(delta);
			}
			if (this.MissionViewItems != null)
			{
				foreach (MissionViewItem missionViewItem in this.MissionViewItems)
				{
					missionViewItem.OnRefresh(delta, 0);
				}
			}
			SlidingBlocksGameData gameData = SlidingBlocksModel.Instance.GameData;
			base.GetText(9).SetText(gameData.SpeedLevel.ToString(), true);
			base.GetText(7).SetText(gameData.Score.ToString(), true);
		}

		// Token: 0x0603224D RID: 205389 RVA: 0x00BA66C0 File Offset: 0x00BA48C0
		private void UpdateGameTime()
		{
			UUIText text = base.GetText(5);
			if (!text.IsUIActiveInHierarchy())
			{
				return;
			}
			double time = SlidingBlocksModel.Instance.GameData.Time;
			int num = (int)Math.Floor(time % TimeUtil.Instance.Hour / TimeUtil.Instance.Minute);
			int num2 = (int)Math.Floor(time % TimeUtil.Instance.Minute);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted((num < 10) ? "0" : "");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			string str = defaultInterpolatedStringHandler.ToStringAndClear();
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted((num2 < 10) ? "0" : "");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
			string str2 = defaultInterpolatedStringHandler.ToStringAndClear();
			text.SetText(str + ":" + str2, true);
		}

		// Token: 0x0603224E RID: 205390 RVA: 0x00BA6794 File Offset: 0x00BA4994
		public bool CheckCondition()
		{
			return true;
		}

		// Token: 0x0603224F RID: 205391 RVA: 0x00BA6797 File Offset: 0x00BA4997
		[NullableContext(1)]
		public string[] GetDistributeTags()
		{
			return new string[]
			{
				"FightInputRoot.FightInput.ActionInput",
				"FightInputRoot.FightInput.AxisInput.MoveInput",
				"UiInputRoot"
			};
		}

		// Token: 0x06032250 RID: 205392 RVA: 0x00BA67B7 File Offset: 0x00BA49B7
		private void RegisterExtraUiProhibitRefresh()
		{
			UiProhibitFightInputCenter.Instance.RegisterExtraRefreshData(this.ViewInfo.Name, this);
		}

		// Token: 0x06032251 RID: 205393 RVA: 0x00BA67D4 File Offset: 0x00BA49D4
		private void UnRegisterExtraUiProhibitRefresh()
		{
			UiProhibitFightInputCenter.Instance.UnRegisterExtraRefreshData(this.ViewInfo.Name);
		}

		// Token: 0x06032252 RID: 205394 RVA: 0x00BA67F0 File Offset: 0x00BA49F0
		private void EnableInput(bool enable)
		{
			int num = (int)EInputAction.MaxCount;
			for (int i = 0; i < num; i++)
			{
				if (i != (int)EInputAction.跳跃 && i != (int)EInputAction.攀爬 && i != (int)EInputAction.闪避)
				{
					BattleInputModel.Instance.SetInputEnable((EInputAction)((byte)i), enable, EBattleInputReason.TetrisGame);
				}
			}
		}

		// Token: 0x06032253 RID: 205395 RVA: 0x00BA684E File Offset: 0x00BA4A4E
		private void OnEndlessSpeedUp()
		{
			this.ShowSpeedUpAnim().Forget();
		}

		// Token: 0x06032254 RID: 205396 RVA: 0x00BA685C File Offset: 0x00BA4A5C
		private UniTask ShowSpeedUpAnim()
		{
			SlidingBlocksView.<ShowSpeedUpAnim>d__33 <ShowSpeedUpAnim>d__;
			<ShowSpeedUpAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowSpeedUpAnim>d__.<>4__this = this;
			<ShowSpeedUpAnim>d__.<>1__state = -1;
			<ShowSpeedUpAnim>d__.<>t__builder.Start<SlidingBlocksView.<ShowSpeedUpAnim>d__33>(ref <ShowSpeedUpAnim>d__);
			return <ShowSpeedUpAnim>d__.<>t__builder.Task;
		}

		// Token: 0x0401AB58 RID: 109400
		private ControlItem ControlItem;

		// Token: 0x0401AB59 RID: 109401
		private PrepareCountDownItem PrepareCountDownItem;

		// Token: 0x0401AB5A RID: 109402
		private NextTetrominoItem NextTetrominoItem;

		// Token: 0x0401AB5B RID: 109403
		private CaptionItem CaptionItem;

		// Token: 0x0401AB5C RID: 109404
		private MissionItem MissionItem;

		// Token: 0x0401AB5D RID: 109405
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<MissionViewItem> MissionViewItems;

		// Token: 0x0401AB5E RID: 109406
		private EndlessSpeedUpTips EndlessSpeedUpTips;

		// Token: 0x0401AB5F RID: 109407
		private bool IsMobile;

		// Token: 0x0401AB60 RID: 109408
		[Nullable(1)]
		private CustomPromise<UniTaskVoid> WaitLevelPlayTrackPromise;

		// Token: 0x0200ADAB RID: 44459
		[NullableContext(0)]
		private class EViewComponent
		{
			// Token: 0x04034BEF RID: 216047
			public const int CaptionItem = 0;

			// Token: 0x04034BF0 RID: 216048
			public const int ContentItem = 1;

			// Token: 0x04034BF1 RID: 216049
			public const int MissionItem = 2;

			// Token: 0x04034BF2 RID: 216050
			public const int NextTetrominoItem = 3;

			// Token: 0x04034BF3 RID: 216051
			public const int TimeRootItem = 4;

			// Token: 0x04034BF4 RID: 216052
			public const int TimeText = 5;

			// Token: 0x04034BF5 RID: 216053
			public const int ScoreRootItem = 6;

			// Token: 0x04034BF6 RID: 216054
			public const int ScoreText = 7;

			// Token: 0x04034BF7 RID: 216055
			public const int SpeedRootItem = 8;

			// Token: 0x04034BF8 RID: 216056
			public const int SpeedText = 9;

			// Token: 0x04034BF9 RID: 216057
			public const int SpriteUp = 10;

			// Token: 0x04034BFA RID: 216058
			public const int PanelTips = 11;

			// Token: 0x04034BFB RID: 216059
			public const int BgTexture = 12;
		}
	}
}
