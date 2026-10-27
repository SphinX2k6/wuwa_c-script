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
	// Token: 0x02004B64 RID: 19300
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseSettleView : UiViewBase
	{
		// Token: 0x06031F7E RID: 204670 RVA: 0x00B98D76 File Offset: 0x00B96F76
		public TowerDefenseSettleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06031F7F RID: 204671 RVA: 0x00B98D8C File Offset: 0x00B96F8C
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

		// Token: 0x06031F80 RID: 204672 RVA: 0x00B98E59 File Offset: 0x00B97059
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FriendApplyReceived, new Action(this.OnRefreshFriendApply));
		}

		// Token: 0x06031F81 RID: 204673 RVA: 0x00B98E77 File Offset: 0x00B97077
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FriendApplyReceived, new Action(this.OnRefreshFriendApply));
		}

		// Token: 0x06031F82 RID: 204674 RVA: 0x00B98E98 File Offset: 0x00B97098
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseSettleView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseSettleView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031F83 RID: 204675 RVA: 0x00B98EDB File Offset: 0x00B970DB
		protected override void OnBeforeShow()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			TowerDefenceEndNotify notify = this.GetNotify();
			uiViewSequence.StartSequenceName = ((notify != null && notify.Success) ? "Success" : "Fail");
		}

		// Token: 0x06031F84 RID: 204676 RVA: 0x00B98F08 File Offset: 0x00B97108
		protected override void OnAfterShow()
		{
			this.OnRefreshFriendApply();
		}

		// Token: 0x06031F85 RID: 204677 RVA: 0x00B98F10 File Offset: 0x00B97110
		protected override void OnBeforeDestroy()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.FriendApplyView))
			{
				UiManager.Instance.CloseView(EUiViewName.FriendApplyView, null);
			}
		}

		// Token: 0x06031F86 RID: 204678 RVA: 0x00B98F34 File Offset: 0x00B97134
		private void OnRefreshFriendApply()
		{
			List<int> list = ItemRewardController.Instance.BuildExploreFriendIdList();
			if (FriendController.Instance.CheckHasAnyApplied(list.ToArray()) && !UiManager.Instance.IsViewOpen(EUiViewName.FriendApplyView))
			{
				UiManager.Instance.OpenView(EUiViewName.FriendApplyView, list, null);
			}
		}

		// Token: 0x06031F87 RID: 204679 RVA: 0x00B98F80 File Offset: 0x00B97180
		[NullableContext(2)]
		private TowerDefenceEndNotify GetNotify()
		{
			return this.OpenParam as TowerDefenceEndNotify;
		}

		// Token: 0x06031F88 RID: 204680 RVA: 0x00B98F90 File Offset: 0x00B97190
		private UniTask InitButtonsAsync()
		{
			TowerDefenseSettleView.<InitButtonsAsync>d__14 <InitButtonsAsync>d__;
			<InitButtonsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonsAsync>d__.<>4__this = this;
			<InitButtonsAsync>d__.<>1__state = -1;
			<InitButtonsAsync>d__.<>t__builder.Start<TowerDefenseSettleView.<InitButtonsAsync>d__14>(ref <InitButtonsAsync>d__);
			return <InitButtonsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031F89 RID: 204681 RVA: 0x00B98FD4 File Offset: 0x00B971D4
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

		// Token: 0x06031F8A RID: 204682 RVA: 0x00B99028 File Offset: 0x00B97228
		private UniTask InitRecordPanelAsync()
		{
			TowerDefenseSettleView.<InitRecordPanelAsync>d__16 <InitRecordPanelAsync>d__;
			<InitRecordPanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRecordPanelAsync>d__.<>4__this = this;
			<InitRecordPanelAsync>d__.<>1__state = -1;
			<InitRecordPanelAsync>d__.<>t__builder.Start<TowerDefenseSettleView.<InitRecordPanelAsync>d__16>(ref <InitRecordPanelAsync>d__);
			return <InitRecordPanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031F8B RID: 204683 RVA: 0x00B9906C File Offset: 0x00B9726C
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

		// Token: 0x06031F8C RID: 204684 RVA: 0x00B990D0 File Offset: 0x00B972D0
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

		// Token: 0x06031F8D RID: 204685 RVA: 0x00B99144 File Offset: 0x00B97344
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

		// Token: 0x06031F8E RID: 204686 RVA: 0x00B99258 File Offset: 0x00B97458
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

		// Token: 0x06031F8F RID: 204687 RVA: 0x00B992F3 File Offset: 0x00B974F3
		private void OnExitBtnClick()
		{
			TowerDefenseController.Instance.RequestChallengeQuit();
		}

		// Token: 0x06031F90 RID: 204688 RVA: 0x00B992FF File Offset: 0x00B974FF
		private void OnRestartBtnClick()
		{
			TowerDefenseController.Instance.HandleSettleViewRestart(0);
		}

		// Token: 0x0401AA40 RID: 109120
		private const string SUCCESS_OUTLINE_COLOR = "C48B29FF";

		// Token: 0x0401AA41 RID: 109121
		private const string SUCCESS_TEXT_COLOR = "f2efd5";

		// Token: 0x0401AA42 RID: 109122
		private readonly Dictionary<int, TowerDefenseSettleButton> ButtonMap = new Dictionary<int, TowerDefenseSettleButton>();

		// Token: 0x0401AA43 RID: 109123
		[Nullable(2)]
		private TowerDefenseSettleRecordPanel RecordPanel;

		// Token: 0x0200ACF5 RID: 44277
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040348D9 RID: 215257
			public const int TitleText = 1;

			// Token: 0x040348DA RID: 215258
			public const int TitleTexture = 2;

			// Token: 0x040348DB RID: 215259
			public const int ButtonHorizontalItem = 4;

			// Token: 0x040348DC RID: 215260
			public const int ButtonItem = 5;

			// Token: 0x040348DD RID: 215261
			public const int ContentItem = 20;
		}

		// Token: 0x0200ACF6 RID: 44278
		[NullableContext(0)]
		private class EButton
		{
			// Token: 0x040348DE RID: 215262
			public const int Exit = 0;

			// Token: 0x040348DF RID: 215263
			public const int Restart = 1;
		}
	}
}
