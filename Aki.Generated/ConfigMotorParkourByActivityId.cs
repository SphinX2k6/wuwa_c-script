using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005B6 RID: 1462
	public class ConfigMotorParkourByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002251 RID: 8785 RVA: 0x0011B8FB File Offset: 0x00119AFB
		static ConfigMotorParkourByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorParkourByActivityId.CreateStaticDefaultValue), new Action(ConfigMotorParkourByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x0011B91C File Offset: 0x00119B1C
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorParkourByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorParkourByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorparkour.db"),
				new ValueTuple<string, object>("文件", "m.摩托跑酷.xlsx"),
				new ValueTuple<string, object>("表名", "MotorParkour"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorParkour` where ActivityId=?")
			});
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x0011B99B File Offset: 0x00119B9B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorParkourByActivityId.LogPair = null;
			ConfigMotorParkourByActivityId.HandleId = 0;
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x0011B9A9 File Offset: 0x00119BA9
		public static void Init()
		{
			ConfigMotorParkourByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorParkourByActivityId.HandleId, "db_motorparkour.db", "select BinData from `MotorParkour` where ActivityId=?");
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x0011B9C4 File Offset: 0x00119BC4
		[NullableContext(2)]
		public static IReadOnlyList<MotorParkour> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorParkourByActivityId.HandleId, ConfigMotorParkourByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorParkourByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<MotorParkour> readOnlyList = (IReadOnlyList<MotorParkour>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMotorParkourByActivityId.LogPair.Clear();
			ConfigMotorParkourByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigMotorParkourByActivityId.HandleId, 1, p0ActivityId, ConfigMotorParkourByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigMotorParkourByActivityId.HandleId, ConfigMotorParkourByActivityId.LogPair);
				return null;
			}
			List<MotorParkour> list = new List<MotorParkour>();
			while (ConfigCommon.Step(ConfigMotorParkourByActivityId.HandleId, false, ConfigMotorParkourByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorParkourByActivityId.HandleId, 0, ConfigMotorParkourByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorParkourByActivityId.HandleId, ConfigMotorParkourByActivityId.LogPair);
					return null;
				}
				MotorParkour rootAsMotorParkour = MotorParkour.GetRootAsMotorParkour(new ByteBuffer(item2));
				list.Add(rootAsMotorParkour);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorParkourByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorParkourByActivityId.HandleId, ConfigMotorParkourByActivityId.LogPair);
			return list;
		}

		// Token: 0x040027DE RID: 10206
		private const string DB = "db_motorparkour.db";

		// Token: 0x040027DF RID: 10207
		private const string FILE = "m.摩托跑酷.xlsx";

		// Token: 0x040027E0 RID: 10208
		private const string TABLE = "MotorParkour";

		// Token: 0x040027E1 RID: 10209
		private const string COMMAND = "select BinData from `MotorParkour` where ActivityId=?";

		// Token: 0x040027E2 RID: 10210
		private const string KEY_PREFIX = "MotorParkourByActivityId";

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
