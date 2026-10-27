using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Level
{
	// Token: 0x02006342 RID: 25410
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballLevelView : PinballMainChildViewBase<PinballMainViewModel>
	{
		// Token: 0x0603FF06 RID: 261894 RVA: 0x00F78BF8 File Offset: 0x00F76DF8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603FF07 RID: 261895 RVA: 0x00F78D90 File Offset: 0x00F76F90
		protected override UniTask OnBeforeStartAsync()
		{
			PinballLevelView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballLevelView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FF08 RID: 261896 RVA: 0x00F78DD4 File Offset: 0x00F76FD4
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			PinballLevelView.<OnPlayingStartSequenceAsync>d__10 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<PinballLevelView.<OnPlayingStartSequenceAsync>d__10>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FF09 RID: 261897 RVA: 0x00F78E17 File Offset: 0x00F77017
		protected override void OnBeforeShow()
		{
			this.SetCaptionInfo();
			this.RefreshLevelInfo();
		}

		// Token: 0x0603FF0A RID: 261898 RVA: 0x00F78E28 File Offset: 0x00F77028
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			PinballLevelView.<OnPlayingCloseSequenceAsync>d__12 <OnPlayingCloseSequenceAsync>d__;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
			<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<PinballLevelView.<OnPlayingCloseSequenceAsync>d__12>(ref <OnPlayingCloseSequenceAsync>d__);
			return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FF0B RID: 261899 RVA: 0x00F78E6C File Offset: 0x00F7706C
		private void SetCaptionInfo()
		{
			if (base.ViewModel != null)
			{
				PinballChapterData chapterData = base.ViewModel.GetChapterData();
				PinballChapterConfig? pinballChapterConfigById = PinballConfig.Instance.GetPinballChapterConfigById(chapterData.ChapterId);
				Action<string> setViewTitle = base.ViewModel.SetViewTitle;
				if (setViewTitle != null)
				{
					setViewTitle(pinballChapterConfigById.Value.Name);
				}
				Action<int> setViewHelpId = base.ViewModel.SetViewHelpId;
				if (setViewHelpId != null)
				{
					setViewHelpId(555);
				}
				base.ViewModel.SetOverrideCloseFunc(new Action(this.OnBtnBackClick));
				Action<string> changePlanetTexture = base.ViewModel.ChangePlanetTexture;
				if (changePlanetTexture != null)
				{
					changePlanetTexture(pinballChapterConfigById.Value.PlanetBg);
				}
				Action<string> changePlanetMaskTexture = base.ViewModel.ChangePlanetMaskTexture;
				if (changePlanetMaskTexture != null)
				{
					changePlanetMaskTexture(pinballChapterConfigById.Value.PlanetMaskBg);
				}
				Action<string> changePlanetSwitchTexture = base.ViewModel.ChangePlanetSwitchTexture;
				if (changePlanetSwitchTexture == null)
				{
					return;
				}
				changePlanetSwitchTexture(pinballChapterConfigById.Value.PlanetBg);
			}
		}

		// Token: 0x0603FF0C RID: 261900 RVA: 0x00F78F68 File Offset: 0x00F77168
		private void RefreshChapterInfo()
		{
			PinballChapterData chapterData = base.ViewModel.GetChapterData();
			if (chapterData != null)
			{
				this.ChapterItem.Refresh(chapterData, false);
				this.ChapterItem.SetProgressActive(false);
			}
		}

		// Token: 0x0603FF0D RID: 261901 RVA: 0x00F78FA0 File Offset: 0x00F771A0
		private void RefreshLevelInfo()
		{
			List<PinballLevelRecordData> levelDataList = base.ViewModel.GetLevelDataList();
			PinballLevelRecordData selectLevelData = base.ViewModel.GetSelectLevelData();
			PinballLevelRecordData pinballLevelRecordData = this.AutoFindTargetLevelData(levelDataList);
			PinballLevelRecordData pinballLevelRecordData2 = (selectLevelData != null) ? selectLevelData : pinballLevelRecordData;
			UiPanelBase[] array = new UiPanelBase[]
			{
				this.CommonLevelItem1,
				this.CommonLevelItem2,
				this.CommonLevelItem3,
				this.CowLevelItem
			};
			for (int i = 0; i < levelDataList.Count; i++)
			{
				PinballLevelRecordData pinballLevelRecordData3 = levelDataList[i];
				UiPanelBase uiPanelBase = array[i];
				if (uiPanelBase != null)
				{
					PinballLevelItem pinballLevelItem = uiPanelBase as PinballLevelItem;
					if (pinballLevelItem != null)
					{
						pinballLevelItem.Refresh(pinballLevelRecordData3);
						if (pinballLevelRecordData3.LevelId == pinballLevelRecordData2.LevelId)
						{
							pinballLevelItem.SelectLevel();
							if (Info.Instance.IsInGamepad())
							{
								UiNavigationNewController.Instance.SetNavigationFocusForView(pinballLevelItem.GetRootItem(), true, false, false);
							}
						}
					}
					else
					{
						PinballCowLevelItem pinballCowLevelItem = uiPanelBase as PinballCowLevelItem;
						if (pinballCowLevelItem != null)
						{
							pinballCowLevelItem.Refresh(pinballLevelRecordData3);
							if (pinballLevelRecordData3.LevelId == pinballLevelRecordData2.LevelId)
							{
								pinballCowLevelItem.SelectLevel();
								if (Info.Instance.IsInGamepad())
								{
									UiNavigationNewController.Instance.SetNavigationFocusForView(pinballCowLevelItem.GetRootItem(), true, false, false);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0603FF0E RID: 261902 RVA: 0x00F790D0 File Offset: 0x00F772D0
		[NullableContext(1)]
		private PinballLevelRecordData AutoFindTargetLevelData(List<PinballLevelRecordData> levelDataList)
		{
			PinballLevelRecordData pinballLevelRecordData = null;
			foreach (PinballLevelRecordData pinballLevelRecordData2 in levelDataList)
			{
				if (pinballLevelRecordData2.PassStatus == EPinballLevelPassStatus.Unfinished)
				{
					pinballLevelRecordData = pinballLevelRecordData2;
					break;
				}
				if (pinballLevelRecordData2.PassStatus != EPinballLevelPassStatus.Perfect && (pinballLevelRecordData == null || pinballLevelRecordData2.LevelShowType == EPinballLevelShowType.Cow))
				{
					pinballLevelRecordData = pinballLevelRecordData2;
				}
			}
			return pinballLevelRecordData ?? levelDataList[levelDataList.Count - 1];
		}

		// Token: 0x0603FF0F RID: 261903 RVA: 0x00F79150 File Offset: 0x00F77350
		[NullableContext(1)]
		private void OnClickLevel(PinballLevelRecordData data, IPinballLevelInfoData infoData, UUIExtendToggle toggle)
		{
			if (this.CurrentLevelToggle != null)
			{
				this.CurrentLevelToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.CurrentLevelToggle = toggle;
			this.CurrentLevelToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			this.LevelInfoPanel.Refresh(infoData);
			base.ViewModel.SetSelectLevelData(data);
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(data.LevelId);
			bool isLevelFinished = data.PassStatus != EPinballLevelPassStatus.Unfinished;
			bool hasRole = pinballLevelConfigById.Value.ShowRoleId > 0;
			if (hasRole)
			{
				PinballRoleConfig? pinballRoleConfigById = PinballConfig.Instance.GetPinballRoleConfigById(pinballLevelConfigById.Value.ShowRoleId);
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew(RoleConfig.Instance.GetRoleConfig(pinballRoleConfigById.Value.RoleId).Value.Name, null);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Pinball_Level_UnlockCharacter", new <>z__ReadOnlySingleElementList<object>(localTextNew));
			}
			this.RefreshRoleSpine(pinballLevelConfigById.Value.ShowRoleId, "Idle_Fight", true, delegate
			{
				this.GetText(2).SetUIActive(!isLevelFinished & hasRole);
				this.GetItem(11).SetUIActive(hasRole);
				this.GetItem(3).SetUIActive(isLevelFinished & hasRole);
			});
		}

		// Token: 0x0603FF10 RID: 261904 RVA: 0x00F79288 File Offset: 0x00F77488
		[NullableContext(1)]
		private void RefreshRoleSpine(int roleId, string spineAnim, bool bLoop, Action finishCallback)
		{
			PinballLevelView.<>c__DisplayClass18_0 CS$<>8__locals1 = new PinballLevelView.<>c__DisplayClass18_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.spineAnim = spineAnim;
			CS$<>8__locals1.bLoop = bLoop;
			CS$<>8__locals1.finishCallback = finishCallback;
			if (roleId > 0)
			{
				CS$<>8__locals1.roleConfig = PinballConfig.Instance.GetPinballRoleConfigById(roleId);
				if (CS$<>8__locals1.roleConfig != null)
				{
					UiAsyncTask task = new UiAsyncTask("PinballLevelRoleSpine", delegate()
					{
						PinballLevelView.<>c__DisplayClass18_0.<<RefreshRoleSpine>b__0>d <<RefreshRoleSpine>b__0>d;
						<<RefreshRoleSpine>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
						<<RefreshRoleSpine>b__0>d.<>4__this = CS$<>8__locals1;
						<<RefreshRoleSpine>b__0>d.<>1__state = -1;
						<<RefreshRoleSpine>b__0>d.<>t__builder.Start<PinballLevelView.<>c__DisplayClass18_0.<<RefreshRoleSpine>b__0>d>(ref <<RefreshRoleSpine>b__0>d);
						return <<RefreshRoleSpine>b__0>d.<>t__builder.Task;
					}, null);
					base.RunAsyncTask(task).Forget();
				}
				return;
			}
			Action finishCallback2 = CS$<>8__locals1.finishCallback;
			if (finishCallback2 == null)
			{
				return;
			}
			finishCallback2();
		}

		// Token: 0x0603FF11 RID: 261905 RVA: 0x00F79310 File Offset: 0x00F77510
		private void OnBtnBackClick()
		{
			base.ViewModel.ClearSelectLevelData();
			if (this.RootView.GetChildViewStackNum() > 1)
			{
				base.BackToLastView();
				return;
			}
			UiAsyncTask task = new UiAsyncTask("PinballLevelViewToMainView", delegate()
			{
				PinballLevelView.<<OnBtnBackClick>b__19_0>d <<OnBtnBackClick>b__19_0>d;
				<<OnBtnBackClick>b__19_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<OnBtnBackClick>b__19_0>d.<>4__this = this;
				<<OnBtnBackClick>b__19_0>d.<>1__state = -1;
				<<OnBtnBackClick>b__19_0>d.<>t__builder.Start<PinballLevelView.<<OnBtnBackClick>b__19_0>d>(ref <<OnBtnBackClick>b__19_0>d);
				return <<OnBtnBackClick>b__19_0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x0603FF12 RID: 261906 RVA: 0x00F79361 File Offset: 0x00F77561
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams[0] == "Level")
			{
				return this.LevelInfoPanel.GetGuideUiItemAndUiItemForShowEx(RuntimeHelpers.GetSubArray<string>(configParams, Range.StartAt(1)));
			}
			return null;
		}

		// Token: 0x04021592 RID: 136594
		private PinballLevelInfoPanel LevelInfoPanel;

		// Token: 0x04021593 RID: 136595
		private PinballMainChapterItem ChapterItem;

		// Token: 0x04021594 RID: 136596
		private PinballLevelItem CommonLevelItem1;

		// Token: 0x04021595 RID: 136597
		private PinballLevelItem CommonLevelItem2;

		// Token: 0x04021596 RID: 136598
		private PinballLevelItem CommonLevelItem3;

		// Token: 0x04021597 RID: 136599
		private PinballCowLevelItem CowLevelItem;

		// Token: 0x04021598 RID: 136600
		private UUIExtendToggle CurrentLevelToggle;

		// Token: 0x0200C559 RID: 50521
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B907 RID: 243975
			LevelDetailTips,
			// Token: 0x0403B908 RID: 243976
			SpineRoleNotDone,
			// Token: 0x0403B909 RID: 243977
			TxtRescueRole,
			// Token: 0x0403B90A RID: 243978
			RoleDoneItem,
			// Token: 0x0403B90B RID: 243979
			SpineRoleDone,
			// Token: 0x0403B90C RID: 243980
			ComLevelItem1,
			// Token: 0x0403B90D RID: 243981
			ComLevelItem2,
			// Token: 0x0403B90E RID: 243982
			ComLevelItem3,
			// Token: 0x0403B90F RID: 243983
			CowLevelItem,
			// Token: 0x0403B910 RID: 243984
			ChapterItem,
			// Token: 0x0403B911 RID: 243985
			RoleNotDoneItem,
			// Token: 0x0403B912 RID: 243986
			RoleShowItem
		}
	}
}
