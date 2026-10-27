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
	// Token: 0x02006307 RID: 25351
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballRoleAttributeTabView : UiTabViewBase, IPinballRoleTabViewRoleChange, IPinballRoleTabViewRefresh
	{
		// Token: 0x0603FC8E RID: 261262 RVA: 0x00F6E844 File Offset: 0x00F6CA44
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

		// Token: 0x0603FC8F RID: 261263 RVA: 0x00F6EB48 File Offset: 0x00F6CD48
		protected override UniTask OnBeforeStartAsync()
		{
			PinballRoleAttributeTabView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballRoleAttributeTabView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FC90 RID: 261264 RVA: 0x00F6EB8C File Offset: 0x00F6CD8C
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

		// Token: 0x0603FC91 RID: 261265 RVA: 0x00F6EBCF File Offset: 0x00F6CDCF
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPinballRoleLevelUp, new Action<int, int, int>(this.OnPinballRoleLevelUp));
		}

		// Token: 0x0603FC92 RID: 261266 RVA: 0x00F6EBED File Offset: 0x00F6CDED
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPinballRoleLevelUp, new Action<int, int, int>(this.OnPinballRoleLevelUp));
		}

		// Token: 0x0603FC93 RID: 261267 RVA: 0x00F6EC0C File Offset: 0x00F6CE0C
		private UniTask InitTabItemsAsync()
		{
			PinballRoleAttributeTabView.<InitTabItemsAsync>d__20 <InitTabItemsAsync>d__;
			<InitTabItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTabItemsAsync>d__.<>4__this = this;
			<InitTabItemsAsync>d__.<>1__state = -1;
			<InitTabItemsAsync>d__.<>t__builder.Start<PinballRoleAttributeTabView.<InitTabItemsAsync>d__20>(ref <InitTabItemsAsync>d__);
			return <InitTabItemsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FC94 RID: 261268 RVA: 0x00F6EC50 File Offset: 0x00F6CE50
		private UniTask InitLevelUpItemsAsync()
		{
			PinballRoleAttributeTabView.<InitLevelUpItemsAsync>d__21 <InitLevelUpItemsAsync>d__;
			<InitLevelUpItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLevelUpItemsAsync>d__.<>4__this = this;
			<InitLevelUpItemsAsync>d__.<>1__state = -1;
			<InitLevelUpItemsAsync>d__.<>t__builder.Start<PinballRoleAttributeTabView.<InitLevelUpItemsAsync>d__21>(ref <InitLevelUpItemsAsync>d__);
			return <InitLevelUpItemsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FC95 RID: 261269 RVA: 0x00F6EC93 File Offset: 0x00F6CE93
		private void InitAttrLayout()
		{
			this.AttributeLayout = new GenericLayout<PinballAttributeItem, IPinballAttributeItemData>(base.GetLayoutBase(6), new Func<PinballAttributeItem>(this.CreateAttrItem), base.GetItem(7).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x0603FC96 RID: 261270 RVA: 0x00F6ECC6 File Offset: 0x00F6CEC6
		private void InitSkillScroll()
		{
			this.SkillDetailScrollView = new GenericScrollViewNew<PinballRoleSkillDetailItem, PinballSkillDisplayConfig>(base.GetScrollViewWithScrollbar(11), new Func<PinballRoleSkillDetailItem>(this.CreateSkillDetailItem), base.GetItem(12).GetOwner() as AUIBaseActor, false, null);
		}

		// Token: 0x0603FC97 RID: 261271 RVA: 0x00F6ECFB File Offset: 0x00F6CEFB
		private void InitRoleClassLayout()
		{
			this.RoleClassLayout = new GenericLayout<PinballRoleClassItem, IPinballRoleClassItemData>(base.GetLayoutBase(9), new Func<PinballRoleClassItem>(this.CreateRoleClassItem), base.GetItem(10).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x0603FC98 RID: 261272 RVA: 0x00F6ED30 File Offset: 0x00F6CF30
		public void RefreshView()
		{
			this.RefreshRoleInfo();
			this.RefreshCurTabView();
		}

		// Token: 0x0603FC99 RID: 261273 RVA: 0x00F6ED40 File Offset: 0x00F6CF40
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

		// Token: 0x0603FC9A RID: 261274 RVA: 0x00F6EE54 File Offset: 0x00F6D054
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

		// Token: 0x0603FC9B RID: 261275 RVA: 0x00F6EF94 File Offset: 0x00F6D194
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

		// Token: 0x0603FC9C RID: 261276 RVA: 0x00F6EFB4 File Offset: 0x00F6D1B4
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

		// Token: 0x0603FC9D RID: 261277 RVA: 0x00F6F0A9 File Offset: 0x00F6D2A9
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

		// Token: 0x0603FC9E RID: 261278 RVA: 0x00F6F0D0 File Offset: 0x00F6D2D0
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

		// Token: 0x0603FC9F RID: 261279 RVA: 0x00F6F147 File Offset: 0x00F6D347
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

		// Token: 0x0603FCA0 RID: 261280 RVA: 0x00F6F167 File Offset: 0x00F6D367
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

		// Token: 0x0603FCA1 RID: 261281 RVA: 0x00F6F188 File Offset: 0x00F6D388
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

		// Token: 0x0603FCA2 RID: 261282 RVA: 0x00F6F284 File Offset: 0x00F6D484
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

		// Token: 0x0603FCA3 RID: 261283 RVA: 0x00F6F3C4 File Offset: 0x00F6D5C4
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

		// Token: 0x0603FCA4 RID: 261284 RVA: 0x00F6F464 File Offset: 0x00F6D664
		public void RefreshByRoleChange()
		{
			this.RefreshView();
		}

		// Token: 0x0603FCA5 RID: 261285 RVA: 0x00F6F46C File Offset: 0x00F6D66C
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

		// Token: 0x0603FCA6 RID: 261286 RVA: 0x00F6F503 File Offset: 0x00F6D703
		private PinballAttributeItem CreateAttrItem()
		{
			return new PinballAttributeItem();
		}

		// Token: 0x0603FCA7 RID: 261287 RVA: 0x00F6F50A File Offset: 0x00F6D70A
		private PinballRoleSkillDetailItem CreateSkillDetailItem()
		{
			return new PinballRoleSkillDetailItem();
		}

		// Token: 0x0603FCA8 RID: 261288 RVA: 0x00F6F511 File Offset: 0x00F6D711
		private PinballRoleClassItem CreateRoleClassItem()
		{
			return new PinballRoleClassItem();
		}

		// Token: 0x0603FCA9 RID: 261289 RVA: 0x00F6F518 File Offset: 0x00F6D718
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

		// Token: 0x0603FCAA RID: 261290 RVA: 0x00F6F568 File Offset: 0x00F6D768
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

		// Token: 0x0603FCAB RID: 261291 RVA: 0x00F6F5C4 File Offset: 0x00F6D7C4
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

		// Token: 0x0603FCAC RID: 261292 RVA: 0x00F6F66C File Offset: 0x00F6D86C
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

		// Token: 0x040214A9 RID: 136361
		[Nullable(2)]
		protected IPinballRoleAttributeTabViewProxy Proxy;

		// Token: 0x040214AA RID: 136362
		private EPinballRoleAttributeTabIndex SelectedTabIndex = EPinballRoleAttributeTabIndex.None;

		// Token: 0x040214AB RID: 136363
		private readonly List<IPinballRoleAttributeTabItemData> TabItemDataList = new List<IPinballRoleAttributeTabItemData>();

		// Token: 0x040214AC RID: 136364
		private readonly List<IPinballAttributeItemData> RoleAttributeDataList = new List<IPinballAttributeItemData>();

		// Token: 0x040214AD RID: 136365
		private readonly List<PinballSkillDisplayConfig> RoleSkillDataList = new List<PinballSkillDisplayConfig>();

		// Token: 0x040214AE RID: 136366
		private readonly List<IPinballRoleClassItemData> RoleClassDataList = new List<IPinballRoleClassItemData>();

		// Token: 0x040214AF RID: 136367
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<PinballAttributeItem, IPinballAttributeItemData> AttributeLayout;

		// Token: 0x040214B0 RID: 136368
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<PinballRoleSkillDetailItem, PinballSkillDisplayConfig> SkillDetailScrollView;

		// Token: 0x040214B1 RID: 136369
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<PinballRoleClassItem, IPinballRoleClassItemData> RoleClassLayout;

		// Token: 0x040214B2 RID: 136370
		private readonly List<PinballRoleAttributeTabItem> TabItems = new List<PinballRoleAttributeTabItem>();

		// Token: 0x040214B3 RID: 136371
		private readonly List<UUIItem> TabRootItems = new List<UUIItem>();

		// Token: 0x040214B4 RID: 136372
		[Nullable(2)]
		private PinballRoleLevelUpButtonItem LevelUpButtonItem;

		// Token: 0x040214B5 RID: 136373
		[Nullable(2)]
		private PinballRoleLevelUpButtonItem SingleLevelUpButtonItem;

		// Token: 0x040214B6 RID: 136374
		[Nullable(2)]
		private PinballRoleLevelUpButtonItem MultipleLevelUpButtonItem;

		// Token: 0x0200C4FC RID: 50428
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B726 RID: 243494
			BdTexture,
			// Token: 0x0403B727 RID: 243495
			NameText,
			// Token: 0x0403B728 RID: 243496
			LevelText,
			// Token: 0x0403B729 RID: 243497
			AttrTabItem,
			// Token: 0x0403B72A RID: 243498
			SkillTabItem,
			// Token: 0x0403B72B RID: 243499
			AttrRootItem,
			// Token: 0x0403B72C RID: 243500
			AttrItemLayout,
			// Token: 0x0403B72D RID: 243501
			AttrTemplateItem,
			// Token: 0x0403B72E RID: 243502
			AttrDetailButton,
			// Token: 0x0403B72F RID: 243503
			RoleClassLayout,
			// Token: 0x0403B730 RID: 243504
			RoleClassTemplateItem,
			// Token: 0x0403B731 RID: 243505
			SkillDetailScrollView,
			// Token: 0x0403B732 RID: 243506
			SkillDetailTemplateItem,
			// Token: 0x0403B733 RID: 243507
			SingleLevelUpRootItem,
			// Token: 0x0403B734 RID: 243508
			MultipleLevelUpRootItem,
			// Token: 0x0403B735 RID: 243509
			SingleLevelUpItem,
			// Token: 0x0403B736 RID: 243510
			MultipleLevelUpItem,
			// Token: 0x0403B737 RID: 243511
			MaxLevelItem,
			// Token: 0x0403B738 RID: 243512
			LockItem,
			// Token: 0x0403B739 RID: 243513
			LockText
		}
	}
}
