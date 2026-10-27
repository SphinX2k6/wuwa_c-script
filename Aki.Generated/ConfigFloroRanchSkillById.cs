using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000325 RID: 805
	public class ConfigFloroRanchSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012E3 RID: 4835 RVA: 0x000C4267 File Offset: 0x000C2467
		static ConfigFloroRanchSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchSkillById.CreateStaticDefaultValue), new Action(ConfigFloroRanchSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x000C4288 File Offset: 0x000C2488
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchSkillById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchSkillById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchSkill"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchSkill` where Id=?")
			});
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x000C4307 File Offset: 0x000C2507
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchSkillById.LogPair = null;
			ConfigFloroRanchSkillById.HandleId = 0;
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x000C4315 File Offset: 0x000C2515
		public static void Init()
		{
			ConfigFloroRanchSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchSkillById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchSkill` where Id=?");
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x000C4330 File Offset: 0x000C2530
		public static FloroRanchSkill? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchSkillById.HandleId, ConfigFloroRanchSkillById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchSkill?(FloroRanchSkill.GetRootAsFloroRanchSkill(configBuffer));
				}
			}
			ConfigFloroRanchSkillById.LogPair.Clear();
			ConfigFloroRanchSkillById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchSkillById.HandleId, 1, p0Id, ConfigFloroRanchSkillById.LogPair) || ConfigCommon.Step(ConfigFloroRanchSkillById.HandleId, true, ConfigFloroRanchSkillById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchSkillById.HandleId, ConfigFloroRanchSkillById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchSkillById.HandleId, 0, ConfigFloroRanchSkillById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchSkillById.HandleId, ConfigFloroRanchSkillById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchSkill rootAsFloroRanchSkill = FloroRanchSkill.GetRootAsFloroRanchSkill(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchSkillById.HandleId, ConfigFloroRanchSkillById.LogPair);
			return new FloroRanchSkill?(rootAsFloroRanchSkill);
		}

		// Token: 0x040015E7 RID: 5607
		private const string DB = "db_flororanch.db";

		// Token: 0x040015E8 RID: 5608
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040015E9 RID: 5609
		private const string TABLE = "FloroRanchSkill";

		// Token: 0x040015EA RID: 5610
		private const string COMMAND = "select BinData from `FloroRanchSkill` where Id=?";

		// Token: 0x040015EB RID: 5611
		private const string KEY_PREFIX = "FloroRanchSkillById";

		// Token: 0x040015EC RID: 5612
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015ED RID: 5613
		private static int HandleId;
	}
}
