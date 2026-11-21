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
	// Token: 0x02005133 RID: 20787
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleSkinTrialSubView : ActivitySubViewBase
	{
		// Token: 0x06033F9C RID: 212892 RVA: 0x00E8AAE0 File Offset: 0x00E88CE0
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

		// Token: 0x06033F9D RID: 212893 RVA: 0x00E8AE08 File Offset: 0x00E89008
		protected override UniTask OnBeforeStartAsync()
		{
			RoleSkinTrialSubView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkinTrialSubView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033F9E RID: 212894 RVA: 0x00E8AE4B File Offset: 0x00E8904B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnStateChange));
		}

		// Token: 0x06033F9F RID: 212895 RVA: 0x00E8AE69 File Offset: 0x00E89069
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnStateChange));
		}

		// Token: 0x06033FA0 RID: 212896 RVA: 0x00E8AE87 File Offset: 0x00E89087
		private void OnStateChange(int id)
		{
			if (id != this.ActivityBaseData.Id)
			{
				return;
			}
			this.RefreshReward(this.SelectToggleIndex);
		}

		// Token: 0x06033FA1 RID: 212897 RVA: 0x00E8AEA4 File Offset: 0x00E890A4
		private ActivitySmallItemGrid InitGridItem()
		{
			return new ActivitySmallItemGrid();
		}

		// Token: 0x06033FA2 RID: 212898 RVA: 0x00E8AEAB File Offset: 0x00E890AB
		private RoleItem InitRoleItem()
		{
			return new RoleItem
			{
				ToggleCallBack = new Action<RoleItemData>(this.ToggleCallBack)
			};
		}

		// Token: 0x06033FA3 RID: 212899 RVA: 0x00E8AEC4 File Offset: 0x00E890C4
		private void ToggleCallBack(RoleItemData data)
		{
			this.SelectToggleIndex = data.Index;
			this.RefreshViewBySelectToggleIndex(this.SelectToggleIndex);
			this.RefreshLayout();
			this.PlaySwitchSequence();
		}

		// Token: 0x06033FA4 RID: 212900 RVA: 0x00E8AEEA File Offset: 0x00E890EA
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

		// Token: 0x06033FA5 RID: 212901 RVA: 0x00E8AF28 File Offset: 0x00E89128
		private void RefreshViewBySelectToggleIndex(int index)
		{
			this.RefreshReward(index);
			this.RefreshDescriptionComponent(index);
			this.RefreshNameText(index);
			this.RefreshUiConfigPerformance(index);
			this.RefreshSpine(index);
			this.RefreshInfluenceTexture(index);
		}

		// Token: 0x06033FA6 RID: 212902 RVA: 0x00E8AF58 File Offset: 0x00E89158
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

		// Token: 0x06033FA7 RID: 212903 RVA: 0x00E8B010 File Offset: 0x00E89210
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

		// Token: 0x06033FA8 RID: 212904 RVA: 0x00E8B058 File Offset: 0x00E89258
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

		// Token: 0x06033FA9 RID: 212905 RVA: 0x00E8B0DB File Offset: 0x00E892DB
		protected override void OnTimer(float gap)
		{
			this.RefreshTimeTitle();
		}

		// Token: 0x06033FAA RID: 212906 RVA: 0x00E8B0E4 File Offset: 0x00E892E4
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

		// Token: 0x06033FAB RID: 212907 RVA: 0x00E8B180 File Offset: 0x00E89380
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

		// Token: 0x06033FAC RID: 212908 RVA: 0x00E8B2B8 File Offset: 0x00E894B8
		private void RefreshLayout()
		{
			List<int> roleList = this.CurrentData.GetRoleList();
			List<RoleItemData> list = new List<RoleItemData>();
			for (int i = 0; i < roleList.Count; i++)
			{
				int num = roleList[i];
				list.Add(new RoleItemData
				{
					RoleId = num,
					ActivityId = this.CurrentData.Id,
					Index = i,
					SelectState = (i == this.SelectToggleIndex),
					FinishState = (this.CurrentData.GetRewardStateById(num) == ChallengeState.Finish),
					RoleSkinTrialData = this.CurrentData
				});
			}
			this.RoleLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06033FAD RID: 212909 RVA: 0x00E8B362 File Offset: 0x00E89562
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

		// Token: 0x06033FAE RID: 212910 RVA: 0x00E8B380 File Offset: 0x00E89580
		private void RefreshNameText(int index)
		{
			int selectIdByIndex = this.CurrentData.GetSelectIdByIndex(index);
			int previewSkinId = RoleSkinTrialConfig.Instance.GetRoleSkinTrialInfoById(selectIdByIndex).Value.PreviewSkinId;
			RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(previewSkinId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(15), roleSkinData.GetTitleName(), Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(16), roleSkinData.GetSubTitle(), Array.Empty<object>());
		}

		// Token: 0x06033FAF RID: 212911 RVA: 0x00E8B400 File Offset: 0x00E89600
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

		// Token: 0x06033FB0 RID: 212912 RVA: 0x00E8B44C File Offset: 0x00E8964C
		private void PlaySwitchSequence()
		{
			if (this.LevelSequenceSwitchPlayer.GetCurrentSequence() == "Switch")
			{
				this.LevelSequenceSwitchPlayer.ReplaySequenceByKey("Switch");
				return;
			}
			this.LevelSequenceSwitchPlayer.PlayLevelSequenceByName("Switch", false, null, false);
		}

		// Token: 0x06033FB1 RID: 212913 RVA: 0x00E8B49C File Offset: 0x00E8969C
		private void ButtonRewardClaimedClick()
		{
			int selectIdByIndex = this.CurrentData.GetSelectIdByIndex(this.SelectToggleIndex);
			RoleSkinTrialController.RequestRoleSkinTrailInstanceReward(this.CurrentData.Id, selectIdByIndex);
		}

		// Token: 0x06033FB2 RID: 212914 RVA: 0x00E8B4CC File Offset: 0x00E896CC
		private void OnShopButtonClick()
		{
			int selectIdByIndex = this.CurrentData.GetSelectIdByIndex(this.SelectToggleIndex);
			SkipTaskManager.RunByConfigId(this.CurrentData.GetAccessIdById(selectIdByIndex), null);
		}

		// Token: 0x06033FB3 RID: 212915 RVA: 0x00E8B500 File Offset: 0x00E89700
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

		// Token: 0x06033FB4 RID: 212916 RVA: 0x00E8B5B8 File Offset: 0x00E897B8
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequenceSwitchPlayer = this.LevelSequenceSwitchPlayer;
			if (levelSequenceSwitchPlayer == null)
			{
				return;
			}
			levelSequenceSwitchPlayer.Clear();
		}

		// Token: 0x06033FB5 RID: 212917 RVA: 0x00E8B5CC File Offset: 0x00E897CC
		private void RefreshHorizontalLayout()
		{
			bool uiactive = this.CurrentData.GetRoleList().Count > 1;
			base.GetHorizontalLayout(1).RootUIComp.Get().SetUIActive(uiactive);
			base.GetItem(18).SetUIActive(uiactive);
		}

		// Token: 0x0401B807 RID: 112647
		private int SelectToggleIndex;

		// Token: 0x0401B808 RID: 112648
		private GenericLayout<RoleItem, RoleItemData> RoleLayout;

		// Token: 0x0401B809 RID: 112649
		private RoleSkinTrialData CurrentData;

		// Token: 0x0401B80A RID: 112650
		private LevelSequencePlayer LevelSequenceSwitchPlayer;

		// Token: 0x0401B80B RID: 112651
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x0401B80C RID: 112652
		private ActivityDescriptionTypeB DescriptionComponent;

		// Token: 0x0401B80D RID: 112653
		private ActivityRewardList<ActivitySmallItemGrid, IItemGridData> RewardListComponent;

		// Token: 0x0401B80E RID: 112654
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x0200ADEC RID: 44524
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035BFF RID: 220159
			public const int TexInfluence = 0;

			// Token: 0x04035C00 RID: 220160
			public const int PanelRole = 1;

			// Token: 0x04035C01 RID: 220161
			public const int TitleItem = 2;

			// Token: 0x04035C02 RID: 220162
			public const int DescriptionItem = 3;

			// Token: 0x04035C03 RID: 220163
			public const int RewardListItem = 4;

			// Token: 0x04035C04 RID: 220164
			public const int FunctionArea = 5;

			// Token: 0x04035C05 RID: 220165
			public const int PanelDone = 6;

			// Token: 0x04035C06 RID: 220166
			public const int PanelOngoing = 7;

			// Token: 0x04035C07 RID: 220167
			public const int BtnReward = 8;

			// Token: 0x04035C08 RID: 220168
			public const int TexColor1 = 9;

			// Token: 0x04035C09 RID: 220169
			public const int TexColor2 = 10;

			// Token: 0x04035C0A RID: 220170
			public const int TexColor3 = 11;

			// Token: 0x04035C0B RID: 220171
			public const int TexColor4 = 12;

			// Token: 0x04035C0C RID: 220172
			public const int TexColor5 = 13;

			// Token: 0x04035C0D RID: 220173
			public const int ShopBtn = 14;

			// Token: 0x04035C0E RID: 220174
			public const int MainNameText = 15;

			// Token: 0x04035C0F RID: 220175
			public const int SubNameText = 16;

			// Token: 0x04035C10 RID: 220176
			public const int SpineTexture = 17;

			// Token: 0x04035C11 RID: 220177
			public const int HorizontalMaskItem = 18;

			// Token: 0x04035C12 RID: 220178
			public const int SpineParentItem = 19;
		}
	}
}
