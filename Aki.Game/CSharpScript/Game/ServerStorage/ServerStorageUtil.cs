using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.ServerStorage.Container;
using UnrealEngine;

namespace CSharpScript.Game.ServerStorage
{
	// Token: 0x020034AC RID: 13484
	public class ServerStorageUtil
	{
		// Token: 0x0602258A RID: 140682 RVA: 0x009BA4AC File Offset: 0x009B86AC
		[NullableContext(1)]
		public static ClientStorageInfo CreateDefaultStorageInfo(int key)
		{
			ClientStorageInfo clientStorageInfo = ClientStorageInfo.Create();
			clientStorageInfo.SystemId = key;
			clientStorageInfo.MapMapData = null;
			clientStorageInfo.MapListData = null;
			clientStorageInfo.MapData = null;
			clientStorageInfo.ListData = null;
			clientStorageInfo.SetData = null;
			clientStorageInfo.BoolData = null;
			clientStorageInfo.IntData = null;
			clientStorageInfo.LongData = null;
			clientStorageInfo.StringData = null;
			return clientStorageInfo;
		}

		// Token: 0x0602258B RID: 140683 RVA: 0x009BA504 File Offset: 0x009B8704
		public unsafe static bool OverrideLocalNumberToServerNumber(ELocalStoragePlayerKey localKey, EClientStorageSystemIdType serverKey, bool deleteLocal = true)
		{
			ServerStorageEntryBase serverStorageEntryBase = ServerStorageModel.Instance.Get(serverKey);
			if (!(serverStorageEntryBase is ServerStorageNumber))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorage number type mismatch";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("serverKey", serverKey);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", serverStorageEntryBase);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			ServerStorageNumber serverStorageNumber = (ServerStorageNumber)serverStorageEntryBase;
			if (serverStorageNumber.Get() != null)
			{
				return false;
			}
			int? player = LocalStorage.GetPlayer<int?>(localKey, null);
			if (player == null)
			{
				return false;
			}
			serverStorageNumber.Set(player);
			if (deleteLocal)
			{
				ServerStorageModel.Instance.RegisterPendingLocalDelete(serverKey, localKey);
			}
			return true;
		}

		// Token: 0x0602258C RID: 140684 RVA: 0x009BA5D0 File Offset: 0x009B87D0
		public unsafe static bool OverrideLocalNumberToServerLong(ELocalStoragePlayerKey localKey, EClientStorageSystemIdType serverKey, bool deleteLocal = true)
		{
			ServerStorageEntryBase serverStorageEntryBase = ServerStorageModel.Instance.Get(serverKey);
			if (!(serverStorageEntryBase is ServerStorageLong))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorage long type mismatch";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("serverKey", serverKey);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", serverStorageEntryBase);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			ServerStorageLong serverStorageLong = (ServerStorageLong)serverStorageEntryBase;
			if (serverStorageLong.Get() != null)
			{
				return false;
			}
			long? player = LocalStorage.GetPlayer<long?>(localKey, null);
			if (player == null)
			{
				return false;
			}
			serverStorageLong.Set(player);
			if (deleteLocal)
			{
				ServerStorageModel.Instance.RegisterPendingLocalDelete(serverKey, localKey);
			}
			return true;
		}

		// Token: 0x0602258D RID: 140685 RVA: 0x009BA69C File Offset: 0x009B889C
		public unsafe static bool OverrideLocalDoubleToServerLong(ELocalStoragePlayerKey localKey, EClientStorageSystemIdType serverKey, bool deleteLocal = true)
		{
			ServerStorageEntryBase serverStorageEntryBase = ServerStorageModel.Instance.Get(serverKey);
			if (!(serverStorageEntryBase is ServerStorageLong))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorage long type mismatch";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("serverKey", serverKey);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", serverStorageEntryBase);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			ServerStorageLong serverStorageLong = (ServerStorageLong)serverStorageEntryBase;
			if (serverStorageLong.Get() != null)
			{
				return false;
			}
			double? player = LocalStorage.GetPlayer<double?>(localKey, null);
			if (player == null)
			{
				return false;
			}
			serverStorageLong.Set(new long?((long)player.Value));
			if (deleteLocal)
			{
				ServerStorageModel.Instance.RegisterPendingLocalDelete(serverKey, localKey);
			}
			return true;
		}

		// Token: 0x0602258E RID: 140686 RVA: 0x009BA774 File Offset: 0x009B8974
		public unsafe static bool OverrideLocalStringToServerString(ELocalStoragePlayerKey localKey, EClientStorageSystemIdType serverKey, bool deleteLocal = true)
		{
			ServerStorageEntryBase serverStorageEntryBase = ServerStorageModel.Instance.Get(serverKey);
			if (!(serverStorageEntryBase is ServerStorageString))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorage string type mismatch";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("serverKey", serverKey);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", serverStorageEntryBase);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			ServerStorageString serverStorageString = (ServerStorageString)serverStorageEntryBase;
			if (serverStorageString.Get() != null)
			{
				return false;
			}
			string player = LocalStorage.GetPlayer<string>(localKey, null);
			if (player == null)
			{
				return false;
			}
			serverStorageString.Set(player);
			if (deleteLocal)
			{
				ServerStorageModel.Instance.RegisterPendingLocalDelete(serverKey, localKey);
			}
			return true;
		}

		// Token: 0x0602258F RID: 140687 RVA: 0x009BA828 File Offset: 0x009B8A28
		public unsafe static bool OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey localKey, EClientStorageSystemIdType serverKey, bool deleteLocal = true)
		{
			ServerStorageEntryBase serverStorageEntryBase = ServerStorageModel.Instance.Get(serverKey);
			if (!(serverStorageEntryBase is ServerStorageBoolean))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorage boolean type mismatch";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("serverKey", serverKey);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", serverStorageEntryBase);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			ServerStorageBoolean serverStorageBoolean = (ServerStorageBoolean)serverStorageEntryBase;
			if (serverStorageBoolean.Get() != null)
			{
				return false;
			}
			bool? player = LocalStorage.GetPlayer<bool?>(localKey, null);
			if (player == null)
			{
				return false;
			}
			serverStorageBoolean.Set(player);
			if (deleteLocal)
			{
				ServerStorageModel.Instance.RegisterPendingLocalDelete(serverKey, localKey);
			}
			return true;
		}

		// Token: 0x06022590 RID: 140688 RVA: 0x009BA8F4 File Offset: 0x009B8AF4
		public unsafe static bool OverrideLocalListToServerSet(ELocalStoragePlayerKey localKey, EClientStorageSystemIdType serverKey, bool deleteLocal = true)
		{
			if (deleteLocal && ServerStorageModel.Instance.HasPendingLocalDelete(serverKey, localKey))
			{
				return false;
			}
			List<int> player = LocalStorage.GetPlayer<List<int>>(localKey, null);
			if (player == null)
			{
				return false;
			}
			ServerStorageEntryBase serverStorageEntryBase = ServerStorageModel.Instance.Get(serverKey);
			if (!(serverStorageEntryBase is ServerStorageSet))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorage set type mismatch";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("serverKey", serverKey);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", serverStorageEntryBase);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			ServerStorageSet serverStorageSet = (ServerStorageSet)serverStorageEntryBase;
			foreach (int value in player)
			{
				if (!serverStorageSet.Has(value))
				{
					serverStorageSet.Add(value);
				}
			}
			if (deleteLocal)
			{
				ServerStorageModel.Instance.RegisterPendingLocalDelete(serverKey, localKey);
			}
			return true;
		}

		// Token: 0x06022591 RID: 140689 RVA: 0x009BA9F8 File Offset: 0x009B8BF8
		public unsafe static bool OverrideLocalSetToServerSet(ELocalStoragePlayerKey localKey, EClientStorageSystemIdType serverKey, bool deleteLocal = true)
		{
			if (deleteLocal && ServerStorageModel.Instance.HasPendingLocalDelete(serverKey, localKey))
			{
				return false;
			}
			HashSet<int> player = LocalStorage.GetPlayer<HashSet<int>>(localKey, null);
			if (player == null)
			{
				return false;
			}
			ServerStorageEntryBase serverStorageEntryBase = ServerStorageModel.Instance.Get(serverKey);
			if (!(serverStorageEntryBase is ServerStorageSet))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorage set type mismatch";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("serverKey", serverKey);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", serverStorageEntryBase);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			ServerStorageSet serverStorageSet = (ServerStorageSet)serverStorageEntryBase;
			foreach (int value in player)
			{
				if (!serverStorageSet.Has(value))
				{
					serverStorageSet.Add(value);
				}
			}
			if (deleteLocal)
			{
				ServerStorageModel.Instance.RegisterPendingLocalDelete(serverKey, localKey);
			}
			return true;
		}

		// Token: 0x06022592 RID: 140690 RVA: 0x009BAAFC File Offset: 0x009B8CFC
		public unsafe static bool OverrideLocalStringMapToServerHashMap(ELocalStoragePlayerKey localKey, EClientStorageSystemIdType serverKey, bool deleteLocal = true)
		{
			Dictionary<int, string> player = LocalStorage.GetPlayer<Dictionary<int, string>>(localKey, null);
			if (player == null)
			{
				return false;
			}
			ServerStorageEntryBase serverStorageEntryBase = ServerStorageModel.Instance.Get(serverKey);
			if (!(serverStorageEntryBase is ServerStorageMap))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorage map type mismatch";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("serverKey", serverKey);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", serverStorageEntryBase);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			ServerStorageMap serverStorageMap = (ServerStorageMap)serverStorageEntryBase;
			foreach (KeyValuePair<int, string> keyValuePair in player)
			{
				int num;
				string text;
				keyValuePair.Deconstruct(out num, out text);
				int key = num;
				string str = text;
				if (!serverStorageMap.Has(key))
				{
					serverStorageMap.Set(key, UGASBPLibrary.FnvHash(str));
				}
			}
			if (deleteLocal)
			{
				ServerStorageModel.Instance.RegisterPendingLocalDelete(serverKey, localKey);
			}
			return true;
		}

		// Token: 0x06022593 RID: 140691 RVA: 0x009BAC08 File Offset: 0x009B8E08
		public unsafe static bool OverrideLocalMapToServerMap(ELocalStoragePlayerKey localKey, EClientStorageSystemIdType serverKey, bool deleteLocal = true)
		{
			Dictionary<int, int> player = LocalStorage.GetPlayer<Dictionary<int, int>>(localKey, null);
			if (player == null)
			{
				return false;
			}
			ServerStorageEntryBase serverStorageEntryBase = ServerStorageModel.Instance.Get(serverKey);
			if (!(serverStorageEntryBase is ServerStorageMap))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorage map type mismatch";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("serverKey", serverKey);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", serverStorageEntryBase);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			ServerStorageMap serverStorageMap = (ServerStorageMap)serverStorageEntryBase;
			foreach (KeyValuePair<int, int> keyValuePair in player)
			{
				int num;
				int num2;
				keyValuePair.Deconstruct(out num, out num2);
				int key = num;
				int value = num2;
				if (!serverStorageMap.Has(key))
				{
					serverStorageMap.Set(key, value);
				}
			}
			if (deleteLocal)
			{
				ServerStorageModel.Instance.RegisterPendingLocalDelete(serverKey, localKey);
			}
			return true;
		}

		// Token: 0x06022594 RID: 140692 RVA: 0x009BAD10 File Offset: 0x009B8F10
		public unsafe static bool OverrideLocalBoolMapToServerSet(ELocalStoragePlayerKey localKey, EClientStorageSystemIdType serverKey, bool deleteLocal = true)
		{
			Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(localKey, null);
			if (player == null)
			{
				return false;
			}
			ServerStorageEntryBase serverStorageEntryBase = ServerStorageModel.Instance.Get(serverKey);
			if (!(serverStorageEntryBase is ServerStorageSet))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorage set type mismatch";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("serverKey", serverKey);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", serverStorageEntryBase);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			ServerStorageSet serverStorageSet = (ServerStorageSet)serverStorageEntryBase;
			foreach (KeyValuePair<int, bool> keyValuePair in player)
			{
				int num;
				bool flag;
				keyValuePair.Deconstruct(out num, out flag);
				int value = num;
				if (flag && !serverStorageSet.Has(value))
				{
					serverStorageSet.Add(value);
				}
			}
			if (deleteLocal)
			{
				ServerStorageModel.Instance.RegisterPendingLocalDelete(serverKey, localKey);
			}
			return true;
		}

		// Token: 0x06022595 RID: 140693 RVA: 0x009BAE14 File Offset: 0x009B9014
		public unsafe static bool OverrideLocalMapListToServerMapSet(ELocalStoragePlayerKey localKey, EClientStorageSystemIdType serverKey, bool deleteLocal = true)
		{
			Dictionary<int, List<int>> player = LocalStorage.GetPlayer<Dictionary<int, List<int>>>(localKey, null);
			if (player == null)
			{
				return false;
			}
			ServerStorageEntryBase serverStorageEntryBase = ServerStorageModel.Instance.Get(serverKey);
			if (!(serverStorageEntryBase is ServerStorageMapSet))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ServerStorage;
				ELogAuthor author = ELogAuthor.BB;
				string message = "ServerStorage map-set type mismatch";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("serverKey", serverKey);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", serverStorageEntryBase);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			ServerStorageMapSet serverStorageMapSet = (ServerStorageMapSet)serverStorageEntryBase;
			foreach (KeyValuePair<int, List<int>> keyValuePair in player)
			{
				int num;
				List<int> list;
				keyValuePair.Deconstruct(out num, out list);
				int key = num;
				foreach (int value in list)
				{
					if (!serverStorageMapSet.Has(key, value))
					{
						serverStorageMapSet.Add(key, value);
					}
				}
			}
			if (deleteLocal)
			{
				ServerStorageModel.Instance.RegisterPendingLocalDelete(serverKey, localKey);
			}
			return true;
		}
	}
}
