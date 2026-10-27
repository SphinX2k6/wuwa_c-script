using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000876 RID: 2166
	public class ConfigRogueWeeklyParamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032D6 RID: 13014 RVA: 0x00178CDF File Offset: 0x00176EDF
		static ConfigRogueWeeklyParamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyParamById.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyParamById.ResetStaticDefaultValue));
		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x00178D00 File Offset: 0x00176F00
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeeklyParamById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeeklyParamById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeeklyParam"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeeklyParam` where Id=?")
			});
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x00178D7F File Offset: 0x00176F7F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyParamById.LogPair = null;
			ConfigRogueWeeklyParamById.HandleId = 0;
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x00178D8D File Offset: 0x00176F8D
		public static void Init()
		{
			ConfigRogueWeeklyParamById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyParamById.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyParam` where Id=?");
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x00178DA8 File Offset: 0x00176FA8
		public static RogueWeeklyParam? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeeklyParamById.HandleId, ConfigRogueWeeklyParamById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueWeeklyParam?(RogueWeeklyParam.GetRootAsRogueWeeklyParam(configBuffer));
				}
			}
			ConfigRogueWeeklyParamById.LogPair.Clear();
			ConfigRogueWeeklyParamById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueWeeklyParamById.HandleId, 1, p0Id, ConfigRogueWeeklyParamById.LogPair) || ConfigCommon.Step(ConfigRogueWeeklyParamById.HandleId, true, ConfigRogueWeeklyParamById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyParamById.HandleId, ConfigRogueWeeklyParamById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeeklyParamById.HandleId, 0, ConfigRogueWeeklyParamById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyParamById.HandleId, ConfigRogueWeeklyParamById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueWeeklyParam rootAsRogueWeeklyParam = RogueWeeklyParam.GetRootAsRogueWeeklyParam(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueWeeklyParamById.HandleId, ConfigRogueWeeklyParamById.LogPair);
			return new RogueWeeklyParam?(rootAsRogueWeeklyParam);
		}

		// Token: 0x04003B20 RID: 15136
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003B21 RID: 15137
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003B22 RID: 15138
		private const string TABLE = "RogueWeeklyParam";

		// Token: 0x04003B23 RID: 15139
		private const string COMMAND = "select BinData from `RogueWeeklyParam` where Id=?";

		// Token: 0x04003B24 RID: 15140
		private const string KEY_PREFIX = "RogueWeeklyParamById";

		// Token: 0x04003B25 RID: 15141
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B26 RID: 15142
		private static int HandleId;
	}
}
