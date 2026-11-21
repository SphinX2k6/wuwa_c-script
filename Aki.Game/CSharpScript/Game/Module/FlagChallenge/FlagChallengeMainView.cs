using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.FlagChallenge;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A46 RID: 19014
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeMainView : UiViewBase
	{
		// Token: 0x0602F9C3 RID: 195011 RVA: 0x00D47645 File Offset: 0x00D45845
		public FlagChallengeMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F9C4 RID: 195012 RVA: 0x00D47664 File Offset: 0x00D45864
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUITexture)),
				new ValueTuple<int, Type>(6, typeof(UUITexture)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(16, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(18, typeof(UUIText)),
				new ValueTuple<int, Type>(19, typeof(UUITexture)),
				new ValueTuple<int, Type>(20, typeof(UUIArtText)),
				new ValueTuple<int, Type>(21, typeof(UUIText)),
				new ValueTuple<int, Type>(22, typeof(UUISprite)),
				new ValueTuple<int, Type>(23, typeof(UUIArtText)),
				new ValueTuple<int, Type>(24, typeof(UUISprite)),
				new ValueTuple<int, Type>(25, typeof(UUIArtText)),
				new ValueTuple<int, Type>(26, typeof(UUIText)),
				new ValueTuple<int, Type>(27, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(28, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(29, typeof(UUIItem)),
				new ValueTuple<int, Type>(30, typeof(UUIText)),
				new ValueTuple<int, Type>(31, typeof(UUIItem)),
				new ValueTuple<int, Type>(32, typeof(UUIItem)),
				new ValueTuple<int, Type>(33, typeof(UUIItem)),
				new ValueTuple<int, Type>(34, typeof(UUIItem)),
				new ValueTuple<int, Type>(35, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(36, typeof(UUIItem)),
				new ValueTuple<int, Type>(37, typeof(UUIText)),
				new ValueTuple<int, Type>(38, typeof(UUISprite)),
				new ValueTuple<int, Type>(39, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(13, new Action(this.OnBuffButtonClick)),
				new ValueTuple<int, Delegate>(17, new Action(this.OnTaskButtonClick)),
				new ValueTuple<int, Delegate>(27, new Action(this.OnDetailButtonClick)),
				new ValueTuple<int, Delegate>(28, new Action(this.OnChallengeButtonClick))
			};
		}

		// Token: 0x0602F9C5 RID: 195013 RVA: 0x00D47A7C File Offset: 0x00D45C7C
		protected override UniTask OnBeforeStartAsync()
		{
			FlagChallengeMainView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FlagChallengeMainView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F9C6 RID: 195014 RVA: 0x00D47AC0 File Offset: 0x00D45CC0
		protected override void OnStart()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotFlagChallengeActivityReward, base.GetItem(36), null, this.ActivityId);
			UUIItem item = base.GetItem(14);
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotFlagChallengeActivityBuffNewlyUnlocked, item, null, this.ActivityId);
			item.SetUIActive(this.Data.HasBuffNewlyUnlocked());
			this.LevelScrollView.GetGenericLayout().SelectGridProxyByKey(this.SelectedLevelId, true);
			UUIItem itemByKey = this.LevelScrollView.GetItemByKey(this.SelectedLevelId);
			if (itemByKey != null)
			{
				this.LevelScrollView.LateScrollTo(itemByKey, null, false);
			}
			this.LevelInfoItem.RefreshView();
			this.RefreshTaskView();
			EventSystem.Instance.Add(EEventName.OnFlagChallengeTaskUpdate, new Action<int>(this.OnTaskUpdate));
		}

		// Token: 0x0602F9C7 RID: 195015 RVA: 0x00D47B90 File Offset: 0x00D45D90
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotFlagChallengeActivityReward, base.GetItem(36), this.ActivityId);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotFlagChallengeActivityBuffNewlyUnlocked, base.GetItem(14), this.ActivityId);
			EventSystem.Instance.Remove(EEventName.OnFlagChallengeTaskUpdate, new Action<int>(this.OnTaskUpdate));
		}

		// Token: 0x0602F9C8 RID: 195016 RVA: 0x00D47BF4 File Offset: 0x00D45DF4
		private void InitViewData()
		{
			ActivityFlagChallengeData activityFlagChallengeData = (ActivityFlagChallengeData)this.OpenParam;
			this.ActivityId = activityFlagChallengeData.Id;
			this.Data = FlagChallengeModel.Instance.GetFlagChallengeData(this.ActivityId);
			this.SelectedLevelId = (this.Data.GetMainViewSelectLevelId() ?? FlagChallengeModel.Instance.GetRecommendLevel(this.ActivityId, true).Value);
			this.Data.SetMainViewSelectLevelId(null);
			this.UpdateViewData();
		}

		// Token: 0x0602F9C9 RID: 195017 RVA: 0x00D47C88 File Offset: 0x00D45E88
		private void UpdateViewData()
		{
			int levelRecommendStrongholdId = FlagChallengeModel.Instance.GetLevelRecommendStrongholdId(this.ActivityId, this.SelectedLevelId, null);
			this.EnterStrongholdId = levelRecommendStrongholdId;
		}

		// Token: 0x0602F9CA RID: 195018 RVA: 0x00D47CB4 File Offset: 0x00D45EB4
		private UniTask CreateAreaItemAsync(UUIItem uiItem, int index)
		{
			FlagChallengeMainView.<CreateAreaItemAsync>d__19 <CreateAreaItemAsync>d__;
			<CreateAreaItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateAreaItemAsync>d__.<>4__this = this;
			<CreateAreaItemAsync>d__.uiItem = uiItem;
			<CreateAreaItemAsync>d__.index = index;
			<CreateAreaItemAsync>d__.<>1__state = -1;
			<CreateAreaItemAsync>d__.<>t__builder.Start<FlagChallengeMainView.<CreateAreaItemAsync>d__19>(ref <CreateAreaItemAsync>d__);
			return <CreateAreaItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F9CB RID: 195019 RVA: 0x00D47D07 File Offset: 0x00D45F07
		private void RefreshTaskView()
		{
			base.GetText(18).SetText(this.Data.GetTaskProgressText(), true);
		}

		// Token: 0x0602F9CC RID: 195020 RVA: 0x00D47D24 File Offset: 0x00D45F24
		private void RefreshLevelView()
		{
			EFlagChallengeUiStyleType uiStyle = this.Data.GetLevelData(this.SelectedLevelId).GetUiStyle();
			Dictionary<string, string> dictionary;
			if (!FlagChallengeDefine.Instance.flagChallengeStyleRes.TryGetValue(uiStyle, out dictionary))
			{
				return;
			}
			UiResourceConfig instance = UiResourceConfig.Instance;
			base.SetTextureByPath(instance.GetResourcePath(dictionary["LevelMapBg"]), base.GetTexture(1), null, null);
			base.SetTextureByPath(instance.GetResourcePath(dictionary["LevelMapTopBg"]), base.GetTexture(2), null, null);
			base.SetTextureByPath(instance.GetResourcePath(dictionary["LevelListLight"]), base.GetTexture(3), null, null);
			base.SetTextureByPath(instance.GetResourcePath(dictionary["LevelFrame"]), base.GetTexture(5), null, null);
			base.SetTextureByPath(instance.GetResourcePath(dictionary["LevelSetOffLight"]), base.GetTexture(6), null, null);
			base.SetTextureByPath(instance.GetResourcePath(dictionary["LevelTitleBg"]), base.GetTexture(19), null, null);
			base.SetTextureByPath(instance.GetResourcePath(dictionary["MaskBg"]), base.GetTexture(4), null, null);
			base.GetItem(32).SetUIActive(uiStyle == EFlagChallengeUiStyleType.Green);
			base.GetItem(33).SetUIActive(uiStyle == EFlagChallengeUiStyleType.Yellow);
			base.GetItem(34).SetUIActive(uiStyle == EFlagChallengeUiStyleType.Red || uiStyle == EFlagChallengeUiStyleType.Hidden);
		}

		// Token: 0x0602F9CD RID: 195021 RVA: 0x00D47EB8 File Offset: 0x00D460B8
		private void RefreshLevelDetailView()
		{
			FlagChallengeLevelData levelData = this.Data.GetLevelData(this.SelectedLevelId);
			base.GetArtText(20).SetText(levelData.Index.ToString().PadLeft(2, '0'));
			base.GetText(21).ShowTextNew(levelData.LevelConfig.Name);
			base.GetText(26).ShowTextNew(levelData.LevelConfig.Desc);
			int[] recommendLevel = levelData.GetRecommendLevel();
			base.GetArtText(23).SetText(recommendLevel[0].ToString());
			base.GetArtText(25).SetText(recommendLevel[1].ToString());
			UiResourceConfig instance = UiResourceConfig.Instance;
			this.SetSpriteByPath(instance.GetResourcePath(this.GetLevelDiffBgRes(recommendLevel[0])), base.GetSprite(22), false, null, null);
			this.SetSpriteByPath(instance.GetResourcePath(this.GetLevelDiffBgRes(recommendLevel[1])), base.GetSprite(24), false, null, null);
			int totalLevel = FlagChallengeModel.Instance.GetTotalLevel(this.ActivityId);
			FlagChallengeStrongholdData strongholdData = this.Data.GetStrongholdData(this.EnterStrongholdId);
			base.GetItem(31).SetUIActive(!strongholdData.IsPass && totalLevel < strongholdData.StrongholdConfig.RecommendLevel);
			UUIText text = base.GetText(37);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Morale_32_Region_NickName_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(strongholdData.GetIndex());
			text.ShowTextNew(defaultInterpolatedStringHandler.ToStringAndClear());
			FlagChallengeAreaData areaData = this.Data.GetAreaData(strongholdData.StrongholdConfig.AreaId);
			UiResourceConfig instance2 = UiResourceConfig.Instance;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
			defaultInterpolatedStringHandler.AppendLiteral("SP_MoraleRome");
			defaultInterpolatedStringHandler.AppendFormatted<int>(areaData.Config.UiPos);
			this.SetSpriteByPath(instance2.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear()), base.GetSprite(38), false, null, null);
			bool flag = levelData.IsCompleted();
			base.GetItem(29).SetUIActive(!flag);
			base.GetButton(27).RootUIComp.Get().SetUIActive(!flag);
			base.GetButton(28).RootUIComp.Get().SetUIActive(!flag);
			base.GetItem(39).SetUIActive(flag);
		}

		// Token: 0x0602F9CE RID: 195022 RVA: 0x00D48118 File Offset: 0x00D46318
		private string GetLevelDiffBgRes(int targetLevel)
		{
			switch (FlagChallengeModel.Instance.GetLevelDiffType(this.ActivityId, targetLevel, null))
			{
			case EFlagChallengeLevelDiffType.Easy:
				return "SP_MoralePowerGreen";
			case EFlagChallengeLevelDiffType.Normal:
				return "SP_MoralePowerYellow";
			case EFlagChallengeLevelDiffType.Hard:
				return "SP_MoralePowerRed";
			default:
				return "SP_MoralePowerGreen";
			}
		}

		// Token: 0x0602F9CF RID: 195023 RVA: 0x00D4816C File Offset: 0x00D4636C
		private void RefreshAreaView(bool isClear = true)
		{
			if (isClear)
			{
				this.AreaItemMap.Clear();
				List<FlagChallengeAreaData> levelAreaDataList = this.Data.GetLevelAreaDataList(this.SelectedLevelId);
				foreach (FlagChallengeLevelAreaItem flagChallengeLevelAreaItem in this.AreaItemList)
				{
					flagChallengeLevelAreaItem.SetUiActive(false);
				}
				for (int i = 0; i < levelAreaDataList.Count; i++)
				{
					FlagChallengeAreaData flagChallengeAreaData = levelAreaDataList[i];
					int areaItemPos = flagChallengeAreaData.GetAreaItemPos();
					if (areaItemPos - 1 < this.AreaItemList.Count)
					{
						FlagChallengeLevelAreaItem flagChallengeLevelAreaItem2 = this.AreaItemList[areaItemPos - 1];
						if (flagChallengeLevelAreaItem2 != null)
						{
							flagChallengeLevelAreaItem2.Refresh(flagChallengeAreaData, i + 1);
							flagChallengeLevelAreaItem2.SetUiActive(true);
							this.AreaItemMap.Add(flagChallengeAreaData.Id, flagChallengeLevelAreaItem2);
						}
					}
				}
				return;
			}
			foreach (KeyValuePair<int, FlagChallengeLevelAreaItem> keyValuePair in this.AreaItemMap)
			{
				keyValuePair.Value.RefreshView();
			}
		}

		// Token: 0x0602F9D0 RID: 195024 RVA: 0x00D48298 File Offset: 0x00D46498
		private void OnBuffButtonClick()
		{
			FlagChallengeController.Instance.OpenFlagChallengeBuffView(this.ActivityId, null);
		}

		// Token: 0x0602F9D1 RID: 195025 RVA: 0x00D482BE File Offset: 0x00D464BE
		private void OnTaskButtonClick()
		{
			FlagChallengeController.Instance.OpenFlagChallengeTaskView(this.ActivityId);
		}

		// Token: 0x0602F9D2 RID: 195026 RVA: 0x00D482D0 File Offset: 0x00D464D0
		private void OnDetailButtonClick()
		{
			int levelRecommendStrongholdId = FlagChallengeModel.Instance.GetLevelRecommendStrongholdId(this.ActivityId, this.SelectedLevelId, null);
			FlagChallengeStrongholdData strongholdData = this.Data.GetStrongholdData(levelRecommendStrongholdId);
			FlagChallengeController.Instance.OpenFlagChallengeAreaDetailView(this.ActivityId, this.SelectedLevelId, strongholdData.StrongholdConfig.AreaId, new int?(strongholdData.Id));
		}

		// Token: 0x0602F9D3 RID: 195027 RVA: 0x00D48330 File Offset: 0x00D46530
		private void OnHelpClick()
		{
			int mainViewHelpId = FlagChallengeConfig.Instance.GetMainViewHelpId();
			HelpController.Instance.OpenHelpById(mainViewHelpId);
		}

		// Token: 0x0602F9D4 RID: 195028 RVA: 0x00D48353 File Offset: 0x00D46553
		private void OnChallengeButtonClick()
		{
			FlagChallengeController.Instance.OpenFlagChallengeSelectRoleView(this.ActivityId, this.SelectedLevelId, this.EnterStrongholdId);
		}

		// Token: 0x0602F9D5 RID: 195029 RVA: 0x00D48371 File Offset: 0x00D46571
		private FlagChallengeLevelTabItem CreateLevelItem()
		{
			FlagChallengeLevelTabItem flagChallengeLevelTabItem = new FlagChallengeLevelTabItem();
			flagChallengeLevelTabItem.SetToggleCallback(new Action<int>(this.OnLevelTabItemSelect));
			return flagChallengeLevelTabItem;
		}

		// Token: 0x0602F9D6 RID: 195030 RVA: 0x00D4838A File Offset: 0x00D4658A
		private void OnCloseButtonClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602F9D7 RID: 195031 RVA: 0x00D48393 File Offset: 0x00D46593
		private void OnTaskUpdate(int activityId)
		{
			if (activityId != this.ActivityId)
			{
				return;
			}
			this.RefreshTaskView();
		}

		// Token: 0x0602F9D8 RID: 195032 RVA: 0x00D483A8 File Offset: 0x00D465A8
		private void OnLevelTabItemSelect(int levelId)
		{
			GenericLayout<FlagChallengeLevelTabItem, FlagChallengeLevelData> genericLayout = this.LevelScrollView.GetGenericLayout();
			genericLayout.DeselectCurrentGridProxy();
			this.SelectedLevelId = levelId;
			genericLayout.SelectGridProxyByKey(levelId, false);
			this.UpdateViewData();
			this.RefreshAreaView(true);
			this.RefreshLevelView();
			this.RefreshLevelDetailView();
			this.SequencePlayer.StopCurrentSequenceByName("Switch", false, true);
			this.SequencePlayer.PlayOrReplaySequenceByName("Switch", true, null);
		}

		// Token: 0x0602F9D9 RID: 195033 RVA: 0x00D48420 File Offset: 0x00D46620
		private void OnLevelAreaItemClick(int areaId)
		{
			this.SelectedAreaId = new int?(areaId);
			int areaRecommendStrongholdId = FlagChallengeModel.Instance.GetAreaRecommendStrongholdId(this.ActivityId, areaId);
			FlagChallengeController.Instance.OpenFlagChallengeAreaDetailView(this.ActivityId, this.SelectedLevelId, this.SelectedAreaId.Value, new int?(areaRecommendStrongholdId));
		}

		// Token: 0x0401943B RID: 103483
		private int ActivityId;

		// Token: 0x0401943C RID: 103484
		private FlagChallengeData Data;

		// Token: 0x0401943D RID: 103485
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<FlagChallengeLevelTabItem, FlagChallengeLevelData> LevelScrollView;

		// Token: 0x0401943E RID: 103486
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401943F RID: 103487
		private FlagChallengeLevelInfoItem LevelInfoItem;

		// Token: 0x04019440 RID: 103488
		private FlagChallengeCompleteItem CompleteItem;

		// Token: 0x04019441 RID: 103489
		private readonly List<FlagChallengeLevelAreaItem> AreaItemList = new List<FlagChallengeLevelAreaItem>();

		// Token: 0x04019442 RID: 103490
		private readonly Dictionary<int, FlagChallengeLevelAreaItem> AreaItemMap = new Dictionary<int, FlagChallengeLevelAreaItem>();

		// Token: 0x04019443 RID: 103491
		private int SelectedLevelId;

		// Token: 0x04019444 RID: 103492
		private int? SelectedAreaId;

		// Token: 0x04019445 RID: 103493
		private int EnterStrongholdId;

		// Token: 0x04019446 RID: 103494
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;
	}
}
