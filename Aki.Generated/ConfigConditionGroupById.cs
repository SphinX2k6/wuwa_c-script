using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000193 RID: 403
	public class ConfigConditionGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000975 RID: 2421 RVA: 0x0008EFD4 File Offset: 0x0008D1D4
		static ConfigConditionGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigConditionGroupById.CreateStaticDefaultValue), new Action(ConfigConditionGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0008EFF4 File Offset: 0x0008D1F4
		public static void CreateStaticDefaultValue()
		{
			ConfigConditionGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigConditionGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_condition.db"),
				new ValueTuple<string, object>("文件", "t.条件.xlsx"),
				new ValueTuple<string, object>("表名", "ConditionGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `ConditionGroup` where Id=?")
			});
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0008F073 File Offset: 0x0008D273
		public static void ResetStaticDefaultValue()
		{
			ConfigConditionGroupById.LogPair = null;
			ConfigConditionGroupById.HandleId = 0;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0008F081 File Offset: 0x0008D281
		public static void Init()
		{
			ConfigConditionGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigConditionGroupById.HandleId, "db_condition.db", "select BinData from `ConditionGroup` where Id=?");
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0008F09C File Offset: 0x0008D29C
		public static ConditionGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigConditionGroupById.HandleId, ConfigConditionGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ConditionGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ConditionGroup?(ConditionGroup.GetRootAsConditionGroup(configBuffer));
				}
			}
			ConfigConditionGroupById.LogPair.Clear();
			ConfigConditionGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigConditionGroupById.HandleId, 1, p0Id, ConfigConditionGroupById.LogPair) || ConfigCommon.Step(ConfigConditionGroupById.HandleId, true, ConfigConditionGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigConditionGroupById.HandleId, ConfigConditionGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigConditionGroupById.HandleId, 0, ConfigConditionGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigConditionGroupById.HandleId, ConfigConditionGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ConditionGroup rootAsConditionGroup = ConditionGroup.GetRootAsConditionGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ConditionGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigConditionGroupById.HandleId, ConfigConditionGroupById.LogPair);
			return new ConditionGroup?(rootAsConditionGroup);
		}

		// Token: 0x04000AE9 RID: 2793
		private const string DB = "db_condition.db";

		// Token: 0x04000AEA RID: 2794
		private const string FILE = "t.条件.xlsx";

		// Token: 0x04000AEB RID: 2795
		private const string TABLE = "ConditionGroup";

		// Token: 0x04000AEC RID: 2796
		private const string COMMAND = "select BinData from `ConditionGroup` where Id=?";

		// Token: 0x04000AED RID: 2797
		private const string KEY_PREFIX = "ConditionGroupById";

		// Token: 0x04000AEE RID: 2798
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000AEF RID: 2799
		private static int HandleId;
	}
}
