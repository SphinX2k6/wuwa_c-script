using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Common.LocalStorageJson;
using UnrealEngine;

namespace CSharpScript.Game.Common
{
	// Token: 0x02007286 RID: 29318
	[NullableContext(1)]
	[Nullable(0)]
	public class LocalStorage : IStaticVariableResetter
	{
		// Token: 0x06047DB7 RID: 294327 RVA: 0x01262FF0 File Offset: 0x012611F0
		static LocalStorage()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LocalStorage.CreateStaticDefaultValue), new Action(LocalStorage.ResetStaticDefaultValue));
		}

		// Token: 0x06047DB8 RID: 294328 RVA: 0x01263054 File Offset: 0x01261254
		private static string GetJournalMode(LocalStorage.EJournalMode mode)
		{
			switch (mode)
			{
			case LocalStorage.EJournalMode.Delete:
				return "PRAGMA journal_mode=DELETE";
			case LocalStorage.EJournalMode.Truncate:
				return "PRAGMA journal_mode=TRUNCATE";
			case LocalStorage.EJournalMode.Persist:
				return "PRAGMA journal_mode=PERSIST";
			case LocalStorage.EJournalMode.Memory:
				return "PRAGMA journal_mode=MEMORY";
			case LocalStorage.EJournalMode.Off:
				return "PRAGMA journal_mode=OFF";
			default:
				return "";
			}
		}

		// Token: 0x06047DB9 RID: 294329 RVA: 0x012630A0 File Offset: 0x012612A0
		public static void Initialize()
		{
			if (LocalStorage.IsInited)
			{
				return;
			}
			LocalStorage.IsInited = true;
			LocalStorage.InitDbPath();
			LocalStorage.OpenOrCreateDb();
			LocalStorage.AddEventListener();
		}

		// Token: 0x06047DBA RID: 294330 RVA: 0x012630C0 File Offset: 0x012612C0
		public static void Destroy()
		{
			LocalStorage.PlayerId = null;
			LocalStorageCache cache = LocalStorage.Cache;
			if (cache != null)
			{
				cache.Clear();
			}
			LocalStorage.RemoveEventListener();
		}

		// Token: 0x06047DBB RID: 294331 RVA: 0x012630E2 File Offset: 0x012612E2
		public static bool HasPlayerId()
		{
			return LocalStorage.PlayerId != null;
		}

		// Token: 0x06047DBC RID: 294332 RVA: 0x012630F0 File Offset: 0x012612F0
		[NullableContext(2)]
		public static T GetGlobal<T>(ELocalStorageGlobalKey key, T defaultValue = default(T))
		{
			if (!LocalStorage.IsInited)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LocalStorage;
				ELogAuthor author = ELogAuthor.TL;
				string message = "GetGlobal LocalStorage未初始化";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", key);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return defaultValue;
			}
			string text = LocalStorage.CheckAndGetGlobalKeyName(key);
			if (text == null)
			{
				return defaultValue;
			}
			string cacheEncodeValue = LocalStorage.GetCacheEncodeValue(text);
			if (!string.IsNullOrEmpty(cacheEncodeValue))
			{
				using (LocalStorageJsonContext.EnterScope(key))
				{
					return LocalStorageSerializer.Decode<T>(cacheEncodeValue);
				}
			}
			ValueTuple<bool, string> value = LocalStorage.GetValue(text, false);
			if (!value.Item1)
			{
				return defaultValue;
			}
			string item = value.Item2;
			if (string.IsNullOrEmpty(item))
			{
				return defaultValue;
			}
			T result;
			using (LocalStorageJsonContext.EnterScope(key))
			{
				T t = LocalStorageSerializer.Decode<T>(item);
				LocalStorage.SetCacheValue(text, item);
				result = t;
			}
			return result;
		}

		// Token: 0x06047DBD RID: 294333 RVA: 0x012631DC File Offset: 0x012613DC
		[NullableContext(2)]
		public unsafe static bool SetGlobal<T>(ELocalStorageGlobalKey key, T value)
		{
			if (!LocalStorage.IsInited)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LocalStorage;
				ELogAuthor author = ELogAuthor.TL;
				string message = "GetGlobal LocalStorage未初始化";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", key);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			string text = LocalStorage.CheckAndGetGlobalKeyName(key);
			if (text == null)
			{
				return false;
			}
			if (value == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.LocalStorage;
				ELogAuthor author2 = ELogAuthor.MZJ;
				string message2 = "value值非法";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("keyName", text);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", value);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			bool result;
			using (LocalStorageJsonContext.EnterScope(key))
			{
				string text2 = LocalStorageSerializer.Encode<T>(value);
				if (text2 == null)
				{
					result = false;
				}
				else if (LocalStorage.GetCacheEncodeValue(text) == text2)
				{
					result = true;
				}
				else
				{
					LocalStorage.SetCacheValue(text, text2);
					result = LocalStorage.SetValue(text, text2, false);
				}
			}
			return result;
		}

		// Token: 0x06047DBE RID: 294334 RVA: 0x012632F0 File Offset: 0x012614F0
		public static bool DeleteGlobal(ELocalStorageGlobalKey key)
		{
			string text = LocalStorage.CheckAndGetGlobalKeyName(key);
			return text != null && LocalStorage.DeleteKey(text, false);
		}

		// Token: 0x06047DBF RID: 294335 RVA: 0x01263310 File Offset: 0x01261510
		[NullableContext(2)]
		public static T GetDeviceSaved<[Nullable(1)] T>(ELocalStorageDeviceKey key, T defaultValue = default(T)) where T : class
		{
			string text = LocalStorage.CheckAndGetDeviceKeyName(key);
			if (text == null)
			{
				return defaultValue;
			}
			string cacheEncodeValue = LocalStorage.GetCacheEncodeValue(text);
			if (!string.IsNullOrEmpty(cacheEncodeValue))
			{
				using (LocalStorageJsonContext.EnterScope(key))
				{
					return LocalStorageSerializer.Decode<T>(cacheEncodeValue);
				}
			}
			ValueTuple<bool, string> value = LocalStorage.GetValue(text, true);
			if (!value.Item1)
			{
				return defaultValue;
			}
			string item = value.Item2;
			if (string.IsNullOrEmpty(item))
			{
				return defaultValue;
			}
			T result;
			using (LocalStorageJsonContext.EnterScope(key))
			{
				T t = LocalStorageSerializer.Decode<T>(item);
				LocalStorage.SetCacheValue(text, item);
				result = t;
			}
			return result;
		}

		// Token: 0x06047DC0 RID: 294336 RVA: 0x012633C4 File Offset: 0x012615C4
		[NullableContext(2)]
		public unsafe static bool SetDeviceSaved<T>(ELocalStorageDeviceKey key, T value)
		{
			string text = LocalStorage.CheckAndGetDeviceKeyName(key);
			if (text == null)
			{
				return false;
			}
			if (value == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LocalStorage;
				ELogAuthor author = ELogAuthor.MZJ;
				string message = "value值非法";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("keyName", text);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", value);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			bool result;
			using (LocalStorageJsonContext.EnterScope(key))
			{
				string text2 = LocalStorageSerializer.Encode<T>(value);
				if (text2 == null)
				{
					result = false;
				}
				else if (LocalStorage.GetCacheEncodeValue(text) == text2)
				{
					result = true;
				}
				else
				{
					LocalStorage.SetCacheValue(text, text2);
					result = LocalStorage.SetValue(text, text2, true);
				}
			}
			return result;
		}

		// Token: 0x06047DC1 RID: 294337 RVA: 0x012634A0 File Offset: 0x012616A0
		public static bool DeleteDeviceSaved(ELocalStorageDeviceKey key)
		{
			string text = LocalStorage.CheckAndGetDeviceKeyName(key);
			return text != null && LocalStorage.DeleteKey(text, true);
		}

		// Token: 0x06047DC2 RID: 294338 RVA: 0x012634C0 File Offset: 0x012616C0
		[NullableContext(2)]
		public static T GetPlayer<T>(ELocalStoragePlayerKey key, T defaultValue = default(T))
		{
			string text = LocalStorage.CheckAndGetPlayerKeyName(key);
			if (text == null)
			{
				return defaultValue;
			}
			string cacheEncodeValue = LocalStorage.GetCacheEncodeValue(text);
			if (!string.IsNullOrEmpty(cacheEncodeValue))
			{
				using (LocalStorageJsonContext.EnterScope(key))
				{
					return LocalStorageSerializer.Decode<T>(cacheEncodeValue);
				}
			}
			ValueTuple<bool, string> value = LocalStorage.GetValue(text, false);
			if (!value.Item1)
			{
				return defaultValue;
			}
			string item = value.Item2;
			if (string.IsNullOrEmpty(item))
			{
				return defaultValue;
			}
			T result;
			using (LocalStorageJsonContext.EnterScope(key))
			{
				T t = LocalStorageSerializer.Decode<T>(item);
				LocalStorage.SetCacheValue(text, item);
				result = t;
			}
			return result;
		}

		// Token: 0x06047DC3 RID: 294339 RVA: 0x01263574 File Offset: 0x01261774
		public unsafe static bool SetPlayer<[Nullable(2)] T>(ELocalStoragePlayerKey key, T value)
		{
			string text = LocalStorage.CheckAndGetPlayerKeyName(key);
			if (text == null)
			{
				return false;
			}
			if (value == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LocalStorage;
				ELogAuthor author = ELogAuthor.MZJ;
				string message = "value值非法";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("keyName", text);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", value);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			bool result;
			using (LocalStorageJsonContext.EnterScope(key))
			{
				string text2 = LocalStorageSerializer.Encode<T>(value);
				if (text2 == null)
				{
					result = false;
				}
				else if (LocalStorage.GetCacheEncodeValue(text) == text2)
				{
					result = true;
				}
				else
				{
					LocalStorage.SetCacheValue(text, text2);
					result = LocalStorage.SetValue(text, text2, false);
				}
			}
			return result;
		}

		// Token: 0x06047DC4 RID: 294340 RVA: 0x01263650 File Offset: 0x01261850
		public static bool DeletePlayer(ELocalStoragePlayerKey key)
		{
			string text = LocalStorage.CheckAndGetPlayerKeyName(key);
			return text != null && LocalStorage.DeleteKey(text, false);
		}

		// Token: 0x06047DC5 RID: 294341 RVA: 0x01263670 File Offset: 0x01261870
		private static void InitDbPath()
		{
			if (string.IsNullOrEmpty(LocalStorage.DbPath))
			{
				string str = UKuroLauncherLibrary.GameSavedDir();
				LocalStorage.DbPath = str + "LocalStorage/LocalStorage.db";
				LocalStorage.DeviceDbPath = str + "DeviceSaved/DeviceStorage.db";
			}
		}

		// Token: 0x06047DC6 RID: 294342 RVA: 0x012636A4 File Offset: 0x012618A4
		private static bool OpenOrCreateDb()
		{
			string text = LocalStorage.DbPath;
			bool flag = UKuroSqliteLibrary.OpenCreateDB(text, true);
			if (!flag)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LocalStorage;
				ELogAuthor author = ELogAuthor.MZJ;
				string message = "打开DB失败！";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("dbFilePath", text);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				for (int i = 2; i <= 10; i++)
				{
					text = UKuroLauncherLibrary.GameSavedDir() + "LocalStorage/LocalStorage" + i.ToString() + ".db";
					flag = UKuroSqliteLibrary.OpenCreateDB(text, true);
					if (flag)
					{
						LocalStorage.DbPath = text;
						break;
					}
				}
				if (!flag)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.LocalStorage;
					ELogAuthor author2 = ELogAuthor.MZJ;
					string message2 = "创建10次DB都失败！";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("dbFilePath", text);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return false;
				}
			}
			UKuroSqliteLibrary.Execute(text, LocalStorage.GetJournalMode(LocalStorage.EJournalMode.Persist));
			string text2 = LocalStorage.DeviceDbPath;
			flag = UKuroSqliteLibrary.OpenCreateDB(text2, true);
			if (!flag)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.LocalStorage;
				ELogAuthor author3 = ELogAuthor.LZP;
				string message3 = "打开DB失败！";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("deviceDbPath", text2);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				for (int j = 2; j <= 10; j++)
				{
					text2 = UKuroLauncherLibrary.GameSavedDir() + "DeviceSaved/DeviceStorage" + j.ToString() + ".db";
					flag = UKuroSqliteLibrary.OpenCreateDB(text2, true);
					if (flag)
					{
						LocalStorage.DeviceDbPath = text2;
						break;
					}
				}
				if (!flag)
				{
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.LocalStorage;
					ELogAuthor author4 = ELogAuthor.LZP;
					string message4 = "创建10次DB都失败！";
					ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("deviceDbPath", text2);
					instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
					return false;
				}
			}
			UKuroSqliteLibrary.Execute(text2, LocalStorage.GetJournalMode(LocalStorage.EJournalMode.Persist));
			return LocalStorage.CreateTable();
		}

		// Token: 0x06047DC7 RID: 294343 RVA: 0x0126382C File Offset: 0x01261A2C
		private static bool CreateTable()
		{
			string dbPath = LocalStorage.DbPath;
			string text = "create table if not exists LocalStorage(key text primary key not null , value text not null)";
			if (!UKuroSqliteLibrary.Execute(dbPath, text))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LocalStorage;
				ELogAuthor author = ELogAuthor.MZJ;
				string message = "创建DbTable失败！";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("command", text);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			bool flag = UKuroSqliteLibrary.Execute(LocalStorage.DeviceDbPath, text);
			if (!flag)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.LocalStorage;
				ELogAuthor author2 = ELogAuthor.LZP;
				string message2 = "创建DeviceDbTable失败！";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("command", text);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			return flag;
		}

		// Token: 0x06047DC8 RID: 294344 RVA: 0x012638B0 File Offset: 0x01261AB0
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private static ValueTuple<bool, string> GetValue(string keyName, bool bIsDeviceDb)
		{
			string dbPath = bIsDeviceDb ? LocalStorage.DeviceDbPath : LocalStorage.DbPath;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 2);
			defaultInterpolatedStringHandler.AppendLiteral("SELECT value FROM ");
			defaultInterpolatedStringHandler.AppendFormatted("LocalStorage");
			defaultInterpolatedStringHandler.AppendLiteral(" WHERE key ='");
			defaultInterpolatedStringHandler.AppendFormatted(keyName);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			string sql = defaultInterpolatedStringHandler.ToStringAndClear();
			string empty = string.Empty;
			int num = UKuroSqliteLibrary.QueryValue(dbPath, sql, ref empty);
			if (num == -1)
			{
				return new ValueTuple<bool, string>(false, null);
			}
			if (num == 1)
			{
				return new ValueTuple<bool, string>(true, null);
			}
			return new ValueTuple<bool, string>(true, empty);
		}

		// Token: 0x06047DC9 RID: 294345 RVA: 0x01263944 File Offset: 0x01261B44
		private static bool SetValue(string keyName, string value, bool bIsDeviceDb)
		{
			string dbPath = bIsDeviceDb ? LocalStorage.DeviceDbPath : LocalStorage.DbPath;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(82, 4);
			defaultInterpolatedStringHandler.AppendLiteral("insert into ");
			defaultInterpolatedStringHandler.AppendFormatted("LocalStorage");
			defaultInterpolatedStringHandler.AppendLiteral(" (key,value) values('");
			defaultInterpolatedStringHandler.AppendFormatted(keyName);
			defaultInterpolatedStringHandler.AppendLiteral("' , '");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("') on CONFLICT(key) do update set value = '");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			string sql = defaultInterpolatedStringHandler.ToStringAndClear();
			UKuroSqliteLibrary.ExecuteAsync(dbPath, sql);
			return true;
		}

		// Token: 0x06047DCA RID: 294346 RVA: 0x012639DB File Offset: 0x01261BDB
		[return: Nullable(2)]
		private static string GetCacheEncodeValue(string keyName)
		{
			return LocalStorage.Cache.Get(keyName);
		}

		// Token: 0x06047DCB RID: 294347 RVA: 0x012639E8 File Offset: 0x01261BE8
		private static void SetCacheValue(string keyName, string encodeValue)
		{
			LocalStorage.Cache.Set(keyName, encodeValue);
		}

		// Token: 0x06047DCC RID: 294348 RVA: 0x012639F8 File Offset: 0x01261BF8
		private static bool DeleteKey(string key, bool bIsDeviceDb)
		{
			string dbPath = bIsDeviceDb ? LocalStorage.DeviceDbPath : LocalStorage.DbPath;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
			defaultInterpolatedStringHandler.AppendLiteral("delete from ");
			defaultInterpolatedStringHandler.AppendFormatted("LocalStorage");
			defaultInterpolatedStringHandler.AppendLiteral(" where key = '");
			defaultInterpolatedStringHandler.AppendFormatted(key);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			string sql = defaultInterpolatedStringHandler.ToStringAndClear();
			UKuroSqliteLibrary.ExecuteAsync(dbPath, sql);
			return true;
		}

		// Token: 0x06047DCD RID: 294349 RVA: 0x01263A67 File Offset: 0x01261C67
		private static void AddEventListener()
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.ChangePlayerInfoId;
			Action<int> handle;
			if ((handle = LocalStorage.<>O.<0>__SetPlayerId) == null)
			{
				handle = (LocalStorage.<>O.<0>__SetPlayerId = new Action<int>(LocalStorage.SetPlayerId));
			}
			instance.Add(name, handle);
		}

		// Token: 0x06047DCE RID: 294350 RVA: 0x01263A94 File Offset: 0x01261C94
		private static void RemoveEventListener()
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.ChangePlayerInfoId;
			Action<int> handle;
			if ((handle = LocalStorage.<>O.<0>__SetPlayerId) == null)
			{
				handle = (LocalStorage.<>O.<0>__SetPlayerId = new Action<int>(LocalStorage.SetPlayerId));
			}
			instance.Remove(name, handle);
		}

		// Token: 0x06047DCF RID: 294351 RVA: 0x01263AC1 File Offset: 0x01261CC1
		private static void SetPlayerId(int id)
		{
			LocalStorage.PlayerId = new int?(id);
			EventSystem.Instance.Emit(EEventName.LocalStorageInitPlayerId);
		}

		// Token: 0x06047DD0 RID: 294352 RVA: 0x01263AE0 File Offset: 0x01261CE0
		[NullableContext(2)]
		private static string CheckAndGetGlobalKeyName(ELocalStorageGlobalKey key)
		{
			string text = key.ToString();
			if (string.IsNullOrEmpty(text))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LocalStorage;
				ELogAuthor author = ELogAuthor.MZJ;
				string message = "keyName值非法";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", key);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return text;
		}

		// Token: 0x06047DD1 RID: 294353 RVA: 0x01263B38 File Offset: 0x01261D38
		[NullableContext(2)]
		private static string CheckAndGetDeviceKeyName(ELocalStorageDeviceKey key)
		{
			string text = key.ToString();
			if (string.IsNullOrEmpty(text))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LocalStorage;
				ELogAuthor author = ELogAuthor.MZJ;
				string message = "keyName值非法";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", key);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return text;
		}

		// Token: 0x06047DD2 RID: 294354 RVA: 0x01263B90 File Offset: 0x01261D90
		[NullableContext(2)]
		private unsafe static string CheckAndGetPlayerKeyName(ELocalStoragePlayerKey key)
		{
			string text = key.ToString();
			if (string.IsNullOrEmpty(text))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LocalStorage;
				ELogAuthor author = ELogAuthor.MZJ;
				string message = "keyName值非法！";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("keyName", text);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			if (LocalStorage.PlayerId == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.LocalStorage;
				ELogAuthor author2 = ELogAuthor.MZJ;
				string message2 = "尚未获取到playerId，无法操作Player相关的存储值！";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("keyName", text);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int?>(LocalStorage.PlayerId);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06047DD3 RID: 294355 RVA: 0x01263C78 File Offset: 0x01261E78
		public static void CreateStaticDefaultValue()
		{
			LocalStorage.Cache = new LocalStorageCache();
		}

		// Token: 0x06047DD4 RID: 294356 RVA: 0x01263C84 File Offset: 0x01261E84
		public static void ResetStaticDefaultValue()
		{
			LocalStorage.DbPath = null;
			LocalStorage.Cache = null;
			LocalStorage.DeviceDbPath = null;
			LocalStorage.PlayerId = null;
			LocalStorage.IsInited = false;
		}

		// Token: 0x04025C7A RID: 154746
		private const string DBPATH = "LocalStorage/LocalStorage";

		// Token: 0x04025C7B RID: 154747
		private const string DEVICEDBPATH = "DeviceSaved/DeviceStorage";

		// Token: 0x04025C7C RID: 154748
		private const string DBSUFFIX = ".db";

		// Token: 0x04025C7D RID: 154749
		private const string TABLENAME = "LocalStorage";

		// Token: 0x04025C7E RID: 154750
		private const int DBNUM = 10;

		// Token: 0x04025C7F RID: 154751
		private const bool ISUSEDB = true;

		// Token: 0x04025C80 RID: 154752
		private const bool USE_THREAD = true;

		// Token: 0x04025C81 RID: 154753
		private const bool USE_CACHE = true;

		// Token: 0x04025C82 RID: 154754
		private const int SQLITE_ERR = -1;

		// Token: 0x04025C83 RID: 154755
		private const int SQLITE_NO_DATA = 1;

		// Token: 0x04025C84 RID: 154756
		private const int CHECK_COMPLEX_THRESHOLD = 600;

		// Token: 0x04025C85 RID: 154757
		private const LocalStorage.EJournalMode USE_JOURNAL_MODE = LocalStorage.EJournalMode.Persist;

		// Token: 0x04025C86 RID: 154758
		[Nullable(2)]
		private static string DbPath;

		// Token: 0x04025C87 RID: 154759
		[Nullable(2)]
		private static string DeviceDbPath;

		// Token: 0x04025C88 RID: 154760
		private static int? PlayerId;

		// Token: 0x04025C89 RID: 154761
		[Nullable(2)]
		private static LocalStorageCache Cache;

		// Token: 0x04025C8A RID: 154762
		private static bool IsInited = false;

		// Token: 0x04025C8B RID: 154763
		[StaticVariableRuleIgnore]
		private static readonly Stat StatOpenOrCreateDb = Stat.Create("LocalStorage_OpenOrCreateDb", "", "");

		// Token: 0x04025C8C RID: 154764
		[StaticVariableRuleIgnore]
		private static readonly Stat StatCreateTable = Stat.Create("LocalStorage_CreateTable", "", "");

		// Token: 0x0200CF8E RID: 53134
		[NullableContext(0)]
		private enum EJournalMode
		{
			// Token: 0x0403E61F RID: 255519
			Delete,
			// Token: 0x0403E620 RID: 255520
			Truncate,
			// Token: 0x0403E621 RID: 255521
			Persist,
			// Token: 0x0403E622 RID: 255522
			Memory,
			// Token: 0x0403E623 RID: 255523
			Off
		}

		// Token: 0x0200CF8F RID: 53135
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403E624 RID: 255524
			[Nullable(0)]
			public static Action<int> <0>__SetPlayerId;
		}
	}
}
