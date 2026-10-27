using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000665 RID: 1637
	public class ConfigPhantomBattleCardGroupByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600266E RID: 9838 RVA: 0x00132F50 File Offset: 0x00131150
		static ConfigPhantomBattleCardGroupByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardGroupByGroupId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardGroupByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x00132F70 File Offset: 0x00131170
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleCardGroupByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleCardGroupByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleCardGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleCardGroup` where GroupId=?")
			});
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x00132FEF File Offset: 0x001311EF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardGroupByGroupId.LogPair = null;
			ConfigPhantomBattleCardGroupByGroupId.HandleId = 0;
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x00132FFD File Offset: 0x001311FD
		public static void Init()
		{
			ConfigPhantomBattleCardGroupByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardGroupByGroupId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardGroup` where GroupId=?");
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x00133018 File Offset: 0x00131218
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleCardGroup> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleCardGroupByGroupId.HandleId, ConfigPhantomBattleCardGroupByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardGroupByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<PhantomBattleCardGroup> readOnlyList = (IReadOnlyList<PhantomBattleCardGroup>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomBattleCardGroupByGroupId.LogPair.Clear();
			ConfigPhantomBattleCardGroupByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleCardGroupByGroupId.HandleId, 1, p0GroupId, ConfigPhantomBattleCardGroupByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardGroupByGroupId.HandleId, ConfigPhantomBattleCardGroupByGroupId.LogPair);
				return null;
			}
			List<PhantomBattleCardGroup> list = new List<PhantomBattleCardGroup>();
			while (ConfigCommon.Step(ConfigPhantomBattleCardGroupByGroupId.HandleId, false, ConfigPhantomBattleCardGroupByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleCardGroupByGroupId.HandleId, 0, ConfigPhantomBattleCardGroupByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleCardGroupByGroupId.HandleId, ConfigPhantomBattleCardGroupByGroupId.LogPair);
					return null;
				}
				PhantomBattleCardGroup rootAsPhantomBattleCardGroup = PhantomBattleCardGroup.GetRootAsPhantomBattleCardGroup(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleCardGroup);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardGroupByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleCardGroupByGroupId.HandleId, ConfigPhantomBattleCardGroupByGroupId.LogPair);
			return list;
		}

		// Token: 0x04002CA9 RID: 11433
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002CAA RID: 11434
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002CAB RID: 11435
		private const string TABLE = "PhantomBattleCardGroup";

		// Token: 0x04002CAC RID: 11436
		private const string COMMAND = "select BinData from `PhantomBattleCardGroup` where GroupId=?";

		// Token: 0x04002CAD RID: 11437
		private const string KEY_PREFIX = "PhantomBattleCardGroupByGroupId";

		// Token: 0x04002CAE RID: 11438
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CAF RID: 11439
		private static int HandleId;
	}
}
