using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000971 RID: 2417
	public class ConfigSplashScreenById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038BA RID: 14522 RVA: 0x0019A4D7 File Offset: 0x001986D7
		static ConfigSplashScreenById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSplashScreenById.CreateStaticDefaultValue), new Action(ConfigSplashScreenById.ResetStaticDefaultValue));
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x0019A4F8 File Offset: 0x001986F8
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

		// Token: 0x060038BC RID: 14524 RVA: 0x0019A577 File Offset: 0x00198777
		public static void ResetStaticDefaultValue()
		{
			ConfigSplashScreenById.LogPair = null;
			ConfigSplashScreenById.HandleId = 0;
		}

		// Token: 0x060038BD RID: 14525 RVA: 0x0019A585 File Offset: 0x00198785
		public static void Init()
		{
			ConfigSplashScreenById.HandleId = ConfigCommon.InitDataStatement(ConfigSplashScreenById.HandleId, "db_splashscreen.db", "select BinData from `SplashScreen` where Id=?");
		}

		// Token: 0x060038BE RID: 14526 RVA: 0x0019A5A0 File Offset: 0x001987A0
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

		// Token: 0x040041FD RID: 16893
		private const string DB = "db_splashscreen.db";

		// Token: 0x040041FE RID: 16894
		private const string FILE = "k.开屏动画.xlsx";

		// Token: 0x040041FF RID: 16895
		private const string TABLE = "SplashScreen";

		// Token: 0x04004200 RID: 16896
		private const string COMMAND = "select BinData from `SplashScreen` where Id=?";

		// Token: 0x04004201 RID: 16897
		private const string KEY_PREFIX = "SplashScreenById";

		// Token: 0x04004202 RID: 16898
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004203 RID: 16899
		private static int HandleId;
	}
}
