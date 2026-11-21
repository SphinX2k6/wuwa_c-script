using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A46 RID: 2630
	public class ConfigSplashScreenById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DB8 RID: 15800 RVA: 0x001B986B File Offset: 0x001B7A6B
		static ConfigSplashScreenById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSplashScreenById.CreateStaticDefaultValue), new Action(ConfigSplashScreenById.ResetStaticDefaultValue));
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x001B988C File Offset: 0x001B7A8C
		public static void CreateStaticDefaultValue()
		{
			ConfigSplashScreenById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSplashScreenById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_splashscreen.db"),
				new ValueTuple<string, object>("文件", "k.开屏动画.xlsx"),
				new ValueTuple<string, object>("表名", "SplashScreen"),
				new ValueTuple<string, object>("语句", "select BinData from `SplashScreen` where Id=?")
			});
		}

		// Token: 0x06003DBA RID: 15802 RVA: 0x001B990B File Offset: 0x001B7B0B
		public static void ResetStaticDefaultValue()
		{
			ConfigSplashScreenById.LogPair = null;
			ConfigSplashScreenById.HandleId = 0;
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x001B9919 File Offset: 0x001B7B19
		public static void Init()
		{
			ConfigSplashScreenById.HandleId = ConfigCommon.InitDataStatement(ConfigSplashScreenById.HandleId, "db_splashscreen.db", "select BinData from `SplashScreen` where Id=?");
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x001B9934 File Offset: 0x001B7B34
		public static SplashScreen? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSplashScreenById.HandleId, ConfigSplashScreenById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SplashScreenById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SplashScreen?(SplashScreen.GetRootAsSplashScreen(configBuffer));
				}
			}
			ConfigSplashScreenById.LogPair.Clear();
			ConfigSplashScreenById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSplashScreenById.HandleId, 1, p0Id, ConfigSplashScreenById.LogPair) || ConfigCommon.Step(ConfigSplashScreenById.HandleId, true, ConfigSplashScreenById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSplashScreenById.HandleId, ConfigSplashScreenById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSplashScreenById.HandleId, 0, ConfigSplashScreenById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSplashScreenById.HandleId, ConfigSplashScreenById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SplashScreen rootAsSplashScreen = SplashScreen.GetRootAsSplashScreen(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SplashScreenById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSplashScreenById.HandleId, ConfigSplashScreenById.LogPair);
			return new SplashScreen?(rootAsSplashScreen);
		}

		// Token: 0x040047D0 RID: 18384
		private const string DB = "db_splashscreen.db";

		// Token: 0x040047D1 RID: 18385
		private const string FILE = "k.开屏动画.xlsx";

		// Token: 0x040047D2 RID: 18386
		private const string TABLE = "SplashScreen";

		// Token: 0x040047D3 RID: 18387
		private const string COMMAND = "select BinData from `SplashScreen` where Id=?";

		// Token: 0x040047D4 RID: 18388
		private const string KEY_PREFIX = "SplashScreenById";

		// Token: 0x040047D5 RID: 18389
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047D6 RID: 18390
		private static int HandleId;
	}
}
