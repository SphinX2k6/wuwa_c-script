using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Phantom.Vision.View;

// Token: 0x02000D93 RID: 3475
[NullableContext(1)]
[Nullable(0)]
public class TipsVisionData : ItemTipsData
{
	// Token: 0x06008E8B RID: 36491 RVA: 0x002AEC2C File Offset: 0x002ACE2C
	public TipsVisionData(ItemTipsParam tipsParam) : base(tipsParam)
	{
		Aki.Protocol.PhantomItem phantomItem = tipsParam.ExtraParam as Aki.Protocol.PhantomItem;
		AttributeItemData attributeItemData;
		if (phantomItem != null)
		{
			attributeItemData = InventoryModel.Instance.GetPhantomItemDataByPhantomItem(phantomItem);
		}
		else
		{
			attributeItemData = InventoryModel.Instance.GetAttributeItemData(this.IncId);
		}
		if (phantomItem != null)
		{
			this.StackCount = Math.Max(1, phantomItem.StackCount);
		}
		else
		{
			PhantomItemData phantomItemData = attributeItemData as PhantomItemData;
			if (phantomItemData != null)
			{
				this.StackCount = phantomItemData.GetStackCount();
			}
		}
		Aki.Config.PhantomItem? phantomItemConfig = InventoryConfig.Instance.GetPhantomItemConfig(this.ConfigId);
		Aki.Config.PhantomItem? phantomItem2 = (this.IncId != 0) ? attributeItemData.GetConfig().As<Aki.Config.PhantomItem>() : phantomItemConfig;
		if (phantomItem2 == null)
		{
			return;
		}
		PhantomBattleModel instance = PhantomBattleModel.Instance;
		PhantomBattleData phantomBattleData = null;
		if (phantomItem != null)
		{
			phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleDataByPhantomItem(phantomItem);
		}
		else
		{
			phantomBattleData = ((this.IncId != 0) ? instance.GetPhantomBattleData(this.IncId) : null);
		}
		int level = (phantomBattleData != null) ? phantomBattleData.GetPhantomLevel() : 0;
		int quality = (phantomBattleData != null) ? phantomBattleData.GetQuality() : 1;
		this.CanStack = PhantomStackUtil.CanStackWithSameSpec(phantomBattleData);
		this.ItemType = EItemTipsType.Vision;
		this.VisionId = phantomItem2.Value.MonsterId;
		int rarity = phantomItem2.Value.Rarity;
		this.VisionType = ConfigPhantomRarityByRare.GetConfig(rarity, true).Value.Desc;
		this.Cost = PhantomBattleConfig.Instance.GetPhantomRareConfig(rarity).Value.Cost;
		this.ConfigId = ((phantomBattleData != null) ? phantomBattleData.GetConfigId(true) : this.ConfigId);
		this.Title = ((phantomBattleData != null) ? phantomBattleData.GetMonsterName() : this.Title);
		string textById = TextConfig.Instance.GetTextById("VisionLevel");
		this.UpgradeLevel = StringUtils.Format(textById, new string[]
		{
			level.ToString()
		});
		VisionDetailInfoComponentData visionDetailInfoComponentData = new VisionDetailInfoComponentData();
		if (phantomItemConfig != null && phantomBattleData == null)
		{
			int skillId = phantomItemConfig.Value.SkillId;
			PhantomSkill? phantomSkillBySkillId = PhantomBattleConfig.Instance.GetPhantomSkillBySkillId(skillId);
			if (phantomSkillBySkillId != null)
			{
				this.MainSkillText = phantomSkillBySkillId.Value.DescriptionEx;
				this.MainSkillParams = PhantomBattleConfig.Instance.GetPhantomSkillDescExByPhantomSkillIdAndQuality(skillId, quality);
				foreach (VisionDetailDesc data in VisionDetailDesc.ConvertVisionSkillDescToDescData(phantomSkillBySkillId.Value, level, true, true, quality))
				{
					visionDetailInfoComponentData.AddDescData(data);
				}
			}
		}
		List<ITipsAttributeItemData> list = new List<ITipsAttributeItemData>();
		List<AttrListScrollData> list2 = (phantomBattleData != null) ? phantomBattleData.GetMainPropShowAttributeList(CommonComponentDefine.EAttributeType.PhantomType, false) : null;
		if (list2 != null)
		{
			foreach (AttrListScrollData attrListScrollData in list2)
			{
				PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(attrListScrollData.Id);
				TipsAttributeItemData item = new TipsAttributeItemData
				{
					Id = attrListScrollData.Id,
					IsMainAttribute = true,
					Name = propertyIndexInfo.Value.Name,
					IconPath = propertyIndexInfo.Value.Icon,
					Value = attrListScrollData.BaseValue,
					IsRatio = attrListScrollData.IsRatio
				};
				list.Add(item);
			}
		}
		List<AttrListScrollData> list3 = (phantomBattleData != null) ? phantomBattleData.GetSubPropShowAttributeList(CommonComponentDefine.EAttributeType.PhantomType) : null;
		if (list3 != null)
		{
			foreach (AttrListScrollData attrListScrollData2 in list3)
			{
				PropertyIndex? propertyIndexInfo2 = PropertyIndexConfig.Instance.GetPropertyIndexInfo(attrListScrollData2.Id);
				TipsAttributeItemData item2 = new TipsAttributeItemData
				{
					Id = attrListScrollData2.Id,
					IsMainAttribute = false,
					Name = propertyIndexInfo2.Value.Name,
					IconPath = propertyIndexInfo2.Value.Icon,
					Value = attrListScrollData2.BaseValue,
					IsRatio = attrListScrollData2.IsRatio
				};
				list.Add(item2);
			}
		}
		this.AttributeData = list.ToArray();
		int? equipRole = PhantomBattleController.Instance.GetEquipRole(this.IncId);
		if (equipRole != null)
		{
			this.EquippedId = equipRole;
			int? equippedId = this.EquippedId;
			int num = 0;
			this.IsEquip = !(equippedId.GetValueOrDefault() == num & equippedId != null);
		}
		visionDetailInfoComponentData.DataBase = phantomBattleData;
		int num2 = -1;
		List<VisionFetterData> list4 = (phantomBattleData != null) ? phantomBattleData.GetPreviewShowFetterList(-1, 0) : null;
		bool ifPreview = true;
		if (phantomBattleData != null)
		{
			foreach (VisionDetailDesc data2 in VisionDetailDesc.ConvertVisionSkillDescToDescData(phantomBattleData.GetNormalSkillConfig().Value, phantomBattleData.GetPhantomLevel(), num2 == -1, ifPreview, quality))
			{
				visionDetailInfoComponentData.AddDescData(data2);
			}
		}
		if (list4 != null)
		{
			foreach (VisionDetailDesc data3 in VisionDetailDesc.ConvertVisionFetterDataToDetailDescData(list4, false, null, null))
			{
				visionDetailInfoComponentData.AddDescData(data3);
			}
		}
		this.VisionDetailInfoComponentData = visionDetailInfoComponentData;
	}

	// Token: 0x06008E8C RID: 36492 RVA: 0x002AF1E4 File Offset: 0x002AD3E4
	protected override bool OnIsShowIconBig()
	{
		return true;
	}

	// Token: 0x04005561 RID: 21857
	public int VisionId;

	// Token: 0x04005562 RID: 21858
	public string VisionType = "";

	// Token: 0x04005563 RID: 21859
	public int Cost;

	// Token: 0x04005564 RID: 21860
	public string UpgradeLevel = "";

	// Token: 0x04005565 RID: 21861
	public string MainSkillText = "";

	// Token: 0x04005566 RID: 21862
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] MainSkillParams;

	// Token: 0x04005567 RID: 21863
	[Nullable(2)]
	public string SkillUniqueText;

	// Token: 0x04005568 RID: 21864
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] SkillUniqueTextParam;

	// Token: 0x04005569 RID: 21865
	public int? SkillUniqueRoleId;

	// Token: 0x0400556A RID: 21866
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public ITipsAttributeItemData[] AttributeData;

	// Token: 0x0400556B RID: 21867
	public bool IsEquip;

	// Token: 0x0400556C RID: 21868
	public int? EquippedId;

	// Token: 0x0400556D RID: 21869
	public int StackCount = 1;

	// Token: 0x0400556E RID: 21870
	public int SelectedCount;

	// Token: 0x0400556F RID: 21871
	public bool CanStack;

	// Token: 0x04005570 RID: 21872
	[Nullable(2)]
	public VisionDetailInfoComponentData VisionDetailInfoComponentData;
}
