using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.ServerStorage.Container;

namespace CSharpScript.Game.ServerStorage
{
	// Token: 0x02004584 RID: 17796
	public class ServerStorageUtil
	{
		// Token: 0x0602DEA5 RID: 188069 RVA: 0x00A8E838 File Offset: 0x00A8CA38
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

		// Token: 0x0602DEA6 RID: 188070 RVA: 0x00A8E890 File Offset: 0x00A8CA90
		public unsafe static bool OverrideLocalNumberToServerNumber(ELocalStoragePlayerKey localKey, EClientStorageSystemIdType serverKey)
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
			return true;
		}

		// Token: 0x0602DEA7 RID: 188071 RVA: 0x00A8E94C File Offset: 0x00A8CB4C
		public unsafe static bool OverrideLocalNumberToServerLong(ELocalStoragePlayerKey localKey, EClientStorageSystemIdType serverKey)
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
			return true;
		}

		// Token: 0x0602DEA8 RID: 188072 RVA: 0x00A8EA08 File Offset: 0x00A8CC08
		public unsafe static bool OverrideLocalStringToServerString(ELocalStoragePlayerKey localKey, EClientStorageSystemIdType serverKey)
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
			return true;
		}

		// Token: 0x0602DEA9 RID: 188073 RVA: 0x00A8EAAC File Offset: 0x00A8CCAC
		public unsafe static bool OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey localKey, EClientStorageSystemIdType serverKey)
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
			return true;
		}

		// Token: 0x0602DEAA RID: 188074 RVA: 0x00A8EB68 File Offset: 0x00A8CD68
		public unsafe static bool OverrideLocalListToServerSet(ELocalStoragePlayerKey localKey, EClientStorageSystemIdType serverKey)
		{
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
			return true;
		}

		// Token: 0x0602DEAB RID: 188075 RVA: 0x00A8EC4C File Offset: 0x00A8CE4C
		public unsafe static bool OverrideLocalSetToServerSet(ELocalStoragePlayerKey localKey, EClientStorageSystemIdType serverKey)
		{
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
			return true;
		}
	}
}
