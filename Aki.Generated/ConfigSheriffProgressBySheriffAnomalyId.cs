using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000966 RID: 2406
	public class ConfigSheriffProgressBySheriffAnomalyId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003877 RID: 14455 RVA: 0x0019BC00 File Offset: 0x00199E00
		static ConfigSheriffProgressBySheriffAnomalyId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffProgressBySheriffAnomalyId.CreateStaticDefaultValue), new Action(ConfigSheriffProgressBySheriffAnomalyId.ResetStaticDefaultValue));
		}

		// Token: 0x06003878 RID: 14456 RVA: 0x0019BC20 File Offset: 0x00199E20
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffProgressBySheriffAnomalyId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffProgressBySheriffAnomalyId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffProgress"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffProgress` where SheriffAnomalyId=?")
			});
		}

		// Token: 0x06003879 RID: 14457 RVA: 0x0019BC9F File Offset: 0x00199E9F
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffProgressBySheriffAnomalyId.LogPair = null;
			ConfigSheriffProgressBySheriffAnomalyId.HandleId = 0;
		}

		// Token: 0x0600387A RID: 14458 RVA: 0x0019BCAD File Offset: 0x00199EAD
		public static void Init()
		{
			ConfigSheriffProgressBySheriffAnomalyId.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffProgressBySheriffAnomalyId.HandleId, "db_sheriff.db", "select BinData from `SheriffProgress` where SheriffAnomalyId=?");
		}

		// Token: 0x0600387B RID: 14459 RVA: 0x0019BCC8 File Offset: 0x00199EC8
		[NullableContext(2)]
		public static IReadOnlyList<SheriffProgress> GetConfigList(int p0SheriffAnomalyId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffProgressBySheriffAnomalyId.HandleId, ConfigSheriffProgressBySheriffAnomalyId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffProgressBySheriffAnomalyId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SheriffAnomalyId);
				IReadOnlyList<SheriffProgress> readOnlyList = (IReadOnlyList<SheriffProgress>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSheriffProgressBySheriffAnomalyId.LogPair.Clear();
			ConfigSheriffProgressBySheriffAnomalyId.LogPair.Add(new ValueTuple<string, object>("SheriffAnomalyId", p0SheriffAnomalyId));
			if (!ConfigCommon.BindInt(ConfigSheriffProgressBySheriffAnomalyId.HandleId, 1, p0SheriffAnomalyId, ConfigSheriffProgressBySheriffAnomalyId.LogPair))
			{
				ConfigCommon.Reset(ConfigSheriffProgressBySheriffAnomalyId.HandleId, ConfigSheriffProgressBySheriffAnomalyId.LogPair);
				return null;
			}
			List<SheriffProgress> list = new List<SheriffProgress>();
			while (ConfigCommon.Step(ConfigSheriffProgressBySheriffAnomalyId.HandleId, false, ConfigSheriffProgressBySheriffAnomalyId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffProgressBySheriffAnomalyId.HandleId, 0, ConfigSheriffProgressBySheriffAnomalyId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSheriffProgressBySheriffAnomalyId.HandleId, ConfigSheriffProgressBySheriffAnomalyId.LogPair);
					return null;
				}
				SheriffProgress rootAsSheriffProgress = SheriffProgress.GetRootAsSheriffProgress(new ByteBuffer(item2));
				list.Add(rootAsSheriffProgress);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffProgressBySheriffAnomalyId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SheriffAnomalyId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSheriffProgressBySheriffAnomalyId.HandleId, ConfigSheriffProgressBySheriffAnomalyId.LogPair);
			return list;
		}

		// Token: 0x040041B0 RID: 16816
		private const string DB = "db_sheriff.db";

		// Token: 0x040041B1 RID: 16817
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x040041B2 RID: 16818
		private const string TABLE = "SheriffProgress";

		// Token: 0x040041B3 RID: 16819
		private const string COMMAND = "select BinData from `SheriffProgress` where SheriffAnomalyId=?";

		// Token: 0x040041B4 RID: 16820
		private const string KEY_PREFIX = "SheriffProgressBySheriffAnomalyId";

		// Token: 0x040041B5 RID: 16821
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041B6 RID: 16822
		private static int HandleId;
	}
}
