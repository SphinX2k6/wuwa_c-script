using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200017F RID: 383
	public class ConfigCircumEntryByEntryType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008FB RID: 2299 RVA: 0x0008FCF7 File Offset: 0x0008DEF7
		static ConfigCircumEntryByEntryType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCircumEntryByEntryType.CreateStaticDefaultValue), new Action(ConfigCircumEntryByEntryType.ResetStaticDefaultValue));
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0008FD18 File Offset: 0x0008DF18
		public static void CreateStaticDefaultValue()
		{
			ConfigCircumEntryByEntryType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCircumEntryByEntryType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_circumfluence.db"),
				new ValueTuple<string, object>("文件", "h.回流活动.xlsx"),
				new ValueTuple<string, object>("表名", "CircumEntry"),
				new ValueTuple<string, object>("语句", "select BinData from `CircumEntry` where EntryType=?")
			});
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0008FD97 File Offset: 0x0008DF97
		public static void ResetStaticDefaultValue()
		{
			ConfigCircumEntryByEntryType.LogPair = null;
			ConfigCircumEntryByEntryType.HandleId = 0;
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0008FDA5 File Offset: 0x0008DFA5
		public static void Init()
		{
			ConfigCircumEntryByEntryType.HandleId = ConfigCommon.InitDataStatement(ConfigCircumEntryByEntryType.HandleId, "db_circumfluence.db", "select BinData from `CircumEntry` where EntryType=?");
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0008FDC0 File Offset: 0x0008DFC0
		[NullableContext(2)]
		public static IReadOnlyList<CircumEntry> GetConfigList(int p0EntryType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCircumEntryByEntryType.HandleId, ConfigCircumEntryByEntryType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CircumEntryByEntryType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EntryType);
				IReadOnlyList<CircumEntry> readOnlyList = (IReadOnlyList<CircumEntry>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigCircumEntryByEntryType.LogPair.Clear();
			ConfigCircumEntryByEntryType.LogPair.Add(new ValueTuple<string, object>("EntryType", p0EntryType));
			if (!ConfigCommon.BindInt(ConfigCircumEntryByEntryType.HandleId, 1, p0EntryType, ConfigCircumEntryByEntryType.LogPair))
			{
				ConfigCommon.Reset(ConfigCircumEntryByEntryType.HandleId, ConfigCircumEntryByEntryType.LogPair);
				return null;
			}
			List<CircumEntry> list = new List<CircumEntry>();
			while (ConfigCommon.Step(ConfigCircumEntryByEntryType.HandleId, false, ConfigCircumEntryByEntryType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCircumEntryByEntryType.HandleId, 0, ConfigCircumEntryByEntryType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCircumEntryByEntryType.HandleId, ConfigCircumEntryByEntryType.LogPair);
					return null;
				}
				CircumEntry rootAsCircumEntry = CircumEntry.GetRootAsCircumEntry(new ByteBuffer(item2));
				list.Add(rootAsCircumEntry);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CircumEntryByEntryType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EntryType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigCircumEntryByEntryType.HandleId, ConfigCircumEntryByEntryType.LogPair);
			return list;
		}

		// Token: 0x04000A5D RID: 2653
		private const string DB = "db_circumfluence.db";

		// Token: 0x04000A5E RID: 2654
		private const string FILE = "h.回流活动.xlsx";

		// Token: 0x04000A5F RID: 2655
		private const string TABLE = "CircumEntry";

		// Token: 0x04000A60 RID: 2656
		private const string COMMAND = "select BinData from `CircumEntry` where EntryType=?";

		// Token: 0x04000A61 RID: 2657
		private const string KEY_PREFIX = "CircumEntryByEntryType";

		// Token: 0x04000A62 RID: 2658
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A63 RID: 2659
		private static int HandleId;
	}
}
