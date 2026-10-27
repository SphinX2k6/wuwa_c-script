using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001E3 RID: 483
	public class ConfigDangoBrawlSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B55 RID: 2901 RVA: 0x00099A6C File Offset: 0x00097C6C
		static ConfigDangoBrawlSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlSkillById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00099A8C File Offset: 0x00097C8C
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

		// Token: 0x06000B57 RID: 2903 RVA: 0x00099B0B File Offset: 0x00097D0B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlSkillById.LogPair = null;
			ConfigDangoBrawlSkillById.HandleId = 0;
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00099B19 File Offset: 0x00097D19
		public static void Init()
		{
			ConfigDangoBrawlSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlSkillById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlSkill` where Id=?");
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00099B34 File Offset: 0x00097D34
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

		// Token: 0x04000D19 RID: 3353
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D1A RID: 3354
		private const string FILE = "t.团子乱斗战斗.xlsx";

		// Token: 0x04000D1B RID: 3355
		private const string TABLE = "DangoBrawlSkill";

		// Token: 0x04000D1C RID: 3356
		private const string COMMAND = "select BinData from `DangoBrawlSkill` where Id=?";

		// Token: 0x04000D1D RID: 3357
		private const string KEY_PREFIX = "DangoBrawlSkillById";

		// Token: 0x04000D1E RID: 3358
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D1F RID: 3359
		private static int HandleId;
	}
}
