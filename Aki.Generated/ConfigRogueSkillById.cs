using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000883 RID: 2179
	public class ConfigRogueSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003324 RID: 13092 RVA: 0x0017E133 File Offset: 0x0017C333
		static ConfigRogueSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueSkillById.CreateStaticDefaultValue), new Action(ConfigRogueSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x0017E154 File Offset: 0x0017C354
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

		// Token: 0x06003326 RID: 13094 RVA: 0x0017E1D3 File Offset: 0x0017C3D3
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueSkillById.LogPair = null;
			ConfigRogueSkillById.HandleId = 0;
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x0017E1E1 File Offset: 0x0017C3E1
		public static void Init()
		{
			ConfigRogueSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueSkillById.HandleId, "db_rogue.db", "select BinData from `RogueSkill` where Id=?");
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x0017E1FC File Offset: 0x0017C3FC
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

		// Token: 0x04003B7B RID: 15227
		private const string DB = "db_rogue.db";

		// Token: 0x04003B7C RID: 15228
		private const string FILE = "r.肉鸽经典复开.xlsx";

		// Token: 0x04003B7D RID: 15229
		private const string TABLE = "RogueSkill";

		// Token: 0x04003B7E RID: 15230
		private const string COMMAND = "select BinData from `RogueSkill` where Id=?";

		// Token: 0x04003B7F RID: 15231
		private const string KEY_PREFIX = "RogueSkillById";

		// Token: 0x04003B80 RID: 15232
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B81 RID: 15233
		private static int HandleId;
	}
}
