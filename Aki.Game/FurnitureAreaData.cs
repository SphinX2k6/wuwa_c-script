using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000426 RID: 1062
[NullableContext(1)]
[Nullable(0)]
public class FurnitureAreaData
{
	// Token: 0x060038B7 RID: 14519 RVA: 0x0014A490 File Offset: 0x00148690
	public void DeepCopy(FurnitureAreaData other)
	{
		this.AreaId = other.AreaId;
		this.MapId = other.MapId;
		this.Atmosphere = other.Atmosphere;
		this.MaxAtmosphere = other.MaxAtmosphere;
		this.SceneSlotDataMap.Clear();
		foreach (KeyValuePair<int, FurnitureSceneSlotData> keyValuePair in other.SceneSlotDataMap)
		{
			FurnitureSceneSlotData furnitureSceneSlotData = new FurnitureSceneSlotData();
			furnitureSceneSlotData.DeepCopy(keyValuePair.Value);
			this.SceneSlotDataMap[keyValuePair.Key] = furnitureSceneSlotData;
		}
		this.FurnitureUseCountMap.Clear();
		foreach (KeyValuePair<int, int> keyValuePair2 in other.FurnitureUseCountMap)
		{
			this.FurnitureUseCountMap[keyValuePair2.Key] = keyValuePair2.Value;
		}
	}

	// Token: 0x060038B8 RID: 14520 RVA: 0x0014A5A0 File Offset: 0x001487A0
	public bool Compare(FurnitureAreaData other)
	{
		if (this.AreaId != other.AreaId)
		{
			return false;
		}
		if (this.MapId != other.MapId)
		{
			return false;
		}
		if (this.Atmosphere != other.Atmosphere)
		{
			return false;
		}
		if (this.MaxAtmosphere != other.MaxAtmosphere)
		{
			return false;
		}
		if (this.SceneSlotDataMap.Count != other.SceneSlotDataMap.Count)
		{
			return false;
		}
		foreach (KeyValuePair<int, FurnitureSceneSlotData> keyValuePair in this.SceneSlotDataMap)
		{
			FurnitureSceneSlotData other2;
			if (!other.SceneSlotDataMap.TryGetValue(keyValuePair.Key, out other2))
			{
				return false;
			}
			if (!keyValuePair.Value.Compare(other2))
			{
				return false;
			}
		}
		if (this.FurnitureUseCountMap.Count != other.FurnitureUseCountMap.Count)
		{
			return false;
		}
		foreach (KeyValuePair<int, int> keyValuePair2 in this.FurnitureUseCountMap)
		{
			int num;
			if (!other.FurnitureUseCountMap.TryGetValue(keyValuePair2.Key, out num))
			{
				return false;
			}
			if (keyValuePair2.Value != num)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060038B9 RID: 14521 RVA: 0x0014A6FC File Offset: 0x001488FC
	public void SetAreaId(int areaId)
	{
		this.AreaId = areaId;
	}

	// Token: 0x060038BA RID: 14522 RVA: 0x0014A705 File Offset: 0x00148905
	public void SetMapId(int mapId)
	{
		this.MapId = mapId;
	}

	// Token: 0x060038BB RID: 14523 RVA: 0x0014A70E File Offset: 0x0014890E
	public void SetAtmosphere(int atmosphere)
	{
		this.Atmosphere = atmosphere;
	}

	// Token: 0x060038BC RID: 14524 RVA: 0x0014A717 File Offset: 0x00148917
	public void SetMaxAtmosphere(int maxAtmosphere)
	{
		this.MaxAtmosphere = maxAtmosphere;
	}

	// Token: 0x060038BD RID: 14525 RVA: 0x0014A720 File Offset: 0x00148920
	public FurnitureSceneSlotData CreateSceneSlotData(int slotEntityId)
	{
		FurnitureSceneSlotData furnitureSceneSlotData = new FurnitureSceneSlotData();
		furnitureSceneSlotData.SetSceneSlotData(this.MapId, slotEntityId);
		this.SceneSlotDataMap[slotEntityId] = furnitureSceneSlotData;
		return furnitureSceneSlotData;
	}

	// Token: 0x060038BE RID: 14526 RVA: 0x0014A750 File Offset: 0x00148950
	public void SetSlotPlacedData(int slotEntityId, int subSlotIndex, int furnitureConfigId)
	{
		FurnitureSceneSlotData sceneSlotData;
		if (!this.SceneSlotDataMap.TryGetValue(slotEntityId, out sceneSlotData))
		{
			return;
		}
		if (subSlotIndex == -1)
		{
			this.SetSceneSlotPlacedDataInternal(sceneSlotData, furnitureConfigId);
			return;
		}
		this.SetSubSlotPlacedDataInternal(sceneSlotData, subSlotIndex, furnitureConfigId);
	}

	// Token: 0x060038BF RID: 14527 RVA: 0x0014A784 File Offset: 0x00148984
	public void ClearSlotPlacedData()
	{
		this.FurnitureUseCountMap.Clear();
		foreach (FurnitureSceneSlotData furnitureSceneSlotData in this.SceneSlotDataMap.Values)
		{
			furnitureSceneSlotData.UnPlaceFurniture();
		}
		this.Atmosphere = 0;
	}

	// Token: 0x060038C0 RID: 14528 RVA: 0x0014A7EC File Offset: 0x001489EC
	private void SetSceneSlotPlacedDataInternal(FurnitureSceneSlotData sceneSlotData, int furnitureConfigId)
	{
		for (int i = 0; i < sceneSlotData.GetSubSlotDataListLength(); i++)
		{
			FurnitureSubSlotData subSlotData = sceneSlotData.GetSubSlotData(i);
			if (subSlotData != null)
			{
				this.ReduceFurnitureCount(subSlotData.GetPlacedFurnitureConfigId());
			}
		}
		this.UnPlaceFurnitureInternal(sceneSlotData);
		if (furnitureConfigId > 0)
		{
			this.PlaceFurnitureInternal(sceneSlotData, furnitureConfigId);
		}
	}

	// Token: 0x060038C1 RID: 14529 RVA: 0x0014A834 File Offset: 0x00148A34
	private void SetSubSlotPlacedDataInternal(FurnitureSceneSlotData sceneSlotData, int subSlotIndex, int furnitureConfigId)
	{
		FurnitureSubSlotData subSlotData = sceneSlotData.GetSubSlotData(subSlotIndex);
		if (subSlotData == null)
		{
			return;
		}
		this.UnPlaceFurnitureInternal(subSlotData);
		if (furnitureConfigId > 0)
		{
			this.PlaceFurnitureInternal(subSlotData, furnitureConfigId);
		}
	}

	// Token: 0x060038C2 RID: 14530 RVA: 0x0014A860 File Offset: 0x00148A60
	private void PlaceFurnitureInternal(FurnitureSlotDataBase slotData, int furnitureConfigId)
	{
		slotData.PlaceFurniture(furnitureConfigId);
		this.AddFurnitureCount(furnitureConfigId);
	}

	// Token: 0x060038C3 RID: 14531 RVA: 0x0014A870 File Offset: 0x00148A70
	private void UnPlaceFurnitureInternal(FurnitureSlotDataBase slotData)
	{
		this.ReduceFurnitureCount(slotData.GetPlacedFurnitureConfigId());
		slotData.UnPlaceFurniture();
	}

	// Token: 0x060038C4 RID: 14532 RVA: 0x0014A884 File Offset: 0x00148A84
	protected void AddFurnitureCount(int furnitureConfigId)
	{
		if (furnitureConfigId <= 0)
		{
			return;
		}
		int num;
		this.FurnitureUseCountMap.TryGetValue(furnitureConfigId, out num);
		this.FurnitureUseCountMap[furnitureConfigId] = num + 1;
	}

	// Token: 0x060038C5 RID: 14533 RVA: 0x0014A8B4 File Offset: 0x00148AB4
	protected void ReduceFurnitureCount(int furnitureConfigId)
	{
		if (furnitureConfigId <= 0)
		{
			return;
		}
		if (!this.FurnitureUseCountMap.ContainsKey(furnitureConfigId))
		{
			return;
		}
		int num2;
		int num = (this.FurnitureUseCountMap.TryGetValue(furnitureConfigId, out num2) ? num2 : 0) - 1;
		if (num <= 0)
		{
			this.FurnitureUseCountMap.Remove(furnitureConfigId);
			return;
		}
		this.FurnitureUseCountMap[furnitureConfigId] = num;
	}

	// Token: 0x060038C6 RID: 14534 RVA: 0x0014A90B File Offset: 0x00148B0B
	public int GetPlacedFurnitureConfigId(int slotEntityId, int subSlotIndex)
	{
		FurnitureSlotDataBase slotData = this.GetSlotData(slotEntityId, subSlotIndex);
		if (slotData == null)
		{
			return 0;
		}
		return slotData.GetPlacedFurnitureConfigId();
	}

	// Token: 0x060038C7 RID: 14535 RVA: 0x0014A920 File Offset: 0x00148B20
	[NullableContext(2)]
	public FurnitureSceneSlotData GetSceneSlotData(int slotEntityId)
	{
		FurnitureSceneSlotData result;
		if (!this.SceneSlotDataMap.TryGetValue(slotEntityId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x060038C8 RID: 14536 RVA: 0x0014A940 File Offset: 0x00148B40
	[NullableContext(2)]
	public FurnitureSlotDataBase GetSlotData(int slotEntityId, int subSlotIndex)
	{
		if (subSlotIndex == -1)
		{
			return this.GetSceneSlotData(slotEntityId);
		}
		FurnitureSceneSlotData sceneSlotData = this.GetSceneSlotData(slotEntityId);
		if (sceneSlotData == null)
		{
			return null;
		}
		return sceneSlotData.GetSubSlotData(subSlotIndex);
	}

	// Token: 0x060038C9 RID: 14537 RVA: 0x0014A961 File Offset: 0x00148B61
	public IReadOnlyDictionary<int, FurnitureSceneSlotData> GetSceneSlotDataMap()
	{
		return this.SceneSlotDataMap;
	}

	// Token: 0x060038CA RID: 14538 RVA: 0x0014A969 File Offset: 0x00148B69
	public int GetAreaId()
	{
		return this.AreaId;
	}

	// Token: 0x060038CB RID: 14539 RVA: 0x0014A971 File Offset: 0x00148B71
	public int GetMapId()
	{
		return this.MapId;
	}

	// Token: 0x060038CC RID: 14540 RVA: 0x0014A979 File Offset: 0x00148B79
	public int GetAtmosphere()
	{
		return this.Atmosphere;
	}

	// Token: 0x060038CD RID: 14541 RVA: 0x0014A981 File Offset: 0x00148B81
	public int GetMaxAtmosphere()
	{
		return this.MaxAtmosphere;
	}

	// Token: 0x060038CE RID: 14542 RVA: 0x0014A98C File Offset: 0x00148B8C
	public int GetFurnitureUseCount(int furnitureConfigId)
	{
		int result;
		if (!this.FurnitureUseCountMap.TryGetValue(furnitureConfigId, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x060038CF RID: 14543 RVA: 0x0014A9AC File Offset: 0x00148BAC
	public int GetPlacedSceneSlotCount()
	{
		int num = 0;
		using (Dictionary<int, FurnitureSceneSlotData>.ValueCollection.Enumerator enumerator = this.SceneSlotDataMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsPlaced())
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x060038D0 RID: 14544 RVA: 0x0014AA0C File Offset: 0x00148C0C
	public int GetPlacedSlotCount()
	{
		int num = 0;
		foreach (FurnitureSceneSlotData furnitureSceneSlotData in this.SceneSlotDataMap.Values)
		{
			if (furnitureSceneSlotData.IsPlaced())
			{
				num += 1 + this.GetPlacedSubSlotCount(furnitureSceneSlotData);
			}
		}
		return num;
	}

	// Token: 0x060038D1 RID: 14545 RVA: 0x0014AA74 File Offset: 0x00148C74
	public int GetPlacedSubSlotCount(FurnitureSceneSlotData sceneSlotData)
	{
		int num = 0;
		using (List<FurnitureSubSlotData>.Enumerator enumerator = sceneSlotData.GetSubSlotDataList().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsPlaced())
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x060038D2 RID: 14546 RVA: 0x0014AAD0 File Offset: 0x00148CD0
	public void UpdateAtmosphere()
	{
		int num = 0;
		foreach (KeyValuePair<int, int> keyValuePair in this.FurnitureUseCountMap)
		{
			Furniture? furnitureConfig = FurnitureConfig.Instance.GetFurnitureConfig(keyValuePair.Key);
			if (furnitureConfig != null)
			{
				num += furnitureConfig.Value.Atmosphere * keyValuePair.Value;
			}
		}
		this.Atmosphere = num;
	}

	// Token: 0x04002E95 RID: 11925
	private int AreaId;

	// Token: 0x04002E96 RID: 11926
	private int MapId;

	// Token: 0x04002E97 RID: 11927
	protected int Atmosphere;

	// Token: 0x04002E98 RID: 11928
	protected int MaxAtmosphere;

	// Token: 0x04002E99 RID: 11929
	protected Dictionary<int, FurnitureSceneSlotData> SceneSlotDataMap = new Dictionary<int, FurnitureSceneSlotData>();

	// Token: 0x04002E9A RID: 11930
	protected Dictionary<int, int> FurnitureUseCountMap = new Dictionary<int, int>();

	// Token: 0x04002E9B RID: 11931
	public bool UsePreset;
}
