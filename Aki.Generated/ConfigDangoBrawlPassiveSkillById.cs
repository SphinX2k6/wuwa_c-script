using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001E9 RID: 489
	public class ConfigDangoBrawlPassiveSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B79 RID: 2937 RVA: 0x0009DFCC File Offset: 0x0009C1CC
		static ConfigDangoBrawlPassiveSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlPassiveSkillById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlPassiveSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x0009DFEC File Offset: 0x0009C1EC
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

		// Token: 0x06000B7B RID: 2939 RVA: 0x0009E06B File Offset: 0x0009C26B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlPassiveSkillById.LogPair = null;
			ConfigDangoBrawlPassiveSkillById.HandleId = 0;
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0009E079 File Offset: 0x0009C279
		public static void Init()
		{
			ConfigDangoBrawlPassiveSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlPassiveSkillById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlPassiveSkill` where Id=?");
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0009E094 File Offset: 0x0009C294
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

		// Token: 0x04000D43 RID: 3395
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D44 RID: 3396
		private const string FILE = "t.团子乱斗战斗.xlsx";

		// Token: 0x04000D45 RID: 3397
		private const string TABLE = "DangoBrawlPassiveSkill";

		// Token: 0x04000D46 RID: 3398
		private const string COMMAND = "select BinData from `DangoBrawlPassiveSkill` where Id=?";

		// Token: 0x04000D47 RID: 3399
		private const string KEY_PREFIX = "DangoBrawlPassiveSkillById";

		// Token: 0x04000D48 RID: 3400
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D49 RID: 3401
		private static int HandleId;
	}
}
