using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.UiCamera;
using UnrealEngine;

// Token: 0x02001FBF RID: 8127
[NullableContext(1)]
[Nullable(0)]
public class CalabashSkinViewProxy : global::ViewModelBase<ECalabashSkinViewData>
{
	// Token: 0x060142C8 RID: 82632 RVA: 0x005E3054 File Offset: 0x005E1254
	public CalabashSkinViewProxy()
	{
		List<CalabashSkinData> value = new List<CalabashSkinData>();
		this.DataMap.Add(ECalabashSkinViewData.SkinDataList, value);
		this.DataMap.Add(ECalabashSkinViewData.EquipSkinId, 0);
		this.DataMap.Add(ECalabashSkinViewData.SelectedSkinId, 0);
	}

	// Token: 0x17001E3A RID: 7738
	// (get) Token: 0x060142C9 RID: 82633 RVA: 0x005E309E File Offset: 0x005E129E
	public bool NeedStopRotate
	{
		get
		{
			return this.NeedStopRotateInternal;
		}
	}

	// Token: 0x17001E3B RID: 7739
	// (get) Token: 0x060142CA RID: 82634 RVA: 0x005E30A6 File Offset: 0x005E12A6
	public int FailRequestCd
	{
		get
		{
			return this.FailRequestCdInternal;
		}
	}

	// Token: 0x060142CB RID: 82635 RVA: 0x005E30B0 File Offset: 0x005E12B0
	public void Init(ISkinViewData viewData)
	{
		this.SkinIdFromSkipInternal = viewData.CalabashSkinId.GetValueOrDefault();
		this.FailRequestCdInternal = SkinConfig.Instance.GetCalabashSkinFailRequestCd();
		this.NeedStopRotateInternal = SkinConfig.Instance.GetCalabashSkinNeedStopRotate();
		this.InitSkinDataList();
		this.InitGridSelected();
	}

	// Token: 0x060142CC RID: 82636 RVA: 0x005E30FD File Offset: 0x005E12FD
	public List<CalabashSkinData> GetSkinDataList()
	{
		return base.GetData(ECalabashSkinViewData.SkinDataList) as List<CalabashSkinData>;
	}

	// Token: 0x060142CD RID: 82637 RVA: 0x005E310B File Offset: 0x005E130B
	public CalabashSkinData GetSkinDataByIndex(int index)
	{
		return this.GetSkinDataList()[index];
	}

	// Token: 0x060142CE RID: 82638 RVA: 0x005E311C File Offset: 0x005E131C
	public CalabashSkinData GetSkinDataBySkinId(int skinId)
	{
		int dataIndexBySkinId = this.GetDataIndexBySkinId(skinId);
		return this.GetSkinDataByIndex(dataIndexBySkinId);
	}

	// Token: 0x060142CF RID: 82639 RVA: 0x005E3138 File Offset: 0x005E1338
	public void SetEquipSkinId(int skinId, bool notNotify = false)
	{
		this.PrevEquipSkinIdInternal = this.GetEquipSkinId();
		base.SetData(ECalabashSkinViewData.EquipSkinId, skinId, new bool?(notNotify));
	}

	// Token: 0x060142D0 RID: 82640 RVA: 0x005E3159 File Offset: 0x005E1359
	public int GetEquipSkinId()
	{
		return (int)base.GetData(ECalabashSkinViewData.EquipSkinId);
	}

	// Token: 0x060142D1 RID: 82641 RVA: 0x005E3167 File Offset: 0x005E1367
	public void SetSelectedSkinId(int skinId, bool notNotify = false)
	{
		base.SetData(ECalabashSkinViewData.SelectedSkinId, skinId, new bool?(notNotify));
	}

	// Token: 0x060142D2 RID: 82642 RVA: 0x005E317C File Offset: 0x005E137C
	public int GetSelectedSkinId()
	{
		return (int)base.GetData(ECalabashSkinViewData.SelectedSkinId);
	}

	// Token: 0x060142D3 RID: 82643 RVA: 0x005E318A File Offset: 0x005E138A
	public void SetGetDragItemFunc(Func<UUIDraggableComponent> getDragItemFunc)
	{
		this.GetDragItemFunc = getDragItemFunc;
	}

	// Token: 0x17001E3C RID: 7740
	// (get) Token: 0x060142D4 RID: 82644 RVA: 0x005E3193 File Offset: 0x005E1393
	public int PrevEquipSkinId
	{
		get
		{
			return this.PrevEquipSkinIdInternal;
		}
	}

	// Token: 0x060142D5 RID: 82645 RVA: 0x005E319B File Offset: 0x005E139B
	public UUIDraggableComponent GetDragItem()
	{
		Func<UUIDraggableComponent> getDragItemFunc = this.GetDragItemFunc;
		if (getDragItemFunc == null)
		{
			return null;
		}
		return getDragItemFunc();
	}

	// Token: 0x060142D6 RID: 82646 RVA: 0x005E31AE File Offset: 0x005E13AE
	private CalabashSkinData CreateCalabashSkinGridData(int skinId)
	{
		return new CalabashSkinData(skinId);
	}

	// Token: 0x060142D7 RID: 82647 RVA: 0x005E31B8 File Offset: 0x005E13B8
	public int GetDataIndexBySkinId(int skinId)
	{
		int num = this.GetSkinDataList().FindIndex((CalabashSkinData data) => data.SkinId == skinId);
		return (num < 0) ? 0 : num;
	}

	// Token: 0x060142D8 RID: 82648 RVA: 0x005E31F4 File Offset: 0x005E13F4
	public UiCameraInputBindingData GetCalabashSkinTabCameraInputData()
	{
		SUiRoleCameraSetting? roleCameraConfig = UiRoleCameraConfig.Instance.GetRoleCameraConfig("葫芦皮肤旋转查看");
		FVectorDouble fvectorDouble = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("TerminalCase").Value, ECollectActorType.UI).D_K2_GetActorLocation();
		return new UiCameraInputBindingData
		{
			DragComponent = this.GetDragItem(),
			CameraSettingConfig = roleCameraConfig.Value,
			SourceLocation = fvectorDouble
		};
	}

	// Token: 0x060142D9 RID: 82649 RVA: 0x005E325C File Offset: 0x005E145C
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

	// Token: 0x060142DA RID: 82650 RVA: 0x005E32AC File Offset: 0x005E14AC
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

	// Token: 0x060142DB RID: 82651 RVA: 0x005E337C File Offset: 0x005E157C
	public bool CalabashGridItemCanExecuteChange(object parameters, bool _, EToggleState state)
	{
		int skinId = (parameters as CalabashSkinData).SkinId;
		return this.GetSelectedSkinId() != skinId;
	}

	// Token: 0x0400AB5C RID: 43868
	private bool NeedStopRotateInternal;

	// Token: 0x0400AB5D RID: 43869
	private int FailRequestCdInternal;

	// Token: 0x0400AB5E RID: 43870
	private int PrevEquipSkinIdInternal;

	// Token: 0x0400AB5F RID: 43871
	private int SkinIdFromSkipInternal;

	// Token: 0x0400AB60 RID: 43872
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<UUIDraggableComponent> GetDragItemFunc;

	// Token: 0x0400AB61 RID: 43873
	public bool NeedLoadModel;
}
