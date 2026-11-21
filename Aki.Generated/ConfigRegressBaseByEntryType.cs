using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007E4 RID: 2020
	public class ConfigRegressBaseByEntryType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F6A RID: 12138 RVA: 0x00168BFB File Offset: 0x00166DFB
		static ConfigRegressBaseByEntryType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressBaseByEntryType.CreateStaticDefaultValue), new Action(ConfigRegressBaseByEntryType.ResetStaticDefaultValue));
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x00168C1C File Offset: 0x00166E1C
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressBaseByEntryType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressBaseByEntryType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressBase"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressBase` where EntryType=?")
			});
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x00168C9B File Offset: 0x00166E9B
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressBaseByEntryType.LogPair = null;
			ConfigRegressBaseByEntryType.HandleId = 0;
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x00168CA9 File Offset: 0x00166EA9
		public static void Init()
		{
			ConfigRegressBaseByEntryType.HandleId = ConfigCommon.InitDataStatement(ConfigRegressBaseByEntryType.HandleId, "db_regressactivity.db", "select BinData from `RegressBase` where EntryType=?");
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x00168CC4 File Offset: 0x00166EC4
		[NullableContext(2)]
		public static IReadOnlyList<RegressBase> GetConfigList(int p0EntryType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressBaseByEntryType.HandleId, ConfigRegressBaseByEntryType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressBaseByEntryType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EntryType);
				IReadOnlyList<RegressBase> readOnlyList = (IReadOnlyList<RegressBase>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRegressBaseByEntryType.LogPair.Clear();
			ConfigRegressBaseByEntryType.LogPair.Add(new ValueTuple<string, object>("EntryType", p0EntryType));
			if (!ConfigCommon.BindInt(ConfigRegressBaseByEntryType.HandleId, 1, p0EntryType, ConfigRegressBaseByEntryType.LogPair))
			{
				ConfigCommon.Reset(ConfigRegressBaseByEntryType.HandleId, ConfigRegressBaseByEntryType.LogPair);
				return null;
			}
			List<RegressBase> list = new List<RegressBase>();
			while (ConfigCommon.Step(ConfigRegressBaseByEntryType.HandleId, false, ConfigRegressBaseByEntryType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressBaseByEntryType.HandleId, 0, ConfigRegressBaseByEntryType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRegressBaseByEntryType.HandleId, ConfigRegressBaseByEntryType.LogPair);
					return null;
				}
				RegressBase rootAsRegressBase = RegressBase.GetRootAsRegressBase(new ByteBuffer(item2));
				list.Add(rootAsRegressBase);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressBaseByEntryType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EntryType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRegressBaseByEntryType.HandleId, ConfigRegressBaseByEntryType.LogPair);
			return list;
		}

		// Token: 0x04003722 RID: 14114
		private const string DB = "db_regressactivity.db";

		// Token: 0x04003723 RID: 14115
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x04003724 RID: 14116
		private const string TABLE = "RegressBase";

		// Token: 0x04003725 RID: 14117
		private const string COMMAND = "select BinData from `RegressBase` where EntryType=?";

		// Token: 0x04003726 RID: 14118
		private const string KEY_PREFIX = "RegressBaseByEntryType";

		// Token: 0x04003727 RID: 14119
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003728 RID: 14120
		private static int HandleId;
	}
}
