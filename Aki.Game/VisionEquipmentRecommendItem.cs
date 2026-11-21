using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001992 RID: 6546
[NullableContext(1)]
[Nullable(0)]
public class VisionEquipmentRecommendItem : UiPanelBase
{
	// Token: 0x0601022D RID: 66093 RVA: 0x004B3F2C File Offset: 0x004B212C
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

	// Token: 0x0601022E RID: 66094 RVA: 0x004B4080 File Offset: 0x004B2280
	protected override UniTask OnBeforeStartAsync()
	{
		VisionEquipmentRecommendItem.<OnBeforeStartAsync>d__28 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionEquipmentRecommendItem.<OnBeforeStartAsync>d__28>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601022F RID: 66095 RVA: 0x004B40C4 File Offset: 0x004B22C4
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

	// Token: 0x06010230 RID: 66096 RVA: 0x004B4141 File Offset: 0x004B2341
	private VisionRecommendBranchFetterItem InitSystemRecommendItem()
	{
		VisionRecommendBranchFetterItem visionRecommendBranchFetterItem = new VisionRecommendBranchFetterItem();
		visionRecommendBranchFetterItem.OnSelectedCallback = new Action<int>(this.OnSystemRecommendItemSelected);
		visionRecommendBranchFetterItem.SetRoldId(this.CurrentRoleId);
		return visionRecommendBranchFetterItem;
	}

	// Token: 0x06010231 RID: 66097 RVA: 0x004B4166 File Offset: 0x004B2366
	private VisionRecommendBranchFetterItem InitUsageRecommendItem()
	{
		VisionRecommendBranchFetterItem visionRecommendBranchFetterItem = new VisionRecommendBranchFetterItem();
		visionRecommendBranchFetterItem.OnSelectedCallback = new Action<int>(this.OnUsageRecommendItemSelected);
		visionRecommendBranchFetterItem.SetRoldId(this.CurrentRoleId);
		return visionRecommendBranchFetterItem;
	}

	// Token: 0x06010232 RID: 66098 RVA: 0x004B418C File Offset: 0x004B238C
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

	// Token: 0x06010233 RID: 66099 RVA: 0x004B4220 File Offset: 0x004B2420
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

	// Token: 0x06010234 RID: 66100 RVA: 0x004B42B4 File Offset: 0x004B24B4
	private void RefreshSelectedRecommendDetail(VisionFetterRecommendInfo info)
	{
		bool isOfficial = info.GetUsage() == 0;
		this.SetCurrentPlan(info, isOfficial);
	}

	// Token: 0x06010235 RID: 66101 RVA: 0x004B42D3 File Offset: 0x004B24D3
	protected override void OnBeforeDestroy()
	{
		VisionRecommendModel.Instance.CurrentSelectMainAttrArray = new List<VisionSelectRecommendData>();
		VisionRecommendModel.Instance.CurrentSelectSubAttrArray = new List<VisionSelectRecommendData>();
		VisionRecommendModel.Instance.CurrentMainPhantom = null;
	}

	// Token: 0x06010236 RID: 66102 RVA: 0x004B42FE File Offset: 0x004B24FE
	public void BindOnChangeAttrCallBack(Action callback)
	{
		this.OnChangeAttrCallBack = callback;
	}

	// Token: 0x06010237 RID: 66103 RVA: 0x004B4308 File Offset: 0x004B2508
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

	// Token: 0x06010238 RID: 66104 RVA: 0x004B4358 File Offset: 0x004B2558
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

	// Token: 0x06010239 RID: 66105 RVA: 0x004B4420 File Offset: 0x004B2620
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

	// Token: 0x0601023A RID: 66106 RVA: 0x004B4491 File Offset: 0x004B2691
	private void RefreshTopItemFetterIcons()
	{
		VisionEquipmentRecommendItemTop topItem = this.TopItem;
		if (topItem == null)
		{
			return;
		}
		topItem.Refresh(this.CurrentPlanInfo.BuildFetterItemDataList());
	}

	// Token: 0x0601023B RID: 66107 RVA: 0x004B44B0 File Offset: 0x004B26B0
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
		int num = this.FindCoreGroupId(roleId);
		VisionFetterRecommendInfo visionFetterRecommendInfo;
		if (num == 0)
		{
			visionFetterRecommendInfo = ((roleSystemFetterRecommendList.Count > 0) ? roleSystemFetterRecommendList[0] : null);
		}
		else
		{
			List<VisionFetterRecommendInfo> list = new List<VisionFetterRecommendInfo>();
			foreach (VisionFetterRecommendInfo visionFetterRecommendInfo2 in roleFetterRecommendInfo)
			{
				if (visionFetterRecommendInfo2.GetRecommendFetterGroupId() == num)
				{
					list.Add(visionFetterRecommendInfo2);
				}
			}
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

	// Token: 0x0601023C RID: 66108 RVA: 0x004B462C File Offset: 0x004B282C
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

	// Token: 0x0601023D RID: 66109 RVA: 0x004B46A0 File Offset: 0x004B28A0
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

	// Token: 0x0601023E RID: 66110 RVA: 0x004B4804 File Offset: 0x004B2A04
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

	// Token: 0x0601023F RID: 66111 RVA: 0x004B4888 File Offset: 0x004B2A88
	public List<int> GetCurrentPlanFetterGroupIds()
	{
		VisionFetterRecommendInfo currentPlanInfo = this.CurrentPlanInfo;
		return ((currentPlanInfo != null) ? currentPlanInfo.BuildFetterList() : null) ?? new List<int>();
	}

	// Token: 0x06010240 RID: 66112 RVA: 0x004B48A8 File Offset: 0x004B2AA8
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

	// Token: 0x06010241 RID: 66113 RVA: 0x004B499C File Offset: 0x004B2B9C
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

	// Token: 0x06010242 RID: 66114 RVA: 0x004B4A0C File Offset: 0x004B2C0C
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

	// Token: 0x06010243 RID: 66115 RVA: 0x004B4A98 File Offset: 0x004B2C98
	private bool IsMainAttrAllSelected()
	{
		return this.CurrentShowMainAttrArray.Count > 0 && this.CurrentSelectMainAttrArray.Count == this.CurrentShowMainAttrArray.Count;
	}

	// Token: 0x06010244 RID: 66116 RVA: 0x004B4AC4 File Offset: 0x004B2CC4
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

	// Token: 0x06010245 RID: 66117 RVA: 0x004B4B50 File Offset: 0x004B2D50
	private bool IsSubAttrAllSelected()
	{
		return this.CurrentShowSubAttrArray.Count > 0 && this.CurrentSelectSubAttrArray.Count == this.CurrentShowSubAttrArray.Count;
	}

	// Token: 0x06010246 RID: 66118 RVA: 0x004B4B7C File Offset: 0x004B2D7C
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

	// Token: 0x06010247 RID: 66119 RVA: 0x004B4C50 File Offset: 0x004B2E50
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

	// Token: 0x06010248 RID: 66120 RVA: 0x004B4E38 File Offset: 0x004B3038
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

	// Token: 0x06010249 RID: 66121 RVA: 0x004B4E60 File Offset: 0x004B3060
	private void RefreshMainPhantomRecommend()
	{
		MainRecommendPhantom mainPhantomRecommendItem = this.MainPhantomRecommendItem;
		if (mainPhantomRecommendItem != null)
		{
			mainPhantomRecommendItem.SetUiActive(true);
		}
		VisionRecommendModel.Instance.CurrentMainPhantom = this.CurrentSelectMainPhantom;
		int num = 2;
		VisionFetterRecommendInfo currentPlanInfo = this.CurrentPlanInfo;
		List<MainPhantomRecommendInfo> list = new List<MainPhantomRecommendInfo>();
		if (currentPlanInfo != null)
		{
			foreach (MainPhantomRecommendInfo item in currentPlanInfo.GetMainPhantomList())
			{
				if (list.Count >= num)
				{
					break;
				}
				list.Add(item);
			}
		}
		this.CurrentShowMainPhantomArray.Clear();
		foreach (MainPhantomRecommendInfo info in list)
		{
			MainPhantomItemData item2 = new MainPhantomItemData
			{
				Info = info,
				CurrentSelectMainPhantom = this.CurrentSelectMainPhantom,
				OnMainPhantomCallBack = new Action<IMainPhantomItemData>(this.OnSelectMainAttr)
			};
			this.CurrentShowMainPhantomArray.Add(item2);
		}
		MainRecommendPhantom mainPhantomRecommendItem2 = this.MainPhantomRecommendItem;
		if (mainPhantomRecommendItem2 == null)
		{
			return;
		}
		mainPhantomRecommendItem2.Refresh(this.CurrentShowMainPhantomArray);
	}

	// Token: 0x0601024A RID: 66122 RVA: 0x004B4F88 File Offset: 0x004B3188
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

	// Token: 0x0601024B RID: 66123 RVA: 0x004B5004 File Offset: 0x004B3204
	private void RefreshMainAttrForAllCost()
	{
		List<int> list = new List<int>();
		list.Add(4);
		list.Add(3);
		list.Add(1);
		this.CurrentShowMainAttrArray.Clear();
		List<IMainRecommendAttrItemData> list2 = new List<IMainRecommendAttrItemData>();
		foreach (int cost in list)
		{
			list2.Add(this.BuildMainAttrGroup(cost, true, new int?(1)));
		}
		MainRecommendAttr mainRecommendAttr = this.MainRecommendAttr;
		if (mainRecommendAttr == null)
		{
			return;
		}
		mainRecommendAttr.Refresh(list2);
	}

	// Token: 0x0601024C RID: 66124 RVA: 0x004B509C File Offset: 0x004B329C
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

	// Token: 0x0601024D RID: 66125 RVA: 0x004B50E0 File Offset: 0x004B32E0
	private IMainRecommendAttrItemData BuildMainAttrGroup(int cost, bool showUsage, int? limit = null)
	{
		List<AttrRecommendInfo> roleMainAttrRecommendListByPlan = VisionRecommendModel.Instance.GetRoleMainAttrRecommendListByPlan(this.CurrentRoleId, cost, this.IsOfficialPlan);
		List<RecommendItemData> list = new List<RecommendItemData>();
		if (roleMainAttrRecommendListByPlan.Count > 0)
		{
			List<AttrRecommendInfo> list2 = new List<AttrRecommendInfo>(roleMainAttrRecommendListByPlan);
			list2.Sort((AttrRecommendInfo a, AttrRecommendInfo b) => b.GetUsage() - a.GetUsage());
			foreach (AttrRecommendInfo attrRecommendInfo in ((limit != null) ? list2.GetRange(0, (limit.Value < 0) ? 0 : ((limit.Value > list2.Count) ? list2.Count : limit.Value)) : list2))
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

	// Token: 0x0601024E RID: 66126 RVA: 0x004B5258 File Offset: 0x004B3458
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

	// Token: 0x0601024F RID: 66127 RVA: 0x004B532C File Offset: 0x004B352C
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

	// Token: 0x06010250 RID: 66128 RVA: 0x004B5424 File Offset: 0x004B3624
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

	// Token: 0x06010251 RID: 66129 RVA: 0x004B546D File Offset: 0x004B366D
	private CostDistributionItem InitCostDistributionItem()
	{
		return new CostDistributionItem();
	}

	// Token: 0x06010252 RID: 66130 RVA: 0x004B5474 File Offset: 0x004B3674
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

	// Token: 0x06010253 RID: 66131 RVA: 0x004B55DC File Offset: 0x004B37DC
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

	// Token: 0x06010254 RID: 66132 RVA: 0x004B56B4 File Offset: 0x004B38B4
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

	// Token: 0x06010255 RID: 66133 RVA: 0x004B5768 File Offset: 0x004B3968
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

	// Token: 0x06010256 RID: 66134 RVA: 0x004B57C4 File Offset: 0x004B39C4
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

	// Token: 0x06010257 RID: 66135 RVA: 0x004B5864 File Offset: 0x004B3A64
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

	// Token: 0x06010258 RID: 66136 RVA: 0x004B5918 File Offset: 0x004B3B18
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

	// Token: 0x06010259 RID: 66137 RVA: 0x004B5A6C File Offset: 0x004B3C6C
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

	// Token: 0x0601025A RID: 66138 RVA: 0x004B5AB4 File Offset: 0x004B3CB4
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

	// Token: 0x0601025B RID: 66139 RVA: 0x004B5B0C File Offset: 0x004B3D0C
	protected override UniTask OnBeforeHideAsync()
	{
		VisionEquipmentRecommendItem.<OnBeforeHideAsync>d__73 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<VisionEquipmentRecommendItem.<OnBeforeHideAsync>d__73>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04008F28 RID: 36648
	private const int CALABASH_LOW_LEVEL = 2;

	// Token: 0x04008F29 RID: 36649
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

	// Token: 0x04008F2A RID: 36650
	[Nullable(2)]
	private VisionEquipmentRecommendItemTop TopItem;

	// Token: 0x04008F2B RID: 36651
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionRecommendBranchFetterItem, VisionFetterRecommendInfo> SystemRecommendLayout;

	// Token: 0x04008F2C RID: 36652
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionRecommendBranchFetterItem, VisionFetterRecommendInfo> UsageRecommendLayout;

	// Token: 0x04008F2D RID: 36653
	private readonly List<VisionSelectRecommendData> CurrentSelectMainAttrArray = new List<VisionSelectRecommendData>();

	// Token: 0x04008F2E RID: 36654
	private readonly List<VisionSelectRecommendData> CurrentSelectSubAttrArray = new List<VisionSelectRecommendData>();

	// Token: 0x04008F2F RID: 36655
	[Nullable(2)]
	private VisionMainSelectPhantomData CurrentSelectMainPhantom;

	// Token: 0x04008F30 RID: 36656
	private readonly List<RecommendItemData> CurrentShowMainAttrArray = new List<RecommendItemData>();

	// Token: 0x04008F31 RID: 36657
	private readonly List<RecommendItemData> CurrentShowSubAttrArray = new List<RecommendItemData>();

	// Token: 0x04008F32 RID: 36658
	private readonly List<IMainPhantomItemData> CurrentShowMainPhantomArray = new List<IMainPhantomItemData>();

	// Token: 0x04008F33 RID: 36659
	[Nullable(2)]
	private MainRecommendPhantom MainPhantomRecommendItem;

	// Token: 0x04008F34 RID: 36660
	[Nullable(2)]
	private MainRecommendAttr MainRecommendAttr;

	// Token: 0x04008F35 RID: 36661
	[Nullable(2)]
	private SubRecommendAttr SubRecommendAttr;

	// Token: 0x04008F36 RID: 36662
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CostDistributionItem, int> OtherCostLayout;

	// Token: 0x04008F37 RID: 36663
	private int TabCost;

	// Token: 0x04008F38 RID: 36664
	private int CurrentCost;

	// Token: 0x04008F39 RID: 36665
	private int CurrentRoleId;

	// Token: 0x04008F3A RID: 36666
	[Nullable(2)]
	public VisionFetterRecommendInfo CurrentPlanInfo;

	// Token: 0x04008F3B RID: 36667
	private bool IsOfficialPlan;

	// Token: 0x04008F3C RID: 36668
	[Nullable(2)]
	private Action OnChangeAttrCallBack;

	// Token: 0x04008F3D RID: 36669
	[Nullable(2)]
	public Action OnDeselectMainPhantomCallback;

	// Token: 0x04008F3E RID: 36670
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IMainPhantomFilterChangedInfo> OnMainPhantomFilterChanged;

	// Token: 0x04008F3F RID: 36671
	[Nullable(2)]
	public Action<VisionFetterRecommendInfo> OnPlanChangedCallback;

	// Token: 0x04008F40 RID: 36672
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<List<int>, bool> OnSelectAllCallback;

	// Token: 0x04008F41 RID: 36673
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x02007BB7 RID: 31671
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040280F4 RID: 164084
		SystemRecommendLayout,
		// Token: 0x040280F5 RID: 164085
		SystemRecommendItem,
		// Token: 0x040280F6 RID: 164086
		UsageRecommendLayout,
		// Token: 0x040280F7 RID: 164087
		UsageRecommendItem,
		// Token: 0x040280F8 RID: 164088
		TogTop,
		// Token: 0x040280F9 RID: 164089
		PnlFirstVision,
		// Token: 0x040280FA RID: 164090
		PnlMainAttr,
		// Token: 0x040280FB RID: 164091
		PnlSubAttr,
		// Token: 0x040280FC RID: 164092
		TextFirstVisionCost,
		// Token: 0x040280FD RID: 164093
		OtherVisionCostLayout,
		// Token: 0x040280FE RID: 164094
		OtherVisionCostItem,
		// Token: 0x040280FF RID: 164095
		PnlSystemRecommend,
		// Token: 0x04028100 RID: 164096
		PnlUsageRecommend,
		// Token: 0x04028101 RID: 164097
		Scroll
	}
}
