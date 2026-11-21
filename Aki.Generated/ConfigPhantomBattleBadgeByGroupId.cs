using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200066F RID: 1647
	public class ConfigPhantomBattleBadgeByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026AA RID: 9898 RVA: 0x00137C27 File Offset: 0x00135E27
		static ConfigPhantomBattleBadgeByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleBadgeByGroupId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleBadgeByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x00137C48 File Offset: 0x00135E48
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleBadgeByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleBadge"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleBadge` where GroupId=?")
			});
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x00137CC7 File Offset: 0x00135EC7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeByGroupId.LogPair = null;
			ConfigPhantomBattleBadgeByGroupId.HandleId = 0;
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x00137CD5 File Offset: 0x00135ED5
		public static void Init()
		{
			ConfigPhantomBattleBadgeByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleBadgeByGroupId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleBadge` where GroupId=?");
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x00137CF0 File Offset: 0x00135EF0
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleBadge> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleBadgeByGroupId.HandleId, ConfigPhantomBattleBadgeByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleBadgeByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<PhantomBattleBadge> readOnlyList = (IReadOnlyList<PhantomBattleBadge>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomBattleBadgeByGroupId.LogPair.Clear();
			ConfigPhantomBattleBadgeByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleBadgeByGroupId.HandleId, 1, p0GroupId, ConfigPhantomBattleBadgeByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomBattleBadgeByGroupId.HandleId, ConfigPhantomBattleBadgeByGroupId.LogPair);
				return null;
			}
			List<PhantomBattleBadge> list = new List<PhantomBattleBadge>();
			while (ConfigCommon.Step(ConfigPhantomBattleBadgeByGroupId.HandleId, false, ConfigPhantomBattleBadgeByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleBadgeByGroupId.HandleId, 0, ConfigPhantomBattleBadgeByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleBadgeByGroupId.HandleId, ConfigPhantomBattleBadgeByGroupId.LogPair);
					return null;
				}
				PhantomBattleBadge rootAsPhantomBattleBadge = PhantomBattleBadge.GetRootAsPhantomBattleBadge(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleBadge);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleBadgeByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleBadgeByGroupId.HandleId, ConfigPhantomBattleBadgeByGroupId.LogPair);
			return list;
		}

		// Token: 0x04002CEF RID: 11503
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002CF0 RID: 11504
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002CF1 RID: 11505
		private const string TABLE = "PhantomBattleBadge";

		// Token: 0x04002CF2 RID: 11506
		private const string COMMAND = "select BinData from `PhantomBattleBadge` where GroupId=?";

		// Token: 0x04002CF3 RID: 11507
		private const string KEY_PREFIX = "PhantomBattleBadgeByGroupId";

		// Token: 0x04002CF4 RID: 11508
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CF5 RID: 11509
		private static int HandleId;
	}
}
