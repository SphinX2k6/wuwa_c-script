using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003F1 RID: 1009
	public class ConfigHonamiStoryAreaByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017AD RID: 6061 RVA: 0x000E2E70 File Offset: 0x000E1070
		static ConfigHonamiStoryAreaByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryAreaByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryAreaByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x000E2E90 File Offset: 0x000E1090
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryAreaByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryAreaByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryArea"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryArea` where ActivityId=?")
			});
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x000E2F0F File Offset: 0x000E110F
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryAreaByActivityId.LogPair = null;
			ConfigHonamiStoryAreaByActivityId.HandleId = 0;
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x000E2F1D File Offset: 0x000E111D
		public static void Init()
		{
			ConfigHonamiStoryAreaByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryAreaByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryArea` where ActivityId=?");
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x000E2F38 File Offset: 0x000E1138
		[NullableContext(2)]
		public static IReadOnlyList<HonamiStoryArea> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryAreaByActivityId.HandleId, ConfigHonamiStoryAreaByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryAreaByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<HonamiStoryArea> readOnlyList = (IReadOnlyList<HonamiStoryArea>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigHonamiStoryAreaByActivityId.LogPair.Clear();
			ConfigHonamiStoryAreaByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryAreaByActivityId.HandleId, 1, p0ActivityId, ConfigHonamiStoryAreaByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigHonamiStoryAreaByActivityId.HandleId, ConfigHonamiStoryAreaByActivityId.LogPair);
				return null;
			}
			List<HonamiStoryArea> list = new List<HonamiStoryArea>();
			while (ConfigCommon.Step(ConfigHonamiStoryAreaByActivityId.HandleId, false, ConfigHonamiStoryAreaByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryAreaByActivityId.HandleId, 0, ConfigHonamiStoryAreaByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiStoryAreaByActivityId.HandleId, ConfigHonamiStoryAreaByActivityId.LogPair);
					return null;
				}
				HonamiStoryArea rootAsHonamiStoryArea = HonamiStoryArea.GetRootAsHonamiStoryArea(new ByteBuffer(item2));
				list.Add(rootAsHonamiStoryArea);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryAreaByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiStoryAreaByActivityId.HandleId, ConfigHonamiStoryAreaByActivityId.LogPair);
			return list;
		}

		// Token: 0x04001B7B RID: 7035
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B7C RID: 7036
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001B7D RID: 7037
		private const string TABLE = "HonamiStoryArea";

		// Token: 0x04001B7E RID: 7038
		private const string COMMAND = "select BinData from `HonamiStoryArea` where ActivityId=?";

		// Token: 0x04001B7F RID: 7039
		private const string KEY_PREFIX = "HonamiStoryAreaByActivityId";

		// Token: 0x04001B80 RID: 7040
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B81 RID: 7041
		private static int HandleId;
	}
}
