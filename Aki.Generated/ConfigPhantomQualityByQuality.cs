using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006AF RID: 1711
	public class ConfigPhantomQualityByQuality : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600282A RID: 10282 RVA: 0x0013CB58 File Offset: 0x0013AD58
		static ConfigPhantomQualityByQuality()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomQualityByQuality.CreateStaticDefaultValue), new Action(ConfigPhantomQualityByQuality.ResetStaticDefaultValue));
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x0013CB78 File Offset: 0x0013AD78
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomQualityByQuality.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomQualityByQuality.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomQuality"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomQuality` where Quality=?")
			});
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x0013CBF7 File Offset: 0x0013ADF7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomQualityByQuality.LogPair = null;
			ConfigPhantomQualityByQuality.HandleId = 0;
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x0013CC05 File Offset: 0x0013AE05
		public static void Init()
		{
			ConfigPhantomQualityByQuality.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomQualityByQuality.HandleId, "db_phantom.db", "select BinData from `PhantomQuality` where Quality=?");
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x0013CC20 File Offset: 0x0013AE20
		public static PhantomQuality? GetConfig(int p0Quality, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomQualityByQuality.HandleId, ConfigPhantomQualityByQuality.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomQualityByQuality");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Quality);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomQuality?(PhantomQuality.GetRootAsPhantomQuality(configBuffer));
				}
			}
			ConfigPhantomQualityByQuality.LogPair.Clear();
			ConfigPhantomQualityByQuality.LogPair.Add(new ValueTuple<string, object>("Quality", p0Quality));
			if (!ConfigCommon.BindInt(ConfigPhantomQualityByQuality.HandleId, 1, p0Quality, ConfigPhantomQualityByQuality.LogPair) || ConfigCommon.Step(ConfigPhantomQualityByQuality.HandleId, true, ConfigPhantomQualityByQuality.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomQualityByQuality.HandleId, ConfigPhantomQualityByQuality.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomQualityByQuality.HandleId, 0, ConfigPhantomQualityByQuality.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomQualityByQuality.HandleId, ConfigPhantomQualityByQuality.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomQuality rootAsPhantomQuality = PhantomQuality.GetRootAsPhantomQuality(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomQualityByQuality");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Quality);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomQualityByQuality.HandleId, ConfigPhantomQualityByQuality.LogPair);
			return new PhantomQuality?(rootAsPhantomQuality);
		}

		// Token: 0x04002EAF RID: 11951
		private const string DB = "db_phantom.db";

		// Token: 0x04002EB0 RID: 11952
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002EB1 RID: 11953
		private const string TABLE = "PhantomQuality";

		// Token: 0x04002EB2 RID: 11954
		private const string COMMAND = "select BinData from `PhantomQuality` where Quality=?";

		// Token: 0x04002EB3 RID: 11955
		private const string KEY_PREFIX = "PhantomQualityByQuality";

		// Token: 0x04002EB4 RID: 11956
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EB5 RID: 11957
		private static int HandleId;
	}
}
