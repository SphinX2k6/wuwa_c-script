using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;
using Google.Protobuf.Collections;

// Token: 0x02002299 RID: 8857
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MotorcycleDiyModel : ModelBase
{
	// Token: 0x06011469 RID: 70761 RVA: 0x00436F28 File Offset: 0x00435128
	protected override bool OnInit()
	{
		this.CurUsingStickerDict[EStickerParts.AleftPart] = 0;
		this.CurUsingStickerDict[EStickerParts.ArightPart] = 0;
		this.CurUsingStickerDict[EStickerParts.BPart] = 0;
		this.CurUsingDecorationDict[EDecorationParts.HeadPart] = 0;
		this.InitSceneData();
		return true;
	}

	// Token: 0x0601146A RID: 70762 RVA: 0x00436F68 File Offset: 0x00435168
	private void InitSceneData()
	{
		foreach (MotorScene motorScene in MotorDiyConfig.Instance.GetAllMotorSceneList())
		{
			this.SceneIdList.Add(motorScene.Id);
			if (motorScene.DefaultFlag)
			{
				this.DefaultSceneId = motorScene.Id;
			}
			else
			{
				this.SceneItemIdSet.Add(motorScene.UnlockItem);
			}
		}
		this.CurSceneId = this.DefaultSceneId;
	}

	// Token: 0x0601146B RID: 70763 RVA: 0x00436FFC File Offset: 0x004351FC
	private void AddMotorOutlookItemList(Dictionary<int, int> dataMap)
	{
		List<AddCountItemInfo> list = new List<AddCountItemInfo>();
		foreach (KeyValuePair<int, int> keyValuePair in dataMap)
		{
			AddCountItemInfo addCountItemInfo = AddCountItemInfo.Create();
			addCountItemInfo.Id = keyValuePair.Key;
			addCountItemInfo.Count = keyValuePair.Value;
			addCountItemInfo.IncrId = 0;
			list.Add(addCountItemInfo);
		}
		ItemHintModel.Instance.MainInterfaceInsertItemRewardInfo(list.ToArray());
	}

	// Token: 0x0601146C RID: 70764 RVA: 0x00437088 File Offset: 0x00435288
	private void InitRedDotInfo()
	{
		if (this.RedDotCache != null)
		{
			return;
		}
		this.RedDotCache = (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.MotorDiyNewUnlockId) as ServerStorageSet);
	}

	// Token: 0x0601146D RID: 70765 RVA: 0x004370AA File Offset: 0x004352AA
	private void TryInitSceneRedDotInfo()
	{
		if (this.SceneRedDotCache != null)
		{
			return;
		}
		this.SceneRedDotCache = (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.MotorSceneHadCheck) as ServerStorageSet);
	}

	// Token: 0x0601146E RID: 70766 RVA: 0x004370CC File Offset: 0x004352CC
	private void CheckLocalSaveItemIds(EOutlookType outlookType, List<int> itemIds, bool isSkin = false)
	{
		object obj = null;
		bool? flag = null;
		foreach (int num in itemIds)
		{
			if (!this.ProcessedItemIds.Contains(num) && num != 0)
			{
				if (outlookType == EOutlookType.Frame)
				{
					MotorFrame? motorFrameConfig = MotorDiyConfig.Instance.GetMotorFrameConfig(num);
					obj = motorFrameConfig;
					flag = new bool?(motorFrameConfig != null && motorFrameConfig.Value.DefaultFlag);
				}
				else if (outlookType == EOutlookType.Sticker)
				{
					MotorSticker? motorStickerConfig = MotorDiyConfig.Instance.GetMotorStickerConfig(num);
					obj = motorStickerConfig;
					flag = new bool?(motorStickerConfig != null && motorStickerConfig.Value.FreeFlag);
				}
				else if (outlookType == EOutlookType.Decoration)
				{
					MotorDecorations? motorDecorationConfig = MotorDiyConfig.Instance.GetMotorDecorationConfig(num);
					obj = motorDecorationConfig;
					flag = new bool?(motorDecorationConfig != null && motorDecorationConfig.Value.FreeFlag);
				}
				else if (isSkin)
				{
					MotorSkin? motorSkinConfig = MotorDiyConfig.Instance.GetMotorSkinConfig(num);
					obj = motorSkinConfig;
					flag = new bool?(motorSkinConfig != null && motorSkinConfig.Value.DefaultFlag);
				}
				if (obj != null)
				{
					this.ProcessedItemIds.Add(num);
					bool flag2 = this.RedDotCache.Has(num);
					if (flag.GetValueOrDefault())
					{
						if (flag2)
						{
							this.RedDotCache.Remove(num);
						}
					}
					else if (!flag2)
					{
						this.RedDotCache.Add(num);
					}
				}
			}
		}
	}

	// Token: 0x0601146F RID: 70767 RVA: 0x00437284 File Offset: 0x00435484
	private void UpdateOwnedOutlookInfo(MotorOutlookOwnedPb ownedOutlookData)
	{
		if (ownedOutlookData.SkinOwned != null)
		{
			this.OwnedSkinIds = new List<int>(ownedOutlookData.SkinOwned);
		}
		if (ownedOutlookData.StickerOwned != null)
		{
			this.OwnedStickerIds = new List<int>(ownedOutlookData.StickerOwned);
		}
		if (ownedOutlookData.FrameOwned != null)
		{
			this.OwnedFrameIds = new List<int>(ownedOutlookData.FrameOwned);
		}
		if (ownedOutlookData.DecorationsOwned != null)
		{
			this.OwnedDecorationsIds = new List<int>(ownedOutlookData.DecorationsOwned);
		}
	}

	// Token: 0x06011470 RID: 70768 RVA: 0x004372F8 File Offset: 0x004354F8
	[NullableContext(2)]
	private void UpdateRedDotInfo(IList<int> skinOwned, IList<int> stickerOwned, IList<int> frameOwned, IList<int> decorationsOwned)
	{
		if (skinOwned != null && skinOwned.Count > 0)
		{
			this.CheckLocalSaveItemIds(EOutlookType.None, new List<int>(skinOwned), true);
		}
		if (stickerOwned != null && stickerOwned.Count > 0)
		{
			this.CheckLocalSaveItemIds(EOutlookType.Sticker, new List<int>(stickerOwned), false);
		}
		if (frameOwned != null && frameOwned.Count > 0)
		{
			this.CheckLocalSaveItemIds(EOutlookType.Frame, new List<int>(frameOwned), false);
		}
		if (decorationsOwned != null && decorationsOwned.Count > 0)
		{
			this.CheckLocalSaveItemIds(EOutlookType.Decoration, new List<int>(decorationsOwned), false);
		}
	}

	// Token: 0x06011471 RID: 70769 RVA: 0x00437370 File Offset: 0x00435570
	private void UpdateEquippedOutlookInfo(MotorOutlookEquippedPb equippedOutlookData)
	{
		int curSkinId = this.CurSkinId;
		this.CurSkinId = equippedOutlookData.SkinEquipped;
		RepeatedField<int> stickerEquipped = equippedOutlookData.StickerEquipped;
		if (stickerEquipped != null)
		{
			for (int i = 0; i < stickerEquipped.Count; i++)
			{
				int value = stickerEquipped[i];
				EStickerParts key = i + EStickerParts.AleftPart;
				this.CurUsingStickerDict[key] = value;
			}
		}
		this.CurFrameId = equippedOutlookData.FrameEquipped;
		RepeatedField<int> decorationsEquipped = equippedOutlookData.DecorationsEquipped;
		if (decorationsEquipped != null)
		{
			for (int j = 0; j < decorationsEquipped.Count; j++)
			{
				int value2 = decorationsEquipped[j];
				EDecorationParts key2 = j + EDecorationParts.HeadPart;
				this.CurUsingDecorationDict[key2] = value2;
			}
		}
		if (!this.HasInitSelectedInfo || curSkinId != this.CurSkinId)
		{
			this.ResetSelectedItemInfo();
			this.HasInitSelectedInfo = true;
		}
	}

	// Token: 0x06011472 RID: 70770 RVA: 0x00437430 File Offset: 0x00435630
	public void UpdateSkinSuitInfo(IList<MotorOutlookEquippedPb> skinSuitDataList)
	{
		foreach (MotorOutlookEquippedPb motorOutlookEquippedPb in skinSuitDataList)
		{
			if (motorOutlookEquippedPb != null)
			{
				int skinEquipped = motorOutlookEquippedPb.SkinEquipped;
				MotorcycleDiySkinEquipRecord motorcycleDiySkinEquipRecord = new MotorcycleDiySkinEquipRecord();
				motorcycleDiySkinEquipRecord.FrameId = motorOutlookEquippedPb.FrameEquipped;
				RepeatedField<int> stickerEquipped = motorOutlookEquippedPb.StickerEquipped;
				motorcycleDiySkinEquipRecord.StickerIds = (((stickerEquipped != null) ? stickerEquipped.ToArray<int>() : null) ?? Array.Empty<int>());
				RepeatedField<int> decorationsEquipped = motorOutlookEquippedPb.DecorationsEquipped;
				motorcycleDiySkinEquipRecord.DecorateIds = (((decorationsEquipped != null) ? decorationsEquipped.ToArray<int>() : null) ?? Array.Empty<int>());
				MotorcycleDiySkinEquipRecord value = motorcycleDiySkinEquipRecord;
				this.SkinSuitDict[skinEquipped] = value;
			}
		}
	}

	// Token: 0x06011473 RID: 70771 RVA: 0x004374DC File Offset: 0x004356DC
	public void InitCustomPresetInfo(MotorOutlookPlayerPresetPb playerPreset)
	{
		this.CustomPresetDataList.Clear();
		this.UpdateCustomPresetInfo(playerPreset);
	}

	// Token: 0x06011474 RID: 70772 RVA: 0x004374F0 File Offset: 0x004356F0
	public void UpdateCustomPresetInfo(MotorOutlookPlayerPresetPb playerPreset)
	{
		RepeatedField<MotorOutlookPresetPlanPb> plan = playerPreset.Plan;
		if (plan == null)
		{
			return;
		}
		foreach (MotorOutlookPresetPlanPb presetPlan in plan)
		{
			this.UpdateSingleCustomPresetInfo(presetPlan);
		}
	}

	// Token: 0x06011475 RID: 70773 RVA: 0x00437544 File Offset: 0x00435744
	public void RemoveSingleCustomPresetInfo(int presetId)
	{
		this.CustomPresetDataList.RemoveAll((MotorcycleDiyPresetData preset) => preset.CustomId == presetId);
	}

	// Token: 0x06011476 RID: 70774 RVA: 0x00437578 File Offset: 0x00435778
	public void UpdateSingleCustomPresetInfo(MotorOutlookPresetPlanPb presetPlan)
	{
		int customPresetId = presetPlan.Id;
		MotorcycleDiyPresetData motorcycleDiyPresetData = this.CustomPresetDataList.Find((MotorcycleDiyPresetData preset) => preset.CustomId == customPresetId);
		if (motorcycleDiyPresetData == null)
		{
			motorcycleDiyPresetData = new MotorcycleDiyPresetData
			{
				CustomId = customPresetId
			};
			this.CustomPresetDataList.Add(motorcycleDiyPresetData);
		}
		motorcycleDiyPresetData.Name = (presetPlan.Name ?? string.Empty);
		MotorOutlookEquippedPb preset2 = presetPlan.Preset;
		if (preset2 != null)
		{
			motorcycleDiyPresetData.SkinId = preset2.SkinEquipped;
			MotorcycleDiyPresetData motorcycleDiyPresetData2 = motorcycleDiyPresetData;
			RepeatedField<int> stickerEquipped = preset2.StickerEquipped;
			motorcycleDiyPresetData2.StickerIds = (((stickerEquipped != null) ? stickerEquipped.ToArray<int>() : null) ?? Array.Empty<int>());
			MotorcycleDiyPresetData motorcycleDiyPresetData3 = motorcycleDiyPresetData;
			RepeatedField<int> decorationsEquipped = preset2.DecorationsEquipped;
			motorcycleDiyPresetData3.DecorateIds = (((decorationsEquipped != null) ? decorationsEquipped.ToArray<int>() : null) ?? Array.Empty<int>());
			motorcycleDiyPresetData.FrameId = preset2.FrameEquipped;
		}
	}

	// Token: 0x06011477 RID: 70775 RVA: 0x0043764C File Offset: 0x0043584C
	public void UpdateMotorCanUseOutlookInfo(MotorOutlookRegionInfoNotify message)
	{
		if (message != null && message.MotorOutlookRegion != null)
		{
			MotorOutlookRegionPb motorOutlookRegion = message.MotorOutlookRegion;
			this.CurCanUseFrameIds = new List<int>();
			this.CurCanUseStickerIds = new List<int>();
			this.CurCanUseDecorationsIds = new List<int>();
			if (motorOutlookRegion.MotorFrame != null)
			{
				foreach (MotorOutlookIdTimePairPb motorOutlookIdTimePairPb in motorOutlookRegion.MotorFrame)
				{
					this.CurCanUseFrameIds.Add(motorOutlookIdTimePairPb.Id);
					this.CanUseIdsTimeStamp[motorOutlookIdTimePairPb.Id] = motorOutlookIdTimePairPb.OpenTime;
				}
			}
			if (motorOutlookRegion.MotorSticker != null)
			{
				foreach (MotorOutlookIdTimePairPb motorOutlookIdTimePairPb2 in motorOutlookRegion.MotorSticker)
				{
					this.CurCanUseStickerIds.Add(motorOutlookIdTimePairPb2.Id);
					this.CanUseIdsTimeStamp[motorOutlookIdTimePairPb2.Id] = motorOutlookIdTimePairPb2.OpenTime;
				}
			}
			if (motorOutlookRegion.MotorDecoration != null)
			{
				foreach (MotorOutlookIdTimePairPb motorOutlookIdTimePairPb3 in motorOutlookRegion.MotorDecoration)
				{
					this.CurCanUseDecorationsIds.Add(motorOutlookIdTimePairPb3.Id);
					this.CanUseIdsTimeStamp[motorOutlookIdTimePairPb3.Id] = motorOutlookIdTimePairPb3.OpenTime;
				}
			}
		}
	}

	// Token: 0x06011478 RID: 70776 RVA: 0x004377CC File Offset: 0x004359CC
	private void UpdateSceneInUse(int? sceneInUse)
	{
		if (sceneInUse != null && sceneInUse.Value > 0)
		{
			this.CurSceneId = sceneInUse.Value;
		}
	}

	// Token: 0x06011479 RID: 70777 RVA: 0x004377F0 File Offset: 0x004359F0
	public void UpdateMotorOutlookInfo(MotorOutlookInfoResponse message)
	{
		if (message != null && message.MotorOutlook != null)
		{
			MotorOutlookPb motorOutlook = message.MotorOutlook;
			MotorOutlookOwnedPb motorOutlookOwned = motorOutlook.MotorOutlookOwned;
			MotorOutlookEquippedPb motorOutlookEquipped = motorOutlook.MotorOutlookEquipped;
			MotorOutlookPlayerPresetPb motorOutlookPreset = motorOutlook.MotorOutlookPreset;
			RepeatedField<MotorOutlookEquippedPb> latestMotorSkinSuit = motorOutlook.LatestMotorSkinSuit;
			if (motorOutlookOwned != null)
			{
				this.InitRedDotInfo();
				this.UpdateOwnedOutlookInfo(motorOutlookOwned);
			}
			if (motorOutlookEquipped != null)
			{
				this.UpdateEquippedOutlookInfo(motorOutlookEquipped);
			}
			if (motorOutlookPreset != null)
			{
				this.InitCustomPresetInfo(motorOutlookPreset);
			}
			if (latestMotorSkinSuit != null)
			{
				this.UpdateSkinSuitInfo(latestMotorSkinSuit);
			}
			this.UpdateSceneInUse(new int?(motorOutlook.SceneInUse));
		}
	}

	// Token: 0x0601147A RID: 70778 RVA: 0x00437870 File Offset: 0x00435A70
	public void AddMotorOutlookInfo(MotorOutlookAddNotify message)
	{
		if (message != null)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			if (message.MotorSkin != null)
			{
				foreach (int num in message.MotorSkin)
				{
					if (this.IsRegionItemInOpenTime(num))
					{
						dictionary[num] = 1;
					}
				}
			}
			if (message.MotorSticker != null)
			{
				foreach (int num2 in message.MotorSticker)
				{
					if (this.IsRegionItemInOpenTime(num2))
					{
						dictionary[num2] = 1;
					}
				}
			}
			if (message.MotorFrame != null)
			{
				foreach (int num3 in message.MotorFrame)
				{
					if (this.IsRegionItemInOpenTime(num3))
					{
						dictionary[num3] = 1;
					}
				}
			}
			if (message.MotorDecoration != null)
			{
				foreach (int num4 in message.MotorDecoration)
				{
					if (this.IsRegionItemInOpenTime(num4))
					{
						dictionary[num4] = 1;
					}
				}
			}
			this.AddMotorOutlookItemList(dictionary);
			this.InitRedDotInfo();
			this.UpdateRedDotInfo(message.MotorSkin, message.MotorSticker, message.MotorFrame, message.MotorDecoration);
		}
	}

	// Token: 0x0601147B RID: 70779 RVA: 0x004379F8 File Offset: 0x00435BF8
	public void UpdateMotorOutlookOwnedChange(MotorOutlookOwnedChangeNotify message)
	{
		MotorOutlookOwnedPb motorOutlookOwned = message.MotorOutlookOwned;
		if (motorOutlookOwned != null)
		{
			this.UpdateOwnedOutlookInfo(motorOutlookOwned);
		}
	}

	// Token: 0x0601147C RID: 70780 RVA: 0x00437A18 File Offset: 0x00435C18
	public void UpdateMotorOutlookEquippedChange(MotorOutlookEquippedChangeNotify message)
	{
		MotorOutlookEquippedPb motorOutlookEquipped = message.MotorOutlookEquipped;
		if (motorOutlookEquipped != null)
		{
			this.UpdateEquippedOutlookInfo(motorOutlookEquipped);
		}
		RepeatedField<MotorOutlookEquippedPb> latestMotorSkinSuit = message.LatestMotorSkinSuit;
		if (latestMotorSkinSuit != null)
		{
			this.UpdateSkinSuitInfo(latestMotorSkinSuit);
		}
	}

	// Token: 0x0601147D RID: 70781 RVA: 0x00437A48 File Offset: 0x00435C48
	public void UpdateMotorOutlookFullChange(MotorOutlookFullChangeNotify message)
	{
		MotorOutlookPb motorOutlook = message.MotorOutlook;
		if (motorOutlook != null)
		{
			if (motorOutlook.MotorOutlookEquipped != null)
			{
				this.UpdateEquippedOutlookInfo(motorOutlook.MotorOutlookEquipped);
			}
			if (motorOutlook.MotorOutlookOwned != null)
			{
				this.UpdateOwnedOutlookInfo(motorOutlook.MotorOutlookOwned);
			}
			if (motorOutlook.MotorOutlookPreset != null)
			{
				this.InitCustomPresetInfo(motorOutlook.MotorOutlookPreset);
			}
			if (motorOutlook.LatestMotorSkinSuit != null)
			{
				this.UpdateSkinSuitInfo(motorOutlook.LatestMotorSkinSuit);
			}
			this.UpdateSceneInUse(new int?(motorOutlook.SceneInUse));
		}
	}

	// Token: 0x0601147E RID: 70782 RVA: 0x00437AC0 File Offset: 0x00435CC0
	public List<UiDynamicTab> GetMotorDiyTabList(EUiViewName viewName)
	{
		List<UiDynamicTab> viewTabList = DynamicTabConfig.Instance.GetViewTabList(viewName);
		int count = viewTabList.Count;
		List<UiDynamicTab> list = new List<UiDynamicTab>();
		for (int i = 0; i < count; i++)
		{
			UiDynamicTab item = viewTabList[i];
			if (FunctionModel.Instance.IsOpen(item.FunctionId))
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x0601147F RID: 70783 RVA: 0x00437B1C File Offset: 0x00435D1C
	public int GetDefaultFrameId()
	{
		if (this.DefaultFrameId == 0)
		{
			foreach (int num in this.OwnedFrameIds)
			{
				MotorFrame? motorFrameConfig = MotorDiyConfig.Instance.GetMotorFrameConfig(num);
				if (motorFrameConfig != null && motorFrameConfig.Value.DefaultFlag)
				{
					this.DefaultFrameId = num;
					break;
				}
			}
		}
		return this.DefaultFrameId;
	}

	// Token: 0x06011480 RID: 70784 RVA: 0x00437BA8 File Offset: 0x00435DA8
	public List<int> GetDefaultStickerIdList()
	{
		List<int> list = new List<int>();
		foreach (int num in MotorcycleDiyDefine.MOTORCYCLE_DIY_STICKER_PART)
		{
			list.Add(0);
		}
		return list;
	}

	// Token: 0x06011481 RID: 70785 RVA: 0x00437BDC File Offset: 0x00435DDC
	public List<int> GetDefaultDecorationIdList()
	{
		List<int> list = new List<int>();
		foreach (int num in MotorcycleDiyDefine.MOTORCYCLE_DIY_DECORATION_PART)
		{
			list.Add(0);
		}
		return list;
	}

	// Token: 0x06011482 RID: 70786 RVA: 0x00437C10 File Offset: 0x00435E10
	public List<MotorcycleDiyPresetData> GetAllPresetDataList(bool isCustom = false)
	{
		List<MotorcycleDiyPresetData> list = new List<MotorcycleDiyPresetData>();
		if (isCustom)
		{
			list.AddRange(this.CustomPresetDataList);
		}
		else
		{
			foreach (MotorLoadProject motorLoadProject in MotorDiyConfig.Instance.GetAllMotorPresetList())
			{
				if (motorLoadProject.Show)
				{
					int frame = motorLoadProject.Frame;
					List<int> list2 = (motorLoadProject.GetStickerArray() ?? Array.Empty<int>()).ToList<int>();
					List<int> list3 = (motorLoadProject.GetDecorationsArray() ?? Array.Empty<int>()).ToList<int>();
					if (list2.Count == 0)
					{
						list2 = this.GetDefaultStickerIdList();
					}
					if (list3.Count == 0)
					{
						list3 = this.GetDefaultDecorationIdList();
					}
					if (this.HasFrame(frame))
					{
						bool flag = true;
						foreach (int stickerId in list2)
						{
							if (!this.HasSticker(stickerId))
							{
								flag = false;
								break;
							}
						}
						if (flag)
						{
							bool flag2 = true;
							foreach (int decorationId in list3)
							{
								if (!this.HasDecoration(decorationId))
								{
									flag2 = false;
									break;
								}
							}
							if (flag2)
							{
								list.Add(new MotorcycleDiyPresetData
								{
									OfficialId = motorLoadProject.Id,
									CustomId = 0,
									Name = (ConfigMultiTextLang.GetLocalTextNew(motorLoadProject.Name, null) ?? string.Empty),
									StickerIds = list2.ToArray(),
									DecorateIds = list3.ToArray(),
									FrameId = frame
								});
							}
						}
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06011483 RID: 70787 RVA: 0x00437E18 File Offset: 0x00436018
	public EOutLookState GetItemState(EOutlookType outlookType, int itemId)
	{
		List<int> list = new List<int>();
		int num = 0;
		ICollection<int> collection = new List<int>();
		List<int> list2 = new List<int>();
		Func<int, bool> func = (int id) => false;
		switch (outlookType)
		{
		case EOutlookType.Frame:
			list = this.CurCanUseFrameIds;
			num = this.CurFrameId;
			list2 = this.OwnedFrameIds;
			func = new Func<int, bool>(this.IsBanFrame);
			break;
		case EOutlookType.Sticker:
			list = this.CurCanUseStickerIds;
			collection = this.CurUsingStickerDict.Values;
			list2 = this.OwnedStickerIds;
			func = new Func<int, bool>(this.IsBanSticker);
			break;
		case EOutlookType.Decoration:
			list = this.CurCanUseDecorationsIds;
			collection = this.CurUsingDecorationDict.Values;
			list2 = this.OwnedDecorationsIds;
			func = new Func<int, bool>(this.IsBanDecoration);
			break;
		}
		if (outlookType == EOutlookType.Frame)
		{
			MotorFrame? motorFrameConfig = MotorDiyConfig.Instance.GetMotorFrameConfig(itemId);
			if (motorFrameConfig != null && !motorFrameConfig.Value.Show)
			{
				return EOutLookState.IsHide;
			}
		}
		if (!list.Contains(itemId) || !this.IsRegionItemInOpenTime(itemId))
		{
			return EOutLookState.IsHide;
		}
		if (func(itemId))
		{
			return EOutLookState.IsBan;
		}
		if (collection.Contains(itemId) || num == itemId)
		{
			return EOutLookState.IsEquipped;
		}
		if (!list2.Contains(itemId))
		{
			return EOutLookState.IsLock;
		}
		return EOutLookState.CanEquipped;
	}

	// Token: 0x06011484 RID: 70788 RVA: 0x00437F54 File Offset: 0x00436154
	public void CollectRedDotOnViewOpen(EOutlookType outlookType, int? part = null)
	{
		this.RedDotOnViewOpenCache.Clear();
		List<int> list = new List<int>();
		if (outlookType == EOutlookType.Frame)
		{
			list = this.OwnedFrameIds;
		}
		else
		{
			if (outlookType == EOutlookType.Sticker)
			{
				using (List<int>.Enumerator enumerator = this.OwnedStickerIds.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						int num = enumerator.Current;
						MotorSticker? motorStickerConfig = MotorDiyConfig.Instance.GetMotorStickerConfig(num);
						if (motorStickerConfig != null)
						{
							int partId = motorStickerConfig.Value.PartId;
							int? num2 = part;
							if (partId == num2.GetValueOrDefault() & num2 != null)
							{
								list.Add(num);
							}
						}
					}
					goto IL_112;
				}
			}
			if (outlookType == EOutlookType.Decoration)
			{
				foreach (int num3 in this.OwnedDecorationsIds)
				{
					MotorDecorations? motorDecorationConfig = MotorDiyConfig.Instance.GetMotorDecorationConfig(num3);
					if (motorDecorationConfig != null)
					{
						int partId2 = motorDecorationConfig.Value.PartId;
						int? num2 = part;
						if (partId2 == num2.GetValueOrDefault() & num2 != null)
						{
							list.Add(num3);
						}
					}
				}
			}
		}
		IL_112:
		foreach (int num4 in list)
		{
			if (this.RedDotCache.Has(num4))
			{
				this.RedDotOnViewOpenCache.Add(num4);
				this.RedDotCache.Remove(num4);
			}
		}
		EventSystem.Instance.Emit(EEventName.MotorDiyInfoRedDotUpdate);
	}

	// Token: 0x06011485 RID: 70789 RVA: 0x00438100 File Offset: 0x00436300
	public void CheckRedDotForAnyItem(int itemId)
	{
		if (this.RedDotCache.Has(itemId))
		{
			this.RedDotCache.Remove(itemId);
			EventSystem.Instance.Emit(EEventName.MotorDiyInfoRedDotUpdate);
		}
	}

	// Token: 0x06011486 RID: 70790 RVA: 0x0043812C File Offset: 0x0043632C
	public bool CheckRedDotInViewOpenCache(int id)
	{
		return this.RedDotOnViewOpenCache.Contains(id);
	}

	// Token: 0x06011487 RID: 70791 RVA: 0x0043813A File Offset: 0x0043633A
	public void RemoveRedDotInViewOpenCache(int id)
	{
		this.RedDotOnViewOpenCache.Remove(id);
	}

	// Token: 0x06011488 RID: 70792 RVA: 0x0043814C File Offset: 0x0043634C
	private IMotorDiyItemGroupConfigInfo GetItemGroupConfigInfo(EOutlookType outlookType, int itemId)
	{
		MotorDiyItemGroupConfigInfo motorDiyItemGroupConfigInfo = new MotorDiyItemGroupConfigInfo();
		if (itemId == 0)
		{
			return motorDiyItemGroupConfigInfo;
		}
		switch (outlookType)
		{
		case EOutlookType.Frame:
		{
			MotorFrame? motorFrameConfig = MotorDiyConfig.Instance.GetMotorFrameConfig(itemId);
			if (motorFrameConfig != null)
			{
				motorDiyItemGroupConfigInfo.GroupId = new int?(motorFrameConfig.Value.GroupId);
			}
			break;
		}
		case EOutlookType.Sticker:
		{
			MotorSticker? motorStickerConfig = MotorDiyConfig.Instance.GetMotorStickerConfig(itemId);
			if (motorStickerConfig != null)
			{
				motorDiyItemGroupConfigInfo.GroupId = new int?(motorStickerConfig.Value.GroupId);
				motorDiyItemGroupConfigInfo.PartId = new int?(motorStickerConfig.Value.PartId);
			}
			break;
		}
		case EOutlookType.Decoration:
		{
			MotorDecorations? motorDecorationConfig = MotorDiyConfig.Instance.GetMotorDecorationConfig(itemId);
			if (motorDecorationConfig != null)
			{
				motorDiyItemGroupConfigInfo.GroupId = new int?(motorDecorationConfig.Value.GroupId);
				motorDiyItemGroupConfigInfo.PartId = new int?(motorDecorationConfig.Value.PartId);
			}
			break;
		}
		}
		return motorDiyItemGroupConfigInfo;
	}

	// Token: 0x06011489 RID: 70793 RVA: 0x0043824C File Offset: 0x0043644C
	private bool CheckIsBan(EOutlookType outlookType, int itemId)
	{
		MotorcycleDiyModel.<>c__DisplayClass59_0 CS$<>8__locals1;
		CS$<>8__locals1.outlookType = outlookType;
		CS$<>8__locals1.<>4__this = this;
		IMotorDiyItemGroupConfigInfo itemGroupConfigInfo = this.GetItemGroupConfigInfo(CS$<>8__locals1.outlookType, itemId);
		int? groupId = itemGroupConfigInfo.GroupId;
		CS$<>8__locals1.targetPartId = itemGroupConfigInfo.PartId;
		if (groupId == null)
		{
			return false;
		}
		MotorComponentGroup? motorComponentGroupConfig = MotorDiyConfig.Instance.GetMotorComponentGroupConfig(groupId.Value);
		if (motorComponentGroupConfig == null || motorComponentGroupConfig.Value.GetConflictGroupArray() == null || motorComponentGroupConfig.Value.GetConflictGroupArray().Length == 0)
		{
			return false;
		}
		CS$<>8__locals1.conflictGroupIds = motorComponentGroupConfig.Value.GetConflictGroupArray();
		foreach (KeyValuePair<EStickerParts, int> keyValuePair in this.SelectedStickerDict)
		{
			if (this.<CheckIsBan>g__isConflict|59_0(EOutlookType.Sticker, keyValuePair.Value, new int?((int)keyValuePair.Key), ref CS$<>8__locals1))
			{
				return true;
			}
		}
		foreach (KeyValuePair<EDecorationParts, int> keyValuePair2 in this.SelectedDecorationDict)
		{
			if (this.<CheckIsBan>g__isConflict|59_0(EOutlookType.Decoration, keyValuePair2.Value, new int?((int)keyValuePair2.Key), ref CS$<>8__locals1))
			{
				return true;
			}
		}
		return this.<CheckIsBan>g__isConflict|59_0(EOutlookType.Frame, this.SelectedFrameId, null, ref CS$<>8__locals1);
	}

	// Token: 0x0601148A RID: 70794 RVA: 0x004383D8 File Offset: 0x004365D8
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public ValueTuple<string, string>? GetBanTips(EOutlookType outlookType, int itemId)
	{
		MotorcycleDiyModel.<>c__DisplayClass60_0 CS$<>8__locals1;
		CS$<>8__locals1.outlookType = outlookType;
		CS$<>8__locals1.<>4__this = this;
		IMotorDiyItemGroupConfigInfo itemGroupConfigInfo = this.GetItemGroupConfigInfo(CS$<>8__locals1.outlookType, itemId);
		int? groupId = itemGroupConfigInfo.GroupId;
		CS$<>8__locals1.targetPartId = itemGroupConfigInfo.PartId;
		if (groupId == null)
		{
			return null;
		}
		MotorComponentGroup? motorComponentGroupConfig = MotorDiyConfig.Instance.GetMotorComponentGroupConfig(groupId.Value);
		if (motorComponentGroupConfig == null || motorComponentGroupConfig.Value.GetConflictGroupArray() == null || motorComponentGroupConfig.Value.GetConflictGroupArray().Length == 0)
		{
			return null;
		}
		CS$<>8__locals1.conflictGroupIds = motorComponentGroupConfig.Value.GetConflictGroupArray();
		string item = "";
		CS$<>8__locals1.banItemName = "";
		item = MotorcycleDiyModel.<GetBanTips>g__getItemName|60_0(CS$<>8__locals1.outlookType, itemId);
		CS$<>8__locals1.addedGroupIds = new List<int>
		{
			groupId.Value
		};
		foreach (KeyValuePair<EStickerParts, int> keyValuePair in this.SelectedStickerDict)
		{
			this.<GetBanTips>g__checkAndAdd|60_1(EOutlookType.Sticker, keyValuePair.Value, new int?((int)keyValuePair.Key), ref CS$<>8__locals1);
		}
		foreach (KeyValuePair<EDecorationParts, int> keyValuePair2 in this.SelectedDecorationDict)
		{
			this.<GetBanTips>g__checkAndAdd|60_1(EOutlookType.Decoration, keyValuePair2.Value, new int?((int)keyValuePair2.Key), ref CS$<>8__locals1);
		}
		this.<GetBanTips>g__checkAndAdd|60_1(EOutlookType.Frame, this.SelectedFrameId, null, ref CS$<>8__locals1);
		return new ValueTuple<string, string>?(new ValueTuple<string, string>(item, CS$<>8__locals1.banItemName));
	}

	// Token: 0x0601148B RID: 70795 RVA: 0x004385A8 File Offset: 0x004367A8
	public List<int> GetSelectedItemIdList(EOutlookType outlookType, bool checkHasItem = false)
	{
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
		Func<int, bool> func = (int id) => false;
		switch (outlookType)
		{
		case EOutlookType.Sticker:
			list2 = MotorcycleDiyDefine.MOTORCYCLE_DIY_STICKER_PART.ToList<int>();
			dictionary = this.SelectedStickerDict.ToDictionary((KeyValuePair<EStickerParts, int> kvp) => (int)kvp.Key, (KeyValuePair<EStickerParts, int> kvp) => kvp.Value);
			dictionary2 = this.CurUsingStickerDict.ToDictionary((KeyValuePair<EStickerParts, int> kvp) => (int)kvp.Key, (KeyValuePair<EStickerParts, int> kvp) => kvp.Value);
			func = new Func<int, bool>(this.HasSticker);
			break;
		case EOutlookType.Decoration:
			list2 = MotorcycleDiyDefine.MOTORCYCLE_DIY_DECORATION_PART.ToList<int>();
			dictionary = this.SelectedDecorationDict.ToDictionary((KeyValuePair<EDecorationParts, int> kvp) => (int)kvp.Key, (KeyValuePair<EDecorationParts, int> kvp) => kvp.Value);
			dictionary2 = this.CurUsingDecorationDict.ToDictionary((KeyValuePair<EDecorationParts, int> kvp) => (int)kvp.Key, (KeyValuePair<EDecorationParts, int> kvp) => kvp.Value);
			func = new Func<int, bool>(this.HasDecoration);
			break;
		}
		foreach (int key in list2)
		{
			int valueOrDefault = dictionary.GetValueOrDefault(key, 0);
			if (checkHasItem)
			{
				if (func(valueOrDefault))
				{
					list.Add(valueOrDefault);
				}
				else
				{
					int valueOrDefault2 = dictionary2.GetValueOrDefault(key, 0);
					list.Add(valueOrDefault2);
				}
			}
			else
			{
				list.Add(valueOrDefault);
			}
		}
		return list;
	}

	// Token: 0x0601148C RID: 70796 RVA: 0x004387E8 File Offset: 0x004369E8
	private List<int> GetEquippedItemIdList(EOutlookType outlookType)
	{
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		switch (outlookType)
		{
		case EOutlookType.Sticker:
			list2 = MotorcycleDiyDefine.MOTORCYCLE_DIY_STICKER_PART.ToList<int>();
			dictionary = this.CurUsingStickerDict.ToDictionary((KeyValuePair<EStickerParts, int> kvp) => (int)kvp.Key, (KeyValuePair<EStickerParts, int> kvp) => kvp.Value);
			break;
		case EOutlookType.Decoration:
			list2 = MotorcycleDiyDefine.MOTORCYCLE_DIY_DECORATION_PART.ToList<int>();
			dictionary = this.CurUsingDecorationDict.ToDictionary((KeyValuePair<EDecorationParts, int> kvp) => (int)kvp.Key, (KeyValuePair<EDecorationParts, int> kvp) => kvp.Value);
			break;
		}
		foreach (int key in list2)
		{
			int item = dictionary.ContainsKey(key) ? dictionary[key] : 0;
			list.Add(item);
		}
		return list;
	}

	// Token: 0x0601148D RID: 70797 RVA: 0x0043892C File Offset: 0x00436B2C
	public int GetSelectedItemId(EOutlookType outlookType, int? part = null)
	{
		int result = 0;
		switch (outlookType)
		{
		case EOutlookType.Frame:
			result = this.SelectedFrameId;
			break;
		case EOutlookType.Sticker:
			result = ((part != null && this.SelectedStickerDict.ContainsKey((EStickerParts)part.Value)) ? this.SelectedStickerDict[(EStickerParts)part.Value] : 0);
			break;
		case EOutlookType.Decoration:
			result = ((part != null && this.SelectedDecorationDict.ContainsKey((EDecorationParts)part.Value)) ? this.SelectedDecorationDict[(EDecorationParts)part.Value] : 0);
			break;
		}
		return result;
	}

	// Token: 0x0601148E RID: 70798 RVA: 0x004389C8 File Offset: 0x00436BC8
	public int GetEquippedItemId(EOutlookType outlookType, int part)
	{
		int result = 0;
		switch (outlookType)
		{
		case EOutlookType.Sticker:
			result = (this.CurUsingStickerDict.ContainsKey((EStickerParts)part) ? this.CurUsingStickerDict[(EStickerParts)part] : 0);
			break;
		case EOutlookType.Decoration:
			result = (this.CurUsingDecorationDict.ContainsKey((EDecorationParts)part) ? this.CurUsingDecorationDict[(EDecorationParts)part] : 0);
			break;
		}
		return result;
	}

	// Token: 0x0601148F RID: 70799 RVA: 0x00438A30 File Offset: 0x00436C30
	public void ResetSelectedItemInfo()
	{
		this.SelectedStickerDict.Clear();
		this.SelectedDecorationDict.Clear();
		foreach (KeyValuePair<EStickerParts, int> keyValuePair in this.CurUsingStickerDict)
		{
			this.SelectedStickerDict[keyValuePair.Key] = keyValuePair.Value;
		}
		foreach (KeyValuePair<EDecorationParts, int> keyValuePair2 in this.CurUsingDecorationDict)
		{
			this.SelectedDecorationDict[keyValuePair2.Key] = keyValuePair2.Value;
		}
		this.SelectedFrameId = this.CurFrameId;
	}

	// Token: 0x06011490 RID: 70800 RVA: 0x00438B0C File Offset: 0x00436D0C
	public bool RedDotHasNewItemByAnyPart(EOutlookType outlookType)
	{
		List<int> list = new List<int>();
		switch (outlookType)
		{
		case EOutlookType.Sticker:
			list = MotorcycleDiyDefine.MOTORCYCLE_DIY_STICKER_PART.ToList<int>();
			break;
		case EOutlookType.Decoration:
			list = MotorcycleDiyDefine.MOTORCYCLE_DIY_DECORATION_PART.ToList<int>();
			break;
		}
		foreach (int part in list)
		{
			if (this.RedDotHasNewItemByPart(outlookType, part))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06011491 RID: 70801 RVA: 0x00438B9C File Offset: 0x00436D9C
	public bool RedDotHasNewItemByPart(EOutlookType outlookType, int part)
	{
		List<int> list = new List<int>();
		Func<int, bool> func = (int id) => false;
		switch (outlookType)
		{
		case EOutlookType.Sticker:
			list = this.CurCanUseStickerIds;
			func = new Func<int, bool>(this.HasSticker);
			break;
		case EOutlookType.Decoration:
			list = this.CurCanUseDecorationsIds;
			func = new Func<int, bool>(this.HasDecoration);
			break;
		}
		foreach (int num in list)
		{
			int? num2 = null;
			if (outlookType == EOutlookType.Sticker)
			{
				MotorSticker? motorStickerConfig = MotorDiyConfig.Instance.GetMotorStickerConfig(num);
				if (motorStickerConfig != null)
				{
					num2 = new int?(motorStickerConfig.GetValueOrDefault().PartId);
				}
			}
			else if (outlookType == EOutlookType.Decoration)
			{
				MotorDecorations? motorDecorationConfig = MotorDiyConfig.Instance.GetMotorDecorationConfig(num);
				if (motorDecorationConfig != null)
				{
					num2 = new int?(motorDecorationConfig.GetValueOrDefault().PartId);
				}
			}
			EOutLookState itemState = this.GetItemState(outlookType, num);
			bool flag = num2 != null && num2.Value == part;
			bool flag2 = func(num);
			bool flag3 = itemState == EOutLookState.CanEquipped || itemState == EOutLookState.IsEquipped;
			if (flag && flag2 && flag3 && this.RedDotHasNewItem(num))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06011492 RID: 70802 RVA: 0x00438D10 File Offset: 0x00436F10
	public List<int> GetCanUseStickerIdsInRegion()
	{
		return this.CurCanUseStickerIds;
	}

	// Token: 0x06011493 RID: 70803 RVA: 0x00438D18 File Offset: 0x00436F18
	public List<int> GetCanUseFrameIdsInRegion()
	{
		return this.CurCanUseFrameIds;
	}

	// Token: 0x06011494 RID: 70804 RVA: 0x00438D20 File Offset: 0x00436F20
	public List<int> GetCanUseDecorationsIdsInRegion()
	{
		return this.CurCanUseDecorationsIds;
	}

	// Token: 0x06011495 RID: 70805 RVA: 0x00438D28 File Offset: 0x00436F28
	public bool IsRegionItemInOpenTime(int itemId)
	{
		long num2;
		long num = this.CanUseIdsTimeStamp.TryGetValue(itemId, out num2) ? num2 : 0L;
		return (long)TimeUtil.Instance.GetServerTime() >= num;
	}

	// Token: 0x06011496 RID: 70806 RVA: 0x00438D5C File Offset: 0x00436F5C
	public int GetEquippedSkinId()
	{
		return this.CurSkinId;
	}

	// Token: 0x06011497 RID: 70807 RVA: 0x00438D64 File Offset: 0x00436F64
	public int GetCurrentSceneId()
	{
		return this.CurSceneId;
	}

	// Token: 0x06011498 RID: 70808 RVA: 0x00438D6C File Offset: 0x00436F6C
	public void SetCurrentSceneId(int sceneId)
	{
		this.CurSceneId = sceneId;
	}

	// Token: 0x06011499 RID: 70809 RVA: 0x00438D75 File Offset: 0x00436F75
	public List<int> GetMotorSceneIdList()
	{
		return this.SceneIdList;
	}

	// Token: 0x0601149A RID: 70810 RVA: 0x00438D80 File Offset: 0x00436F80
	public bool HasScene(int sceneId)
	{
		if (sceneId <= 0)
		{
			return false;
		}
		if (sceneId == this.DefaultSceneId)
		{
			return true;
		}
		MotorScene? motorSceneConfig = MotorDiyConfig.Instance.GetMotorSceneConfig(sceneId);
		return motorSceneConfig != null && InventoryModel.Instance.GetItemCountByConfigId(motorSceneConfig.Value.UnlockItem, 0) > 0;
	}

	// Token: 0x0601149B RID: 70811 RVA: 0x00438DD2 File Offset: 0x00436FD2
	public bool RedDotHasNewScene(int sceneId)
	{
		if (sceneId == this.DefaultSceneId)
		{
			return false;
		}
		if (!this.HasScene(sceneId))
		{
			return false;
		}
		this.TryInitSceneRedDotInfo();
		return this.SceneRedDotCache == null || !this.SceneRedDotCache.Has(sceneId);
	}

	// Token: 0x0601149C RID: 70812 RVA: 0x00438E0C File Offset: 0x0043700C
	public bool RedDotHasAnyNewScene()
	{
		foreach (int sceneId in this.SceneIdList)
		{
			if (this.RedDotHasNewScene(sceneId))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601149D RID: 70813 RVA: 0x00438E68 File Offset: 0x00437068
	public void RecordHadCheckNewScene(int sceneId)
	{
		if (sceneId == this.DefaultSceneId)
		{
			return;
		}
		if (!this.HasScene(sceneId))
		{
			return;
		}
		this.TryInitSceneRedDotInfo();
		ServerStorageSet sceneRedDotCache = this.SceneRedDotCache;
		if (sceneRedDotCache != null)
		{
			sceneRedDotCache.Add(sceneId);
		}
		EventSystem.Instance.Emit(EEventName.MotorDiySceneItemUpdate);
	}

	// Token: 0x0601149E RID: 70814 RVA: 0x00438EA6 File Offset: 0x004370A6
	public bool IsSceneItemId(int itemId)
	{
		return this.SceneItemIdSet.Contains(itemId);
	}

	// Token: 0x0601149F RID: 70815 RVA: 0x00438EB4 File Offset: 0x004370B4
	public bool IsEquipDefaultSkin()
	{
		if (this.CurSkinId <= 0)
		{
			return false;
		}
		bool result = false;
		MotorSkin? motorSkinConfig = MotorDiyConfig.Instance.GetMotorSkinConfig(this.CurSkinId);
		if (motorSkinConfig != null && motorSkinConfig.Value.DefaultFlag)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x060114A0 RID: 70816 RVA: 0x00438EFC File Offset: 0x004370FC
	[NullableContext(2)]
	public MotorcycleDiySkinEquipRecord GetSkinSuitRecord(int skinId)
	{
		MotorcycleDiySkinEquipRecord motorcycleDiySkinEquipRecord;
		if (this.SkinSuitDict.TryGetValue(skinId, out motorcycleDiySkinEquipRecord))
		{
			return motorcycleDiySkinEquipRecord;
		}
		MotorSkin? motorSkinConfig = MotorDiyConfig.Instance.GetMotorSkinConfig(skinId);
		if (motorSkinConfig == null)
		{
			return null;
		}
		motorcycleDiySkinEquipRecord = new MotorcycleDiySkinEquipRecord
		{
			FrameId = motorSkinConfig.Value.BindFrame,
			StickerIds = motorSkinConfig.Value.BindSticker(),
			DecorateIds = motorSkinConfig.Value.BindDecorations()
		};
		this.SkinSuitDict[skinId] = motorcycleDiySkinEquipRecord;
		return motorcycleDiySkinEquipRecord;
	}

	// Token: 0x060114A1 RID: 70817 RVA: 0x00438F85 File Offset: 0x00437185
	public bool HasSkin(int skinId)
	{
		return this.OwnedSkinIds.Contains(skinId);
	}

	// Token: 0x060114A2 RID: 70818 RVA: 0x00438F93 File Offset: 0x00437193
	public EOutLookState GetFrameState(int frameId)
	{
		return this.GetItemState(EOutlookType.Frame, frameId);
	}

	// Token: 0x060114A3 RID: 70819 RVA: 0x00438F9D File Offset: 0x0043719D
	public int GetSelectedFrameId()
	{
		return this.SelectedFrameId;
	}

	// Token: 0x060114A4 RID: 70820 RVA: 0x00438FA5 File Offset: 0x004371A5
	public int GetEquippedFrameId()
	{
		return this.CurFrameId;
	}

	// Token: 0x060114A5 RID: 70821 RVA: 0x00438FAD File Offset: 0x004371AD
	public void SetSelectFrame(int frameId)
	{
		this.SelectedFrameId = frameId;
	}

	// Token: 0x060114A6 RID: 70822 RVA: 0x00438FB6 File Offset: 0x004371B6
	public bool HasFrame(int frameId)
	{
		return this.OwnedFrameIds.Contains(frameId);
	}

	// Token: 0x060114A7 RID: 70823 RVA: 0x00438FC4 File Offset: 0x004371C4
	public bool IsBanFrame(int frameId)
	{
		return this.CheckIsBan(EOutlookType.Frame, frameId);
	}

	// Token: 0x060114A8 RID: 70824 RVA: 0x00438FD0 File Offset: 0x004371D0
	public bool IsEquipFrameLockedByPlayer()
	{
		BaseTagComponent component = SceneTeamModel.Instance.GetCurrentEntity.Entity.GetComponent<BaseTagComponent>();
		bool flag = component.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.驾驶期间"]);
		bool flag2 = component.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.下车"]) || component.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.退场技"]);
		return flag || flag2;
	}

	// Token: 0x060114A9 RID: 70825 RVA: 0x00439039 File Offset: 0x00437239
	public EOutLookState GetStickerState(int stickerId)
	{
		return this.GetItemState(EOutlookType.Sticker, stickerId);
	}

	// Token: 0x060114AA RID: 70826 RVA: 0x00439043 File Offset: 0x00437243
	public List<int> GetSelectedStickerIdList(bool checkHasSticker = false)
	{
		return this.GetSelectedItemIdList(EOutlookType.Sticker, checkHasSticker);
	}

	// Token: 0x060114AB RID: 70827 RVA: 0x0043904D File Offset: 0x0043724D
	public int GetSelectedStickerId(int stickerPart)
	{
		if (!this.SelectedStickerDict.ContainsKey((EStickerParts)stickerPart))
		{
			return 0;
		}
		return this.SelectedStickerDict[(EStickerParts)stickerPart];
	}

	// Token: 0x060114AC RID: 70828 RVA: 0x0043906B File Offset: 0x0043726B
	public List<int> GetEquippedStickerIdList()
	{
		return this.GetEquippedItemIdList(EOutlookType.Sticker);
	}

	// Token: 0x060114AD RID: 70829 RVA: 0x00439074 File Offset: 0x00437274
	public int GetEquippedStickerId(int stickerPart)
	{
		if (!this.CurUsingStickerDict.ContainsKey((EStickerParts)stickerPart))
		{
			return 0;
		}
		return this.CurUsingStickerDict[(EStickerParts)stickerPart];
	}

	// Token: 0x060114AE RID: 70830 RVA: 0x00439092 File Offset: 0x00437292
	public void SetSelectStickerInfo(int stickerPart, int stickerId)
	{
		this.SelectedStickerDict[(EStickerParts)stickerPart] = stickerId;
	}

	// Token: 0x060114AF RID: 70831 RVA: 0x004390A1 File Offset: 0x004372A1
	public bool IsEquipDefaultSticker(int stickerPart)
	{
		return this.CurUsingStickerDict.ContainsKey((EStickerParts)stickerPart) && this.CurUsingStickerDict[(EStickerParts)stickerPart] == 0;
	}

	// Token: 0x060114B0 RID: 70832 RVA: 0x004390C2 File Offset: 0x004372C2
	public bool IsBanSticker(int stickerId)
	{
		return this.CheckIsBan(EOutlookType.Sticker, stickerId);
	}

	// Token: 0x060114B1 RID: 70833 RVA: 0x004390CC File Offset: 0x004372CC
	public bool HasSticker(int stickerId)
	{
		return stickerId <= 0 || this.OwnedStickerIds.Contains(stickerId);
	}

	// Token: 0x060114B2 RID: 70834 RVA: 0x004390E0 File Offset: 0x004372E0
	public EOutLookState GetDecorationState(int decorationId)
	{
		return this.GetItemState(EOutlookType.Decoration, decorationId);
	}

	// Token: 0x060114B3 RID: 70835 RVA: 0x004390EA File Offset: 0x004372EA
	public List<int> GetSelectedDecorationIdList(bool checkHasDecoration = false)
	{
		return this.GetSelectedItemIdList(EOutlookType.Decoration, checkHasDecoration);
	}

	// Token: 0x060114B4 RID: 70836 RVA: 0x004390F4 File Offset: 0x004372F4
	public int GetSelectedDecorationId(int decorationPart)
	{
		if (!this.SelectedDecorationDict.ContainsKey((EDecorationParts)decorationPart))
		{
			return 0;
		}
		return this.SelectedDecorationDict[(EDecorationParts)decorationPart];
	}

	// Token: 0x060114B5 RID: 70837 RVA: 0x00439112 File Offset: 0x00437312
	public List<int> GetEquippedDecorationIdList()
	{
		return this.GetEquippedItemIdList(EOutlookType.Decoration);
	}

	// Token: 0x060114B6 RID: 70838 RVA: 0x0043911B File Offset: 0x0043731B
	public int GetEquippedDecorationId(int decorationPart)
	{
		if (!this.CurUsingDecorationDict.ContainsKey((EDecorationParts)decorationPart))
		{
			return 0;
		}
		return this.CurUsingDecorationDict[(EDecorationParts)decorationPart];
	}

	// Token: 0x060114B7 RID: 70839 RVA: 0x00439139 File Offset: 0x00437339
	public void SetSelectDecorationInfo(int decorationPart, int decorationId)
	{
		this.SelectedDecorationDict[(EDecorationParts)decorationPart] = decorationId;
	}

	// Token: 0x060114B8 RID: 70840 RVA: 0x00439148 File Offset: 0x00437348
	public bool IsEquipDefaultDecoration(int decorationPart)
	{
		return this.CurUsingDecorationDict.ContainsKey((EDecorationParts)decorationPart) && this.CurUsingDecorationDict[(EDecorationParts)decorationPart] == 0;
	}

	// Token: 0x060114B9 RID: 70841 RVA: 0x00439169 File Offset: 0x00437369
	public bool IsBanDecoration(int decorationId)
	{
		return this.CheckIsBan(EOutlookType.Decoration, decorationId);
	}

	// Token: 0x060114BA RID: 70842 RVA: 0x00439173 File Offset: 0x00437373
	public bool HasDecoration(int decorationId)
	{
		return decorationId <= 0 || this.OwnedDecorationsIds.Contains(decorationId);
	}

	// Token: 0x060114BB RID: 70843 RVA: 0x00439187 File Offset: 0x00437387
	public bool CanShowDiyPartRedDot()
	{
		return this.IsEquipDefaultSkin();
	}

	// Token: 0x060114BC RID: 70844 RVA: 0x0043918F File Offset: 0x0043738F
	public bool RedDotHasAnyNewItem()
	{
		return this.RedDotHasNewFrame() || this.RedDotHasNewStickerByAnyPart() || this.RedDotHasNewDecorationByAnyPart() || this.RedDotHasNewSkin();
	}

	// Token: 0x060114BD RID: 70845 RVA: 0x004391B1 File Offset: 0x004373B1
	public bool RedDotHasAnyNewItemVisible()
	{
		return this.CanShowDiyPartRedDot() && this.RedDotHasAnyNewItem();
	}

	// Token: 0x060114BE RID: 70846 RVA: 0x004391C3 File Offset: 0x004373C3
	public bool RedDotForDiyTab()
	{
		return this.RedDotHasAnyNewItemVisible() || this.RedDotHasAnyNewScene();
	}

	// Token: 0x060114BF RID: 70847 RVA: 0x004391D5 File Offset: 0x004373D5
	public bool RedDotHasNewFrameVisible()
	{
		return this.CanShowDiyPartRedDot() && this.RedDotHasNewFrame();
	}

	// Token: 0x060114C0 RID: 70848 RVA: 0x004391E7 File Offset: 0x004373E7
	public bool RedDotHasNewStickerByAnyPartVisible()
	{
		return this.CanShowDiyPartRedDot() && this.RedDotHasNewStickerByAnyPart();
	}

	// Token: 0x060114C1 RID: 70849 RVA: 0x004391F9 File Offset: 0x004373F9
	public bool RedDotHasNewDecorationByAnyPartVisible()
	{
		return this.CanShowDiyPartRedDot() && this.RedDotHasNewDecorationByAnyPart();
	}

	// Token: 0x060114C2 RID: 70850 RVA: 0x0043920C File Offset: 0x0043740C
	public bool RedDotHasNewFrame()
	{
		foreach (int itemId in this.OwnedFrameIds)
		{
			if (this.RedDotHasNewItem(itemId))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060114C3 RID: 70851 RVA: 0x00439268 File Offset: 0x00437468
	public bool RedDotHasNewStickerByAnyPart()
	{
		return this.RedDotHasNewItemByAnyPart(EOutlookType.Sticker);
	}

	// Token: 0x060114C4 RID: 70852 RVA: 0x00439271 File Offset: 0x00437471
	public bool RedDotHasNewStickerByPart(int stickerPart)
	{
		return this.RedDotHasNewItemByPart(EOutlookType.Sticker, stickerPart);
	}

	// Token: 0x060114C5 RID: 70853 RVA: 0x0043927B File Offset: 0x0043747B
	public bool RedDotHasNewDecorationByAnyPart()
	{
		return this.RedDotHasNewItemByAnyPart(EOutlookType.Decoration);
	}

	// Token: 0x060114C6 RID: 70854 RVA: 0x00439284 File Offset: 0x00437484
	public bool RedDotHasNewDecorationByPart(int decorationPart)
	{
		return this.RedDotHasNewItemByPart(EOutlookType.Decoration, decorationPart);
	}

	// Token: 0x060114C7 RID: 70855 RVA: 0x00439290 File Offset: 0x00437490
	public bool RedDotHasNewSkin()
	{
		foreach (int itemId in this.OwnedSkinIds)
		{
			if (this.RedDotHasNewItem(itemId))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060114C8 RID: 70856 RVA: 0x004392EC File Offset: 0x004374EC
	public bool RedDotHasNewItem(int itemId)
	{
		ServerStorageSet redDotCache = this.RedDotCache;
		return redDotCache != null && redDotCache.Has(itemId);
	}

	// Token: 0x060114C9 RID: 70857 RVA: 0x00439300 File Offset: 0x00437500
	public bool RedDotIsPreviewInAnyPart(EOutlookType outlookType)
	{
		List<int> list = new List<int>();
		if (outlookType == EOutlookType.Sticker)
		{
			list = MotorcycleDiyDefine.MOTORCYCLE_DIY_STICKER_PART.ToList<int>();
		}
		else if (outlookType == EOutlookType.Decoration)
		{
			list = MotorcycleDiyDefine.MOTORCYCLE_DIY_DECORATION_PART.ToList<int>();
		}
		foreach (int value in list)
		{
			if (this.RedDotIsPreview(outlookType, new int?(value)))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060114CA RID: 70858 RVA: 0x00439384 File Offset: 0x00437584
	public bool RedDotIsPreview(EOutlookType outlookType, int? part = null)
	{
		int selectedItemId = this.GetSelectedItemId(outlookType, part);
		return this.GetItemState(outlookType, selectedItemId) == EOutLookState.IsLock;
	}

	// Token: 0x17001611 RID: 5649
	// (get) Token: 0x060114CB RID: 70859 RVA: 0x004393A5 File Offset: 0x004375A5
	public static MotorcycleDiyModel Instance
	{
		get
		{
			return MotorcycleDiyModel._Instance;
		}
	}

	// Token: 0x060114CC RID: 70860 RVA: 0x004393AC File Offset: 0x004375AC
	public static MotorcycleDiyModel GetOrCreateInstance()
	{
		if (MotorcycleDiyModel._Instance == null)
		{
			MotorcycleDiyModel.CreateInstance();
		}
		return MotorcycleDiyModel._Instance;
	}

	// Token: 0x060114CD RID: 70861 RVA: 0x004393C0 File Offset: 0x004375C0
	public static bool CreateInstance()
	{
		if (MotorcycleDiyModel._Instance != null)
		{
			return true;
		}
		MotorcycleDiyModel._Instance = new MotorcycleDiyModel();
		return true;
	}

	// Token: 0x060114CE RID: 70862 RVA: 0x004393D6 File Offset: 0x004375D6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060114CF RID: 70863 RVA: 0x004393D8 File Offset: 0x004375D8
	public static void ResetStaticDefaultValue()
	{
		MotorcycleDiyModel._Instance = null;
	}

	// Token: 0x060114D0 RID: 70864 RVA: 0x004393E0 File Offset: 0x004375E0
	static MotorcycleDiyModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleDiyModel.CreateStaticDefaultValue), new Action(MotorcycleDiyModel.ResetStaticDefaultValue));
	}

	// Token: 0x060114D2 RID: 70866 RVA: 0x004394DC File Offset: 0x004376DC
	[CompilerGenerated]
	private bool <CheckIsBan>g__isConflict|59_0(EOutlookType type, int id, int? part = null, ref MotorcycleDiyModel.<>c__DisplayClass59_0 A_4)
	{
		if (id != 0)
		{
			if (type == A_4.outlookType)
			{
				int? num = part;
				int? targetPartId = A_4.targetPartId;
				if (num.GetValueOrDefault() == targetPartId.GetValueOrDefault() & num != null == (targetPartId != null))
				{
					return false;
				}
			}
			int? groupId = this.GetItemGroupConfigInfo(type, id).GroupId;
			return groupId != null && A_4.conflictGroupIds.Contains(groupId.Value);
		}
		return false;
	}

	// Token: 0x060114D3 RID: 70867 RVA: 0x00439554 File Offset: 0x00437754
	[CompilerGenerated]
	internal static string <GetBanTips>g__getItemName|60_0(EOutlookType type, int id)
	{
		string id2 = "";
		switch (type)
		{
		case EOutlookType.Frame:
		{
			MotorFrame? motorFrameConfig = MotorDiyConfig.Instance.GetMotorFrameConfig(id);
			id2 = ((motorFrameConfig != null) ? motorFrameConfig.Value.Title : "");
			break;
		}
		case EOutlookType.Sticker:
		{
			MotorSticker? motorStickerConfig = MotorDiyConfig.Instance.GetMotorStickerConfig(id);
			id2 = ((motorStickerConfig != null) ? motorStickerConfig.Value.Title : "");
			break;
		}
		case EOutlookType.Decoration:
		{
			MotorDecorations? motorDecorationConfig = MotorDiyConfig.Instance.GetMotorDecorationConfig(id);
			id2 = ((motorDecorationConfig != null) ? motorDecorationConfig.Value.Title : "");
			break;
		}
		}
		return ConfigMultiTextLang.GetLocalTextNew(id2, null) ?? "";
	}

	// Token: 0x060114D4 RID: 70868 RVA: 0x00439620 File Offset: 0x00437820
	[CompilerGenerated]
	private void <GetBanTips>g__checkAndAdd|60_1(EOutlookType type, int id, int? part = null, ref MotorcycleDiyModel.<>c__DisplayClass60_0 A_4)
	{
		if (id != 0)
		{
			if (type == A_4.outlookType)
			{
				int? num = part;
				int? targetPartId = A_4.targetPartId;
				if (num.GetValueOrDefault() == targetPartId.GetValueOrDefault() & num != null == (targetPartId != null))
				{
					return;
				}
			}
			IMotorDiyItemGroupConfigInfo itemGroupConfigInfo = this.GetItemGroupConfigInfo(type, id);
			if (itemGroupConfigInfo.GroupId != null && A_4.conflictGroupIds.Contains(itemGroupConfigInfo.GroupId.Value) && !A_4.addedGroupIds.Contains(itemGroupConfigInfo.GroupId.Value))
			{
				A_4.addedGroupIds.Add(itemGroupConfigInfo.GroupId.Value);
				string text = MotorcycleDiyModel.<GetBanTips>g__getItemName|60_0(type, id);
				if (text.Length > 0)
				{
					A_4.banItemName = text;
				}
			}
			return;
		}
	}

	// Token: 0x0400837C RID: 33660
	private List<int> CurCanUseStickerIds = new List<int>();

	// Token: 0x0400837D RID: 33661
	private List<int> CurCanUseFrameIds = new List<int>();

	// Token: 0x0400837E RID: 33662
	private List<int> CurCanUseDecorationsIds = new List<int>();

	// Token: 0x0400837F RID: 33663
	private readonly Dictionary<int, long> CanUseIdsTimeStamp = new Dictionary<int, long>();

	// Token: 0x04008380 RID: 33664
	private List<int> OwnedSkinIds = new List<int>();

	// Token: 0x04008381 RID: 33665
	private List<int> OwnedStickerIds = new List<int>();

	// Token: 0x04008382 RID: 33666
	private List<int> OwnedFrameIds = new List<int>();

	// Token: 0x04008383 RID: 33667
	private List<int> OwnedDecorationsIds = new List<int>();

	// Token: 0x04008384 RID: 33668
	private int CurSkinId;

	// Token: 0x04008385 RID: 33669
	private int CurFrameId;

	// Token: 0x04008386 RID: 33670
	private readonly Dictionary<EStickerParts, int> CurUsingStickerDict = new Dictionary<EStickerParts, int>();

	// Token: 0x04008387 RID: 33671
	private readonly Dictionary<EDecorationParts, int> CurUsingDecorationDict = new Dictionary<EDecorationParts, int>();

	// Token: 0x04008388 RID: 33672
	private readonly Dictionary<int, MotorcycleDiySkinEquipRecord> SkinSuitDict = new Dictionary<int, MotorcycleDiySkinEquipRecord>();

	// Token: 0x04008389 RID: 33673
	private List<MotorcycleDiyPresetData> CustomPresetDataList = new List<MotorcycleDiyPresetData>();

	// Token: 0x0400838A RID: 33674
	private int SelectedFrameId;

	// Token: 0x0400838B RID: 33675
	private readonly Dictionary<EStickerParts, int> SelectedStickerDict = new Dictionary<EStickerParts, int>();

	// Token: 0x0400838C RID: 33676
	private readonly Dictionary<EDecorationParts, int> SelectedDecorationDict = new Dictionary<EDecorationParts, int>();

	// Token: 0x0400838D RID: 33677
	private int DefaultFrameId;

	// Token: 0x0400838E RID: 33678
	private readonly HashSet<int> ProcessedItemIds = new HashSet<int>();

	// Token: 0x0400838F RID: 33679
	[Nullable(2)]
	private ServerStorageSet RedDotCache;

	// Token: 0x04008390 RID: 33680
	private bool HasInitSelectedInfo;

	// Token: 0x04008391 RID: 33681
	private readonly HashSet<int> RedDotOnViewOpenCache = new HashSet<int>();

	// Token: 0x04008392 RID: 33682
	private int CurSceneId;

	// Token: 0x04008393 RID: 33683
	private int DefaultSceneId;

	// Token: 0x04008394 RID: 33684
	private readonly List<int> SceneIdList = new List<int>();

	// Token: 0x04008395 RID: 33685
	private readonly HashSet<int> SceneItemIdSet = new HashSet<int>();

	// Token: 0x04008396 RID: 33686
	[Nullable(2)]
	private ServerStorageSet SceneRedDotCache;

	// Token: 0x04008397 RID: 33687
	[Nullable(2)]
	private static MotorcycleDiyModel _Instance;
}
