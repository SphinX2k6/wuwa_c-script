using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000400 RID: 1024
	public class ConfigHonamiStoryLifeSupportByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001807 RID: 6151 RVA: 0x000E4FC4 File Offset: 0x000E31C4
		static ConfigHonamiStoryLifeSupportByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryLifeSupportByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryLifeSupportByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x000E4FE4 File Offset: 0x000E31E4
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryLifeSupportByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryLifeSupportByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语装备栏.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryLifeSupport"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryLifeSupport` where ActivityId=?")
			});
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x000E5063 File Offset: 0x000E3263
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryLifeSupportByActivityId.LogPair = null;
			ConfigHonamiStoryLifeSupportByActivityId.HandleId = 0;
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x000E5071 File Offset: 0x000E3271
		public static void Init()
		{
			ConfigHonamiStoryLifeSupportByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryLifeSupportByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryLifeSupport` where ActivityId=?");
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x000E508C File Offset: 0x000E328C
		[NullableContext(2)]
		public static IReadOnlyList<HonamiStoryLifeSupport> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryLifeSupportByActivityId.HandleId, ConfigHonamiStoryLifeSupportByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryLifeSupportByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<HonamiStoryLifeSupport> readOnlyList = (IReadOnlyList<HonamiStoryLifeSupport>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigHonamiStoryLifeSupportByActivityId.LogPair.Clear();
			ConfigHonamiStoryLifeSupportByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryLifeSupportByActivityId.HandleId, 1, p0ActivityId, ConfigHonamiStoryLifeSupportByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigHonamiStoryLifeSupportByActivityId.HandleId, ConfigHonamiStoryLifeSupportByActivityId.LogPair);
				return null;
			}
			List<HonamiStoryLifeSupport> list = new List<HonamiStoryLifeSupport>();
			while (ConfigCommon.Step(ConfigHonamiStoryLifeSupportByActivityId.HandleId, false, ConfigHonamiStoryLifeSupportByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryLifeSupportByActivityId.HandleId, 0, ConfigHonamiStoryLifeSupportByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiStoryLifeSupportByActivityId.HandleId, ConfigHonamiStoryLifeSupportByActivityId.LogPair);
					return null;
				}
				HonamiStoryLifeSupport rootAsHonamiStoryLifeSupport = HonamiStoryLifeSupport.GetRootAsHonamiStoryLifeSupport(new ByteBuffer(item2));
				list.Add(rootAsHonamiStoryLifeSupport);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryLifeSupportByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiStoryLifeSupportByActivityId.HandleId, ConfigHonamiStoryLifeSupportByActivityId.LogPair);
			return list;
		}

		// Token: 0x04001BE4 RID: 7140
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BE5 RID: 7141
		private const string FILE = "s.穗波奇妙物语装备栏.xlsx";

		// Token: 0x04001BE6 RID: 7142
		private const string TABLE = "HonamiStoryLifeSupport";

		// Token: 0x04001BE7 RID: 7143
		private const string COMMAND = "select BinData from `HonamiStoryLifeSupport` where ActivityId=?";

		// Token: 0x04001BE8 RID: 7144
		private const string KEY_PREFIX = "HonamiStoryLifeSupportByActivityId";

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
