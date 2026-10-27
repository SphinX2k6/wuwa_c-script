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
	// Token: 0x020061B3 RID: 25011
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewRoleTrial : ActivitySubViewBase
	{
		// Token: 0x1700920E RID: 37390
		// (get) Token: 0x0603F299 RID: 258713 RVA: 0x00F42227 File Offset: 0x00F40427
		protected new ActivityRoleTrialData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as ActivityRoleTrialData;
			}
		}

		// Token: 0x1700920F RID: 37391
		// (get) Token: 0x0603F29A RID: 258714 RVA: 0x00F42234 File Offset: 0x00F40434
		// (set) Token: 0x0603F29B RID: 258715 RVA: 0x00F4223C File Offset: 0x00F4043C
		private ActivityTitleTypeA TitleComponent { get; set; }

		// Token: 0x17009210 RID: 37392
		// (get) Token: 0x0603F29C RID: 258716 RVA: 0x00F42245 File Offset: 0x00F40445
		// (set) Token: 0x0603F29D RID: 258717 RVA: 0x00F4224D File Offset: 0x00F4044D
		private ActivityDescriptionTypeB DescriptionComponent { get; set; }

		// Token: 0x17009211 RID: 37393
		// (get) Token: 0x0603F29E RID: 258718 RVA: 0x00F42256 File Offset: 0x00F40456
		// (set) Token: 0x0603F29F RID: 258719 RVA: 0x00F4225E File Offset: 0x00F4045E
		private ActivityRoleDescribeComponent RoleDescribeComponent { get; set; }

		// Token: 0x17009212 RID: 37394
		// (get) Token: 0x0603F2A0 RID: 258720 RVA: 0x00F42267 File Offset: 0x00F40467
		// (set) Token: 0x0603F2A1 RID: 258721 RVA: 0x00F4226F File Offset: 0x00F4046F
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

		// Token: 0x17009213 RID: 37395
		// (get) Token: 0x0603F2A2 RID: 258722 RVA: 0x00F42278 File Offset: 0x00F40478
		// (set) Token: 0x0603F2A3 RID: 258723 RVA: 0x00F42280 File Offset: 0x00F40480
		private ActivityFunctionalTypeA FunctionalComponent { get; set; }

		// Token: 0x17009214 RID: 37396
		// (get) Token: 0x0603F2A4 RID: 258724 RVA: 0x00F42289 File Offset: 0x00F40489
		// (set) Token: 0x0603F2A5 RID: 258725 RVA: 0x00F42291 File Offset: 0x00F40491
		protected int CurrentRoleId { get; set; }

		// Token: 0x17009215 RID: 37397
		// (get) Token: 0x0603F2A6 RID: 258726 RVA: 0x00F4229A File Offset: 0x00F4049A
		// (set) Token: 0x0603F2A7 RID: 258727 RVA: 0x00F422A2 File Offset: 0x00F404A2
		private LevelSequencePlayer LevelSequenceSwitchPlayer { get; set; }

		// Token: 0x0603F2A8 RID: 258728 RVA: 0x00F422AC File Offset: 0x00F404AC
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

		// Token: 0x0603F2A9 RID: 258729 RVA: 0x00F42776 File Offset: 0x00F40976
		protected override void OnSetData()
		{
		}

		// Token: 0x0603F2AA RID: 258730 RVA: 0x00F42778 File Offset: 0x00F40978
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewRoleTrial.<OnBeforeStartAsync>d__41 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewRoleTrial.<OnBeforeStartAsync>d__41>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F2AB RID: 258731 RVA: 0x00F427BC File Offset: 0x00F409BC
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

		// Token: 0x0603F2AC RID: 258732 RVA: 0x00F4296C File Offset: 0x00F40B6C
		private void RefreshScrollWidth(int roleCount)
		{
			ULGUIBehaviour scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(20);
			UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(2);
			float width = Math.Min((base.GetItem(21).GetWidth() + horizontalLayout.GetSpacing()) * (float)roleCount, this.ScrollDefaultWidth);
			scrollViewWithScrollbar.RootUIComp.Get().SetWidth(width);
		}

		// Token: 0x0603F2AD RID: 258733 RVA: 0x00F429C0 File Offset: 0x00F40BC0
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

		// Token: 0x0603F2AE RID: 258734 RVA: 0x00F42A7C File Offset: 0x00F40C7C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnStateChange));
			EventSystem.Instance.Add<int>(EEventName.OnTrialRoleDataChanged, new Action<int>(this.OnStateChange));
		}

		// Token: 0x0603F2AF RID: 258735 RVA: 0x00F42AB6 File Offset: 0x00F40CB6
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnStateChange));
			EventSystem.Instance.Remove(EEventName.OnTrialRoleDataChanged, new Action<int>(this.OnStateChange));
		}

		// Token: 0x0603F2B0 RID: 258736 RVA: 0x00F42AF0 File Offset: 0x00F40CF0
		protected override void OnBeforeHide()
		{
			if (!this.ActivityBaseData.IsRoleInstanceOn())
			{
				this.ActivityBaseData.SetRoleTrialState(ERoleTrialFlowState.ActivityOff);
			}
		}

		// Token: 0x0603F2B1 RID: 258737 RVA: 0x00F42B0B File Offset: 0x00F40D0B
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

		// Token: 0x0603F2B2 RID: 258738 RVA: 0x00F42B40 File Offset: 0x00F40D40
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

		// Token: 0x0603F2B3 RID: 258739 RVA: 0x00F42B90 File Offset: 0x00F40D90
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

		// Token: 0x0603F2B4 RID: 258740 RVA: 0x00F42BED File Offset: 0x00F40DED
		protected override void OnTimer(float gap)
		{
			this.RefreshTimerText();
		}

		// Token: 0x0603F2B5 RID: 258741 RVA: 0x00F42BF8 File Offset: 0x00F40DF8
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

		// Token: 0x0603F2B6 RID: 258742 RVA: 0x00F42C38 File Offset: 0x00F40E38
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

		// Token: 0x0603F2B7 RID: 258743 RVA: 0x00F42CD4 File Offset: 0x00F40ED4
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

		// Token: 0x0603F2B8 RID: 258744 RVA: 0x00F42E58 File Offset: 0x00F41058
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

		// Token: 0x0603F2B9 RID: 258745 RVA: 0x00F42F54 File Offset: 0x00F41154
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

		// Token: 0x0603F2BA RID: 258746 RVA: 0x00F42FBF File Offset: 0x00F411BF
		private void SetRoleId(int roleId)
		{
			this.CurrentRoleId = roleId;
			this.ActivityBaseData.CurrentRoleId = roleId;
		}

		// Token: 0x0603F2BB RID: 258747 RVA: 0x00F42FD4 File Offset: 0x00F411D4
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

		// Token: 0x0603F2BC RID: 258748 RVA: 0x00F43264 File Offset: 0x00F41464
		private void PlaySwitchSequence()
		{
			if (this.LevelSequenceSwitchPlayer.GetCurrentSequence() == "Switch")
			{
				this.LevelSequenceSwitchPlayer.ReplaySequenceByKey("Switch");
				return;
			}
			this.LevelSequenceSwitchPlayer.PlayLevelSequenceByName("Switch", false, null, false);
		}

		// Token: 0x0603F2BD RID: 258749 RVA: 0x00F432B4 File Offset: 0x00F414B4
		private void RefreshUiConfigPerformance(int uiConfigId)
		{
			RoleTrialUiConfig? roleTrialUiConfigById = ActivityRoleTrialConfig.Instance.GetRoleTrialUiConfigById(uiConfigId);
			base.GetTexture(14).SetColor(FColor.FromHex(((roleTrialUiConfigById != null) ? roleTrialUiConfigById.GetValueOrDefault().Color1 : null) ?? ""));
			base.GetTexture(15).SetColor(FColor.FromHex(((roleTrialUiConfigById != null) ? roleTrialUiConfigById.GetValueOrDefault().Color2 : null) ?? ""));
			base.GetTexture(16).SetColor(FColor.FromHex(((roleTrialUiConfigById != null) ? roleTrialUiConfigById.GetValueOrDefault().Color3 : null) ?? ""));
			base.GetTexture(17).SetColor(FColor.FromHex(((roleTrialUiConfigById != null) ? roleTrialUiConfigById.GetValueOrDefault().Color4 : null) ?? ""));
			base.GetTexture(18).SetColor(FColor.FromHex(((roleTrialUiConfigById != null) ? roleTrialUiConfigById.GetValueOrDefault().Color5 : null) ?? ""));
		}

		// Token: 0x0603F2BE RID: 258750 RVA: 0x00F433DC File Offset: 0x00F415DC
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

		// Token: 0x0603F2BF RID: 258751 RVA: 0x00F43478 File Offset: 0x00F41678
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

		// Token: 0x0603F2C0 RID: 258752 RVA: 0x00F434B4 File Offset: 0x00F416B4
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

		// Token: 0x0603F2C1 RID: 258753 RVA: 0x00F4351C File Offset: 0x00F4171C
		[NullableContext(1)]
		private ActivitySmallItemGrid InitGridItem()
		{
			return new ActivitySmallItemGrid();
		}

		// Token: 0x0603F2C2 RID: 258754 RVA: 0x00F43523 File Offset: 0x00F41723
		[NullableContext(1)]
		private RoleItem InitRoleItem()
		{
			return new RoleItem(this.ActivityBaseData)
			{
				ToggleCallBack = new Action<int, bool>(this.ToggleCallBack)
			};
		}

		// Token: 0x0603F2C3 RID: 258755 RVA: 0x00F43544 File Offset: 0x00F41744
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

		// Token: 0x0603F2C4 RID: 258756 RVA: 0x00F435A4 File Offset: 0x00F417A4
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

		// Token: 0x0603F2C5 RID: 258757 RVA: 0x00F4360D File Offset: 0x00F4180D
		private void ButtonRewardClaimedClick()
		{
			ActivityRoleTrialController.Instance.RequestRoleInstanceReward(this.CurrentRoleId, this.ActivityBaseData.Id);
		}

		// Token: 0x0603F2C6 RID: 258758 RVA: 0x00F4362A File Offset: 0x00F4182A
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

		// Token: 0x0603F2C7 RID: 258759 RVA: 0x00F43648 File Offset: 0x00F41848
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

		// Token: 0x0603F2C8 RID: 258760 RVA: 0x00F436AF File Offset: 0x00F418AF
		private void ButtonRedPointLeftClick()
		{
			if (this.RedDotItemPair != null && this.RedDotItemPair.Item1.IsValid())
			{
				this.RoleScroll.ScrollTo(this.RedDotItemPair.Item1, false);
			}
		}

		// Token: 0x0603F2C9 RID: 258761 RVA: 0x00F436E2 File Offset: 0x00F418E2
		private void ButtonRedPointRightClick()
		{
			if (this.RedDotItemPair != null && this.RedDotItemPair.Item2.IsValid())
			{
				this.RoleScroll.ScrollToLeftByItem(this.RedDotItemPair.Item1);
			}
		}

		// Token: 0x0603F2CA RID: 258762 RVA: 0x00F43714 File Offset: 0x00F41914
		private void ButtonNewPointLeftClick()
		{
			if (this.NewItemPair != null && this.NewItemPair.Item1.IsValid())
			{
				this.RoleScroll.ScrollTo(this.NewItemPair.Item1, false);
			}
		}

		// Token: 0x0603F2CB RID: 258763 RVA: 0x00F43747 File Offset: 0x00F41947
		private void ButtonNewPointRightClick()
		{
			if (this.NewItemPair != null && this.NewItemPair.Item2.IsValid())
			{
				this.RoleScroll.ScrollToLeftByItem(this.NewItemPair.Item1);
			}
		}

		// Token: 0x04020EC6 RID: 134854
		public float SCROLL_TOLERANCE = 0.1f;

		// Token: 0x04020ECC RID: 134860
		[Nullable(1)]
		private GenericScrollViewNew<RoleItem, int> RoleScroll;

		// Token: 0x04020ECD RID: 134861
		protected float ScrollDefaultWidth;

		// Token: 0x04020ECE RID: 134862
		[Nullable(1)]
		private Tuple<UUIItem, UUIItem> RedDotItemPair;

		// Token: 0x04020ECF RID: 134863
		[Nullable(1)]
		private Tuple<UUIItem, UUIItem> NewItemPair;

		// Token: 0x04020ED0 RID: 134864
		[Nullable(1)]
		private Tuple<UUIItem, UUIItem> RedDotButtonPair;

		// Token: 0x04020ED1 RID: 134865
		[Nullable(1)]
		private Tuple<UUIItem, UUIItem> NewButtonPair;

		// Token: 0x04020ED2 RID: 134866
		private bool HasSelectedNewRole;

		// Token: 0x0200C3FF RID: 50175
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B26F RID: 242287
			public const int TexInfluence = 0;

			// Token: 0x0403B270 RID: 242288
			public const int TexRoleSpine = 1;

			// Token: 0x0403B271 RID: 242289
			public const int PanelRole = 2;

			// Token: 0x0403B272 RID: 242290
			public const int TitleItem = 3;

			// Token: 0x0403B273 RID: 242291
			public const int DescriptionItem = 4;

			// Token: 0x0403B274 RID: 242292
			public const int RoleAttribute = 5;

			// Token: 0x0403B275 RID: 242293
			public const int BtnRolePreview = 6;

			// Token: 0x0403B276 RID: 242294
			public const int RewardListItem = 7;

			// Token: 0x0403B277 RID: 242295
			public const int FunctionArea = 8;

			// Token: 0x0403B278 RID: 242296
			public const int PanelDone = 9;

			// Token: 0x0403B279 RID: 242297
			public const int PanelOngoing = 10;

			// Token: 0x0403B27A RID: 242298
			public const int BtnReward = 11;

			// Token: 0x0403B27B RID: 242299
			public const int TexRoleBackground1 = 12;

			// Token: 0x0403B27C RID: 242300
			public const int TexRoleBackground2 = 13;

			// Token: 0x0403B27D RID: 242301
			public const int TexColor1 = 14;

			// Token: 0x0403B27E RID: 242302
			public const int TexColor2 = 15;

			// Token: 0x0403B27F RID: 242303
			public const int TexColor3 = 16;

			// Token: 0x0403B280 RID: 242304
			public const int TexColor4 = 17;

			// Token: 0x0403B281 RID: 242305
			public const int TexColor5 = 18;

			// Token: 0x0403B282 RID: 242306
			public const int SkipGachaButton = 19;

			// Token: 0x0403B283 RID: 242307
			public const int ScrollView = 20;

			// Token: 0x0403B284 RID: 242308
			public const int LayoutRoleItem = 21;

			// Token: 0x0403B285 RID: 242309
			public const int RoleSpineItem = 22;

			// Token: 0x0403B286 RID: 242310
			public const int BtnRedPointL = 23;

			// Token: 0x0403B287 RID: 242311
			public const int BtnRedPointR = 24;

			// Token: 0x0403B288 RID: 242312
			public const int BtnNewPointL = 25;

			// Token: 0x0403B289 RID: 242313
			public const int BtnNewPointR = 26;
		}
	}
}
