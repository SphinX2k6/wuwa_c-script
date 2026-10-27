using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020024AB RID: 9387
[NullableContext(1)]
[Nullable(0)]
public class VisionEquipmentRecommendItem : UiPanelBase
{
	// Token: 0x06012D6C RID: 77164 RVA: 0x004A6434 File Offset: 0x004A4634
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIScrollViewWithScrollbarComponent))
		};
	}

	// Token: 0x06012D6D RID: 77165 RVA: 0x004A6588 File Offset: 0x004A4788
	protected override UniTask OnBeforeStartAsync()
	{
		VisionEquipmentRecommendItem.<OnBeforeStartAsync>d__28 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionEquipmentRecommendItem.<OnBeforeStartAsync>d__28>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012D6E RID: 77166 RVA: 0x004A65CC File Offset: 0x004A47CC
	private void InitAllLayouts()
	{
		UUILayoutBase layoutBase = base.GetLayoutBase(0);
		Func<VisionRecommendBranchFetterItem> gridProxyCreateFunction = new Func<VisionRecommendBranchFetterItem>(this.InitSystemRecommendItem);
		UUIItem item = base.GetItem(1);
		this.SystemRecommendLayout = new GenericLayout<VisionRecommendBranchFetterItem, VisionFetterRecommendInfo>(layoutBase, gridProxyCreateFunction, ((item != null) ? item.GetOwner() : null) as AUIBaseActor, false, true);
		UUILayoutBase layoutBase2 = base.GetLayoutBase(2);
		Func<VisionRecommendBranchFetterItem> gridProxyCreateFunction2 = new Func<VisionRecommendBranchFetterItem>(this.InitUsageRecommendItem);
		UUIItem item2 = base.GetItem(3);
		this.UsageRecommendLayout = new GenericLayout<VisionRecommendBranchFetterItem, VisionFetterRecommendInfo>(layoutBase2, gridProxyCreateFunction2, ((item2 != null) ? item2.GetOwner() : null) as AUIBaseActor, false, true);
	}

	// Token: 0x06012D6F RID: 77167 RVA: 0x004A6649 File Offset: 0x004A4849
	private VisionRecommendBranchFetterItem InitSystemRecommendItem()
	{
		VisionRecommendBranchFetterItem visionRecommendBranchFetterItem = new VisionRecommendBranchFetterItem();
		visionRecommendBranchFetterItem.OnSelectedCallback = new Action<int>(this.OnSystemRecommendItemSelected);
		visionRecommendBranchFetterItem.SetRoldId(this.CurrentRoleId);
		return visionRecommendBranchFetterItem;
	}

	// Token: 0x06012D70 RID: 77168 RVA: 0x004A666E File Offset: 0x004A486E
	private VisionRecommendBranchFetterItem InitUsageRecommendItem()
	{
		VisionRecommendBranchFetterItem visionRecommendBranchFetterItem = new VisionRecommendBranchFetterItem();
		visionRecommendBranchFetterItem.OnSelectedCallback = new Action<int>(this.OnUsageRecommendItemSelected);
		visionRecommendBranchFetterItem.SetRoldId(this.CurrentRoleId);
		return visionRecommendBranchFetterItem;
	}

	// Token: 0x06012D71 RID: 77169 RVA: 0x004A6694 File Offset: 0x004A4894
	private void OnSystemRecommendItemSelected(int index)
	{
		List<VisionFetterRecommendInfo> roleSystemFetterRecommendList = VisionRecommendModel.Instance.GetRoleSystemFetterRecommendList(this.CurrentRoleId);
		if (roleSystemFetterRecommendList == null || index < 0 || index >= roleSystemFetterRecommendList.Count)
		{
			return;
		}
		VisionFetterRecommendInfo info = roleSystemFetterRecommendList[index];
		GenericLayout<VisionRecommendBranchFetterItem, VisionFetterRecommendInfo> usageRecommendLayout = this.UsageRecommendLayout;
		if (usageRecommendLayout != null)
		{
			usageRecommendLayout.DeselectCurrentGridProxy();
		}
		GenericLayout<VisionRecommendBranchFetterItem, VisionFetterRecommendInfo> systemRecommendLayout = this.SystemRecommendLayout;
		if (systemRecommendLayout != null)
		{
			systemRecommendLayout.SelectGridProxy(index, false);
		}
		this.RefreshSelectedRecommendDetail(info);
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.StopPlayingSequence(false, true);
		}
		LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
		if (sequencePlayer2 == null)
		{
			return;
		}
		sequencePlayer2.PlayOrReplaySequenceByName("Switch", false, null);
	}

	// Token: 0x06012D72 RID: 77170 RVA: 0x004A6728 File Offset: 0x004A4928
	private void OnUsageRecommendItemSelected(int index)
	{
		List<VisionFetterRecommendInfo> roleUsageFetterRecommendList = VisionRecommendModel.Instance.GetRoleUsageFetterRecommendList(this.CurrentRoleId);
		if (roleUsageFetterRecommendList == null || index < 0 || index >= roleUsageFetterRecommendList.Count)
		{
			return;
		}
		VisionFetterRecommendInfo info = roleUsageFetterRecommendList[index];
		GenericLayout<VisionRecommendBranchFetterItem, VisionFetterRecommendInfo> systemRecommendLayout = this.SystemRecommendLayout;
		if (systemRecommendLayout != null)
		{
			systemRecommendLayout.DeselectCurrentGridProxy();
		}
		GenericLayout<VisionRecommendBranchFetterItem, VisionFetterRecommendInfo> usageRecommendLayout = this.UsageRecommendLayout;
		if (usageRecommendLayout != null)
		{
			usageRecommendLayout.SelectGridProxy(index, false);
		}
		this.RefreshSelectedRecommendDetail(info);
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.StopPlayingSequence(false, true);
		}
		LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
		if (sequencePlayer2 == null)
		{
			return;
		}
		sequencePlayer2.PlayOrReplaySequenceByName("Switch", false, null);
	}

	// Token: 0x06012D73 RID: 77171 RVA: 0x004A67BC File Offset: 0x004A49BC
	private void RefreshSelectedRecommendDetail(VisionFetterRecommendInfo info)
	{
		bool isOfficial = info.GetUsage() == 0;
		this.SetCurrentPlan(info, isOfficial);
	}

	// Token: 0x06012D74 RID: 77172 RVA: 0x004A67DB File Offset: 0x004A49DB
	protected override void OnBeforeDestroy()
	{
		VisionRecommendModel.Instance.CurrentSelectMainAttrArray = new List<VisionSelectRecommendData>();
		VisionRecommendModel.Instance.CurrentSelectSubAttrArray = new List<VisionSelectRecommendData>();
		VisionRecommendModel.Instance.CurrentMainPhantom = null;
	}

	// Token: 0x06012D75 RID: 77173 RVA: 0x004A6806 File Offset: 0x004A4A06
	public void BindOnChangeAttrCallBack(Action callback)
	{
		this.OnChangeAttrCallBack = callback;
	}

	// Token: 0x06012D76 RID: 77174 RVA: 0x004A6810 File Offset: 0x004A4A10
	public void ChangeCost(int cost, int roleId)
	{
		this.CurrentRoleId = roleId;
		this.TabCost = cost;
		this.RefreshAttrListData(roleId);
		VisionFetterRecommendInfo visionFetterRecommendInfo = this.CurrentPlanInfo ?? this.MatchDefaultPlan(roleId);
		if (visionFetterRecommendInfo == null)
		{
			return;
		}
		if (visionFetterRecommendInfo == this.CurrentPlanInfo)
		{
			this.OnChangeCurrentSelectAttr();
			return;
		}
		this.RefreshRecommendLayout(visionFetterRecommendInfo);
	}

	// Token: 0x06012D77 RID: 77175 RVA: 0x004A6860 File Offset: 0x004A4A60
	private void RefreshRecommendLayout(VisionFetterRecommendInfo info)
	{
		List<VisionFetterRecommendInfo> roleSystemFetterRecommendList = VisionRecommendModel.Instance.GetRoleSystemFetterRecommendList(this.CurrentRoleId);
		UUIItem item = base.GetItem(11);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		GenericLayout<VisionRecommendBranchFetterItem, VisionFetterRecommendInfo> systemRecommendLayout = this.SystemRecommendLayout;
		if (systemRecommendLayout != null)
		{
			systemRecommendLayout.RefreshByData(roleSystemFetterRecommendList, delegate
			{
				GenericLayout<VisionRecommendBranchFetterItem, VisionFetterRecommendInfo> systemRecommendLayout2 = this.SystemRecommendLayout;
				if (systemRecommendLayout2 == null)
				{
					return;
				}
				systemRecommendLayout2.SelectGridProxyByKey(info, true);
			}, false);
		}
		List<VisionFetterRecommendInfo> roleUsageFetterRecommendList = VisionRecommendModel.Instance.GetRoleUsageFetterRecommendList(this.CurrentRoleId);
		if (roleUsageFetterRecommendList != null && roleUsageFetterRecommendList.Count > 0)
		{
			UUIItem item2 = base.GetItem(12);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			GenericLayout<VisionRecommendBranchFetterItem, VisionFetterRecommendInfo> usageRecommendLayout = this.UsageRecommendLayout;
			if (usageRecommendLayout == null)
			{
				return;
			}
			usageRecommendLayout.RefreshByData(roleUsageFetterRecommendList, delegate
			{
				GenericLayout<VisionRecommendBranchFetterItem, VisionFetterRecommendInfo> usageRecommendLayout2 = this.UsageRecommendLayout;
				if (usageRecommendLayout2 == null)
				{
					return;
				}
				usageRecommendLayout2.SelectGridProxyByKey(info, true);
			}, false);
			return;
		}
		else
		{
			UUIItem item3 = base.GetItem(12);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(false);
			return;
		}
	}

	// Token: 0x06012D78 RID: 77176 RVA: 0x004A6928 File Offset: 0x004A4B28
	[NullableContext(2)]
	public void SetCurrentPlan(VisionFetterRecommendInfo planInfo, bool isOfficial)
	{
		bool flag = this.CurrentPlanInfo == planInfo;
		this.CurrentPlanInfo = planInfo;
		this.IsOfficialPlan = isOfficial;
		if (!flag)
		{
			this.CurrentSelectMainAttrArray.Clear();
			this.CurrentSelectSubAttrArray.Clear();
			this.CurrentSelectMainPhantom = null;
		}
		this.RefreshTopItemFetterIcons();
		this.RefreshAttrListData(this.CurrentRoleId);
		this.OnChangeCurrentSelectAttr();
		Action<VisionFetterRecommendInfo> onPlanChangedCallback = this.OnPlanChangedCallback;
		if (onPlanChangedCallback == null)
		{
			return;
		}
		onPlanChangedCallback(this.CurrentPlanInfo);
	}

	// Token: 0x06012D79 RID: 77177 RVA: 0x004A6999 File Offset: 0x004A4B99
	private void RefreshTopItemFetterIcons()
	{
		VisionEquipmentRecommendItemTop topItem = this.TopItem;
		if (topItem == null)
		{
			return;
		}
		topItem.Refresh(this.CurrentPlanInfo.BuildFetterItemDataList());
	}

	// Token: 0x06012D7A RID: 77178 RVA: 0x004A69B8 File Offset: 0x004A4BB8
	[NullableContext(2)]
	public VisionFetterRecommendInfo MatchDefaultPlan(int roleId)
	{
		List<VisionFetterRecommendInfo> roleFetterRecommendInfo = VisionRecommendModel.Instance.GetRoleFetterRecommendInfo(roleId);
		if (roleFetterRecommendInfo == null)
		{
			Log.Instance.Error(ELogModule.Phantom, ELogAuthor.CB, "recommendList is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		List<VisionFetterRecommendInfo> roleSystemFetterRecommendList = VisionRecommendModel.Instance.GetRoleSystemFetterRecommendList(roleId);
		int coreGroupId = this.FindCoreGroupId(roleId);
		VisionFetterRecommendInfo visionFetterRecommendInfo;
		if (coreGroupId == 0)
		{
			visionFetterRecommendInfo = ((roleSystemFetterRecommendList.Count > 0) ? roleSystemFetterRecommendList[0] : null);
		}
		else
		{
			List<VisionFetterRecommendInfo> list = (from info in roleFetterRecommendInfo
			where info.GetRecommendFetterGroupId() == coreGroupId
			select info).ToList<VisionFetterRecommendInfo>();
			if (list.Count == 0)
			{
				visionFetterRecommendInfo = ((roleSystemFetterRecommendList.Count > 0) ? roleSystemFetterRecommendList[0] : null);
			}
			else
			{
				List<int> activatedGroupIds = this.GetActivatedFetterGroupIds(roleId);
				visionFetterRecommendInfo = list.Find(delegate(VisionFetterRecommendInfo info)
				{
					int recommendFetterGroupId = info.GetRecommendFetterGroupId();
					int specialFetterSubGroupId = info.GetSpecialFetterSubGroupId();
					return activatedGroupIds.Contains(recommendFetterGroupId) && (specialFetterSubGroupId == 0 || activatedGroupIds.Contains(specialFetterSubGroupId));
				});
				if (visionFetterRecommendInfo == null)
				{
					visionFetterRecommendInfo = list.Find((VisionFetterRecommendInfo info) => info.GetUsage() == 0);
					if (visionFetterRecommendInfo == null)
					{
						list.Sort((VisionFetterRecommendInfo a, VisionFetterRecommendInfo b) => b.GetUsage() - a.GetUsage());
						visionFetterRecommendInfo = ((list.Count > 0) ? list[0] : null);
					}
				}
			}
		}
		return visionFetterRecommendInfo;
	}

	// Token: 0x06012D7B RID: 77179 RVA: 0x004A6B04 File Offset: 0x004A4D04
	private int FindCoreGroupId(int roleId)
	{
		List<int> activatedFetterGroupIds = this.GetActivatedFetterGroupIds(roleId);
		if (activatedFetterGroupIds.Count == 0)
		{
			return 0;
		}
		if (activatedFetterGroupIds.Count == 1)
		{
			return activatedFetterGroupIds[0];
		}
		if (activatedFetterGroupIds.Count != 2)
		{
			return 0;
		}
		int fetterGroupActivateCount = this.GetFetterGroupActivateCount(roleId, activatedFetterGroupIds[0]);
		int fetterGroupActivateCount2 = this.GetFetterGroupActivateCount(roleId, activatedFetterGroupIds[1]);
		if (fetterGroupActivateCount == fetterGroupActivateCount2)
		{
			return 0;
		}
		if (fetterGroupActivateCount <= fetterGroupActivateCount2)
		{
			return activatedFetterGroupIds[1];
		}
		return activatedFetterGroupIds[0];
	}

	// Token: 0x06012D7C RID: 77180 RVA: 0x004A6B78 File Offset: 0x004A4D78
	private List<int> GetActivatedFetterGroupIds(int roleId)
	{
		PhantomRoleEquipmentData battleDataById = PhantomBattleModel.Instance.GetBattleDataById(roleId);
		if (battleDataById == null)
		{
			return new List<int>();
		}
		List<int> incrIdList = battleDataById.GetIncrIdList();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (int num in incrIdList)
		{
			if (num != 0)
			{
				PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(num);
				if (phantomBattleData != null)
				{
					int fetterGroupId = phantomBattleData.GetFetterGroupId();
					int num2;
					dictionary[fetterGroupId] = (dictionary.TryGetValue(fetterGroupId, out num2) ? num2 : 0) + 1;
				}
			}
		}
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			Dictionary<int, int> dictionary2 = PhantomBattleConfig.Instance.GetFetterGroupById(key).FetterMap();
			if (dictionary2 != null)
			{
				foreach (KeyValuePair<int, int> keyValuePair2 in dictionary2)
				{
					int key2 = keyValuePair2.Key;
					if (value >= key2)
					{
						list.Add(key);
						break;
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06012D7D RID: 77181 RVA: 0x004A6CDC File Offset: 0x004A4EDC
	private int GetFetterGroupActivateCount(int roleId, int groupId)
	{
		PhantomRoleEquipmentData battleDataById = PhantomBattleModel.Instance.GetBattleDataById(roleId);
		if (battleDataById == null)
		{
			return 0;
		}
		List<int> incrIdList = battleDataById.GetIncrIdList();
		int num = 0;
		foreach (int num2 in incrIdList)
		{
			if (num2 != 0)
			{
				PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(num2);
				if (phantomBattleData != null && phantomBattleData.GetFetterGroupId() == groupId)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x06012D7E RID: 77182 RVA: 0x004A6D60 File Offset: 0x004A4F60
	public List<int> GetCurrentPlanFetterGroupIds()
	{
		VisionFetterRecommendInfo currentPlanInfo = this.CurrentPlanInfo;
		return ((currentPlanInfo != null) ? currentPlanInfo.BuildFetterList() : null) ?? new List<int>();
	}

	// Token: 0x06012D7F RID: 77183 RVA: 0x004A6D80 File Offset: 0x004A4F80
	public void RefreshSelectAllToggleState(List<int> currentFilteredGroupIds)
	{
		if (this.TopItem == null || this.CurrentPlanInfo == null)
		{
			VisionEquipmentRecommendItemTop topItem = this.TopItem;
			if (topItem == null)
			{
				return;
			}
			topItem.SetToggleState(EToggleState.ETT_UnChecked);
			return;
		}
		else
		{
			List<int> currentPlanFetterGroupIds = this.GetCurrentPlanFetterGroupIds();
			if (currentPlanFetterGroupIds.Count == 0)
			{
				this.TopItem.SetToggleState(EToggleState.ETT_UnChecked);
				return;
			}
			List<int> list = new List<int>(currentFilteredGroupIds);
			list.Sort((int a, int b) => a - b);
			List<int> list2 = new List<int>(currentPlanFetterGroupIds);
			list2.Sort((int a, int b) => a - b);
			bool flag = list.Count == list2.Count;
			if (flag)
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i] != list2[i])
					{
						flag = false;
						break;
					}
				}
			}
			this.TopItem.SetToggleState(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked);
			return;
		}
	}

	// Token: 0x06012D80 RID: 77184 RVA: 0x004A6E74 File Offset: 0x004A5074
	public void OnSelectAllBtnClick(EToggleState state)
	{
		List<int> currentPlanFetterGroupIds = this.GetCurrentPlanFetterGroupIds();
		if (state == EToggleState.ETT_UnChecked)
		{
			this.CurrentSelectMainAttrArray.Clear();
			this.CurrentSelectSubAttrArray.Clear();
			this.CurrentSelectMainPhantom = null;
			Action<List<int>, bool> onSelectAllCallback = this.OnSelectAllCallback;
			if (onSelectAllCallback != null)
			{
				onSelectAllCallback(currentPlanFetterGroupIds, false);
			}
		}
		else
		{
			Action<List<int>, bool> onSelectAllCallback2 = this.OnSelectAllCallback;
			if (onSelectAllCallback2 != null)
			{
				onSelectAllCallback2(currentPlanFetterGroupIds, true);
			}
		}
		this.RefreshAttrListData(this.CurrentRoleId);
		this.OnChangeCurrentSelectAttr();
	}

	// Token: 0x06012D81 RID: 77185 RVA: 0x004A6EE4 File Offset: 0x004A50E4
	public void OnMainAttrSelectAllBtnClick(EToggleState state)
	{
		this.CurrentSelectMainAttrArray.Clear();
		if (state == EToggleState.ETT_Checked)
		{
			foreach (RecommendItemData recommendItemData in this.CurrentShowMainAttrArray)
			{
				VisionSelectRecommendData visionSelectRecommendData = new VisionSelectRecommendData();
				visionSelectRecommendData.AttrId = recommendItemData.AttrId;
				visionSelectRecommendData.AddType = recommendItemData.AddType;
				this.CurrentSelectMainAttrArray.Add(visionSelectRecommendData);
			}
		}
		this.OnChangeCurrentSelectAttr();
	}

	// Token: 0x06012D82 RID: 77186 RVA: 0x004A6F70 File Offset: 0x004A5170
	private bool IsMainAttrAllSelected()
	{
		return this.CurrentShowMainAttrArray.Count > 0 && this.CurrentSelectMainAttrArray.Count == this.CurrentShowMainAttrArray.Count;
	}

	// Token: 0x06012D83 RID: 77187 RVA: 0x004A6F9C File Offset: 0x004A519C
	public void OnSubAttrSelectAllBtnClick(EToggleState state)
	{
		this.CurrentSelectSubAttrArray.Clear();
		if (state == EToggleState.ETT_Checked)
		{
			foreach (RecommendItemData recommendItemData in this.CurrentShowSubAttrArray)
			{
				VisionSelectRecommendData visionSelectRecommendData = new VisionSelectRecommendData();
				visionSelectRecommendData.AttrId = recommendItemData.AttrId;
				visionSelectRecommendData.AddType = recommendItemData.AddType;
				this.CurrentSelectSubAttrArray.Add(visionSelectRecommendData);
			}
		}
		this.OnChangeCurrentSelectAttr();
	}

	// Token: 0x06012D84 RID: 77188 RVA: 0x004A7028 File Offset: 0x004A5228
	private bool IsSubAttrAllSelected()
	{
		return this.CurrentShowSubAttrArray.Count > 0 && this.CurrentSelectSubAttrArray.Count == this.CurrentShowSubAttrArray.Count;
	}

	// Token: 0x06012D85 RID: 77189 RVA: 0x004A7054 File Offset: 0x004A5254
	public void CheckAndUpdateMainPhantomByFilter(List<int> currentSuitGroupIds, List<string> currentMonsterNames)
	{
		if (this.CurrentSelectMainPhantom == null)
		{
			return;
		}
		int fetterGroupId = this.CurrentSelectMainPhantom.FetterGroupId;
		bool flag = currentSuitGroupIds.Count == 0 || currentSuitGroupIds.Contains(fetterGroupId);
		bool flag2 = true;
		if (currentMonsterNames.Count > 0)
		{
			IReadOnlyList<PhantomItem> phantomItemByMonsterId = PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(this.CurrentSelectMainPhantom.MonsterId);
			if (phantomItemByMonsterId != null && phantomItemByMonsterId.Count > 0)
			{
				MonsterInfo? monsterInfoConfig = MonsterInfoConfig.Instance.GetMonsterInfoConfig(CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(this.CurrentSelectMainPhantom.MonsterId).Value.MonsterInfoId);
				if (monsterInfoConfig != null)
				{
					flag2 = currentMonsterNames.Contains(monsterInfoConfig.Value.Name);
				}
			}
		}
		if (!flag || !flag2)
		{
			this.CurrentSelectMainPhantom = null;
			this.RefreshAttrListData(this.CurrentRoleId);
			this.OnChangeCurrentSelectAttr();
		}
	}

	// Token: 0x06012D86 RID: 77190 RVA: 0x004A7128 File Offset: 0x004A5328
	private void RefreshAttrListData(int roleId)
	{
		int num = this.TabCost;
		if (this.CurrentSelectMainPhantom != null)
		{
			int rarity = PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(this.CurrentSelectMainPhantom.MonsterId)[0].Rarity;
			num = PhantomBattleConfig.Instance.GetPhantomRareConfig(rarity).Value.Cost;
		}
		this.CurrentCost = num;
		VisionAttrRecommendInfo roleCostAttrRecommendInfo = VisionRecommendModel.Instance.GetRoleCostAttrRecommendInfo(roleId, num);
		if (roleCostAttrRecommendInfo != null)
		{
			List<AttrRecommendInfo> mainAttrRecommendInfo = roleCostAttrRecommendInfo.GetMainAttrRecommendInfo();
			for (int i = this.CurrentSelectMainAttrArray.Count - 1; i >= 0; i--)
			{
				bool flag = false;
				foreach (AttrRecommendInfo attrRecommendInfo in mainAttrRecommendInfo)
				{
					if (attrRecommendInfo.GetAttrId() == this.CurrentSelectMainAttrArray[i].AttrId && attrRecommendInfo.GetAddType() == this.CurrentSelectMainAttrArray[i].AddType)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					this.CurrentSelectMainAttrArray.RemoveAt(i);
				}
			}
		}
		List<AttrRecommendInfo> subAttrData = this.GetSubAttrData();
		if (subAttrData != null)
		{
			for (int j = this.CurrentSelectSubAttrArray.Count - 1; j >= 0; j--)
			{
				bool flag2 = false;
				foreach (AttrRecommendInfo attrRecommendInfo2 in subAttrData)
				{
					if (attrRecommendInfo2.GetAttrId() == this.CurrentSelectSubAttrArray[j].AttrId && attrRecommendInfo2.GetAddType() == this.CurrentSelectSubAttrArray[j].AddType)
					{
						flag2 = true;
						break;
					}
				}
				if (!flag2)
				{
					this.CurrentSelectSubAttrArray.RemoveAt(j);
				}
			}
		}
	}

	// Token: 0x06012D87 RID: 77191 RVA: 0x004A7310 File Offset: 0x004A5510
	private void OnChangeCurrentSelectAttr()
	{
		this.RefreshMainPhantomRecommend();
		this.RefreshAttrRecommend();
		this.RefreshCostDistribution();
		if (this.OnChangeAttrCallBack != null)
		{
			this.OnChangeAttrCallBack();
		}
	}

	// Token: 0x06012D88 RID: 77192 RVA: 0x004A7338 File Offset: 0x004A5538
	private void RefreshMainPhantomRecommend()
	{
		MainRecommendPhantom mainPhantomRecommendItem = this.MainPhantomRecommendItem;
		if (mainPhantomRecommendItem != null)
		{
			mainPhantomRecommendItem.SetUiActive(true);
		}
		VisionRecommendModel.Instance.CurrentMainPhantom = this.CurrentSelectMainPhantom;
		int count = 2;
		VisionFetterRecommendInfo currentPlanInfo = this.CurrentPlanInfo;
		List<MainPhantomRecommendInfo> list = ((currentPlanInfo != null) ? currentPlanInfo.GetMainPhantomList().Take(count).ToList<MainPhantomRecommendInfo>() : null) ?? new List<MainPhantomRecommendInfo>();
		this.CurrentShowMainPhantomArray.Clear();
		foreach (MainPhantomRecommendInfo info in list)
		{
			MainPhantomItemData item = new MainPhantomItemData
			{
				Info = info,
				CurrentSelectMainPhantom = this.CurrentSelectMainPhantom,
				OnMainPhantomCallBack = new Action<IMainPhantomItemData>(this.OnSelectMainAttr)
			};
			this.CurrentShowMainPhantomArray.Add(item);
		}
		MainRecommendPhantom mainPhantomRecommendItem2 = this.MainPhantomRecommendItem;
		if (mainPhantomRecommendItem2 == null)
		{
			return;
		}
		mainPhantomRecommendItem2.Refresh(this.CurrentShowMainPhantomArray);
	}

	// Token: 0x06012D89 RID: 77193 RVA: 0x004A7420 File Offset: 0x004A5620
	private void RefreshAttrRecommend()
	{
		VisionRecommendModel.Instance.CurrentSelectMainAttrArray = this.CurrentSelectMainAttrArray;
		VisionRecommendModel.Instance.CurrentSelectSubAttrArray = this.CurrentSelectSubAttrArray;
		if (this.CurrentCost == 0)
		{
			this.RefreshMainAttrForAllCost();
		}
		else
		{
			this.RefreshMainAttrForSpecificCost(this.CurrentCost);
		}
		MainRecommendAttr mainRecommendAttr = this.MainRecommendAttr;
		if (mainRecommendAttr != null)
		{
			mainRecommendAttr.SetToggleAllState(this.IsMainAttrAllSelected());
		}
		this.RefreshSubAttrRecommend();
		SubRecommendAttr subRecommendAttr = this.SubRecommendAttr;
		if (subRecommendAttr == null)
		{
			return;
		}
		subRecommendAttr.SetToggleAllState(this.IsSubAttrAllSelected());
	}

	// Token: 0x06012D8A RID: 77194 RVA: 0x004A749C File Offset: 0x004A569C
	private void RefreshMainAttrForAllCost()
	{
		List<int> list = new List<int>();
		list.Add(4);
		list.Add(3);
		list.Add(1);
		this.CurrentShowMainAttrArray.Clear();
		List<IMainRecommendAttrItemData> data = (from cost in list
		select this.BuildMainAttrGroup(cost, true, new int?(1))).ToList<IMainRecommendAttrItemData>();
		MainRecommendAttr mainRecommendAttr = this.MainRecommendAttr;
		if (mainRecommendAttr == null)
		{
			return;
		}
		mainRecommendAttr.Refresh(data);
	}

	// Token: 0x06012D8B RID: 77195 RVA: 0x004A74F8 File Offset: 0x004A56F8
	private void RefreshMainAttrForSpecificCost(int cost)
	{
		this.CurrentShowMainAttrArray.Clear();
		MainRecommendAttr mainRecommendAttr = this.MainRecommendAttr;
		if (mainRecommendAttr == null)
		{
			return;
		}
		mainRecommendAttr.Refresh(new List<IMainRecommendAttrItemData>
		{
			this.BuildMainAttrGroup(cost, true, null)
		});
	}

	// Token: 0x06012D8C RID: 77196 RVA: 0x004A753C File Offset: 0x004A573C
	private IMainRecommendAttrItemData BuildMainAttrGroup(int cost, bool showUsage, int? limit = null)
	{
		List<AttrRecommendInfo> roleMainAttrRecommendListByPlan = VisionRecommendModel.Instance.GetRoleMainAttrRecommendListByPlan(this.CurrentRoleId, cost, this.IsOfficialPlan);
		List<RecommendItemData> list = new List<RecommendItemData>();
		if (roleMainAttrRecommendListByPlan.Count > 0)
		{
			List<AttrRecommendInfo> list2 = new List<AttrRecommendInfo>(roleMainAttrRecommendListByPlan);
			list2.Sort((AttrRecommendInfo a, AttrRecommendInfo b) => b.GetUsage() - a.GetUsage());
			foreach (AttrRecommendInfo attrRecommendInfo in ((limit != null) ? list2.Take(limit.Value).ToList<AttrRecommendInfo>() : list2))
			{
				RecommendItemData recommendItemData = new RecommendItemData();
				recommendItemData.AttrId = attrRecommendInfo.GetAttrId();
				recommendItemData.AddType = attrRecommendInfo.GetAddType();
				recommendItemData.CurrentSelectArray = this.CurrentSelectMainAttrArray;
				recommendItemData.UsageText = (showUsage ? attrRecommendInfo.GetUsageText() : "");
				recommendItemData.Type = 1;
				recommendItemData.OnSelectCallBack = new Action<RecommendItemData>(this.OnSelectAttr);
				list.Add(recommendItemData);
				this.CurrentShowMainAttrArray.Add(recommendItemData);
			}
		}
		return new MainRecommendAttrItemData
		{
			CostLabel = VisionEquipmentRecommendItem.costLabelTextIdMap.GetValueOrDefault(cost),
			Items = list
		};
	}

	// Token: 0x06012D8D RID: 77197 RVA: 0x004A7694 File Offset: 0x004A5894
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private List<AttrRecommendInfo> GetSubAttrData()
	{
		if (this.CurrentCost != 0)
		{
			VisionAttrRecommendInfo roleCostAttrRecommendInfo = VisionRecommendModel.Instance.GetRoleCostAttrRecommendInfo(this.CurrentRoleId, this.CurrentCost);
			if (!this.IsOfficialPlan)
			{
				if (roleCostAttrRecommendInfo == null)
				{
					return null;
				}
				return roleCostAttrRecommendInfo.GetUsageSubAttrRecommendInfo();
			}
			else
			{
				if (roleCostAttrRecommendInfo == null)
				{
					return null;
				}
				return roleCostAttrRecommendInfo.GetOfficialSubAttrRecommendInfo();
			}
		}
		else
		{
			Dictionary<int, VisionAttrRecommendInfo> roleAllAttrRecommendInfo = VisionRecommendModel.Instance.GetRoleAllAttrRecommendInfo(this.CurrentRoleId);
			if (roleAllAttrRecommendInfo == null)
			{
				return null;
			}
			foreach (KeyValuePair<int, VisionAttrRecommendInfo> keyValuePair in roleAllAttrRecommendInfo)
			{
				List<AttrRecommendInfo> list = this.IsOfficialPlan ? keyValuePair.Value.GetOfficialSubAttrRecommendInfo() : keyValuePair.Value.GetUsageSubAttrRecommendInfo();
				if (list.Count > 0)
				{
					return list;
				}
			}
			return null;
		}
	}

	// Token: 0x06012D8E RID: 77198 RVA: 0x004A7768 File Offset: 0x004A5968
	private void RefreshSubAttrRecommend()
	{
		List<AttrRecommendInfo> subAttrData = this.GetSubAttrData();
		if (subAttrData == null || subAttrData.Count == 0)
		{
			this.CurrentShowSubAttrArray.Clear();
			SubRecommendAttr subRecommendAttr = this.SubRecommendAttr;
			if (subRecommendAttr == null)
			{
				return;
			}
			subRecommendAttr.Refresh(this.CurrentShowSubAttrArray);
			return;
		}
		else
		{
			this.CurrentShowSubAttrArray.Clear();
			foreach (AttrRecommendInfo attrRecommendInfo in subAttrData)
			{
				RecommendItemData recommendItemData = new RecommendItemData();
				recommendItemData.AttrId = attrRecommendInfo.GetAttrId();
				recommendItemData.AddType = attrRecommendInfo.GetAddType();
				recommendItemData.CurrentSelectArray = this.CurrentSelectSubAttrArray;
				recommendItemData.UsageText = attrRecommendInfo.GetUsageText();
				recommendItemData.Type = 2;
				recommendItemData.OnSelectCallBack = new Action<RecommendItemData>(this.OnSelectAttr);
				this.CurrentShowSubAttrArray.Add(recommendItemData);
			}
			SubRecommendAttr subRecommendAttr2 = this.SubRecommendAttr;
			if (subRecommendAttr2 == null)
			{
				return;
			}
			subRecommendAttr2.Refresh(this.CurrentShowSubAttrArray);
			return;
		}
	}

	// Token: 0x06012D8F RID: 77199 RVA: 0x004A7860 File Offset: 0x004A5A60
	private void RefreshCostDistribution()
	{
		int firstCost = this.DetermineFirstVisionCost();
		UUIText text = base.GetText(8);
		if (text != null)
		{
			text.SetText(firstCost.ToString(), true);
		}
		List<int> data = this.DetermineOtherVisionCosts(firstCost);
		GenericLayout<CostDistributionItem, int> otherCostLayout = this.OtherCostLayout;
		if (otherCostLayout == null)
		{
			return;
		}
		otherCostLayout.RefreshByData(data, null, false);
	}

	// Token: 0x06012D90 RID: 77200 RVA: 0x004A78A9 File Offset: 0x004A5AA9
	private CostDistributionItem InitCostDistributionItem()
	{
		return new CostDistributionItem();
	}

	// Token: 0x06012D91 RID: 77201 RVA: 0x004A78B0 File Offset: 0x004A5AB0
	private int DetermineFirstVisionCost()
	{
		if (this.CurrentSelectMainPhantom != null)
		{
			return this.GetCostByMonsterId(this.CurrentSelectMainPhantom.MonsterId);
		}
		PhantomRoleEquipmentData battleDataById = PhantomBattleModel.Instance.GetBattleDataById(this.CurrentRoleId);
		if (battleDataById != null)
		{
			List<int> incrIdList = battleDataById.GetIncrIdList();
			if (incrIdList.Count > 0 && incrIdList[0] != 0)
			{
				PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(incrIdList[0]);
				if (phantomBattleData != null)
				{
					int monsterId = phantomBattleData.GetMonsterId(false);
					int fetterGroupId = phantomBattleData.GetFetterGroupId();
					foreach (IMainPhantomItemData mainPhantomItemData in this.CurrentShowMainPhantomArray)
					{
						if (mainPhantomItemData.Info.GetMonsterId() == monsterId && mainPhantomItemData.Info.GetFetterGroupId() == fetterGroupId)
						{
							return phantomBattleData.GetCost();
						}
					}
				}
			}
		}
		VisionFetterRecommendInfo currentPlanInfo = this.CurrentPlanInfo;
		List<MainPhantomRecommendInfo> list = ((currentPlanInfo != null) ? currentPlanInfo.GetMainPhantomList() : null) ?? new List<MainPhantomRecommendInfo>();
		if (list.Count > 0)
		{
			MainPhantomRecommendInfo mainPhantomRecommendInfo = list[0];
			for (int i = 1; i < list.Count; i++)
			{
				if (list[i].GetUsage() > mainPhantomRecommendInfo.GetUsage())
				{
					mainPhantomRecommendInfo = list[i];
				}
			}
			return this.GetCostByMonsterId(mainPhantomRecommendInfo.GetMonsterId());
		}
		return 0;
	}

	// Token: 0x06012D92 RID: 77202 RVA: 0x004A7A18 File Offset: 0x004A5C18
	private List<int> DetermineOtherVisionCosts(int firstCost)
	{
		int calabashLevel = CalabashModel.Instance.GetCalabashLevel();
		int visionRecommendRuleLevel = PhantomBattleConfig.Instance.GetVisionRecommendRuleLevel();
		if (calabashLevel < 2)
		{
			if (firstCost != 1)
			{
				return new List<int>
				{
					1,
					1,
					1,
					1
				};
			}
			return new List<int>
			{
				PhantomBattleDefine.costListRecommendLowLevel[0],
				1,
				1,
				1
			};
		}
		else
		{
			if (calabashLevel < visionRecommendRuleLevel)
			{
				List<int> list = new List<int>(PhantomBattleDefine.costListRecommendLowLevel);
				int num = list.IndexOf(firstCost);
				if (num >= 0)
				{
					list.RemoveAt(num);
				}
				else
				{
					list.RemoveAt(list.Count - 1);
				}
				list.Sort((int a, int b) => b - a);
				return list;
			}
			return this.GetHighLevelOtherCosts(firstCost);
		}
	}

	// Token: 0x06012D93 RID: 77203 RVA: 0x004A7AF0 File Offset: 0x004A5CF0
	private List<int> GetHighLevelOtherCosts(int firstCost)
	{
		if (this.CurrentPlanInfo == null)
		{
			return new List<int>();
		}
		List<ICostCombinationData> costCombinations = this.CurrentPlanInfo.GetCostCombinations();
		if (costCombinations.Count == 0)
		{
			return new List<int>();
		}
		int num = -1;
		List<int> result = new List<int>();
		foreach (ICostCombinationData costCombinationData in costCombinations)
		{
			int num2 = costCombinationData.Costs.IndexOf(firstCost);
			if (num2 >= 0 && costCombinationData.Usage > num)
			{
				num = costCombinationData.Usage;
				List<int> list = new List<int>(costCombinationData.Costs);
				list.RemoveAt(num2);
				result = list;
			}
		}
		return result;
	}

	// Token: 0x06012D94 RID: 77204 RVA: 0x004A7BA4 File Offset: 0x004A5DA4
	private int GetCostByMonsterId(int monsterId)
	{
		IReadOnlyList<PhantomItem> phantomItemByMonsterId = PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(monsterId);
		if (phantomItemByMonsterId != null && phantomItemByMonsterId.Count > 0)
		{
			PhantomRarity? phantomRareConfig = PhantomBattleConfig.Instance.GetPhantomRareConfig(phantomItemByMonsterId[0].Rarity);
			if (phantomRareConfig != null)
			{
				return phantomRareConfig.Value.Cost;
			}
		}
		return 0;
	}

	// Token: 0x06012D95 RID: 77205 RVA: 0x004A7C00 File Offset: 0x004A5E00
	private void OnSelectMainAttr(IMainPhantomItemData data)
	{
		if (this.CurrentSelectMainPhantom != null && data.Info.GetMonsterId() == this.CurrentSelectMainPhantom.MonsterId && data.Info.GetFetterGroupId() == this.CurrentSelectMainPhantom.FetterGroupId)
		{
			this.NotifyMainPhantomFilterChanged(data, true);
			this.ClearSelectMainPhantom(true);
			return;
		}
		this.CurrentSelectMainPhantom = new VisionMainSelectPhantomData
		{
			MonsterId = data.Info.GetMonsterId(),
			FetterGroupId = data.Info.GetFetterGroupId()
		};
		this.RefreshAttrListData(this.CurrentRoleId);
		this.OnChangeCurrentSelectAttr();
		this.NotifyMainPhantomFilterChanged(data, false);
	}

	// Token: 0x06012D96 RID: 77206 RVA: 0x004A7CA0 File Offset: 0x004A5EA0
	private void NotifyMainPhantomFilterChanged(IMainPhantomItemData data, bool isDeselect)
	{
		if (this.OnMainPhantomFilterChanged == null)
		{
			return;
		}
		int cost = 0;
		IReadOnlyList<PhantomItem> phantomItemByMonsterId = PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(data.Info.GetMonsterId());
		if (phantomItemByMonsterId != null && phantomItemByMonsterId.Count > 0)
		{
			int rarity = phantomItemByMonsterId[0].Rarity;
			PhantomRarity? phantomRareConfig = PhantomBattleConfig.Instance.GetPhantomRareConfig(rarity);
			if (phantomRareConfig != null)
			{
				cost = phantomRareConfig.Value.Cost;
			}
		}
		this.OnMainPhantomFilterChanged(new MainPhantomFilterChangedInfo
		{
			MonsterId = data.Info.GetMonsterId(),
			FetterGroupId = data.Info.GetFetterGroupId(),
			Cost = cost,
			IsDeselect = isDeselect
		});
	}

	// Token: 0x06012D97 RID: 77207 RVA: 0x004A7D54 File Offset: 0x004A5F54
	private void OnSelectAttr(RecommendItemData data)
	{
		if (data.Type == 1)
		{
			bool flag = false;
			int index = -1;
			for (int i = 0; i < this.CurrentSelectMainAttrArray.Count; i++)
			{
				if (this.CurrentSelectMainAttrArray[i].AttrId == data.AttrId && this.CurrentSelectMainAttrArray[i].AddType == data.AddType)
				{
					flag = true;
					index = i;
					break;
				}
			}
			if (flag)
			{
				this.CurrentSelectMainAttrArray.RemoveAt(index);
			}
			else
			{
				VisionSelectRecommendData visionSelectRecommendData = new VisionSelectRecommendData();
				visionSelectRecommendData.AttrId = data.AttrId;
				visionSelectRecommendData.AddType = data.AddType;
				this.CurrentSelectMainAttrArray.Add(visionSelectRecommendData);
			}
		}
		else
		{
			bool flag2 = false;
			int index2 = -1;
			for (int j = 0; j < this.CurrentSelectSubAttrArray.Count; j++)
			{
				if (this.CurrentSelectSubAttrArray[j].AttrId == data.AttrId && this.CurrentSelectSubAttrArray[j].AddType == data.AddType)
				{
					flag2 = true;
					index2 = j;
					break;
				}
			}
			if (flag2)
			{
				this.CurrentSelectSubAttrArray.RemoveAt(index2);
			}
			else
			{
				VisionSelectRecommendData visionSelectRecommendData2 = new VisionSelectRecommendData();
				visionSelectRecommendData2.AttrId = data.AttrId;
				visionSelectRecommendData2.AddType = data.AddType;
				this.CurrentSelectSubAttrArray.Add(visionSelectRecommendData2);
			}
		}
		this.OnChangeCurrentSelectAttr();
	}

	// Token: 0x06012D98 RID: 77208 RVA: 0x004A7EA8 File Offset: 0x004A60A8
	public void ClearSelectMainPhantom(bool bTriggerDeselectCallback = true)
	{
		bool flag = false;
		if (this.CurrentSelectMainPhantom != null)
		{
			this.CurrentSelectMainPhantom = null;
			flag = true;
		}
		this.RefreshAttrListData(this.CurrentRoleId);
		if (!flag || !bTriggerDeselectCallback)
		{
			this.OnChangeCurrentSelectAttr();
			return;
		}
		Action onDeselectMainPhantomCallback = this.OnDeselectMainPhantomCallback;
		if (onDeselectMainPhantomCallback == null)
		{
			return;
		}
		onDeselectMainPhantomCallback();
	}

	// Token: 0x06012D99 RID: 77209 RVA: 0x004A7EF0 File Offset: 0x004A60F0
	protected override void OnAfterShow()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(13);
		if (scrollViewWithScrollbar != null)
		{
			scrollViewWithScrollbar.SetScrollProgress(0f);
		}
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.StopPlayingSequence(false, true);
		}
		LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
		if (sequencePlayer2 == null)
		{
			return;
		}
		sequencePlayer2.PlayLevelSequenceByName("Open", false, null, false);
	}

	// Token: 0x06012D9A RID: 77210 RVA: 0x004A7F48 File Offset: 0x004A6148
	protected override UniTask OnBeforeHideAsync()
	{
		VisionEquipmentRecommendItem.<OnBeforeHideAsync>d__73 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<VisionEquipmentRecommendItem.<OnBeforeHideAsync>d__73>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04008DDE RID: 36318
	private const int CALABASH_LOW_LEVEL = 2;

	// Token: 0x04008DDF RID: 36319
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<int, string> costLabelTextIdMap = new Dictionary<int, string>
	{
		{
			4,
			"PhantomRecommend_4Cost"
		},
		{
			3,
			"PhantomRecommend_3Cost"
		},
		{
			1,
			"PhantomRecommend_1Cost"
		}
	};

	// Token: 0x04008DE0 RID: 36320
	[Nullable(2)]
	private VisionEquipmentRecommendItemTop TopItem;

	// Token: 0x04008DE1 RID: 36321
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionRecommendBranchFetterItem, VisionFetterRecommendInfo> SystemRecommendLayout;

	// Token: 0x04008DE2 RID: 36322
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionRecommendBranchFetterItem, VisionFetterRecommendInfo> UsageRecommendLayout;

	// Token: 0x04008DE3 RID: 36323
	private readonly List<VisionSelectRecommendData> CurrentSelectMainAttrArray = new List<VisionSelectRecommendData>();

	// Token: 0x04008DE4 RID: 36324
	private readonly List<VisionSelectRecommendData> CurrentSelectSubAttrArray = new List<VisionSelectRecommendData>();

	// Token: 0x04008DE5 RID: 36325
	[Nullable(2)]
	private VisionMainSelectPhantomData CurrentSelectMainPhantom;

	// Token: 0x04008DE6 RID: 36326
	private readonly List<RecommendItemData> CurrentShowMainAttrArray = new List<RecommendItemData>();

	// Token: 0x04008DE7 RID: 36327
	private readonly List<RecommendItemData> CurrentShowSubAttrArray = new List<RecommendItemData>();

	// Token: 0x04008DE8 RID: 36328
	private readonly List<IMainPhantomItemData> CurrentShowMainPhantomArray = new List<IMainPhantomItemData>();

	// Token: 0x04008DE9 RID: 36329
	[Nullable(2)]
	private MainRecommendPhantom MainPhantomRecommendItem;

	// Token: 0x04008DEA RID: 36330
	[Nullable(2)]
	private MainRecommendAttr MainRecommendAttr;

	// Token: 0x04008DEB RID: 36331
	[Nullable(2)]
	private SubRecommendAttr SubRecommendAttr;

	// Token: 0x04008DEC RID: 36332
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CostDistributionItem, int> OtherCostLayout;

	// Token: 0x04008DED RID: 36333
	private int TabCost;

	// Token: 0x04008DEE RID: 36334
	private int CurrentCost;

	// Token: 0x04008DEF RID: 36335
	private int CurrentRoleId;

	// Token: 0x04008DF0 RID: 36336
	[Nullable(2)]
	public VisionFetterRecommendInfo CurrentPlanInfo;

	// Token: 0x04008DF1 RID: 36337
	private bool IsOfficialPlan;

	// Token: 0x04008DF2 RID: 36338
	[Nullable(2)]
	private Action OnChangeAttrCallBack;

	// Token: 0x04008DF3 RID: 36339
	[Nullable(2)]
	public Action OnDeselectMainPhantomCallback;

	// Token: 0x04008DF4 RID: 36340
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IMainPhantomFilterChangedInfo> OnMainPhantomFilterChanged;

	// Token: 0x04008DF5 RID: 36341
	[Nullable(2)]
	public Action<VisionFetterRecommendInfo> OnPlanChangedCallback;

	// Token: 0x04008DF6 RID: 36342
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<List<int>, bool> OnSelectAllCallback;

	// Token: 0x04008DF7 RID: 36343
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x02008A2D RID: 35373
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CDD4 RID: 183764
		SystemRecommendLayout,
		// Token: 0x0402CDD5 RID: 183765
		SystemRecommendItem,
		// Token: 0x0402CDD6 RID: 183766
		UsageRecommendLayout,
		// Token: 0x0402CDD7 RID: 183767
		UsageRecommendItem,
		// Token: 0x0402CDD8 RID: 183768
		TogTop,
		// Token: 0x0402CDD9 RID: 183769
		PnlFirstVision,
		// Token: 0x0402CDDA RID: 183770
		PnlMainAttr,
		// Token: 0x0402CDDB RID: 183771
		PnlSubAttr,
		// Token: 0x0402CDDC RID: 183772
		TextFirstVisionCost,
		// Token: 0x0402CDDD RID: 183773
		OtherVisionCostLayout,
		// Token: 0x0402CDDE RID: 183774
		OtherVisionCostItem,
		// Token: 0x0402CDDF RID: 183775
		PnlSystemRecommend,
		// Token: 0x0402CDE0 RID: 183776
		PnlUsageRecommend,
		// Token: 0x0402CDE1 RID: 183777
		Scroll
	}
}
