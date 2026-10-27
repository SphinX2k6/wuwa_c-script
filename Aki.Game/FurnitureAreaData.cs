using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000F71 RID: 3953
[NullableContext(1)]
[Nullable(0)]
public class FurnitureAreaData
{
	// Token: 0x0600651F RID: 25887 RVA: 0x00141BF4 File Offset: 0x0013FDF4
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

	// Token: 0x06006520 RID: 25888 RVA: 0x00141D04 File Offset: 0x0013FF04
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

	// Token: 0x06006521 RID: 25889 RVA: 0x00141E60 File Offset: 0x00140060
	public void SetAreaId(int areaId)
	{
		this.AreaId = areaId;
	}

	// Token: 0x06006522 RID: 25890 RVA: 0x00141E69 File Offset: 0x00140069
	public void SetMapId(int mapId)
	{
		this.MapId = mapId;
	}

	// Token: 0x06006523 RID: 25891 RVA: 0x00141E72 File Offset: 0x00140072
	public void SetAtmosphere(int atmosphere)
	{
		this.Atmosphere = atmosphere;
	}

	// Token: 0x06006524 RID: 25892 RVA: 0x00141E7B File Offset: 0x0014007B
	public void SetMaxAtmosphere(int maxAtmosphere)
	{
		this.MaxAtmosphere = maxAtmosphere;
	}

	// Token: 0x06006525 RID: 25893 RVA: 0x00141E84 File Offset: 0x00140084
	public FurnitureSceneSlotData CreateSceneSlotData(int slotEntityId)
	{
		FurnitureSceneSlotData furnitureSceneSlotData = new FurnitureSceneSlotData();
		furnitureSceneSlotData.SetSceneSlotData(this.MapId, slotEntityId);
		this.SceneSlotDataMap[slotEntityId] = furnitureSceneSlotData;
		return furnitureSceneSlotData;
	}

	// Token: 0x06006526 RID: 25894 RVA: 0x00141EB4 File Offset: 0x001400B4
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

	// Token: 0x06006527 RID: 25895 RVA: 0x00141EE8 File Offset: 0x001400E8
	public void ClearSlotPlacedData()
	{
		this.FurnitureUseCountMap.Clear();
		foreach (FurnitureSceneSlotData furnitureSceneSlotData in this.SceneSlotDataMap.Values)
		{
			furnitureSceneSlotData.UnPlaceFurniture();
		}
		this.Atmosphere = 0;
	}

	// Token: 0x06006528 RID: 25896 RVA: 0x00141F50 File Offset: 0x00140150
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

	// Token: 0x06006529 RID: 25897 RVA: 0x00141F98 File Offset: 0x00140198
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

	// Token: 0x0600652A RID: 25898 RVA: 0x00141FC4 File Offset: 0x001401C4
	private void PlaceFurnitureInternal(FurnitureSlotDataBase slotData, int furnitureConfigId)
	{
		slotData.PlaceFurniture(furnitureConfigId);
		this.AddFurnitureCount(furnitureConfigId);
	}

	// Token: 0x0600652B RID: 25899 RVA: 0x00141FD4 File Offset: 0x001401D4
	private void UnPlaceFurnitureInternal(FurnitureSlotDataBase slotData)
	{
		this.ReduceFurnitureCount(slotData.GetPlacedFurnitureConfigId());
		slotData.UnPlaceFurniture();
	}

	// Token: 0x0600652C RID: 25900 RVA: 0x00141FE8 File Offset: 0x001401E8
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

	// Token: 0x0600652D RID: 25901 RVA: 0x00142018 File Offset: 0x00140218
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

	// Token: 0x0600652E RID: 25902 RVA: 0x0014206F File Offset: 0x0014026F
	public int GetPlacedFurnitureConfigId(int slotEntityId, int subSlotIndex)
	{
		FurnitureSlotDataBase slotData = this.GetSlotData(slotEntityId, subSlotIndex);
		if (slotData == null)
		{
			return 0;
		}
		return slotData.GetPlacedFurnitureConfigId();
	}

	// Token: 0x0600652F RID: 25903 RVA: 0x00142084 File Offset: 0x00140284
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

	// Token: 0x06006530 RID: 25904 RVA: 0x001420A4 File Offset: 0x001402A4
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

	// Token: 0x06006531 RID: 25905 RVA: 0x001420C5 File Offset: 0x001402C5
	public IReadOnlyDictionary<int, FurnitureSceneSlotData> GetSceneSlotDataMap()
	{
		return this.SceneSlotDataMap;
	}

	// Token: 0x06006532 RID: 25906 RVA: 0x001420CD File Offset: 0x001402CD
	public int GetAreaId()
	{
		return this.AreaId;
	}

	// Token: 0x06006533 RID: 25907 RVA: 0x001420D5 File Offset: 0x001402D5
	public int GetMapId()
	{
		return this.MapId;
	}

	// Token: 0x06006534 RID: 25908 RVA: 0x001420DD File Offset: 0x001402DD
	public int GetAtmosphere()
	{
		return this.Atmosphere;
	}

	// Token: 0x06006535 RID: 25909 RVA: 0x001420E5 File Offset: 0x001402E5
	public int GetMaxAtmosphere()
	{
		return this.MaxAtmosphere;
	}

	// Token: 0x06006536 RID: 25910 RVA: 0x001420F0 File Offset: 0x001402F0
	public int GetFurnitureUseCount(int furnitureConfigId)
	{
		int result;
		if (!this.FurnitureUseCountMap.TryGetValue(furnitureConfigId, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x06006537 RID: 25911 RVA: 0x00142110 File Offset: 0x00140310
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

	// Token: 0x06006538 RID: 25912 RVA: 0x00142170 File Offset: 0x00140370
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

	// Token: 0x06006539 RID: 25913 RVA: 0x001421D8 File Offset: 0x001403D8
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

	// Token: 0x0600653A RID: 25914 RVA: 0x00142234 File Offset: 0x00140434
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

	// Token: 0x04002DFC RID: 11772
	private int AreaId;

	// Token: 0x04002DFD RID: 11773
	private int MapId;

	// Token: 0x04002DFE RID: 11774
	protected int Atmosphere;

	// Token: 0x04002DFF RID: 11775
	protected int MaxAtmosphere;

	// Token: 0x04002E00 RID: 11776
	protected Dictionary<int, FurnitureSceneSlotData> SceneSlotDataMap = new Dictionary<int, FurnitureSceneSlotData>();

	// Token: 0x04002E01 RID: 11777
	protected Dictionary<int, int> FurnitureUseCountMap = new Dictionary<int, int>();

	// Token: 0x04002E02 RID: 11778
	public bool UsePreset;
}
