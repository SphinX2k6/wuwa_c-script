using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200008A RID: 138
	public class ConfigAiSkillInfosById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600033C RID: 828 RVA: 0x0006BD4C File Offset: 0x00069F4C
		static ConfigAiSkillInfosById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiSkillInfosById.CreateStaticDefaultValue), new Action(ConfigAiSkillInfosById.ResetStaticDefaultValue));
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0006BD6C File Offset: 0x00069F6C
		public static void CreateStaticDefaultValue()
		{
			ConfigAiSkillInfosById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAiSkillInfosById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ai.db"),
				new ValueTuple<string, object>("文件", "a.AI随机技能表.xlsx"),
				new ValueTuple<string, object>("表名", "AiSkillInfos"),
				new ValueTuple<string, object>("语句", "select BinData from `AiSkillInfos` where Id=?")
			});
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0006BDEB File Offset: 0x00069FEB
		public static void ResetStaticDefaultValue()
		{
			ConfigAiSkillInfosById.LogPair = null;
			ConfigAiSkillInfosById.HandleId = 0;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0006BDF9 File Offset: 0x00069FF9
		public static void Init()
		{
			ConfigAiSkillInfosById.HandleId = ConfigCommon.InitDataStatement(ConfigAiSkillInfosById.HandleId, "db_ai.db", "select BinData from `AiSkillInfos` where Id=?");
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0006BE14 File Offset: 0x0006A014
		public static AiSkillInfos? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAiSkillInfosById.HandleId, ConfigAiSkillInfosById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiSkillInfosById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AiSkillInfos?(AiSkillInfos.GetRootAsAiSkillInfos(configBuffer));
				}
			}
			ConfigAiSkillInfosById.LogPair.Clear();
			ConfigAiSkillInfosById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAiSkillInfosById.HandleId, 1, p0Id, ConfigAiSkillInfosById.LogPair) || ConfigCommon.Step(ConfigAiSkillInfosById.HandleId, true, ConfigAiSkillInfosById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAiSkillInfosById.HandleId, ConfigAiSkillInfosById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAiSkillInfosById.HandleId, 0, ConfigAiSkillInfosById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAiSkillInfosById.HandleId, ConfigAiSkillInfosById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AiSkillInfos rootAsAiSkillInfos = AiSkillInfos.GetRootAsAiSkillInfos(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiSkillInfosById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAiSkillInfosById.HandleId, ConfigAiSkillInfosById.LogPair);
			return new AiSkillInfos?(rootAsAiSkillInfos);
		}

		// Token: 0x040003AA RID: 938
		private const string DB = "db_ai.db";

		// Token: 0x040003AB RID: 939
		private const string FILE = "a.AI随机技能表.xlsx";

		// Token: 0x040003AC RID: 940
		private const string TABLE = "AiSkillInfos";

		// Token: 0x040003AD RID: 941
		private const string COMMAND = "select BinData from `AiSkillInfos` where Id=?";

		// Token: 0x040003AE RID: 942
		private const string KEY_PREFIX = "AiSkillInfosById";

		// Token: 0x040003AF RID: 943
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003B0 RID: 944
		private static int HandleId;
	}
}
