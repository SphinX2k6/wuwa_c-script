using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200016E RID: 366
	public class ConfigCircumBaseByEntryType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000895 RID: 2197 RVA: 0x00089F65 File Offset: 0x00088165
		static ConfigCircumBaseByEntryType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCircumBaseByEntryType.CreateStaticDefaultValue), new Action(ConfigCircumBaseByEntryType.ResetStaticDefaultValue));
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00089F84 File Offset: 0x00088184
		public static void CreateStaticDefaultValue()
		{
			ConfigCircumBaseByEntryType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCircumBaseByEntryType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_circumfluence.db"),
				new ValueTuple<string, object>("文件", "h.回流活动.xlsx"),
				new ValueTuple<string, object>("表名", "CircumBase"),
				new ValueTuple<string, object>("语句", "select BinData from `CircumBase` where EntryType=?")
			});
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x0008A003 File Offset: 0x00088203
		public static void ResetStaticDefaultValue()
		{
			ConfigCircumBaseByEntryType.LogPair = null;
			ConfigCircumBaseByEntryType.HandleId = 0;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x0008A011 File Offset: 0x00088211
		public static void Init()
		{
			ConfigCircumBaseByEntryType.HandleId = ConfigCommon.InitDataStatement(ConfigCircumBaseByEntryType.HandleId, "db_circumfluence.db", "select BinData from `CircumBase` where EntryType=?");
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0008A02C File Offset: 0x0008822C
		[NullableContext(2)]
		public static IReadOnlyList<CircumBase> GetConfigList(int p0EntryType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCircumBaseByEntryType.HandleId, ConfigCircumBaseByEntryType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CircumBaseByEntryType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EntryType);
				IReadOnlyList<CircumBase> readOnlyList = (IReadOnlyList<CircumBase>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigCircumBaseByEntryType.LogPair.Clear();
			ConfigCircumBaseByEntryType.LogPair.Add(new ValueTuple<string, object>("EntryType", p0EntryType));
			if (!ConfigCommon.BindInt(ConfigCircumBaseByEntryType.HandleId, 1, p0EntryType, ConfigCircumBaseByEntryType.LogPair))
			{
				ConfigCommon.Reset(ConfigCircumBaseByEntryType.HandleId, ConfigCircumBaseByEntryType.LogPair);
				return null;
			}
			List<CircumBase> list = new List<CircumBase>();
			while (ConfigCommon.Step(ConfigCircumBaseByEntryType.HandleId, false, ConfigCircumBaseByEntryType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCircumBaseByEntryType.HandleId, 0, ConfigCircumBaseByEntryType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCircumBaseByEntryType.HandleId, ConfigCircumBaseByEntryType.LogPair);
					return null;
				}
				CircumBase rootAsCircumBase = CircumBase.GetRootAsCircumBase(new ByteBuffer(item2));
				list.Add(rootAsCircumBase);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CircumBaseByEntryType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EntryType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigCircumBaseByEntryType.HandleId, ConfigCircumBaseByEntryType.LogPair);
			return list;
		}

		// Token: 0x040009E6 RID: 2534
		private const string DB = "db_circumfluence.db";

		// Token: 0x040009E7 RID: 2535
		private const string FILE = "h.回流活动.xlsx";

		// Token: 0x040009E8 RID: 2536
		private const string TABLE = "CircumBase";

		// Token: 0x040009E9 RID: 2537
		private const string COMMAND = "select BinData from `CircumBase` where EntryType=?";

		// Token: 0x040009EA RID: 2538
		private const string KEY_PREFIX = "CircumBaseByEntryType";

		// Token: 0x040009EB RID: 2539
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009EC RID: 2540
		private static int HandleId;
	}
}
