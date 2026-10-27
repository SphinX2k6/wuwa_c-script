using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200095F RID: 2399
	public class ConfigSoarById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600384E RID: 14414 RVA: 0x00197E91 File Offset: 0x00196091
		static ConfigSoarById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSoarById.CreateStaticDefaultValue), new Action(ConfigSoarById.ResetStaticDefaultValue));
		}

		// Token: 0x0600384F RID: 14415 RVA: 0x00197EB0 File Offset: 0x001960B0
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

		// Token: 0x06003850 RID: 14416 RVA: 0x00197F2F File Offset: 0x0019612F
		public static void ResetStaticDefaultValue()
		{
			ConfigSoarById.LogPair = null;
			ConfigSoarById.HandleId = 0;
		}

		// Token: 0x06003851 RID: 14417 RVA: 0x00197F3D File Offset: 0x0019613D
		public static void Init()
		{
			ConfigSoarById.HandleId = ConfigCommon.InitDataStatement(ConfigSoarById.HandleId, "db_soar.db", "select BinData from `Soar` where Id=?");
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x00197F58 File Offset: 0x00196158
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

		// Token: 0x0400417F RID: 16767
		private const string DB = "db_soar.db";

		// Token: 0x04004180 RID: 16768
		private const string FILE = "a.翱翔.xlsx";

		// Token: 0x04004181 RID: 16769
		private const string TABLE = "Soar";

		// Token: 0x04004182 RID: 16770
		private const string COMMAND = "select BinData from `Soar` where Id=?";

		// Token: 0x04004183 RID: 16771
		private const string KEY_PREFIX = "SoarById";

		// Token: 0x04004184 RID: 16772
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004185 RID: 16773
		private static int HandleId;
	}
}
