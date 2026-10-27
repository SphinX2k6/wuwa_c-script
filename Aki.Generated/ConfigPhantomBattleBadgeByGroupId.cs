using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000657 RID: 1623
	public class ConfigPhantomBattleBadgeByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600261A RID: 9754 RVA: 0x001311AB File Offset: 0x0012F3AB
		static ConfigPhantomBattleBadgeByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleBadgeByGroupId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleBadgeByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x001311CC File Offset: 0x0012F3CC
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

		// Token: 0x0600261C RID: 9756 RVA: 0x0013124B File Offset: 0x0012F44B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeByGroupId.LogPair = null;
			ConfigPhantomBattleBadgeByGroupId.HandleId = 0;
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x00131259 File Offset: 0x0012F459
		public static void Init()
		{
			ConfigPhantomBattleBadgeByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleBadgeByGroupId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleBadge` where GroupId=?");
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x00131274 File Offset: 0x0012F474
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

		// Token: 0x04002C47 RID: 11335
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002C48 RID: 11336
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002C49 RID: 11337
		private const string TABLE = "PhantomBattleBadge";

		// Token: 0x04002C4A RID: 11338
		private const string COMMAND = "select BinData from `PhantomBattleBadge` where GroupId=?";

		// Token: 0x04002C4B RID: 11339
		private const string KEY_PREFIX = "PhantomBattleBadgeByGroupId";

		// Token: 0x04002C4C RID: 11340
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C4D RID: 11341
		private static int HandleId;
	}
}
