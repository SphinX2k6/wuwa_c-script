using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02002406 RID: 9222
[NullableContext(1)]
[Nullable(0)]
public class PhantomBattleData : PhantomDataBase
{
	// Token: 0x060127BE RID: 75710 RVA: 0x0048EF84 File Offset: 0x0048D184
	public void SetData(Aki.Protocol.PhantomItem phantomItemInfo)
	{
		this.UniqueId = phantomItemInfo.IncrId;
		this.PhantomLevel = phantomItemInfo.PhantomLevel;
		this.ItemId = phantomItemInfo.Id;
		this.PhantomExp = phantomItemInfo.PhantomExp;
		this.PhantomMainProp = phantomItemInfo.PhantomMainProp.ToList<Aki.Protocol.PhantomPropInfo>();
		this.PhantomSubProp = phantomItemInfo.PhantomSubProp.ToList<Aki.Protocol.PhantomPropInfo>();
		this.FetterGroupId = phantomItemInfo.FetterGroupId;
		this.FuncValue = phantomItemInfo.FuncValue;
		base.SetSkinId(phantomItemInfo.SkinId);
		base.SetIncId(this.UniqueId);
		this.UnAckSubProp = phantomItemInfo.UnAckSubProp.ToList<Aki.Protocol.PhantomPropInfo>();
		this.LockSubPropIndices = phantomItemInfo.LockPropIndex.ToList<int>();
	}

	// Token: 0x060127BF RID: 75711 RVA: 0x0048F035 File Offset: 0x0048D235
	public virtual int GetUniqueId()
	{
		return this.UniqueId;
	}

	// Token: 0x060127C0 RID: 75712 RVA: 0x0048F040 File Offset: 0x0048D240
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

	// Token: 0x060127C1 RID: 75713 RVA: 0x0048F0E0 File Offset: 0x0048D2E0
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

	// Token: 0x060127C2 RID: 75714 RVA: 0x0048F19C File Offset: 0x0048D39C
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

	// Token: 0x060127C3 RID: 75715 RVA: 0x0048F26C File Offset: 0x0048D46C
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

	// Token: 0x060127C4 RID: 75716 RVA: 0x0048F33C File Offset: 0x0048D53C
	public override bool IsBreach()
	{
		return this.PhantomSubProp.Count > 0;
	}

	// Token: 0x04008B6E RID: 35694
	private int UniqueId;
}
