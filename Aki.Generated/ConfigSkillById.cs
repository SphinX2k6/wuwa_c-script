using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000986 RID: 2438
	public class ConfigSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003937 RID: 14647 RVA: 0x001A00C0 File Offset: 0x0019E2C0
		static ConfigSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillById.CreateStaticDefaultValue), new Action(ConfigSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x06003938 RID: 14648 RVA: 0x001A00E0 File Offset: 0x0019E2E0
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skill.db"),
				new ValueTuple<string, object>("文件", "j.技能.xlsx"),
				new ValueTuple<string, object>("表名", "Skill"),
				new ValueTuple<string, object>("语句", "select BinData from `Skill` where Id = ?")
			});
		}

		// Token: 0x06003939 RID: 14649 RVA: 0x001A015F File Offset: 0x0019E35F
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillById.LogPair = null;
			ConfigSkillById.HandleId = 0;
		}

		// Token: 0x0600393A RID: 14650 RVA: 0x001A016D File Offset: 0x0019E36D
		public static void Init()
		{
			ConfigSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillById.HandleId, "db_skill.db", "select BinData from `Skill` where Id = ?");
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x001A0188 File Offset: 0x0019E388
		public static Skill? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillById.HandleId, ConfigSkillById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Skill?(Skill.GetRootAsSkill(configBuffer));
				}
			}
			ConfigSkillById.LogPair.Clear();
			ConfigSkillById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSkillById.HandleId, 1, p0Id, ConfigSkillById.LogPair) || ConfigCommon.Step(ConfigSkillById.HandleId, true, ConfigSkillById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSkillById.HandleId, ConfigSkillById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillById.HandleId, 0, ConfigSkillById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSkillById.HandleId, ConfigSkillById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Skill rootAsSkill = Skill.GetRootAsSkill(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSkillById.HandleId, ConfigSkillById.LogPair);
			return new Skill?(rootAsSkill);
		}

		// Token: 0x04004290 RID: 17040
		private const string DB = "db_skill.db";

		// Token: 0x04004291 RID: 17041
		private const string FILE = "j.技能.xlsx";

		// Token: 0x04004292 RID: 17042
		private const string TABLE = "Skill";

		// Token: 0x04004293 RID: 17043
		private const string COMMAND = "select BinData from `Skill` where Id = ?";

		// Token: 0x04004294 RID: 17044
		private const string KEY_PREFIX = "SkillById";

		// Token: 0x04004295 RID: 17045
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004296 RID: 17046
		private static int HandleId;
	}
}
