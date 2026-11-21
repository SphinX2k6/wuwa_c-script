using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02005285 RID: 21125
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballRoleAttributeTabView : UiTabViewBase, IPinballRoleTabViewRoleChange, IPinballRoleTabViewRefresh
	{
		// Token: 0x0603494F RID: 215375 RVA: 0x00EB57A0 File Offset: 0x00EB39A0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 20;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnAttrDetailButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06034950 RID: 215376 RVA: 0x00EB5AA4 File Offset: 0x00EB3CA4
		protected override UniTask OnBeforeStartAsync()
		{
			PinballRoleAttributeTabView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballRoleAttributeTabView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034951 RID: 215377 RVA: 0x00EB5AE8 File Offset: 0x00EB3CE8
		protected override void OnBeforeShow()
		{
			this.Proxy = (IPinballRoleAttributeTabViewProxy)this.ExtraParams;
			this.RefreshView();
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x06034952 RID: 215378 RVA: 0x00EB5B2B File Offset: 0x00EB3D2B
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPinballRoleLevelUp, new Action<int, int, int>(this.OnPinballRoleLevelUp));
		}

		// Token: 0x06034953 RID: 215379 RVA: 0x00EB5B49 File Offset: 0x00EB3D49
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPinballRoleLevelUp, new Action<int, int, int>(this.OnPinballRoleLevelUp));
		}

		// Token: 0x06034954 RID: 215380 RVA: 0x00EB5B68 File Offset: 0x00EB3D68
		private UniTask InitTabItemsAsync()
		{
			PinballRoleAttributeTabView.<InitTabItemsAsync>d__20 <InitTabItemsAsync>d__;
			<InitTabItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTabItemsAsync>d__.<>4__this = this;
			<InitTabItemsAsync>d__.<>1__state = -1;
			<InitTabItemsAsync>d__.<>t__builder.Start<PinballRoleAttributeTabView.<InitTabItemsAsync>d__20>(ref <InitTabItemsAsync>d__);
			return <InitTabItemsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034955 RID: 215381 RVA: 0x00EB5BAC File Offset: 0x00EB3DAC
		private UniTask InitLevelUpItemsAsync()
		{
			PinballRoleAttributeTabView.<InitLevelUpItemsAsync>d__21 <InitLevelUpItemsAsync>d__;
			<InitLevelUpItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLevelUpItemsAsync>d__.<>4__this = this;
			<InitLevelUpItemsAsync>d__.<>1__state = -1;
			<InitLevelUpItemsAsync>d__.<>t__builder.Start<PinballRoleAttributeTabView.<InitLevelUpItemsAsync>d__21>(ref <InitLevelUpItemsAsync>d__);
			return <InitLevelUpItemsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034956 RID: 215382 RVA: 0x00EB5BEF File Offset: 0x00EB3DEF
		private void InitAttrLayout()
		{
			this.AttributeLayout = new GenericLayout<PinballAttributeItem, IPinballAttributeItemData>(base.GetLayoutBase(6), new Func<PinballAttributeItem>(this.CreateAttrItem), base.GetItem(7).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06034957 RID: 215383 RVA: 0x00EB5C22 File Offset: 0x00EB3E22
		private void InitSkillScroll()
		{
			this.SkillDetailScrollView = new GenericScrollViewNew<PinballRoleSkillDetailItem, PinballSkillDisplayConfig>(base.GetScrollViewWithScrollbar(11), new Func<PinballRoleSkillDetailItem>(this.CreateSkillDetailItem), base.GetItem(12).GetOwner() as AUIBaseActor, false, null);
		}

		// Token: 0x06034958 RID: 215384 RVA: 0x00EB5C57 File Offset: 0x00EB3E57
		private void InitRoleClassLayout()
		{
			this.RoleClassLayout = new GenericLayout<PinballRoleClassItem, IPinballRoleClassItemData>(base.GetLayoutBase(9), new Func<PinballRoleClassItem>(this.CreateRoleClassItem), base.GetItem(10).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06034959 RID: 215385 RVA: 0x00EB5C8C File Offset: 0x00EB3E8C
		public void RefreshView()
		{
			this.RefreshRoleInfo();
			this.RefreshCurTabView();
		}

		// Token: 0x0603495A RID: 215386 RVA: 0x00EB5C9C File Offset: 0x00EB3E9C
		public void RefreshRoleInfo()
		{
			if (this.Proxy == null)
			{
				return;
			}
			PinballRoleDataBase roleData = this.Proxy.GetRoleData();
			PinballRoleConfig? pinballRoleConfigById = PinballConfig.Instance.GetPinballRoleConfigById(roleData.GetId());
			if (pinballRoleConfigById == null)
			{
				return;
			}
			string roleNameByPinballRoleConfig = PinballModel.Instance.GetRoleNameByPinballRoleConfig(pinballRoleConfigById.Value);
			int level = roleData.GetLevel();
			int maxLevelByPinballRoleConfig = PinballModel.Instance.GetMaxLevelByPinballRoleConfig(pinballRoleConfigById.Value);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), roleNameByPinballRoleConfig, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Pinball_Character_level_01", new <>z__ReadOnlyArray<object>(new object[]
			{
				level.ToString(),
				maxLevelByPinballRoleConfig.ToString()
			}));
			int bd = pinballRoleConfigById.Value.Bd;
			PinballBdConfig? pinballRoleBdConfigById = PinballConfig.Instance.GetPinballRoleBdConfigById(bd);
			if (pinballRoleBdConfigById == null)
			{
				return;
			}
			base.SetTextureByPath(pinballRoleBdConfigById.Value.MiddleIcon, base.GetTexture(0), null, null);
			this.RefreshLevelUpItems();
			this.RefreshStateItem();
		}

		// Token: 0x0603495B RID: 215387 RVA: 0x00EB5DB0 File Offset: 0x00EB3FB0
		private void BuildClassDataList()
		{
			this.RoleClassDataList.Clear();
			if (this.Proxy == null)
			{
				return;
			}
			this.RoleClassDataList.Clear();
			PinballRoleConfig config = this.Proxy.GetRoleData().GetConfig();
			PinballBdConfig? pinballRoleBdConfigById = PinballConfig.Instance.GetPinballRoleBdConfigById(config.Bd);
			if (pinballRoleBdConfigById == null)
			{
				return;
			}
			PinballRoleClassItemData item = new PinballRoleClassItemData
			{
				Name = pinballRoleBdConfigById.Value.BdName,
				IconPath = pinballRoleBdConfigById.Value.Icon,
				BgColor = pinballRoleBdConfigById.Value.BgColor
			};
			this.RoleClassDataList.Add(item);
			int pinballClassLength = config.PinballClassLength;
			for (int i = 0; i < pinballClassLength; i++)
			{
				int id = config.PinballClass(i);
				PinballClassConfig? pinballClassConfigById = PinballConfig.Instance.GetPinballClassConfigById(id);
				if (pinballClassConfigById != null)
				{
					PinballRoleClassItemData item2 = new PinballRoleClassItemData
					{
						Name = pinballClassConfigById.Value.PinballClassName,
						IconPath = pinballClassConfigById.Value.Icon,
						BgColor = pinballClassConfigById.Value.BgColor
					};
					this.RoleClassDataList.Add(item2);
				}
			}
		}

		// Token: 0x0603495C RID: 215388 RVA: 0x00EB5EF0 File Offset: 0x00EB40F0
		public void RefreshClassLayout()
		{
			this.BuildClassDataList();
			GenericLayout<PinballRoleClassItem, IPinballRoleClassItemData> roleClassLayout = this.RoleClassLayout;
			if (roleClassLayout == null)
			{
				return;
			}
			roleClassLayout.RefreshByData(this.RoleClassDataList, null, false);
		}

		// Token: 0x0603495D RID: 215389 RVA: 0x00EB5F10 File Offset: 0x00EB4110
		private void BuildAttrItemDataList()
		{
			if (this.Proxy == null)
			{
				return;
			}
			this.RoleAttributeDataList.Clear();
			int id = this.Proxy.GetActivityData().Id;
			PinballActivity? pinballActivityConfigByActivityId = PinballConfig.Instance.GetPinballActivityConfigByActivityId(id);
			if (pinballActivityConfigByActivityId == null)
			{
				return;
			}
			int mainAttrShowListLength = pinballActivityConfigByActivityId.Value.MainAttrShowListLength;
			PinballRoleDataBase roleData = this.Proxy.GetRoleData();
			for (int i = 0; i < mainAttrShowListLength; i++)
			{
				int num = pinballActivityConfigByActivityId.Value.MainAttrShowList(i);
				PinballPropertyIndex? pinballPropertyIndexConfigById = PinballConfig.Instance.GetPinballPropertyIndexConfigById(num);
				if (pinballPropertyIndexConfigById != null)
				{
					int num2 = roleData.GetAttribute((EPinballAttr)num);
					if (num == 7)
					{
						num2 += 10000;
					}
					PinballAttributeItemData item = new PinballAttributeItemData
					{
						IsBgShow = (i % 2 == 1),
						AttributeConfig = pinballPropertyIndexConfigById.Value,
						AttributeValue = num2
					};
					this.RoleAttributeDataList.Add(item);
				}
			}
		}

		// Token: 0x0603495E RID: 215390 RVA: 0x00EB6005 File Offset: 0x00EB4205
		public void RefreshAttributeView()
		{
			this.BuildAttrItemDataList();
			GenericLayout<PinballAttributeItem, IPinballAttributeItemData> attributeLayout = this.AttributeLayout;
			if (attributeLayout != null)
			{
				attributeLayout.RefreshByData(this.RoleAttributeDataList, null, false);
			}
			this.RefreshClassLayout();
		}

		// Token: 0x0603495F RID: 215391 RVA: 0x00EB602C File Offset: 0x00EB422C
		private void BuildSkillDetailDataList()
		{
			if (this.Proxy == null)
			{
				return;
			}
			this.RoleSkillDataList.Clear();
			PinballRoleConfig config = this.Proxy.GetRoleData().GetConfig();
			int skillDisplayListLength = config.SkillDisplayListLength;
			for (int i = 0; i < skillDisplayListLength; i++)
			{
				int id = config.SkillDisplayList(i);
				PinballSkillDisplayConfig? pinballSkillDisplayConfigById = PinballConfig.Instance.GetPinballSkillDisplayConfigById(id);
				if (pinballSkillDisplayConfigById != null)
				{
					this.RoleSkillDataList.Add(pinballSkillDisplayConfigById.Value);
				}
			}
		}

		// Token: 0x06034960 RID: 215392 RVA: 0x00EB60A3 File Offset: 0x00EB42A3
		public void RefreshSkillTabView()
		{
			this.BuildSkillDetailDataList();
			GenericScrollViewNew<PinballRoleSkillDetailItem, PinballSkillDisplayConfig> skillDetailScrollView = this.SkillDetailScrollView;
			if (skillDetailScrollView == null)
			{
				return;
			}
			skillDetailScrollView.RefreshByData(this.RoleSkillDataList, null, false);
		}

		// Token: 0x06034961 RID: 215393 RVA: 0x00EB60C3 File Offset: 0x00EB42C3
		public void RefreshCurTabView()
		{
			if (this.SelectedTabIndex == EPinballRoleAttributeTabIndex.Attr)
			{
				this.RefreshAttributeView();
				return;
			}
			if (this.SelectedTabIndex == EPinballRoleAttributeTabIndex.Skill)
			{
				this.RefreshSkillTabView();
			}
		}

		// Token: 0x06034962 RID: 215394 RVA: 0x00EB60E4 File Offset: 0x00EB42E4
		[NullableContext(2)]
		private IPinballRoleLevelUpButtonItemData BuildLevelUpItemDataByTimes(int times, bool bToMaxLevel)
		{
			IPinballRoleAttributeTabViewProxy proxy = this.Proxy;
			PinballActivityData pinballActivityData = (proxy != null) ? proxy.GetActivityData() : null;
			IPinballRoleAttributeTabViewProxy proxy2 = this.Proxy;
			PinballRoleDataBase pinballRoleDataBase = (proxy2 != null) ? proxy2.GetRoleData() : null;
			PinballRoleConfig? pinballRoleConfig = (pinballRoleDataBase != null) ? new PinballRoleConfig?(pinballRoleDataBase.GetConfig()) : null;
			if (pinballActivityData == null || pinballRoleDataBase == null || pinballRoleConfig == null)
			{
				return null;
			}
			int id = pinballActivityData.Id;
			int roleLevelUpCostItemId = PinballModel.Instance.GetRoleLevelUpCostItemId(id);
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(roleLevelUpCostItemId, 0);
			int level = pinballRoleDataBase.GetLevel();
			int targetLevel = level + times;
			int roleLevelUpCostCount = PinballModel.Instance.GetRoleLevelUpCostCount(pinballRoleConfig.Value.GradeUpGroup, level, targetLevel);
			CostData costItemData = new CostData
			{
				ItemId = roleLevelUpCostItemId,
				Count = itemCountByConfigId,
				Cost = roleLevelUpCostCount
			};
			return new PinballRoleLevelUpButtonItemData
			{
				Times = times,
				IsToMaxLevel = bToMaxLevel,
				ConfirmDelegate = new Action<int>(this.OnLevelUpConfirm),
				CostItemData = costItemData
			};
		}

		// Token: 0x06034963 RID: 215395 RVA: 0x00EB61E0 File Offset: 0x00EB43E0
		public void RefreshLevelUpItems()
		{
			IPinballRoleAttributeTabViewProxy proxy = this.Proxy;
			PinballRoleDataBase pinballRoleDataBase = (proxy != null) ? proxy.GetRoleData() : null;
			if (pinballRoleDataBase == null)
			{
				return;
			}
			int id = pinballRoleDataBase.GetId();
			bool flag = pinballRoleDataBase.IsLocked();
			UUIItem item = base.GetItem(13);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			if (flag)
			{
				UUIItem item2 = base.GetItem(14);
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
				PinballLevelConfig? pinballLevelConfigByRoleId = PinballConfig.Instance.GetPinballLevelConfigByRoleId(id);
				if (pinballLevelConfigByRoleId == null)
				{
					return;
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(19), "Pinball_Character_lockedinfo", new <>z__ReadOnlySingleElementList<object>(ConfigMultiTextLang.GetLocalTextNew(pinballLevelConfigByRoleId.Value.Name, null)));
				return;
			}
			else
			{
				int level = pinballRoleDataBase.GetLevel();
				int maxLevelByPinballByRoleId = PinballModel.Instance.GetMaxLevelByPinballByRoleId(id);
				if (level != maxLevelByPinballByRoleId)
				{
					UUIItem item3 = base.GetItem(14);
					if (item3 != null)
					{
						item3.SetUIActive(true);
					}
					IPinballRoleLevelUpButtonItemData pinballRoleLevelUpButtonItemData = this.BuildLevelUpItemDataByTimes(1, false);
					int num = maxLevelByPinballByRoleId - level;
					IPinballRoleLevelUpButtonItemData pinballRoleLevelUpButtonItemData2;
					if (num < 10)
					{
						pinballRoleLevelUpButtonItemData2 = this.BuildLevelUpItemDataByTimes(num, true);
					}
					else
					{
						pinballRoleLevelUpButtonItemData2 = this.BuildLevelUpItemDataByTimes(10, false);
					}
					if (pinballRoleLevelUpButtonItemData != null)
					{
						PinballRoleLevelUpButtonItem singleLevelUpButtonItem = this.SingleLevelUpButtonItem;
						if (singleLevelUpButtonItem != null)
						{
							singleLevelUpButtonItem.Refresh(pinballRoleLevelUpButtonItemData);
						}
					}
					if (pinballRoleLevelUpButtonItemData2 != null)
					{
						PinballRoleLevelUpButtonItem multipleLevelUpButtonItem = this.MultipleLevelUpButtonItem;
						if (multipleLevelUpButtonItem == null)
						{
							return;
						}
						multipleLevelUpButtonItem.Refresh(pinballRoleLevelUpButtonItemData2);
					}
					return;
				}
				UUIItem item4 = base.GetItem(14);
				if (item4 == null)
				{
					return;
				}
				item4.SetUIActive(false);
				return;
			}
		}

		// Token: 0x06034964 RID: 215396 RVA: 0x00EB6320 File Offset: 0x00EB4520
		public void RefreshStateItem()
		{
			if (this.Proxy == null)
			{
				return;
			}
			PinballRoleDataBase roleData = this.Proxy.GetRoleData();
			if (roleData == null)
			{
				return;
			}
			IPinballRoleAttributeTabViewProxy proxy = this.Proxy;
			bool? flag;
			if (proxy == null)
			{
				flag = null;
			}
			else
			{
				PinballRoleDataBase roleData2 = proxy.GetRoleData();
				flag = ((roleData2 != null) ? new bool?(roleData2.IsLocked()) : null);
			}
			bool? flag2 = flag;
			bool valueOrDefault = flag2.GetValueOrDefault(true);
			bool uiactive = false;
			UUIItem item = base.GetItem(18);
			if (item != null)
			{
				item.SetUIActive(valueOrDefault);
			}
			if (!valueOrDefault)
			{
				uiactive = PinballModel.Instance.IsRoleMaxLevel(roleData.GetId());
			}
			UUIItem item2 = base.GetItem(17);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(uiactive);
		}

		// Token: 0x06034965 RID: 215397 RVA: 0x00EB63C0 File Offset: 0x00EB45C0
		public void RefreshByRoleChange()
		{
			this.RefreshView();
		}

		// Token: 0x06034966 RID: 215398 RVA: 0x00EB63C8 File Offset: 0x00EB45C8
		private void SelectTabIndex(EPinballRoleAttributeTabIndex tabIndex)
		{
			if (this.SelectedTabIndex == tabIndex)
			{
				return;
			}
			EPinballRoleAttributeTabIndex selectedTabIndex = this.SelectedTabIndex;
			this.SelectedTabIndex = tabIndex;
			this.TabItemDataList[(int)selectedTabIndex].IsSelected = false;
			this.TabItems[(int)selectedTabIndex].RefreshSelectState(false);
			this.TabItemDataList[(int)tabIndex].IsSelected = true;
			this.TabItems[(int)tabIndex].RefreshSelectState(false);
			this.TabRootItems[(int)selectedTabIndex].SetUIActive(false);
			this.TabRootItems[(int)tabIndex].SetUIActive(true);
			this.RefreshCurTabView();
		}

		// Token: 0x06034967 RID: 215399 RVA: 0x00EB645F File Offset: 0x00EB465F
		private PinballAttributeItem CreateAttrItem()
		{
			return new PinballAttributeItem();
		}

		// Token: 0x06034968 RID: 215400 RVA: 0x00EB6466 File Offset: 0x00EB4666
		private PinballRoleSkillDetailItem CreateSkillDetailItem()
		{
			return new PinballRoleSkillDetailItem();
		}

		// Token: 0x06034969 RID: 215401 RVA: 0x00EB646D File Offset: 0x00EB466D
		private PinballRoleClassItem CreateRoleClassItem()
		{
			return new PinballRoleClassItem();
		}

		// Token: 0x0603496A RID: 215402 RVA: 0x00EB6474 File Offset: 0x00EB4674
		private void OnLevelUpConfirm(int times)
		{
			if (this.Proxy == null)
			{
				return;
			}
			PinballActivityData activityData = this.Proxy.GetActivityData();
			if (activityData == null)
			{
				return;
			}
			PinballRoleDataBase roleData = this.Proxy.GetRoleData();
			if (roleData == null)
			{
				return;
			}
			this.OnLevelUpConfirmAsync(activityData.Id, roleData.GetId(), times).Forget();
		}

		// Token: 0x0603496B RID: 215403 RVA: 0x00EB64C4 File Offset: 0x00EB46C4
		private UniTask OnLevelUpConfirmAsync(int activityId, int roleId, int times)
		{
			PinballRoleAttributeTabView.<OnLevelUpConfirmAsync>d__43 <OnLevelUpConfirmAsync>d__;
			<OnLevelUpConfirmAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnLevelUpConfirmAsync>d__.<>4__this = this;
			<OnLevelUpConfirmAsync>d__.activityId = activityId;
			<OnLevelUpConfirmAsync>d__.roleId = roleId;
			<OnLevelUpConfirmAsync>d__.times = times;
			<OnLevelUpConfirmAsync>d__.<>1__state = -1;
			<OnLevelUpConfirmAsync>d__.<>t__builder.Start<PinballRoleAttributeTabView.<OnLevelUpConfirmAsync>d__43>(ref <OnLevelUpConfirmAsync>d__);
			return <OnLevelUpConfirmAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603496C RID: 215404 RVA: 0x00EB6520 File Offset: 0x00EB4720
		private void OnPinballRoleLevelUp(int activityId, int roleId, int addLevel)
		{
			IPinballRoleAttributeTabViewProxy proxy = this.Proxy;
			int? num;
			if (proxy == null)
			{
				num = null;
			}
			else
			{
				PinballActivityData activityData = proxy.GetActivityData();
				num = ((activityData != null) ? new int?(activityData.Id) : null);
			}
			int? num2 = num;
			if (!(activityId == num2.GetValueOrDefault() & num2 != null))
			{
				return;
			}
			IPinballRoleAttributeTabViewProxy proxy2 = this.Proxy;
			int? num3;
			if (proxy2 == null)
			{
				num3 = null;
			}
			else
			{
				PinballRoleDataBase roleData = proxy2.GetRoleData();
				num3 = ((roleData != null) ? new int?(roleData.GetId()) : null);
			}
			num2 = num3;
			if (!(roleId == num2.GetValueOrDefault() & num2 != null))
			{
				return;
			}
			this.RefreshView();
		}

		// Token: 0x0603496D RID: 215405 RVA: 0x00EB65C8 File Offset: 0x00EB47C8
		private void OnAttrDetailButtonClick()
		{
			if (this.Proxy == null)
			{
				return;
			}
			PinballActivityData activityData = this.Proxy.GetActivityData();
			if (activityData == null)
			{
				return;
			}
			List<IPinballAttributeDetailItemData> list = new List<IPinballAttributeDetailItemData>();
			int id = activityData.Id;
			PinballActivity? pinballActivityConfigByActivityId = PinballConfig.Instance.GetPinballActivityConfigByActivityId(id);
			if (pinballActivityConfigByActivityId == null)
			{
				return;
			}
			int attrShowListLength = pinballActivityConfigByActivityId.Value.AttrShowListLength;
			PinballRoleDataBase roleData = this.Proxy.GetRoleData();
			for (int i = 0; i < attrShowListLength; i++)
			{
				int id2 = pinballActivityConfigByActivityId.Value.AttrShowList(i);
				PinballPropertyIndex? pinballPropertyIndexConfigById = PinballConfig.Instance.GetPinballPropertyIndexConfigById(id2);
				if (pinballPropertyIndexConfigById != null)
				{
					PinballAttributeDetailItemData item = new PinballAttributeDetailItemData
					{
						IsBgShow = (i % 2 == 1),
						AttributeConfig = pinballPropertyIndexConfigById.Value,
						AttributeValue = roleData.GetAttribute((EPinballAttr)id2),
						IsExpanded = false
					};
					list.Add(item);
				}
			}
			UiManager.Instance.OpenView(EUiViewName.PinballAttributeDetailView, list, null);
		}

		// Token: 0x0401BDD8 RID: 114136
		[Nullable(2)]
		protected IPinballRoleAttributeTabViewProxy Proxy;

		// Token: 0x0401BDD9 RID: 114137
		private EPinballRoleAttributeTabIndex SelectedTabIndex = EPinballRoleAttributeTabIndex.None;

		// Token: 0x0401BDDA RID: 114138
		private readonly List<IPinballRoleAttributeTabItemData> TabItemDataList = new List<IPinballRoleAttributeTabItemData>();

		// Token: 0x0401BDDB RID: 114139
		private readonly List<IPinballAttributeItemData> RoleAttributeDataList = new List<IPinballAttributeItemData>();

		// Token: 0x0401BDDC RID: 114140
		private readonly List<PinballSkillDisplayConfig> RoleSkillDataList = new List<PinballSkillDisplayConfig>();

		// Token: 0x0401BDDD RID: 114141
		private readonly List<IPinballRoleClassItemData> RoleClassDataList = new List<IPinballRoleClassItemData>();

		// Token: 0x0401BDDE RID: 114142
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<PinballAttributeItem, IPinballAttributeItemData> AttributeLayout;

		// Token: 0x0401BDDF RID: 114143
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<PinballRoleSkillDetailItem, PinballSkillDisplayConfig> SkillDetailScrollView;

		// Token: 0x0401BDE0 RID: 114144
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<PinballRoleClassItem, IPinballRoleClassItemData> RoleClassLayout;

		// Token: 0x0401BDE1 RID: 114145
		private readonly List<PinballRoleAttributeTabItem> TabItems = new List<PinballRoleAttributeTabItem>();

		// Token: 0x0401BDE2 RID: 114146
		private readonly List<UUIItem> TabRootItems = new List<UUIItem>();

		// Token: 0x0401BDE3 RID: 114147
		[Nullable(2)]
		private PinballRoleLevelUpButtonItem LevelUpButtonItem;

		// Token: 0x0401BDE4 RID: 114148
		[Nullable(2)]
		private PinballRoleLevelUpButtonItem SingleLevelUpButtonItem;

		// Token: 0x0401BDE5 RID: 114149
		[Nullable(2)]
		private PinballRoleLevelUpButtonItem MultipleLevelUpButtonItem;

		// Token: 0x0200AEE3 RID: 44771
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04036088 RID: 221320
			BdTexture,
			// Token: 0x04036089 RID: 221321
			NameText,
			// Token: 0x0403608A RID: 221322
			LevelText,
			// Token: 0x0403608B RID: 221323
			AttrTabItem,
			// Token: 0x0403608C RID: 221324
			SkillTabItem,
			// Token: 0x0403608D RID: 221325
			AttrRootItem,
			// Token: 0x0403608E RID: 221326
			AttrItemLayout,
			// Token: 0x0403608F RID: 221327
			AttrTemplateItem,
			// Token: 0x04036090 RID: 221328
			AttrDetailButton,
			// Token: 0x04036091 RID: 221329
			RoleClassLayout,
			// Token: 0x04036092 RID: 221330
			RoleClassTemplateItem,
			// Token: 0x04036093 RID: 221331
			SkillDetailScrollView,
			// Token: 0x04036094 RID: 221332
			SkillDetailTemplateItem,
			// Token: 0x04036095 RID: 221333
			SingleLevelUpRootItem,
			// Token: 0x04036096 RID: 221334
			MultipleLevelUpRootItem,
			// Token: 0x04036097 RID: 221335
			SingleLevelUpItem,
			// Token: 0x04036098 RID: 221336
			MultipleLevelUpItem,
			// Token: 0x04036099 RID: 221337
			MaxLevelItem,
			// Token: 0x0403609A RID: 221338
			LockItem,
			// Token: 0x0403609B RID: 221339
			LockText
		}
	}
}
