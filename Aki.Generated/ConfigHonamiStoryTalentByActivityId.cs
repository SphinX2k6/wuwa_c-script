using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200040A RID: 1034
	public class ConfigHonamiStoryTalentByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001843 RID: 6211 RVA: 0x000E2F5C File Offset: 0x000E115C
		static ConfigHonamiStoryTalentByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryTalentByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryTalentByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x000E2F7C File Offset: 0x000E117C
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

		// Token: 0x06001845 RID: 6213 RVA: 0x000E2FFB File Offset: 0x000E11FB
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryTalentByActivityId.LogPair = null;
			ConfigHonamiStoryTalentByActivityId.HandleId = 0;
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x000E3009 File Offset: 0x000E1209
		public static void Init()
		{
			ConfigHonamiStoryTalentByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryTalentByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryTalent` where ActivityId=?");
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x000E3024 File Offset: 0x000E1224
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

		// Token: 0x04001C2A RID: 7210
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C2B RID: 7211
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001C2C RID: 7212
		private const string TABLE = "HonamiStoryTalent";

		// Token: 0x04001C2D RID: 7213
		private const string COMMAND = "select BinData from `HonamiStoryTalent` where ActivityId=?";

		// Token: 0x04001C2E RID: 7214
		private const string KEY_PREFIX = "HonamiStoryTalentByActivityId";

		// Token: 0x04001C2F RID: 7215
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C30 RID: 7216
		private static int HandleId;
	}
}
