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
	// Token: 0x020052C0 RID: 21184
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballLevelView : PinballMainChildViewBase<PinballMainViewModel>
	{
		// Token: 0x06034BC7 RID: 216007 RVA: 0x00EBFB58 File Offset: 0x00EBDD58
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

		// Token: 0x06034BC8 RID: 216008 RVA: 0x00EBFCF0 File Offset: 0x00EBDEF0
		protected override UniTask OnBeforeStartAsync()
		{
			PinballLevelView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballLevelView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034BC9 RID: 216009 RVA: 0x00EBFD34 File Offset: 0x00EBDF34
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			PinballLevelView.<OnPlayingStartSequenceAsync>d__10 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<PinballLevelView.<OnPlayingStartSequenceAsync>d__10>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034BCA RID: 216010 RVA: 0x00EBFD77 File Offset: 0x00EBDF77
		protected override void OnBeforeShow()
		{
			this.SetCaptionInfo();
			this.RefreshLevelInfo();
		}

		// Token: 0x06034BCB RID: 216011 RVA: 0x00EBFD88 File Offset: 0x00EBDF88
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			PinballLevelView.<OnPlayingCloseSequenceAsync>d__12 <OnPlayingCloseSequenceAsync>d__;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
			<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<PinballLevelView.<OnPlayingCloseSequenceAsync>d__12>(ref <OnPlayingCloseSequenceAsync>d__);
			return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034BCC RID: 216012 RVA: 0x00EBFDCC File Offset: 0x00EBDFCC
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

		// Token: 0x06034BCD RID: 216013 RVA: 0x00EBFEC8 File Offset: 0x00EBE0C8
		private void RefreshChapterInfo()
		{
			PinballChapterData chapterData = base.ViewModel.GetChapterData();
			if (chapterData != null)
			{
				this.ChapterItem.Refresh(chapterData, false);
				this.ChapterItem.SetProgressActive(false);
			}
		}

		// Token: 0x06034BCE RID: 216014 RVA: 0x00EBFF00 File Offset: 0x00EBE100
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

		// Token: 0x06034BCF RID: 216015 RVA: 0x00EC0030 File Offset: 0x00EBE230
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

		// Token: 0x06034BD0 RID: 216016 RVA: 0x00EC00B0 File Offset: 0x00EBE2B0
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

		// Token: 0x06034BD1 RID: 216017 RVA: 0x00EC01E8 File Offset: 0x00EBE3E8
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

		// Token: 0x06034BD2 RID: 216018 RVA: 0x00EC0270 File Offset: 0x00EBE470
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

		// Token: 0x06034BD3 RID: 216019 RVA: 0x00EC02C1 File Offset: 0x00EBE4C1
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

		// Token: 0x0401BEC1 RID: 114369
		private PinballLevelInfoPanel LevelInfoPanel;

		// Token: 0x0401BEC2 RID: 114370
		private PinballMainChapterItem ChapterItem;

		// Token: 0x0401BEC3 RID: 114371
		private PinballLevelItem CommonLevelItem1;

		// Token: 0x0401BEC4 RID: 114372
		private PinballLevelItem CommonLevelItem2;

		// Token: 0x0401BEC5 RID: 114373
		private PinballLevelItem CommonLevelItem3;

		// Token: 0x0401BEC6 RID: 114374
		private PinballCowLevelItem CowLevelItem;

		// Token: 0x0401BEC7 RID: 114375
		private UUIExtendToggle CurrentLevelToggle;

		// Token: 0x0200AF40 RID: 44864
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04036269 RID: 221801
			LevelDetailTips,
			// Token: 0x0403626A RID: 221802
			SpineRoleNotDone,
			// Token: 0x0403626B RID: 221803
			TxtRescueRole,
			// Token: 0x0403626C RID: 221804
			RoleDoneItem,
			// Token: 0x0403626D RID: 221805
			SpineRoleDone,
			// Token: 0x0403626E RID: 221806
			ComLevelItem1,
			// Token: 0x0403626F RID: 221807
			ComLevelItem2,
			// Token: 0x04036270 RID: 221808
			ComLevelItem3,
			// Token: 0x04036271 RID: 221809
			CowLevelItem,
			// Token: 0x04036272 RID: 221810
			ChapterItem,
			// Token: 0x04036273 RID: 221811
			RoleNotDoneItem,
			// Token: 0x04036274 RID: 221812
			RoleShowItem
		}
	}
}
