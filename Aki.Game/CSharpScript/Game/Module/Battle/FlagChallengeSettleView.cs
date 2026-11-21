using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.FlagChallenge;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C20 RID: 19488
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeSettleView : UiViewBase
	{
		// Token: 0x060309D3 RID: 199123 RVA: 0x00D8D0FE File Offset: 0x00D8B2FE
		public FlagChallengeSettleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060309D4 RID: 199124 RVA: 0x00D8D108 File Offset: 0x00D8B308
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
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

		// Token: 0x060309D5 RID: 199125 RVA: 0x00D8D1F8 File Offset: 0x00D8B3F8
		protected override UniTask OnBeforeStartAsync()
		{
			FlagChallengeSettleView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FlagChallengeSettleView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060309D6 RID: 199126 RVA: 0x00D8D23B File Offset: 0x00D8B43B
		protected override void OnBeforeShow()
		{
			this.StartAutoLeaveTimer();
			this.TryPlaySequence();
		}

		// Token: 0x060309D7 RID: 199127 RVA: 0x00D8D249 File Offset: 0x00D8B449
		protected override void OnBeforeHide()
		{
			this.ClearAutoLeaveTimer();
		}

		// Token: 0x060309D8 RID: 199128 RVA: 0x00D8D251 File Offset: 0x00D8B451
		protected override void OnBeforeDestroy()
		{
			this.ClearAutoLeaveTimer();
			this.IsPlayed = false;
		}

		// Token: 0x060309D9 RID: 199129 RVA: 0x00D8D260 File Offset: 0x00D8B460
		private void RefreshTitle()
		{
			UUIText text = base.GetText(1);
			text.SetColor(FColor.FromHex("C48B29FF"));
			text.ShowTextNew("GenericPromptTypes_3_GeneralText");
			UUIEffectOutline uuieffectOutline = text.GetOwner().GetComponentByClass(UUIEffectOutline.StaticClass()) as UUIEffectOutline;
			text.outlineColor = FColor.FromHex("C48B29FF");
			base.GetTexture(2).SetColor(FColor.FromHex("8C754D7F"));
			if (uuieffectOutline != null)
			{
				uuieffectOutline.SetOutlineColor(FColor.FromHex("C48B29FF"));
			}
			text.SetColor(FColor.FromHex("f2efd5"));
		}

		// Token: 0x060309DA RID: 199130 RVA: 0x00D8D2F4 File Offset: 0x00D8B4F4
		private void StartAutoLeaveTimer()
		{
			int leftSecondToAutoLeave = 31;
			this.AutoLeaveTimerId = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				int leftSecondToAutoLeave;
				if (leftSecondToAutoLeave <= 0)
				{
					TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
					this.OnExitBtnClick();
					return;
				}
				FlagChallengeSettleButton flagChallengeSettleButton = this.ButtonMap[0];
				string textId = "InstanceDungeonLeftTimeToAutoLeave";
				object[] array = new object[1];
				int num = 0;
				leftSecondToAutoLeave = leftSecondToAutoLeave;
				leftSecondToAutoLeave--;
				array[num] = leftSecondToAutoLeave.ToString();
				flagChallengeSettleButton.SetFloatText(textId, array);
			}, 1000f, 1f, null, null, true);
		}

		// Token: 0x060309DB RID: 199131 RVA: 0x00D8D33F File Offset: 0x00D8B53F
		private void TryPlaySequence()
		{
			if (this.IsPlayed)
			{
				return;
			}
			base.PlaySequence("Success", null, false);
			this.IsPlayed = true;
		}

		// Token: 0x060309DC RID: 199132 RVA: 0x00D8D360 File Offset: 0x00D8B560
		private void RefreshLevelPanel()
		{
			FlagChallengeSettleInfo settleInfo = FlagChallengeBattleModel.Instance.SettleInfo;
			int level = settleInfo.Level;
			int cacheLevel = settleInfo.CacheLevel;
			int num = MathUtils.Instance.Clamp(level - cacheLevel, 0, level);
			int boxLevel = settleInfo.BoxLevel;
			this.LevelPanel.SetLevelText(level.ToString(), num.ToString(), boxLevel.ToString());
		}

		// Token: 0x060309DD RID: 199133 RVA: 0x00D8D3BB File Offset: 0x00D8B5BB
		private void ClearAutoLeaveTimer()
		{
			if (this.AutoLeaveTimerId != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
			}
			this.AutoLeaveTimerId = null;
		}

		// Token: 0x060309DE RID: 199134 RVA: 0x00D8D3E0 File Offset: 0x00D8B5E0
		private UniTask InitButtonAsync()
		{
			FlagChallengeSettleView.<InitButtonAsync>d__19 <InitButtonAsync>d__;
			<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonAsync>d__.<>4__this = this;
			<InitButtonAsync>d__.<>1__state = -1;
			<InitButtonAsync>d__.<>t__builder.Start<FlagChallengeSettleView.<InitButtonAsync>d__19>(ref <InitButtonAsync>d__);
			return <InitButtonAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060309DF RID: 199135 RVA: 0x00D8D424 File Offset: 0x00D8B624
		private UniTask InitLevelPanelAsync()
		{
			FlagChallengeSettleView.<InitLevelPanelAsync>d__20 <InitLevelPanelAsync>d__;
			<InitLevelPanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLevelPanelAsync>d__.<>4__this = this;
			<InitLevelPanelAsync>d__.<>1__state = -1;
			<InitLevelPanelAsync>d__.<>t__builder.Start<FlagChallengeSettleView.<InitLevelPanelAsync>d__20>(ref <InitLevelPanelAsync>d__);
			return <InitLevelPanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060309E0 RID: 199136 RVA: 0x00D8D468 File Offset: 0x00D8B668
		private UniTask CreateButton(UUIItem uiItem, int buttonIndex, Action clickFunction)
		{
			FlagChallengeSettleView.<CreateButton>d__21 <CreateButton>d__;
			<CreateButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateButton>d__.<>4__this = this;
			<CreateButton>d__.buttonIndex = buttonIndex;
			<CreateButton>d__.clickFunction = clickFunction;
			<CreateButton>d__.<>1__state = -1;
			<CreateButton>d__.<>t__builder.Start<FlagChallengeSettleView.<CreateButton>d__21>(ref <CreateButton>d__);
			return <CreateButton>d__.<>t__builder.Task;
		}

		// Token: 0x060309E1 RID: 199137 RVA: 0x00D8D4BC File Offset: 0x00D8B6BC
		private void OnNextLevelBtnClick()
		{
			int activityId = FlagChallengeBattleModel.Instance.ActivityId;
			int? recommendLevel = FlagChallengeModel.Instance.GetRecommendLevel(activityId, false);
			if (recommendLevel != null && recommendLevel.GetValueOrDefault() != 0)
			{
				FlagChallengeController.Instance.OpenFlagChallengeMainView(activityId, recommendLevel);
			}
		}

		// Token: 0x060309E2 RID: 199138 RVA: 0x00D8D4FF File Offset: 0x00D8B6FF
		private void OnExitBtnClick()
		{
			FlagChallengeBattleController.Instance.LeaveFlagChallengeInstance().Forget();
		}

		// Token: 0x04019B9F RID: 105375
		private const string SUCCESS_OUTLINE_COLOR = "C48B29FF";

		// Token: 0x04019BA0 RID: 105376
		private const string SUCCESS_TEXT_COLOR = "f2efd5";

		// Token: 0x04019BA1 RID: 105377
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Dictionary<int, FlagChallengeSettleButton> ButtonMap;

		// Token: 0x04019BA2 RID: 105378
		[Nullable(2)]
		protected FlagChallengeResultLevelPanel LevelPanel;

		// Token: 0x04019BA3 RID: 105379
		[Nullable(2)]
		private TimerHandle AutoLeaveTimerId;

		// Token: 0x04019BA4 RID: 105380
		private bool IsPlayed;

		// Token: 0x0200A83D RID: 43069
		[NullableContext(0)]
		private enum EButtons
		{
			// Token: 0x04033F86 RID: 212870
			LeftButton,
			// Token: 0x04033F87 RID: 212871
			RightButton
		}

		// Token: 0x0200A83E RID: 43070
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x04033F89 RID: 212873
			TitleItem,
			// Token: 0x04033F8A RID: 212874
			TitleText,
			// Token: 0x04033F8B RID: 212875
			TitleTexture,
			// Token: 0x04033F8C RID: 212876
			ButtonHorizontalItem = 4,
			// Token: 0x04033F8D RID: 212877
			ButtonItem,
			// Token: 0x04033F8E RID: 212878
			ContentItem = 20
		}
	}
}
