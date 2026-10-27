using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001F1 RID: 497
	public class ConfigDangoSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BA9 RID: 2985 RVA: 0x0009BA0C File Offset: 0x00099C0C
		static ConfigDangoSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoSkillById.CreateStaticDefaultValue), new Action(ConfigDangoSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0009BA2C File Offset: 0x00099C2C
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoSkillById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoSkillById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dango.db"),
				new ValueTuple<string, object>("文件", "t.团子.xlsx"),
				new ValueTuple<string, object>("表名", "DangoSkill"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoSkill` where Id=?")
			});
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0009BAAB File Offset: 0x00099CAB
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoSkillById.LogPair = null;
			ConfigDangoSkillById.HandleId = 0;
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x0009BAB9 File Offset: 0x00099CB9
		public static void Init()
		{
			ConfigDangoSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoSkillById.HandleId, "db_dango.db", "select BinData from `DangoSkill` where Id=?");
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0009BAD4 File Offset: 0x00099CD4
		public static DangoSkill? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoSkillById.HandleId, ConfigDangoSkillById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoSkill?(DangoSkill.GetRootAsDangoSkill(configBuffer));
				}
			}
			ConfigDangoSkillById.LogPair.Clear();
			ConfigDangoSkillById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoSkillById.HandleId, 1, p0Id, ConfigDangoSkillById.LogPair) || ConfigCommon.Step(ConfigDangoSkillById.HandleId, true, ConfigDangoSkillById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoSkillById.HandleId, ConfigDangoSkillById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoSkillById.HandleId, 0, ConfigDangoSkillById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoSkillById.HandleId, ConfigDangoSkillById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoSkill rootAsDangoSkill = DangoSkill.GetRootAsDangoSkill(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoSkillById.HandleId, ConfigDangoSkillById.LogPair);
			return new DangoSkill?(rootAsDangoSkill);
		}

		// Token: 0x04000D7B RID: 3451
		private const string DB = "db_dango.db";

		// Token: 0x04000D7C RID: 3452
		private const string FILE = "t.团子.xlsx";

		// Token: 0x04000D7D RID: 3453
		private const string TABLE = "DangoSkill";

		// Token: 0x04000D7E RID: 3454
		private const string COMMAND = "select BinData from `DangoSkill` where Id=?";

		// Token: 0x04000D7F RID: 3455
		private const string KEY_PREFIX = "DangoSkillById";

		// Token: 0x04000D80 RID: 3456
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D81 RID: 3457
		private static int HandleId;
	}
}
