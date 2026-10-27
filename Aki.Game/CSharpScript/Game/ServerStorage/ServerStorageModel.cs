using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.ServerStorage.Container;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.ServerStorage
{
	// Token: 0x02004583 RID: 17795
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ServerStorageModel : ModelBase
	{
		// Token: 0x0602DE97 RID: 188055 RVA: 0x00A8E4C4 File Offset: 0x00A8C6C4
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

		// Token: 0x0602DE98 RID: 188056 RVA: 0x00A8E568 File Offset: 0x00A8C768
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

		// Token: 0x0602DE99 RID: 188057 RVA: 0x00A8E614 File Offset: 0x00A8C814
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

		// Token: 0x0602DE9A RID: 188058 RVA: 0x00A8E63C File Offset: 0x00A8C83C
		public void MarkDirty(EClientStorageSystemIdType key)
		{
			this.DirtyCache.Add(key);
			if (this.DelayTimerHandle != null)
			{
				return;
			}
			this.DelayTimerHandle = TimerSystem.RealTimeInstance.Delay(new TTimerAction(this.DelaySaveDirtyCache), 3000f, null, null, true, 1f);
		}

		// Token: 0x0602DE9B RID: 188059 RVA: 0x00A8E688 File Offset: 0x00A8C888
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

		// Token: 0x0602DE9C RID: 188060 RVA: 0x00A8E6B4 File Offset: 0x00A8C8B4
		private void SaveDirtyCache()
		{
			if (this.DirtyCache.Count == 0)
			{
				return;
			}
			StorageInfoUpdateRequest storageInfoUpdateRequest = StorageInfoUpdateRequest.Create();
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
				}
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.ServerStorage;
			ELogAuthor author2 = ELogAuthor.BB;
			string message2 = "DelaySaveDirtyCache";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("storageInfo", storageInfoUpdateRequest.Infos);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			ServerStorageController.Instance.SendStorageInfoUpdateRequest(storageInfoUpdateRequest);
			this.DirtyCache.Clear();
		}

		// Token: 0x0602DE9D RID: 188061 RVA: 0x00A8E7B0 File Offset: 0x00A8C9B0
		private void DelaySaveDirtyCache(float delta)
		{
			this.SaveDirtyCache();
			this.DelayTimerHandle = null;
		}

		// Token: 0x17007596 RID: 30102
		// (get) Token: 0x0602DE9E RID: 188062 RVA: 0x00A8E7BF File Offset: 0x00A8C9BF
		public static ServerStorageModel Instance
		{
			get
			{
				return ServerStorageModel._Instance;
			}
		}

		// Token: 0x0602DE9F RID: 188063 RVA: 0x00A8E7C6 File Offset: 0x00A8C9C6
		public static ServerStorageModel GetOrCreateInstance()
		{
			if (ServerStorageModel._Instance == null)
			{
				ServerStorageModel.CreateInstance();
			}
			return ServerStorageModel._Instance;
		}

		// Token: 0x0602DEA0 RID: 188064 RVA: 0x00A8E7DA File Offset: 0x00A8C9DA
		public static bool CreateInstance()
		{
			if (ServerStorageModel._Instance != null)
			{
				return true;
			}
			ServerStorageModel._Instance = new ServerStorageModel();
			return true;
		}

		// Token: 0x0602DEA1 RID: 188065 RVA: 0x00A8E7F0 File Offset: 0x00A8C9F0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DEA2 RID: 188066 RVA: 0x00A8E7F2 File Offset: 0x00A8C9F2
		public static void ResetStaticDefaultValue()
		{
			ServerStorageModel._Instance = null;
		}

		// Token: 0x0602DEA3 RID: 188067 RVA: 0x00A8E7FA File Offset: 0x00A8C9FA
		static ServerStorageModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ServerStorageModel.CreateStaticDefaultValue), new Action(ServerStorageModel.ResetStaticDefaultValue));
		}

		// Token: 0x04018844 RID: 100420
		private readonly Dictionary<EClientStorageSystemIdType, ServerStorageEntryBase> Cache = new Dictionary<EClientStorageSystemIdType, ServerStorageEntryBase>();

		// Token: 0x04018845 RID: 100421
		private readonly HashSet<EClientStorageSystemIdType> DirtyCache = new HashSet<EClientStorageSystemIdType>();

		// Token: 0x04018846 RID: 100422
		[Nullable(2)]
		private TimerHandle DelayTimerHandle;

		// Token: 0x04018847 RID: 100423
		[Nullable(2)]
		private static ServerStorageModel _Instance;
	}
}
