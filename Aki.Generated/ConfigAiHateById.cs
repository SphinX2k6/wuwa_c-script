using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000086 RID: 134
	public class ConfigAiHateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000324 RID: 804 RVA: 0x0006B42C File Offset: 0x0006962C
		static ConfigAiHateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiHateById.CreateStaticDefaultValue), new Action(ConfigAiHateById.ResetStaticDefaultValue));
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0006B44C File Offset: 0x0006964C
		public static void CreateStaticDefaultValue()
		{
			ConfigAiHateById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAiHateById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ai.db"),
				new ValueTuple<string, object>("文件", "a.AI仇恨.xlsx"),
				new ValueTuple<string, object>("表名", "AiHate"),
				new ValueTuple<string, object>("语句", "select BinData from `AiHate` where Id=?")
			});
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0006B4CB File Offset: 0x000696CB
		public static void ResetStaticDefaultValue()
		{
			ConfigAiHateById.LogPair = null;
			ConfigAiHateById.HandleId = 0;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0006B4D9 File Offset: 0x000696D9
		public static void Init()
		{
			ConfigAiHateById.HandleId = ConfigCommon.InitDataStatement(ConfigAiHateById.HandleId, "db_ai.db", "select BinData from `AiHate` where Id=?");
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0006B4F4 File Offset: 0x000696F4
		public static AiHate? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAiHateById.HandleId, ConfigAiHateById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiHateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AiHate?(AiHate.GetRootAsAiHate(configBuffer));
				}
			}
			ConfigAiHateById.LogPair.Clear();
			ConfigAiHateById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAiHateById.HandleId, 1, p0Id, ConfigAiHateById.LogPair) || ConfigCommon.Step(ConfigAiHateById.HandleId, true, ConfigAiHateById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAiHateById.HandleId, ConfigAiHateById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAiHateById.HandleId, 0, ConfigAiHateById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAiHateById.HandleId, ConfigAiHateById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AiHate rootAsAiHate = AiHate.GetRootAsAiHate(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiHateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAiHateById.HandleId, ConfigAiHateById.LogPair);
			return new AiHate?(rootAsAiHate);
		}

		// Token: 0x0400038E RID: 910
		private const string DB = "db_ai.db";

		// Token: 0x0400038F RID: 911
		private const string FILE = "a.AI仇恨.xlsx";

		// Token: 0x04000390 RID: 912
		private const string TABLE = "AiHate";

		// Token: 0x04000391 RID: 913
		private const string COMMAND = "select BinData from `AiHate` where Id=?";

		// Token: 0x04000392 RID: 914
		private const string KEY_PREFIX = "AiHateById";

		// Token: 0x04000393 RID: 915
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000394 RID: 916
		private static int HandleId;
	}
}
