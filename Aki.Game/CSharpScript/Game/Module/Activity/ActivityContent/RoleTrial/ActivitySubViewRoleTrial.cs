using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoleTrial
{
	// Token: 0x02005131 RID: 20785
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewRoleTrial : ActivitySubViewBase
	{
		// Token: 0x17006570 RID: 25968
		// (get) Token: 0x06033F59 RID: 212825 RVA: 0x00E890F3 File Offset: 0x00E872F3
		protected new ActivityRoleTrialData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as ActivityRoleTrialData;
			}
		}

		// Token: 0x17006571 RID: 25969
		// (get) Token: 0x06033F5A RID: 212826 RVA: 0x00E89100 File Offset: 0x00E87300
		// (set) Token: 0x06033F5B RID: 212827 RVA: 0x00E89108 File Offset: 0x00E87308
		private ActivityTitleTypeA TitleComponent { get; set; }

		// Token: 0x17006572 RID: 25970
		// (get) Token: 0x06033F5C RID: 212828 RVA: 0x00E89111 File Offset: 0x00E87311
		// (set) Token: 0x06033F5D RID: 212829 RVA: 0x00E89119 File Offset: 0x00E87319
		private ActivityDescriptionTypeB DescriptionComponent { get; set; }

		// Token: 0x17006573 RID: 25971
		// (get) Token: 0x06033F5E RID: 212830 RVA: 0x00E89122 File Offset: 0x00E87322
		// (set) Token: 0x06033F5F RID: 212831 RVA: 0x00E8912A File Offset: 0x00E8732A
		private ActivityRoleDescribeComponent RoleDescribeComponent { get; set; }

		// Token: 0x17006574 RID: 25972
		// (get) Token: 0x06033F60 RID: 212832 RVA: 0x00E89133 File Offset: 0x00E87333
		// (set) Token: 0x06033F61 RID: 212833 RVA: 0x00E8913B File Offset: 0x00E8733B
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private ActivityRewardList<ActivitySmallItemGrid, IItemGridData> RewardListComponent { [return: Nullable(new byte[]
		{
			2,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1
		})] set; }

		// Token: 0x17006575 RID: 25973
		// (get) Token: 0x06033F62 RID: 212834 RVA: 0x00E89144 File Offset: 0x00E87344
		// (set) Token: 0x06033F63 RID: 212835 RVA: 0x00E8914C File Offset: 0x00E8734C
		private ActivityFunctionalTypeA FunctionalComponent { get; set; }

		// Token: 0x17006576 RID: 25974
		// (get) Token: 0x06033F64 RID: 212836 RVA: 0x00E89155 File Offset: 0x00E87355
		// (set) Token: 0x06033F65 RID: 212837 RVA: 0x00E8915D File Offset: 0x00E8735D
		protected int CurrentRoleId { get; set; }

		// Token: 0x17006577 RID: 25975
		// (get) Token: 0x06033F66 RID: 212838 RVA: 0x00E89166 File Offset: 0x00E87366
		// (set) Token: 0x06033F67 RID: 212839 RVA: 0x00E8916E File Offset: 0x00E8736E
		private LevelSequencePlayer LevelSequenceSwitchPlayer { get; set; }

		// Token: 0x06033F68 RID: 212840 RVA: 0x00E89178 File Offset: 0x00E87378
		protected unsafe override void OnRegisterComponent()
		{
			int num = 27;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 7;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.ButtonRolePreviewClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.ButtonRewardClaimedClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(19, new Action(this.ButtonSkipGachaClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(23, new Action(this.ButtonRedPointLeftClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(24, new Action(this.ButtonRedPointRightClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(25, new Action(this.ButtonNewPointLeftClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(26, new Action(this.ButtonNewPointRightClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033F69 RID: 212841 RVA: 0x00E89642 File Offset: 0x00E87842
		protected override void OnSetData()
		{
		}

		// Token: 0x06033F6A RID: 212842 RVA: 0x00E89644 File Offset: 0x00E87844
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewRoleTrial.<OnBeforeStartAsync>d__41 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewRoleTrial.<OnBeforeStartAsync>d__41>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033F6B RID: 212843 RVA: 0x00E89688 File Offset: 0x00E87888
		protected override void OnStart()
		{
			Activity? localConfig = this.ActivityBaseData.LocalConfig;
			this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
			this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
			this.TitleComponent.SetSubTitleVisible(!StringUtils.IsEmpty((localConfig != null) ? localConfig.GetValueOrDefault().DescTheme : null));
			if (!string.IsNullOrEmpty((localConfig != null) ? localConfig.GetValueOrDefault().DescTheme : null))
			{
				this.TitleComponent.SetSubTitleByTextId(localConfig.Value.DescTheme, Array.Empty<string>());
			}
			this.RefreshTimerText();
			this.RewardListComponent.SetTitleByTextId("CollectActivity_reward");
			this.RewardListComponent.InitGridLayout(new Func<ActivitySmallItemGrid>(this.InitGridItem));
			this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.ButtonInstanceEnterClick));
			List<int> roleIdList = this.ActivityBaseData.RoleIdList;
			if (roleIdList.Count == 0)
			{
				return;
			}
			int roleId = roleIdList[0];
			if (this.OpenParam != null)
			{
				roleId = (int)this.OpenParam;
			}
			else if (this.ActivityBaseData.CurrentRoleId != 0 && roleIdList.Contains(this.ActivityBaseData.CurrentRoleId))
			{
				roleId = this.ActivityBaseData.CurrentRoleId;
			}
			this.HasSelectedNewRole = this.ActivityBaseData.GetIsNewByRoleId(roleId);
			this.RefreshScrollWidth(roleIdList.Count);
			this.RoleScroll.RefreshByData(roleIdList, delegate
			{
				this.SelectRoleToggle(roleId);
				this.RefreshIndexPair();
				this.OnRoleScrollValueChange();
			}, false);
		}

		// Token: 0x06033F6C RID: 212844 RVA: 0x00E89838 File Offset: 0x00E87A38
		private void RefreshScrollWidth(int roleCount)
		{
			ULGUIBehaviour scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(20);
			UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(2);
			float width = Math.Min((base.GetItem(21).GetWidth() + horizontalLayout.GetSpacing()) * (float)roleCount, this.ScrollDefaultWidth);
			scrollViewWithScrollbar.RootUIComp.Get().SetWidth(width);
		}

		// Token: 0x06033F6D RID: 212845 RVA: 0x00E8988C File Offset: 0x00E87A8C
		protected override void OnBeforeShow()
		{
			this.RoleScroll.BindScrollValueChange(delegate(FVector2D progress)
			{
				this.OnRoleScrollValueChange();
			});
			if (!this.HasSelectedNewRole)
			{
				List<int> roleIdList = this.ActivityBaseData.RoleIdList;
				foreach (int num in roleIdList)
				{
					if (this.ActivityBaseData.GetIsNewByRoleId(num))
					{
						int index = roleIdList.IndexOf(num);
						UUIItem itemByIndex = this.RoleScroll.GetItemByIndex(index);
						GenericScrollViewNew<RoleItem, int> roleScroll = this.RoleScroll;
						if (roleScroll != null)
						{
							roleScroll.ScrollTo(itemByIndex, false);
						}
						this.SelectRoleToggle(num);
						break;
					}
				}
			}
			this.HasSelectedNewRole = false;
		}

		// Token: 0x06033F6E RID: 212846 RVA: 0x00E89948 File Offset: 0x00E87B48
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnStateChange));
			EventSystem.Instance.Add<int>(EEventName.OnTrialRoleDataChanged, new Action<int>(this.OnStateChange));
		}

		// Token: 0x06033F6F RID: 212847 RVA: 0x00E89982 File Offset: 0x00E87B82
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnStateChange));
			EventSystem.Instance.Remove(EEventName.OnTrialRoleDataChanged, new Action<int>(this.OnStateChange));
		}

		// Token: 0x06033F70 RID: 212848 RVA: 0x00E899BC File Offset: 0x00E87BBC
		protected override void OnBeforeHide()
		{
			if (!this.ActivityBaseData.IsRoleInstanceOn())
			{
				this.ActivityBaseData.SetRoleTrialState(ERoleTrialFlowState.ActivityOff);
			}
		}

		// Token: 0x06033F71 RID: 212849 RVA: 0x00E899D7 File Offset: 0x00E87BD7
		protected override void OnBeforeDestroy()
		{
			if (!this.ActivityBaseData.IsRoleInstanceOn())
			{
				this.ActivityBaseData.SetRoleTrialState(ERoleTrialFlowState.ActivityOff);
				this.SetRoleId(0);
			}
			LevelSequencePlayer levelSequenceSwitchPlayer = this.LevelSequenceSwitchPlayer;
			if (levelSequenceSwitchPlayer == null)
			{
				return;
			}
			levelSequenceSwitchPlayer.Clear();
		}

		// Token: 0x06033F72 RID: 212850 RVA: 0x00E89A0C File Offset: 0x00E87C0C
		protected override void OnRefreshView()
		{
			this.RefreshCondition();
			this.RefreshTimerText();
			this.ActivityBaseData.SetRoleTrialState(ERoleTrialFlowState.ActivityOn);
			if (this.ActivityBaseData.CurrentRoleId != this.CurrentRoleId)
			{
				this.SelectRoleToggle(this.ActivityBaseData.CurrentRoleId);
				return;
			}
			this.PlaySwitchSequence();
		}

		// Token: 0x06033F73 RID: 212851 RVA: 0x00E89A5C File Offset: 0x00E87C5C
		private void RefreshCondition()
		{
			bool flag = this.ActivityBaseData.IsUnLock();
			this.FunctionalComponent.SetPanelConditionVisible(!flag);
			this.FunctionalComponent.FunctionButton.SetUiActive(flag);
			if (!flag)
			{
				this.FunctionalComponent.SetPerformanceConditionLock(this.ActivityBaseData.ConditionGroupId, this.ActivityBaseData.Id);
			}
		}

		// Token: 0x06033F74 RID: 212852 RVA: 0x00E89AB9 File Offset: 0x00E87CB9
		protected override void OnTimer(float gap)
		{
			this.RefreshTimerText();
		}

		// Token: 0x06033F75 RID: 212853 RVA: 0x00E89AC4 File Offset: 0x00E87CC4
		private void RefreshTimerText()
		{
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			this.TitleComponent.SetTimeTextVisible(item);
			if (item)
			{
				this.TitleComponent.SetTimeTextByText(item2);
			}
		}

		// Token: 0x06033F76 RID: 212854 RVA: 0x00E89B04 File Offset: 0x00E87D04
		private void OnStateChange(int id)
		{
			if (id != this.ActivityBaseData.Id)
			{
				return;
			}
			List<int> roleIdList = this.ActivityBaseData.RoleIdList;
			this.RefreshScrollWidth(roleIdList.Count);
			int roleId = this.CurrentRoleId;
			bool needFallback = roleIdList.Count > 0 && !roleIdList.Contains(roleId);
			if (needFallback)
			{
				roleId = roleIdList[0];
			}
			this.RoleScroll.RefreshByData(roleIdList, delegate
			{
				this.MarkSelectRoleToggle(roleId, needFallback);
				this.RefreshRole(roleId);
				this.RefreshIndexPair();
				this.OnRoleScrollValueChange();
			}, false);
		}

		// Token: 0x06033F77 RID: 212855 RVA: 0x00E89BA0 File Offset: 0x00E87DA0
		private void OnRoleScrollValueChange()
		{
			bool flag = false;
			bool flag2 = false;
			if (this.RedDotItemPair == null || !this.RedDotItemPair.Item1.IsValid() || !this.RedDotItemPair.Item2.IsValid())
			{
				this.RedDotButtonPair.Item1.SetUIActive(false);
				this.RedDotButtonPair.Item2.SetUIActive(false);
			}
			else
			{
				flag = (this.RoleScroll.IsItemFullyOutOfViewport(this.RedDotItemPair.Item1, this.SCROLL_TOLERANCE) == EOutOfBoundsType.OutOfBegin);
				flag2 = (this.RoleScroll.IsItemInViewport(this.RedDotItemPair.Item2, this.SCROLL_TOLERANCE) == EOutOfBoundsType.OutOfEnd);
				this.RedDotButtonPair.Item1.SetUIActive(flag);
				this.RedDotButtonPair.Item2.SetUIActive(flag2);
			}
			if (this.NewItemPair == null || !this.NewItemPair.Item1.IsValid() || !this.NewItemPair.Item2.IsValid())
			{
				this.NewButtonPair.Item1.SetUIActive(false);
				this.NewButtonPair.Item2.SetUIActive(false);
				return;
			}
			bool uiactive = this.RoleScroll.IsItemFullyOutOfViewport(this.NewItemPair.Item1, this.SCROLL_TOLERANCE) == EOutOfBoundsType.OutOfBegin && !flag;
			bool uiactive2 = this.RoleScroll.IsItemInViewport(this.NewItemPair.Item2, this.SCROLL_TOLERANCE) == EOutOfBoundsType.OutOfEnd && !flag2;
			this.NewButtonPair.Item1.SetUIActive(uiactive);
			this.NewButtonPair.Item2.SetUIActive(uiactive2);
		}

		// Token: 0x06033F78 RID: 212856 RVA: 0x00E89D24 File Offset: 0x00E87F24
		private void RefreshIndexPair()
		{
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			List<int> roleIdList = this.ActivityBaseData.RoleIdList;
			for (int i = 0; i < roleIdList.Count; i++)
			{
				int roleId = roleIdList[i];
				if (this.ActivityBaseData.GetRewardStateByRoleId(roleId) == ERoleTrialRewardState.FinishedAndUnClaimed)
				{
					list.Add(i);
				}
				if (this.ActivityBaseData.GetIsNewByRoleId(roleId))
				{
					list2.Add(i);
				}
			}
			if (list.Count > 0)
			{
				UUIItem itemByIndex = this.RoleScroll.GetItemByIndex(list[0]);
				GenericScrollViewNew<RoleItem, int> roleScroll = this.RoleScroll;
				List<int> list3 = list;
				this.RedDotItemPair = new Tuple<UUIItem, UUIItem>(itemByIndex, roleScroll.GetItemByIndex(list3[list3.Count - 1]));
			}
			else
			{
				this.RedDotItemPair = null;
			}
			if (list2.Count > 0)
			{
				UUIItem itemByIndex2 = this.RoleScroll.GetItemByIndex(list2[0]);
				GenericScrollViewNew<RoleItem, int> roleScroll2 = this.RoleScroll;
				List<int> list4 = list2;
				this.NewItemPair = new Tuple<UUIItem, UUIItem>(itemByIndex2, roleScroll2.GetItemByIndex(list4[list4.Count - 1]));
				return;
			}
			this.NewItemPair = null;
		}

		// Token: 0x06033F79 RID: 212857 RVA: 0x00E89E20 File Offset: 0x00E88020
		private void MarkRoleIdAsOld(int roleId)
		{
			if (this.ActivityBaseData.GetIsNewByRoleId(roleId))
			{
				this.ActivityBaseData.SaveRemindTime(roleId);
				int index = this.ActivityBaseData.RoleIdList.IndexOf(roleId);
				RoleItem scrollItemByIndex = this.RoleScroll.GetScrollItemByIndex(index);
				if (scrollItemByIndex != null)
				{
					scrollItemByIndex.MarkAsOld();
				}
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityBaseData.Id);
			}
		}

		// Token: 0x06033F7A RID: 212858 RVA: 0x00E89E8B File Offset: 0x00E8808B
		private void SetRoleId(int roleId)
		{
			this.CurrentRoleId = roleId;
			this.ActivityBaseData.CurrentRoleId = roleId;
		}

		// Token: 0x06033F7B RID: 212859 RVA: 0x00E89EA0 File Offset: 0x00E880A0
		private void RefreshRole(int roleId)
		{
			this.SetRoleId(roleId);
			RoleTrialInfo? roleTrialInfoConfigByRoleId = ActivityRoleTrialConfig.Instance.GetRoleTrialInfoConfigByRoleId(roleId);
			RoleTrialRoleConfig? roleTrialRoleConfigByRoleId = ActivityRoleTrialConfig.Instance.GetRoleTrialRoleConfigByRoleId(roleTrialInfoConfigByRoleId.Value.RoleId);
			string text = roleTrialRoleConfigByRoleId.Value.Introduction;
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
			this.RoleDescribeComponent.Update(roleTrialInfoConfigByRoleId.Value.RoleId);
			UUIItem roleItem = base.GetItem(22);
			USpineSkeletonAnimationComponent roleSpine = base.GetSpine(1);
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleTrialInfoConfigByRoleId.Value.RoleId);
			roleItem.SetUIActive(false);
			float[] param = roleTrialRoleConfigByRoleId.Value.SpineParam();
			base.SetSpineAssetByPath(roleTrialRoleConfigByRoleId.Value.FormationSpineAtlas, roleTrialRoleConfigByRoleId.Value.FormationSpineSkeletonData, roleSpine).Then(delegate()
			{
				roleItem.SetAnchorOffsetX(param[0]);
				roleItem.SetAnchorOffsetY(param[1]);
				roleItem.SetUIItemScale(new FVector(param[2], param[2], param[2]));
				roleItem.SetUIActive(true);
				roleSpine.SetAnimation(0, ESpineAnimation.Idle.ToString(), true);
			});
			UUITexture texture = base.GetTexture(12);
			UUITexture texture2 = base.GetTexture(13);
			if (!string.IsNullOrEmpty(roleTrialRoleConfigByRoleId.Value.RoleStand2))
			{
				base.SetTextureShowUntilLoaded(roleTrialRoleConfigByRoleId.Value.RoleStand2, texture, null);
				base.SetTextureShowUntilLoaded(roleTrialRoleConfigByRoleId.Value.RoleStand2, texture2, null);
			}
			this.RefreshUiConfigPerformance(roleTrialRoleConfigByRoleId.Value.UiConfigId);
			if (roleConfig != null)
			{
				int partyId = roleConfig.Value.PartyId;
				Influence? influenceConfig = InfluenceConfig.Instance.GetInfluenceConfig(partyId);
				if (!StringUtils.IsEmpty((influenceConfig != null) ? influenceConfig.GetValueOrDefault().Logo : null))
				{
					UUITexture texture3 = base.GetTexture(0);
					base.SetTextureByPath(influenceConfig.Value.Logo, texture3, null, null);
				}
			}
			UUIButtonComponent button = base.GetButton(19);
			bool flag2 = FunctionModel.Instance.IsOpen(10009);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(roleTrialInfoConfigByRoleId.Value.GachaId > 0 && flag2);
			}
			this.RefreshReward(roleId);
		}

		// Token: 0x06033F7C RID: 212860 RVA: 0x00E8A130 File Offset: 0x00E88330
		private void PlaySwitchSequence()
		{
			if (this.LevelSequenceSwitchPlayer.GetCurrentSequence() == "Switch")
			{
				this.LevelSequenceSwitchPlayer.ReplaySequenceByKey("Switch");
				return;
			}
			this.LevelSequenceSwitchPlayer.PlayLevelSequenceByName("Switch", false, null, false);
		}

		// Token: 0x06033F7D RID: 212861 RVA: 0x00E8A180 File Offset: 0x00E88380
		private void RefreshUiConfigPerformance(int uiConfigId)
		{
			RoleTrialUiConfig? roleTrialUiConfigById = ActivityRoleTrialConfig.Instance.GetRoleTrialUiConfigById(uiConfigId);
			base.GetTexture(14).SetColor(FColor.FromHex(((roleTrialUiConfigById != null) ? roleTrialUiConfigById.GetValueOrDefault().Color1 : null) ?? ""));
			base.GetTexture(15).SetColor(FColor.FromHex(((roleTrialUiConfigById != null) ? roleTrialUiConfigById.GetValueOrDefault().Color2 : null) ?? ""));
			base.GetTexture(16).SetColor(FColor.FromHex(((roleTrialUiConfigById != null) ? roleTrialUiConfigById.GetValueOrDefault().Color3 : null) ?? ""));
			base.GetTexture(17).SetColor(FColor.FromHex(((roleTrialUiConfigById != null) ? roleTrialUiConfigById.GetValueOrDefault().Color4 : null) ?? ""));
			base.GetTexture(18).SetColor(FColor.FromHex(((roleTrialUiConfigById != null) ? roleTrialUiConfigById.GetValueOrDefault().Color5 : null) ?? ""));
		}

		// Token: 0x06033F7E RID: 212862 RVA: 0x00E8A2A8 File Offset: 0x00E884A8
		private void RefreshReward(int roleId)
		{
			List<IItemGridData> rewardDataByRoleId = this.ActivityBaseData.GetRewardDataByRoleId(roleId);
			this.RewardListComponent.SetItemLayoutVisible(rewardDataByRoleId != null && rewardDataByRoleId.Count > 0);
			ERoleTrialRewardState rewardStateByRoleId = this.ActivityBaseData.GetRewardStateByRoleId(roleId);
			if (rewardDataByRoleId != null && rewardDataByRoleId.Count > 0)
			{
				this.RewardListComponent.RefreshItemLayout(rewardDataByRoleId, null);
			}
			base.GetItem(9).SetUIActive(rewardStateByRoleId == ERoleTrialRewardState.FinishedAndClaimed);
			base.GetItem(10).SetUIActive(rewardStateByRoleId == ERoleTrialRewardState.InActive);
			base.GetButton(11).RootUIComp.Get().SetUIActive(rewardStateByRoleId == ERoleTrialRewardState.FinishedAndUnClaimed);
		}

		// Token: 0x06033F7F RID: 212863 RVA: 0x00E8A344 File Offset: 0x00E88544
		private void SelectRoleToggle(int roleId)
		{
			int num = this.ActivityBaseData.RoleIdList.IndexOf(roleId);
			if (num >= 0)
			{
				RoleItem scrollItemByIndex = this.RoleScroll.GetScrollItemByIndex(num);
				if (scrollItemByIndex == null)
				{
					return;
				}
				scrollItemByIndex.SetToggleState(true, true);
			}
		}

		// Token: 0x06033F80 RID: 212864 RVA: 0x00E8A380 File Offset: 0x00E88580
		private void MarkSelectRoleToggle(int roleId, bool fireEvent)
		{
			List<int> roleIdList = this.ActivityBaseData.RoleIdList;
			int num = roleIdList.IndexOf(roleId);
			for (int i = 0; i < roleIdList.Count; i++)
			{
				RoleItem scrollItemByIndex = this.RoleScroll.GetScrollItemByIndex(i);
				if (scrollItemByIndex != null)
				{
					bool flag = scrollItemByIndex.IsToggleChecked();
					if (i == num)
					{
						if (!flag)
						{
							scrollItemByIndex.SetToggleState(true, fireEvent);
						}
					}
					else if (flag)
					{
						scrollItemByIndex.SetToggleState(false, false);
					}
				}
			}
		}

		// Token: 0x06033F81 RID: 212865 RVA: 0x00E8A3E8 File Offset: 0x00E885E8
		[NullableContext(1)]
		private ActivitySmallItemGrid InitGridItem()
		{
			return new ActivitySmallItemGrid();
		}

		// Token: 0x06033F82 RID: 212866 RVA: 0x00E8A3EF File Offset: 0x00E885EF
		[NullableContext(1)]
		private RoleItem InitRoleItem()
		{
			return new RoleItem(this.ActivityBaseData)
			{
				ToggleCallBack = new Action<int, bool>(this.ToggleCallBack)
			};
		}

		// Token: 0x06033F83 RID: 212867 RVA: 0x00E8A410 File Offset: 0x00E88610
		private void ToggleCallBack(int roleId, bool state)
		{
			int index = this.ActivityBaseData.RoleIdList.IndexOf(this.CurrentRoleId);
			RoleItem scrollItemByIndex = this.RoleScroll.GetScrollItemByIndex(index);
			if (scrollItemByIndex != null)
			{
				scrollItemByIndex.SetToggleState(false, false);
			}
			this.RefreshRole(roleId);
			this.MarkRoleIdAsOld(roleId);
			this.RefreshIndexPair();
			this.OnRoleScrollValueChange();
			this.PlaySwitchSequence();
		}

		// Token: 0x06033F84 RID: 212868 RVA: 0x00E8A470 File Offset: 0x00E88670
		private void ButtonRolePreviewClick()
		{
			RoleTrialInfo? roleTrialInfoConfigByRoleId = ActivityRoleTrialConfig.Instance.GetRoleTrialInfoConfigByRoleId(this.CurrentRoleId);
			int selectRoleId = (roleTrialInfoConfigByRoleId != null) ? roleTrialInfoConfigByRoleId.GetValueOrDefault().TrialRoleId : 0;
			List<int> roleTrialIdList = this.ActivityBaseData.RoleTrialIdList;
			RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, selectRoleId, roleTrialIdList, null, delegate(bool _, int _)
			{
				this.ActivityBaseData.SetRoleTrialState(ERoleTrialFlowState.RolePreview);
			});
		}

		// Token: 0x06033F85 RID: 212869 RVA: 0x00E8A4D9 File Offset: 0x00E886D9
		private void ButtonRewardClaimedClick()
		{
			ActivityRoleTrialController.Instance.RequestRoleInstanceReward(this.CurrentRoleId, this.ActivityBaseData.Id);
		}

		// Token: 0x06033F86 RID: 212870 RVA: 0x00E8A4F6 File Offset: 0x00E886F6
		private void ButtonInstanceEnterClick()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (RoleController.Instance.IsInRoleTrial())
				{
					GenericPromptController.Instance.ShowPromptByCode("TrialRoleDungeonsLimit", Array.Empty<object>());
					return;
				}
				int? instanceIdByRoleId = this.ActivityBaseData.GetInstanceIdByRoleId(this.CurrentRoleId);
				if (instanceIdByRoleId == null)
				{
					return;
				}
				this.ActivityBaseData.SetRoleTrialState(ERoleTrialFlowState.RoleInstance);
				ActivityRoleTrialController.Instance.EnterRoleTrialDungeonDirectly(instanceIdByRoleId.Value, this.ActivityBaseData.Id, this.CurrentRoleId).ContinueWith(delegate(bool success)
				{
					if (!success)
					{
						this.ActivityBaseData.SetRoleTrialState(ERoleTrialFlowState.ActivityOn);
					}
				});
			});
		}

		// Token: 0x06033F87 RID: 212871 RVA: 0x00E8A514 File Offset: 0x00E88714
		private void ButtonSkipGachaClick()
		{
			RoleTrialInfo? roleTrialInfoConfigByRoleId = ActivityRoleTrialConfig.Instance.GetRoleTrialInfoConfigByRoleId(this.CurrentRoleId);
			if (!GachaModel.Instance.CheckGachaValidByGachaId(roleTrialInfoConfigByRoleId.Value.GachaId))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_1400017_Text", Array.Empty<object>());
				return;
			}
			GachaController.Instance.OpenGachaView(roleTrialInfoConfigByRoleId.Value.GachaId);
		}

		// Token: 0x06033F88 RID: 212872 RVA: 0x00E8A57B File Offset: 0x00E8877B
		private void ButtonRedPointLeftClick()
		{
			if (this.RedDotItemPair != null && this.RedDotItemPair.Item1.IsValid())
			{
				this.RoleScroll.ScrollTo(this.RedDotItemPair.Item1, false);
			}
		}

		// Token: 0x06033F89 RID: 212873 RVA: 0x00E8A5AE File Offset: 0x00E887AE
		private void ButtonRedPointRightClick()
		{
			if (this.RedDotItemPair != null && this.RedDotItemPair.Item2.IsValid())
			{
				this.RoleScroll.ScrollToLeftByItem(this.RedDotItemPair.Item1);
			}
		}

		// Token: 0x06033F8A RID: 212874 RVA: 0x00E8A5E0 File Offset: 0x00E887E0
		private void ButtonNewPointLeftClick()
		{
			if (this.NewItemPair != null && this.NewItemPair.Item1.IsValid())
			{
				this.RoleScroll.ScrollTo(this.NewItemPair.Item1, false);
			}
		}

		// Token: 0x06033F8B RID: 212875 RVA: 0x00E8A613 File Offset: 0x00E88813
		private void ButtonNewPointRightClick()
		{
			if (this.NewItemPair != null && this.NewItemPair.Item2.IsValid())
			{
				this.RoleScroll.ScrollToLeftByItem(this.NewItemPair.Item1);
			}
		}

		// Token: 0x0401B7F3 RID: 112627
		public float SCROLL_TOLERANCE = 0.1f;

		// Token: 0x0401B7F9 RID: 112633
		[Nullable(1)]
		private GenericScrollViewNew<RoleItem, int> RoleScroll;

		// Token: 0x0401B7FA RID: 112634
		protected float ScrollDefaultWidth;

		// Token: 0x0401B7FB RID: 112635
		[Nullable(1)]
		private Tuple<UUIItem, UUIItem> RedDotItemPair;

		// Token: 0x0401B7FC RID: 112636
		[Nullable(1)]
		private Tuple<UUIItem, UUIItem> NewItemPair;

		// Token: 0x0401B7FD RID: 112637
		[Nullable(1)]
		private Tuple<UUIItem, UUIItem> RedDotButtonPair;

		// Token: 0x0401B7FE RID: 112638
		[Nullable(1)]
		private Tuple<UUIItem, UUIItem> NewButtonPair;

		// Token: 0x0401B7FF RID: 112639
		private bool HasSelectedNewRole;

		// Token: 0x0200ADE6 RID: 44518
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035BD0 RID: 220112
			public const int TexInfluence = 0;

			// Token: 0x04035BD1 RID: 220113
			public const int TexRoleSpine = 1;

			// Token: 0x04035BD2 RID: 220114
			public const int PanelRole = 2;

			// Token: 0x04035BD3 RID: 220115
			public const int TitleItem = 3;

			// Token: 0x04035BD4 RID: 220116
			public const int DescriptionItem = 4;

			// Token: 0x04035BD5 RID: 220117
			public const int RoleAttribute = 5;

			// Token: 0x04035BD6 RID: 220118
			public const int BtnRolePreview = 6;

			// Token: 0x04035BD7 RID: 220119
			public const int RewardListItem = 7;

			// Token: 0x04035BD8 RID: 220120
			public const int FunctionArea = 8;

			// Token: 0x04035BD9 RID: 220121
			public const int PanelDone = 9;

			// Token: 0x04035BDA RID: 220122
			public const int PanelOngoing = 10;

			// Token: 0x04035BDB RID: 220123
			public const int BtnReward = 11;

			// Token: 0x04035BDC RID: 220124
			public const int TexRoleBackground1 = 12;

			// Token: 0x04035BDD RID: 220125
			public const int TexRoleBackground2 = 13;

			// Token: 0x04035BDE RID: 220126
			public const int TexColor1 = 14;

			// Token: 0x04035BDF RID: 220127
			public const int TexColor2 = 15;

			// Token: 0x04035BE0 RID: 220128
			public const int TexColor3 = 16;

			// Token: 0x04035BE1 RID: 220129
			public const int TexColor4 = 17;

			// Token: 0x04035BE2 RID: 220130
			public const int TexColor5 = 18;

			// Token: 0x04035BE3 RID: 220131
			public const int SkipGachaButton = 19;

			// Token: 0x04035BE4 RID: 220132
			public const int ScrollView = 20;

			// Token: 0x04035BE5 RID: 220133
			public const int LayoutRoleItem = 21;

			// Token: 0x04035BE6 RID: 220134
			public const int RoleSpineItem = 22;

			// Token: 0x04035BE7 RID: 220135
			public const int BtnRedPointL = 23;

			// Token: 0x04035BE8 RID: 220136
			public const int BtnRedPointR = 24;

			// Token: 0x04035BE9 RID: 220137
			public const int BtnNewPointL = 25;

			// Token: 0x04035BEA RID: 220138
			public const int BtnNewPointR = 26;
		}
	}
}
