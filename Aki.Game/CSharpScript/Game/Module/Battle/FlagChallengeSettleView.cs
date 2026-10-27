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
	// Token: 0x02005C40 RID: 23616
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeSettleView : UiViewBase
	{
		// Token: 0x0603BA88 RID: 244360 RVA: 0x00E3CD8E File Offset: 0x00E3AF8E
		public FlagChallengeSettleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603BA89 RID: 244361 RVA: 0x00E3CD98 File Offset: 0x00E3AF98
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

		// Token: 0x0603BA8A RID: 244362 RVA: 0x00E3CE88 File Offset: 0x00E3B088
		protected override UniTask OnBeforeStartAsync()
		{
			FlagChallengeSettleView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FlagChallengeSettleView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BA8B RID: 244363 RVA: 0x00E3CECB File Offset: 0x00E3B0CB
		protected override void OnBeforeShow()
		{
			this.StartAutoLeaveTimer();
			this.TryPlaySequence();
		}

		// Token: 0x0603BA8C RID: 244364 RVA: 0x00E3CED9 File Offset: 0x00E3B0D9
		protected override void OnBeforeHide()
		{
			this.ClearAutoLeaveTimer();
		}

		// Token: 0x0603BA8D RID: 244365 RVA: 0x00E3CEE1 File Offset: 0x00E3B0E1
		protected override void OnBeforeDestroy()
		{
			this.ClearAutoLeaveTimer();
			this.IsPlayed = false;
		}

		// Token: 0x0603BA8E RID: 244366 RVA: 0x00E3CEF0 File Offset: 0x00E3B0F0
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

		// Token: 0x0603BA8F RID: 244367 RVA: 0x00E3CF84 File Offset: 0x00E3B184
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

		// Token: 0x0603BA90 RID: 244368 RVA: 0x00E3CFCF File Offset: 0x00E3B1CF
		private void TryPlaySequence()
		{
			if (this.IsPlayed)
			{
				return;
			}
			base.PlaySequence("Success", null, false);
			this.IsPlayed = true;
		}

		// Token: 0x0603BA91 RID: 244369 RVA: 0x00E3CFF0 File Offset: 0x00E3B1F0
		private void RefreshLevelPanel()
		{
			FlagChallengeSettleInfo settleInfo = FlagChallengeBattleModel.Instance.SettleInfo;
			int level = settleInfo.Level;
			int cacheLevel = settleInfo.CacheLevel;
			int num = MathUtils.Instance.Clamp(level - cacheLevel, 0, level);
			int boxLevel = settleInfo.BoxLevel;
			this.LevelPanel.SetLevelText(level.ToString(), num.ToString(), boxLevel.ToString());
		}

		// Token: 0x0603BA92 RID: 244370 RVA: 0x00E3D04B File Offset: 0x00E3B24B
		private void ClearAutoLeaveTimer()
		{
			if (this.AutoLeaveTimerId != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
			}
			this.AutoLeaveTimerId = null;
		}

		// Token: 0x0603BA93 RID: 244371 RVA: 0x00E3D070 File Offset: 0x00E3B270
		private UniTask InitButtonAsync()
		{
			FlagChallengeSettleView.<InitButtonAsync>d__19 <InitButtonAsync>d__;
			<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonAsync>d__.<>4__this = this;
			<InitButtonAsync>d__.<>1__state = -1;
			<InitButtonAsync>d__.<>t__builder.Start<FlagChallengeSettleView.<InitButtonAsync>d__19>(ref <InitButtonAsync>d__);
			return <InitButtonAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BA94 RID: 244372 RVA: 0x00E3D0B4 File Offset: 0x00E3B2B4
		private UniTask InitLevelPanelAsync()
		{
			FlagChallengeSettleView.<InitLevelPanelAsync>d__20 <InitLevelPanelAsync>d__;
			<InitLevelPanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLevelPanelAsync>d__.<>4__this = this;
			<InitLevelPanelAsync>d__.<>1__state = -1;
			<InitLevelPanelAsync>d__.<>t__builder.Start<FlagChallengeSettleView.<InitLevelPanelAsync>d__20>(ref <InitLevelPanelAsync>d__);
			return <InitLevelPanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BA95 RID: 244373 RVA: 0x00E3D0F8 File Offset: 0x00E3B2F8
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

		// Token: 0x0603BA96 RID: 244374 RVA: 0x00E3D14C File Offset: 0x00E3B34C
		private void OnNextLevelBtnClick()
		{
			int activityId = FlagChallengeBattleModel.Instance.ActivityId;
			int? recommendLevel = FlagChallengeModel.Instance.GetRecommendLevel(activityId, false);
			if (recommendLevel != null && recommendLevel.GetValueOrDefault() != 0)
			{
				FlagChallengeController.Instance.OpenFlagChallengeMainView(activityId, recommendLevel);
			}
		}

		// Token: 0x0603BA97 RID: 244375 RVA: 0x00E3D18F File Offset: 0x00E3B38F
		private void OnExitBtnClick()
		{
			FlagChallengeBattleController.Instance.LeaveFlagChallengeInstance().Forget();
		}

		// Token: 0x0401F0EE RID: 127214
		private const string SUCCESS_OUTLINE_COLOR = "C48B29FF";

		// Token: 0x0401F0EF RID: 127215
		private const string SUCCESS_TEXT_COLOR = "f2efd5";

		// Token: 0x0401F0F0 RID: 127216
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Dictionary<int, FlagChallengeSettleButton> ButtonMap;

		// Token: 0x0401F0F1 RID: 127217
		[Nullable(2)]
		protected FlagChallengeResultLevelPanel LevelPanel;

		// Token: 0x0401F0F2 RID: 127218
		[Nullable(2)]
		private TimerHandle AutoLeaveTimerId;

		// Token: 0x0401F0F3 RID: 127219
		private bool IsPlayed;

		// Token: 0x0200BE35 RID: 48693
		[NullableContext(0)]
		private enum EButtons
		{
			// Token: 0x040395C3 RID: 234947
			LeftButton,
			// Token: 0x040395C4 RID: 234948
			RightButton
		}

		// Token: 0x0200BE36 RID: 48694
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x040395C6 RID: 234950
			TitleItem,
			// Token: 0x040395C7 RID: 234951
			TitleText,
			// Token: 0x040395C8 RID: 234952
			TitleTexture,
			// Token: 0x040395C9 RID: 234953
			ButtonHorizontalItem = 4,
			// Token: 0x040395CA RID: 234954
			ButtonItem,
			// Token: 0x040395CB RID: 234955
			ContentItem = 20
		}
	}
}
