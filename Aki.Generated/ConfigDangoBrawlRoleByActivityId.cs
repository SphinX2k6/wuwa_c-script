using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001DC RID: 476
	public class ConfigDangoBrawlRoleByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B2B RID: 2859 RVA: 0x00098B38 File Offset: 0x00096D38
		static ConfigDangoBrawlRoleByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlRoleByActivityId.CreateStaticDefaultValue), new Action(ConfigDangoBrawlRoleByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00098B58 File Offset: 0x00096D58
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlRoleByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlRoleByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlRole"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlRole` where ActivityId=?")
			});
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00098BD7 File Offset: 0x00096DD7
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlRoleByActivityId.LogPair = null;
			ConfigDangoBrawlRoleByActivityId.HandleId = 0;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00098BE5 File Offset: 0x00096DE5
		public static void Init()
		{
			ConfigDangoBrawlRoleByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlRoleByActivityId.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlRole` where ActivityId=?");
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00098C00 File Offset: 0x00096E00
		[NullableContext(2)]
		public static IReadOnlyList<DangoBrawlRole> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlRoleByActivityId.HandleId, ConfigDangoBrawlRoleByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlRoleByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<DangoBrawlRole> readOnlyList = (IReadOnlyList<DangoBrawlRole>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigDangoBrawlRoleByActivityId.LogPair.Clear();
			ConfigDangoBrawlRoleByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlRoleByActivityId.HandleId, 1, p0ActivityId, ConfigDangoBrawlRoleByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigDangoBrawlRoleByActivityId.HandleId, ConfigDangoBrawlRoleByActivityId.LogPair);
				return null;
			}
			List<DangoBrawlRole> list = new List<DangoBrawlRole>();
			while (ConfigCommon.Step(ConfigDangoBrawlRoleByActivityId.HandleId, false, ConfigDangoBrawlRoleByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlRoleByActivityId.HandleId, 0, ConfigDangoBrawlRoleByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDangoBrawlRoleByActivityId.HandleId, ConfigDangoBrawlRoleByActivityId.LogPair);
					return null;
				}
				DangoBrawlRole rootAsDangoBrawlRole = DangoBrawlRole.GetRootAsDangoBrawlRole(new ByteBuffer(item2));
				list.Add(rootAsDangoBrawlRole);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlRoleByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigDangoBrawlRoleByActivityId.HandleId, ConfigDangoBrawlRoleByActivityId.LogPair);
			return list;
		}

		// Token: 0x04000CE8 RID: 3304
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CE9 RID: 3305
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000CEA RID: 3306
		private const string TABLE = "DangoBrawlRole";

		// Token: 0x04000CEB RID: 3307
		private const string COMMAND = "select BinData from `DangoBrawlRole` where ActivityId=?";

		// Token: 0x04000CEC RID: 3308
		private const string KEY_PREFIX = "DangoBrawlRoleByActivityId";

		// Token: 0x04000CED RID: 3309
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CEE RID: 3310
		private static int HandleId;
	}
}
