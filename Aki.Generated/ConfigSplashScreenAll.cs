using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000970 RID: 2416
	public class ConfigSplashScreenAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038B4 RID: 14516 RVA: 0x0019A344 File Offset: 0x00198544
		static ConfigSplashScreenAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSplashScreenAll.CreateStaticDefaultValue), new Action(ConfigSplashScreenAll.ResetStaticDefaultValue));
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x0019A364 File Offset: 0x00198564
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

		// Token: 0x060038B6 RID: 14518 RVA: 0x0019A3E3 File Offset: 0x001985E3
		public static void ResetStaticDefaultValue()
		{
			ConfigSplashScreenAll.LogPair = null;
			ConfigSplashScreenAll.HandleId = 0;
		}

		// Token: 0x060038B7 RID: 14519 RVA: 0x0019A3F1 File Offset: 0x001985F1
		public static void Init()
		{
			ConfigSplashScreenAll.HandleId = ConfigCommon.InitDataStatement(ConfigSplashScreenAll.HandleId, "db_splashscreen.db", "select BinData from `SplashScreen`");
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x0019A40C File Offset: 0x0019860C
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

		// Token: 0x040041F6 RID: 16886
		private const string DB = "db_splashscreen.db";

		// Token: 0x040041F7 RID: 16887
		private const string FILE = "k.开屏动画.xlsx";

		// Token: 0x040041F8 RID: 16888
		private const string TABLE = "SplashScreen";

		// Token: 0x040041F9 RID: 16889
		private const string COMMAND = "select BinData from `SplashScreen`";

		// Token: 0x040041FA RID: 16890
		private const string KEY_PREFIX = "SplashScreenAll";

		// Token: 0x040041FB RID: 16891
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041FC RID: 16892
		private static int HandleId;
	}
}
