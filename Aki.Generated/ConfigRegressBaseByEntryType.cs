using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007C8 RID: 1992
	public class ConfigRegressBaseByEntryType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EC2 RID: 11970 RVA: 0x00161913 File Offset: 0x0015FB13
		static ConfigRegressBaseByEntryType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressBaseByEntryType.CreateStaticDefaultValue), new Action(ConfigRegressBaseByEntryType.ResetStaticDefaultValue));
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x00161934 File Offset: 0x0015FB34
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

		// Token: 0x06002EC4 RID: 11972 RVA: 0x001619B3 File Offset: 0x0015FBB3
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressBaseByEntryType.LogPair = null;
			ConfigRegressBaseByEntryType.HandleId = 0;
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x001619C1 File Offset: 0x0015FBC1
		public static void Init()
		{
			ConfigRegressBaseByEntryType.HandleId = ConfigCommon.InitDataStatement(ConfigRegressBaseByEntryType.HandleId, "db_regressactivity.db", "select BinData from `RegressBase` where EntryType=?");
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x001619DC File Offset: 0x0015FBDC
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

		// Token: 0x0400365E RID: 13918
		private const string DB = "db_regressactivity.db";

		// Token: 0x0400365F RID: 13919
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x04003660 RID: 13920
		private const string TABLE = "RegressBase";

		// Token: 0x04003661 RID: 13921
		private const string COMMAND = "select BinData from `RegressBase` where EntryType=?";

		// Token: 0x04003662 RID: 13922
		private const string KEY_PREFIX = "RegressBaseByEntryType";

		// Token: 0x04003663 RID: 13923
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003664 RID: 13924
		private static int HandleId;
	}
}
