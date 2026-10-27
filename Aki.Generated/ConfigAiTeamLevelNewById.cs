using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200008F RID: 143
	public class ConfigAiTeamLevelNewById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600035A RID: 858 RVA: 0x0006C864 File Offset: 0x0006AA64
		static ConfigAiTeamLevelNewById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiTeamLevelNewById.CreateStaticDefaultValue), new Action(ConfigAiTeamLevelNewById.ResetStaticDefaultValue));
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0006C884 File Offset: 0x0006AA84
		public static void CreateStaticDefaultValue()
		{
			ConfigAiTeamLevelNewById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAiTeamLevelNewById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ai.db"),
				new ValueTuple<string, object>("文件", "a.AI集群总表.xlsx"),
				new ValueTuple<string, object>("表名", "AiTeamLevelNew"),
				new ValueTuple<string, object>("语句", "select BinData from `AiTeamLevelNew` where Id=?")
			});
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0006C903 File Offset: 0x0006AB03
		public static void ResetStaticDefaultValue()
		{
			ConfigAiTeamLevelNewById.LogPair = null;
			ConfigAiTeamLevelNewById.HandleId = 0;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0006C911 File Offset: 0x0006AB11
		public static void Init()
		{
			ConfigAiTeamLevelNewById.HandleId = ConfigCommon.InitDataStatement(ConfigAiTeamLevelNewById.HandleId, "db_ai.db", "select BinData from `AiTeamLevelNew` where Id=?");
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0006C92C File Offset: 0x0006AB2C
		public static AiTeamLevelNew? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAiTeamLevelNewById.HandleId, ConfigAiTeamLevelNewById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiTeamLevelNewById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AiTeamLevelNew?(AiTeamLevelNew.GetRootAsAiTeamLevelNew(configBuffer));
				}
			}
			ConfigAiTeamLevelNewById.LogPair.Clear();
			ConfigAiTeamLevelNewById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAiTeamLevelNewById.HandleId, 1, p0Id, ConfigAiTeamLevelNewById.LogPair) || ConfigCommon.Step(ConfigAiTeamLevelNewById.HandleId, true, ConfigAiTeamLevelNewById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAiTeamLevelNewById.HandleId, ConfigAiTeamLevelNewById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAiTeamLevelNewById.HandleId, 0, ConfigAiTeamLevelNewById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAiTeamLevelNewById.HandleId, ConfigAiTeamLevelNewById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AiTeamLevelNew rootAsAiTeamLevelNew = AiTeamLevelNew.GetRootAsAiTeamLevelNew(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiTeamLevelNewById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAiTeamLevelNewById.HandleId, ConfigAiTeamLevelNewById.LogPair);
			return new AiTeamLevelNew?(rootAsAiTeamLevelNew);
		}

		// Token: 0x040003CD RID: 973
		private const string DB = "db_ai.db";

		// Token: 0x040003CE RID: 974
		private const string FILE = "a.AI集群总表.xlsx";

		// Token: 0x040003CF RID: 975
		private const string TABLE = "AiTeamLevelNew";

		// Token: 0x040003D0 RID: 976
		private const string COMMAND = "select BinData from `AiTeamLevelNew` where Id=?";

		// Token: 0x040003D1 RID: 977
		private const string KEY_PREFIX = "AiTeamLevelNewById";

		// Token: 0x040003D2 RID: 978
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003D3 RID: 979
		private static int HandleId;
	}
}
