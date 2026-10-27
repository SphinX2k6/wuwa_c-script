using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Module.Common.UiCamera;
using CSharpScript.Game.Module.Skin;
using UnrealEngine;

// Token: 0x02002A44 RID: 10820
[NullableContext(1)]
[Nullable(0)]
public class CalabashSkinViewProxy : global::ViewModelBase<ECalabashSkinViewData>
{
	// Token: 0x060168A7 RID: 92327 RVA: 0x005B6F10 File Offset: 0x005B5110
	public CalabashSkinViewProxy()
	{
		List<CalabashSkinData> value = new List<CalabashSkinData>();
		this.DataMap.Add(ECalabashSkinViewData.SkinDataList, value);
		this.DataMap.Add(ECalabashSkinViewData.EquipSkinId, 0);
		this.DataMap.Add(ECalabashSkinViewData.SelectedSkinId, 0);
	}

	// Token: 0x17001DE2 RID: 7650
	// (get) Token: 0x060168A8 RID: 92328 RVA: 0x005B6F5A File Offset: 0x005B515A
	public bool NeedStopRotate
	{
		get
		{
			return this.NeedStopRotateInternal;
		}
	}

	// Token: 0x17001DE3 RID: 7651
	// (get) Token: 0x060168A9 RID: 92329 RVA: 0x005B6F62 File Offset: 0x005B5162
	public int FailRequestCd
	{
		get
		{
			return this.FailRequestCdInternal;
		}
	}

	// Token: 0x060168AA RID: 92330 RVA: 0x005B6F6C File Offset: 0x005B516C
	public void Init(ISkinViewData viewData)
	{
		this.SkinIdFromSkipInternal = viewData.CalabashSkinId.GetValueOrDefault();
		this.FailRequestCdInternal = SkinConfig.Instance.GetCalabashSkinFailRequestCd();
		this.NeedStopRotateInternal = SkinConfig.Instance.GetCalabashSkinNeedStopRotate();
		this.InitSkinDataList();
		this.InitGridSelected();
	}

	// Token: 0x060168AB RID: 92331 RVA: 0x005B6FB9 File Offset: 0x005B51B9
	public List<CalabashSkinData> GetSkinDataList()
	{
		return base.GetData(ECalabashSkinViewData.SkinDataList) as List<CalabashSkinData>;
	}

	// Token: 0x060168AC RID: 92332 RVA: 0x005B6FC7 File Offset: 0x005B51C7
	public CalabashSkinData GetSkinDataByIndex(int index)
	{
		return this.GetSkinDataList()[index];
	}

	// Token: 0x060168AD RID: 92333 RVA: 0x005B6FD8 File Offset: 0x005B51D8
	public CalabashSkinData GetSkinDataBySkinId(int skinId)
	{
		int dataIndexBySkinId = this.GetDataIndexBySkinId(skinId);
		return this.GetSkinDataByIndex(dataIndexBySkinId);
	}

	// Token: 0x060168AE RID: 92334 RVA: 0x005B6FF4 File Offset: 0x005B51F4
	public void SetEquipSkinId(int skinId, bool notNotify = false)
	{
		this.PrevEquipSkinIdInternal = this.GetEquipSkinId();
		base.SetData(ECalabashSkinViewData.EquipSkinId, skinId, new bool?(notNotify));
	}

	// Token: 0x060168AF RID: 92335 RVA: 0x005B7015 File Offset: 0x005B5215
	public int GetEquipSkinId()
	{
		return (int)base.GetData(ECalabashSkinViewData.EquipSkinId);
	}

	// Token: 0x060168B0 RID: 92336 RVA: 0x005B7023 File Offset: 0x005B5223
	public void SetSelectedSkinId(int skinId, bool notNotify = false)
	{
		base.SetData(ECalabashSkinViewData.SelectedSkinId, skinId, new bool?(notNotify));
	}

	// Token: 0x060168B1 RID: 92337 RVA: 0x005B7038 File Offset: 0x005B5238
	public int GetSelectedSkinId()
	{
		return (int)base.GetData(ECalabashSkinViewData.SelectedSkinId);
	}

	// Token: 0x060168B2 RID: 92338 RVA: 0x005B7046 File Offset: 0x005B5246
	public void SetGetDragItemFunc(Func<UUIDraggableComponent> getDragItemFunc)
	{
		this.GetDragItemFunc = getDragItemFunc;
	}

	// Token: 0x17001DE4 RID: 7652
	// (get) Token: 0x060168B3 RID: 92339 RVA: 0x005B704F File Offset: 0x005B524F
	public int PrevEquipSkinId
	{
		get
		{
			return this.PrevEquipSkinIdInternal;
		}
	}

	// Token: 0x060168B4 RID: 92340 RVA: 0x005B7057 File Offset: 0x005B5257
	public UUIDraggableComponent GetDragItem()
	{
		Func<UUIDraggableComponent> getDragItemFunc = this.GetDragItemFunc;
		if (getDragItemFunc == null)
		{
			return null;
		}
		return getDragItemFunc();
	}

	// Token: 0x060168B5 RID: 92341 RVA: 0x005B706A File Offset: 0x005B526A
	private CalabashSkinData CreateCalabashSkinGridData(int skinId)
	{
		return new CalabashSkinData(skinId);
	}

	// Token: 0x060168B6 RID: 92342 RVA: 0x005B7074 File Offset: 0x005B5274
	public int GetDataIndexBySkinId(int skinId)
	{
		int num = this.GetSkinDataList().FindIndex((CalabashSkinData data) => data.SkinId == skinId);
		return (num < 0) ? 0 : num;
	}

	// Token: 0x060168B7 RID: 92343 RVA: 0x005B70B0 File Offset: 0x005B52B0
	public IUiCameraInputComponentData GetCalabashSkinTabCameraInputData()
	{
		SUiRoleCameraSetting? roleCameraConfig = UiRoleCameraConfig.Instance.GetRoleCameraConfig("葫芦皮肤旋转查看");
		FVectorDouble fvectorDouble = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("TerminalCase").Value, ECollectActorType.UI).D_K2_GetActorLocation();
		return new UiCameraInputComponentData
		{
			DragComponent = this.GetDragItem(),
			CameraSettingConfig = roleCameraConfig.Value,
			SourceLocation = fvectorDouble
		};
	}

	// Token: 0x060168B8 RID: 92344 RVA: 0x005B7118 File Offset: 0x005B5318
	public void InitGridSelected()
	{
		if (this.SkinIdFromSkipInternal != 0)
		{
			this.SetSelectedSkinId(this.SkinIdFromSkipInternal, false);
		}
		else
		{
			this.SetSelectedSkinId(CalabashSkinModel.Instance.GetCurrentEquipSkinId(), false);
		}
		int currentEquipSkinId = CalabashSkinModel.Instance.GetCurrentEquipSkinId();
		this.PrevEquipSkinIdInternal = currentEquipSkinId;
		this.SetEquipSkinId(currentEquipSkinId, false);
	}

	// Token: 0x060168B9 RID: 92345 RVA: 0x005B7168 File Offset: 0x005B5368
	public void InitSkinDataList()
	{
		IEnumerable<CalabashSkin> calabashSkinConfigList = SkinConfig.Instance.GetCalabashSkinConfigList();
		CalabashSkinData item = this.CreateCalabashSkinGridData(0);
		List<CalabashSkinData> skinDataList = this.GetSkinDataList();
		skinDataList.Add(item);
		foreach (CalabashSkin calabashSkin in calabashSkinConfigList)
		{
			CalabashSkin calabashSkinConfig = SkinConfig.Instance.GetCalabashSkinConfig(calabashSkin.Id);
			if (InventoryModel.Instance.GetItemCountByConfigId(calabashSkinConfig.Id, 0) > 0 || calabashSkinConfig.ShowWhenLocked)
			{
				CalabashSkinData item2 = this.CreateCalabashSkinGridData(calabashSkin.Id);
				skinDataList.Add(item2);
			}
		}
		skinDataList.Sort(delegate(CalabashSkinData aSkinData, CalabashSkinData bSkinData)
		{
			if (aSkinData.IsEmptyData != bSkinData.IsEmptyData)
			{
				if (!aSkinData.IsEmptyData)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				bool isLock = aSkinData.GetIsLock();
				bool isLock2 = bSkinData.GetIsLock();
				if (isLock == isLock2)
				{
					return bSkinData.SortIndex - aSkinData.SortIndex;
				}
				if (!isLock)
				{
					return -1;
				}
				return 1;
			}
		});
	}

	// Token: 0x060168BA RID: 92346 RVA: 0x005B7238 File Offset: 0x005B5438
	public bool CalabashGridItemCanExecuteChange(object parameters, bool _, EToggleState state)
	{
		int skinId = (parameters as CalabashSkinData).SkinId;
		return this.GetSelectedSkinId() != skinId;
	}

	// Token: 0x0400A758 RID: 42840
	private bool NeedStopRotateInternal;

	// Token: 0x0400A759 RID: 42841
	private int FailRequestCdInternal;

	// Token: 0x0400A75A RID: 42842
	private int PrevEquipSkinIdInternal;

	// Token: 0x0400A75B RID: 42843
	private int SkinIdFromSkipInternal;

	// Token: 0x0400A75C RID: 42844
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<UUIDraggableComponent> GetDragItemFunc;

	// Token: 0x0400A75D RID: 42845
	public bool NeedLoadModel;
}
