using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000983 RID: 2435
	public class ConfigSpringFestivalSkipEntryByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003926 RID: 14630 RVA: 0x0019CB7C File Offset: 0x0019AD7C
		static ConfigSpringFestivalSkipEntryByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalSkipEntryByActivityId.CreateStaticDefaultValue), new Action(ConfigSpringFestivalSkipEntryByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003927 RID: 14631 RVA: 0x0019CB9C File Offset: 0x0019AD9C
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

		// Token: 0x06003928 RID: 14632 RVA: 0x0019CC1B File Offset: 0x0019AE1B
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalSkipEntryByActivityId.LogPair = null;
			ConfigSpringFestivalSkipEntryByActivityId.HandleId = 0;
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x0019CC29 File Offset: 0x0019AE29
		public static void Init()
		{
			ConfigSpringFestivalSkipEntryByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalSkipEntryByActivityId.HandleId, "db_spring26.db", "select BinData from `SpringFestivalSkipEntry` where Activity=?");
		}

		// Token: 0x0600392A RID: 14634 RVA: 0x0019CC44 File Offset: 0x0019AE44
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

		// Token: 0x0400427B RID: 17019
		private const string DB = "db_spring26.db";

		// Token: 0x0400427C RID: 17020
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x0400427D RID: 17021
		private const string TABLE = "SpringFestivalSkipEntry";

		// Token: 0x0400427E RID: 17022
		private const string COMMAND = "select BinData from `SpringFestivalSkipEntry` where Activity=?";

		// Token: 0x0400427F RID: 17023
		private const string KEY_PREFIX = "SpringFestivalSkipEntryByActivityId";

		// Token: 0x04004280 RID: 17024
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004281 RID: 17025
		private static int HandleId;
	}
}
