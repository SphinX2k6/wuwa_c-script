using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000AB RID: 171
	public class ConfigAreaByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000403 RID: 1027 RVA: 0x00073D34 File Offset: 0x00071F34
		static ConfigAreaByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaByLevel.CreateStaticDefaultValue), new Action(ConfigAreaByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00073D54 File Offset: 0x00071F54
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

		// Token: 0x06000405 RID: 1029 RVA: 0x00073DD3 File Offset: 0x00071FD3
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaByLevel.LogPair = null;
			ConfigAreaByLevel.HandleId = 0;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00073DE1 File Offset: 0x00071FE1
		public static void Init()
		{
			ConfigAreaByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigAreaByLevel.HandleId, "db_area.db", "select BinData from `Area` where Level=?");
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00073DFC File Offset: 0x00071FFC
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

		// Token: 0x04000491 RID: 1169
		private const string DB = "db_area.db";

		// Token: 0x04000492 RID: 1170
		private const string FILE = "q.区域.xlsx";

		// Token: 0x04000493 RID: 1171
		private const string TABLE = "Area";

		// Token: 0x04000494 RID: 1172
		private const string COMMAND = "select BinData from `Area` where Level=?";

		// Token: 0x04000495 RID: 1173
		private const string KEY_PREFIX = "AreaByLevel";

		// Token: 0x04000496 RID: 1174
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000497 RID: 1175
		private static int HandleId;
	}
}
