using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009D8 RID: 2520
	public class ConfigSolarSchoolExamChoiceByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B24 RID: 15140 RVA: 0x001AB0C4 File Offset: 0x001A92C4
		static ConfigSolarSchoolExamChoiceByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolExamChoiceByGroupId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolExamChoiceByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06003B25 RID: 15141 RVA: 0x001AB0E4 File Offset: 0x001A92E4
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolExamChoiceByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolExamChoiceByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolExamChoice"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolExamChoice` where GroupId=?")
			});
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x001AB163 File Offset: 0x001A9363
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolExamChoiceByGroupId.LogPair = null;
			ConfigSolarSchoolExamChoiceByGroupId.HandleId = 0;
		}

		// Token: 0x06003B27 RID: 15143 RVA: 0x001AB171 File Offset: 0x001A9371
		public static void Init()
		{
			ConfigSolarSchoolExamChoiceByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolExamChoiceByGroupId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolExamChoice` where GroupId=?");
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x001AB18C File Offset: 0x001A938C
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolExamChoice> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolExamChoiceByGroupId.HandleId, ConfigSolarSchoolExamChoiceByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolExamChoiceByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<SolarSchoolExamChoice> readOnlyList = (IReadOnlyList<SolarSchoolExamChoice>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolExamChoiceByGroupId.LogPair.Clear();
			ConfigSolarSchoolExamChoiceByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolExamChoiceByGroupId.HandleId, 1, p0GroupId, ConfigSolarSchoolExamChoiceByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolExamChoiceByGroupId.HandleId, ConfigSolarSchoolExamChoiceByGroupId.LogPair);
				return null;
			}
			List<SolarSchoolExamChoice> list = new List<SolarSchoolExamChoice>();
			while (ConfigCommon.Step(ConfigSolarSchoolExamChoiceByGroupId.HandleId, false, ConfigSolarSchoolExamChoiceByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolExamChoiceByGroupId.HandleId, 0, ConfigSolarSchoolExamChoiceByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolExamChoiceByGroupId.HandleId, ConfigSolarSchoolExamChoiceByGroupId.LogPair);
					return null;
				}
				SolarSchoolExamChoice rootAsSolarSchoolExamChoice = SolarSchoolExamChoice.GetRootAsSolarSchoolExamChoice(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolExamChoice);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolExamChoiceByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolExamChoiceByGroupId.HandleId, ConfigSolarSchoolExamChoiceByGroupId.LogPair);
			return list;
		}

		// Token: 0x040044CE RID: 17614
		private const string DB = "db_solarschool.db";

		// Token: 0x040044CF RID: 17615
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x040044D0 RID: 17616
		private const string TABLE = "SolarSchoolExamChoice";

		// Token: 0x040044D1 RID: 17617
		private const string COMMAND = "select BinData from `SolarSchoolExamChoice` where GroupId=?";

		// Token: 0x040044D2 RID: 17618
		private const string KEY_PREFIX = "SolarSchoolExamChoiceByGroupId";

		// Token: 0x040044D3 RID: 17619
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044D4 RID: 17620
		private static int HandleId;
	}
}
