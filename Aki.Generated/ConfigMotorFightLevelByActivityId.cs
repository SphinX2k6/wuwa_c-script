using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200058F RID: 1423
	public class ConfigMotorFightLevelByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002167 RID: 8551 RVA: 0x00116550 File Offset: 0x00114750
		static ConfigMotorFightLevelByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightLevelByActivityId.CreateStaticDefaultValue), new Action(ConfigMotorFightLevelByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x00116570 File Offset: 0x00114770
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

		// Token: 0x06002169 RID: 8553 RVA: 0x001165EF File Offset: 0x001147EF
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightLevelByActivityId.LogPair = null;
			ConfigMotorFightLevelByActivityId.HandleId = 0;
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x001165FD File Offset: 0x001147FD
		public static void Init()
		{
			ConfigMotorFightLevelByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightLevelByActivityId.HandleId, "db_motorfight.db", "select BinData from `MotorFightLevel` where ActivityId=?");
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x00116618 File Offset: 0x00114818
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

		// Token: 0x040026CD RID: 9933
		private const string DB = "db_motorfight.db";

		// Token: 0x040026CE RID: 9934
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x040026CF RID: 9935
		private const string TABLE = "MotorFightLevel";

		// Token: 0x040026D0 RID: 9936
		private const string COMMAND = "select BinData from `MotorFightLevel` where ActivityId=?";

		// Token: 0x040026D1 RID: 9937
		private const string KEY_PREFIX = "MotorFightLevelByActivityId";

		// Token: 0x040026D2 RID: 9938
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026D3 RID: 9939
		private static int HandleId;
	}
}
