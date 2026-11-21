using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200017E RID: 382
	public class ConfigCircumBaseByEntryType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008F5 RID: 2293 RVA: 0x0008FAC1 File Offset: 0x0008DCC1
		static ConfigCircumBaseByEntryType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCircumBaseByEntryType.CreateStaticDefaultValue), new Action(ConfigCircumBaseByEntryType.ResetStaticDefaultValue));
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0008FAE0 File Offset: 0x0008DCE0
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

		// Token: 0x060008F7 RID: 2295 RVA: 0x0008FB5F File Offset: 0x0008DD5F
		public static void ResetStaticDefaultValue()
		{
			ConfigCircumBaseByEntryType.LogPair = null;
			ConfigCircumBaseByEntryType.HandleId = 0;
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x0008FB6D File Offset: 0x0008DD6D
		public static void Init()
		{
			ConfigCircumBaseByEntryType.HandleId = ConfigCommon.InitDataStatement(ConfigCircumBaseByEntryType.HandleId, "db_circumfluence.db", "select BinData from `CircumBase` where EntryType=?");
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0008FB88 File Offset: 0x0008DD88
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

		// Token: 0x04000A56 RID: 2646
		private const string DB = "db_circumfluence.db";

		// Token: 0x04000A57 RID: 2647
		private const string FILE = "h.回流活动.xlsx";

		// Token: 0x04000A58 RID: 2648
		private const string TABLE = "CircumBase";

		// Token: 0x04000A59 RID: 2649
		private const string COMMAND = "select BinData from `CircumBase` where EntryType=?";

		// Token: 0x04000A5A RID: 2650
		private const string KEY_PREFIX = "CircumBaseByEntryType";

		// Token: 0x04000A5B RID: 2651
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A5C RID: 2652
		private static int HandleId;
	}
}
