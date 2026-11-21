using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A4B RID: 2635
	public class ConfigSpringFestivalAreaByFloor : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DD6 RID: 15830 RVA: 0x001BA25B File Offset: 0x001B845B
		static ConfigSpringFestivalAreaByFloor()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalAreaByFloor.CreateStaticDefaultValue), new Action(ConfigSpringFestivalAreaByFloor.ResetStaticDefaultValue));
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x001BA27C File Offset: 0x001B847C
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

		// Token: 0x06003DD8 RID: 15832 RVA: 0x001BA2FB File Offset: 0x001B84FB
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalAreaByFloor.LogPair = null;
			ConfigSpringFestivalAreaByFloor.HandleId = 0;
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x001BA309 File Offset: 0x001B8509
		public static void Init()
		{
			ConfigSpringFestivalAreaByFloor.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalAreaByFloor.HandleId, "db_spring26.db", "select BinData from `SpringFestivalArea` where Floor=?");
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x001BA324 File Offset: 0x001B8524
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

		// Token: 0x040047F3 RID: 18419
		private const string DB = "db_spring26.db";

		// Token: 0x040047F4 RID: 18420
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x040047F5 RID: 18421
		private const string TABLE = "SpringFestivalArea";

		// Token: 0x040047F6 RID: 18422
		private const string COMMAND = "select BinData from `SpringFestivalArea` where Floor=?";

		// Token: 0x040047F7 RID: 18423
		private const string KEY_PREFIX = "SpringFestivalAreaByFloor";

		// Token: 0x040047F8 RID: 18424
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047F9 RID: 18425
		private static int HandleId;
	}
}
