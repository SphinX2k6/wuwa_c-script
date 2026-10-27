using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200093E RID: 2366
	public class ConfigSkillConditionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003787 RID: 14215 RVA: 0x001934B3 File Offset: 0x001916B3
		static ConfigSkillConditionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillConditionById.CreateStaticDefaultValue), new Action(ConfigSkillConditionById.ResetStaticDefaultValue));
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x001934D4 File Offset: 0x001916D4
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

		// Token: 0x06003789 RID: 14217 RVA: 0x00193553 File Offset: 0x00191753
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillConditionById.LogPair = null;
			ConfigSkillConditionById.HandleId = 0;
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x00193561 File Offset: 0x00191761
		public static void Init()
		{
			ConfigSkillConditionById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillConditionById.HandleId, "db_skilltree.db", "select BinData from `SkillCondition` where Id = ?");
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x0019357C File Offset: 0x0019177C
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

		// Token: 0x04004098 RID: 16536
		private const string DB = "db_skilltree.db";

		// Token: 0x04004099 RID: 16537
		private const string FILE = "j.技能树.xlsx";

		// Token: 0x0400409A RID: 16538
		private const string TABLE = "SkillCondition";

		// Token: 0x0400409B RID: 16539
		private const string COMMAND = "select BinData from `SkillCondition` where Id = ?";

		// Token: 0x0400409C RID: 16540
		private const string KEY_PREFIX = "SkillConditionById";

		// Token: 0x0400409D RID: 16541
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400409E RID: 16542
		private static int HandleId;
	}
}
