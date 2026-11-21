using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001F5 RID: 501
	public class ConfigDangoBrawlSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BC1 RID: 3009 RVA: 0x0009F9A4 File Offset: 0x0009DBA4
		static ConfigDangoBrawlSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlSkillById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0009F9C4 File Offset: 0x0009DBC4
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlSkillById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlSkillById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗战斗.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlSkill"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlSkill` where Id=?")
			});
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0009FA43 File Offset: 0x0009DC43
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlSkillById.LogPair = null;
			ConfigDangoBrawlSkillById.HandleId = 0;
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0009FA51 File Offset: 0x0009DC51
		public static void Init()
		{
			ConfigDangoBrawlSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlSkillById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlSkill` where Id=?");
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0009FA6C File Offset: 0x0009DC6C
		public static DangoBrawlSkill? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlSkillById.HandleId, ConfigDangoBrawlSkillById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlSkill?(DangoBrawlSkill.GetRootAsDangoBrawlSkill(configBuffer));
				}
			}
			ConfigDangoBrawlSkillById.LogPair.Clear();
			ConfigDangoBrawlSkillById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlSkillById.HandleId, 1, p0Id, ConfigDangoBrawlSkillById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlSkillById.HandleId, true, ConfigDangoBrawlSkillById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlSkillById.HandleId, ConfigDangoBrawlSkillById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlSkillById.HandleId, 0, ConfigDangoBrawlSkillById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlSkillById.HandleId, ConfigDangoBrawlSkillById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlSkill rootAsDangoBrawlSkill = DangoBrawlSkill.GetRootAsDangoBrawlSkill(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlSkillById.HandleId, ConfigDangoBrawlSkillById.LogPair);
			return new DangoBrawlSkill?(rootAsDangoBrawlSkill);
		}

		// Token: 0x04000D97 RID: 3479
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D98 RID: 3480
		private const string FILE = "t.团子乱斗战斗.xlsx";

		// Token: 0x04000D99 RID: 3481
		private const string TABLE = "DangoBrawlSkill";

		// Token: 0x04000D9A RID: 3482
		private const string COMMAND = "select BinData from `DangoBrawlSkill` where Id=?";

		// Token: 0x04000D9B RID: 3483
		private const string KEY_PREFIX = "DangoBrawlSkillById";

		// Token: 0x04000D9C RID: 3484
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D9D RID: 3485
		private static int HandleId;
	}
}
