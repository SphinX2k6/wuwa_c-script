using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000387 RID: 903
	public class ConfigGachaRoleDevelopInsByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001530 RID: 5424 RVA: 0x000D4DD4 File Offset: 0x000D2FD4
		static ConfigGachaRoleDevelopInsByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaRoleDevelopInsByRoleId.CreateStaticDefaultValue), new Action(ConfigGachaRoleDevelopInsByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x000D4DF4 File Offset: 0x000D2FF4
		public static void CreateStaticDefaultValue()
		{
			ConfigGachaRoleDevelopInsByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGachaRoleDevelopInsByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gacharoledevelop.db"),
				new ValueTuple<string, object>("文件", "d.当期卡池角色养成推荐.xlsx"),
				new ValueTuple<string, object>("表名", "GachaRoleDevelopIns"),
				new ValueTuple<string, object>("语句", "select BinData from `GachaRoleDevelopIns` where RoleId=?")
			});
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x000D4E73 File Offset: 0x000D3073
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaRoleDevelopInsByRoleId.LogPair = null;
			ConfigGachaRoleDevelopInsByRoleId.HandleId = 0;
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x000D4E81 File Offset: 0x000D3081
		public static void Init()
		{
			ConfigGachaRoleDevelopInsByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigGachaRoleDevelopInsByRoleId.HandleId, "db_gacharoledevelop.db", "select BinData from `GachaRoleDevelopIns` where RoleId=?");
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x000D4E9C File Offset: 0x000D309C
		[NullableContext(2)]
		public static IReadOnlyList<GachaRoleDevelopIns> GetConfigList(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaRoleDevelopInsByRoleId.HandleId, ConfigGachaRoleDevelopInsByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaRoleDevelopInsByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				IReadOnlyList<GachaRoleDevelopIns> readOnlyList = (IReadOnlyList<GachaRoleDevelopIns>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigGachaRoleDevelopInsByRoleId.LogPair.Clear();
			ConfigGachaRoleDevelopInsByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigGachaRoleDevelopInsByRoleId.HandleId, 1, p0RoleId, ConfigGachaRoleDevelopInsByRoleId.LogPair))
			{
				ConfigCommon.Reset(ConfigGachaRoleDevelopInsByRoleId.HandleId, ConfigGachaRoleDevelopInsByRoleId.LogPair);
				return null;
			}
			List<GachaRoleDevelopIns> list = new List<GachaRoleDevelopIns>();
			while (ConfigCommon.Step(ConfigGachaRoleDevelopInsByRoleId.HandleId, false, ConfigGachaRoleDevelopInsByRoleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaRoleDevelopInsByRoleId.HandleId, 0, ConfigGachaRoleDevelopInsByRoleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGachaRoleDevelopInsByRoleId.HandleId, ConfigGachaRoleDevelopInsByRoleId.LogPair);
					return null;
				}
				GachaRoleDevelopIns rootAsGachaRoleDevelopIns = GachaRoleDevelopIns.GetRootAsGachaRoleDevelopIns(new ByteBuffer(item2));
				list.Add(rootAsGachaRoleDevelopIns);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaRoleDevelopInsByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigGachaRoleDevelopInsByRoleId.HandleId, ConfigGachaRoleDevelopInsByRoleId.LogPair);
			return list;
		}

		// Token: 0x04001895 RID: 6293
		private const string DB = "db_gacharoledevelop.db";

		// Token: 0x04001896 RID: 6294
		private const string FILE = "d.当期卡池角色养成推荐.xlsx";

		// Token: 0x04001897 RID: 6295
		private const string TABLE = "GachaRoleDevelopIns";

		// Token: 0x04001898 RID: 6296
		private const string COMMAND = "select BinData from `GachaRoleDevelopIns` where RoleId=?";

		// Token: 0x04001899 RID: 6297
		private const string KEY_PREFIX = "GachaRoleDevelopInsByRoleId";

		// Token: 0x0400189A RID: 6298
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400189B RID: 6299
		private static int HandleId;
	}
}
