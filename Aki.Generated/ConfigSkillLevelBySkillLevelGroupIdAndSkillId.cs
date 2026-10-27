using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000946 RID: 2374
	public class ConfigSkillLevelBySkillLevelGroupIdAndSkillId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037B7 RID: 14263 RVA: 0x001946B3 File Offset: 0x001928B3
		static ConfigSkillLevelBySkillLevelGroupIdAndSkillId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillLevelBySkillLevelGroupIdAndSkillId.CreateStaticDefaultValue), new Action(ConfigSkillLevelBySkillLevelGroupIdAndSkillId.ResetStaticDefaultValue));
		}

		// Token: 0x060037B8 RID: 14264 RVA: 0x001946D4 File Offset: 0x001928D4
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillLevelBySkillLevelGroupIdAndSkillId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillLevelBySkillLevelGroupIdAndSkillId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skill.db"),
				new ValueTuple<string, object>("文件", "j.技能.xlsx"),
				new ValueTuple<string, object>("表名", "SkillLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillLevel` where SkillLevelGroupId = ? AND SkillId = ?")
			});
		}

		// Token: 0x060037B9 RID: 14265 RVA: 0x00194753 File Offset: 0x00192953
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillLevelBySkillLevelGroupIdAndSkillId.LogPair = null;
			ConfigSkillLevelBySkillLevelGroupIdAndSkillId.HandleId = 0;
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x00194761 File Offset: 0x00192961
		public static void Init()
		{
			ConfigSkillLevelBySkillLevelGroupIdAndSkillId.HandleId = ConfigCommon.InitDataStatement(ConfigSkillLevelBySkillLevelGroupIdAndSkillId.HandleId, "db_skill.db", "select BinData from `SkillLevel` where SkillLevelGroupId = ? AND SkillId = ?");
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x0019477C File Offset: 0x0019297C
		public static SkillLevel? GetConfig(int p0SkillLevelGroupId, int p1SkillId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillLevelBySkillLevelGroupIdAndSkillId.HandleId, ConfigSkillLevelBySkillLevelGroupIdAndSkillId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SkillLevelBySkillLevelGroupIdAndSkillId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkillLevelGroupId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1SkillId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SkillLevel?(SkillLevel.GetRootAsSkillLevel(configBuffer));
				}
			}
			ConfigSkillLevelBySkillLevelGroupIdAndSkillId.LogPair.Clear();
			ConfigSkillLevelBySkillLevelGroupIdAndSkillId.LogPair.Add(new ValueTuple<string, object>("SkillLevelGroupId", p0SkillLevelGroupId));
			ConfigSkillLevelBySkillLevelGroupIdAndSkillId.LogPair.Add(new ValueTuple<string, object>("SkillId", p1SkillId));
			if (!ConfigCommon.BindInt(ConfigSkillLevelBySkillLevelGroupIdAndSkillId.HandleId, 1, p0SkillLevelGroupId, ConfigSkillLevelBySkillLevelGroupIdAndSkillId.LogPair) || !ConfigCommon.BindInt(ConfigSkillLevelBySkillLevelGroupIdAndSkillId.HandleId, 2, p1SkillId, ConfigSkillLevelBySkillLevelGroupIdAndSkillId.LogPair) || ConfigCommon.Step(ConfigSkillLevelBySkillLevelGroupIdAndSkillId.HandleId, true, ConfigSkillLevelBySkillLevelGroupIdAndSkillId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSkillLevelBySkillLevelGroupIdAndSkillId.HandleId, ConfigSkillLevelBySkillLevelGroupIdAndSkillId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillLevelBySkillLevelGroupIdAndSkillId.HandleId, 0, ConfigSkillLevelBySkillLevelGroupIdAndSkillId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSkillLevelBySkillLevelGroupIdAndSkillId.HandleId, ConfigSkillLevelBySkillLevelGroupIdAndSkillId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SkillLevel rootAsSkillLevel = SkillLevel.GetRootAsSkillLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SkillLevelBySkillLevelGroupIdAndSkillId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkillLevelGroupId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1SkillId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSkillLevelBySkillLevelGroupIdAndSkillId.HandleId, ConfigSkillLevelBySkillLevelGroupIdAndSkillId.LogPair);
			return new SkillLevel?(rootAsSkillLevel);
		}

		// Token: 0x040040D0 RID: 16592
		private const string DB = "db_skill.db";

		// Token: 0x040040D1 RID: 16593
		private const string FILE = "j.技能.xlsx";

		// Token: 0x040040D2 RID: 16594
		private const string TABLE = "SkillLevel";

		// Token: 0x040040D3 RID: 16595
		private const string COMMAND = "select BinData from `SkillLevel` where SkillLevelGroupId = ? AND SkillId = ?";

		// Token: 0x040040D4 RID: 16596
		private const string KEY_PREFIX = "SkillLevelBySkillLevelGroupIdAndSkillId";

		// Token: 0x040040D5 RID: 16597
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040D6 RID: 16598
		private static int HandleId;
	}
}
