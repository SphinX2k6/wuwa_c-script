using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

// Token: 0x02000F72 RID: 3954
[NullableContext(1)]
[Nullable(0)]
public class FurnitureSceneSlotData : FurnitureSlotDataBase
{
	// Token: 0x0600653C RID: 25916 RVA: 0x001422DE File Offset: 0x001404DE
	public override EFurnitureSlotType GetSlotType()
	{
		return EFurnitureSlotType.SceneSlot;
	}

	// Token: 0x0600653D RID: 25917 RVA: 0x001422E4 File Offset: 0x001404E4
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

	// Token: 0x0600653E RID: 25918 RVA: 0x00142334 File Offset: 0x00140534
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

	// Token: 0x0600653F RID: 25919 RVA: 0x001423A8 File Offset: 0x001405A8
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

	// Token: 0x06006540 RID: 25920 RVA: 0x00142434 File Offset: 0x00140634
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

	// Token: 0x06006541 RID: 25921 RVA: 0x00142584 File Offset: 0x00140784
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

	// Token: 0x06006542 RID: 25922 RVA: 0x001425FC File Offset: 0x001407FC
	public override void UnPlaceFurniture()
	{
		this.PlacedFurnitureConfigId = 0;
		this.ClearSubSlotDataList();
	}

	// Token: 0x06006543 RID: 25923 RVA: 0x0014260B File Offset: 0x0014080B
	public void ClearSubSlotDataList()
	{
		this.SubSlotDataList.Clear();
	}

	// Token: 0x06006544 RID: 25924 RVA: 0x00142618 File Offset: 0x00140818
	public FurnitureSubSlotData GetSubSlotData(int index)
	{
		return this.SubSlotDataList[index];
	}

	// Token: 0x06006545 RID: 25925 RVA: 0x00142626 File Offset: 0x00140826
	public int GetSubSlotDataListLength()
	{
		return this.SubSlotDataList.Count;
	}

	// Token: 0x06006546 RID: 25926 RVA: 0x00142633 File Offset: 0x00140833
	public List<FurnitureSubSlotData> GetSubSlotDataList()
	{
		return this.SubSlotDataList;
	}

	// Token: 0x06006547 RID: 25927 RVA: 0x0014263B File Offset: 0x0014083B
	public int GetSlotEntityId()
	{
		return this.SlotEntityId;
	}

	// Token: 0x04002E03 RID: 11779
	protected int SlotEntityId;

	// Token: 0x04002E04 RID: 11780
	protected List<FurnitureSubSlotData> SubSlotDataList = new List<FurnitureSubSlotData>();

	// Token: 0x04002E05 RID: 11781
	protected int MapId;
}
