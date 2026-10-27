using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000976 RID: 2422
	public class ConfigSpringFestivalAreaByFloor : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038D8 RID: 14552 RVA: 0x0019AEC7 File Offset: 0x001990C7
		static ConfigSpringFestivalAreaByFloor()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalAreaByFloor.CreateStaticDefaultValue), new Action(ConfigSpringFestivalAreaByFloor.ResetStaticDefaultValue));
		}

		// Token: 0x060038D9 RID: 14553 RVA: 0x0019AEE8 File Offset: 0x001990E8
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalAreaByFloor.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalAreaByFloor.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalArea"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalArea` where Floor=?")
			});
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x0019AF67 File Offset: 0x00199167
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalAreaByFloor.LogPair = null;
			ConfigSpringFestivalAreaByFloor.HandleId = 0;
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x0019AF75 File Offset: 0x00199175
		public static void Init()
		{
			ConfigSpringFestivalAreaByFloor.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalAreaByFloor.HandleId, "db_spring26.db", "select BinData from `SpringFestivalArea` where Floor=?");
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x0019AF90 File Offset: 0x00199190
		[NullableContext(2)]
		public static IReadOnlyList<SpringFestivalArea> GetConfigList(int p0Floor, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalAreaByFloor.HandleId, ConfigSpringFestivalAreaByFloor.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalAreaByFloor");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Floor);
				IReadOnlyList<SpringFestivalArea> readOnlyList = (IReadOnlyList<SpringFestivalArea>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSpringFestivalAreaByFloor.LogPair.Clear();
			ConfigSpringFestivalAreaByFloor.LogPair.Add(new ValueTuple<string, object>("Floor", p0Floor));
			if (!ConfigCommon.BindInt(ConfigSpringFestivalAreaByFloor.HandleId, 1, p0Floor, ConfigSpringFestivalAreaByFloor.LogPair))
			{
				ConfigCommon.Reset(ConfigSpringFestivalAreaByFloor.HandleId, ConfigSpringFestivalAreaByFloor.LogPair);
				return null;
			}
			List<SpringFestivalArea> list = new List<SpringFestivalArea>();
			while (ConfigCommon.Step(ConfigSpringFestivalAreaByFloor.HandleId, false, ConfigSpringFestivalAreaByFloor.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalAreaByFloor.HandleId, 0, ConfigSpringFestivalAreaByFloor.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSpringFestivalAreaByFloor.HandleId, ConfigSpringFestivalAreaByFloor.LogPair);
					return null;
				}
				SpringFestivalArea rootAsSpringFestivalArea = SpringFestivalArea.GetRootAsSpringFestivalArea(new ByteBuffer(item2));
				list.Add(rootAsSpringFestivalArea);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalAreaByFloor");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Floor);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSpringFestivalAreaByFloor.HandleId, ConfigSpringFestivalAreaByFloor.LogPair);
			return list;
		}

		// Token: 0x04004220 RID: 16928
		private const string DB = "db_spring26.db";

		// Token: 0x04004221 RID: 16929
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004222 RID: 16930
		private const string TABLE = "SpringFestivalArea";

		// Token: 0x04004223 RID: 16931
		private const string COMMAND = "select BinData from `SpringFestivalArea` where Floor=?";

		// Token: 0x04004224 RID: 16932
		private const string KEY_PREFIX = "SpringFestivalAreaByFloor";

		// Token: 0x04004225 RID: 16933
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004226 RID: 16934
		private static int HandleId;
	}
}
