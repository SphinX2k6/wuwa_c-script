using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005B6 RID: 1462
	public class ConfigMotorFightTaskTabByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002251 RID: 8785 RVA: 0x0011F1C4 File Offset: 0x0011D3C4
		static ConfigMotorFightTaskTabByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightTaskTabByActivityId.CreateStaticDefaultValue), new Action(ConfigMotorFightTaskTabByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x0011F1E4 File Offset: 0x0011D3E4
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightTaskTabByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightTaskTabByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightTaskTab"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightTaskTab` where ActivityId=?")
			});
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x0011F263 File Offset: 0x0011D463
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightTaskTabByActivityId.LogPair = null;
			ConfigMotorFightTaskTabByActivityId.HandleId = 0;
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x0011F271 File Offset: 0x0011D471
		public static void Init()
		{
			ConfigMotorFightTaskTabByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightTaskTabByActivityId.HandleId, "db_motorfight.db", "select BinData from `MotorFightTaskTab` where ActivityId=?");
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x0011F28C File Offset: 0x0011D48C
		[NullableContext(2)]
		public static IReadOnlyList<MotorFightTaskTab> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightTaskTabByActivityId.HandleId, ConfigMotorFightTaskTabByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightTaskTabByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<MotorFightTaskTab> readOnlyList = (IReadOnlyList<MotorFightTaskTab>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMotorFightTaskTabByActivityId.LogPair.Clear();
			ConfigMotorFightTaskTabByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigMotorFightTaskTabByActivityId.HandleId, 1, p0ActivityId, ConfigMotorFightTaskTabByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigMotorFightTaskTabByActivityId.HandleId, ConfigMotorFightTaskTabByActivityId.LogPair);
				return null;
			}
			List<MotorFightTaskTab> list = new List<MotorFightTaskTab>();
			while (ConfigCommon.Step(ConfigMotorFightTaskTabByActivityId.HandleId, false, ConfigMotorFightTaskTabByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightTaskTabByActivityId.HandleId, 0, ConfigMotorFightTaskTabByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorFightTaskTabByActivityId.HandleId, ConfigMotorFightTaskTabByActivityId.LogPair);
					return null;
				}
				MotorFightTaskTab rootAsMotorFightTaskTab = MotorFightTaskTab.GetRootAsMotorFightTaskTab(new ByteBuffer(item2));
				list.Add(rootAsMotorFightTaskTab);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightTaskTabByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorFightTaskTabByActivityId.HandleId, ConfigMotorFightTaskTabByActivityId.LogPair);
			return list;
		}

		// Token: 0x040027DE RID: 10206
		private const string DB = "db_motorfight.db";

		// Token: 0x040027DF RID: 10207
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x040027E0 RID: 10208
		private const string TABLE = "MotorFightTaskTab";

		// Token: 0x040027E1 RID: 10209
		private const string COMMAND = "select BinData from `MotorFightTaskTab` where ActivityId=?";

		// Token: 0x040027E2 RID: 10210
		private const string KEY_PREFIX = "MotorFightTaskTabByActivityId";

		// Token: 0x040027E3 RID: 10211
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027E4 RID: 10212
		private static int HandleId;
	}
}
