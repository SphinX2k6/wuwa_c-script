using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200091B RID: 2331
	public class ConfigSheriffProgressBySheriffAnomalyId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036B5 RID: 14005 RVA: 0x0018E9E0 File Offset: 0x0018CBE0
		static ConfigSheriffProgressBySheriffAnomalyId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffProgressBySheriffAnomalyId.CreateStaticDefaultValue), new Action(ConfigSheriffProgressBySheriffAnomalyId.ResetStaticDefaultValue));
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x0018EA00 File Offset: 0x0018CC00
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

		// Token: 0x060036B7 RID: 14007 RVA: 0x0018EA7F File Offset: 0x0018CC7F
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffProgressBySheriffAnomalyId.LogPair = null;
			ConfigSheriffProgressBySheriffAnomalyId.HandleId = 0;
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x0018EA8D File Offset: 0x0018CC8D
		public static void Init()
		{
			ConfigSheriffProgressBySheriffAnomalyId.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffProgressBySheriffAnomalyId.HandleId, "db_sheriff.db", "select BinData from `SheriffProgress` where SheriffAnomalyId=?");
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x0018EAA8 File Offset: 0x0018CCA8
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

		// Token: 0x04003FA3 RID: 16291
		private const string DB = "db_sheriff.db";

		// Token: 0x04003FA4 RID: 16292
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04003FA5 RID: 16293
		private const string TABLE = "SheriffProgress";

		// Token: 0x04003FA6 RID: 16294
		private const string COMMAND = "select BinData from `SheriffProgress` where SheriffAnomalyId=?";

		// Token: 0x04003FA7 RID: 16295
		private const string KEY_PREFIX = "SheriffProgressBySheriffAnomalyId";

		// Token: 0x04003FA8 RID: 16296
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FA9 RID: 16297
		private static int HandleId;
	}
}
