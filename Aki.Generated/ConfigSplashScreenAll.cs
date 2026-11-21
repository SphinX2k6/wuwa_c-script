using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A45 RID: 2629
	public class ConfigSplashScreenAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DB2 RID: 15794 RVA: 0x001B96D8 File Offset: 0x001B78D8
		static ConfigSplashScreenAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSplashScreenAll.CreateStaticDefaultValue), new Action(ConfigSplashScreenAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x001B96F8 File Offset: 0x001B78F8
		public static void CreateStaticDefaultValue()
		{
			ConfigSplashScreenAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSplashScreenAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_splashscreen.db"),
				new ValueTuple<string, object>("文件", "k.开屏动画.xlsx"),
				new ValueTuple<string, object>("表名", "SplashScreen"),
				new ValueTuple<string, object>("语句", "select BinData from `SplashScreen`")
			});
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x001B9777 File Offset: 0x001B7977
		public static void ResetStaticDefaultValue()
		{
			ConfigSplashScreenAll.LogPair = null;
			ConfigSplashScreenAll.HandleId = 0;
		}

		// Token: 0x06003DB5 RID: 15797 RVA: 0x001B9785 File Offset: 0x001B7985
		public static void Init()
		{
			ConfigSplashScreenAll.HandleId = ConfigCommon.InitDataStatement(ConfigSplashScreenAll.HandleId, "db_splashscreen.db", "select BinData from `SplashScreen`");
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x001B97A0 File Offset: 0x001B79A0
		[NullableContext(2)]
		public static IReadOnlyList<SplashScreen> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSplashScreenAll.HandleId, ConfigSplashScreenAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SplashScreen> readOnlyList = (IReadOnlyList<SplashScreen>)ConfigCommon.GetConfig("SplashScreenAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SplashScreen> list = new List<SplashScreen>();
			while (ConfigCommon.Step(ConfigSplashScreenAll.HandleId, false, ConfigSplashScreenAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSplashScreenAll.HandleId, 0, ConfigSplashScreenAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSplashScreenAll.HandleId, ConfigSplashScreenAll.LogPair);
					return null;
				}
				SplashScreen rootAsSplashScreen = SplashScreen.GetRootAsSplashScreen(new ByteBuffer(item2));
				list.Add(rootAsSplashScreen);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SplashScreenAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSplashScreenAll.HandleId, ConfigSplashScreenAll.LogPair);
			return list;
		}

		// Token: 0x040047C9 RID: 18377
		private const string DB = "db_splashscreen.db";

		// Token: 0x040047CA RID: 18378
		private const string FILE = "k.开屏动画.xlsx";

		// Token: 0x040047CB RID: 18379
		private const string TABLE = "SplashScreen";

		// Token: 0x040047CC RID: 18380
		private const string COMMAND = "select BinData from `SplashScreen`";

		// Token: 0x040047CD RID: 18381
		private const string KEY_PREFIX = "SplashScreenAll";

		// Token: 0x040047CE RID: 18382
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047CF RID: 18383
		private static int HandleId;
	}
}
