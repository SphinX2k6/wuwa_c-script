using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200066E RID: 1646
	public class ConfigPhantomBattleBadgeByActivityGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026A4 RID: 9892 RVA: 0x00137997 File Offset: 0x00135B97
		static ConfigPhantomBattleBadgeByActivityGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleBadgeByActivityGroupId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleBadgeByActivityGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x001379B8 File Offset: 0x00135BB8
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

		// Token: 0x060026A6 RID: 9894 RVA: 0x00137A37 File Offset: 0x00135C37
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeByActivityGroupId.LogPair = null;
			ConfigPhantomBattleBadgeByActivityGroupId.HandleId = 0;
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x00137A45 File Offset: 0x00135C45
		public static void Init()
		{
			ConfigPhantomBattleBadgeByActivityGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleBadgeByActivityGroupId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleBadge` where ActivityId=? AND GroupId=?");
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x00137A60 File Offset: 0x00135C60
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

		// Token: 0x04002CE8 RID: 11496
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002CE9 RID: 11497
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002CEA RID: 11498
		private const string TABLE = "PhantomBattleBadge";

		// Token: 0x04002CEB RID: 11499
		private const string COMMAND = "select BinData from `PhantomBattleBadge` where ActivityId=? AND GroupId=?";

		// Token: 0x04002CEC RID: 11500
		private const string KEY_PREFIX = "PhantomBattleBadgeByActivityGroupId";

		// Token: 0x04002CED RID: 11501
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CEE RID: 11502
		private static int HandleId;
	}
}
