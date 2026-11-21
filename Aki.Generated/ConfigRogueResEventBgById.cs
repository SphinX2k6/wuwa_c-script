using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000861 RID: 2145
	public class ConfigRogueResEventBgById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003258 RID: 12888 RVA: 0x001798F0 File Offset: 0x00177AF0
		static ConfigRogueResEventBgById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEventBgById.CreateStaticDefaultValue), new Action(ConfigRogueResEventBgById.ResetStaticDefaultValue));
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x00179910 File Offset: 0x00177B10
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResEventBgById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResEventBgById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResEventBg"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResEventBg` where Id=?")
			});
		}

		// Token: 0x0600325A RID: 12890 RVA: 0x0017998F File Offset: 0x00177B8F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEventBgById.LogPair = null;
			ConfigRogueResEventBgById.HandleId = 0;
		}

		// Token: 0x0600325B RID: 12891 RVA: 0x0017999D File Offset: 0x00177B9D
		public static void Init()
		{
			ConfigRogueResEventBgById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEventBgById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEventBg` where Id=?");
		}

		// Token: 0x0600325C RID: 12892 RVA: 0x001799B8 File Offset: 0x00177BB8
		public static RogueResEventBg? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResEventBgById.HandleId, ConfigRogueResEventBgById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEventBgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResEventBg?(RogueResEventBg.GetRootAsRogueResEventBg(configBuffer));
				}
			}
			ConfigRogueResEventBgById.LogPair.Clear();
			ConfigRogueResEventBgById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResEventBgById.HandleId, 1, p0Id, ConfigRogueResEventBgById.LogPair) || ConfigCommon.Step(ConfigRogueResEventBgById.HandleId, true, ConfigRogueResEventBgById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResEventBgById.HandleId, ConfigRogueResEventBgById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResEventBgById.HandleId, 0, ConfigRogueResEventBgById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResEventBgById.HandleId, ConfigRogueResEventBgById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResEventBg rootAsRogueResEventBg = RogueResEventBg.GetRootAsRogueResEventBg(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEventBgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResEventBgById.HandleId, ConfigRogueResEventBgById.LogPair);
			return new RogueResEventBg?(rootAsRogueResEventBg);
		}

		// Token: 0x04003A8D RID: 14989
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A8E RID: 14990
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A8F RID: 14991
		private const string TABLE = "RogueResEventBg";

		// Token: 0x04003A90 RID: 14992
		private const string COMMAND = "select BinData from `RogueResEventBg` where Id=?";

		// Token: 0x04003A91 RID: 14993
		private const string KEY_PREFIX = "RogueResEventBgById";

		// Token: 0x04003A92 RID: 14994
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A93 RID: 14995
		private static int HandleId;
	}
}
