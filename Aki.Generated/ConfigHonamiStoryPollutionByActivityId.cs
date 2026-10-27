using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000400 RID: 1024
	public class ConfigHonamiStoryPollutionByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001807 RID: 6151 RVA: 0x000E1970 File Offset: 0x000DFB70
		static ConfigHonamiStoryPollutionByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryPollutionByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryPollutionByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x000E1990 File Offset: 0x000DFB90
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryPollutionByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryPollutionByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局内.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryPollution"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryPollution` where ActivityId = ?")
			});
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x000E1A0F File Offset: 0x000DFC0F
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryPollutionByActivityId.LogPair = null;
			ConfigHonamiStoryPollutionByActivityId.HandleId = 0;
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x000E1A1D File Offset: 0x000DFC1D
		public static void Init()
		{
			ConfigHonamiStoryPollutionByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryPollutionByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryPollution` where ActivityId = ?");
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x000E1A38 File Offset: 0x000DFC38
		[NullableContext(2)]
		public static IReadOnlyList<HonamiStoryPollution> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryPollutionByActivityId.HandleId, ConfigHonamiStoryPollutionByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPollutionByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<HonamiStoryPollution> readOnlyList = (IReadOnlyList<HonamiStoryPollution>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigHonamiStoryPollutionByActivityId.LogPair.Clear();
			ConfigHonamiStoryPollutionByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryPollutionByActivityId.HandleId, 1, p0ActivityId, ConfigHonamiStoryPollutionByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigHonamiStoryPollutionByActivityId.HandleId, ConfigHonamiStoryPollutionByActivityId.LogPair);
				return null;
			}
			List<HonamiStoryPollution> list = new List<HonamiStoryPollution>();
			while (ConfigCommon.Step(ConfigHonamiStoryPollutionByActivityId.HandleId, false, ConfigHonamiStoryPollutionByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryPollutionByActivityId.HandleId, 0, ConfigHonamiStoryPollutionByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiStoryPollutionByActivityId.HandleId, ConfigHonamiStoryPollutionByActivityId.LogPair);
					return null;
				}
				HonamiStoryPollution rootAsHonamiStoryPollution = HonamiStoryPollution.GetRootAsHonamiStoryPollution(new ByteBuffer(item2));
				list.Add(rootAsHonamiStoryPollution);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPollutionByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiStoryPollutionByActivityId.HandleId, ConfigHonamiStoryPollutionByActivityId.LogPair);
			return list;
		}

		// Token: 0x04001BE4 RID: 7140
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BE5 RID: 7141
		private const string FILE = "s.穗波奇妙物语局内.xlsx";

		// Token: 0x04001BE6 RID: 7142
		private const string TABLE = "HonamiStoryPollution";

		// Token: 0x04001BE7 RID: 7143
		private const string COMMAND = "select BinData from `HonamiStoryPollution` where ActivityId = ?";

		// Token: 0x04001BE8 RID: 7144
		private const string KEY_PREFIX = "HonamiStoryPollutionByActivityId";

		// Token: 0x04001BE9 RID: 7145
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BEA RID: 7146
		private static int HandleId;
	}
}
