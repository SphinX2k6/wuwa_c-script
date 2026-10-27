using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000656 RID: 1622
	public class ConfigPhantomBattleBadgeByActivityGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002614 RID: 9748 RVA: 0x00130F1B File Offset: 0x0012F11B
		static ConfigPhantomBattleBadgeByActivityGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleBadgeByActivityGroupId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleBadgeByActivityGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x00130F3C File Offset: 0x0012F13C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeByActivityGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleBadgeByActivityGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleBadge"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleBadge` where ActivityId=? AND GroupId=?")
			});
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x00130FBB File Offset: 0x0012F1BB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeByActivityGroupId.LogPair = null;
			ConfigPhantomBattleBadgeByActivityGroupId.HandleId = 0;
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x00130FC9 File Offset: 0x0012F1C9
		public static void Init()
		{
			ConfigPhantomBattleBadgeByActivityGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleBadgeByActivityGroupId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleBadge` where ActivityId=? AND GroupId=?");
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x00130FE4 File Offset: 0x0012F1E4
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleBadge> GetConfigList(int p0ActivityId, int p1GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleBadgeByActivityGroupId.HandleId, ConfigPhantomBattleBadgeByActivityGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleBadgeByActivityGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1GroupId);
				IReadOnlyList<PhantomBattleBadge> readOnlyList = (IReadOnlyList<PhantomBattleBadge>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomBattleBadgeByActivityGroupId.LogPair.Clear();
			ConfigPhantomBattleBadgeByActivityGroupId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			ConfigPhantomBattleBadgeByActivityGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p1GroupId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleBadgeByActivityGroupId.HandleId, 1, p0ActivityId, ConfigPhantomBattleBadgeByActivityGroupId.LogPair) || !ConfigCommon.BindInt(ConfigPhantomBattleBadgeByActivityGroupId.HandleId, 2, p1GroupId, ConfigPhantomBattleBadgeByActivityGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomBattleBadgeByActivityGroupId.HandleId, ConfigPhantomBattleBadgeByActivityGroupId.LogPair);
				return null;
			}
			List<PhantomBattleBadge> list = new List<PhantomBattleBadge>();
			while (ConfigCommon.Step(ConfigPhantomBattleBadgeByActivityGroupId.HandleId, false, ConfigPhantomBattleBadgeByActivityGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleBadgeByActivityGroupId.HandleId, 0, ConfigPhantomBattleBadgeByActivityGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleBadgeByActivityGroupId.HandleId, ConfigPhantomBattleBadgeByActivityGroupId.LogPair);
					return null;
				}
				PhantomBattleBadge rootAsPhantomBattleBadge = PhantomBattleBadge.GetRootAsPhantomBattleBadge(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleBadge);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleBadgeByActivityGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleBadgeByActivityGroupId.HandleId, ConfigPhantomBattleBadgeByActivityGroupId.LogPair);
			return list;
		}

		// Token: 0x04002C40 RID: 11328
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002C41 RID: 11329
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002C42 RID: 11330
		private const string TABLE = "PhantomBattleBadge";

		// Token: 0x04002C43 RID: 11331
		private const string COMMAND = "select BinData from `PhantomBattleBadge` where ActivityId=? AND GroupId=?";

		// Token: 0x04002C44 RID: 11332
		private const string KEY_PREFIX = "PhantomBattleBadgeByActivityGroupId";

		// Token: 0x04002C45 RID: 11333
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C46 RID: 11334
		private static int HandleId;
	}
}
