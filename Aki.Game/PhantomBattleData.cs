using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020018EB RID: 6379
[NullableContext(1)]
[Nullable(0)]
public class PhantomBattleData : PhantomDataBase
{
	// Token: 0x0600FC74 RID: 64628 RVA: 0x0049C5A0 File Offset: 0x0049A7A0
	public void SetData(Aki.Protocol.PhantomItem phantomItemInfo)
	{
		this.UniqueId = phantomItemInfo.IncrId;
		this.PhantomLevel = phantomItemInfo.PhantomLevel;
		this.ItemId = phantomItemInfo.Id;
		this.PhantomExp = phantomItemInfo.PhantomExp;
		this.PhantomMainProp = new List<Aki.Protocol.PhantomPropInfo>(phantomItemInfo.PhantomMainProp);
		this.PhantomSubProp = new List<Aki.Protocol.PhantomPropInfo>(phantomItemInfo.PhantomSubProp);
		this.FetterGroupId = phantomItemInfo.FetterGroupId;
		this.FuncValue = phantomItemInfo.FuncValue;
		base.SetSkinId(phantomItemInfo.SkinId);
		base.SetIncId(this.UniqueId);
		this.UnAckSubProp = new List<Aki.Protocol.PhantomPropInfo>(phantomItemInfo.UnAckSubProp);
		this.LockSubPropIndices = new List<int>(phantomItemInfo.LockPropIndex);
	}

	// Token: 0x0600FC75 RID: 64629 RVA: 0x0049C651 File Offset: 0x0049A851
	public virtual int GetUniqueId()
	{
		return this.UniqueId;
	}

	// Token: 0x0600FC76 RID: 64630 RVA: 0x0049C65C File Offset: 0x0049A85C
	public List<PhantomSortStruct> GetMainPropArray()
	{
		List<PhantomSortStruct> list = new List<PhantomSortStruct>();
		foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo in base.GetPhantomMainProp())
		{
			PhantomMainPropItem phantomMainPropertyItemId = PhantomBattleConfig.Instance.GetPhantomMainPropertyItemId(phantomPropInfo.PhantomPropId);
			list.Add(new PhantomSortStruct
			{
				PhantomPropId = phantomMainPropertyItemId.PropId,
				Value = phantomPropInfo.Value,
				IfPercentage = (phantomMainPropertyItemId.AddType == 2)
			});
		}
		return list;
	}

	// Token: 0x0600FC77 RID: 64631 RVA: 0x0049C6FC File Offset: 0x0049A8FC
	public List<PhantomSortStruct> GetSubPropArray()
	{
		List<PhantomSortStruct> list = new List<PhantomSortStruct>();
		foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo in base.GetPhantomSubProp())
		{
			PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(phantomPropInfo.PhantomPropId);
			PhantomSubProperty phantomSubPropertyById = PhantomBattleConfig.Instance.GetPhantomSubPropertyById(phantomPropInfo.PhantomPropId);
			list.Add(new PhantomSortStruct
			{
				PhantomPropId = propertyIndexInfo.Value.Id,
				Value = phantomPropInfo.Value,
				IfPercentage = (phantomSubPropertyById.AddType == 2)
			});
		}
		return list;
	}

	// Token: 0x0600FC78 RID: 64632 RVA: 0x0049C7B8 File Offset: 0x0049A9B8
	public bool GetIfHaveRecommendMainProp(int roleId)
	{
		VisionAttrRecommendInfo roleCostAttrRecommendInfo = VisionRecommendModel.Instance.GetRoleCostAttrRecommendInfo(roleId, base.GetCost());
		List<AttrRecommendInfo> list = (roleCostAttrRecommendInfo != null) ? roleCostAttrRecommendInfo.GetMainAttrRecommendInfo() : null;
		if (list != null)
		{
			foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo in base.GetPhantomMainProp())
			{
				PhantomMainPropItem phantomMainPropertyItemId = PhantomBattleConfig.Instance.GetPhantomMainPropertyItemId(phantomPropInfo.PhantomPropId);
				int count = list.Count;
				for (int i = 0; i < count; i++)
				{
					if (phantomMainPropertyItemId.AddType == list[i].GetAddType() && phantomMainPropertyItemId.PropId == list[i].GetAttrId())
					{
						return true;
					}
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x0600FC79 RID: 64633 RVA: 0x0049C888 File Offset: 0x0049AA88
	public bool GetIfHaveRecommendSubProp(int roleId)
	{
		VisionAttrRecommendInfo roleCostAttrRecommendInfo = VisionRecommendModel.Instance.GetRoleCostAttrRecommendInfo(roleId, base.GetCost());
		List<AttrRecommendInfo> list = (roleCostAttrRecommendInfo != null) ? roleCostAttrRecommendInfo.GetSubAttrRecommendInfo() : null;
		if (list != null)
		{
			foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo in base.GetPhantomSubProp())
			{
				PhantomSubProperty phantomSubPropertyById = PhantomBattleConfig.Instance.GetPhantomSubPropertyById(phantomPropInfo.PhantomPropId);
				int count = list.Count;
				for (int i = 0; i < count; i++)
				{
					if (phantomSubPropertyById.AddType == list[i].GetAddType() && phantomSubPropertyById.PropId == list[i].GetAttrId())
					{
						return true;
					}
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x0600FC7A RID: 64634 RVA: 0x0049C958 File Offset: 0x0049AB58
	public override bool IsBreach()
	{
		return this.PhantomSubProp.Count > 0;
	}

	// Token: 0x04008CB5 RID: 36021
	private int UniqueId;
}
