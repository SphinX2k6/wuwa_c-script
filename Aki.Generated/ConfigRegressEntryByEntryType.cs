using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007D1 RID: 2001
	public class ConfigRegressEntryByEntryType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EF8 RID: 12024 RVA: 0x00162BB3 File Offset: 0x00160DB3
		static ConfigRegressEntryByEntryType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressEntryByEntryType.CreateStaticDefaultValue), new Action(ConfigRegressEntryByEntryType.ResetStaticDefaultValue));
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x00162BD4 File Offset: 0x00160DD4
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

		// Token: 0x06002EFA RID: 12026 RVA: 0x00162C53 File Offset: 0x00160E53
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressEntryByEntryType.LogPair = null;
			ConfigRegressEntryByEntryType.HandleId = 0;
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x00162C61 File Offset: 0x00160E61
		public static void Init()
		{
			ConfigRegressEntryByEntryType.HandleId = ConfigCommon.InitDataStatement(ConfigRegressEntryByEntryType.HandleId, "db_regressactivity.db", "select BinData from `RegressEntry` where EntryType=?");
		}

		// Token: 0x06002EFC RID: 12028 RVA: 0x00162C7C File Offset: 0x00160E7C
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

		// Token: 0x0400369D RID: 13981
		private const string DB = "db_regressactivity.db";

		// Token: 0x0400369E RID: 13982
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x0400369F RID: 13983
		private const string TABLE = "RegressEntry";

		// Token: 0x040036A0 RID: 13984
		private const string COMMAND = "select BinData from `RegressEntry` where EntryType=?";

		// Token: 0x040036A1 RID: 13985
		private const string KEY_PREFIX = "RegressEntryByEntryType";

		// Token: 0x040036A2 RID: 13986
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036A3 RID: 13987
		private static int HandleId;
	}
}
