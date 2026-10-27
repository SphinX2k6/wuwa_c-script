using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

// Token: 0x020024DB RID: 9435
[NullableContext(1)]
[Nullable(0)]
public class VisionNewRecommendPreviewView : UiViewBase
{
	// Token: 0x06012F7C RID: 77692 RVA: 0x004B20CC File Offset: 0x004B02CC
	public VisionNewRecommendPreviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x170018B3 RID: 6323
	// (get) Token: 0x06012F7D RID: 77693 RVA: 0x004B20D5 File Offset: 0x004B02D5
	public new IVisionNewRecommendPreviewViewOpenParam OpenParam
	{
		get
		{
			return (IVisionNewRecommendPreviewViewOpenParam)this.OpenParam;
		}
	}

	// Token: 0x06012F7E RID: 77694 RVA: 0x004B20E4 File Offset: 0x004B02E4
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

	// Token: 0x06012F7F RID: 77695 RVA: 0x004B2244 File Offset: 0x004B0444
	protected override UniTask OnBeforeStartAsync()
	{
		VisionNewRecommendPreviewView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionNewRecommendPreviewView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012F80 RID: 77696 RVA: 0x004B2288 File Offset: 0x004B0488
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

	// Token: 0x06012F81 RID: 77697 RVA: 0x004B22D6 File Offset: 0x004B04D6
	protected override void OnHandleReleaseScene()
	{
		this.TryReleaseScene();
	}

	// Token: 0x06012F82 RID: 77698 RVA: 0x004B22DE File Offset: 0x004B04DE
	private void TryReleaseScene()
	{
		if (this.ViewModel != null)
		{
			this.ViewModel.HandleReleaseScene();
		}
		this.ViewModel = null;
	}

	// Token: 0x06012F83 RID: 77699 RVA: 0x004B22FA File Offset: 0x004B04FA
	protected override void OnBeforeDestroy()
	{
		this.TryReleaseScene();
	}

	// Token: 0x06012F84 RID: 77700 RVA: 0x004B2302 File Offset: 0x004B0502
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

	// Token: 0x06012F85 RID: 77701 RVA: 0x004B2340 File Offset: 0x004B0540
	private void InitData()
	{
		this.CurUniqueIdList = PhantomBattleModel.Instance.GetBattleDataById(this.OpenParam.Proxy.CurrentSelectRoleId).GetIncrIdList().ToList<int>();
		this.RecommendUniqueIdList = VisionRecommendModel.Instance.GetRecommendEquipUniqueIdListNew(this.OpenParam.Proxy.CurrentSelectRoleId, this.OpenParam.Proxy.CurrentSelectFirstVisionMonsterId, this.OpenParam.Proxy.GetCurrentSelectRecommendInfo());
		bool isBothEmpty;
		if (this.CurUniqueIdList.All((int id) => id == 0))
		{
			isBothEmpty = this.RecommendUniqueIdList.All((int id) => id == 0);
		}
		else
		{
			isBothEmpty = false;
		}
		this.IsBothEmpty = isBothEmpty;
		this.IsSameEquip = this.CheckUniqueIdListEqual(this.CurUniqueIdList, this.RecommendUniqueIdList);
		this.RecommendAttrIdSet = this.GetRecommendAttrIds(this.OpenParam.Proxy.CurrentSelectRoleId);
	}

	// Token: 0x06012F86 RID: 77702 RVA: 0x004B244C File Offset: 0x004B064C
	private bool CheckUniqueIdListEqual(IReadOnlyList<int> listA, IReadOnlyList<int> listB)
	{
		if (listA[0] != listB[0])
		{
			return false;
		}
		List<int> list = (from x in listA.Skip(1)
		orderby x
		select x).ToList<int>();
		List<int> list2 = (from x in listB.Skip(1)
		orderby x
		select x).ToList<int>();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] != list2[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06012F87 RID: 77703 RVA: 0x004B24F4 File Offset: 0x004B06F4
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

	// Token: 0x06012F88 RID: 77704 RVA: 0x004B25AC File Offset: 0x004B07AC
	private void InitCaptionItem()
	{
		this.Caption = new PopupCaptionItem(base.GetItem(0));
		this.Caption.SetCloseCallBack(new Action(this.CloseCallBack));
		this.Caption.SetHelpBtnActive(false);
	}

	// Token: 0x06012F89 RID: 77705 RVA: 0x004B25E3 File Offset: 0x004B07E3
	private void CloseCallBack()
	{
		base.CloseMe(null);
	}

	// Token: 0x06012F8A RID: 77706 RVA: 0x004B25EC File Offset: 0x004B07EC
	private void InitAttributeLayout()
	{
		this.AttributeLayout = new GenericScrollViewNew<VisionNewRecommendPreviewAttrItem, VisionAssembleAttrData>(base.GetScrollViewWithScrollbar(7), new Func<VisionNewRecommendPreviewAttrItem>(this.InitAttributeItem), null, false, null);
	}

	// Token: 0x06012F8B RID: 77707 RVA: 0x004B260F File Offset: 0x004B080F
	private VisionNewRecommendPreviewAttrItem InitAttributeItem()
	{
		return new VisionNewRecommendPreviewAttrItem();
	}

	// Token: 0x06012F8C RID: 77708 RVA: 0x004B2618 File Offset: 0x004B0818
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

	// Token: 0x06012F8D RID: 77709 RVA: 0x004B2650 File Offset: 0x004B0850
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

	// Token: 0x06012F8E RID: 77710 RVA: 0x004B26CC File Offset: 0x004B08CC
	private void RefreshRoleIcon(RoleSkin roleSkinConfig)
	{
		string tag = "RoleIcon1";
		string roleSkinConfigParam = ComponentConfig.Instance.GetRoleSkinConfigParam(tag);
		if (roleSkinConfigParam != null && roleSkinConfigParam != "")
		{
			PropertyInfo property = roleSkinConfig.GetType().GetProperty(roleSkinConfigParam);
			if (property != null)
			{
				string text = property.GetValue(roleSkinConfig) as string;
				if (text != null)
				{
					base.SetTextureByPath(text, base.GetTexture(1), null, null);
				}
			}
		}
	}

	// Token: 0x06012F8F RID: 77711 RVA: 0x004B2744 File Offset: 0x004B0944
	private void RefreshRoleName(RoleSkin roleSkinConfig)
	{
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetText(RoleConfig.Instance.GetRoleName(roleSkinConfig.Name), true);
	}

	// Token: 0x06012F90 RID: 77712 RVA: 0x004B276C File Offset: 0x004B096C
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

	// Token: 0x06012F91 RID: 77713 RVA: 0x004B2794 File Offset: 0x004B0994
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

	// Token: 0x06012F92 RID: 77714 RVA: 0x004B2854 File Offset: 0x004B0A54
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

	// Token: 0x06012F93 RID: 77715 RVA: 0x004B287C File Offset: 0x004B0A7C
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

	// Token: 0x06012F94 RID: 77716 RVA: 0x004B2919 File Offset: 0x004B0B19
	private void RefreshCurEquipDetail()
	{
		VisionNewRecommendPreviewTopItem curEquipTopItem = this.CurEquipTopItem;
		if (curEquipTopItem == null)
		{
			return;
		}
		curEquipTopItem.Refresh(this.BuildTopData(false));
	}

	// Token: 0x06012F95 RID: 77717 RVA: 0x004B2932 File Offset: 0x004B0B32
	private void RefreshRecommendEquipDetail()
	{
		VisionNewRecommendPreviewTopItem recommendEquipTopItem = this.RecommendEquipTopItem;
		if (recommendEquipTopItem == null)
		{
			return;
		}
		recommendEquipTopItem.Refresh(this.BuildTopData(true));
	}

	// Token: 0x06012F96 RID: 77718 RVA: 0x004B294C File Offset: 0x004B0B4C
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

	// Token: 0x06012F97 RID: 77719 RVA: 0x004B2A4C File Offset: 0x004B0C4C
	private VisionNewRecommendPreviewTopData BuildTopData(bool isRecommend)
	{
		List<int> list = isRecommend ? this.RecommendUniqueIdList.ToList<int>() : this.CurUniqueIdList;
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

	// Token: 0x06012F98 RID: 77720 RVA: 0x004B2B44 File Offset: 0x004B0D44
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

	// Token: 0x06012F99 RID: 77721 RVA: 0x004B2BEC File Offset: 0x004B0DEC
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

	// Token: 0x06012F9A RID: 77722 RVA: 0x004B2C48 File Offset: 0x004B0E48
	private List<VisionAssembleAttrData> BuildAttrDetailData()
	{
		List<VisionAssembleAttrData> visionAttrDataListByIncIdList = this.GetVisionAttrDataListByIncIdList(this.CurUniqueIdList);
		List<VisionAssembleAttrData> visionAttrDataListByIncIdList2 = this.GetVisionAttrDataListByIncIdList(this.RecommendUniqueIdList.ToList<int>());
		this.CombineAttrList(visionAttrDataListByIncIdList2, visionAttrDataListByIncIdList);
		visionAttrDataListByIncIdList2.Sort(new Comparison<VisionAssembleAttrData>(this.SortAttrList));
		return visionAttrDataListByIncIdList2;
	}

	// Token: 0x06012F9B RID: 77723 RVA: 0x004B2C90 File Offset: 0x004B0E90
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

	// Token: 0x06012F9C RID: 77724 RVA: 0x004B2F30 File Offset: 0x004B1130
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

	// Token: 0x06012F9D RID: 77725 RVA: 0x004B2F94 File Offset: 0x004B1194
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

	// Token: 0x06012F9E RID: 77726 RVA: 0x004B3070 File Offset: 0x004B1270
	private void OnClickApplyBtn(int _)
	{
		if (this.OpenParam.Proxy.GetCurrentSelectRecommendInfo() == null)
		{
			return;
		}
		PhantomBattleController.Instance.ApplyRecommendEquip(this.OpenParam.Proxy.CurrentSelectRoleId, this.RecommendUniqueIdList.ToList<int>(), delegate
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

	// Token: 0x04008ECF RID: 36559
	[Nullable(2)]
	private PopupCaptionItem Caption;

	// Token: 0x04008ED0 RID: 36560
	[Nullable(2)]
	private VisionNewRecommendPreviewEquipItem CurEquipPanel;

	// Token: 0x04008ED1 RID: 36561
	[Nullable(2)]
	private VisionNewRecommendPreviewEquipItem RecommendEquipPanel;

	// Token: 0x04008ED2 RID: 36562
	[Nullable(2)]
	private VisionNewRecommendPreviewTopItem CurEquipTopItem;

	// Token: 0x04008ED3 RID: 36563
	[Nullable(2)]
	private VisionNewRecommendPreviewTopItem RecommendEquipTopItem;

	// Token: 0x04008ED4 RID: 36564
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<VisionNewRecommendPreviewAttrItem, VisionAssembleAttrData> AttributeLayout;

	// Token: 0x04008ED5 RID: 36565
	[Nullable(2)]
	private ButtonItem ApplyBtn;

	// Token: 0x04008ED6 RID: 36566
	[Nullable(2)]
	private RoleViewViewModel ViewModel;

	// Token: 0x04008ED7 RID: 36567
	[Nullable(2)]
	private List<int> CurUniqueIdList;

	// Token: 0x04008ED8 RID: 36568
	[Nullable(2)]
	private int[] RecommendUniqueIdList;

	// Token: 0x04008ED9 RID: 36569
	private bool IsSameEquip;

	// Token: 0x04008EDA RID: 36570
	private bool IsBothEmpty;

	// Token: 0x04008EDB RID: 36571
	[Nullable(2)]
	private HashSet<int> RecommendAttrIdSet;

	// Token: 0x02008A69 RID: 35433
	[Nullable(0)]
	private static class ETextId
	{
		// Token: 0x0402CF1B RID: 184091
		public const string Apply = "PhantomRecommend_Button05";

		// Token: 0x0402CF1C RID: 184092
		public const string ApplySameEquip = "PhantomRecommend_Tips05";
	}

	// Token: 0x02008A6A RID: 35434
	[NullableContext(0)]
	private enum EComp
	{
		// Token: 0x0402CF1E RID: 184094
		Caption,
		// Token: 0x0402CF1F RID: 184095
		RoleIcon,
		// Token: 0x0402CF20 RID: 184096
		RoleName,
		// Token: 0x0402CF21 RID: 184097
		CurEquipItem,
		// Token: 0x0402CF22 RID: 184098
		RecommendEquipItem,
		// Token: 0x0402CF23 RID: 184099
		LeftTop,
		// Token: 0x0402CF24 RID: 184100
		RightTop,
		// Token: 0x0402CF25 RID: 184101
		Scroll,
		// Token: 0x0402CF26 RID: 184102
		ScrollContent,
		// Token: 0x0402CF27 RID: 184103
		ScrollItem,
		// Token: 0x0402CF28 RID: 184104
		ApplyBtn,
		// Token: 0x0402CF29 RID: 184105
		BackBtn,
		// Token: 0x0402CF2A RID: 184106
		EmptyItem
	}
}
