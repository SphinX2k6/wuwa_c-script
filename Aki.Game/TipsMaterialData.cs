using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x020018D8 RID: 6360
[NullableContext(1)]
[Nullable(0)]
public class TipsMaterialData : ItemTipsData
{
	// Token: 0x0600BA9C RID: 47772 RVA: 0x002A3CB0 File Offset: 0x002A1EB0
	public TipsMaterialData(ItemTipsParam data) : base(data)
	{
		this.ItemType = EItemTipsType.Normal;
		CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.ConfigId);
		this.MaterialType = itemConfigData.TypeDescription;
		this.ItemConfigType = itemConfigData.ItemType;
		this.FunctionSpritePath = this.GetItemBuffIconPathByBuffType(new EMediumItemGridBuffType?((EMediumItemGridBuffType)itemConfigData.ItemBuffType));
		int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.ConfigId, this.IncId);
		this.Num = itemCountByConfigId;
		this.TxtEffect = itemConfigData.AttributesDescription;
		this.TxtEffectArgs = itemConfigData.AttributesDescriptionArgs;
		this.TxtDescription = itemConfigData.BgDescription;
		if (itemConfigData.ExpiredConvertItemMap.Count > 0)
		{
			using (Dictionary<int, int>.Enumerator enumerator = itemConfigData.ExpiredConvertItemMap.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					KeyValuePair<int, int> keyValuePair = enumerator.Current;
					CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData2 = InventoryConfig.Instance.GetItemConfigData(keyValuePair.Key);
					this.ExTxtDescription = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("AutoConvertText_ItemDes", null), new string[]
					{
						keyValuePair.Value.ToString(),
						ConfigMultiTextLang.GetLocalTextNew(itemConfigData2.Name, null)
					});
				}
			}
		}
		CommonItemData commonItemData = InventoryModel.Instance.GetCommonItemData(this.ConfigId, this.IncId);
		if (commonItemData != null && commonItemData.IsLimitTimeItem())
		{
			long endTime = commonItemData.GetEndTime();
			DateTime dataFromTimeStamp = TimeUtil.Instance.GetDataFromTimeStamp((double)endTime * TimeUtil.Instance.Millisecond);
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("Text_ItemExpired_text", null);
			this.LimitTimeTxt = StringUtils.Format(localTextNew, new string[]
			{
				dataFromTimeStamp.Month.ToString(),
				dataFromTimeStamp.Day.ToString(),
				dataFromTimeStamp.Hour.ToString() + ":" + dataFromTimeStamp.Minute.ToString()
			});
		}
		this.TryApplyConsoleExtraPayGiftPreview();
	}

	// Token: 0x0600BA9D RID: 47773 RVA: 0x002A3EBC File Offset: 0x002A20BC
	private void TryApplyConsoleExtraPayGiftPreview()
	{
		PayShopModel instance = PayShopModel.Instance;
		IPreviewPayGiftEntry previewPayGiftEntry = (instance != null) ? instance.TryGetPreviewPayGiftEntry(this.ConfigId) : null;
		if (previewPayGiftEntry == null)
		{
			return;
		}
		if (this.LimitTimeTxt == null && previewPayGiftEntry.EndStampSec > 0L)
		{
			DateTime dataFromTimeStamp = TimeUtil.Instance.GetDataFromTimeStamp((double)previewPayGiftEntry.EndStampSec);
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("Text_ItemExpired_text", null);
			this.LimitTimeTxt = StringUtils.Format(localTextNew, new string[]
			{
				dataFromTimeStamp.Month.ToString(),
				dataFromTimeStamp.Day.ToString(),
				dataFromTimeStamp.Hour.ToString() + ":" + dataFromTimeStamp.Minute.ToString()
			});
		}
		if (!StringUtils.IsEmpty(previewPayGiftEntry.Title))
		{
			this.Title = previewPayGiftEntry.Title;
		}
		if (!StringUtils.IsEmpty(previewPayGiftEntry.RewardListDesc))
		{
			this.TxtEffect = previewPayGiftEntry.RewardListDesc;
			this.TxtDescription = "";
		}
		this.EffectAutoLocalText = false;
		this.Num = 1;
	}

	// Token: 0x0600BA9E RID: 47774 RVA: 0x002A3FC4 File Offset: 0x002A21C4
	[NullableContext(2)]
	private string GetItemBuffIconPathByBuffType(EMediumItemGridBuffType? buffIconType)
	{
		MediumItemGridModel instance = MediumItemGridModel.Instance;
		if (buffIconType != null)
		{
			switch (buffIconType.GetValueOrDefault())
			{
			case EMediumItemGridBuffType.Attack:
				return instance.AttackBuffSpritePath;
			case EMediumItemGridBuffType.Defense:
				return instance.DefenseBuffSpritePath;
			case EMediumItemGridBuffType.RestoreHealth:
				return instance.RestoreHealthBuffSpritePath;
			case EMediumItemGridBuffType.Recharge:
				return instance.RechargeBuffSpritePath;
			case EMediumItemGridBuffType.Resurrection:
				return instance.ResurrectionBuffSpritePath;
			case EMediumItemGridBuffType.Explore:
				return instance.ExploreBuffSpritePath;
			}
		}
		return null;
	}

	// Token: 0x0600BA9F RID: 47775 RVA: 0x002A4037 File Offset: 0x002A2237
	protected override bool OnIsShowIconBig()
	{
		return this.ItemConfigType.GetValueOrDefault() == InventoryDefine.EItemType.Phantom || this.ItemConfigType.GetValueOrDefault() == InventoryDefine.EItemType.MotorFrame || this.ItemConfigType.GetValueOrDefault() == InventoryDefine.EItemType.MotorSkin;
	}

	// Token: 0x040054A0 RID: 21664
	public string MaterialType;

	// Token: 0x040054A1 RID: 21665
	[Nullable(2)]
	public string FunctionSpritePath;

	// Token: 0x040054A2 RID: 21666
	public int Num;

	// Token: 0x040054A3 RID: 21667
	public string TxtEffect;

	// Token: 0x040054A4 RID: 21668
	public string[] TxtEffectArgs;

	// Token: 0x040054A5 RID: 21669
	public bool EffectAutoLocalText = true;

	// Token: 0x040054A6 RID: 21670
	public string TxtDescription;

	// Token: 0x040054A7 RID: 21671
	public InventoryDefine.EItemType? ItemConfigType;

	// Token: 0x040054A8 RID: 21672
	[Nullable(2)]
	public string ExTxtDescription;
}
