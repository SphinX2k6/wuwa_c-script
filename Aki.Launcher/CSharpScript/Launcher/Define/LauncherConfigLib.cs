using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Util;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x0200023F RID: 575
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherConfigLib : Singleton
	{
		// Token: 0x06000EB1 RID: 3761 RVA: 0x00058620 File Offset: 0x00056820
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

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00058764 File Offset: 0x00056964
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

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00058820 File Offset: 0x00056A20
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

		// Token: 0x06000EB4 RID: 3764 RVA: 0x000588DC File Offset: 0x00056ADC
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

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00058968 File Offset: 0x00056B68
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

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00058A8C File Offset: 0x00056C8C
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

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00058BF4 File Offset: 0x00056DF4
		private string GetTextDbPath(string dbName, string culture = null)
		{
			string str = ((!string.IsNullOrEmpty(culture)) ? culture : LauncherLanguageLib.Instance.GetPackageLanguage()) + "/" + dbName;
			return this.BaseDir + str;
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00058C30 File Offset: 0x00056E30
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

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x00058D38 File Offset: 0x00056F38
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

		// Token: 0x06000EBA RID: 3770 RVA: 0x00058D5B File Offset: 0x00056F5B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00058D5D File Offset: 0x00056F5D
		public static void ResetStaticDefaultValue()
		{
			LauncherConfigLib instance = LauncherConfigLib._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LauncherConfigLib._instance = null;
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00058D76 File Offset: 0x00056F76
		static LauncherConfigLib()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherConfigLib.CreateStaticDefaultValue), new Action(LauncherConfigLib.ResetStaticDefaultValue));
		}

		// Token: 0x0400096B RID: 2411
		private string BaseDir = "";

		// Token: 0x0400096C RID: 2412
		private DbInfo MenuConfigDbInfo;

		// Token: 0x0400096D RID: 2413
		private DbInfo ServerLimitConfigDbInfo;

		// Token: 0x0400096E RID: 2414
		private DbInfo DownLoadDbInfo;

		// Token: 0x0400096F RID: 2415
		private readonly Dictionary<string, string> HotPatchTextMap = new Dictionary<string, string>();

		// Token: 0x04000970 RID: 2416
		private bool IsInit;

		// Token: 0x04000971 RID: 2417
		private const string DB = "lang_hot_patch.db";

		// Token: 0x04000972 RID: 2418
		private const string TABLE = "HotPatchText";

		// Token: 0x04000973 RID: 2419
		[Nullable(2)]
		private static LauncherConfigLib _instance;
	}
}
