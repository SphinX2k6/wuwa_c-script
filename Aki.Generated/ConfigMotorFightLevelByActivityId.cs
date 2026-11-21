using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005A6 RID: 1446
	public class ConfigMotorFightLevelByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021F1 RID: 8689 RVA: 0x0011CE38 File Offset: 0x0011B038
		static ConfigMotorFightLevelByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightLevelByActivityId.CreateStaticDefaultValue), new Action(ConfigMotorFightLevelByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x0011CE58 File Offset: 0x0011B058
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightLevelByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightLevelByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightLevel` where ActivityId=?")
			});
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x0011CED7 File Offset: 0x0011B0D7
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightLevelByActivityId.LogPair = null;
			ConfigMotorFightLevelByActivityId.HandleId = 0;
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x0011CEE5 File Offset: 0x0011B0E5
		public static void Init()
		{
			ConfigMotorFightLevelByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightLevelByActivityId.HandleId, "db_motorfight.db", "select BinData from `MotorFightLevel` where ActivityId=?");
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x0011CF00 File Offset: 0x0011B100
		[NullableContext(2)]
		public static IReadOnlyList<MotorFightLevel> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightLevelByActivityId.HandleId, ConfigMotorFightLevelByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightLevelByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<MotorFightLevel> readOnlyList = (IReadOnlyList<MotorFightLevel>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMotorFightLevelByActivityId.LogPair.Clear();
			ConfigMotorFightLevelByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigMotorFightLevelByActivityId.HandleId, 1, p0ActivityId, ConfigMotorFightLevelByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigMotorFightLevelByActivityId.HandleId, ConfigMotorFightLevelByActivityId.LogPair);
				return null;
			}
			List<MotorFightLevel> list = new List<MotorFightLevel>();
			while (ConfigCommon.Step(ConfigMotorFightLevelByActivityId.HandleId, false, ConfigMotorFightLevelByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightLevelByActivityId.HandleId, 0, ConfigMotorFightLevelByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorFightLevelByActivityId.HandleId, ConfigMotorFightLevelByActivityId.LogPair);
					return null;
				}
				MotorFightLevel rootAsMotorFightLevel = MotorFightLevel.GetRootAsMotorFightLevel(new ByteBuffer(item2));
				list.Add(rootAsMotorFightLevel);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightLevelByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorFightLevelByActivityId.HandleId, ConfigMotorFightLevelByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400276E RID: 10094
		private const string DB = "db_motorfight.db";

		// Token: 0x0400276F RID: 10095
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x04002770 RID: 10096
		private const string TABLE = "MotorFightLevel";

		// Token: 0x04002771 RID: 10097
		private const string COMMAND = "select BinData from `MotorFightLevel` where ActivityId=?";

		// Token: 0x04002772 RID: 10098
		private const string KEY_PREFIX = "MotorFightLevelByActivityId";

		// Token: 0x04002773 RID: 10099
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002774 RID: 10100
		private static int HandleId;
	}
}
