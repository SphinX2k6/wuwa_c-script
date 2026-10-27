using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003EA RID: 1002
	public class ConfigHonamiStoryLifeSupportByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001783 RID: 6019 RVA: 0x000DE870 File Offset: 0x000DCA70
		static ConfigHonamiStoryLifeSupportByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryLifeSupportByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryLifeSupportByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x000DE890 File Offset: 0x000DCA90
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

		// Token: 0x06001785 RID: 6021 RVA: 0x000DE90F File Offset: 0x000DCB0F
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryLifeSupportByActivityId.LogPair = null;
			ConfigHonamiStoryLifeSupportByActivityId.HandleId = 0;
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x000DE91D File Offset: 0x000DCB1D
		public static void Init()
		{
			ConfigHonamiStoryLifeSupportByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryLifeSupportByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryLifeSupport` where ActivityId=?");
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x000DE938 File Offset: 0x000DCB38
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

		// Token: 0x04001B4A RID: 6986
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B4B RID: 6987
		private const string FILE = "s.穗波奇妙物语装备栏.xlsx";

		// Token: 0x04001B4C RID: 6988
		private const string TABLE = "HonamiStoryLifeSupport";

		// Token: 0x04001B4D RID: 6989
		private const string COMMAND = "select BinData from `HonamiStoryLifeSupport` where ActivityId=?";

		// Token: 0x04001B4E RID: 6990
		private const string KEY_PREFIX = "HonamiStoryLifeSupportByActivityId";

		// Token: 0x04001B4F RID: 6991
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B50 RID: 6992
		private static int HandleId;
	}
}
