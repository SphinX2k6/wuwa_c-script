using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003B0C RID: 15116
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseSettleView : UiViewBase
	{
		// Token: 0x06026D0D RID: 158989 RVA: 0x00ADCFB2 File Offset: 0x00ADB1B2
		public TowerDefenseSettleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06026D0E RID: 158990 RVA: 0x00ADCFC8 File Offset: 0x00ADB1C8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06026D0F RID: 158991 RVA: 0x00ADD095 File Offset: 0x00ADB295
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FriendApplyReceived, new Action(this.OnRefreshFriendApply));
		}

		// Token: 0x06026D10 RID: 158992 RVA: 0x00ADD0B3 File Offset: 0x00ADB2B3
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FriendApplyReceived, new Action(this.OnRefreshFriendApply));
		}

		// Token: 0x06026D11 RID: 158993 RVA: 0x00ADD0D4 File Offset: 0x00ADB2D4
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseSettleView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseSettleView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026D12 RID: 158994 RVA: 0x00ADD117 File Offset: 0x00ADB317
		protected override void OnBeforeShow()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			TowerDefenceEndNotify notify = this.GetNotify();
			uiViewSequence.StartSequenceName = ((notify != null && notify.Success) ? "Success" : "Fail");
		}

		// Token: 0x06026D13 RID: 158995 RVA: 0x00ADD144 File Offset: 0x00ADB344
		protected override void OnAfterShow()
		{
			this.OnRefreshFriendApply();
		}

		// Token: 0x06026D14 RID: 158996 RVA: 0x00ADD14C File Offset: 0x00ADB34C
		protected override void OnBeforeDestroy()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.FriendApplyView))
			{
				UiManager.Instance.CloseView(EUiViewName.FriendApplyView, null);
			}
		}

		// Token: 0x06026D15 RID: 158997 RVA: 0x00ADD170 File Offset: 0x00ADB370
		private void OnRefreshFriendApply()
		{
			List<int> list = ItemRewardController.Instance.BuildExploreFriendIdList();
			if (FriendController.Instance.CheckHasAnyApplied(list.ToArray()) && !UiManager.Instance.IsViewOpen(EUiViewName.FriendApplyView))
			{
				UiManager.Instance.OpenView(EUiViewName.FriendApplyView, list, null);
			}
		}

		// Token: 0x06026D16 RID: 158998 RVA: 0x00ADD1BC File Offset: 0x00ADB3BC
		[NullableContext(2)]
		private TowerDefenceEndNotify GetNotify()
		{
			return this.OpenParam as TowerDefenceEndNotify;
		}

		// Token: 0x06026D17 RID: 158999 RVA: 0x00ADD1CC File Offset: 0x00ADB3CC
		private UniTask InitButtonsAsync()
		{
			TowerDefenseSettleView.<InitButtonsAsync>d__14 <InitButtonsAsync>d__;
			<InitButtonsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonsAsync>d__.<>4__this = this;
			<InitButtonsAsync>d__.<>1__state = -1;
			<InitButtonsAsync>d__.<>t__builder.Start<TowerDefenseSettleView.<InitButtonsAsync>d__14>(ref <InitButtonsAsync>d__);
			return <InitButtonsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026D18 RID: 159000 RVA: 0x00ADD210 File Offset: 0x00ADB410
		private UniTask CreateButtonAsync(int index, Action onClick)
		{
			TowerDefenseSettleView.<CreateButtonAsync>d__15 <CreateButtonAsync>d__;
			<CreateButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateButtonAsync>d__.<>4__this = this;
			<CreateButtonAsync>d__.index = index;
			<CreateButtonAsync>d__.onClick = onClick;
			<CreateButtonAsync>d__.<>1__state = -1;
			<CreateButtonAsync>d__.<>t__builder.Start<TowerDefenseSettleView.<CreateButtonAsync>d__15>(ref <CreateButtonAsync>d__);
			return <CreateButtonAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026D19 RID: 159001 RVA: 0x00ADD264 File Offset: 0x00ADB464
		private UniTask InitRecordPanelAsync()
		{
			TowerDefenseSettleView.<InitRecordPanelAsync>d__16 <InitRecordPanelAsync>d__;
			<InitRecordPanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRecordPanelAsync>d__.<>4__this = this;
			<InitRecordPanelAsync>d__.<>1__state = -1;
			<InitRecordPanelAsync>d__.<>t__builder.Start<TowerDefenseSettleView.<InitRecordPanelAsync>d__16>(ref <InitRecordPanelAsync>d__);
			return <InitRecordPanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026D1A RID: 159002 RVA: 0x00ADD2A8 File Offset: 0x00ADB4A8
		private void RefreshTitle()
		{
			TowerDefenceEndNotify notify = this.GetNotify();
			UUIText text = base.GetText(1);
			if (notify == null)
			{
				text.SetText("", true);
				return;
			}
			string textStringId = notify.Success ? "Text_ChallengeSuccess_Text" : "TowerDefenceSettlement01";
			LguiUtil.Instance.SetLocalTextNew(text, textStringId, Array.Empty<object>());
			if (notify.Success)
			{
				this.ApplySuccessTitleStyle(text);
			}
		}

		// Token: 0x06026D1B RID: 159003 RVA: 0x00ADD30C File Offset: 0x00ADB50C
		private void ApplySuccessTitleStyle(UUIText titleText)
		{
			UUIEffectOutline uuieffectOutline = titleText.GetOwner().GetComponentByClass(UUIEffectOutline.StaticClass()) as UUIEffectOutline;
			titleText.outlineColor = FColor.FromHex("C48B29FF");
			base.GetTexture(2).SetColor(FColor.FromHex("8C754D7F"));
			if (uuieffectOutline != null)
			{
				uuieffectOutline.SetOutlineColor(FColor.FromHex("C48B29FF"));
			}
			titleText.SetColor(FColor.FromHex("f2efd5"));
		}

		// Token: 0x06026D1C RID: 159004 RVA: 0x00ADD380 File Offset: 0x00ADB580
		private void RefreshRecordPanel()
		{
			TowerDefenceEndNotify notify = this.GetNotify();
			if (notify == null || this.RecordPanel == null)
			{
				return;
			}
			TowerDefenceInstance? config = ConfigTowerDefenceInstanceById.GetConfig(notify.InstId, true);
			bool flag = config != null && config.Value.IsDifficult;
			if (!notify.Success && flag)
			{
				this.RecordPanel.SetTitleOnly("TowerDefencelose");
				return;
			}
			this.RecordPanel.SetTitleById(flag ? "PrefabTextItem_3771425333_Text" : "PrefabTextItem_1350027209_Text");
			if (notify.Success && flag)
			{
				bool isNewRecord = notify.PassTime != 0 && notify.MinPassTime > notify.PassTime;
				this.RecordPanel.SetRecord(TimeUtil.Instance.GetTimeString((double)notify.PassTime), isNewRecord);
				return;
			}
			if (notify.Success && !flag)
			{
				bool isNewRecord2 = notify.Score > notify.MaxScore && notify.Score != 0;
				this.RecordPanel.SetRecordRolling(notify.Score, isNewRecord2);
				return;
			}
			this.RecordPanel.SetRecordRolling(notify.Score, false);
		}

		// Token: 0x06026D1D RID: 159005 RVA: 0x00ADD494 File Offset: 0x00ADB694
		private void RefreshHighestScore()
		{
			TowerDefenceEndNotify notify = this.GetNotify();
			TowerDefenseSettleButton towerDefenseSettleButton;
			if (notify == null || !this.ButtonMap.TryGetValue(1, out towerDefenseSettleButton))
			{
				return;
			}
			TowerDefenceInstance? config = ConfigTowerDefenceInstanceById.GetConfig(notify.InstId, true);
			if (config != null && config.Value.IsDifficult)
			{
				towerDefenseSettleButton.SetFloatText("TowerDefenceBestTime", new string[]
				{
					TimeUtil.Instance.GetTimeString((double)notify.MinPassTime)
				});
				return;
			}
			towerDefenseSettleButton.SetFloatText("TowerDefence_GPint", new string[]
			{
				notify.MaxScore.ToString()
			});
		}

		// Token: 0x06026D1E RID: 159006 RVA: 0x00ADD52F File Offset: 0x00ADB72F
		private void OnExitBtnClick()
		{
			TowerDefenseController.Instance.RequestChallengeQuit();
		}

		// Token: 0x06026D1F RID: 159007 RVA: 0x00ADD53B File Offset: 0x00ADB73B
		private void OnRestartBtnClick()
		{
			TowerDefenseController.Instance.HandleSettleViewRestart(0);
		}

		// Token: 0x04015392 RID: 86930
		private const string SUCCESS_OUTLINE_COLOR = "C48B29FF";

		// Token: 0x04015393 RID: 86931
		private const string SUCCESS_TEXT_COLOR = "f2efd5";

		// Token: 0x04015394 RID: 86932
		private readonly Dictionary<int, TowerDefenseSettleButton> ButtonMap = new Dictionary<int, TowerDefenseSettleButton>();

		// Token: 0x04015395 RID: 86933
		[Nullable(2)]
		private TowerDefenseSettleRecordPanel RecordPanel;

		// Token: 0x02009714 RID: 38676
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0402F282 RID: 193154
			public const int TitleText = 1;

			// Token: 0x0402F283 RID: 193155
			public const int TitleTexture = 2;

			// Token: 0x0402F284 RID: 193156
			public const int ButtonHorizontalItem = 4;

			// Token: 0x0402F285 RID: 193157
			public const int ButtonItem = 5;

			// Token: 0x0402F286 RID: 193158
			public const int ContentItem = 20;
		}

		// Token: 0x02009715 RID: 38677
		[NullableContext(0)]
		private class EButton
		{
			// Token: 0x0402F287 RID: 193159
			public const int Exit = 0;

			// Token: 0x0402F288 RID: 193160
			public const int Restart = 1;
		}
	}
}
