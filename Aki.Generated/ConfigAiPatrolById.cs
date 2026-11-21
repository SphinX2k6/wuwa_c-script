using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200008F RID: 143
	public class ConfigAiPatrolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600035A RID: 858 RVA: 0x0006FF28 File Offset: 0x0006E128
		static ConfigAiPatrolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiPatrolById.CreateStaticDefaultValue), new Action(ConfigAiPatrolById.ResetStaticDefaultValue));
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0006FF48 File Offset: 0x0006E148
		public static void CreateStaticDefaultValue()
		{
			ConfigAiPatrolById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAiPatrolById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ai.db"),
				new ValueTuple<string, object>("文件", "a.AI巡逻.xlsx"),
				new ValueTuple<string, object>("表名", "AiPatrol"),
				new ValueTuple<string, object>("语句", "select BinData from `AiPatrol` where Id=?")
			});
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0006FFC7 File Offset: 0x0006E1C7
		public static void ResetStaticDefaultValue()
		{
			ConfigAiPatrolById.LogPair = null;
			ConfigAiPatrolById.HandleId = 0;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0006FFD5 File Offset: 0x0006E1D5
		public static void Init()
		{
			ConfigAiPatrolById.HandleId = ConfigCommon.InitDataStatement(ConfigAiPatrolById.HandleId, "db_ai.db", "select BinData from `AiPatrol` where Id=?");
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0006FFF0 File Offset: 0x0006E1F0
		public static AiPatrol? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAiPatrolById.HandleId, ConfigAiPatrolById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiPatrolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AiPatrol?(AiPatrol.GetRootAsAiPatrol(configBuffer));
				}
			}
			ConfigAiPatrolById.LogPair.Clear();
			ConfigAiPatrolById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAiPatrolById.HandleId, 1, p0Id, ConfigAiPatrolById.LogPair) || ConfigCommon.Step(ConfigAiPatrolById.HandleId, true, ConfigAiPatrolById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAiPatrolById.HandleId, ConfigAiPatrolById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAiPatrolById.HandleId, 0, ConfigAiPatrolById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAiPatrolById.HandleId, ConfigAiPatrolById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AiPatrol rootAsAiPatrol = AiPatrol.GetRootAsAiPatrol(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiPatrolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAiPatrolById.HandleId, ConfigAiPatrolById.LogPair);
			return new AiPatrol?(rootAsAiPatrol);
		}

		// Token: 0x040003CD RID: 973
		private const string DB = "db_ai.db";

		// Token: 0x040003CE RID: 974
		private const string FILE = "a.AI巡逻.xlsx";

		// Token: 0x040003CF RID: 975
		private const string TABLE = "AiPatrol";

		// Token: 0x040003D0 RID: 976
		private const string COMMAND = "select BinData from `AiPatrol` where Id=?";

		// Token: 0x040003D1 RID: 977
		private const string KEY_PREFIX = "AiPatrolById";

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
