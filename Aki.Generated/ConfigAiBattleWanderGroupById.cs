using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000083 RID: 131
	public class ConfigAiBattleWanderGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000312 RID: 786 RVA: 0x0006AD54 File Offset: 0x00068F54
		static ConfigAiBattleWanderGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiBattleWanderGroupById.CreateStaticDefaultValue), new Action(ConfigAiBattleWanderGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0006AD74 File Offset: 0x00068F74
		public static void CreateStaticDefaultValue()
		{
			ConfigAiBattleWanderGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAiBattleWanderGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ai.db"),
				new ValueTuple<string, object>("文件", "a.AI战斗游荡.xlsx"),
				new ValueTuple<string, object>("表名", "AiBattleWanderGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `AiBattleWanderGroup` where Id=?")
			});
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0006ADF3 File Offset: 0x00068FF3
		public static void ResetStaticDefaultValue()
		{
			ConfigAiBattleWanderGroupById.LogPair = null;
			ConfigAiBattleWanderGroupById.HandleId = 0;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0006AE01 File Offset: 0x00069001
		public static void Init()
		{
			ConfigAiBattleWanderGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigAiBattleWanderGroupById.HandleId, "db_ai.db", "select BinData from `AiBattleWanderGroup` where Id=?");
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0006AE1C File Offset: 0x0006901C
		public static AiBattleWanderGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAiBattleWanderGroupById.HandleId, ConfigAiBattleWanderGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiBattleWanderGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AiBattleWanderGroup?(AiBattleWanderGroup.GetRootAsAiBattleWanderGroup(configBuffer));
				}
			}
			ConfigAiBattleWanderGroupById.LogPair.Clear();
			ConfigAiBattleWanderGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAiBattleWanderGroupById.HandleId, 1, p0Id, ConfigAiBattleWanderGroupById.LogPair) || ConfigCommon.Step(ConfigAiBattleWanderGroupById.HandleId, true, ConfigAiBattleWanderGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAiBattleWanderGroupById.HandleId, ConfigAiBattleWanderGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAiBattleWanderGroupById.HandleId, 0, ConfigAiBattleWanderGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAiBattleWanderGroupById.HandleId, ConfigAiBattleWanderGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AiBattleWanderGroup rootAsAiBattleWanderGroup = AiBattleWanderGroup.GetRootAsAiBattleWanderGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiBattleWanderGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAiBattleWanderGroupById.HandleId, ConfigAiBattleWanderGroupById.LogPair);
			return new AiBattleWanderGroup?(rootAsAiBattleWanderGroup);
		}

		// Token: 0x04000379 RID: 889
		private const string DB = "db_ai.db";

		// Token: 0x0400037A RID: 890
		private const string FILE = "a.AI战斗游荡.xlsx";

		// Token: 0x0400037B RID: 891
		private const string TABLE = "AiBattleWanderGroup";

		// Token: 0x0400037C RID: 892
		private const string COMMAND = "select BinData from `AiBattleWanderGroup` where Id=?";

		// Token: 0x0400037D RID: 893
		private const string KEY_PREFIX = "AiBattleWanderGroupById";

		// Token: 0x0400037E RID: 894
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400037F RID: 895
		private static int HandleId;
	}
}
