using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoleSkinTrial
{
	// Token: 0x020061B5 RID: 25013
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleSkinTrialSubView : ActivitySubViewBase
	{
		// Token: 0x0603F2DC RID: 258780 RVA: 0x00F43C14 File Offset: 0x00F41E14
		protected unsafe override void OnRegisterComponent()
		{
			int num = 20;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.ButtonRewardClaimedClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnShopButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603F2DD RID: 258781 RVA: 0x00F43F3C File Offset: 0x00F4213C
		protected override UniTask OnBeforeStartAsync()
		{
			RoleSkinTrialSubView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkinTrialSubView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F2DE RID: 258782 RVA: 0x00F43F7F File Offset: 0x00F4217F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnStateChange));
		}

		// Token: 0x0603F2DF RID: 258783 RVA: 0x00F43F9D File Offset: 0x00F4219D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnStateChange));
		}

		// Token: 0x0603F2E0 RID: 258784 RVA: 0x00F43FBB File Offset: 0x00F421BB
		private void OnStateChange(int id)
		{
			if (id != this.ActivityBaseData.Id)
			{
				return;
			}
			this.RefreshReward(this.SelectToggleIndex);
		}

		// Token: 0x0603F2E1 RID: 258785 RVA: 0x00F43FD8 File Offset: 0x00F421D8
		private ActivitySmallItemGrid InitGridItem()
		{
			return new ActivitySmallItemGrid();
		}

		// Token: 0x0603F2E2 RID: 258786 RVA: 0x00F43FDF File Offset: 0x00F421DF
		private RoleItem InitRoleItem()
		{
			return new RoleItem
			{
				ToggleCallBack = new Action<RoleItemData>(this.ToggleCallBack)
			};
		}

		// Token: 0x0603F2E3 RID: 258787 RVA: 0x00F43FF8 File Offset: 0x00F421F8
		private void ToggleCallBack(RoleItemData data)
		{
			this.SelectToggleIndex = data.Index;
			this.RefreshViewBySelectToggleIndex(this.SelectToggleIndex);
			this.RefreshLayout();
			this.PlaySwitchSequence();
		}

		// Token: 0x0603F2E4 RID: 258788 RVA: 0x00F4401E File Offset: 0x00F4221E
		protected override void OnRefreshView()
		{
			this.CurrentData = (this.ActivityBaseData as RoleSkinTrialData);
			this.SelectToggleIndex = 0;
			this.RefreshViewBySelectToggleIndex(this.SelectToggleIndex);
			this.RefreshTitleComponent();
			this.PlaySwitchSequence();
			this.RefreshHorizontalLayout();
			this.RefreshLayout();
		}

		// Token: 0x0603F2E5 RID: 258789 RVA: 0x00F4405C File Offset: 0x00F4225C
		private void RefreshViewBySelectToggleIndex(int index)
		{
			this.RefreshReward(index);
			this.RefreshDescriptionComponent(index);
			this.RefreshNameText(index);
			this.RefreshUiConfigPerformance(index);
			this.RefreshSpine(index);
			this.RefreshInfluenceTexture(index);
		}

		// Token: 0x0603F2E6 RID: 258790 RVA: 0x00F4408C File Offset: 0x00F4228C
		private void RefreshTitleComponent()
		{
			Activity? localConfig = this.ActivityBaseData.LocalConfig;
			this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
			this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
			this.TitleComponent.SetSubTitleVisible(!StringUtils.IsEmpty((localConfig != null) ? localConfig.GetValueOrDefault().DescTheme : null));
			if (!StringUtils.IsEmpty((localConfig != null) ? localConfig.GetValueOrDefault().DescTheme : null))
			{
				this.TitleComponent.SetSubTitleByTextId(localConfig.Value.DescTheme, Array.Empty<string>());
			}
			this.RefreshTimeTitle();
		}

		// Token: 0x0603F2E7 RID: 258791 RVA: 0x00F44144 File Offset: 0x00F42344
		private void RefreshTimeTitle()
		{
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(this.ActivityBaseData, null);
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			this.TitleComponent.SetTimeTextVisible(item);
			if (item)
			{
				this.TitleComponent.SetTimeTextByText(item2);
			}
		}

		// Token: 0x0603F2E8 RID: 258792 RVA: 0x00F4418C File Offset: 0x00F4238C
		private void RefreshDescriptionComponent(int index)
		{
			int selectIdByIndex = this.CurrentData.GetSelectIdByIndex(index);
			string text = RoleSkinTrialConfig.Instance.GetRoleSkinTrialInfoById(selectIdByIndex).Value.Introduction;
			if (StringUtils.IsEmpty(text))
			{
				text = this.ActivityBaseData.LocalConfig.Value.Desc;
			}
			bool flag = !StringUtils.IsEmpty(text);
			this.DescriptionComponent.SetContentVisible(flag);
			if (flag)
			{
				this.DescriptionComponent.SetContentByTextId(text, Array.Empty<string>());
			}
		}

		// Token: 0x0603F2E9 RID: 258793 RVA: 0x00F4420F File Offset: 0x00F4240F
		protected override void OnTimer(float gap)
		{
			this.RefreshTimeTitle();
		}

		// Token: 0x0603F2EA RID: 258794 RVA: 0x00F44218 File Offset: 0x00F42418
		private void RefreshReward(int index)
		{
			int selectIdByIndex = this.CurrentData.GetSelectIdByIndex(index);
			IItemGridData[] rewardDataById = this.CurrentData.GetRewardDataById(selectIdByIndex);
			this.RewardListComponent.SetItemLayoutVisible(rewardDataById != null && rewardDataById.Length != 0);
			ChallengeState rewardStateById = this.CurrentData.GetRewardStateById(selectIdByIndex);
			if (rewardDataById != null && rewardDataById.Length != 0)
			{
				this.RewardListComponent.RefreshItemLayout(rewardDataById, null);
			}
			base.GetItem(6).SetUIActive(rewardStateById == ChallengeState.Finish);
			base.GetItem(7).SetUIActive(rewardStateById == ChallengeState.Running);
			base.GetButton(8).RootUIComp.Get().SetUIActive(rewardStateById == ChallengeState.WaitTakeReward);
		}

		// Token: 0x0603F2EB RID: 258795 RVA: 0x00F442B4 File Offset: 0x00F424B4
		private void RefreshUiConfigPerformance(int index)
		{
			int selectIdByIndex = this.CurrentData.GetSelectIdByIndex(index);
			RoleSkinTrialUiConfig? roleSkinTrialUiConfigById = this.CurrentData.GetRoleSkinTrialUiConfigById(selectIdByIndex);
			base.GetTexture(9).SetColor(FColor.FromHex(((roleSkinTrialUiConfigById != null) ? roleSkinTrialUiConfigById.GetValueOrDefault().Color1 : null) ?? ""));
			base.GetTexture(10).SetColor(FColor.FromHex(((roleSkinTrialUiConfigById != null) ? roleSkinTrialUiConfigById.GetValueOrDefault().Color2 : null) ?? ""));
			base.GetTexture(11).SetColor(FColor.FromHex(((roleSkinTrialUiConfigById != null) ? roleSkinTrialUiConfigById.GetValueOrDefault().Color3 : null) ?? ""));
			base.GetTexture(12).SetColor(FColor.FromHex(((roleSkinTrialUiConfigById != null) ? roleSkinTrialUiConfigById.GetValueOrDefault().Color4 : null) ?? ""));
			base.GetTexture(13).SetColor(FColor.FromHex(((roleSkinTrialUiConfigById != null) ? roleSkinTrialUiConfigById.GetValueOrDefault().Color5 : null) ?? ""));
		}

		// Token: 0x0603F2EC RID: 258796 RVA: 0x00F443EC File Offset: 0x00F425EC
		private void RefreshLayout()
		{
			List<int> roleList = this.CurrentData.GetRoleList();
			List<RoleItemData> list = new List<RoleItemData>();
			for (int i = 0; i < roleList.Count; i++)
			{
				int roleId = roleList[i];
				list.Add(new RoleItemData
				{
					RoleId = roleId,
					ActivityId = this.CurrentData.Id,
					Index = i,
					SelectState = (i == this.SelectToggleIndex)
				});
			}
			this.RoleLayout.RefreshByData(list, null, false);
		}

		// Token: 0x0603F2ED RID: 258797 RVA: 0x00F44473 File Offset: 0x00F42673
		private void ButtonInstanceEnterClick()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (RoleController.Instance.IsInRoleTrial())
				{
					GenericPromptController.Instance.ShowPromptByCode("TrialRoleDungeonsLimit", Array.Empty<object>());
					return;
				}
				int selectIdByIndex = this.CurrentData.GetSelectIdByIndex(this.SelectToggleIndex);
				RoleSkinTrialController.EnterRoleTrialDungeonDirectly(this.CurrentData.GetInstanceIdById(selectIdByIndex).Value, this.CurrentData.Id, selectIdByIndex);
			});
		}

		// Token: 0x0603F2EE RID: 258798 RVA: 0x00F44494 File Offset: 0x00F42694
		private void RefreshNameText(int index)
		{
			int selectIdByIndex = this.CurrentData.GetSelectIdByIndex(index);
			int previewSkinId = RoleSkinTrialConfig.Instance.GetRoleSkinTrialInfoById(selectIdByIndex).Value.PreviewSkinId;
			RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(previewSkinId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(15), roleSkinData.GetTitleName(), Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(16), roleSkinData.GetSubTitle(), Array.Empty<object>());
		}

		// Token: 0x0603F2EF RID: 258799 RVA: 0x00F44514 File Offset: 0x00F42714
		private UniTask RefreshSpine(int index)
		{
			RoleSkinTrialSubView.<RefreshSpine>d__28 <RefreshSpine>d__;
			<RefreshSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshSpine>d__.<>4__this = this;
			<RefreshSpine>d__.index = index;
			<RefreshSpine>d__.<>1__state = -1;
			<RefreshSpine>d__.<>t__builder.Start<RoleSkinTrialSubView.<RefreshSpine>d__28>(ref <RefreshSpine>d__);
			return <RefreshSpine>d__.<>t__builder.Task;
		}

		// Token: 0x0603F2F0 RID: 258800 RVA: 0x00F44560 File Offset: 0x00F42760
		private void PlaySwitchSequence()
		{
			if (this.LevelSequenceSwitchPlayer.GetCurrentSequence() == "Switch")
			{
				this.LevelSequenceSwitchPlayer.ReplaySequenceByKey("Switch");
				return;
			}
			this.LevelSequenceSwitchPlayer.PlayLevelSequenceByName("Switch", false, null, false);
		}

		// Token: 0x0603F2F1 RID: 258801 RVA: 0x00F445B0 File Offset: 0x00F427B0
		private void ButtonRewardClaimedClick()
		{
			int selectIdByIndex = this.CurrentData.GetSelectIdByIndex(this.SelectToggleIndex);
			RoleSkinTrialController.RequestRoleSkinTrailInstanceReward(this.CurrentData.Id, selectIdByIndex);
		}

		// Token: 0x0603F2F2 RID: 258802 RVA: 0x00F445E0 File Offset: 0x00F427E0
		private void OnShopButtonClick()
		{
			int selectIdByIndex = this.CurrentData.GetSelectIdByIndex(this.SelectToggleIndex);
			SkipTaskManager.RunByConfigId(this.CurrentData.GetAccessIdById(selectIdByIndex), null);
		}

		// Token: 0x0603F2F3 RID: 258803 RVA: 0x00F44614 File Offset: 0x00F42814
		private void RefreshInfluenceTexture(int index)
		{
			int selectIdByIndex = this.CurrentData.GetSelectIdByIndex(index);
			RoleSkinTrialInfo? roleSkinTrialInfoById = RoleSkinTrialConfig.Instance.GetRoleSkinTrialInfoById(selectIdByIndex);
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleSkinTrialInfoById.Value.RoleId);
			if (roleConfig != null)
			{
				int partyId = roleConfig.Value.PartyId;
				Influence? influenceConfig = InfluenceConfig.Instance.GetInfluenceConfig(partyId);
				if (!StringUtils.IsEmpty((influenceConfig != null) ? influenceConfig.GetValueOrDefault().Logo : null))
				{
					UUITexture texture = base.GetTexture(0);
					base.SetTextureByPath(influenceConfig.Value.Logo, texture, null, null);
				}
			}
		}

		// Token: 0x0603F2F4 RID: 258804 RVA: 0x00F446CC File Offset: 0x00F428CC
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequenceSwitchPlayer = this.LevelSequenceSwitchPlayer;
			if (levelSequenceSwitchPlayer == null)
			{
				return;
			}
			levelSequenceSwitchPlayer.Clear();
		}

		// Token: 0x0603F2F5 RID: 258805 RVA: 0x00F446E0 File Offset: 0x00F428E0
		private void RefreshHorizontalLayout()
		{
			bool uiactive = this.CurrentData.GetRoleList().Count > 1;
			base.GetHorizontalLayout(1).RootUIComp.Get().SetUIActive(uiactive);
			base.GetItem(18).SetUIActive(uiactive);
		}

		// Token: 0x04020EDA RID: 134874
		private int SelectToggleIndex;

		// Token: 0x04020EDB RID: 134875
		private GenericLayout<RoleItem, RoleItemData> RoleLayout;

		// Token: 0x04020EDC RID: 134876
		private RoleSkinTrialData CurrentData;

		// Token: 0x04020EDD RID: 134877
		private LevelSequencePlayer LevelSequenceSwitchPlayer;

		// Token: 0x04020EDE RID: 134878
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x04020EDF RID: 134879
		private ActivityDescriptionTypeB DescriptionComponent;

		// Token: 0x04020EE0 RID: 134880
		private ActivityRewardList<ActivitySmallItemGrid, IItemGridData> RewardListComponent;

		// Token: 0x04020EE1 RID: 134881
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x0200C405 RID: 50181
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B29E RID: 242334
			public const int TexInfluence = 0;

			// Token: 0x0403B29F RID: 242335
			public const int PanelRole = 1;

			// Token: 0x0403B2A0 RID: 242336
			public const int TitleItem = 2;

			// Token: 0x0403B2A1 RID: 242337
			public const int DescriptionItem = 3;

			// Token: 0x0403B2A2 RID: 242338
			public const int RewardListItem = 4;

			// Token: 0x0403B2A3 RID: 242339
			public const int FunctionArea = 5;

			// Token: 0x0403B2A4 RID: 242340
			public const int PanelDone = 6;

			// Token: 0x0403B2A5 RID: 242341
			public const int PanelOngoing = 7;

			// Token: 0x0403B2A6 RID: 242342
			public const int BtnReward = 8;

			// Token: 0x0403B2A7 RID: 242343
			public const int TexColor1 = 9;

			// Token: 0x0403B2A8 RID: 242344
			public const int TexColor2 = 10;

			// Token: 0x0403B2A9 RID: 242345
			public const int TexColor3 = 11;

			// Token: 0x0403B2AA RID: 242346
			public const int TexColor4 = 12;

			// Token: 0x0403B2AB RID: 242347
			public const int TexColor5 = 13;

			// Token: 0x0403B2AC RID: 242348
			public const int ShopBtn = 14;

			// Token: 0x0403B2AD RID: 242349
			public const int MainNameText = 15;

			// Token: 0x0403B2AE RID: 242350
			public const int SubNameText = 16;

			// Token: 0x0403B2AF RID: 242351
			public const int SpineTexture = 17;

			// Token: 0x0403B2B0 RID: 242352
			public const int HorizontalMaskItem = 18;

			// Token: 0x0403B2B1 RID: 242353
			public const int SpineParentItem = 19;
		}
	}
}
