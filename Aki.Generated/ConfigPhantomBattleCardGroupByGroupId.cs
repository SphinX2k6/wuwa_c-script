using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200067D RID: 1661
	public class ConfigPhantomBattleCardGroupByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026FE RID: 9982 RVA: 0x001399CC File Offset: 0x00137BCC
		static ConfigPhantomBattleCardGroupByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardGroupByGroupId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardGroupByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x001399EC File Offset: 0x00137BEC
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

		// Token: 0x06002700 RID: 9984 RVA: 0x00139A6B File Offset: 0x00137C6B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardGroupByGroupId.LogPair = null;
			ConfigPhantomBattleCardGroupByGroupId.HandleId = 0;
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x00139A79 File Offset: 0x00137C79
		public static void Init()
		{
			ConfigPhantomBattleCardGroupByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardGroupByGroupId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardGroup` where GroupId=?");
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x00139A94 File Offset: 0x00137C94
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

		// Token: 0x04002D51 RID: 11601
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D52 RID: 11602
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D53 RID: 11603
		private const string TABLE = "PhantomBattleCardGroup";

		// Token: 0x04002D54 RID: 11604
		private const string COMMAND = "select BinData from `PhantomBattleCardGroup` where GroupId=?";

		// Token: 0x04002D55 RID: 11605
		private const string KEY_PREFIX = "PhantomBattleCardGroupByGroupId";

		// Token: 0x04002D56 RID: 11606
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D57 RID: 11607
		private static int HandleId;
	}
}
