using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008C3 RID: 2243
	public class ConfigRoleSkinAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034A5 RID: 13477 RVA: 0x00182DA0 File Offset: 0x00180FA0
		static ConfigRoleSkinAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinAll.CreateStaticDefaultValue), new Action(ConfigRoleSkinAll.ResetStaticDefaultValue));
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x00182DC0 File Offset: 0x00180FC0
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleSkinAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleSkinAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleSkin"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleSkin`")
			});
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x00182E3F File Offset: 0x0018103F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinAll.LogPair = null;
			ConfigRoleSkinAll.HandleId = 0;
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x00182E4D File Offset: 0x0018104D
		public static void Init()
		{
			ConfigRoleSkinAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinAll.HandleId, "db_role.db", "select BinData from `RoleSkin`");
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x00182E68 File Offset: 0x00181068
		[NullableContext(2)]
		public static IReadOnlyList<RoleSkin> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleSkinAll.HandleId, ConfigRoleSkinAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleSkin> readOnlyList = (IReadOnlyList<RoleSkin>)ConfigCommon.GetConfig("RoleSkinAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleSkin> list = new List<RoleSkin>();
			while (ConfigCommon.Step(ConfigRoleSkinAll.HandleId, false, ConfigRoleSkinAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleSkinAll.HandleId, 0, ConfigRoleSkinAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleSkinAll.HandleId, ConfigRoleSkinAll.LogPair);
					return null;
				}
				RoleSkin rootAsRoleSkin = RoleSkin.GetRootAsRoleSkin(new ByteBuffer(item2));
				list.Add(rootAsRoleSkin);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleSkinAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleSkinAll.HandleId, ConfigRoleSkinAll.LogPair);
			return list;
		}

		// Token: 0x04003D3B RID: 15675
		private const string DB = "db_role.db";

		// Token: 0x04003D3C RID: 15676
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003D3D RID: 15677
		private const string TABLE = "RoleSkin";

		// Token: 0x04003D3E RID: 15678
		private const string COMMAND = "select BinData from `RoleSkin`";

		// Token: 0x04003D3F RID: 15679
		private const string KEY_PREFIX = "RoleSkinAll";

		// Token: 0x04003D40 RID: 15680
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D41 RID: 15681
		private static int HandleId;
	}
}
