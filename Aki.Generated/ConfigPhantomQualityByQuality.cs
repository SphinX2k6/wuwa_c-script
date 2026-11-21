using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006C7 RID: 1735
	public class ConfigPhantomQualityByQuality : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028BA RID: 10426 RVA: 0x001435D4 File Offset: 0x001417D4
		static ConfigPhantomQualityByQuality()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomQualityByQuality.CreateStaticDefaultValue), new Action(ConfigPhantomQualityByQuality.ResetStaticDefaultValue));
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x001435F4 File Offset: 0x001417F4
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

		// Token: 0x060028BC RID: 10428 RVA: 0x00143673 File Offset: 0x00141873
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomQualityByQuality.LogPair = null;
			ConfigPhantomQualityByQuality.HandleId = 0;
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x00143681 File Offset: 0x00141881
		public static void Init()
		{
			ConfigPhantomQualityByQuality.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomQualityByQuality.HandleId, "db_phantom.db", "select BinData from `PhantomQuality` where Quality=?");
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x0014369C File Offset: 0x0014189C
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

		// Token: 0x04002F57 RID: 12119
		private const string DB = "db_phantom.db";

		// Token: 0x04002F58 RID: 12120
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002F59 RID: 12121
		private const string TABLE = "PhantomQuality";

		// Token: 0x04002F5A RID: 12122
		private const string COMMAND = "select BinData from `PhantomQuality` where Quality=?";

		// Token: 0x04002F5B RID: 12123
		private const string KEY_PREFIX = "PhantomQualityByQuality";

		// Token: 0x04002F5C RID: 12124
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F5D RID: 12125
		private static int HandleId;
	}
}
