using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200008B RID: 139
	public class ConfigAiSkillPreconditionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000342 RID: 834 RVA: 0x0006BF94 File Offset: 0x0006A194
		static ConfigAiSkillPreconditionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiSkillPreconditionById.CreateStaticDefaultValue), new Action(ConfigAiSkillPreconditionById.ResetStaticDefaultValue));
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0006BFB4 File Offset: 0x0006A1B4
		public static void CreateStaticDefaultValue()
		{
			ConfigAiSkillPreconditionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAiSkillPreconditionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ai.db"),
				new ValueTuple<string, object>("文件", "a.AI随机技能前置条件.xlsx"),
				new ValueTuple<string, object>("表名", "AiSkillPrecondition"),
				new ValueTuple<string, object>("语句", "select BinData from `AiSkillPrecondition` where Id=?")
			});
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0006C033 File Offset: 0x0006A233
		public static void ResetStaticDefaultValue()
		{
			ConfigAiSkillPreconditionById.LogPair = null;
			ConfigAiSkillPreconditionById.HandleId = 0;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0006C041 File Offset: 0x0006A241
		public static void Init()
		{
			ConfigAiSkillPreconditionById.HandleId = ConfigCommon.InitDataStatement(ConfigAiSkillPreconditionById.HandleId, "db_ai.db", "select BinData from `AiSkillPrecondition` where Id=?");
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0006C05C File Offset: 0x0006A25C
		public static AiSkillPrecondition? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAiSkillPreconditionById.HandleId, ConfigAiSkillPreconditionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiSkillPreconditionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AiSkillPrecondition?(AiSkillPrecondition.GetRootAsAiSkillPrecondition(configBuffer));
				}
			}
			ConfigAiSkillPreconditionById.LogPair.Clear();
			ConfigAiSkillPreconditionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAiSkillPreconditionById.HandleId, 1, p0Id, ConfigAiSkillPreconditionById.LogPair) || ConfigCommon.Step(ConfigAiSkillPreconditionById.HandleId, true, ConfigAiSkillPreconditionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAiSkillPreconditionById.HandleId, ConfigAiSkillPreconditionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAiSkillPreconditionById.HandleId, 0, ConfigAiSkillPreconditionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAiSkillPreconditionById.HandleId, ConfigAiSkillPreconditionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AiSkillPrecondition rootAsAiSkillPrecondition = AiSkillPrecondition.GetRootAsAiSkillPrecondition(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiSkillPreconditionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAiSkillPreconditionById.HandleId, ConfigAiSkillPreconditionById.LogPair);
			return new AiSkillPrecondition?(rootAsAiSkillPrecondition);
		}

		// Token: 0x040003B1 RID: 945
		private const string DB = "db_ai.db";

		// Token: 0x040003B2 RID: 946
		private const string FILE = "a.AI随机技能前置条件.xlsx";

		// Token: 0x040003B3 RID: 947
		private const string TABLE = "AiSkillPrecondition";

		// Token: 0x040003B4 RID: 948
		private const string COMMAND = "select BinData from `AiSkillPrecondition` where Id=?";

		// Token: 0x040003B5 RID: 949
		private const string KEY_PREFIX = "AiSkillPreconditionById";

		// Token: 0x040003B6 RID: 950
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003B7 RID: 951
		private static int HandleId;
	}
}
