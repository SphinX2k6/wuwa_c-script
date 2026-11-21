using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Module.LinkedItem;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.UiCamera;
using UnrealEngine;

// Token: 0x02001FD1 RID: 8145
[NullableContext(1)]
[Nullable(0)]
public class FlySkinTabViewModel : global::ViewModelBase<EFlySkinViewData>
{
	// Token: 0x06014377 RID: 82807 RVA: 0x005E5558 File Offset: 0x005E3758
	public FlySkinTabViewModel()
	{
		List<FlySkinGridData> value = new List<FlySkinGridData>();
		this.DataMap.Add(EFlySkinViewData.GridDataList, value);
		this.DataMap.Add(EFlySkinViewData.SelectedTab, null);
		this.DataMap.Add(EFlySkinViewData.SelectedGridIndex, -1);
	}

	// Token: 0x17001E4E RID: 7758
	// (get) Token: 0x06014378 RID: 82808 RVA: 0x005E55C8 File Offset: 0x005E37C8
	public int RoleDataId
	{
		get
		{
			return this.RoleDataIdInternal;
		}
	}

	// Token: 0x17001E4F RID: 7759
	// (get) Token: 0x06014379 RID: 82809 RVA: 0x005E55D0 File Offset: 0x005E37D0
	public EFlySkinType SelectedFlySkinType
	{
		get
		{
			return this.SelectedFlySkinTypeInternal;
		}
	}

	// Token: 0x17001E50 RID: 7760
	// (get) Token: 0x0601437A RID: 82810 RVA: 0x005E55D8 File Offset: 0x005E37D8
	public int SelectedFlySkinId
	{
		get
		{
			return this.SelectedFlySkinIdInternal;
		}
	}

	// Token: 0x17001E51 RID: 7761
	// (get) Token: 0x0601437B RID: 82811 RVA: 0x005E55E0 File Offset: 0x005E37E0
	public FlySkinGridData SelectedGridData
	{
		get
		{
			return this.SelectedGridDataInternal;
		}
	}

	// Token: 0x17001E52 RID: 7762
	// (get) Token: 0x0601437C RID: 82812 RVA: 0x005E55E8 File Offset: 0x005E37E8
	public List<IFlySkinGetWayData> GetWayDataList
	{
		get
		{
			return this.GetWayDataListInternal;
		}
	}

	// Token: 0x17001E53 RID: 7763
	// (get) Token: 0x0601437D RID: 82813 RVA: 0x005E55F0 File Offset: 0x005E37F0
	public string ModelCase
	{
		get
		{
			return this.ModelCaseInternal;
		}
	}

	// Token: 0x0601437E RID: 82814 RVA: 0x005E55F8 File Offset: 0x005E37F8
	public List<FlySkinGridData> GetGridDataList()
	{
		return base.GetData(EFlySkinViewData.GridDataList) as List<FlySkinGridData>;
	}

	// Token: 0x0601437F RID: 82815 RVA: 0x005E5606 File Offset: 0x005E3806
	public void SetSelectedTab(EFlySkinTab? selectedTab, bool? notNotify = false)
	{
		base.SetData(EFlySkinViewData.SelectedTab, selectedTab, notNotify);
	}

	// Token: 0x06014380 RID: 82816 RVA: 0x005E5616 File Offset: 0x005E3816
	public EFlySkinTab? GetSelectedTab()
	{
		return base.GetData(EFlySkinViewData.SelectedTab) as EFlySkinTab?;
	}

	// Token: 0x06014381 RID: 82817 RVA: 0x005E5629 File Offset: 0x005E3829
	public void SetSelectedGridIndex(int gridIndex, bool? notNotify = false)
	{
		base.SetData(EFlySkinViewData.SelectedGridIndex, gridIndex, notNotify);
	}

	// Token: 0x06014382 RID: 82818 RVA: 0x005E5639 File Offset: 0x005E3839
	public int GetSelectedGridIndex()
	{
		return (int)base.GetData(EFlySkinViewData.SelectedGridIndex);
	}

	// Token: 0x06014383 RID: 82819 RVA: 0x005E5648 File Offset: 0x005E3848
	public void Init(ISkinViewData viewData)
	{
		this.RoleDataIdInternal = viewData.RoleId;
		this.SelectedFlySkinIdInternal = viewData.FlySkinId.GetValueOrDefault(-1);
		EFlySkinTab valueOrDefault = viewData.FlySkinTab.GetValueOrDefault();
		this.SetSelectedTab(new EFlySkinTab?(valueOrDefault), new bool?(false));
	}

	// Token: 0x06014384 RID: 82820 RVA: 0x005E5698 File Offset: 0x005E3898
	public void SelectTab(EFlySkinTab tab)
	{
		this.SelectedFlySkinTypeInternal = FlySkinDefine.flySkinTabToType[tab];
		this.ModelCaseInternal = FlySkinDefine.flySkinTypeToCase[this.SelectedFlySkinTypeInternal];
		this.SetSelectedGridIndex(-1, new bool?(true));
		this.UpdateGridData();
		this.SetSelectedTab(new EFlySkinTab?(tab), new bool?(false));
	}

	// Token: 0x06014385 RID: 82821 RVA: 0x005E56F4 File Offset: 0x005E38F4
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
			if (!LinkedItemConfig.Instance.ShouldHide(value.Id, FlySkinModel.Instance.CheckSkinIsUnlock(value.Id)))
			{
				gridDataList.Add(item);
			}
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

	// Token: 0x06014386 RID: 82822 RVA: 0x005E5828 File Offset: 0x005E3A28
	public int? GetGridIndexBySkinId(int skinId)
	{
		int value;
		if (this.SkinIdToGridIndexMapInternal.TryGetValue(skinId, out value))
		{
			return new int?(value);
		}
		return null;
	}

	// Token: 0x06014387 RID: 82823 RVA: 0x005E5858 File Offset: 0x005E3A58
	public void SelectGridByIndex(int index)
	{
		this.SelectedGridDataInternal = this.GetGridDataList()[index];
		this.SelectedFlySkinIdInternal = this.SelectedGridDataInternal.SkinId;
		this.SelectedFlySkinConfigInternal = ((this.SelectedFlySkinIdInternal > 0) ? SkinConfig.Instance.GetFlySkinConfig(this.SelectedFlySkinIdInternal) : null);
		this.UpdateGetWayDataList();
		this.SetSelectedGridIndex(index, new bool?(false));
	}

	// Token: 0x06014388 RID: 82824 RVA: 0x005E58C8 File Offset: 0x005E3AC8
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

	// Token: 0x06014389 RID: 82825 RVA: 0x005E59D2 File Offset: 0x005E3BD2
	public void SetUiShowState(bool state)
	{
		this.UiShowState = state;
	}

	// Token: 0x0601438A RID: 82826 RVA: 0x005E59DB File Offset: 0x005E3BDB
	public void SetIsApplyToAll(bool value)
	{
		this.IsApplyToAll = value;
	}

	// Token: 0x0601438B RID: 82827 RVA: 0x005E59E4 File Offset: 0x005E3BE4
	public void ResetSelectedTab()
	{
		this.SetSelectedTab(null, new bool?(false));
		this.SetSelectedGridIndex(-1, new bool?(false));
	}

	// Token: 0x0601438C RID: 82828 RVA: 0x005E5A14 File Offset: 0x005E3C14
	public UiCameraInputBindingData GetFlySkinTabCameraInputData(UUIDraggableComponent dragItem)
	{
		string rowName = "翱翔滑翔皮肤旋转查看";
		SUiRoleCameraSetting value = UiRoleCameraConfig.Instance.GetRoleCameraConfig(rowName).Value;
		FVectorDouble fvectorDouble = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName(this.ModelCaseInternal).Value, ECollectActorType.UI).D_K2_GetActorLocation();
		return new UiCameraInputBindingData
		{
			DragComponent = dragItem,
			CameraSettingConfig = value,
			SourceLocation = fvectorDouble
		};
	}

	// Token: 0x0400AB9B RID: 43931
	private int RoleDataIdInternal;

	// Token: 0x0400AB9C RID: 43932
	private EFlySkinType SelectedFlySkinTypeInternal = EFlySkinType.Paragliding;

	// Token: 0x0400AB9D RID: 43933
	private int SelectedFlySkinIdInternal = -1;

	// Token: 0x0400AB9E RID: 43934
	private FlySkinConfig? SelectedFlySkinConfigInternal;

	// Token: 0x0400AB9F RID: 43935
	private FlySkinGridData SelectedGridDataInternal;

	// Token: 0x0400ABA0 RID: 43936
	private readonly Dictionary<int, int> SkinIdToGridIndexMapInternal = new Dictionary<int, int>();

	// Token: 0x0400ABA1 RID: 43937
	private List<IFlySkinGetWayData> GetWayDataListInternal;

	// Token: 0x0400ABA2 RID: 43938
	private string ModelCaseInternal = "";

	// Token: 0x0400ABA3 RID: 43939
	public bool UiShowState = true;

	// Token: 0x0400ABA4 RID: 43940
	public bool IsApplyToAll;
}
