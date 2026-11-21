using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A60 RID: 2656
	public class ConfigSpringResourceByRoleType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E54 RID: 15956 RVA: 0x001BCFD8 File Offset: 0x001BB1D8
		static ConfigSpringResourceByRoleType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringResourceByRoleType.CreateStaticDefaultValue), new Action(ConfigSpringResourceByRoleType.ResetStaticDefaultValue));
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x001BCFF8 File Offset: 0x001BB1F8
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

		// Token: 0x06003E56 RID: 15958 RVA: 0x001BD077 File Offset: 0x001BB277
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringResourceByRoleType.LogPair = null;
			ConfigSpringResourceByRoleType.HandleId = 0;
		}

		// Token: 0x06003E57 RID: 15959 RVA: 0x001BD085 File Offset: 0x001BB285
		public static void Init()
		{
			ConfigSpringResourceByRoleType.HandleId = ConfigCommon.InitDataStatement(ConfigSpringResourceByRoleType.HandleId, "db_sprintsign.db", "select BinData from `SpringResource` where RoleType=?");
		}

		// Token: 0x06003E58 RID: 15960 RVA: 0x001BD0A0 File Offset: 0x001BB2A0
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

		// Token: 0x04004886 RID: 18566
		private const string DB = "db_sprintsign.db";

		// Token: 0x04004887 RID: 18567
		private const string FILE = "c.2.0春节签到.xlsx";

		// Token: 0x04004888 RID: 18568
		private const string TABLE = "SpringResource";

		// Token: 0x04004889 RID: 18569
		private const string COMMAND = "select BinData from `SpringResource` where RoleType=?";

		// Token: 0x0400488A RID: 18570
		private const string KEY_PREFIX = "SpringResourceByRoleType";

		// Token: 0x0400488B RID: 18571
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400488C RID: 18572
		private static int HandleId;
	}
}
