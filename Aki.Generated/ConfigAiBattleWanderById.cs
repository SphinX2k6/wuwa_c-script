using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200008A RID: 138
	public class ConfigAiBattleWanderById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600033C RID: 828 RVA: 0x0006F3C0 File Offset: 0x0006D5C0
		static ConfigAiBattleWanderById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiBattleWanderById.CreateStaticDefaultValue), new Action(ConfigAiBattleWanderById.ResetStaticDefaultValue));
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0006F3E0 File Offset: 0x0006D5E0
		public static void CreateStaticDefaultValue()
		{
			ConfigAiBattleWanderById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAiBattleWanderById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ai.db"),
				new ValueTuple<string, object>("文件", "a.AI战斗游荡.xlsx"),
				new ValueTuple<string, object>("表名", "AiBattleWander"),
				new ValueTuple<string, object>("语句", "select BinData from `AiBattleWander` where Id=?")
			});
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0006F45F File Offset: 0x0006D65F
		public static void ResetStaticDefaultValue()
		{
			ConfigAiBattleWanderById.LogPair = null;
			ConfigAiBattleWanderById.HandleId = 0;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0006F46D File Offset: 0x0006D66D
		public static void Init()
		{
			ConfigAiBattleWanderById.HandleId = ConfigCommon.InitDataStatement(ConfigAiBattleWanderById.HandleId, "db_ai.db", "select BinData from `AiBattleWander` where Id=?");
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0006F488 File Offset: 0x0006D688
		public static AiBattleWander? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAiBattleWanderById.HandleId, ConfigAiBattleWanderById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiBattleWanderById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AiBattleWander?(AiBattleWander.GetRootAsAiBattleWander(configBuffer));
				}
			}
			ConfigAiBattleWanderById.LogPair.Clear();
			ConfigAiBattleWanderById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAiBattleWanderById.HandleId, 1, p0Id, ConfigAiBattleWanderById.LogPair) || ConfigCommon.Step(ConfigAiBattleWanderById.HandleId, true, ConfigAiBattleWanderById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAiBattleWanderById.HandleId, ConfigAiBattleWanderById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAiBattleWanderById.HandleId, 0, ConfigAiBattleWanderById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAiBattleWanderById.HandleId, ConfigAiBattleWanderById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AiBattleWander rootAsAiBattleWander = AiBattleWander.GetRootAsAiBattleWander(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiBattleWanderById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAiBattleWanderById.HandleId, ConfigAiBattleWanderById.LogPair);
			return new AiBattleWander?(rootAsAiBattleWander);
		}

		// Token: 0x040003AA RID: 938
		private const string DB = "db_ai.db";

		// Token: 0x040003AB RID: 939
		private const string FILE = "a.AI战斗游荡.xlsx";

		// Token: 0x040003AC RID: 940
		private const string TABLE = "AiBattleWander";

		// Token: 0x040003AD RID: 941
		private const string COMMAND = "select BinData from `AiBattleWander` where Id=?";

		// Token: 0x040003AE RID: 942
		private const string KEY_PREFIX = "AiBattleWanderById";

		// Token: 0x040003AF RID: 943
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003B0 RID: 944
		private static int HandleId;
	}
}
