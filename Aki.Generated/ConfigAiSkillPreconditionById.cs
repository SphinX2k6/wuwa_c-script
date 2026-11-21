using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000093 RID: 147
	public class ConfigAiSkillPreconditionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000372 RID: 882 RVA: 0x00070848 File Offset: 0x0006EA48
		static ConfigAiSkillPreconditionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiSkillPreconditionById.CreateStaticDefaultValue), new Action(ConfigAiSkillPreconditionById.ResetStaticDefaultValue));
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00070868 File Offset: 0x0006EA68
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

		// Token: 0x06000374 RID: 884 RVA: 0x000708E7 File Offset: 0x0006EAE7
		public static void ResetStaticDefaultValue()
		{
			ConfigAiSkillPreconditionById.LogPair = null;
			ConfigAiSkillPreconditionById.HandleId = 0;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x000708F5 File Offset: 0x0006EAF5
		public static void Init()
		{
			ConfigAiSkillPreconditionById.HandleId = ConfigCommon.InitDataStatement(ConfigAiSkillPreconditionById.HandleId, "db_ai.db", "select BinData from `AiSkillPrecondition` where Id=?");
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00070910 File Offset: 0x0006EB10
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

		// Token: 0x040003E9 RID: 1001
		private const string DB = "db_ai.db";

		// Token: 0x040003EA RID: 1002
		private const string FILE = "a.AI随机技能前置条件.xlsx";

		// Token: 0x040003EB RID: 1003
		private const string TABLE = "AiSkillPrecondition";

		// Token: 0x040003EC RID: 1004
		private const string COMMAND = "select BinData from `AiSkillPrecondition` where Id=?";

		// Token: 0x040003ED RID: 1005
		private const string KEY_PREFIX = "AiSkillPreconditionById";

		// Token: 0x040003EE RID: 1006
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003EF RID: 1007
		private static int HandleId;
	}
}
