using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.World.Define
{
	// Token: 0x02003458 RID: 13400
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientEntityContainer
	{
		// Token: 0x060222EA RID: 140010 RVA: 0x009AE458 File Offset: 0x009AC658
		public bool AddClientEntity(int pbDataId, EClientEntityFlag flag)
		{
			if (this.ClientEntityMap.ContainsKey(pbDataId))
			{
				return false;
			}
			ClientEntityInfo clientEntityInfo = new ClientEntityInfo();
			clientEntityInfo.ClientEntityFlag = flag;
			clientEntityInfo.CreatureDataId = 0L;
			clientEntityInfo.PbDataId = pbDataId;
			this.ClientEntityMap[pbDataId] = clientEntityInfo;
			return true;
		}

		// Token: 0x060222EB RID: 140011 RVA: 0x009AE4A0 File Offset: 0x009AC6A0
		[NullableContext(2)]
		public ClientEntityInfo GetClientEntityInfo(int pbDataId)
		{
			ClientEntityInfo result;
			this.ClientEntityMap.TryGetValue(pbDataId, out result);
			return result;
		}

		// Token: 0x060222EC RID: 140012 RVA: 0x009AE4BD File Offset: 0x009AC6BD
		public Dictionary<int, ClientEntityInfo> GetAllClientEntityInfos()
		{
			return this.ClientEntityMap;
		}

		// Token: 0x060222ED RID: 140013 RVA: 0x009AE4C5 File Offset: 0x009AC6C5
		public bool HasClientEntity(int pbDataId)
		{
			return this.ClientEntityMap.ContainsKey(pbDataId);
		}

		// Token: 0x060222EE RID: 140014 RVA: 0x009AE4D3 File Offset: 0x009AC6D3
		public bool RemoveClientEntity(int pbDataId)
		{
			return this.ClientEntityMap.Remove(pbDataId);
		}

		// Token: 0x060222EF RID: 140015 RVA: 0x009AE4E4 File Offset: 0x009AC6E4
		public bool CacheClientEntity(int pbDataId)
		{
			ClientEntityInfo clientEntityInfo;
			if (!this.ClientEntityMap.Remove(pbDataId, out clientEntityInfo))
			{
				return false;
			}
			clientEntityInfo.ClientEntityFlag = EClientEntityFlag.None;
			clientEntityInfo.CreatureDataId = 0L;
			clientEntityInfo.EntityId = 0;
			this.CachedClientEntityMap[pbDataId] = clientEntityInfo;
			return true;
		}

		// Token: 0x060222F0 RID: 140016 RVA: 0x009AE527 File Offset: 0x009AC727
		public bool RemoveCachedClientEntity(int pbDataId)
		{
			return this.CachedClientEntityMap.Remove(pbDataId);
		}

		// Token: 0x060222F1 RID: 140017 RVA: 0x009AE538 File Offset: 0x009AC738
		public List<int> RestoreCachedClientEntities(EClientEntityFlag flag)
		{
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, ClientEntityInfo> keyValuePair in this.CachedClientEntityMap)
			{
				if (!this.ClientEntityMap.ContainsKey(keyValuePair.Key))
				{
					ClientEntityInfo value = keyValuePair.Value;
					value.ClientEntityFlag = flag;
					value.CreatureDataId = 0L;
					value.EntityId = 0;
					this.ClientEntityMap[keyValuePair.Key] = value;
					list.Add(keyValuePair.Key);
				}
			}
			this.CachedClientEntityMap.Clear();
			return list;
		}

		// Token: 0x060222F2 RID: 140018 RVA: 0x009AE5E8 File Offset: 0x009AC7E8
		public void ClearCachedClientEntities()
		{
			this.CachedClientEntityMap.Clear();
		}

		// Token: 0x04012D05 RID: 77061
		private readonly Dictionary<int, ClientEntityInfo> ClientEntityMap = new Dictionary<int, ClientEntityInfo>();

		// Token: 0x04012D06 RID: 77062
		private readonly Dictionary<int, ClientEntityInfo> CachedClientEntityMap = new Dictionary<int, ClientEntityInfo>();
	}
}
