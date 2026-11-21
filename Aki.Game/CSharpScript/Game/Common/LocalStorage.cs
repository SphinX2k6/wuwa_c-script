using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Common.LocalStorageJson;
using UnrealEngine;

namespace CSharpScript.Game.Common
{
	// Token: 0x02006405 RID: 25605
	[NullableContext(1)]
	[Nullable(0)]
	public class LocalStorage : IStaticVariableResetter
	{
		// Token: 0x0603E177 RID: 254327 RVA: 0x01203A00 File Offset: 0x01201C00
		static LocalStorage()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LocalStorage.CreateStaticDefaultValue), new Action(LocalStorage.ResetStaticDefaultValue));
		}

		// Token: 0x0603E178 RID: 254328 RVA: 0x01203A64 File Offset: 0x01201C64
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

		// Token: 0x0603E179 RID: 254329 RVA: 0x01203AB0 File Offset: 0x01201CB0
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

		// Token: 0x0603E17A RID: 254330 RVA: 0x01203AD0 File Offset: 0x01201CD0
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

		// Token: 0x0603E17B RID: 254331 RVA: 0x01203AF2 File Offset: 0x01201CF2
		public static bool HasPlayerId()
		{
			return LocalStorage.PlayerId != null;
		}

		// Token: 0x0603E17C RID: 254332 RVA: 0x01203B00 File Offset: 0x01201D00
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

		// Token: 0x0603E17D RID: 254333 RVA: 0x01203BEC File Offset: 0x01201DEC
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

		// Token: 0x0603E17E RID: 254334 RVA: 0x01203D00 File Offset: 0x01201F00
		public static bool DeleteGlobal(ELocalStorageGlobalKey key)
		{
			string text = LocalStorage.CheckAndGetGlobalKeyName(key);
			return text != null && LocalStorage.DeleteKey(text, false);
		}

		// Token: 0x0603E17F RID: 254335 RVA: 0x01203D20 File Offset: 0x01201F20
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

		// Token: 0x0603E180 RID: 254336 RVA: 0x01203DD4 File Offset: 0x01201FD4
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

		// Token: 0x0603E181 RID: 254337 RVA: 0x01203EB0 File Offset: 0x012020B0
		public static bool DeleteDeviceSaved(ELocalStorageDeviceKey key)
		{
			string text = LocalStorage.CheckAndGetDeviceKeyName(key);
			return text != null && LocalStorage.DeleteKey(text, true);
		}

		// Token: 0x0603E182 RID: 254338 RVA: 0x01203ED0 File Offset: 0x012020D0
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

		// Token: 0x0603E183 RID: 254339 RVA: 0x01203F84 File Offset: 0x01202184
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

		// Token: 0x0603E184 RID: 254340 RVA: 0x01204060 File Offset: 0x01202260
		public static bool DeletePlayer(ELocalStoragePlayerKey key)
		{
			string text = LocalStorage.CheckAndGetPlayerKeyName(key);
			return text != null && LocalStorage.DeleteKey(text, false);
		}

		// Token: 0x0603E185 RID: 254341 RVA: 0x01204080 File Offset: 0x01202280
		private static void InitDbPath()
		{
			if (string.IsNullOrEmpty(LocalStorage.DbPath))
			{
				string str = UKuroLauncherLibrary.GameSavedDir();
				LocalStorage.DbPath = str + "LocalStorage/LocalStorage.db";
				LocalStorage.DeviceDbPath = str + "DeviceSaved/DeviceStorage.db";
			}
		}

		// Token: 0x0603E186 RID: 254342 RVA: 0x012040B4 File Offset: 0x012022B4
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

		// Token: 0x0603E187 RID: 254343 RVA: 0x0120423C File Offset: 0x0120243C
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

		// Token: 0x0603E188 RID: 254344 RVA: 0x012042C0 File Offset: 0x012024C0
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

		// Token: 0x0603E189 RID: 254345 RVA: 0x01204354 File Offset: 0x01202554
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

		// Token: 0x0603E18A RID: 254346 RVA: 0x012043EB File Offset: 0x012025EB
		[return: Nullable(2)]
		private static string GetCacheEncodeValue(string keyName)
		{
			return LocalStorage.Cache.Get(keyName);
		}

		// Token: 0x0603E18B RID: 254347 RVA: 0x012043F8 File Offset: 0x012025F8
		private static void SetCacheValue(string keyName, string encodeValue)
		{
			LocalStorage.Cache.Set(keyName, encodeValue);
		}

		// Token: 0x0603E18C RID: 254348 RVA: 0x01204408 File Offset: 0x01202608
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

		// Token: 0x0603E18D RID: 254349 RVA: 0x01204477 File Offset: 0x01202677
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

		// Token: 0x0603E18E RID: 254350 RVA: 0x012044A4 File Offset: 0x012026A4
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

		// Token: 0x0603E18F RID: 254351 RVA: 0x012044D1 File Offset: 0x012026D1
		private static void SetPlayerId(int id)
		{
			LocalStorage.PlayerId = new int?(id);
			EventSystem.Instance.Emit(EEventName.LocalStorageInitPlayerId);
		}

		// Token: 0x0603E190 RID: 254352 RVA: 0x012044F0 File Offset: 0x012026F0
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

		// Token: 0x0603E191 RID: 254353 RVA: 0x01204548 File Offset: 0x01202748
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

		// Token: 0x0603E192 RID: 254354 RVA: 0x012045A0 File Offset: 0x012027A0
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

		// Token: 0x0603E193 RID: 254355 RVA: 0x01204688 File Offset: 0x01202888
		public static void CreateStaticDefaultValue()
		{
			LocalStorage.Cache = new LocalStorageCache();
		}

		// Token: 0x0603E194 RID: 254356 RVA: 0x01204694 File Offset: 0x01202894
		public static void ResetStaticDefaultValue()
		{
			LocalStorage.DbPath = null;
			LocalStorage.Cache = null;
			LocalStorage.DeviceDbPath = null;
			LocalStorage.PlayerId = null;
			LocalStorage.IsInited = false;
		}

		// Token: 0x04020F3A RID: 134970
		private const string DBPATH = "LocalStorage/LocalStorage";

		// Token: 0x04020F3B RID: 134971
		private const string DEVICEDBPATH = "DeviceSaved/DeviceStorage";

		// Token: 0x04020F3C RID: 134972
		private const string DBSUFFIX = ".db";

		// Token: 0x04020F3D RID: 134973
		private const string TABLENAME = "LocalStorage";

		// Token: 0x04020F3E RID: 134974
		private const int DBNUM = 10;

		// Token: 0x04020F3F RID: 134975
		private const bool ISUSEDB = true;

		// Token: 0x04020F40 RID: 134976
		private const bool USE_THREAD = true;

		// Token: 0x04020F41 RID: 134977
		private const bool USE_CACHE = true;

		// Token: 0x04020F42 RID: 134978
		private const int SQLITE_ERR = -1;

		// Token: 0x04020F43 RID: 134979
		private const int SQLITE_NO_DATA = 1;

		// Token: 0x04020F44 RID: 134980
		private const int CHECK_COMPLEX_THRESHOLD = 600;

		// Token: 0x04020F45 RID: 134981
		private const LocalStorage.EJournalMode USE_JOURNAL_MODE = LocalStorage.EJournalMode.Persist;

		// Token: 0x04020F46 RID: 134982
		[Nullable(2)]
		private static string DbPath;

		// Token: 0x04020F47 RID: 134983
		[Nullable(2)]
		private static string DeviceDbPath;

		// Token: 0x04020F48 RID: 134984
		private static int? PlayerId;

		// Token: 0x04020F49 RID: 134985
		[Nullable(2)]
		private static LocalStorageCache Cache;

		// Token: 0x04020F4A RID: 134986
		private static bool IsInited = false;

		// Token: 0x04020F4B RID: 134987
		[StaticVariableRuleIgnore]
		private static readonly Stat StatOpenOrCreateDb = Stat.Create("LocalStorage_OpenOrCreateDb", "", "");

		// Token: 0x04020F4C RID: 134988
		[StaticVariableRuleIgnore]
		private static readonly Stat StatCreateTable = Stat.Create("LocalStorage_CreateTable", "", "");

		// Token: 0x0200BB7A RID: 47994
		[NullableContext(0)]
		private enum EJournalMode
		{
			// Token: 0x04039A4B RID: 236107
			Delete,
			// Token: 0x04039A4C RID: 236108
			Truncate,
			// Token: 0x04039A4D RID: 236109
			Persist,
			// Token: 0x04039A4E RID: 236110
			Memory,
			// Token: 0x04039A4F RID: 236111
			Off
		}

		// Token: 0x0200BB7B RID: 47995
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04039A50 RID: 236112
			[Nullable(0)]
			public static Action<int> <0>__SetPlayerId;
		}
	}
}
