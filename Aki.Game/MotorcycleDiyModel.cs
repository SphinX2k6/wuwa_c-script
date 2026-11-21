using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.LinkedItem;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;
using Google.Protobuf.Collections;

// Token: 0x0200177D RID: 6013
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MotorcycleDiyModel : ModelBase
{
	// Token: 0x0600E8FF RID: 59647 RVA: 0x00443B34 File Offset: 0x00441D34
	protected override bool OnInit()
	{
		this.CurUsingStickerDict[EStickerParts.AleftPart] = 0;
		this.CurUsingStickerDict[EStickerParts.ArightPart] = 0;
		this.CurUsingStickerDict[EStickerParts.BPart] = 0;
		this.CurUsingDecorationDict[EDecorationParts.HeadPart] = 0;
		this.InitSceneData();
		return true;
	}

	// Token: 0x0600E900 RID: 59648 RVA: 0x00443B74 File Offset: 0x00441D74
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

	// Token: 0x0600E901 RID: 59649 RVA: 0x00443C08 File Offset: 0x00441E08
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

	// Token: 0x0600E902 RID: 59650 RVA: 0x00443C94 File Offset: 0x00441E94
	private void InitRedDotInfo()
	{
		if (this.RedDotCache != null)
		{
			return;
		}
		this.RedDotCache = (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.MotorDiyNewUnlockId) as ServerStorageSet);
	}

	// Token: 0x0600E903 RID: 59651 RVA: 0x00443CB6 File Offset: 0x00441EB6
	private void TryInitSceneRedDotInfo()
	{
		if (this.SceneRedDotCache != null)
		{
			return;
		}
		this.SceneRedDotCache = (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.MotorSceneHadCheck) as ServerStorageSet);
	}

	// Token: 0x0600E904 RID: 59652 RVA: 0x00443CD8 File Offset: 0x00441ED8
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

	// Token: 0x0600E905 RID: 59653 RVA: 0x00443E90 File Offset: 0x00442090
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

	// Token: 0x0600E906 RID: 59654 RVA: 0x00443F04 File Offset: 0x00442104
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

	// Token: 0x0600E907 RID: 59655 RVA: 0x00443F7C File Offset: 0x0044217C
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

	// Token: 0x0600E908 RID: 59656 RVA: 0x0044403C File Offset: 0x0044223C
	public void UpdateSkinSuitInfo(IList<MotorOutlookEquippedPb> skinSuitDataList)
	{
		foreach (MotorOutlookEquippedPb motorOutlookEquippedPb in skinSuitDataList)
		{
			if (motorOutlookEquippedPb != null)
			{
				int skinEquipped = motorOutlookEquippedPb.SkinEquipped;
				MotorcycleDiySkinEquipRecord value = new MotorcycleDiySkinEquipRecord
				{
					FrameId = motorOutlookEquippedPb.FrameEquipped,
					StickerIds = MotorcycleDiyModel.ToIntArrayOrEmpty(motorOutlookEquippedPb.StickerEquipped),
					DecorateIds = MotorcycleDiyModel.ToIntArrayOrEmpty(motorOutlookEquippedPb.DecorationsEquipped)
				};
				this.SkinSuitDict[skinEquipped] = value;
			}
		}
	}

	// Token: 0x0600E909 RID: 59657 RVA: 0x004440C8 File Offset: 0x004422C8
	public void InitCustomPresetInfo(MotorOutlookPlayerPresetPb playerPreset)
	{
		this.CustomPresetDataList.Clear();
		this.UpdateCustomPresetInfo(playerPreset);
	}

	// Token: 0x0600E90A RID: 59658 RVA: 0x004440DC File Offset: 0x004422DC
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

	// Token: 0x0600E90B RID: 59659 RVA: 0x00444130 File Offset: 0x00442330
	public void RemoveSingleCustomPresetInfo(int presetId)
	{
		this.CustomPresetDataList.RemoveAll((MotorcycleDiyPresetData preset) => preset.CustomId == presetId);
	}

	// Token: 0x0600E90C RID: 59660 RVA: 0x00444164 File Offset: 0x00442364
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
			motorcycleDiyPresetData.StickerIds = MotorcycleDiyModel.ToIntArrayOrEmpty(preset2.StickerEquipped);
			motorcycleDiyPresetData.DecorateIds = MotorcycleDiyModel.ToIntArrayOrEmpty(preset2.DecorationsEquipped);
			motorcycleDiyPresetData.FrameId = preset2.FrameEquipped;
		}
	}

	// Token: 0x0600E90D RID: 59661 RVA: 0x00444218 File Offset: 0x00442418
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

	// Token: 0x0600E90E RID: 59662 RVA: 0x00444398 File Offset: 0x00442598
	private void UpdateSceneInUse(int? sceneInUse)
	{
		if (sceneInUse != null && sceneInUse.Value > 0)
		{
			this.CurSceneId = sceneInUse.Value;
		}
	}

	// Token: 0x0600E90F RID: 59663 RVA: 0x004443BC File Offset: 0x004425BC
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

	// Token: 0x0600E910 RID: 59664 RVA: 0x0044443C File Offset: 0x0044263C
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

	// Token: 0x0600E911 RID: 59665 RVA: 0x004445C4 File Offset: 0x004427C4
	public void UpdateMotorOutlookOwnedChange(MotorOutlookOwnedChangeNotify message)
	{
		MotorOutlookOwnedPb motorOutlookOwned = message.MotorOutlookOwned;
		if (motorOutlookOwned != null)
		{
			this.UpdateOwnedOutlookInfo(motorOutlookOwned);
		}
	}

	// Token: 0x0600E912 RID: 59666 RVA: 0x004445E4 File Offset: 0x004427E4
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

	// Token: 0x0600E913 RID: 59667 RVA: 0x00444614 File Offset: 0x00442814
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

	// Token: 0x0600E914 RID: 59668 RVA: 0x0044468C File Offset: 0x0044288C
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

	// Token: 0x0600E915 RID: 59669 RVA: 0x004446E8 File Offset: 0x004428E8
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

	// Token: 0x0600E916 RID: 59670 RVA: 0x00444774 File Offset: 0x00442974
	public List<int> GetDefaultStickerIdList()
	{
		List<int> list = new List<int>();
		foreach (int num in MotorcycleDiyDefine.MOTORCYCLE_DIY_STICKER_PART)
		{
			list.Add(0);
		}
		return list;
	}

	// Token: 0x0600E917 RID: 59671 RVA: 0x004447A8 File Offset: 0x004429A8
	public List<int> GetDefaultDecorationIdList()
	{
		List<int> list = new List<int>();
		foreach (int num in MotorcycleDiyDefine.MOTORCYCLE_DIY_DECORATION_PART)
		{
			list.Add(0);
		}
		return list;
	}

	// Token: 0x0600E918 RID: 59672 RVA: 0x004447DC File Offset: 0x004429DC
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
					List<int> list2 = new List<int>(motorLoadProject.GetStickerArray() ?? Array.Empty<int>());
					List<int> list3 = new List<int>(motorLoadProject.GetDecorationsArray() ?? Array.Empty<int>());
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

	// Token: 0x0600E919 RID: 59673 RVA: 0x004449E4 File Offset: 0x00442BE4
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

	// Token: 0x0600E91A RID: 59674 RVA: 0x00444B20 File Offset: 0x00442D20
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

	// Token: 0x0600E91B RID: 59675 RVA: 0x00444CCC File Offset: 0x00442ECC
	public void CheckRedDotForAnyItem(int itemId)
	{
		if (this.RedDotCache.Has(itemId))
		{
			this.RedDotCache.Remove(itemId);
			EventSystem.Instance.Emit(EEventName.MotorDiyInfoRedDotUpdate);
		}
	}

	// Token: 0x0600E91C RID: 59676 RVA: 0x00444CF8 File Offset: 0x00442EF8
	public bool CheckRedDotInViewOpenCache(int id)
	{
		return this.RedDotOnViewOpenCache.Contains(id);
	}

	// Token: 0x0600E91D RID: 59677 RVA: 0x00444D06 File Offset: 0x00442F06
	public void RemoveRedDotInViewOpenCache(int id)
	{
		this.RedDotOnViewOpenCache.Remove(id);
	}

	// Token: 0x0600E91E RID: 59678 RVA: 0x00444D18 File Offset: 0x00442F18
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

	// Token: 0x0600E91F RID: 59679 RVA: 0x00444E18 File Offset: 0x00443018
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

	// Token: 0x0600E920 RID: 59680 RVA: 0x00444FA4 File Offset: 0x004431A4
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

	// Token: 0x0600E921 RID: 59681 RVA: 0x00445174 File Offset: 0x00443374
	public List<int> GetSelectedItemIdList(EOutlookType outlookType, bool checkHasItem = false)
	{
		List<int> list = new List<int>();
		int[] array = Array.Empty<int>();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
		Func<int, bool> func = (int id) => false;
		switch (outlookType)
		{
		case EOutlookType.Sticker:
			array = MotorcycleDiyDefine.MOTORCYCLE_DIY_STICKER_PART;
			dictionary = new Dictionary<int, int>(this.SelectedStickerDict.Count);
			foreach (KeyValuePair<EStickerParts, int> keyValuePair in this.SelectedStickerDict)
			{
				dictionary[(int)keyValuePair.Key] = keyValuePair.Value;
			}
			dictionary2 = new Dictionary<int, int>(this.CurUsingStickerDict.Count);
			foreach (KeyValuePair<EStickerParts, int> keyValuePair2 in this.CurUsingStickerDict)
			{
				dictionary2[(int)keyValuePair2.Key] = keyValuePair2.Value;
			}
			func = new Func<int, bool>(this.HasSticker);
			break;
		case EOutlookType.Decoration:
			array = MotorcycleDiyDefine.MOTORCYCLE_DIY_DECORATION_PART;
			dictionary = new Dictionary<int, int>(this.SelectedDecorationDict.Count);
			foreach (KeyValuePair<EDecorationParts, int> keyValuePair3 in this.SelectedDecorationDict)
			{
				dictionary[(int)keyValuePair3.Key] = keyValuePair3.Value;
			}
			dictionary2 = new Dictionary<int, int>(this.CurUsingDecorationDict.Count);
			foreach (KeyValuePair<EDecorationParts, int> keyValuePair4 in this.CurUsingDecorationDict)
			{
				dictionary2[(int)keyValuePair4.Key] = keyValuePair4.Value;
			}
			func = new Func<int, bool>(this.HasDecoration);
			break;
		}
		foreach (int key in array)
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

	// Token: 0x0600E922 RID: 59682 RVA: 0x004453EC File Offset: 0x004435EC
	private List<int> GetEquippedItemIdList(EOutlookType outlookType)
	{
		List<int> list = new List<int>();
		int[] array = Array.Empty<int>();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		switch (outlookType)
		{
		case EOutlookType.None:
		case EOutlookType.Frame:
			goto IL_E4;
		case EOutlookType.Sticker:
			array = MotorcycleDiyDefine.MOTORCYCLE_DIY_STICKER_PART;
			dictionary = new Dictionary<int, int>(this.CurUsingStickerDict.Count);
			using (Dictionary<EStickerParts, int>.Enumerator enumerator = this.CurUsingStickerDict.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<EStickerParts, int> keyValuePair = enumerator.Current;
					dictionary[(int)keyValuePair.Key] = keyValuePair.Value;
				}
				goto IL_E4;
			}
			break;
		case EOutlookType.Decoration:
			break;
		default:
			goto IL_E4;
		}
		array = MotorcycleDiyDefine.MOTORCYCLE_DIY_DECORATION_PART;
		dictionary = new Dictionary<int, int>(this.CurUsingDecorationDict.Count);
		foreach (KeyValuePair<EDecorationParts, int> keyValuePair2 in this.CurUsingDecorationDict)
		{
			dictionary[(int)keyValuePair2.Key] = keyValuePair2.Value;
		}
		IL_E4:
		foreach (int key in array)
		{
			int item = dictionary.ContainsKey(key) ? dictionary[key] : 0;
			list.Add(item);
		}
		return list;
	}

	// Token: 0x0600E923 RID: 59683 RVA: 0x00445538 File Offset: 0x00443738
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

	// Token: 0x0600E924 RID: 59684 RVA: 0x004455D4 File Offset: 0x004437D4
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

	// Token: 0x0600E925 RID: 59685 RVA: 0x0044563C File Offset: 0x0044383C
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

	// Token: 0x0600E926 RID: 59686 RVA: 0x00445718 File Offset: 0x00443918
	public bool RedDotHasNewItemByAnyPart(EOutlookType outlookType)
	{
		int[] array = Array.Empty<int>();
		switch (outlookType)
		{
		case EOutlookType.Sticker:
			array = MotorcycleDiyDefine.MOTORCYCLE_DIY_STICKER_PART;
			break;
		case EOutlookType.Decoration:
			array = MotorcycleDiyDefine.MOTORCYCLE_DIY_DECORATION_PART;
			break;
		}
		foreach (int part in array)
		{
			if (this.RedDotHasNewItemByPart(outlookType, part))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600E927 RID: 59687 RVA: 0x00445774 File Offset: 0x00443974
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

	// Token: 0x0600E928 RID: 59688 RVA: 0x004458E8 File Offset: 0x00443AE8
	public List<int> GetCanUseStickerIdsInRegion()
	{
		return this.CurCanUseStickerIds.FindAll((int id) => !LinkedItemConfig.Instance.ShouldHide(id, this.HasSticker(id)));
	}

	// Token: 0x0600E929 RID: 59689 RVA: 0x00445901 File Offset: 0x00443B01
	public List<int> GetCanUseFrameIdsInRegion()
	{
		return this.CurCanUseFrameIds;
	}

	// Token: 0x0600E92A RID: 59690 RVA: 0x00445909 File Offset: 0x00443B09
	public List<int> GetCanUseDecorationsIdsInRegion()
	{
		return this.CurCanUseDecorationsIds;
	}

	// Token: 0x0600E92B RID: 59691 RVA: 0x00445914 File Offset: 0x00443B14
	public bool IsRegionItemInOpenTime(int itemId)
	{
		long num2;
		long num = this.CanUseIdsTimeStamp.TryGetValue(itemId, out num2) ? num2 : 0L;
		return (long)TimeUtil.Instance.GetServerTime() >= num;
	}

	// Token: 0x0600E92C RID: 59692 RVA: 0x00445948 File Offset: 0x00443B48
	public int GetEquippedSkinId()
	{
		return this.CurSkinId;
	}

	// Token: 0x0600E92D RID: 59693 RVA: 0x00445950 File Offset: 0x00443B50
	public int GetCurrentSceneId()
	{
		return this.CurSceneId;
	}

	// Token: 0x0600E92E RID: 59694 RVA: 0x00445958 File Offset: 0x00443B58
	public void SetCurrentSceneId(int sceneId)
	{
		this.CurSceneId = sceneId;
	}

	// Token: 0x0600E92F RID: 59695 RVA: 0x00445961 File Offset: 0x00443B61
	public List<int> GetMotorSceneIdList()
	{
		return this.SceneIdList;
	}

	// Token: 0x0600E930 RID: 59696 RVA: 0x0044596C File Offset: 0x00443B6C
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

	// Token: 0x0600E931 RID: 59697 RVA: 0x004459BE File Offset: 0x00443BBE
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

	// Token: 0x0600E932 RID: 59698 RVA: 0x004459F8 File Offset: 0x00443BF8
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

	// Token: 0x0600E933 RID: 59699 RVA: 0x00445A54 File Offset: 0x00443C54
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

	// Token: 0x0600E934 RID: 59700 RVA: 0x00445A92 File Offset: 0x00443C92
	public bool IsSceneItemId(int itemId)
	{
		return this.SceneItemIdSet.Contains(itemId);
	}

	// Token: 0x0600E935 RID: 59701 RVA: 0x00445AA0 File Offset: 0x00443CA0
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

	// Token: 0x0600E936 RID: 59702 RVA: 0x00445AE8 File Offset: 0x00443CE8
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

	// Token: 0x0600E937 RID: 59703 RVA: 0x00445B71 File Offset: 0x00443D71
	public bool HasSkin(int skinId)
	{
		return this.OwnedSkinIds.Contains(skinId);
	}

	// Token: 0x0600E938 RID: 59704 RVA: 0x00445B7F File Offset: 0x00443D7F
	public EOutLookState GetFrameState(int frameId)
	{
		return this.GetItemState(EOutlookType.Frame, frameId);
	}

	// Token: 0x0600E939 RID: 59705 RVA: 0x00445B89 File Offset: 0x00443D89
	public int GetSelectedFrameId()
	{
		return this.SelectedFrameId;
	}

	// Token: 0x0600E93A RID: 59706 RVA: 0x00445B91 File Offset: 0x00443D91
	public int GetEquippedFrameId()
	{
		return this.CurFrameId;
	}

	// Token: 0x0600E93B RID: 59707 RVA: 0x00445B99 File Offset: 0x00443D99
	public void SetSelectFrame(int frameId)
	{
		this.SelectedFrameId = frameId;
	}

	// Token: 0x0600E93C RID: 59708 RVA: 0x00445BA2 File Offset: 0x00443DA2
	public bool HasFrame(int frameId)
	{
		return this.OwnedFrameIds.Contains(frameId);
	}

	// Token: 0x0600E93D RID: 59709 RVA: 0x00445BB0 File Offset: 0x00443DB0
	public bool IsBanFrame(int frameId)
	{
		return this.CheckIsBan(EOutlookType.Frame, frameId);
	}

	// Token: 0x0600E93E RID: 59710 RVA: 0x00445BBC File Offset: 0x00443DBC
	public bool IsEquipFrameLockedByPlayer()
	{
		BaseTagComponent component = SceneTeamModel.Instance.GetCurrentEntity.Entity.GetComponent<BaseTagComponent>();
		bool flag = component.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.驾驶期间"]);
		bool flag2 = component.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.下车"]) || component.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.退场技"]);
		return flag || flag2;
	}

	// Token: 0x0600E93F RID: 59711 RVA: 0x00445C25 File Offset: 0x00443E25
	public EOutLookState GetStickerState(int stickerId)
	{
		return this.GetItemState(EOutlookType.Sticker, stickerId);
	}

	// Token: 0x0600E940 RID: 59712 RVA: 0x00445C2F File Offset: 0x00443E2F
	public List<int> GetSelectedStickerIdList(bool checkHasSticker = false)
	{
		return this.GetSelectedItemIdList(EOutlookType.Sticker, checkHasSticker);
	}

	// Token: 0x0600E941 RID: 59713 RVA: 0x00445C39 File Offset: 0x00443E39
	public int GetSelectedStickerId(int stickerPart)
	{
		if (!this.SelectedStickerDict.ContainsKey((EStickerParts)stickerPart))
		{
			return 0;
		}
		return this.SelectedStickerDict[(EStickerParts)stickerPart];
	}

	// Token: 0x0600E942 RID: 59714 RVA: 0x00445C57 File Offset: 0x00443E57
	public List<int> GetEquippedStickerIdList()
	{
		return this.GetEquippedItemIdList(EOutlookType.Sticker);
	}

	// Token: 0x0600E943 RID: 59715 RVA: 0x00445C60 File Offset: 0x00443E60
	public int GetEquippedStickerId(int stickerPart)
	{
		if (!this.CurUsingStickerDict.ContainsKey((EStickerParts)stickerPart))
		{
			return 0;
		}
		return this.CurUsingStickerDict[(EStickerParts)stickerPart];
	}

	// Token: 0x0600E944 RID: 59716 RVA: 0x00445C7E File Offset: 0x00443E7E
	public void SetSelectStickerInfo(int stickerPart, int stickerId)
	{
		this.SelectedStickerDict[(EStickerParts)stickerPart] = stickerId;
	}

	// Token: 0x0600E945 RID: 59717 RVA: 0x00445C8D File Offset: 0x00443E8D
	public bool IsEquipDefaultSticker(int stickerPart)
	{
		return this.CurUsingStickerDict.ContainsKey((EStickerParts)stickerPart) && this.CurUsingStickerDict[(EStickerParts)stickerPart] == 0;
	}

	// Token: 0x0600E946 RID: 59718 RVA: 0x00445CAE File Offset: 0x00443EAE
	public bool IsBanSticker(int stickerId)
	{
		return this.CheckIsBan(EOutlookType.Sticker, stickerId);
	}

	// Token: 0x0600E947 RID: 59719 RVA: 0x00445CB8 File Offset: 0x00443EB8
	public bool HasSticker(int stickerId)
	{
		return stickerId <= 0 || this.OwnedStickerIds.Contains(stickerId);
	}

	// Token: 0x0600E948 RID: 59720 RVA: 0x00445CCC File Offset: 0x00443ECC
	public EOutLookState GetDecorationState(int decorationId)
	{
		return this.GetItemState(EOutlookType.Decoration, decorationId);
	}

	// Token: 0x0600E949 RID: 59721 RVA: 0x00445CD6 File Offset: 0x00443ED6
	public List<int> GetSelectedDecorationIdList(bool checkHasDecoration = false)
	{
		return this.GetSelectedItemIdList(EOutlookType.Decoration, checkHasDecoration);
	}

	// Token: 0x0600E94A RID: 59722 RVA: 0x00445CE0 File Offset: 0x00443EE0
	public int GetSelectedDecorationId(int decorationPart)
	{
		if (!this.SelectedDecorationDict.ContainsKey((EDecorationParts)decorationPart))
		{
			return 0;
		}
		return this.SelectedDecorationDict[(EDecorationParts)decorationPart];
	}

	// Token: 0x0600E94B RID: 59723 RVA: 0x00445CFE File Offset: 0x00443EFE
	public List<int> GetEquippedDecorationIdList()
	{
		return this.GetEquippedItemIdList(EOutlookType.Decoration);
	}

	// Token: 0x0600E94C RID: 59724 RVA: 0x00445D07 File Offset: 0x00443F07
	public int GetEquippedDecorationId(int decorationPart)
	{
		if (!this.CurUsingDecorationDict.ContainsKey((EDecorationParts)decorationPart))
		{
			return 0;
		}
		return this.CurUsingDecorationDict[(EDecorationParts)decorationPart];
	}

	// Token: 0x0600E94D RID: 59725 RVA: 0x00445D25 File Offset: 0x00443F25
	public void SetSelectDecorationInfo(int decorationPart, int decorationId)
	{
		this.SelectedDecorationDict[(EDecorationParts)decorationPart] = decorationId;
	}

	// Token: 0x0600E94E RID: 59726 RVA: 0x00445D34 File Offset: 0x00443F34
	public bool IsEquipDefaultDecoration(int decorationPart)
	{
		return this.CurUsingDecorationDict.ContainsKey((EDecorationParts)decorationPart) && this.CurUsingDecorationDict[(EDecorationParts)decorationPart] == 0;
	}

	// Token: 0x0600E94F RID: 59727 RVA: 0x00445D55 File Offset: 0x00443F55
	public bool IsBanDecoration(int decorationId)
	{
		return this.CheckIsBan(EOutlookType.Decoration, decorationId);
	}

	// Token: 0x0600E950 RID: 59728 RVA: 0x00445D5F File Offset: 0x00443F5F
	public bool HasDecoration(int decorationId)
	{
		return decorationId <= 0 || this.OwnedDecorationsIds.Contains(decorationId);
	}

	// Token: 0x0600E951 RID: 59729 RVA: 0x00445D73 File Offset: 0x00443F73
	public bool CanShowDiyPartRedDot()
	{
		return this.IsEquipDefaultSkin();
	}

	// Token: 0x0600E952 RID: 59730 RVA: 0x00445D7B File Offset: 0x00443F7B
	public bool RedDotHasAnyNewItem()
	{
		return this.RedDotHasNewFrame() || this.RedDotHasNewStickerByAnyPart() || this.RedDotHasNewDecorationByAnyPart() || this.RedDotHasNewSkin();
	}

	// Token: 0x0600E953 RID: 59731 RVA: 0x00445D9D File Offset: 0x00443F9D
	public bool RedDotHasAnyNewItemVisible()
	{
		return this.CanShowDiyPartRedDot() && this.RedDotHasAnyNewItem();
	}

	// Token: 0x0600E954 RID: 59732 RVA: 0x00445DAF File Offset: 0x00443FAF
	public bool RedDotForDiyTab()
	{
		return this.RedDotHasAnyNewItemVisible() || this.RedDotHasAnyNewScene();
	}

	// Token: 0x0600E955 RID: 59733 RVA: 0x00445DC1 File Offset: 0x00443FC1
	public bool RedDotHasNewFrameVisible()
	{
		return this.CanShowDiyPartRedDot() && this.RedDotHasNewFrame();
	}

	// Token: 0x0600E956 RID: 59734 RVA: 0x00445DD3 File Offset: 0x00443FD3
	public bool RedDotHasNewStickerByAnyPartVisible()
	{
		return this.CanShowDiyPartRedDot() && this.RedDotHasNewStickerByAnyPart();
	}

	// Token: 0x0600E957 RID: 59735 RVA: 0x00445DE5 File Offset: 0x00443FE5
	public bool RedDotHasNewDecorationByAnyPartVisible()
	{
		return this.CanShowDiyPartRedDot() && this.RedDotHasNewDecorationByAnyPart();
	}

	// Token: 0x0600E958 RID: 59736 RVA: 0x00445DF8 File Offset: 0x00443FF8
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

	// Token: 0x0600E959 RID: 59737 RVA: 0x00445E54 File Offset: 0x00444054
	public bool RedDotHasNewStickerByAnyPart()
	{
		return this.RedDotHasNewItemByAnyPart(EOutlookType.Sticker);
	}

	// Token: 0x0600E95A RID: 59738 RVA: 0x00445E5D File Offset: 0x0044405D
	public bool RedDotHasNewStickerByPart(int stickerPart)
	{
		return this.RedDotHasNewItemByPart(EOutlookType.Sticker, stickerPart);
	}

	// Token: 0x0600E95B RID: 59739 RVA: 0x00445E67 File Offset: 0x00444067
	public bool RedDotHasNewDecorationByAnyPart()
	{
		return this.RedDotHasNewItemByAnyPart(EOutlookType.Decoration);
	}

	// Token: 0x0600E95C RID: 59740 RVA: 0x00445E70 File Offset: 0x00444070
	public bool RedDotHasNewDecorationByPart(int decorationPart)
	{
		return this.RedDotHasNewItemByPart(EOutlookType.Decoration, decorationPart);
	}

	// Token: 0x0600E95D RID: 59741 RVA: 0x00445E7C File Offset: 0x0044407C
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

	// Token: 0x0600E95E RID: 59742 RVA: 0x00445ED8 File Offset: 0x004440D8
	public bool RedDotHasNewItem(int itemId)
	{
		ServerStorageSet redDotCache = this.RedDotCache;
		return redDotCache != null && redDotCache.Has(itemId);
	}

	// Token: 0x0600E95F RID: 59743 RVA: 0x00445EEC File Offset: 0x004440EC
	public bool RedDotIsPreviewInAnyPart(EOutlookType outlookType)
	{
		int[] array = Array.Empty<int>();
		if (outlookType == EOutlookType.Sticker)
		{
			array = MotorcycleDiyDefine.MOTORCYCLE_DIY_STICKER_PART;
		}
		else if (outlookType == EOutlookType.Decoration)
		{
			array = MotorcycleDiyDefine.MOTORCYCLE_DIY_DECORATION_PART;
		}
		foreach (int value in array)
		{
			if (this.RedDotIsPreview(outlookType, new int?(value)))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600E960 RID: 59744 RVA: 0x00445F3C File Offset: 0x0044413C
	public bool RedDotIsPreview(EOutlookType outlookType, int? part = null)
	{
		int selectedItemId = this.GetSelectedItemId(outlookType, part);
		return this.GetItemState(outlookType, selectedItemId) == EOutLookState.IsLock;
	}

	// Token: 0x0600E961 RID: 59745 RVA: 0x00445F60 File Offset: 0x00444160
	private static int[] ToIntArrayOrEmpty([Nullable(2)] RepeatedField<int> source)
	{
		if (source == null)
		{
			return Array.Empty<int>();
		}
		int[] array = new int[source.Count];
		source.CopyTo(array, 0);
		return array;
	}

	// Token: 0x17001648 RID: 5704
	// (get) Token: 0x0600E962 RID: 59746 RVA: 0x00445F8B File Offset: 0x0044418B
	public static MotorcycleDiyModel Instance
	{
		get
		{
			return MotorcycleDiyModel._Instance;
		}
	}

	// Token: 0x0600E963 RID: 59747 RVA: 0x00445F92 File Offset: 0x00444192
	public static MotorcycleDiyModel GetOrCreateInstance()
	{
		if (MotorcycleDiyModel._Instance == null)
		{
			MotorcycleDiyModel.CreateInstance();
		}
		return MotorcycleDiyModel._Instance;
	}

	// Token: 0x0600E964 RID: 59748 RVA: 0x00445FA6 File Offset: 0x004441A6
	public static bool CreateInstance()
	{
		if (MotorcycleDiyModel._Instance != null)
		{
			return true;
		}
		MotorcycleDiyModel._Instance = new MotorcycleDiyModel();
		return true;
	}

	// Token: 0x0600E965 RID: 59749 RVA: 0x00445FBC File Offset: 0x004441BC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E966 RID: 59750 RVA: 0x00445FBE File Offset: 0x004441BE
	public static void ResetStaticDefaultValue()
	{
		MotorcycleDiyModel._Instance = null;
	}

	// Token: 0x0600E967 RID: 59751 RVA: 0x00445FC6 File Offset: 0x004441C6
	static MotorcycleDiyModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleDiyModel.CreateStaticDefaultValue), new Action(MotorcycleDiyModel.ResetStaticDefaultValue));
	}

	// Token: 0x0600E969 RID: 59753 RVA: 0x004460C4 File Offset: 0x004442C4
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
			return groupId != null && Array.IndexOf<int>(A_4.conflictGroupIds, groupId.Value) >= 0;
		}
		return false;
	}

	// Token: 0x0600E96A RID: 59754 RVA: 0x00446140 File Offset: 0x00444340
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

	// Token: 0x0600E96B RID: 59755 RVA: 0x0044620C File Offset: 0x0044440C
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
			if (itemGroupConfigInfo.GroupId != null && Array.IndexOf<int>(A_4.conflictGroupIds, itemGroupConfigInfo.GroupId.Value) >= 0 && !A_4.addedGroupIds.Contains(itemGroupConfigInfo.GroupId.Value))
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

	// Token: 0x040084BA RID: 33978
	private List<int> CurCanUseStickerIds = new List<int>();

	// Token: 0x040084BB RID: 33979
	private List<int> CurCanUseFrameIds = new List<int>();

	// Token: 0x040084BC RID: 33980
	private List<int> CurCanUseDecorationsIds = new List<int>();

	// Token: 0x040084BD RID: 33981
	private readonly Dictionary<int, long> CanUseIdsTimeStamp = new Dictionary<int, long>();

	// Token: 0x040084BE RID: 33982
	private List<int> OwnedSkinIds = new List<int>();

	// Token: 0x040084BF RID: 33983
	private List<int> OwnedStickerIds = new List<int>();

	// Token: 0x040084C0 RID: 33984
	private List<int> OwnedFrameIds = new List<int>();

	// Token: 0x040084C1 RID: 33985
	private List<int> OwnedDecorationsIds = new List<int>();

	// Token: 0x040084C2 RID: 33986
	private int CurSkinId;

	// Token: 0x040084C3 RID: 33987
	private int CurFrameId;

	// Token: 0x040084C4 RID: 33988
	private readonly Dictionary<EStickerParts, int> CurUsingStickerDict = new Dictionary<EStickerParts, int>();

	// Token: 0x040084C5 RID: 33989
	private readonly Dictionary<EDecorationParts, int> CurUsingDecorationDict = new Dictionary<EDecorationParts, int>();

	// Token: 0x040084C6 RID: 33990
	private readonly Dictionary<int, MotorcycleDiySkinEquipRecord> SkinSuitDict = new Dictionary<int, MotorcycleDiySkinEquipRecord>();

	// Token: 0x040084C7 RID: 33991
	private List<MotorcycleDiyPresetData> CustomPresetDataList = new List<MotorcycleDiyPresetData>();

	// Token: 0x040084C8 RID: 33992
	private int SelectedFrameId;

	// Token: 0x040084C9 RID: 33993
	private readonly Dictionary<EStickerParts, int> SelectedStickerDict = new Dictionary<EStickerParts, int>();

	// Token: 0x040084CA RID: 33994
	private readonly Dictionary<EDecorationParts, int> SelectedDecorationDict = new Dictionary<EDecorationParts, int>();

	// Token: 0x040084CB RID: 33995
	private int DefaultFrameId;

	// Token: 0x040084CC RID: 33996
	private readonly HashSet<int> ProcessedItemIds = new HashSet<int>();

	// Token: 0x040084CD RID: 33997
	[Nullable(2)]
	private ServerStorageSet RedDotCache;

	// Token: 0x040084CE RID: 33998
	private bool HasInitSelectedInfo;

	// Token: 0x040084CF RID: 33999
	private readonly HashSet<int> RedDotOnViewOpenCache = new HashSet<int>();

	// Token: 0x040084D0 RID: 34000
	private int CurSceneId;

	// Token: 0x040084D1 RID: 34001
	private int DefaultSceneId;

	// Token: 0x040084D2 RID: 34002
	private readonly List<int> SceneIdList = new List<int>();

	// Token: 0x040084D3 RID: 34003
	private readonly HashSet<int> SceneItemIdSet = new HashSet<int>();

	// Token: 0x040084D4 RID: 34004
	[Nullable(2)]
	private ServerStorageSet SceneRedDotCache;

	// Token: 0x040084D5 RID: 34005
	[Nullable(2)]
	private static MotorcycleDiyModel _Instance;
}
