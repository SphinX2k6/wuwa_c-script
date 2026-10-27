using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008C6 RID: 2246
	public class ConfigRoleSkinByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034B7 RID: 13495 RVA: 0x001833C4 File Offset: 0x001815C4
		static ConfigRoleSkinByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinByGroupId.CreateStaticDefaultValue), new Action(ConfigRoleSkinByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x001833E4 File Offset: 0x001815E4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleSkinByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleSkinByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleSkin"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleSkin` where GroupId=?")
			});
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x00183463 File Offset: 0x00181663
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinByGroupId.LogPair = null;
			ConfigRoleSkinByGroupId.HandleId = 0;
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x00183471 File Offset: 0x00181671
		public static void Init()
		{
			ConfigRoleSkinByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinByGroupId.HandleId, "db_role.db", "select BinData from `RoleSkin` where GroupId=?");
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x0018348C File Offset: 0x0018168C
		[NullableContext(2)]
		public static IReadOnlyList<RoleSkin> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleSkinByGroupId.HandleId, ConfigRoleSkinByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<RoleSkin> readOnlyList = (IReadOnlyList<RoleSkin>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleSkinByGroupId.LogPair.Clear();
			ConfigRoleSkinByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigRoleSkinByGroupId.HandleId, 1, p0GroupId, ConfigRoleSkinByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleSkinByGroupId.HandleId, ConfigRoleSkinByGroupId.LogPair);
				return null;
			}
			List<RoleSkin> list = new List<RoleSkin>();
			while (ConfigCommon.Step(ConfigRoleSkinByGroupId.HandleId, false, ConfigRoleSkinByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleSkinByGroupId.HandleId, 0, ConfigRoleSkinByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleSkinByGroupId.HandleId, ConfigRoleSkinByGroupId.LogPair);
					return null;
				}
				RoleSkin rootAsRoleSkin = RoleSkin.GetRootAsRoleSkin(new ByteBuffer(item2));
				list.Add(rootAsRoleSkin);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleSkinByGroupId.HandleId, ConfigRoleSkinByGroupId.LogPair);
			return list;
		}

		// Token: 0x04003D50 RID: 15696
		private const string DB = "db_role.db";

		// Token: 0x04003D51 RID: 15697
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003D52 RID: 15698
		private const string TABLE = "RoleSkin";

		// Token: 0x04003D53 RID: 15699
		private const string COMMAND = "select BinData from `RoleSkin` where GroupId=?";

		// Token: 0x04003D54 RID: 15700
		private const string KEY_PREFIX = "RoleSkinByGroupId";

		// Token: 0x04003D55 RID: 15701
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D56 RID: 15702
		private static int HandleId;
	}
}
