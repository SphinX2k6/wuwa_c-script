using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009D9 RID: 2521
	public class ConfigSolarSchoolExamChoiceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B2A RID: 15146 RVA: 0x001AB2FB File Offset: 0x001A94FB
		static ConfigSolarSchoolExamChoiceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolExamChoiceById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolExamChoiceById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B2B RID: 15147 RVA: 0x001AB31C File Offset: 0x001A951C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolExamChoiceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolExamChoiceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolExamChoice"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolExamChoice` where Id=?")
			});
		}

		// Token: 0x06003B2C RID: 15148 RVA: 0x001AB39B File Offset: 0x001A959B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolExamChoiceById.LogPair = null;
			ConfigSolarSchoolExamChoiceById.HandleId = 0;
		}

		// Token: 0x06003B2D RID: 15149 RVA: 0x001AB3A9 File Offset: 0x001A95A9
		public static void Init()
		{
			ConfigSolarSchoolExamChoiceById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolExamChoiceById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolExamChoice` where Id=?");
		}

		// Token: 0x06003B2E RID: 15150 RVA: 0x001AB3C4 File Offset: 0x001A95C4
		public static SolarSchoolExamChoice? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolExamChoiceById.HandleId, ConfigSolarSchoolExamChoiceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolExamChoiceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolExamChoice?(SolarSchoolExamChoice.GetRootAsSolarSchoolExamChoice(configBuffer));
				}
			}
			ConfigSolarSchoolExamChoiceById.LogPair.Clear();
			ConfigSolarSchoolExamChoiceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolExamChoiceById.HandleId, 1, p0Id, ConfigSolarSchoolExamChoiceById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolExamChoiceById.HandleId, true, ConfigSolarSchoolExamChoiceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolExamChoiceById.HandleId, ConfigSolarSchoolExamChoiceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolExamChoiceById.HandleId, 0, ConfigSolarSchoolExamChoiceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolExamChoiceById.HandleId, ConfigSolarSchoolExamChoiceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolExamChoice rootAsSolarSchoolExamChoice = SolarSchoolExamChoice.GetRootAsSolarSchoolExamChoice(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolExamChoiceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolExamChoiceById.HandleId, ConfigSolarSchoolExamChoiceById.LogPair);
			return new SolarSchoolExamChoice?(rootAsSolarSchoolExamChoice);
		}

		// Token: 0x040044D5 RID: 17621
		private const string DB = "db_solarschool.db";

		// Token: 0x040044D6 RID: 17622
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x040044D7 RID: 17623
		private const string TABLE = "SolarSchoolExamChoice";

		// Token: 0x040044D8 RID: 17624
		private const string COMMAND = "select BinData from `SolarSchoolExamChoice` where Id=?";

		// Token: 0x040044D9 RID: 17625
		private const string KEY_PREFIX = "SolarSchoolExamChoiceById";

		// Token: 0x040044DA RID: 17626
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044DB RID: 17627
		private static int HandleId;
	}
}
