using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000677 RID: 1655
	public class ConfigPhantomBattleCardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026DA RID: 9946 RVA: 0x00138CDF File Offset: 0x00136EDF
		static ConfigPhantomBattleCardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardByActivityId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x00138D00 File Offset: 0x00136F00
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

		// Token: 0x060026DC RID: 9948 RVA: 0x00138D7F File Offset: 0x00136F7F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardByActivityId.LogPair = null;
			ConfigPhantomBattleCardByActivityId.HandleId = 0;
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x00138D8D File Offset: 0x00136F8D
		public static void Init()
		{
			ConfigPhantomBattleCardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardByActivityId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCard` where ActivityId=?");
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x00138DA8 File Offset: 0x00136FA8
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

		// Token: 0x04002D27 RID: 11559
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D28 RID: 11560
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D29 RID: 11561
		private const string TABLE = "PhantomBattleCard";

		// Token: 0x04002D2A RID: 11562
		private const string COMMAND = "select BinData from `PhantomBattleCard` where ActivityId=?";

		// Token: 0x04002D2B RID: 11563
		private const string KEY_PREFIX = "PhantomBattleCardByActivityId";

		// Token: 0x04002D2C RID: 11564
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D2D RID: 11565
		private static int HandleId;
	}
}
