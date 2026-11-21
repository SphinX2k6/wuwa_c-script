using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001A5 RID: 421
	public class ConfigConditionGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009E1 RID: 2529 RVA: 0x00094F0C File Offset: 0x0009310C
		static ConfigConditionGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigConditionGroupById.CreateStaticDefaultValue), new Action(ConfigConditionGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00094F2C File Offset: 0x0009312C
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

		// Token: 0x060009E3 RID: 2531 RVA: 0x00094FAB File Offset: 0x000931AB
		public static void ResetStaticDefaultValue()
		{
			ConfigConditionGroupById.LogPair = null;
			ConfigConditionGroupById.HandleId = 0;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00094FB9 File Offset: 0x000931B9
		public static void Init()
		{
			ConfigConditionGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigConditionGroupById.HandleId, "db_condition.db", "select BinData from `ConditionGroup` where Id=?");
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00094FD4 File Offset: 0x000931D4
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

		// Token: 0x04000B67 RID: 2919
		private const string DB = "db_condition.db";

		// Token: 0x04000B68 RID: 2920
		private const string FILE = "t.条件.xlsx";

		// Token: 0x04000B69 RID: 2921
		private const string TABLE = "ConditionGroup";

		// Token: 0x04000B6A RID: 2922
		private const string COMMAND = "select BinData from `ConditionGroup` where Id=?";

		// Token: 0x04000B6B RID: 2923
		private const string KEY_PREFIX = "ConditionGroupById";

		// Token: 0x04000B6C RID: 2924
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B6D RID: 2925
		private static int HandleId;
	}
}
