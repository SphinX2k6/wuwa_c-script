using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200098B RID: 2443
	public class ConfigSpringResourceByRoleType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003956 RID: 14678 RVA: 0x0019DC44 File Offset: 0x0019BE44
		static ConfigSpringResourceByRoleType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringResourceByRoleType.CreateStaticDefaultValue), new Action(ConfigSpringResourceByRoleType.ResetStaticDefaultValue));
		}

		// Token: 0x06003957 RID: 14679 RVA: 0x0019DC64 File Offset: 0x0019BE64
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringResourceByRoleType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringResourceByRoleType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sprintsign.db"),
				new ValueTuple<string, object>("文件", "c.2.0春节签到.xlsx"),
				new ValueTuple<string, object>("表名", "SpringResource"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringResource` where RoleType=?")
			});
		}

		// Token: 0x06003958 RID: 14680 RVA: 0x0019DCE3 File Offset: 0x0019BEE3
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringResourceByRoleType.LogPair = null;
			ConfigSpringResourceByRoleType.HandleId = 0;
		}

		// Token: 0x06003959 RID: 14681 RVA: 0x0019DCF1 File Offset: 0x0019BEF1
		public static void Init()
		{
			ConfigSpringResourceByRoleType.HandleId = ConfigCommon.InitDataStatement(ConfigSpringResourceByRoleType.HandleId, "db_sprintsign.db", "select BinData from `SpringResource` where RoleType=?");
		}

		// Token: 0x0600395A RID: 14682 RVA: 0x0019DD0C File Offset: 0x0019BF0C
		[NullableContext(2)]
		public static IReadOnlyList<SpringResource> GetConfigList(int p0RoleType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringResourceByRoleType.HandleId, ConfigSpringResourceByRoleType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringResourceByRoleType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleType);
				IReadOnlyList<SpringResource> readOnlyList = (IReadOnlyList<SpringResource>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSpringResourceByRoleType.LogPair.Clear();
			ConfigSpringResourceByRoleType.LogPair.Add(new ValueTuple<string, object>("RoleType", p0RoleType));
			if (!ConfigCommon.BindInt(ConfigSpringResourceByRoleType.HandleId, 1, p0RoleType, ConfigSpringResourceByRoleType.LogPair))
			{
				ConfigCommon.Reset(ConfigSpringResourceByRoleType.HandleId, ConfigSpringResourceByRoleType.LogPair);
				return null;
			}
			List<SpringResource> list = new List<SpringResource>();
			while (ConfigCommon.Step(ConfigSpringResourceByRoleType.HandleId, false, ConfigSpringResourceByRoleType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringResourceByRoleType.HandleId, 0, ConfigSpringResourceByRoleType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSpringResourceByRoleType.HandleId, ConfigSpringResourceByRoleType.LogPair);
					return null;
				}
				SpringResource rootAsSpringResource = SpringResource.GetRootAsSpringResource(new ByteBuffer(item2));
				list.Add(rootAsSpringResource);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringResourceByRoleType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSpringResourceByRoleType.HandleId, ConfigSpringResourceByRoleType.LogPair);
			return list;
		}

		// Token: 0x040042B3 RID: 17075
		private const string DB = "db_sprintsign.db";

		// Token: 0x040042B4 RID: 17076
		private const string FILE = "c.2.0春节签到.xlsx";

		// Token: 0x040042B5 RID: 17077
		private const string TABLE = "SpringResource";

		// Token: 0x040042B6 RID: 17078
		private const string COMMAND = "select BinData from `SpringResource` where RoleType=?";

		// Token: 0x040042B7 RID: 17079
		private const string KEY_PREFIX = "SpringResourceByRoleType";

		// Token: 0x040042B8 RID: 17080
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042B9 RID: 17081
		private static int HandleId;
	}
}
