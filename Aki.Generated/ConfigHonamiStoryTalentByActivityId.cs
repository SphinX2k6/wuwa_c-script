using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000420 RID: 1056
	public class ConfigHonamiStoryTalentByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018C7 RID: 6343 RVA: 0x000E96B0 File Offset: 0x000E78B0
		static ConfigHonamiStoryTalentByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryTalentByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryTalentByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x000E96D0 File Offset: 0x000E78D0
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryTalentByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryTalentByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryTalent"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryTalent` where ActivityId=?")
			});
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x000E974F File Offset: 0x000E794F
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryTalentByActivityId.LogPair = null;
			ConfigHonamiStoryTalentByActivityId.HandleId = 0;
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x000E975D File Offset: 0x000E795D
		public static void Init()
		{
			ConfigHonamiStoryTalentByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryTalentByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryTalent` where ActivityId=?");
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x000E9778 File Offset: 0x000E7978
		[NullableContext(2)]
		public static IReadOnlyList<HonamiStoryTalent> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryTalentByActivityId.HandleId, ConfigHonamiStoryTalentByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryTalentByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<HonamiStoryTalent> readOnlyList = (IReadOnlyList<HonamiStoryTalent>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigHonamiStoryTalentByActivityId.LogPair.Clear();
			ConfigHonamiStoryTalentByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryTalentByActivityId.HandleId, 1, p0ActivityId, ConfigHonamiStoryTalentByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigHonamiStoryTalentByActivityId.HandleId, ConfigHonamiStoryTalentByActivityId.LogPair);
				return null;
			}
			List<HonamiStoryTalent> list = new List<HonamiStoryTalent>();
			while (ConfigCommon.Step(ConfigHonamiStoryTalentByActivityId.HandleId, false, ConfigHonamiStoryTalentByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryTalentByActivityId.HandleId, 0, ConfigHonamiStoryTalentByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiStoryTalentByActivityId.HandleId, ConfigHonamiStoryTalentByActivityId.LogPair);
					return null;
				}
				HonamiStoryTalent rootAsHonamiStoryTalent = HonamiStoryTalent.GetRootAsHonamiStoryTalent(new ByteBuffer(item2));
				list.Add(rootAsHonamiStoryTalent);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryTalentByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiStoryTalentByActivityId.HandleId, ConfigHonamiStoryTalentByActivityId.LogPair);
			return list;
		}

		// Token: 0x04001CC4 RID: 7364
		private const string DB = "db_honamistory.db";

		// Token: 0x04001CC5 RID: 7365
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001CC6 RID: 7366
		private const string TABLE = "HonamiStoryTalent";

		// Token: 0x04001CC7 RID: 7367
		private const string COMMAND = "select BinData from `HonamiStoryTalent` where ActivityId=?";

		// Token: 0x04001CC8 RID: 7368
		private const string KEY_PREFIX = "HonamiStoryTalentByActivityId";

		// Token: 0x04001CC9 RID: 7369
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CCA RID: 7370
		private static int HandleId;
	}
}
