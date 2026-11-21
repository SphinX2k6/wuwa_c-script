using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.ServerStorage.Container;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.ServerStorage
{
	// Token: 0x020034AB RID: 13483
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ServerStorageModel : ModelBase
	{
		// Token: 0x06022579 RID: 140665 RVA: 0x009BA04C File Offset: 0x009B824C
		public void RegisterPendingLocalDelete(EClientStorageSystemIdType serverKey, ELocalStoragePlayerKey localKey)
		{
			List<ELocalStoragePlayerKey> list;
			if (!this.PendingLocalDeletes.TryGetValue(serverKey, out list))
			{
				list = new List<ELocalStoragePlayerKey>();
				this.PendingLocalDeletes[serverKey] = list;
			}
			if (!list.Contains(localKey))
			{
				list.Add(localKey);
			}
			this.MarkDirty(serverKey);
		}

		// Token: 0x0602257A RID: 140666 RVA: 0x009BA094 File Offset: 0x009B8294
		public bool HasPendingLocalDelete(EClientStorageSystemIdType serverKey, ELocalStoragePlayerKey localKey)
		{
			List<ELocalStoragePlayerKey> list;
			return this.PendingLocalDeletes.TryGetValue(serverKey, out list) && list.Contains(localKey);
		}

		// Token: 0x0602257B RID: 140667 RVA: 0x009BA0BA File Offset: 0x009B82BA
		public void RemovePendingLocalDelete(EClientStorageSystemIdType serverKey)
		{
			this.PendingLocalDeletes.Remove(serverKey);
		}

		// Token: 0x0602257C RID: 140668 RVA: 0x009BA0CC File Offset: 0x009B82CC
		[NullableContext(2)]
		private ServerStorageEntryBase CreateContainer(EClientStorageSystemIdType key)
		{
			ServerStorageEntryBase result;
			if (this.Cache.TryGetValue(key, out result))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "Container is already created";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", key);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return result;
			}
			Func<EClientStorageSystemIdType, ServerStorageEntryBase> func;
			if (!ServerStorageDefine.ServerStorageEntryRegistry.TryGetValue(key, out func))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.ServerStorage;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "Container ctor not found";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("key", key);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return null;
			}
			ServerStorageEntryBase serverStorageEntryBase = func(key);
			this.Cache[key] = serverStorageEntryBase;
			return serverStorageEntryBase;
		}

		// Token: 0x0602257D RID: 140669 RVA: 0x009BA170 File Offset: 0x009B8370
		public void InitStorageInfo(RepeatedField<ClientStorageInfo> storageInfoList)
		{
			this.Cache.Clear();
			foreach (ClientStorageInfo clientStorageInfo in storageInfoList)
			{
				ServerStorageEntryBase serverStorageEntryBase = this.Get((EClientStorageSystemIdType)clientStorageInfo.SystemId);
				if (serverStorageEntryBase == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.ServerStorage;
					ELogAuthor author = ELogAuthor.BB;
					string message = "Container is undefined";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", clientStorageInfo.SystemId);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					serverStorageEntryBase.Serialize(clientStorageInfo);
					this.Cache[(EClientStorageSystemIdType)clientStorageInfo.SystemId] = serverStorageEntryBase;
				}
			}
		}

		// Token: 0x0602257E RID: 140670 RVA: 0x009BA21C File Offset: 0x009B841C
		[NullableContext(2)]
		public ServerStorageEntryBase Get(EClientStorageSystemIdType key)
		{
			ServerStorageEntryBase result;
			if (this.Cache.TryGetValue(key, out result))
			{
				return result;
			}
			return this.CreateContainer(key);
		}

		// Token: 0x0602257F RID: 140671 RVA: 0x009BA244 File Offset: 0x009B8444
		public void MarkDirty(EClientStorageSystemIdType key)
		{
			this.DirtyCache.Add(key);
			if (this.DelayTimerHandle != null)
			{
				return;
			}
			this.DelayTimerHandle = TimerSystem.RealTimeInstance.Delay(new TTimerAction(this.DelaySaveDirtyCache), 3000f, null, null, true, 1f);
		}

		// Token: 0x06022580 RID: 140672 RVA: 0x009BA290 File Offset: 0x009B8490
		protected override bool OnClear()
		{
			if (this.DelayTimerHandle == null)
			{
				return true;
			}
			TimerSystem.RealTimeInstance.Remove(this.DelayTimerHandle);
			this.SaveDirtyCache();
			this.DelayTimerHandle = null;
			return true;
		}

		// Token: 0x06022581 RID: 140673 RVA: 0x009BA2BC File Offset: 0x009B84BC
		private void SaveDirtyCache()
		{
			if (this.DirtyCache.Count == 0)
			{
				return;
			}
			StorageInfoUpdateRequest storageInfoUpdateRequest = StorageInfoUpdateRequest.Create();
			List<ELocalStoragePlayerKey> localKeysToDelete = new List<ELocalStoragePlayerKey>();
			List<EClientStorageSystemIdType> serverKeysToDelete = new List<EClientStorageSystemIdType>();
			foreach (EClientStorageSystemIdType eclientStorageSystemIdType in this.DirtyCache)
			{
				ClientStorageInfo clientStorageInfo = ServerStorageModel.Instance.Get(eclientStorageSystemIdType).Deserialize();
				if (clientStorageInfo == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.ServerStorage;
					ELogAuthor author = ELogAuthor.BB;
					string message = "Deserialize Info is undefined";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", eclientStorageSystemIdType);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					storageInfoUpdateRequest.Infos.Add(clientStorageInfo);
					List<ELocalStoragePlayerKey> collection;
					if (this.PendingLocalDeletes.TryGetValue(eclientStorageSystemIdType, out collection))
					{
						localKeysToDelete.AddRange(collection);
						serverKeysToDelete.Add(eclientStorageSystemIdType);
					}
				}
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.ServerStorage;
			ELogAuthor author2 = ELogAuthor.BB;
			string message2 = "DelaySaveDirtyCache";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("storageInfo", storageInfoUpdateRequest.Infos);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			ServerStorageController.Instance.SendStorageInfoUpdateRequest(storageInfoUpdateRequest, delegate(bool success)
			{
				if (!success)
				{
					foreach (EClientStorageSystemIdType serverKey in serverKeysToDelete)
					{
						this.RemovePendingLocalDelete(serverKey);
					}
					return;
				}
				foreach (ELocalStoragePlayerKey key in localKeysToDelete)
				{
					LocalStorage.DeletePlayer(key);
				}
				foreach (EClientStorageSystemIdType key2 in serverKeysToDelete)
				{
					this.PendingLocalDeletes.Remove(key2);
				}
			});
			this.DirtyCache.Clear();
		}

		// Token: 0x06022582 RID: 140674 RVA: 0x009BA418 File Offset: 0x009B8618
		private void DelaySaveDirtyCache(float delta)
		{
			this.SaveDirtyCache();
			this.DelayTimerHandle = null;
		}

		// Token: 0x1700484D RID: 18509
		// (get) Token: 0x06022583 RID: 140675 RVA: 0x009BA427 File Offset: 0x009B8627
		public static ServerStorageModel Instance
		{
			get
			{
				return ServerStorageModel._Instance;
			}
		}

		// Token: 0x06022584 RID: 140676 RVA: 0x009BA42E File Offset: 0x009B862E
		public static ServerStorageModel GetOrCreateInstance()
		{
			if (ServerStorageModel._Instance == null)
			{
				ServerStorageModel.CreateInstance();
			}
			return ServerStorageModel._Instance;
		}

		// Token: 0x06022585 RID: 140677 RVA: 0x009BA442 File Offset: 0x009B8642
		public static bool CreateInstance()
		{
			if (ServerStorageModel._Instance != null)
			{
				return true;
			}
			ServerStorageModel._Instance = new ServerStorageModel();
			return true;
		}

		// Token: 0x06022586 RID: 140678 RVA: 0x009BA458 File Offset: 0x009B8658
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06022587 RID: 140679 RVA: 0x009BA45A File Offset: 0x009B865A
		public static void ResetStaticDefaultValue()
		{
			ServerStorageModel._Instance = null;
		}

		// Token: 0x06022588 RID: 140680 RVA: 0x009BA462 File Offset: 0x009B8662
		static ServerStorageModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ServerStorageModel.CreateStaticDefaultValue), new Action(ServerStorageModel.ResetStaticDefaultValue));
		}

		// Token: 0x04012E7E RID: 77438
		private readonly Dictionary<EClientStorageSystemIdType, ServerStorageEntryBase> Cache = new Dictionary<EClientStorageSystemIdType, ServerStorageEntryBase>();

		// Token: 0x04012E7F RID: 77439
		private readonly HashSet<EClientStorageSystemIdType> DirtyCache = new HashSet<EClientStorageSystemIdType>();

		// Token: 0x04012E80 RID: 77440
		[Nullable(2)]
		private TimerHandle DelayTimerHandle;

		// Token: 0x04012E81 RID: 77441
		private readonly Dictionary<EClientStorageSystemIdType, List<ELocalStoragePlayerKey>> PendingLocalDeletes = new Dictionary<EClientStorageSystemIdType, List<ELocalStoragePlayerKey>>();

		// Token: 0x04012E82 RID: 77442
		[Nullable(2)]
		private static ServerStorageModel _Instance;
	}
}
