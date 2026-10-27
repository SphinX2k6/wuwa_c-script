using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200093B RID: 2363
	public class ConfigSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003775 RID: 14197 RVA: 0x00192EA0 File Offset: 0x001910A0
		static ConfigSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillById.CreateStaticDefaultValue), new Action(ConfigSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x06003776 RID: 14198 RVA: 0x00192EC0 File Offset: 0x001910C0
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

		// Token: 0x06003777 RID: 14199 RVA: 0x00192F3F File Offset: 0x0019113F
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillById.LogPair = null;
			ConfigSkillById.HandleId = 0;
		}

		// Token: 0x06003778 RID: 14200 RVA: 0x00192F4D File Offset: 0x0019114D
		public static void Init()
		{
			ConfigSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillById.HandleId, "db_skill.db", "select BinData from `Skill` where Id = ?");
		}

		// Token: 0x06003779 RID: 14201 RVA: 0x00192F68 File Offset: 0x00191168
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

		// Token: 0x04004083 RID: 16515
		private const string DB = "db_skill.db";

		// Token: 0x04004084 RID: 16516
		private const string FILE = "j.技能.xlsx";

		// Token: 0x04004085 RID: 16517
		private const string TABLE = "Skill";

		// Token: 0x04004086 RID: 16518
		private const string COMMAND = "select BinData from `Skill` where Id = ?";

		// Token: 0x04004087 RID: 16519
		private const string KEY_PREFIX = "SkillById";

		// Token: 0x04004088 RID: 16520
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004089 RID: 16521
		private static int HandleId;
	}
}
