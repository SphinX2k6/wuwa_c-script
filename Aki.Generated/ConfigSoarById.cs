using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009AA RID: 2474
	public class ConfigSoarById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A10 RID: 14864 RVA: 0x001A50B1 File Offset: 0x001A32B1
		static ConfigSoarById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSoarById.CreateStaticDefaultValue), new Action(ConfigSoarById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A11 RID: 14865 RVA: 0x001A50D0 File Offset: 0x001A32D0
		public static void CreateStaticDefaultValue()
		{
			ConfigSoarById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSoarById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_soar.db"),
				new ValueTuple<string, object>("文件", "a.翱翔.xlsx"),
				new ValueTuple<string, object>("表名", "Soar"),
				new ValueTuple<string, object>("语句", "select BinData from `Soar` where Id=?")
			});
		}

		// Token: 0x06003A12 RID: 14866 RVA: 0x001A514F File Offset: 0x001A334F
		public static void ResetStaticDefaultValue()
		{
			ConfigSoarById.LogPair = null;
			ConfigSoarById.HandleId = 0;
		}

		// Token: 0x06003A13 RID: 14867 RVA: 0x001A515D File Offset: 0x001A335D
		public static void Init()
		{
			ConfigSoarById.HandleId = ConfigCommon.InitDataStatement(ConfigSoarById.HandleId, "db_soar.db", "select BinData from `Soar` where Id=?");
		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x001A5178 File Offset: 0x001A3378
		public static Soar? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSoarById.HandleId, ConfigSoarById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("SoarById#" + p0Id);
				if (configBuffer != null)
				{
					return new Soar?(Soar.GetRootAsSoar(configBuffer));
				}
			}
			ConfigSoarById.LogPair.Clear();
			ConfigSoarById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigSoarById.HandleId, 1, p0Id, ConfigSoarById.LogPair) || ConfigCommon.Step(ConfigSoarById.HandleId, true, ConfigSoarById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSoarById.HandleId, ConfigSoarById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSoarById.HandleId, 0, ConfigSoarById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSoarById.HandleId, ConfigSoarById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Soar rootAsSoar = Soar.GetRootAsSoar(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("SoarById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSoarById.HandleId, ConfigSoarById.LogPair);
			return new Soar?(rootAsSoar);
		}

		// Token: 0x0400438C RID: 17292
		private const string DB = "db_soar.db";

		// Token: 0x0400438D RID: 17293
		private const string FILE = "a.翱翔.xlsx";

		// Token: 0x0400438E RID: 17294
		private const string TABLE = "Soar";

		// Token: 0x0400438F RID: 17295
		private const string COMMAND = "select BinData from `Soar` where Id=?";

		// Token: 0x04004390 RID: 17296
		private const string KEY_PREFIX = "SoarById";

		// Token: 0x04004391 RID: 17297
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004392 RID: 17298
		private static int HandleId;
	}
}
