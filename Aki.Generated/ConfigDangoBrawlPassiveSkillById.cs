using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001D7 RID: 471
	public class ConfigDangoBrawlPassiveSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B0D RID: 2829 RVA: 0x00098094 File Offset: 0x00096294
		static ConfigDangoBrawlPassiveSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlPassiveSkillById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlPassiveSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x000980B4 File Offset: 0x000962B4
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlPassiveSkillById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlPassiveSkillById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗战斗.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlPassiveSkill"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlPassiveSkill` where Id=?")
			});
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00098133 File Offset: 0x00096333
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlPassiveSkillById.LogPair = null;
			ConfigDangoBrawlPassiveSkillById.HandleId = 0;
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00098141 File Offset: 0x00096341
		public static void Init()
		{
			ConfigDangoBrawlPassiveSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlPassiveSkillById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlPassiveSkill` where Id=?");
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0009815C File Offset: 0x0009635C
		public static DangoBrawlPassiveSkill? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlPassiveSkillById.HandleId, ConfigDangoBrawlPassiveSkillById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlPassiveSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlPassiveSkill?(DangoBrawlPassiveSkill.GetRootAsDangoBrawlPassiveSkill(configBuffer));
				}
			}
			ConfigDangoBrawlPassiveSkillById.LogPair.Clear();
			ConfigDangoBrawlPassiveSkillById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlPassiveSkillById.HandleId, 1, p0Id, ConfigDangoBrawlPassiveSkillById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlPassiveSkillById.HandleId, true, ConfigDangoBrawlPassiveSkillById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlPassiveSkillById.HandleId, ConfigDangoBrawlPassiveSkillById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlPassiveSkillById.HandleId, 0, ConfigDangoBrawlPassiveSkillById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlPassiveSkillById.HandleId, ConfigDangoBrawlPassiveSkillById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlPassiveSkill rootAsDangoBrawlPassiveSkill = DangoBrawlPassiveSkill.GetRootAsDangoBrawlPassiveSkill(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlPassiveSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlPassiveSkillById.HandleId, ConfigDangoBrawlPassiveSkillById.LogPair);
			return new DangoBrawlPassiveSkill?(rootAsDangoBrawlPassiveSkill);
		}

		// Token: 0x04000CC5 RID: 3269
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CC6 RID: 3270
		private const string FILE = "t.团子乱斗战斗.xlsx";

		// Token: 0x04000CC7 RID: 3271
		private const string TABLE = "DangoBrawlPassiveSkill";

		// Token: 0x04000CC8 RID: 3272
		private const string COMMAND = "select BinData from `DangoBrawlPassiveSkill` where Id=?";

		// Token: 0x04000CC9 RID: 3273
		private const string KEY_PREFIX = "DangoBrawlPassiveSkillById";

		// Token: 0x04000CCA RID: 3274
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CCB RID: 3275
		private static int HandleId;
	}
}
