using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000867 RID: 2151
	public class ConfigRogueSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600327C RID: 12924 RVA: 0x00176E4B File Offset: 0x0017504B
		static ConfigRogueSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueSkillById.CreateStaticDefaultValue), new Action(ConfigRogueSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x00176E6C File Offset: 0x0017506C
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueSkillById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueSkillById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽经典复开.xlsx"),
				new ValueTuple<string, object>("表名", "RogueSkill"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueSkill` where Id=?")
			});
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x00176EEB File Offset: 0x001750EB
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueSkillById.LogPair = null;
			ConfigRogueSkillById.HandleId = 0;
		}

		// Token: 0x0600327F RID: 12927 RVA: 0x00176EF9 File Offset: 0x001750F9
		public static void Init()
		{
			ConfigRogueSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueSkillById.HandleId, "db_rogue.db", "select BinData from `RogueSkill` where Id=?");
		}

		// Token: 0x06003280 RID: 12928 RVA: 0x00176F14 File Offset: 0x00175114
		public static RogueSkill? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueSkillById.HandleId, ConfigRogueSkillById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueSkill?(RogueSkill.GetRootAsRogueSkill(configBuffer));
				}
			}
			ConfigRogueSkillById.LogPair.Clear();
			ConfigRogueSkillById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueSkillById.HandleId, 1, p0Id, ConfigRogueSkillById.LogPair) || ConfigCommon.Step(ConfigRogueSkillById.HandleId, true, ConfigRogueSkillById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueSkillById.HandleId, ConfigRogueSkillById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueSkillById.HandleId, 0, ConfigRogueSkillById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueSkillById.HandleId, ConfigRogueSkillById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueSkill rootAsRogueSkill = RogueSkill.GetRootAsRogueSkill(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueSkillById.HandleId, ConfigRogueSkillById.LogPair);
			return new RogueSkill?(rootAsRogueSkill);
		}

		// Token: 0x04003AB7 RID: 15031
		private const string DB = "db_rogue.db";

		// Token: 0x04003AB8 RID: 15032
		private const string FILE = "r.肉鸽经典复开.xlsx";

		// Token: 0x04003AB9 RID: 15033
		private const string TABLE = "RogueSkill";

		// Token: 0x04003ABA RID: 15034
		private const string COMMAND = "select BinData from `RogueSkill` where Id=?";

		// Token: 0x04003ABB RID: 15035
		private const string KEY_PREFIX = "RogueSkillById";

		// Token: 0x04003ABC RID: 15036
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003ABD RID: 15037
		private static int HandleId;
	}
}
