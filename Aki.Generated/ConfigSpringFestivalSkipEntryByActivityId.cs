using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A58 RID: 2648
	public class ConfigSpringFestivalSkipEntryByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E24 RID: 15908 RVA: 0x001BBF10 File Offset: 0x001BA110
		static ConfigSpringFestivalSkipEntryByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalSkipEntryByActivityId.CreateStaticDefaultValue), new Action(ConfigSpringFestivalSkipEntryByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003E25 RID: 15909 RVA: 0x001BBF30 File Offset: 0x001BA130
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalSkipEntryByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalSkipEntryByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalSkipEntry"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalSkipEntry` where Activity=?")
			});
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x001BBFAF File Offset: 0x001BA1AF
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalSkipEntryByActivityId.LogPair = null;
			ConfigSpringFestivalSkipEntryByActivityId.HandleId = 0;
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x001BBFBD File Offset: 0x001BA1BD
		public static void Init()
		{
			ConfigSpringFestivalSkipEntryByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalSkipEntryByActivityId.HandleId, "db_spring26.db", "select BinData from `SpringFestivalSkipEntry` where Activity=?");
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x001BBFD8 File Offset: 0x001BA1D8
		[NullableContext(2)]
		public static IReadOnlyList<SpringFestivalSkipEntry> GetConfigList(int p0Activity, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalSkipEntryByActivityId.HandleId, ConfigSpringFestivalSkipEntryByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalSkipEntryByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Activity);
				IReadOnlyList<SpringFestivalSkipEntry> readOnlyList = (IReadOnlyList<SpringFestivalSkipEntry>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSpringFestivalSkipEntryByActivityId.LogPair.Clear();
			ConfigSpringFestivalSkipEntryByActivityId.LogPair.Add(new ValueTuple<string, object>("Activity", p0Activity));
			if (!ConfigCommon.BindInt(ConfigSpringFestivalSkipEntryByActivityId.HandleId, 1, p0Activity, ConfigSpringFestivalSkipEntryByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSpringFestivalSkipEntryByActivityId.HandleId, ConfigSpringFestivalSkipEntryByActivityId.LogPair);
				return null;
			}
			List<SpringFestivalSkipEntry> list = new List<SpringFestivalSkipEntry>();
			while (ConfigCommon.Step(ConfigSpringFestivalSkipEntryByActivityId.HandleId, false, ConfigSpringFestivalSkipEntryByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalSkipEntryByActivityId.HandleId, 0, ConfigSpringFestivalSkipEntryByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSpringFestivalSkipEntryByActivityId.HandleId, ConfigSpringFestivalSkipEntryByActivityId.LogPair);
					return null;
				}
				SpringFestivalSkipEntry rootAsSpringFestivalSkipEntry = SpringFestivalSkipEntry.GetRootAsSpringFestivalSkipEntry(new ByteBuffer(item2));
				list.Add(rootAsSpringFestivalSkipEntry);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalSkipEntryByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Activity);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSpringFestivalSkipEntryByActivityId.HandleId, ConfigSpringFestivalSkipEntryByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400484E RID: 18510
		private const string DB = "db_spring26.db";

		// Token: 0x0400484F RID: 18511
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004850 RID: 18512
		private const string TABLE = "SpringFestivalSkipEntry";

		// Token: 0x04004851 RID: 18513
		private const string COMMAND = "select BinData from `SpringFestivalSkipEntry` where Activity=?";

		// Token: 0x04004852 RID: 18514
		private const string KEY_PREFIX = "SpringFestivalSkipEntryByActivityId";

		// Token: 0x04004853 RID: 18515
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004854 RID: 18516
		private static int HandleId;
	}
}
