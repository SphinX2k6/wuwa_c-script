using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200085F RID: 2143
	public class ConfigRogueResEndAwardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600324C RID: 12876 RVA: 0x0017945F File Offset: 0x0017765F
		static ConfigRogueResEndAwardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEndAwardById.CreateStaticDefaultValue), new Action(ConfigRogueResEndAwardById.ResetStaticDefaultValue));
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x00179480 File Offset: 0x00177680
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResEndAwardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResEndAwardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResEndAward"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResEndAward` where Id=?")
			});
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x001794FF File Offset: 0x001776FF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEndAwardById.LogPair = null;
			ConfigRogueResEndAwardById.HandleId = 0;
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x0017950D File Offset: 0x0017770D
		public static void Init()
		{
			ConfigRogueResEndAwardById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEndAwardById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEndAward` where Id=?");
		}

		// Token: 0x06003250 RID: 12880 RVA: 0x00179528 File Offset: 0x00177728
		public static RogueResEndAward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResEndAwardById.HandleId, ConfigRogueResEndAwardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEndAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResEndAward?(RogueResEndAward.GetRootAsRogueResEndAward(configBuffer));
				}
			}
			ConfigRogueResEndAwardById.LogPair.Clear();
			ConfigRogueResEndAwardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResEndAwardById.HandleId, 1, p0Id, ConfigRogueResEndAwardById.LogPair) || ConfigCommon.Step(ConfigRogueResEndAwardById.HandleId, true, ConfigRogueResEndAwardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResEndAwardById.HandleId, ConfigRogueResEndAwardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResEndAwardById.HandleId, 0, ConfigRogueResEndAwardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResEndAwardById.HandleId, ConfigRogueResEndAwardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResEndAward rootAsRogueResEndAward = RogueResEndAward.GetRootAsRogueResEndAward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEndAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResEndAwardById.HandleId, ConfigRogueResEndAwardById.LogPair);
			return new RogueResEndAward?(rootAsRogueResEndAward);
		}

		// Token: 0x04003A7F RID: 14975
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A80 RID: 14976
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A81 RID: 14977
		private const string TABLE = "RogueResEndAward";

		// Token: 0x04003A82 RID: 14978
		private const string COMMAND = "select BinData from `RogueResEndAward` where Id=?";

		// Token: 0x04003A83 RID: 14979
		private const string KEY_PREFIX = "RogueResEndAwardById";

		// Token: 0x04003A84 RID: 14980
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A85 RID: 14981
		private static int HandleId;
	}
}
