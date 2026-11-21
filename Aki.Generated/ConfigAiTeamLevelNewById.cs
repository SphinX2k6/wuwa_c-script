using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000097 RID: 151
	public class ConfigAiTeamLevelNewById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600038A RID: 906 RVA: 0x00071118 File Offset: 0x0006F318
		static ConfigAiTeamLevelNewById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiTeamLevelNewById.CreateStaticDefaultValue), new Action(ConfigAiTeamLevelNewById.ResetStaticDefaultValue));
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00071138 File Offset: 0x0006F338
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

		// Token: 0x0600038C RID: 908 RVA: 0x000711B7 File Offset: 0x0006F3B7
		public static void ResetStaticDefaultValue()
		{
			ConfigAiTeamLevelNewById.LogPair = null;
			ConfigAiTeamLevelNewById.HandleId = 0;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x000711C5 File Offset: 0x0006F3C5
		public static void Init()
		{
			ConfigAiTeamLevelNewById.HandleId = ConfigCommon.InitDataStatement(ConfigAiTeamLevelNewById.HandleId, "db_ai.db", "select BinData from `AiTeamLevelNew` where Id=?");
		}

		// Token: 0x0600038E RID: 910 RVA: 0x000711E0 File Offset: 0x0006F3E0
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

		// Token: 0x04000405 RID: 1029
		private const string DB = "db_ai.db";

		// Token: 0x04000406 RID: 1030
		private const string FILE = "a.AI集群总表.xlsx";

		// Token: 0x04000407 RID: 1031
		private const string TABLE = "AiTeamLevelNew";

		// Token: 0x04000408 RID: 1032
		private const string COMMAND = "select BinData from `AiTeamLevelNew` where Id=?";

		// Token: 0x04000409 RID: 1033
		private const string KEY_PREFIX = "AiTeamLevelNewById";

		// Token: 0x0400040A RID: 1034
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400040B RID: 1035
		private static int HandleId;
	}
}
