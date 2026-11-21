using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019C2 RID: 6594
[NullableContext(1)]
[Nullable(0)]
public class VisionNewRecommendPreviewView : UiViewBase
{
	// Token: 0x0601043B RID: 66619 RVA: 0x004BFCCC File Offset: 0x004BDECC
	public VisionNewRecommendPreviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x170018ED RID: 6381
	// (get) Token: 0x0601043C RID: 66620 RVA: 0x004BFCD5 File Offset: 0x004BDED5
	public new IVisionNewRecommendPreviewViewOpenParam OpenParam
	{
		get
		{
			return (IVisionNewRecommendPreviewViewOpenParam)this.OpenParam;
		}
	}

	// Token: 0x0601043D RID: 66621 RVA: 0x004BFCE4 File Offset: 0x004BDEE4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(11, new Action(this.CloseCallBack))
		};
	}

	// Token: 0x0601043E RID: 66622 RVA: 0x004BFE44 File Offset: 0x004BE044
	protected override UniTask OnBeforeStartAsync()
	{
		VisionNewRecommendPreviewView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionNewRecommendPreviewView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601043F RID: 66623 RVA: 0x004BFE88 File Offset: 0x004BE088
	protected override void OnHandlePostLoadScene(bool isSceneLoad)
	{
		if (!this.SceneLoaded)
		{
			return;
		}
		if (UiSceneManager.Instance.HasRoleSystemRoleActor())
		{
			return;
		}
		int currentSelectRoleId = this.OpenParam.Proxy.CurrentSelectRoleId;
		this.ViewModel = new RoleViewViewModel(currentSelectRoleId, true, ERoleViewSource.Normal);
		this.ViewModel.HandleLoadScene(null);
	}

	// Token: 0x06010440 RID: 66624 RVA: 0x004BFED6 File Offset: 0x004BE0D6
	protected override void OnHandleReleaseScene()
	{
		this.TryReleaseScene();
	}

	// Token: 0x06010441 RID: 66625 RVA: 0x004BFEDE File Offset: 0x004BE0DE
	private void TryReleaseScene()
	{
		if (this.ViewModel != null)
		{
			this.ViewModel.HandleReleaseScene();
		}
		this.ViewModel = null;
	}

	// Token: 0x06010442 RID: 66626 RVA: 0x004BFEFA File Offset: 0x004BE0FA
	protected override void OnBeforeDestroy()
	{
		this.TryReleaseScene();
	}

	// Token: 0x06010443 RID: 66627 RVA: 0x004BFF02 File Offset: 0x004BE102
	protected override void OnStart()
	{
		this.InitData();
		this.InitCaptionItem();
		this.InitAttributeLayout();
		this.RefreshRoleInfo();
		this.RefreshCurEquip();
		this.RefreshRecommendEquip();
		this.RefreshCurEquipDetail();
		this.RefreshRecommendEquipDetail();
		this.RefreshAttributeScroller();
		this.RefreshApplyBtn();
	}

	// Token: 0x06010444 RID: 66628 RVA: 0x004BFF40 File Offset: 0x004BE140
	private void InitData()
	{
		this.CurUniqueIdList = new List<int>(PhantomBattleModel.Instance.GetBattleDataById(this.OpenParam.Proxy.CurrentSelectRoleId).GetIncrIdList());
		this.RecommendUniqueIdList = VisionRecommendModel.Instance.GetRecommendEquipUniqueIdListNew(this.OpenParam.Proxy.CurrentSelectRoleId, this.OpenParam.Proxy.CurrentSelectFirstVisionMonsterId, this.OpenParam.Proxy.GetCurrentSelectRecommendInfo());
		List<int> curUniqueIdList = this.CurUniqueIdList;
		bool flag = true;
		for (int i = 0; i < curUniqueIdList.Count; i++)
		{
			if (curUniqueIdList[i] != 0)
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			int[] recommendUniqueIdList = this.RecommendUniqueIdList;
			for (int j = 0; j < recommendUniqueIdList.Length; j++)
			{
				if (recommendUniqueIdList[j] != 0)
				{
					flag = false;
					break;
				}
			}
		}
		this.IsBothEmpty = flag;
		this.IsSameEquip = this.CheckUniqueIdListEqual(this.CurUniqueIdList, this.RecommendUniqueIdList);
		this.RecommendAttrIdSet = this.GetRecommendAttrIds(this.OpenParam.Proxy.CurrentSelectRoleId);
	}

	// Token: 0x06010445 RID: 66629 RVA: 0x004C0040 File Offset: 0x004BE240
	private bool CheckUniqueIdListEqual(IReadOnlyList<int> listA, IReadOnlyList<int> listB)
	{
		if (listA[0] != listB[0])
		{
			return false;
		}
		List<int> list = new List<int>();
		for (int i = 1; i < listA.Count; i++)
		{
			list.Add(listA[i]);
		}
		list.Sort();
		List<int> list2 = new List<int>();
		for (int j = 1; j < listB.Count; j++)
		{
			list2.Add(listB[j]);
		}
		list2.Sort();
		for (int k = 0; k < list.Count; k++)
		{
			if (list[k] != list2[k])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06010446 RID: 66630 RVA: 0x004C00E0 File Offset: 0x004BE2E0
	private void RefreshApplyBtn()
	{
		this.ApplyBtn = new ButtonItem(base.GetItem(10));
		if (this.IsBothEmpty)
		{
			ButtonItem applyBtn = this.ApplyBtn;
			if (applyBtn != null)
			{
				applyBtn.SetActive(false);
			}
			base.GetButton(11).RootUIComp.Get().SetUIActive(true);
			return;
		}
		if (this.IsSameEquip)
		{
			this.ApplyBtn.SetEnableClick(false);
			this.ApplyBtn.TrySetLocalTextNew("PhantomRecommend_Tips05", Array.Empty<object>());
			return;
		}
		this.ApplyBtn.SetEnableClick(true);
		this.ApplyBtn.TrySetLocalTextNew("PhantomRecommend_Button05", Array.Empty<object>());
		this.ApplyBtn.SetFunction(new Action<int>(this.OnClickApplyBtn));
	}

	// Token: 0x06010447 RID: 66631 RVA: 0x004C0198 File Offset: 0x004BE398
	private void InitCaptionItem()
	{
		this.Caption = new PopupCaptionItem(base.GetItem(0));
		this.Caption.SetCloseCallBack(new Action(this.CloseCallBack));
		this.Caption.SetHelpBtnActive(false);
	}

	// Token: 0x06010448 RID: 66632 RVA: 0x004C01CF File Offset: 0x004BE3CF
	private void CloseCallBack()
	{
		base.CloseMe(null);
	}

	// Token: 0x06010449 RID: 66633 RVA: 0x004C01D8 File Offset: 0x004BE3D8
	private void InitAttributeLayout()
	{
		this.AttributeLayout = new GenericScrollViewNew<VisionNewRecommendPreviewAttrItem, VisionAssembleAttrData>(base.GetScrollViewWithScrollbar(7), new Func<VisionNewRecommendPreviewAttrItem>(this.InitAttributeItem), null, false, null);
	}

	// Token: 0x0601044A RID: 66634 RVA: 0x004C01FB File Offset: 0x004BE3FB
	private VisionNewRecommendPreviewAttrItem InitAttributeItem()
	{
		return new VisionNewRecommendPreviewAttrItem();
	}

	// Token: 0x0601044B RID: 66635 RVA: 0x004C0204 File Offset: 0x004BE404
	private void RefreshRoleInfo()
	{
		RoleSkin? roleSkinConfig = this.GetRoleSkinConfig();
		if (roleSkinConfig == null)
		{
			return;
		}
		this.RefreshRoleIcon(roleSkinConfig.Value);
		this.RefreshRoleName(roleSkinConfig.Value);
	}

	// Token: 0x0601044C RID: 66636 RVA: 0x004C023C File Offset: 0x004BE43C
	private RoleSkin? GetRoleSkinConfig()
	{
		int currentSelectRoleId = this.OpenParam.Proxy.CurrentSelectRoleId;
		RoleSkinModel instance = RoleSkinModel.Instance;
		RoleSkinData roleSkinData = (instance != null) ? instance.GetRoleSkinDataByRoleId(currentSelectRoleId) : null;
		if (roleSkinData != null)
		{
			return new RoleSkin?(roleSkinData.GetRoleSkinConfig());
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(currentSelectRoleId);
		if (roleConfig == null)
		{
			return null;
		}
		return SkinConfig.Instance.GetRoleSkinConfig(roleConfig.Value.SkinId);
	}

	// Token: 0x0601044D RID: 66637 RVA: 0x004C02B8 File Offset: 0x004BE4B8
	private void RefreshRoleIcon(RoleSkin roleSkinConfig)
	{
		string tag = "RoleIcon1";
		string roleSkinConfigParam = ComponentConfig.Instance.GetRoleSkinConfigParam(tag);
		string path;
		if (roleSkinConfigParam != null && roleSkinConfigParam != "" && roleSkinConfig.TryGetMember(roleSkinConfigParam, out path))
		{
			base.SetTextureByPath(path, base.GetTexture(1), null, null);
		}
	}

	// Token: 0x0601044E RID: 66638 RVA: 0x004C030B File Offset: 0x004BE50B
	private void RefreshRoleName(RoleSkin roleSkinConfig)
	{
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetText(RoleConfig.Instance.GetRoleName(roleSkinConfig.Name), true);
	}

	// Token: 0x0601044F RID: 66639 RVA: 0x004C0330 File Offset: 0x004BE530
	private void RefreshCurEquip()
	{
		List<VisionNewRecommendPhantomItemData> data = this.BuildCurEquipData();
		VisionNewRecommendPreviewEquipItem curEquipPanel = this.CurEquipPanel;
		if (curEquipPanel == null)
		{
			return;
		}
		curEquipPanel.Update(data);
	}

	// Token: 0x06010450 RID: 66640 RVA: 0x004C0358 File Offset: 0x004BE558
	[return: Nullable(new byte[]
	{
		1,
		2
	})]
	private List<VisionNewRecommendPhantomItemData> BuildCurEquipData()
	{
		int num = 5;
		List<VisionNewRecommendPhantomItemData> list = new List<VisionNewRecommendPhantomItemData>
		{
			null,
			null,
			null,
			null,
			null
		};
		for (int i = 0; i < num; i++)
		{
			int roleIndexPhantomId = PhantomBattleModel.Instance.GetRoleIndexPhantomId(this.OpenParam.Proxy.CurrentSelectRoleId, i);
			if (roleIndexPhantomId != 0)
			{
				PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(roleIndexPhantomId);
				if (phantomBattleData != null)
				{
					list[i] = new VisionNewRecommendPhantomItemData
					{
						PhantomId = phantomBattleData.GetConfigId(true),
						FetterGroupId = phantomBattleData.GetFetterGroupId(),
						Cost = phantomBattleData.GetCost(),
						UniqueId = roleIndexPhantomId,
						Level = phantomBattleData.GetPhantomLevel()
					};
				}
			}
		}
		return list;
	}

	// Token: 0x06010451 RID: 66641 RVA: 0x004C0418 File Offset: 0x004BE618
	private void RefreshRecommendEquip()
	{
		List<VisionNewRecommendPhantomItemData> data = this.BuildRecommendEquipData();
		VisionNewRecommendPreviewEquipItem recommendEquipPanel = this.RecommendEquipPanel;
		if (recommendEquipPanel == null)
		{
			return;
		}
		recommendEquipPanel.Update(data);
	}

	// Token: 0x06010452 RID: 66642 RVA: 0x004C0440 File Offset: 0x004BE640
	[return: Nullable(new byte[]
	{
		1,
		2
	})]
	private List<VisionNewRecommendPhantomItemData> BuildRecommendEquipData()
	{
		if (this.OpenParam.Proxy.GetCurrentSelectRecommendInfo() == null)
		{
			return new List<VisionNewRecommendPhantomItemData>();
		}
		List<VisionNewRecommendPhantomItemData> list = new List<VisionNewRecommendPhantomItemData>();
		foreach (int uniqueId in this.RecommendUniqueIdList)
		{
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
			if (phantomBattleData != null)
			{
				list.Add(new VisionNewRecommendPhantomItemData
				{
					PhantomId = phantomBattleData.GetConfigId(true),
					FetterGroupId = phantomBattleData.GetFetterGroupId(),
					Cost = phantomBattleData.GetCost(),
					UniqueId = uniqueId,
					Level = phantomBattleData.GetPhantomLevel()
				});
			}
		}
		return list;
	}

	// Token: 0x06010453 RID: 66643 RVA: 0x004C04DD File Offset: 0x004BE6DD
	private void RefreshCurEquipDetail()
	{
		VisionNewRecommendPreviewTopItem curEquipTopItem = this.CurEquipTopItem;
		if (curEquipTopItem == null)
		{
			return;
		}
		curEquipTopItem.Refresh(this.BuildTopData(false));
	}

	// Token: 0x06010454 RID: 66644 RVA: 0x004C04F6 File Offset: 0x004BE6F6
	private void RefreshRecommendEquipDetail()
	{
		VisionNewRecommendPreviewTopItem recommendEquipTopItem = this.RecommendEquipTopItem;
		if (recommendEquipTopItem == null)
		{
			return;
		}
		recommendEquipTopItem.Refresh(this.BuildTopData(true));
	}

	// Token: 0x06010455 RID: 66645 RVA: 0x004C0510 File Offset: 0x004BE710
	private HashSet<int> GetRecommendAttrIds(int roleId)
	{
		HashSet<int> hashSet = new HashSet<int>();
		Dictionary<int, VisionAttrRecommendInfo> roleAllAttrRecommendInfo = VisionRecommendModel.Instance.GetRoleAllAttrRecommendInfo(roleId);
		if (roleAllAttrRecommendInfo == null)
		{
			return hashSet;
		}
		foreach (VisionAttrRecommendInfo visionAttrRecommendInfo in roleAllAttrRecommendInfo.Values)
		{
			foreach (AttrRecommendInfo attrRecommendInfo in visionAttrRecommendInfo.GetMainAttrRecommendInfo())
			{
				hashSet.Add(attrRecommendInfo.GetAttrId());
			}
			foreach (AttrRecommendInfo attrRecommendInfo2 in visionAttrRecommendInfo.GetSubAttrRecommendInfo())
			{
				hashSet.Add(attrRecommendInfo2.GetAttrId());
			}
		}
		return hashSet;
	}

	// Token: 0x06010456 RID: 66646 RVA: 0x004C0610 File Offset: 0x004BE810
	private VisionNewRecommendPreviewTopData BuildTopData(bool isRecommend)
	{
		List<int> list = isRecommend ? new List<int>(this.RecommendUniqueIdList) : this.CurUniqueIdList;
		List<VisionFetterData> list2 = this.FilterSameFetterData(VisionEquipGroupModel.Instance.GetVisionFetterDataByIncIdList(list));
		List<VisionAssembleSuitItemData> list3 = new List<VisionAssembleSuitItemData>();
		foreach (VisionFetterData data in list2)
		{
			VisionAssembleSuitItemData visionAssembleSuitItemData = new VisionAssembleSuitItemData();
			visionAssembleSuitItemData.Phrase(data);
			list3.Add(visionAssembleSuitItemData);
		}
		int num = 0;
		foreach (int uniqueId in list)
		{
			int num2 = num;
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
			num = num2 + ((phantomBattleData != null) ? phantomBattleData.GetCost() : 0);
		}
		return new VisionNewRecommendPreviewTopData
		{
			Cost = num,
			SuitList = list3
		};
	}

	// Token: 0x06010457 RID: 66647 RVA: 0x004C0708 File Offset: 0x004BE908
	private List<VisionFetterData> FilterSameFetterData(List<VisionFetterData> dataList)
	{
		List<VisionFetterData> list = new List<VisionFetterData>();
		Dictionary<int, VisionFetterData> dictionary = new Dictionary<int, VisionFetterData>();
		foreach (VisionFetterData visionFetterData in dataList)
		{
			dictionary[visionFetterData.FetterGroupId] = visionFetterData;
		}
		foreach (VisionFetterData item in dictionary.Values)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x06010458 RID: 66648 RVA: 0x004C07B0 File Offset: 0x004BE9B0
	private void RefreshAttributeScroller()
	{
		List<VisionAssembleAttrData> list = this.BuildAttrDetailData();
		bool flag = list.Count > 0;
		base.GetScrollViewWithScrollbar(7).RootUIComp.Get().SetUIActive(flag);
		base.GetItem(12).SetUIActive(!flag);
		GenericScrollViewNew<VisionNewRecommendPreviewAttrItem, VisionAssembleAttrData> attributeLayout = this.AttributeLayout;
		if (attributeLayout == null)
		{
			return;
		}
		attributeLayout.RefreshByData(list, null, false);
	}

	// Token: 0x06010459 RID: 66649 RVA: 0x004C080C File Offset: 0x004BEA0C
	private List<VisionAssembleAttrData> BuildAttrDetailData()
	{
		List<VisionAssembleAttrData> visionAttrDataListByIncIdList = this.GetVisionAttrDataListByIncIdList(this.CurUniqueIdList);
		List<VisionAssembleAttrData> visionAttrDataListByIncIdList2 = this.GetVisionAttrDataListByIncIdList(this.RecommendUniqueIdList);
		this.CombineAttrList(visionAttrDataListByIncIdList2, visionAttrDataListByIncIdList);
		visionAttrDataListByIncIdList2.Sort(new Comparison<VisionAssembleAttrData>(this.SortAttrList));
		return visionAttrDataListByIncIdList2;
	}

	// Token: 0x0601045A RID: 66650 RVA: 0x004C0850 File Offset: 0x004BEA50
	private List<VisionAssembleAttrData> GetVisionAttrDataListByIncIdList(IReadOnlyList<int> incIdList)
	{
		HashSet<int> recommendAttrIdSet = this.RecommendAttrIdSet;
		List<VisionAssembleAttrData> list = new List<VisionAssembleAttrData>();
		int count = incIdList.Count;
		for (int i = 0; i < count; i++)
		{
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(incIdList[i]);
			if (phantomBattleData != null)
			{
				foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo in phantomBattleData.GetPhantomMainProp())
				{
					PhantomMainPropItem phantomMainPropertyItemId = PhantomBattleConfig.Instance.GetPhantomMainPropertyItemId(phantomPropInfo.PhantomPropId);
					bool flag = phantomMainPropertyItemId.AddType == 2;
					bool flag2 = false;
					foreach (VisionAssembleAttrData visionAssembleAttrData in list)
					{
						if (visionAssembleAttrData.AttrId == phantomMainPropertyItemId.PropId && visionAssembleAttrData.IfPercentage == flag)
						{
							visionAssembleAttrData.CurrentValue += phantomPropInfo.Value;
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						VisionAssembleAttrData visionAssembleAttrData2 = new VisionAssembleAttrData();
						visionAssembleAttrData2.AttrId = phantomMainPropertyItemId.PropId;
						visionAssembleAttrData2.IfPercentage = flag;
						visionAssembleAttrData2.CurrentValue += phantomPropInfo.Value;
						visionAssembleAttrData2.IsHighLight = recommendAttrIdSet.Contains(phantomMainPropertyItemId.PropId);
						list.Add(visionAssembleAttrData2);
					}
				}
				foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo2 in phantomBattleData.GetPhantomSubProp())
				{
					PhantomSubProperty phantomSubPropertyById = PhantomBattleConfig.Instance.GetPhantomSubPropertyById(phantomPropInfo2.PhantomPropId);
					bool flag3 = phantomSubPropertyById.AddType == 2;
					bool flag4 = false;
					foreach (VisionAssembleAttrData visionAssembleAttrData3 in list)
					{
						if (visionAssembleAttrData3.AttrId == phantomSubPropertyById.PropId && visionAssembleAttrData3.IfPercentage == flag3)
						{
							visionAssembleAttrData3.CurrentValue += phantomPropInfo2.Value;
							flag4 = true;
							break;
						}
					}
					if (!flag4)
					{
						VisionAssembleAttrData visionAssembleAttrData4 = new VisionAssembleAttrData();
						visionAssembleAttrData4.AttrId = phantomSubPropertyById.PropId;
						visionAssembleAttrData4.IfPercentage = flag3;
						visionAssembleAttrData4.CurrentValue += phantomPropInfo2.Value;
						visionAssembleAttrData4.IsHighLight = recommendAttrIdSet.Contains(phantomSubPropertyById.PropId);
						list.Add(visionAssembleAttrData4);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x0601045B RID: 66651 RVA: 0x004C0AF0 File Offset: 0x004BECF0
	private int SortAttrList(VisionAssembleAttrData dataB, VisionAssembleAttrData dataA)
	{
		int priority = dataA.GetPriority();
		int priority2 = dataB.GetPriority();
		bool flag = priority != 0;
		bool flag2 = priority2 != 0;
		if (flag && flag2)
		{
			if (priority == priority2)
			{
				int num = (!dataA.IfPercentage) ? 1 : 0;
				int num2 = (!dataB.IfPercentage) ? 1 : 0;
				return num - num2;
			}
			return priority - priority2;
		}
		else
		{
			if (flag)
			{
				return -1;
			}
			if (flag2)
			{
				return 1;
			}
			return dataA.GetId() - dataB.GetId();
		}
	}

	// Token: 0x0601045C RID: 66652 RVA: 0x004C0B54 File Offset: 0x004BED54
	private void CombineAttrList(List<VisionAssembleAttrData> compareAttrDataList, List<VisionAssembleAttrData> currentAttrDataList)
	{
		int count = currentAttrDataList.Count;
		for (int i = 0; i < count; i++)
		{
			VisionAssembleAttrData visionAssembleAttrData = currentAttrDataList[i];
			bool flag = false;
			foreach (VisionAssembleAttrData visionAssembleAttrData2 in compareAttrDataList)
			{
				if (visionAssembleAttrData2.AttrId == visionAssembleAttrData.AttrId && visionAssembleAttrData2.IfPercentage == visionAssembleAttrData.IfPercentage)
				{
					visionAssembleAttrData2.CompareValue = visionAssembleAttrData.CurrentValue;
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				compareAttrDataList.Add(new VisionAssembleAttrData
				{
					AttrId = visionAssembleAttrData.AttrId,
					IfPercentage = visionAssembleAttrData.IfPercentage,
					CompareValue = visionAssembleAttrData.CurrentValue,
					CompareMode = true
				});
			}
		}
	}

	// Token: 0x0601045D RID: 66653 RVA: 0x004C0C30 File Offset: 0x004BEE30
	private void OnClickApplyBtn(int _)
	{
		if (this.OpenParam.Proxy.GetCurrentSelectRecommendInfo() == null)
		{
			return;
		}
		PhantomBattleController.Instance.ApplyRecommendEquip(this.OpenParam.Proxy.CurrentSelectRoleId, new List<int>(this.RecommendUniqueIdList), delegate
		{
			base.CloseMe(null);
			Action onApplySuccess = this.OpenParam.OnApplySuccess;
			if (onApplySuccess == null)
			{
				return;
			}
			onApplySuccess();
		});
	}

	// Token: 0x04009019 RID: 36889
	[Nullable(2)]
	private PopupCaptionItem Caption;

	// Token: 0x0400901A RID: 36890
	[Nullable(2)]
	private VisionNewRecommendPreviewEquipItem CurEquipPanel;

	// Token: 0x0400901B RID: 36891
	[Nullable(2)]
	private VisionNewRecommendPreviewEquipItem RecommendEquipPanel;

	// Token: 0x0400901C RID: 36892
	[Nullable(2)]
	private VisionNewRecommendPreviewTopItem CurEquipTopItem;

	// Token: 0x0400901D RID: 36893
	[Nullable(2)]
	private VisionNewRecommendPreviewTopItem RecommendEquipTopItem;

	// Token: 0x0400901E RID: 36894
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<VisionNewRecommendPreviewAttrItem, VisionAssembleAttrData> AttributeLayout;

	// Token: 0x0400901F RID: 36895
	[Nullable(2)]
	private ButtonItem ApplyBtn;

	// Token: 0x04009020 RID: 36896
	[Nullable(2)]
	private RoleViewViewModel ViewModel;

	// Token: 0x04009021 RID: 36897
	[Nullable(2)]
	private List<int> CurUniqueIdList;

	// Token: 0x04009022 RID: 36898
	[Nullable(2)]
	private int[] RecommendUniqueIdList;

	// Token: 0x04009023 RID: 36899
	private bool IsSameEquip;

	// Token: 0x04009024 RID: 36900
	private bool IsBothEmpty;

	// Token: 0x04009025 RID: 36901
	[Nullable(2)]
	private HashSet<int> RecommendAttrIdSet;

	// Token: 0x02007BF2 RID: 31730
	[Nullable(0)]
	private static class ETextId
	{
		// Token: 0x04028239 RID: 164409
		public const string Apply = "PhantomRecommend_Button05";

		// Token: 0x0402823A RID: 164410
		public const string ApplySameEquip = "PhantomRecommend_Tips05";
	}

	// Token: 0x02007BF3 RID: 31731
	[NullableContext(0)]
	private enum EComp
	{
		// Token: 0x0402823C RID: 164412
		Caption,
		// Token: 0x0402823D RID: 164413
		RoleIcon,
		// Token: 0x0402823E RID: 164414
		RoleName,
		// Token: 0x0402823F RID: 164415
		CurEquipItem,
		// Token: 0x04028240 RID: 164416
		RecommendEquipItem,
		// Token: 0x04028241 RID: 164417
		LeftTop,
		// Token: 0x04028242 RID: 164418
		RightTop,
		// Token: 0x04028243 RID: 164419
		Scroll,
		// Token: 0x04028244 RID: 164420
		ScrollContent,
		// Token: 0x04028245 RID: 164421
		ScrollItem,
		// Token: 0x04028246 RID: 164422
		ApplyBtn,
		// Token: 0x04028247 RID: 164423
		BackBtn,
		// Token: 0x04028248 RID: 164424
		EmptyItem
	}
}
