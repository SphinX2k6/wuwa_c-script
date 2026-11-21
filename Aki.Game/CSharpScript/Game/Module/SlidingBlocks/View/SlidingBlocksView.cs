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
	// Token: 0x02003B41 RID: 15169
	[NullableContext(2)]
	[Nullable(0)]
	public class SlidingBlocksView : UiTickViewBase, IUiProhibitRefreshData
	{
		// Token: 0x06026FCD RID: 159693 RVA: 0x00AEA10B File Offset: 0x00AE830B
		[NullableContext(1)]
		public SlidingBlocksView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06026FCE RID: 159694 RVA: 0x00AEA114 File Offset: 0x00AE8314
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

		// Token: 0x06026FCF RID: 159695 RVA: 0x00AEA2F0 File Offset: 0x00AE84F0
		protected override UniTask OnBeforeStartAsync()
		{
			SlidingBlocksView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SlidingBlocksView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026FD0 RID: 159696 RVA: 0x00AEA334 File Offset: 0x00AE8534
		private UniTask InitControlItem()
		{
			SlidingBlocksView.<InitControlItem>d__13 <InitControlItem>d__;
			<InitControlItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitControlItem>d__.<>4__this = this;
			<InitControlItem>d__.<>1__state = -1;
			<InitControlItem>d__.<>t__builder.Start<SlidingBlocksView.<InitControlItem>d__13>(ref <InitControlItem>d__);
			return <InitControlItem>d__.<>t__builder.Task;
		}

		// Token: 0x06026FD1 RID: 159697 RVA: 0x00AEA378 File Offset: 0x00AE8578
		private UniTask InitPrepareCountDownItem()
		{
			SlidingBlocksView.<InitPrepareCountDownItem>d__14 <InitPrepareCountDownItem>d__;
			<InitPrepareCountDownItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPrepareCountDownItem>d__.<>4__this = this;
			<InitPrepareCountDownItem>d__.<>1__state = -1;
			<InitPrepareCountDownItem>d__.<>t__builder.Start<SlidingBlocksView.<InitPrepareCountDownItem>d__14>(ref <InitPrepareCountDownItem>d__);
			return <InitPrepareCountDownItem>d__.<>t__builder.Task;
		}

		// Token: 0x06026FD2 RID: 159698 RVA: 0x00AEA3BC File Offset: 0x00AE85BC
		private UniTask InitMissionItem()
		{
			SlidingBlocksView.<InitMissionItem>d__15 <InitMissionItem>d__;
			<InitMissionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMissionItem>d__.<>4__this = this;
			<InitMissionItem>d__.<>1__state = -1;
			<InitMissionItem>d__.<>t__builder.Start<SlidingBlocksView.<InitMissionItem>d__15>(ref <InitMissionItem>d__);
			return <InitMissionItem>d__.<>t__builder.Task;
		}

		// Token: 0x06026FD3 RID: 159699 RVA: 0x00AEA400 File Offset: 0x00AE8600
		private UniTask InitNextTetrominoItem()
		{
			SlidingBlocksView.<InitNextTetrominoItem>d__16 <InitNextTetrominoItem>d__;
			<InitNextTetrominoItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitNextTetrominoItem>d__.<>4__this = this;
			<InitNextTetrominoItem>d__.<>1__state = -1;
			<InitNextTetrominoItem>d__.<>t__builder.Start<SlidingBlocksView.<InitNextTetrominoItem>d__16>(ref <InitNextTetrominoItem>d__);
			return <InitNextTetrominoItem>d__.<>t__builder.Task;
		}

		// Token: 0x06026FD4 RID: 159700 RVA: 0x00AEA444 File Offset: 0x00AE8644
		private UniTask InitCaptionItem()
		{
			SlidingBlocksView.<InitCaptionItem>d__17 <InitCaptionItem>d__;
			<InitCaptionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaptionItem>d__.<>4__this = this;
			<InitCaptionItem>d__.<>1__state = -1;
			<InitCaptionItem>d__.<>t__builder.Start<SlidingBlocksView.<InitCaptionItem>d__17>(ref <InitCaptionItem>d__);
			return <InitCaptionItem>d__.<>t__builder.Task;
		}

		// Token: 0x06026FD5 RID: 159701 RVA: 0x00AEA488 File Offset: 0x00AE8688
		private UniTask InitEndlessSpeedUpTips()
		{
			SlidingBlocksView.<InitEndlessSpeedUpTips>d__18 <InitEndlessSpeedUpTips>d__;
			<InitEndlessSpeedUpTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitEndlessSpeedUpTips>d__.<>4__this = this;
			<InitEndlessSpeedUpTips>d__.<>1__state = -1;
			<InitEndlessSpeedUpTips>d__.<>t__builder.Start<SlidingBlocksView.<InitEndlessSpeedUpTips>d__18>(ref <InitEndlessSpeedUpTips>d__);
			return <InitEndlessSpeedUpTips>d__.<>t__builder.Task;
		}

		// Token: 0x06026FD6 RID: 159702 RVA: 0x00AEA4CB File Offset: 0x00AE86CB
		protected override void OnStart()
		{
			this.RegisterExtraUiProhibitRefresh();
			this.EnableInput(false);
		}

		// Token: 0x06026FD7 RID: 159703 RVA: 0x00AEA4DC File Offset: 0x00AE86DC
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

		// Token: 0x06026FD8 RID: 159704 RVA: 0x00AEA5B0 File Offset: 0x00AE87B0
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SlidingBlockEndlessSpeedLevel, new Action(this.OnEndlessSpeedUp));
		}

		// Token: 0x06026FD9 RID: 159705 RVA: 0x00AEA5CE File Offset: 0x00AE87CE
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SlidingBlockEndlessSpeedLevel, new Action(this.OnEndlessSpeedUp));
		}

		// Token: 0x06026FDA RID: 159706 RVA: 0x00AEA5EC File Offset: 0x00AE87EC
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

		// Token: 0x06026FDB RID: 159707 RVA: 0x00AEA668 File Offset: 0x00AE8868
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

		// Token: 0x06026FDC RID: 159708 RVA: 0x00AEA728 File Offset: 0x00AE8928
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

		// Token: 0x06026FDD RID: 159709 RVA: 0x00AEA80C File Offset: 0x00AE8A0C
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

		// Token: 0x06026FDE RID: 159710 RVA: 0x00AEA8E0 File Offset: 0x00AE8AE0
		public bool CheckCondition()
		{
			return true;
		}

		// Token: 0x06026FDF RID: 159711 RVA: 0x00AEA8E3 File Offset: 0x00AE8AE3
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

		// Token: 0x06026FE0 RID: 159712 RVA: 0x00AEA903 File Offset: 0x00AE8B03
		private void RegisterExtraUiProhibitRefresh()
		{
			UiProhibitFightInputCenter.Instance.RegisterExtraRefreshData(this.ViewInfo.Name, this);
		}

		// Token: 0x06026FE1 RID: 159713 RVA: 0x00AEA920 File Offset: 0x00AE8B20
		private void UnRegisterExtraUiProhibitRefresh()
		{
			UiProhibitFightInputCenter.Instance.UnRegisterExtraRefreshData(this.ViewInfo.Name);
		}

		// Token: 0x06026FE2 RID: 159714 RVA: 0x00AEA93C File Offset: 0x00AE8B3C
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

		// Token: 0x06026FE3 RID: 159715 RVA: 0x00AEA99A File Offset: 0x00AE8B9A
		private void OnEndlessSpeedUp()
		{
			this.ShowSpeedUpAnim().Forget();
		}

		// Token: 0x06026FE4 RID: 159716 RVA: 0x00AEA9A8 File Offset: 0x00AE8BA8
		private UniTask ShowSpeedUpAnim()
		{
			SlidingBlocksView.<ShowSpeedUpAnim>d__33 <ShowSpeedUpAnim>d__;
			<ShowSpeedUpAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowSpeedUpAnim>d__.<>4__this = this;
			<ShowSpeedUpAnim>d__.<>1__state = -1;
			<ShowSpeedUpAnim>d__.<>t__builder.Start<SlidingBlocksView.<ShowSpeedUpAnim>d__33>(ref <ShowSpeedUpAnim>d__);
			return <ShowSpeedUpAnim>d__.<>t__builder.Task;
		}

		// Token: 0x040154AC RID: 87212
		private ControlItem ControlItem;

		// Token: 0x040154AD RID: 87213
		private PrepareCountDownItem PrepareCountDownItem;

		// Token: 0x040154AE RID: 87214
		private NextTetrominoItem NextTetrominoItem;

		// Token: 0x040154AF RID: 87215
		private CaptionItem CaptionItem;

		// Token: 0x040154B0 RID: 87216
		private MissionItem MissionItem;

		// Token: 0x040154B1 RID: 87217
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<MissionViewItem> MissionViewItems;

		// Token: 0x040154B2 RID: 87218
		private EndlessSpeedUpTips EndlessSpeedUpTips;

		// Token: 0x040154B3 RID: 87219
		private bool IsMobile;

		// Token: 0x040154B4 RID: 87220
		[Nullable(1)]
		private CustomPromise<UniTaskVoid> WaitLevelPlayTrackPromise;

		// Token: 0x020097CA RID: 38858
		[NullableContext(0)]
		private class EViewComponent
		{
			// Token: 0x0402F596 RID: 193942
			public const int CaptionItem = 0;

			// Token: 0x0402F597 RID: 193943
			public const int ContentItem = 1;

			// Token: 0x0402F598 RID: 193944
			public const int MissionItem = 2;

			// Token: 0x0402F599 RID: 193945
			public const int NextTetrominoItem = 3;

			// Token: 0x0402F59A RID: 193946
			public const int TimeRootItem = 4;

			// Token: 0x0402F59B RID: 193947
			public const int TimeText = 5;

			// Token: 0x0402F59C RID: 193948
			public const int ScoreRootItem = 6;

			// Token: 0x0402F59D RID: 193949
			public const int ScoreText = 7;

			// Token: 0x0402F59E RID: 193950
			public const int SpeedRootItem = 8;

			// Token: 0x0402F59F RID: 193951
			public const int SpeedText = 9;

			// Token: 0x0402F5A0 RID: 193952
			public const int SpriteUp = 10;

			// Token: 0x0402F5A1 RID: 193953
			public const int PanelTips = 11;

			// Token: 0x0402F5A2 RID: 193954
			public const int BgTexture = 12;
		}
	}
}
