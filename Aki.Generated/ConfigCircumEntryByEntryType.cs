using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200016F RID: 367
	public class ConfigCircumEntryByEntryType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600089B RID: 2203 RVA: 0x0008A19B File Offset: 0x0008839B
		static ConfigCircumEntryByEntryType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCircumEntryByEntryType.CreateStaticDefaultValue), new Action(ConfigCircumEntryByEntryType.ResetStaticDefaultValue));
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0008A1BC File Offset: 0x000883BC
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

		// Token: 0x0600089D RID: 2205 RVA: 0x0008A23B File Offset: 0x0008843B
		public static void ResetStaticDefaultValue()
		{
			ConfigCircumEntryByEntryType.LogPair = null;
			ConfigCircumEntryByEntryType.HandleId = 0;
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0008A249 File Offset: 0x00088449
		public static void Init()
		{
			ConfigCircumEntryByEntryType.HandleId = ConfigCommon.InitDataStatement(ConfigCircumEntryByEntryType.HandleId, "db_circumfluence.db", "select BinData from `CircumEntry` where EntryType=?");
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0008A264 File Offset: 0x00088464
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

		// Token: 0x040009ED RID: 2541
		private const string DB = "db_circumfluence.db";

		// Token: 0x040009EE RID: 2542
		private const string FILE = "h.回流活动.xlsx";

		// Token: 0x040009EF RID: 2543
		private const string TABLE = "CircumEntry";

		// Token: 0x040009F0 RID: 2544
		private const string COMMAND = "select BinData from `CircumEntry` where EntryType=?";

		// Token: 0x040009F1 RID: 2545
		private const string KEY_PREFIX = "CircumEntryByEntryType";

		// Token: 0x040009F2 RID: 2546
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009F3 RID: 2547
		private static int HandleId;
	}
}
