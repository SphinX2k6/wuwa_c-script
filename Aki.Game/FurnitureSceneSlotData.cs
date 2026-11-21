using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

// Token: 0x02000427 RID: 1063
[NullableContext(1)]
[Nullable(0)]
public class FurnitureSceneSlotData : FurnitureSlotDataBase
{
	// Token: 0x060038D4 RID: 14548 RVA: 0x0014AB7A File Offset: 0x00148D7A
	public override EFurnitureSlotType GetSlotType()
	{
		return EFurnitureSlotType.SceneSlot;
	}

	// Token: 0x060038D5 RID: 14549 RVA: 0x0014AB80 File Offset: 0x00148D80
	public void SetSceneSlotData(int mapId, int slotEntityId)
	{
		this.MapId = mapId;
		this.SlotEntityId = slotEntityId;
		IFurnitureSlot sceneSlotEntitySlotInfo = FurnitureModel.Instance.GetSceneSlotEntitySlotInfo(mapId, slotEntityId);
		if (sceneSlotEntitySlotInfo == null)
		{
			return;
		}
		this.SlotTagId = sceneSlotEntitySlotInfo.FurnitureTag;
		this.ExcludedFurnitureIds = (sceneSlotEntitySlotInfo.ExcludedFurnitureIds ?? new List<int>());
	}

	// Token: 0x060038D6 RID: 14550 RVA: 0x0014ABD0 File Offset: 0x00148DD0
	public void DeepCopy(FurnitureSceneSlotData other)
	{
		base.DeepCopy(other);
		this.SlotEntityId = other.SlotEntityId;
		this.SubSlotDataList = new List<FurnitureSubSlotData>();
		for (int i = 0; i < other.SubSlotDataList.Count; i++)
		{
			FurnitureSubSlotData other2 = other.SubSlotDataList[i];
			FurnitureSubSlotData furnitureSubSlotData = new FurnitureSubSlotData();
			furnitureSubSlotData.DeepCopy(other2);
			this.SubSlotDataList.Add(furnitureSubSlotData);
		}
		this.MapId = other.MapId;
	}

	// Token: 0x060038D7 RID: 14551 RVA: 0x0014AC44 File Offset: 0x00148E44
	public bool Compare(FurnitureSceneSlotData other)
	{
		if (!base.Compare(other))
		{
			return false;
		}
		if (this.MapId != other.MapId)
		{
			return false;
		}
		if (this.SlotEntityId != other.SlotEntityId)
		{
			return false;
		}
		if (this.SubSlotDataList.Count != other.SubSlotDataList.Count)
		{
			return false;
		}
		for (int i = 0; i < this.SubSlotDataList.Count; i++)
		{
			if (!this.SubSlotDataList[i].Compare(other.SubSlotDataList[i]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060038D8 RID: 14552 RVA: 0x0014ACD0 File Offset: 0x00148ED0
	public IFurnitureSceneSlotDiff GetSceneSlotDiff(FurnitureSceneSlotData other)
	{
		int rootFurnitureToUnPlace = 0;
		int rootFurnitureToPlace = 0;
		if (this.PlacedFurnitureConfigId != other.PlacedFurnitureConfigId)
		{
			rootFurnitureToUnPlace = this.PlacedFurnitureConfigId;
			rootFurnitureToPlace = other.PlacedFurnitureConfigId;
		}
		List<FurnitureSubSlotData> subSlotDataList = this.GetSubSlotDataList();
		List<FurnitureSubSlotData> subSlotDataList2 = other.GetSubSlotDataList();
		int[] array = new int[subSlotDataList.Count];
		int[] array2 = new int[subSlotDataList2.Count];
		for (int i = 0; i < this.SubSlotDataList.Count; i++)
		{
			int placedFurnitureConfigId = this.SubSlotDataList[i].GetPlacedFurnitureConfigId();
			if (placedFurnitureConfigId <= 0)
			{
				array[i] = 0;
			}
			else if (i >= subSlotDataList2.Count)
			{
				array[i] = placedFurnitureConfigId;
			}
			else
			{
				int placedFurnitureConfigId2 = subSlotDataList2[i].GetPlacedFurnitureConfigId();
				if (placedFurnitureConfigId != placedFurnitureConfigId2)
				{
					array[i] = placedFurnitureConfigId;
				}
				else
				{
					array[i] = 0;
				}
			}
		}
		for (int j = 0; j < subSlotDataList2.Count; j++)
		{
			int placedFurnitureConfigId3 = subSlotDataList2[j].GetPlacedFurnitureConfigId();
			if (placedFurnitureConfigId3 <= 0)
			{
				array2[j] = 0;
			}
			else if (j >= subSlotDataList.Count)
			{
				array2[j] = placedFurnitureConfigId3;
			}
			else if (subSlotDataList[j].GetPlacedFurnitureConfigId() != placedFurnitureConfigId3)
			{
				array2[j] = placedFurnitureConfigId3;
			}
			else
			{
				array2[j] = 0;
			}
		}
		return new FurnitureSceneSlotDiff
		{
			RootFurnitureToUnPlace = rootFurnitureToUnPlace,
			RootFurnitureToPlace = rootFurnitureToPlace,
			SubFurnitureListToUnPlace = array,
			SubFurnitureListToPlace = array2
		};
	}

	// Token: 0x060038D9 RID: 14553 RVA: 0x0014AE20 File Offset: 0x00149020
	public override void PlaceFurniture(int furnitureConfigId)
	{
		this.PlacedFurnitureConfigId = furnitureConfigId;
		this.ClearSubSlotDataList();
		IReadOnlyList<IFurnitureSlot> subSlotInfos = FurnitureModel.Instance.GetSubSlotInfos(furnitureConfigId);
		if (subSlotInfos == null)
		{
			return;
		}
		for (int i = 0; i < subSlotInfos.Count; i++)
		{
			IFurnitureSlot furnitureSlot = subSlotInfos[i];
			FurnitureSubSlotData furnitureSubSlotData = new FurnitureSubSlotData();
			furnitureSubSlotData.SetSlotData(this.SlotEntityId, furnitureConfigId, i, furnitureSlot.FurnitureTag, furnitureSlot.ExcludedFurnitureIds ?? new List<int>());
			this.SubSlotDataList.Add(furnitureSubSlotData);
		}
	}

	// Token: 0x060038DA RID: 14554 RVA: 0x0014AE98 File Offset: 0x00149098
	public override void UnPlaceFurniture()
	{
		this.PlacedFurnitureConfigId = 0;
		this.ClearSubSlotDataList();
	}

	// Token: 0x060038DB RID: 14555 RVA: 0x0014AEA7 File Offset: 0x001490A7
	public void ClearSubSlotDataList()
	{
		this.SubSlotDataList.Clear();
	}

	// Token: 0x060038DC RID: 14556 RVA: 0x0014AEB4 File Offset: 0x001490B4
	public FurnitureSubSlotData GetSubSlotData(int index)
	{
		return this.SubSlotDataList[index];
	}

	// Token: 0x060038DD RID: 14557 RVA: 0x0014AEC2 File Offset: 0x001490C2
	public int GetSubSlotDataListLength()
	{
		return this.SubSlotDataList.Count;
	}

	// Token: 0x060038DE RID: 14558 RVA: 0x0014AECF File Offset: 0x001490CF
	public List<FurnitureSubSlotData> GetSubSlotDataList()
	{
		return this.SubSlotDataList;
	}

	// Token: 0x060038DF RID: 14559 RVA: 0x0014AED7 File Offset: 0x001490D7
	public int GetSlotEntityId()
	{
		return this.SlotEntityId;
	}

	// Token: 0x04002E9C RID: 11932
	protected int SlotEntityId;

	// Token: 0x04002E9D RID: 11933
	protected List<FurnitureSubSlotData> SubSlotDataList = new List<FurnitureSubSlotData>();

	// Token: 0x04002E9E RID: 11934
	protected int MapId;
}
