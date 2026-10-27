using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Util;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x0200023A RID: 570
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherConfigLib : Singleton
	{
		// Token: 0x06000E70 RID: 3696 RVA: 0x00055B18 File Offset: 0x00053D18
		public void Initialize()
		{
			if (this.IsInit)
			{
				return;
			}
			this.IsInit = true;
			string str = KuroApplication.ProjectContentDir();
			this.BaseDir = str + "Aki/ConfigDB/";
			string tableName = LauncherMenuConfig.GetTableName();
			string tableName2 = LauncherServerLimitConfig.GetTableName();
			string tableName3 = LauncherDownLoadConfig.GetTableName();
			int num = 0;
			TArray<string> tarray = UKuroStaticLibrary.LoadFileToStringArray(str + "Aki/ConfigDB/aki_base.csv");
			for (int i = 1; i < tarray.Num(); i++)
			{
				string[] array = tarray.Get(i).Split(',', StringSplitOptions.None);
				if (array.Length > 2)
				{
					if (this.MenuConfigDbInfo == null && array[0] == tableName)
					{
						this.MenuConfigDbInfo = new DbInfo(this.BaseDir + array[1], array[2]);
						num++;
					}
					if (this.ServerLimitConfigDbInfo == null && array[0] == tableName2)
					{
						this.ServerLimitConfigDbInfo = new DbInfo(this.BaseDir + array[1], array[2]);
						num++;
					}
					if (this.DownLoadDbInfo == null && array[0] == tableName3)
					{
						this.DownLoadDbInfo = new DbInfo(this.BaseDir + array[1], array[2]);
						num++;
					}
					if (num >= 3)
					{
						break;
					}
				}
			}
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00055C5C File Offset: 0x00053E5C
		public LauncherMenuConfig GetMenuConfigByFunctionId(int functionId)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 2);
			defaultInterpolatedStringHandler.AppendLiteral("SELECT * FROM `");
			defaultInterpolatedStringHandler.AppendFormatted(LauncherMenuConfig.GetTableName());
			defaultInterpolatedStringHandler.AppendLiteral("` WHERE FunctionId=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(functionId);
			string sql = defaultInterpolatedStringHandler.ToStringAndClear();
			UKuroSqliteResultSet ukuroSqliteResultSet = new UKuroSqliteResultSet();
			LauncherMenuConfig result;
			try
			{
				if (!UKuroSqliteLibrary.Query(this.MenuConfigDbInfo.ConfigDbPath, sql, ukuroSqliteResultSet) || !ukuroSqliteResultSet.HasValue())
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "查询LauncherMenuConfig失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("functionId", functionId);
					instance.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					result = null;
				}
				else
				{
					result = LauncherMenuConfig.Parse(ukuroSqliteResultSet);
				}
			}
			finally
			{
				ukuroSqliteResultSet.Release();
			}
			return result;
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00055D18 File Offset: 0x00053F18
		public LaunchGameSettingMenuConfig GetGameSettingsMenuConfigByFunctionId(int functionId)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 2);
			defaultInterpolatedStringHandler.AppendLiteral("SELECT * FROM `");
			defaultInterpolatedStringHandler.AppendFormatted(LaunchGameSettingMenuConfig.GetTableName());
			defaultInterpolatedStringHandler.AppendLiteral("` WHERE FunctionId=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(functionId);
			string sql = defaultInterpolatedStringHandler.ToStringAndClear();
			UKuroSqliteResultSet ukuroSqliteResultSet = new UKuroSqliteResultSet();
			LaunchGameSettingMenuConfig result;
			try
			{
				if (!UKuroSqliteLibrary.Query(this.MenuConfigDbInfo.ConfigDbPath, sql, ukuroSqliteResultSet) || !ukuroSqliteResultSet.HasValue())
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "查询LauncherMenuConfig失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("functionId", functionId);
					instance.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					result = null;
				}
				else
				{
					result = LaunchGameSettingMenuConfig.Parse(ukuroSqliteResultSet);
				}
			}
			finally
			{
				ukuroSqliteResultSet.Release();
			}
			return result;
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00055DD4 File Offset: 0x00053FD4
		public LauncherServerLimitConfig GetServerLimitConfig(string regionId)
		{
			string sql = "SELECT * FROM `" + LauncherServerLimitConfig.GetTableName() + "` WHERE Id=" + regionId;
			UKuroSqliteResultSet ukuroSqliteResultSet = new UKuroSqliteResultSet();
			LauncherServerLimitConfig result;
			try
			{
				if (!UKuroSqliteLibrary.Query(this.ServerLimitConfigDbInfo.ConfigDbPath, sql, ukuroSqliteResultSet) || !ukuroSqliteResultSet.HasValue())
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "查询LauncherServerLimitConfig失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("regionId", regionId);
					instance.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					result = null;
				}
				else
				{
					result = LauncherServerLimitConfig.Parse(ukuroSqliteResultSet);
				}
			}
			finally
			{
				ukuroSqliteResultSet.Release();
			}
			return result;
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00055E60 File Offset: 0x00054060
		public unsafe bool IsLanguageValid(string languageCode)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 2);
			defaultInterpolatedStringHandler.AppendLiteral("SELECT * FROM `");
			defaultInterpolatedStringHandler.AppendFormatted(LauncherMenuConfig.GetLanguageTableName());
			defaultInterpolatedStringHandler.AppendLiteral("` WHERE LanguageCode='");
			defaultInterpolatedStringHandler.AppendFormatted(languageCode);
			defaultInterpolatedStringHandler.AppendLiteral("'");
			string sql = defaultInterpolatedStringHandler.ToStringAndClear();
			UKuroSqliteResultSet ukuroSqliteResultSet = new UKuroSqliteResultSet();
			bool result;
			try
			{
				if (!UKuroSqliteLibrary.Query(this.MenuConfigDbInfo.ConfigDbPath, sql, ukuroSqliteResultSet) || !ukuroSqliteResultSet.HasValue())
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "查询LanguageDefine失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("languageCode", languageCode);
					instance.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					result = false;
				}
				else
				{
					LaunchLanguageDefineConfig launchLanguageDefineConfig = LauncherMenuConfig.ParseLanguageDefine(ukuroSqliteResultSet);
					LauncherLog instance2 = LauncherLog.Instance;
					string message2 = "读取到的多语言配置";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("languageCode", languageCode);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("config", launchLanguageDefineConfig);
					instance2.Info(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					result = (launchLanguageDefineConfig != null && launchLanguageDefineConfig.IsShow);
				}
			}
			finally
			{
				ukuroSqliteResultSet.Release();
			}
			return result;
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00055F84 File Offset: 0x00054184
		[return: Nullable(2)]
		public unsafe string GetHotPatchText(string id)
		{
			if (string.IsNullOrEmpty(id))
			{
				return null;
			}
			string text = null;
			if (this.HotPatchTextMap.TryGetValue(id, out text))
			{
				return text;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
			defaultInterpolatedStringHandler.AppendLiteral("SELECT * FROM `");
			defaultInterpolatedStringHandler.AppendFormatted("HotPatchText");
			defaultInterpolatedStringHandler.AppendLiteral("` WHERE Id=\"");
			defaultInterpolatedStringHandler.AppendFormatted(id);
			defaultInterpolatedStringHandler.AppendLiteral("\"");
			string text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			UKuroSqliteResultSet ukuroSqliteResultSet = new UKuroSqliteResultSet();
			string result;
			try
			{
				if (!UKuroSqliteLibrary.Query(this.GetTextDbPath("lang_hot_patch.db", null), text2, ukuroSqliteResultSet) || !ukuroSqliteResultSet.HasValue())
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "查询HotPatchText多语言表失败";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("textId", id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DB", this.GetTextDbPath("lang_hot_patch.db", null));
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("command", text2);
					instance.Error(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					result = null;
				}
				else if (!ukuroSqliteResultSet.GetString("Content", ref text))
				{
					LauncherLog.Instance.Error("获取HotPatchText多语言数据字段失败，没有Content字段", default(ReadOnlySpan<ValueTuple<string, object>>));
					result = null;
				}
				else
				{
					this.HotPatchTextMap[id] = text;
					result = text;
				}
			}
			finally
			{
				ukuroSqliteResultSet.Release();
			}
			return result;
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x000560EC File Offset: 0x000542EC
		private string GetTextDbPath(string dbName, string culture = null)
		{
			string str = ((!string.IsNullOrEmpty(culture)) ? culture : LauncherLanguageLib.Instance.GetPackageLanguage()) + "/" + dbName;
			return this.BaseDir + str;
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00056128 File Offset: 0x00054328
		public unsafe LauncherDownLoadConfig GetDownLoadTabConfig(string regionId)
		{
			string sql = "SELECT * FROM `" + LauncherDownLoadConfig.GetTableName() + "` WHERE Id=" + regionId;
			UKuroSqliteResultSet ukuroSqliteResultSet = new UKuroSqliteResultSet();
			LauncherDownLoadConfig result;
			try
			{
				if (!UKuroSqliteLibrary.Query(this.DownLoadDbInfo.ConfigDbPath, sql, ukuroSqliteResultSet) || !ukuroSqliteResultSet.HasValue())
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "查询LauncherDownLoadConfig失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("regionId", regionId);
					instance.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					result = null;
				}
				else
				{
					LauncherDownLoadConfig launcherDownLoadConfig = LauncherDownLoadConfig.Parse(ukuroSqliteResultSet);
					LauncherLog instance2 = LauncherLog.Instance;
					string message2 = "GetDownLoadTabConfig";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("config.Id", regionId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("config", launcherDownLoadConfig);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("rs.IsValid();", ukuroSqliteResultSet.IsValid());
					instance2.Info(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					result = launcherDownLoadConfig;
				}
			}
			finally
			{
				ukuroSqliteResultSet.Release();
			}
			return result;
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x00056230 File Offset: 0x00054430
		public static LauncherConfigLib Instance
		{
			get
			{
				if (LauncherConfigLib._instance == null)
				{
					LauncherConfigLib._instance = new LauncherConfigLib();
					LauncherConfigLib._instance.OnInit();
				}
				return LauncherConfigLib._instance;
			}
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00056253 File Offset: 0x00054453
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00056255 File Offset: 0x00054455
		public static void ResetStaticDefaultValue()
		{
			LauncherConfigLib instance = LauncherConfigLib._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LauncherConfigLib._instance = null;
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x0005626E File Offset: 0x0005446E
		static LauncherConfigLib()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherConfigLib.CreateStaticDefaultValue), new Action(LauncherConfigLib.ResetStaticDefaultValue));
		}

		// Token: 0x04000929 RID: 2345
		private string BaseDir = "";

		// Token: 0x0400092A RID: 2346
		private DbInfo MenuConfigDbInfo;

		// Token: 0x0400092B RID: 2347
		private DbInfo ServerLimitConfigDbInfo;

		// Token: 0x0400092C RID: 2348
		private DbInfo DownLoadDbInfo;

		// Token: 0x0400092D RID: 2349
		private readonly Dictionary<string, string> HotPatchTextMap = new Dictionary<string, string>();

		// Token: 0x0400092E RID: 2350
		private bool IsInit;

		// Token: 0x0400092F RID: 2351
		private const string DB = "lang_hot_patch.db";

		// Token: 0x04000930 RID: 2352
		private const string TABLE = "HotPatchText";

		// Token: 0x04000931 RID: 2353
		[Nullable(2)]
		private static LauncherConfigLib _instance;
	}
}
