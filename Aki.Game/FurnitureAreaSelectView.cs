using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200047A RID: 1146
[NullableContext(2)]
[Nullable(0)]
public class FurnitureAreaSelectView : UiViewBase
{
	// Token: 0x06003B00 RID: 15104 RVA: 0x0014F3A0 File Offset: 0x0014D5A0
	[NullableContext(1)]
	public FurnitureAreaSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06003B01 RID: 15105 RVA: 0x0014F424 File Offset: 0x0014D624
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(3, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUISprite)),
			new ValueTuple<int, Type>(14, typeof(UUISprite)),
			new ValueTuple<int, Type>(15, typeof(UUIText)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIText)),
			new ValueTuple<int, Type>(19, typeof(UUIText)),
			new ValueTuple<int, Type>(20, typeof(UUIText)),
			new ValueTuple<int, Type>(21, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(22, typeof(UUIItem)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(25, typeof(UUIItem)),
			new ValueTuple<int, Type>(26, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(27, typeof(UUIItem)),
			new ValueTuple<int, Type>(28, typeof(UUIItem)),
			new ValueTuple<int, Type>(29, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(21, new Action(this.OnConfirmButtonClick)),
			new ValueTuple<int, Delegate>(24, new Action(this.OnShopButtonClick)),
			new ValueTuple<int, Delegate>(26, new Action(this.OnHandBookButtonClick))
		};
	}

	// Token: 0x06003B02 RID: 15106 RVA: 0x0014F73C File Offset: 0x0014D93C
	protected override UniTask OnBeforeStartAsync()
	{
		FurnitureAreaSelectView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FurnitureAreaSelectView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003B03 RID: 15107 RVA: 0x0014F780 File Offset: 0x0014D980
	protected override void OnStart()
	{
		int num = (this.OpenParam is int) ? ((int)this.OpenParam) : 0;
		if (num == 0)
		{
			num = 101;
		}
		this.SetAreaSelectedData(num);
		FurnitureController.Instance.SetFurnitureAreaRedDotAsRead(num);
		SpringFestivalArea? furnitureAreaConfig = FurnitureConfig.Instance.GetFurnitureAreaConfig(this.CurSelectedAreaId);
		if (furnitureAreaConfig == null)
		{
			return;
		}
		this.SetFloorSelectedData(furnitureAreaConfig.Value.Floor);
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem != null)
		{
			captionItem.SetCloseCallBack(new Action(this.OnCloseClick));
		}
		this.FloorToggleMap.Add(1, base.GetExtendToggle(2));
		this.FloorToggleMap.Add(2, base.GetExtendToggle(3));
		foreach (KeyValuePair<int, UUIExtendToggle> keyValuePair in this.FloorToggleMap)
		{
			int floorId = keyValuePair.Key;
			keyValuePair.Value.OnStateChange.Add(delegate(EToggleState toggleState)
			{
				if (toggleState == EToggleState.ETT_Checked)
				{
					this.OnFloorToggleClick(floorId);
				}
			});
		}
		this.RefreshFloorToggleState();
		this.RefreshFloorAreaRootItemShowState();
	}

	// Token: 0x06003B04 RID: 15108 RVA: 0x0014F8BC File Offset: 0x0014DABC
	protected override void OnBeforeShow()
	{
		this.UpdateAreaItemData();
		this.UpdateLevelItemData();
		this.RefreshAreaItem();
		this.RefreshLevelItem();
		this.RefreshDetail();
		this.RefreshButton();
		this.RefreshFloorRedDot();
	}

	// Token: 0x06003B05 RID: 15109 RVA: 0x0014F8E8 File Offset: 0x0014DAE8
	private void SetFloorSelectedData(int floorId)
	{
		this.CurSelectedFloorId = floorId;
	}

	// Token: 0x06003B06 RID: 15110 RVA: 0x0014F8F1 File Offset: 0x0014DAF1
	private void SetAreaSelectedData(int areaId)
	{
		this.CurSelectedAreaId = areaId;
	}

	// Token: 0x06003B07 RID: 15111 RVA: 0x0014F8FC File Offset: 0x0014DAFC
	private void UpdateAreaItemData()
	{
		foreach (int num in this.FurnitureAreaSelectItemMap.Keys)
		{
			IFurnitureAreaSelectItemData furnitureAreaSelectItemData = this.BuildAreaItemData(num);
			if (furnitureAreaSelectItemData != null)
			{
				if (this.AreaItemDataMap.ContainsKey(num))
				{
					this.AreaItemDataMap[num] = furnitureAreaSelectItemData;
				}
				else
				{
					this.AreaItemDataMap.Add(num, furnitureAreaSelectItemData);
				}
			}
		}
	}

	// Token: 0x06003B08 RID: 15112 RVA: 0x0014F984 File Offset: 0x0014DB84
	private void UpdateLevelItemData()
	{
		IFurnitureAtmosphereLevelData atmosphereLevelData = FurnitureModel.Instance.GetAtmosphereLevelData();
		if (atmosphereLevelData != null)
		{
			this.LevelItemData = atmosphereLevelData;
		}
	}

	// Token: 0x06003B09 RID: 15113 RVA: 0x0014F9A8 File Offset: 0x0014DBA8
	private IFurnitureAreaSelectItemData BuildAreaItemData(int areaId)
	{
		FurnitureModel instance = FurnitureModel.Instance;
		SpringFestivalArea? furnitureAreaConfig = FurnitureConfig.Instance.GetFurnitureAreaConfig(areaId);
		if (furnitureAreaConfig == null)
		{
			return null;
		}
		bool areaIsUnlock = instance.GetAreaIsUnlock(areaId);
		bool isSelected = this.CurSelectedAreaId == areaId;
		int areaPlacedSlotCount = instance.GetAreaPlacedSlotCount(areaId);
		int maxSlotCount = furnitureAreaConfig.Value.MaxSlotCount;
		bool redDotShowState = instance.CheckFurnitureAreaRedDot(areaId);
		return new FurnitureAreaSelectItemData
		{
			AreaId = areaId,
			FloorId = furnitureAreaConfig.Value.Floor,
			AreaName = furnitureAreaConfig.Value.AreaName,
			LockAreaIcon = furnitureAreaConfig.Value.AreaUnFinishedBigIcon,
			UnlockAreaIcon = furnitureAreaConfig.Value.AreaFinishedBigIcon,
			IsSelected = isSelected,
			IsUnlock = areaIsUnlock,
			PlacedSlotCount = areaPlacedSlotCount,
			MaxSlotCount = maxSlotCount,
			RedDotShowState = redDotShowState,
			OnSelected = new Action<int>(this.OnAreaItemClick)
		};
	}

	// Token: 0x06003B0A RID: 15114 RVA: 0x0014FAA4 File Offset: 0x0014DCA4
	public void RefreshAreaItem()
	{
		foreach (KeyValuePair<int, FurnitureAreaSelectItem> keyValuePair in this.FurnitureAreaSelectItemMap)
		{
			int key = keyValuePair.Key;
			FurnitureAreaSelectItem value = keyValuePair.Value;
			IFurnitureAreaSelectItemData data;
			if (this.AreaItemDataMap.TryGetValue(key, out data))
			{
				value.Refresh(data);
			}
		}
	}

	// Token: 0x06003B0B RID: 15115 RVA: 0x0014FB18 File Offset: 0x0014DD18
	public void RefreshFloorToggleState()
	{
		foreach (KeyValuePair<int, UUIExtendToggle> keyValuePair in this.FloorToggleMap)
		{
			int key = keyValuePair.Key;
			keyValuePair.Value.SetToggleState((key == this.CurSelectedFloorId) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x06003B0C RID: 15116 RVA: 0x0014FB8C File Offset: 0x0014DD8C
	public void RefreshFloorAreaRootItemShowState()
	{
		base.GetItem(4).SetUIActive(this.CurSelectedFloorId == 1);
		base.GetItem(11).SetUIActive(this.CurSelectedFloorId == 2);
	}

	// Token: 0x06003B0D RID: 15117 RVA: 0x0014FBBC File Offset: 0x0014DDBC
	public void RefreshDetail()
	{
		SpringFestivalArea? furnitureAreaConfig = FurnitureConfig.Instance.GetFurnitureAreaConfig(this.CurSelectedAreaId);
		if (furnitureAreaConfig == null)
		{
			return;
		}
		FurnitureModel instance = FurnitureModel.Instance;
		bool areaIsUnlock = instance.GetAreaIsUnlock(this.CurSelectedAreaId);
		base.GetItem(17).SetUIActive(!areaIsUnlock);
		base.GetItem(16).SetUIActive(areaIsUnlock);
		base.GetItem(23).SetUIActive(!areaIsUnlock);
		base.GetButton(21).RootUIComp.Get().SetUIActive(areaIsUnlock);
		UUISprite sprite = base.GetSprite(14);
		UUISprite sprite2 = base.GetSprite(13);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(15), furnitureAreaConfig.Value.AreaName, Array.Empty<object>());
		if (!areaIsUnlock)
		{
			sprite.SetUIActive(false);
			sprite2.SetUIActive(true);
			this.SetSpriteByPath(furnitureAreaConfig.Value.AreaUnFinishedSmallIcon, sprite2, false, null, null);
			base.GetItem(22).SetUIActive(false);
			return;
		}
		sprite.SetUIActive(true);
		sprite2.SetUIActive(false);
		this.SetSpriteByPath(furnitureAreaConfig.Value.AreaFinishedSmallIcon, sprite, false, null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(20), furnitureAreaConfig.Value.AreaDescription, Array.Empty<object>());
		int areaAtmosphere = instance.GetAreaAtmosphere(this.CurSelectedAreaId);
		base.GetText(18).SetText(areaAtmosphere.ToString(), true);
		int areaPlacedSlotCount = instance.GetAreaPlacedSlotCount(this.CurSelectedAreaId);
		int maxSlotCount = furnitureAreaConfig.Value.MaxSlotCount;
		bool flag = areaPlacedSlotCount >= maxSlotCount;
		UUIText text = base.GetText(19);
		UUIItem uuiitem = text;
		bool bUseChangeColor = flag;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		LguiUtil.Instance.SetLocalTextNew(text, "DIY_RegionAtmosphere_Content_1", new <>z__ReadOnlyArray<object>(new object[]
		{
			areaPlacedSlotCount,
			maxSlotCount
		}));
		base.GetItem(22).SetUIActive(flag);
	}

	// Token: 0x06003B0E RID: 15118 RVA: 0x0014FDCC File Offset: 0x0014DFCC
	public void PlayDetailSwitchAnimation()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.PlayOrReplaySequenceByName("Switch01", false, null);
	}

	// Token: 0x06003B0F RID: 15119 RVA: 0x0014FDF8 File Offset: 0x0014DFF8
	private void RefreshLevelItem()
	{
		if (this.LevelItemData != null)
		{
			FurnitureAtmosphereLevelItem levelItem = this.LevelItem;
			if (levelItem == null)
			{
				return;
			}
			levelItem.Refresh(this.LevelItemData);
		}
	}

	// Token: 0x06003B10 RID: 15120 RVA: 0x0014FE18 File Offset: 0x0014E018
	public void RefreshButton()
	{
		FurnitureModel instance = FurnitureModel.Instance;
		bool furnitureHandBookFunctionIsUnlocked = instance.GetFurnitureHandBookFunctionIsUnlocked();
		bool furnitureShopFunctionIsUnlocked = instance.GetFurnitureShopFunctionIsUnlocked();
		base.GetButton(24).RootUIComp.Get().SetUIActive(furnitureShopFunctionIsUnlocked);
		base.GetButton(26).RootUIComp.Get().SetUIActive(furnitureHandBookFunctionIsUnlocked);
		if (furnitureShopFunctionIsUnlocked)
		{
			base.GetItem(25).SetUIActive(instance.CheckFurnitureShopRedDot());
		}
		if (furnitureHandBookFunctionIsUnlocked)
		{
			base.GetItem(27).SetUIActive(instance.CheckFurnitureHandBookRedDot());
		}
	}

	// Token: 0x06003B11 RID: 15121 RVA: 0x0014FE9C File Offset: 0x0014E09C
	public void RefreshFirstFloorRedDot()
	{
		UUIItem item = base.GetItem(28);
		FurnitureModel instance = FurnitureModel.Instance;
		item.SetUIActive(instance.CheckFurnitureFloorRedDot(1));
	}

	// Token: 0x06003B12 RID: 15122 RVA: 0x0014FEC4 File Offset: 0x0014E0C4
	public void RefreshSecondFloorRedDot()
	{
		UUIItem item = base.GetItem(29);
		FurnitureModel instance = FurnitureModel.Instance;
		item.SetUIActive(instance.CheckFurnitureFloorRedDot(2));
	}

	// Token: 0x06003B13 RID: 15123 RVA: 0x0014FEEB File Offset: 0x0014E0EB
	public void RefreshFloorRedDot()
	{
		this.RefreshFirstFloorRedDot();
		this.RefreshSecondFloorRedDot();
	}

	// Token: 0x06003B14 RID: 15124 RVA: 0x0014FEFC File Offset: 0x0014E0FC
	private void OnFloorToggleClick(int floorId)
	{
		int curSelectedFloorId = this.CurSelectedFloorId;
		if (curSelectedFloorId == floorId)
		{
			return;
		}
		UUIExtendToggle uuiextendToggle;
		if (this.FloorToggleMap.TryGetValue(curSelectedFloorId, out uuiextendToggle))
		{
			uuiextendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		UUIExtendToggle uuiextendToggle2;
		if (this.FloorToggleMap.TryGetValue(floorId, out uuiextendToggle2))
		{
			uuiextendToggle2.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}
		this.SetFloorSelectedData(floorId);
		this.RefreshFloorAreaRootItemShowState();
		this.PlayFloorSwitchAnimation();
	}

	// Token: 0x06003B15 RID: 15125 RVA: 0x0014FF60 File Offset: 0x0014E160
	private void PlayFloorSwitchAnimation()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.PlayOrReplaySequenceByName("Switch", false, null);
	}

	// Token: 0x06003B16 RID: 15126 RVA: 0x0014FF8C File Offset: 0x0014E18C
	private void OnAreaItemClick(int areaId)
	{
		int curSelectedAreaId = this.CurSelectedAreaId;
		if (curSelectedAreaId == areaId)
		{
			return;
		}
		FurnitureAreaSelectItem furnitureAreaSelectItem = null;
		this.FurnitureAreaSelectItemMap.TryGetValue(curSelectedAreaId, out furnitureAreaSelectItem);
		IFurnitureAreaSelectItemData furnitureAreaSelectItemData;
		if (this.AreaItemDataMap.TryGetValue(curSelectedAreaId, out furnitureAreaSelectItemData))
		{
			furnitureAreaSelectItemData.IsSelected = false;
		}
		if (furnitureAreaSelectItem != null)
		{
			furnitureAreaSelectItem.RefreshToggleState();
		}
		FurnitureAreaSelectItem furnitureAreaSelectItem2 = null;
		this.FurnitureAreaSelectItemMap.TryGetValue(areaId, out furnitureAreaSelectItem2);
		IFurnitureAreaSelectItemData furnitureAreaSelectItemData2;
		if (this.AreaItemDataMap.TryGetValue(areaId, out furnitureAreaSelectItemData2))
		{
			furnitureAreaSelectItemData2.IsSelected = true;
			if (furnitureAreaSelectItemData2.RedDotShowState)
			{
				FurnitureController.Instance.SetFurnitureAreaRedDotAsRead(areaId);
				furnitureAreaSelectItemData2.RedDotShowState = false;
			}
		}
		if (furnitureAreaSelectItem2 != null && furnitureAreaSelectItemData2 != null)
		{
			furnitureAreaSelectItem2.RefreshToggleState();
			furnitureAreaSelectItem2.RefreshRedDot();
			int floorId = furnitureAreaSelectItemData2.FloorId;
			if (floorId == 1)
			{
				this.RefreshFirstFloorRedDot();
			}
			else if (floorId == 2)
			{
				this.RefreshSecondFloorRedDot();
			}
		}
		this.SetAreaSelectedData(areaId);
		this.RefreshDetail();
		this.PlayDetailSwitchAnimation();
	}

	// Token: 0x06003B17 RID: 15127 RVA: 0x00150062 File Offset: 0x0014E262
	private void OnCloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06003B18 RID: 15128 RVA: 0x0015006C File Offset: 0x0014E26C
	private void OnConfirmButtonClick()
	{
		if (!FurnitureModel.Instance.GetAreaIsUnlock(this.CurSelectedAreaId))
		{
			return;
		}
		FurnitureDesignViewOpenData param = new FurnitureDesignViewOpenData
		{
			MapId = FurnitureModel.Instance.MapId,
			ToSelectAreaId = this.CurSelectedAreaId
		};
		UiManager.Instance.OpenView(EUiViewName.FurnitureDesignView, param, null);
	}

	// Token: 0x06003B19 RID: 15129 RVA: 0x001500BF File Offset: 0x0014E2BF
	private void OnShopButtonClick()
	{
		FurnitureController.Instance.OpenFurnitureShopViewAsync(0);
	}

	// Token: 0x06003B1A RID: 15130 RVA: 0x001500CD File Offset: 0x0014E2CD
	private void OnHandBookButtonClick()
	{
		UiManager.Instance.OpenView(EUiViewName.FurnitureHandBookView, null, null);
	}

	// Token: 0x06003B1B RID: 15131 RVA: 0x001500E0 File Offset: 0x0014E2E0
	private void OnLockTipButtonClick()
	{
		UiManager.Instance.OpenView(EUiViewName.SpringManorAtmosphereLevelView, null, null);
	}

	// Token: 0x04002F97 RID: 12183
	private int CurSelectedFloorId;

	// Token: 0x04002F98 RID: 12184
	private int CurSelectedAreaId;

	// Token: 0x04002F99 RID: 12185
	[Nullable(1)]
	private readonly Dictionary<int, IFurnitureAreaSelectItemData> AreaItemDataMap = new Dictionary<int, IFurnitureAreaSelectItemData>();

	// Token: 0x04002F9A RID: 12186
	private PopupCaptionItem CaptionItem;

	// Token: 0x04002F9B RID: 12187
	private IFurnitureAtmosphereLevelData LevelItemData;

	// Token: 0x04002F9C RID: 12188
	private FurnitureAtmosphereLevelItem LevelItem;

	// Token: 0x04002F9D RID: 12189
	private FurnitureAreaFinishTipItem FinishTipItem;

	// Token: 0x04002F9E RID: 12190
	private FurnitureAreaLockTipItem LockTipItem;

	// Token: 0x04002F9F RID: 12191
	[Nullable(1)]
	private readonly Dictionary<int, UUIExtendToggle> FloorToggleMap = new Dictionary<int, UUIExtendToggle>();

	// Token: 0x04002FA0 RID: 12192
	[Nullable(1)]
	private readonly Dictionary<int, FurnitureAreaSelectItem> FurnitureAreaSelectItemMap = new Dictionary<int, FurnitureAreaSelectItem>();

	// Token: 0x04002FA1 RID: 12193
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04002FA2 RID: 12194
	[Nullable(1)]
	private readonly Dictionary<int, int> AreaItemBindMap = new Dictionary<int, int>
	{
		{
			5,
			106
		},
		{
			6,
			104
		},
		{
			7,
			102
		},
		{
			8,
			101
		},
		{
			9,
			103
		},
		{
			10,
			105
		},
		{
			12,
			107
		}
	};
}
