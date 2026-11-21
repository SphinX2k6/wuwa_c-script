using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000989 RID: 2441
	public class ConfigSkillConditionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003949 RID: 14665 RVA: 0x001A06D3 File Offset: 0x0019E8D3
		static ConfigSkillConditionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillConditionById.CreateStaticDefaultValue), new Action(ConfigSkillConditionById.ResetStaticDefaultValue));
		}

		// Token: 0x0600394A RID: 14666 RVA: 0x001A06F4 File Offset: 0x0019E8F4
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillConditionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillConditionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skilltree.db"),
				new ValueTuple<string, object>("文件", "j.技能树.xlsx"),
				new ValueTuple<string, object>("表名", "SkillCondition"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillCondition` where Id = ?")
			});
		}

		// Token: 0x0600394B RID: 14667 RVA: 0x001A0773 File Offset: 0x0019E973
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillConditionById.LogPair = null;
			ConfigSkillConditionById.HandleId = 0;
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x001A0781 File Offset: 0x0019E981
		public static void Init()
		{
			ConfigSkillConditionById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillConditionById.HandleId, "db_skilltree.db", "select BinData from `SkillCondition` where Id = ?");
		}

		// Token: 0x0600394D RID: 14669 RVA: 0x001A079C File Offset: 0x0019E99C
		public static SkillCondition? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillConditionById.HandleId, ConfigSkillConditionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillConditionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SkillCondition?(SkillCondition.GetRootAsSkillCondition(configBuffer));
				}
			}
			ConfigSkillConditionById.LogPair.Clear();
			ConfigSkillConditionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSkillConditionById.HandleId, 1, p0Id, ConfigSkillConditionById.LogPair) || ConfigCommon.Step(ConfigSkillConditionById.HandleId, true, ConfigSkillConditionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSkillConditionById.HandleId, ConfigSkillConditionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillConditionById.HandleId, 0, ConfigSkillConditionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSkillConditionById.HandleId, ConfigSkillConditionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SkillCondition rootAsSkillCondition = SkillCondition.GetRootAsSkillCondition(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillConditionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSkillConditionById.HandleId, ConfigSkillConditionById.LogPair);
			return new SkillCondition?(rootAsSkillCondition);
		}

		// Token: 0x040042A5 RID: 17061
		private const string DB = "db_skilltree.db";

		// Token: 0x040042A6 RID: 17062
		private const string FILE = "j.技能树.xlsx";

		// Token: 0x040042A7 RID: 17063
		private const string TABLE = "SkillCondition";

		// Token: 0x040042A8 RID: 17064
		private const string COMMAND = "select BinData from `SkillCondition` where Id = ?";

		// Token: 0x040042A9 RID: 17065
		private const string KEY_PREFIX = "SkillConditionById";

		// Token: 0x040042AA RID: 17066
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042AB RID: 17067
		private static int HandleId;
	}
}
