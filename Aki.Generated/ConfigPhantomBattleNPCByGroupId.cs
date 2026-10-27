using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000682 RID: 1666
	public class ConfigPhantomBattleNPCByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600271C RID: 10012 RVA: 0x00136D08 File Offset: 0x00134F08
		static ConfigPhantomBattleNPCByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleNPCByGroupId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleNPCByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x00136D28 File Offset: 0x00134F28
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleNPCByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleNPCByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleNPC"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleNPC` where GroupId=?")
			});
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x00136DA7 File Offset: 0x00134FA7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleNPCByGroupId.LogPair = null;
			ConfigPhantomBattleNPCByGroupId.HandleId = 0;
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x00136DB5 File Offset: 0x00134FB5
		public static void Init()
		{
			ConfigPhantomBattleNPCByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleNPCByGroupId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleNPC` where GroupId=?");
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x00136DD0 File Offset: 0x00134FD0
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleNPC> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleNPCByGroupId.HandleId, ConfigPhantomBattleNPCByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleNPCByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<PhantomBattleNPC> readOnlyList = (IReadOnlyList<PhantomBattleNPC>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomBattleNPCByGroupId.LogPair.Clear();
			ConfigPhantomBattleNPCByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleNPCByGroupId.HandleId, 1, p0GroupId, ConfigPhantomBattleNPCByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomBattleNPCByGroupId.HandleId, ConfigPhantomBattleNPCByGroupId.LogPair);
				return null;
			}
			List<PhantomBattleNPC> list = new List<PhantomBattleNPC>();
			while (ConfigCommon.Step(ConfigPhantomBattleNPCByGroupId.HandleId, false, ConfigPhantomBattleNPCByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleNPCByGroupId.HandleId, 0, ConfigPhantomBattleNPCByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleNPCByGroupId.HandleId, ConfigPhantomBattleNPCByGroupId.LogPair);
					return null;
				}
				PhantomBattleNPC rootAsPhantomBattleNPC = PhantomBattleNPC.GetRootAsPhantomBattleNPC(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleNPC);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleNPCByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleNPCByGroupId.HandleId, ConfigPhantomBattleNPCByGroupId.LogPair);
			return list;
		}

		// Token: 0x04002D74 RID: 11636
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D75 RID: 11637
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D76 RID: 11638
		private const string TABLE = "PhantomBattleNPC";

		// Token: 0x04002D77 RID: 11639
		private const string COMMAND = "select BinData from `PhantomBattleNPC` where GroupId=?";

		// Token: 0x04002D78 RID: 11640
		private const string KEY_PREFIX = "PhantomBattleNPCByGroupId";

		// Token: 0x04002D79 RID: 11641
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D7A RID: 11642
		private static int HandleId;
	}
}
