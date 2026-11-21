using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x02000D91 RID: 3473
[NullableContext(1)]
[Nullable(0)]
public class TipsMaterialData : ItemTipsData
{
	// Token: 0x06008E85 RID: 36485 RVA: 0x002AE408 File Offset: 0x002AC608
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
				dataFromTimeStamp.Month.ToString("D2"),
				dataFromTimeStamp.Day.ToString("D2"),
				dataFromTimeStamp.Hour.ToString("D2") + ":" + dataFromTimeStamp.Minute.ToString("D2")
			});
		}
		this.TryApplyConsoleExtraPayGiftPreview();
	}

	// Token: 0x06008E86 RID: 36486 RVA: 0x002AE628 File Offset: 0x002AC828
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

	// Token: 0x06008E87 RID: 36487 RVA: 0x002AE730 File Offset: 0x002AC930
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

	// Token: 0x06008E88 RID: 36488 RVA: 0x002AE7A3 File Offset: 0x002AC9A3
	protected override bool OnIsShowIconBig()
	{
		return this.ItemConfigType.GetValueOrDefault() == InventoryDefine.EItemType.Phantom || this.ItemConfigType.GetValueOrDefault() == InventoryDefine.EItemType.MotorFrame || this.ItemConfigType.GetValueOrDefault() == InventoryDefine.EItemType.MotorSkin || this.ItemConfigType.GetValueOrDefault() == InventoryDefine.EItemType.WeaponSkin;
	}

	// Token: 0x0400554B RID: 21835
	public string MaterialType;

	// Token: 0x0400554C RID: 21836
	[Nullable(2)]
	public string FunctionSpritePath;

	// Token: 0x0400554D RID: 21837
	public int Num;

	// Token: 0x0400554E RID: 21838
	public string TxtEffect;

	// Token: 0x0400554F RID: 21839
	public string[] TxtEffectArgs;

	// Token: 0x04005550 RID: 21840
	public bool EffectAutoLocalText = true;

	// Token: 0x04005551 RID: 21841
	public string TxtDescription;

	// Token: 0x04005552 RID: 21842
	public InventoryDefine.EItemType? ItemConfigType;

	// Token: 0x04005553 RID: 21843
	[Nullable(2)]
	public string ExTxtDescription;
}
