using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000A3 RID: 163
	public class ConfigAreaByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003D3 RID: 979 RVA: 0x0006F480 File Offset: 0x0006D680
		static ConfigAreaByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaByLevel.CreateStaticDefaultValue), new Action(ConfigAreaByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0006F4A0 File Offset: 0x0006D6A0
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaByLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaByLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_area.db"),
				new ValueTuple<string, object>("文件", "q.区域.xlsx"),
				new ValueTuple<string, object>("表名", "Area"),
				new ValueTuple<string, object>("语句", "select BinData from `Area` where Level=?")
			});
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0006F51F File Offset: 0x0006D71F
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaByLevel.LogPair = null;
			ConfigAreaByLevel.HandleId = 0;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0006F52D File Offset: 0x0006D72D
		public static void Init()
		{
			ConfigAreaByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigAreaByLevel.HandleId, "db_area.db", "select BinData from `Area` where Level=?");
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0006F548 File Offset: 0x0006D748
		[NullableContext(2)]
		public static IReadOnlyList<Area> GetConfigList(int p0Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaByLevel.HandleId, ConfigAreaByLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				IReadOnlyList<Area> readOnlyList = (IReadOnlyList<Area>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigAreaByLevel.LogPair.Clear();
			ConfigAreaByLevel.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			if (!ConfigCommon.BindInt(ConfigAreaByLevel.HandleId, 1, p0Level, ConfigAreaByLevel.LogPair))
			{
				ConfigCommon.Reset(ConfigAreaByLevel.HandleId, ConfigAreaByLevel.LogPair);
				return null;
			}
			List<Area> list = new List<Area>();
			while (ConfigCommon.Step(ConfigAreaByLevel.HandleId, false, ConfigAreaByLevel.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaByLevel.HandleId, 0, ConfigAreaByLevel.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAreaByLevel.HandleId, ConfigAreaByLevel.LogPair);
					return null;
				}
				Area rootAsArea = Area.GetRootAsArea(new ByteBuffer(item2));
				list.Add(rootAsArea);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigAreaByLevel.HandleId, ConfigAreaByLevel.LogPair);
			return list;
		}

		// Token: 0x04000459 RID: 1113
		private const string DB = "db_area.db";

		// Token: 0x0400045A RID: 1114
		private const string FILE = "q.区域.xlsx";

		// Token: 0x0400045B RID: 1115
		private const string TABLE = "Area";

		// Token: 0x0400045C RID: 1116
		private const string COMMAND = "select BinData from `Area` where Level=?";

		// Token: 0x0400045D RID: 1117
		private const string KEY_PREFIX = "AreaByLevel";

		// Token: 0x0400045E RID: 1118
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400045F RID: 1119
		private static int HandleId;
	}
}
