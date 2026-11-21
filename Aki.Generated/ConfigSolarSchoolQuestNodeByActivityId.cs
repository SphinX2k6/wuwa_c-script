using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A04 RID: 2564
	public class ConfigSolarSchoolQuestNodeByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C2C RID: 15404 RVA: 0x001B0E57 File Offset: 0x001AF057
		static ConfigSolarSchoolQuestNodeByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolQuestNodeByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolQuestNodeByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x001B0E78 File Offset: 0x001AF078
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolQuestNodeByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolQuestNodeByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_任务.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolQuestNode"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolQuestNode` where ActivityId=?")
			});
		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x001B0EF7 File Offset: 0x001AF0F7
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolQuestNodeByActivityId.LogPair = null;
			ConfigSolarSchoolQuestNodeByActivityId.HandleId = 0;
		}

		// Token: 0x06003C2F RID: 15407 RVA: 0x001B0F05 File Offset: 0x001AF105
		public static void Init()
		{
			ConfigSolarSchoolQuestNodeByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolQuestNodeByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolQuestNode` where ActivityId=?");
		}

		// Token: 0x06003C30 RID: 15408 RVA: 0x001B0F20 File Offset: 0x001AF120
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolQuestNode> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolQuestNodeByActivityId.HandleId, ConfigSolarSchoolQuestNodeByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolQuestNodeByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolQuestNode> readOnlyList = (IReadOnlyList<SolarSchoolQuestNode>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolQuestNodeByActivityId.LogPair.Clear();
			ConfigSolarSchoolQuestNodeByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolQuestNodeByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolQuestNodeByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolQuestNodeByActivityId.HandleId, ConfigSolarSchoolQuestNodeByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolQuestNode> list = new List<SolarSchoolQuestNode>();
			while (ConfigCommon.Step(ConfigSolarSchoolQuestNodeByActivityId.HandleId, false, ConfigSolarSchoolQuestNodeByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolQuestNodeByActivityId.HandleId, 0, ConfigSolarSchoolQuestNodeByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolQuestNodeByActivityId.HandleId, ConfigSolarSchoolQuestNodeByActivityId.LogPair);
					return null;
				}
				SolarSchoolQuestNode rootAsSolarSchoolQuestNode = SolarSchoolQuestNode.GetRootAsSolarSchoolQuestNode(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolQuestNode);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolQuestNodeByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolQuestNodeByActivityId.HandleId, ConfigSolarSchoolQuestNodeByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004602 RID: 17922
		private const string DB = "db_solarschool.db";

		// Token: 0x04004603 RID: 17923
		private const string FILE = "d.第二索拉_任务.xlsx";

		// Token: 0x04004604 RID: 17924
		private const string TABLE = "SolarSchoolQuestNode";

		// Token: 0x04004605 RID: 17925
		private const string COMMAND = "select BinData from `SolarSchoolQuestNode` where ActivityId=?";

		// Token: 0x04004606 RID: 17926
		private const string KEY_PREFIX = "SolarSchoolQuestNodeByActivityId";

		// Token: 0x04004607 RID: 17927
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004608 RID: 17928
		private static int HandleId;
	}
}
