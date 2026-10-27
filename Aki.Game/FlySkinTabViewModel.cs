using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Module.Common.UiCamera;
using CSharpScript.Game.Module.Skin;
using UnrealEngine;

// Token: 0x02002A56 RID: 10838
[NullableContext(1)]
[Nullable(0)]
public class FlySkinTabViewModel : global::ViewModelBase<EFlySkinViewData>
{
	// Token: 0x06016956 RID: 92502 RVA: 0x005B93F8 File Offset: 0x005B75F8
	public FlySkinTabViewModel()
	{
		List<FlySkinGridData> value = new List<FlySkinGridData>();
		this.DataMap.Add(EFlySkinViewData.GridDataList, value);
		this.DataMap.Add(EFlySkinViewData.SelectedTab, null);
		this.DataMap.Add(EFlySkinViewData.SelectedGridIndex, -1);
	}

	// Token: 0x17001DF6 RID: 7670
	// (get) Token: 0x06016957 RID: 92503 RVA: 0x005B9468 File Offset: 0x005B7668
	public int RoleDataId
	{
		get
		{
			return this.RoleDataIdInternal;
		}
	}

	// Token: 0x17001DF7 RID: 7671
	// (get) Token: 0x06016958 RID: 92504 RVA: 0x005B9470 File Offset: 0x005B7670
	public EFlySkinType SelectedFlySkinType
	{
		get
		{
			return this.SelectedFlySkinTypeInternal;
		}
	}

	// Token: 0x17001DF8 RID: 7672
	// (get) Token: 0x06016959 RID: 92505 RVA: 0x005B9478 File Offset: 0x005B7678
	public int SelectedFlySkinId
	{
		get
		{
			return this.SelectedFlySkinIdInternal;
		}
	}

	// Token: 0x17001DF9 RID: 7673
	// (get) Token: 0x0601695A RID: 92506 RVA: 0x005B9480 File Offset: 0x005B7680
	public FlySkinGridData SelectedGridData
	{
		get
		{
			return this.SelectedGridDataInternal;
		}
	}

	// Token: 0x17001DFA RID: 7674
	// (get) Token: 0x0601695B RID: 92507 RVA: 0x005B9488 File Offset: 0x005B7688
	public List<IFlySkinGetWayData> GetWayDataList
	{
		get
		{
			return this.GetWayDataListInternal;
		}
	}

	// Token: 0x17001DFB RID: 7675
	// (get) Token: 0x0601695C RID: 92508 RVA: 0x005B9490 File Offset: 0x005B7690
	public string ModelCase
	{
		get
		{
			return this.ModelCaseInternal;
		}
	}

	// Token: 0x0601695D RID: 92509 RVA: 0x005B9498 File Offset: 0x005B7698
	public List<FlySkinGridData> GetGridDataList()
	{
		return base.GetData(EFlySkinViewData.GridDataList) as List<FlySkinGridData>;
	}

	// Token: 0x0601695E RID: 92510 RVA: 0x005B94A6 File Offset: 0x005B76A6
	public void SetSelectedTab(EFlySkinTab? selectedTab, bool? notNotify = false)
	{
		base.SetData(EFlySkinViewData.SelectedTab, selectedTab, notNotify);
	}

	// Token: 0x0601695F RID: 92511 RVA: 0x005B94B6 File Offset: 0x005B76B6
	public EFlySkinTab? GetSelectedTab()
	{
		return base.GetData(EFlySkinViewData.SelectedTab) as EFlySkinTab?;
	}

	// Token: 0x06016960 RID: 92512 RVA: 0x005B94C9 File Offset: 0x005B76C9
	public void SetSelectedGridIndex(int gridIndex, bool? notNotify = false)
	{
		base.SetData(EFlySkinViewData.SelectedGridIndex, gridIndex, notNotify);
	}

	// Token: 0x06016961 RID: 92513 RVA: 0x005B94D9 File Offset: 0x005B76D9
	public int GetSelectedGridIndex()
	{
		return (int)base.GetData(EFlySkinViewData.SelectedGridIndex);
	}

	// Token: 0x06016962 RID: 92514 RVA: 0x005B94E8 File Offset: 0x005B76E8
	public void Init(ISkinViewData viewData)
	{
		this.RoleDataIdInternal = viewData.RoleId;
		this.SelectedFlySkinIdInternal = viewData.FlySkinId.GetValueOrDefault(-1);
		EFlySkinTab valueOrDefault = viewData.FlySkinTab.GetValueOrDefault();
		this.SetSelectedTab(new EFlySkinTab?(valueOrDefault), new bool?(false));
	}

	// Token: 0x06016963 RID: 92515 RVA: 0x005B9538 File Offset: 0x005B7738
	public void SelectTab(EFlySkinTab tab)
	{
		this.SelectedFlySkinTypeInternal = FlySkinDefine.flySkinTabToType[tab];
		this.ModelCaseInternal = FlySkinDefine.flySkinTypeToCase[this.SelectedFlySkinTypeInternal];
		this.SetSelectedGridIndex(-1, new bool?(true));
		this.UpdateGridData();
		this.SetSelectedTab(new EFlySkinTab?(tab), new bool?(false));
	}

	// Token: 0x06016964 RID: 92516 RVA: 0x005B9594 File Offset: 0x005B7794
	public void UpdateGridData()
	{
		List<FlySkinGridData> gridDataList = this.GetGridDataList();
		gridDataList.Clear();
		this.SkinIdToGridIndexMapInternal.Clear();
		EFlySkinType selectedFlySkinTypeInternal = this.SelectedFlySkinTypeInternal;
		gridDataList.Add(new FlySkinGridData(0, this.RoleDataIdInternal, selectedFlySkinTypeInternal, null));
		foreach (FlySkinConfig value in SkinConfig.Instance.GetFlySkinConfigListByType(selectedFlySkinTypeInternal))
		{
			FlySkinGridData item = new FlySkinGridData(value.Id, this.RoleDataIdInternal, selectedFlySkinTypeInternal, new FlySkinConfig?(value));
			gridDataList.Add(item);
		}
		gridDataList.Sort(delegate(FlySkinGridData a, FlySkinGridData b)
		{
			if (a.SkinConfig == null)
			{
				return -1;
			}
			if (b.SkinConfig == null)
			{
				return 1;
			}
			if (a.GetIsLock() != b.GetIsLock())
			{
				if (!a.GetIsLock())
				{
					return -1;
				}
				return 1;
			}
			else
			{
				if (a.SkinConfig.Value.SortIndex != b.SkinConfig.Value.SortIndex)
				{
					return b.SkinConfig.Value.SortIndex - a.SkinConfig.Value.SortIndex;
				}
				return b.SkinId - a.SkinId;
			}
		});
		for (int i = 0; i < gridDataList.Count; i++)
		{
			this.SkinIdToGridIndexMapInternal[gridDataList[i].SkinId] = i;
		}
		base.SetData(EFlySkinViewData.GridDataList, gridDataList, new bool?(false));
	}

	// Token: 0x06016965 RID: 92517 RVA: 0x005B96A4 File Offset: 0x005B78A4
	public int? GetGridIndexBySkinId(int skinId)
	{
		int value;
		if (this.SkinIdToGridIndexMapInternal.TryGetValue(skinId, out value))
		{
			return new int?(value);
		}
		return null;
	}

	// Token: 0x06016966 RID: 92518 RVA: 0x005B96D4 File Offset: 0x005B78D4
	public void SelectGridByIndex(int index)
	{
		this.SelectedGridDataInternal = this.GetGridDataList()[index];
		this.SelectedFlySkinIdInternal = this.SelectedGridDataInternal.SkinId;
		this.SelectedFlySkinConfigInternal = ((this.SelectedFlySkinIdInternal > 0) ? SkinConfig.Instance.GetFlySkinConfig(this.SelectedFlySkinIdInternal) : null);
		this.UpdateGetWayDataList();
		this.SetSelectedGridIndex(index, new bool?(false));
	}

	// Token: 0x06016967 RID: 92519 RVA: 0x005B9744 File Offset: 0x005B7944
	public void UpdateGetWayDataList()
	{
		this.GetWayDataListInternal = new List<IFlySkinGetWayData>();
		if (this.SelectedFlySkinConfigInternal == null)
		{
			return;
		}
		int itemAccessLength = this.SelectedFlySkinConfigInternal.Value.ItemAccessLength;
		for (int i = 0; i < itemAccessLength; i++)
		{
			int num = this.SelectedFlySkinConfigInternal.Value.ItemAccess(i);
			AccessPath? configById = GetWayConfig.Instance.GetConfigById(num);
			if (configById != null)
			{
				FlySkinGetWayData item = new FlySkinGetWayData
				{
					Id = num,
					ConfigId = this.SelectedFlySkinId,
					Type = (EFlySkinGetWayType)configById.Value.Type,
					Text = configById.Value.Description,
					SortIndex = configById.Value.SortIndex
				};
				this.GetWayDataListInternal.Add(item);
			}
		}
		this.GetWayDataListInternal.Sort(delegate(IFlySkinGetWayData aData, IFlySkinGetWayData bData)
		{
			int sortIndex = aData.SortIndex;
			int sortIndex2 = bData.SortIndex;
			if (sortIndex == sortIndex2)
			{
				return bData.Id - aData.Id;
			}
			return sortIndex2 - sortIndex;
		});
	}

	// Token: 0x06016968 RID: 92520 RVA: 0x005B984E File Offset: 0x005B7A4E
	public void SetUiShowState(bool state)
	{
		this.UiShowState = state;
	}

	// Token: 0x06016969 RID: 92521 RVA: 0x005B9857 File Offset: 0x005B7A57
	public void SetIsApplyToAll(bool value)
	{
		this.IsApplyToAll = value;
	}

	// Token: 0x0601696A RID: 92522 RVA: 0x005B9860 File Offset: 0x005B7A60
	public void ResetSelectedTab()
	{
		this.SetSelectedTab(null, new bool?(false));
		this.SetSelectedGridIndex(-1, new bool?(false));
	}

	// Token: 0x0601696B RID: 92523 RVA: 0x005B9890 File Offset: 0x005B7A90
	public IUiCameraInputComponentData GetFlySkinTabCameraInputData(UUIDraggableComponent dragItem)
	{
		string rowName = "翱翔滑翔皮肤旋转查看";
		SUiRoleCameraSetting value = UiRoleCameraConfig.Instance.GetRoleCameraConfig(rowName).Value;
		FVectorDouble fvectorDouble = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName(this.ModelCaseInternal).Value, ECollectActorType.UI).D_K2_GetActorLocation();
		return new UiCameraInputComponentData
		{
			DragComponent = dragItem,
			CameraSettingConfig = value,
			SourceLocation = fvectorDouble
		};
	}

	// Token: 0x0400A797 RID: 42903
	private int RoleDataIdInternal;

	// Token: 0x0400A798 RID: 42904
	private EFlySkinType SelectedFlySkinTypeInternal = EFlySkinType.Paragliding;

	// Token: 0x0400A799 RID: 42905
	private int SelectedFlySkinIdInternal = -1;

	// Token: 0x0400A79A RID: 42906
	private FlySkinConfig? SelectedFlySkinConfigInternal;

	// Token: 0x0400A79B RID: 42907
	private FlySkinGridData SelectedGridDataInternal;

	// Token: 0x0400A79C RID: 42908
	private readonly Dictionary<int, int> SkinIdToGridIndexMapInternal = new Dictionary<int, int>();

	// Token: 0x0400A79D RID: 42909
	private List<IFlySkinGetWayData> GetWayDataListInternal;

	// Token: 0x0400A79E RID: 42910
	private string ModelCaseInternal = "";

	// Token: 0x0400A79F RID: 42911
	public bool UiShowState = true;

	// Token: 0x0400A7A0 RID: 42912
	public bool IsApplyToAll;
}
