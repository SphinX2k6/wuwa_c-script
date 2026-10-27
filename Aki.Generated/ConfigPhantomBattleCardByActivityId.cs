using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200065F RID: 1631
	public class ConfigPhantomBattleCardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600264A RID: 9802 RVA: 0x00132263 File Offset: 0x00130463
		static ConfigPhantomBattleCardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardByActivityId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x00132284 File Offset: 0x00130484
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleCardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleCardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleCard"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleCard` where ActivityId=?")
			});
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x00132303 File Offset: 0x00130503
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardByActivityId.LogPair = null;
			ConfigPhantomBattleCardByActivityId.HandleId = 0;
		}

		// Token: 0x0600264D RID: 9805 RVA: 0x00132311 File Offset: 0x00130511
		public static void Init()
		{
			ConfigPhantomBattleCardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardByActivityId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCard` where ActivityId=?");
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x0013232C File Offset: 0x0013052C
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleCard> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleCardByActivityId.HandleId, ConfigPhantomBattleCardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<PhantomBattleCard> readOnlyList = (IReadOnlyList<PhantomBattleCard>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomBattleCardByActivityId.LogPair.Clear();
			ConfigPhantomBattleCardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleCardByActivityId.HandleId, 1, p0ActivityId, ConfigPhantomBattleCardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardByActivityId.HandleId, ConfigPhantomBattleCardByActivityId.LogPair);
				return null;
			}
			List<PhantomBattleCard> list = new List<PhantomBattleCard>();
			while (ConfigCommon.Step(ConfigPhantomBattleCardByActivityId.HandleId, false, ConfigPhantomBattleCardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleCardByActivityId.HandleId, 0, ConfigPhantomBattleCardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleCardByActivityId.HandleId, ConfigPhantomBattleCardByActivityId.LogPair);
					return null;
				}
				PhantomBattleCard rootAsPhantomBattleCard = PhantomBattleCard.GetRootAsPhantomBattleCard(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleCard);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleCardByActivityId.HandleId, ConfigPhantomBattleCardByActivityId.LogPair);
			return list;
		}

		// Token: 0x04002C7F RID: 11391
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002C80 RID: 11392
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002C81 RID: 11393
		private const string TABLE = "PhantomBattleCard";

		// Token: 0x04002C82 RID: 11394
		private const string COMMAND = "select BinData from `PhantomBattleCard` where ActivityId=?";

		// Token: 0x04002C83 RID: 11395
		private const string KEY_PREFIX = "PhantomBattleCardByActivityId";

		// Token: 0x04002C84 RID: 11396
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C85 RID: 11397
		private static int HandleId;
	}
}
