using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003DB RID: 987
	public class ConfigHonamiStoryAreaByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001729 RID: 5929 RVA: 0x000DC71C File Offset: 0x000DA91C
		static ConfigHonamiStoryAreaByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryAreaByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryAreaByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x000DC73C File Offset: 0x000DA93C
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

		// Token: 0x0600172B RID: 5931 RVA: 0x000DC7BB File Offset: 0x000DA9BB
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryAreaByActivityId.LogPair = null;
			ConfigHonamiStoryAreaByActivityId.HandleId = 0;
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x000DC7C9 File Offset: 0x000DA9C9
		public static void Init()
		{
			ConfigHonamiStoryAreaByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryAreaByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryArea` where ActivityId=?");
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x000DC7E4 File Offset: 0x000DA9E4
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

		// Token: 0x04001AE1 RID: 6881
		private const string DB = "db_honamistory.db";

		// Token: 0x04001AE2 RID: 6882
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001AE3 RID: 6883
		private const string TABLE = "HonamiStoryArea";

		// Token: 0x04001AE4 RID: 6884
		private const string COMMAND = "select BinData from `HonamiStoryArea` where ActivityId=?";

		// Token: 0x04001AE5 RID: 6885
		private const string KEY_PREFIX = "HonamiStoryAreaByActivityId";

		// Token: 0x04001AE6 RID: 6886
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AE7 RID: 6887
		private static int HandleId;
	}
}
