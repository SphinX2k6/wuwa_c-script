using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007ED RID: 2029
	public class ConfigRegressEntryByEntryType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FA0 RID: 12192 RVA: 0x00169E9B File Offset: 0x0016809B
		static ConfigRegressEntryByEntryType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressEntryByEntryType.CreateStaticDefaultValue), new Action(ConfigRegressEntryByEntryType.ResetStaticDefaultValue));
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x00169EBC File Offset: 0x001680BC
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressEntryByEntryType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressEntryByEntryType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressEntry"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressEntry` where EntryType=?")
			});
		}

		// Token: 0x06002FA2 RID: 12194 RVA: 0x00169F3B File Offset: 0x0016813B
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressEntryByEntryType.LogPair = null;
			ConfigRegressEntryByEntryType.HandleId = 0;
		}

		// Token: 0x06002FA3 RID: 12195 RVA: 0x00169F49 File Offset: 0x00168149
		public static void Init()
		{
			ConfigRegressEntryByEntryType.HandleId = ConfigCommon.InitDataStatement(ConfigRegressEntryByEntryType.HandleId, "db_regressactivity.db", "select BinData from `RegressEntry` where EntryType=?");
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x00169F64 File Offset: 0x00168164
		[NullableContext(2)]
		public static IReadOnlyList<RegressEntry> GetConfigList(int p0EntryType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressEntryByEntryType.HandleId, ConfigRegressEntryByEntryType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressEntryByEntryType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EntryType);
				IReadOnlyList<RegressEntry> readOnlyList = (IReadOnlyList<RegressEntry>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRegressEntryByEntryType.LogPair.Clear();
			ConfigRegressEntryByEntryType.LogPair.Add(new ValueTuple<string, object>("EntryType", p0EntryType));
			if (!ConfigCommon.BindInt(ConfigRegressEntryByEntryType.HandleId, 1, p0EntryType, ConfigRegressEntryByEntryType.LogPair))
			{
				ConfigCommon.Reset(ConfigRegressEntryByEntryType.HandleId, ConfigRegressEntryByEntryType.LogPair);
				return null;
			}
			List<RegressEntry> list = new List<RegressEntry>();
			while (ConfigCommon.Step(ConfigRegressEntryByEntryType.HandleId, false, ConfigRegressEntryByEntryType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressEntryByEntryType.HandleId, 0, ConfigRegressEntryByEntryType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRegressEntryByEntryType.HandleId, ConfigRegressEntryByEntryType.LogPair);
					return null;
				}
				RegressEntry rootAsRegressEntry = RegressEntry.GetRootAsRegressEntry(new ByteBuffer(item2));
				list.Add(rootAsRegressEntry);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressEntryByEntryType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EntryType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRegressEntryByEntryType.HandleId, ConfigRegressEntryByEntryType.LogPair);
			return list;
		}

		// Token: 0x04003761 RID: 14177
		private const string DB = "db_regressactivity.db";

		// Token: 0x04003762 RID: 14178
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x04003763 RID: 14179
		private const string TABLE = "RegressEntry";

		// Token: 0x04003764 RID: 14180
		private const string COMMAND = "select BinData from `RegressEntry` where EntryType=?";

		// Token: 0x04003765 RID: 14181
		private const string KEY_PREFIX = "RegressEntryByEntryType";

		// Token: 0x04003766 RID: 14182
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003767 RID: 14183
		private static int HandleId;
	}
}
