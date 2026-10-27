using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000FC5 RID: 4037
[NullableContext(2)]
[Nullable(0)]
public class FurnitureAreaSelectView : UiViewBase
{
	// Token: 0x06006768 RID: 26472 RVA: 0x00146ADC File Offset: 0x00144CDC
	[NullableContext(1)]
	public FurnitureAreaSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006769 RID: 26473 RVA: 0x00146B60 File Offset: 0x00144D60
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

	// Token: 0x0600676A RID: 26474 RVA: 0x00146E78 File Offset: 0x00145078
	protected override UniTask OnBeforeStartAsync()
	{
		FurnitureAreaSelectView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FurnitureAreaSelectView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600676B RID: 26475 RVA: 0x00146EBC File Offset: 0x001450BC
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

	// Token: 0x0600676C RID: 26476 RVA: 0x00146FF8 File Offset: 0x001451F8
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

	// Token: 0x0600676D RID: 26477 RVA: 0x00147024 File Offset: 0x00145224
	private void SetFloorSelectedData(int floorId)
	{
		this.CurSelectedFloorId = floorId;
	}

	// Token: 0x0600676E RID: 26478 RVA: 0x0014702D File Offset: 0x0014522D
	private void SetAreaSelectedData(int areaId)
	{
		this.CurSelectedAreaId = areaId;
	}

	// Token: 0x0600676F RID: 26479 RVA: 0x00147038 File Offset: 0x00145238
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

	// Token: 0x06006770 RID: 26480 RVA: 0x001470C0 File Offset: 0x001452C0
	private void UpdateLevelItemData()
	{
		IFurnitureAtmosphereLevelData atmosphereLevelData = FurnitureModel.Instance.GetAtmosphereLevelData();
		if (atmosphereLevelData != null)
		{
			this.LevelItemData = atmosphereLevelData;
		}
	}

	// Token: 0x06006771 RID: 26481 RVA: 0x001470E4 File Offset: 0x001452E4
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

	// Token: 0x06006772 RID: 26482 RVA: 0x001471E0 File Offset: 0x001453E0
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

	// Token: 0x06006773 RID: 26483 RVA: 0x00147254 File Offset: 0x00145454
	public void RefreshFloorToggleState()
	{
		foreach (KeyValuePair<int, UUIExtendToggle> keyValuePair in this.FloorToggleMap)
		{
			int key = keyValuePair.Key;
			keyValuePair.Value.SetToggleState((key == this.CurSelectedFloorId) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x06006774 RID: 26484 RVA: 0x001472C8 File Offset: 0x001454C8
	public void RefreshFloorAreaRootItemShowState()
	{
		base.GetItem(4).SetUIActive(this.CurSelectedFloorId == 1);
		base.GetItem(11).SetUIActive(this.CurSelectedFloorId == 2);
	}

	// Token: 0x06006775 RID: 26485 RVA: 0x001472F8 File Offset: 0x001454F8
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

	// Token: 0x06006776 RID: 26486 RVA: 0x00147508 File Offset: 0x00145708
	public void PlayDetailSwitchAnimation()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.PlayOrReplaySequenceByName("Switch01", false, null);
	}

	// Token: 0x06006777 RID: 26487 RVA: 0x00147534 File Offset: 0x00145734
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

	// Token: 0x06006778 RID: 26488 RVA: 0x00147554 File Offset: 0x00145754
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

	// Token: 0x06006779 RID: 26489 RVA: 0x001475D8 File Offset: 0x001457D8
	public void RefreshFirstFloorRedDot()
	{
		UUIItem item = base.GetItem(28);
		FurnitureModel instance = FurnitureModel.Instance;
		item.SetUIActive(instance.CheckFurnitureFloorRedDot(1));
	}

	// Token: 0x0600677A RID: 26490 RVA: 0x00147600 File Offset: 0x00145800
	public void RefreshSecondFloorRedDot()
	{
		UUIItem item = base.GetItem(29);
		FurnitureModel instance = FurnitureModel.Instance;
		item.SetUIActive(instance.CheckFurnitureFloorRedDot(2));
	}

	// Token: 0x0600677B RID: 26491 RVA: 0x00147627 File Offset: 0x00145827
	public void RefreshFloorRedDot()
	{
		this.RefreshFirstFloorRedDot();
		this.RefreshSecondFloorRedDot();
	}

	// Token: 0x0600677C RID: 26492 RVA: 0x00147638 File Offset: 0x00145838
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

	// Token: 0x0600677D RID: 26493 RVA: 0x0014769C File Offset: 0x0014589C
	private void PlayFloorSwitchAnimation()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.PlayOrReplaySequenceByName("Switch", false, null);
	}

	// Token: 0x0600677E RID: 26494 RVA: 0x001476C8 File Offset: 0x001458C8
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

	// Token: 0x0600677F RID: 26495 RVA: 0x0014779E File Offset: 0x0014599E
	private void OnCloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06006780 RID: 26496 RVA: 0x001477A8 File Offset: 0x001459A8
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

	// Token: 0x06006781 RID: 26497 RVA: 0x001477FB File Offset: 0x001459FB
	private void OnShopButtonClick()
	{
		FurnitureController.Instance.OpenFurnitureShopViewAsync(0);
	}

	// Token: 0x06006782 RID: 26498 RVA: 0x00147809 File Offset: 0x00145A09
	private void OnHandBookButtonClick()
	{
		UiManager.Instance.OpenView(EUiViewName.FurnitureHandBookView, null, null);
	}

	// Token: 0x06006783 RID: 26499 RVA: 0x0014781C File Offset: 0x00145A1C
	private void OnLockTipButtonClick()
	{
		UiManager.Instance.OpenView(EUiViewName.SpringManorAtmosphereLevelView, null, null);
	}

	// Token: 0x04002EFE RID: 12030
	private int CurSelectedFloorId;

	// Token: 0x04002EFF RID: 12031
	private int CurSelectedAreaId;

	// Token: 0x04002F00 RID: 12032
	[Nullable(1)]
	private readonly Dictionary<int, IFurnitureAreaSelectItemData> AreaItemDataMap = new Dictionary<int, IFurnitureAreaSelectItemData>();

	// Token: 0x04002F01 RID: 12033
	private PopupCaptionItem CaptionItem;

	// Token: 0x04002F02 RID: 12034
	private IFurnitureAtmosphereLevelData LevelItemData;

	// Token: 0x04002F03 RID: 12035
	private FurnitureAtmosphereLevelItem LevelItem;

	// Token: 0x04002F04 RID: 12036
	private FurnitureAreaFinishTipItem FinishTipItem;

	// Token: 0x04002F05 RID: 12037
	private FurnitureAreaLockTipItem LockTipItem;

	// Token: 0x04002F06 RID: 12038
	[Nullable(1)]
	private readonly Dictionary<int, UUIExtendToggle> FloorToggleMap = new Dictionary<int, UUIExtendToggle>();

	// Token: 0x04002F07 RID: 12039
	[Nullable(1)]
	private readonly Dictionary<int, FurnitureAreaSelectItem> FurnitureAreaSelectItemMap = new Dictionary<int, FurnitureAreaSelectItem>();

	// Token: 0x04002F08 RID: 12040
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04002F09 RID: 12041
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
