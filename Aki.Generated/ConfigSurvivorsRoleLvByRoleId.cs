using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A7B RID: 2683
	public class ConfigSurvivorsRoleLvByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EF6 RID: 16118 RVA: 0x001C0BCC File Offset: 0x001BEDCC
		static ConfigSurvivorsRoleLvByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsRoleLvByRoleId.CreateStaticDefaultValue), new Action(ConfigSurvivorsRoleLvByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x001C0BEC File Offset: 0x001BEDEC
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsRoleLvByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsRoleLvByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局内.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsRoleLv"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsRoleLv` where RoleId=?")
			});
		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x001C0C6B File Offset: 0x001BEE6B
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsRoleLvByRoleId.LogPair = null;
			ConfigSurvivorsRoleLvByRoleId.HandleId = 0;
		}

		// Token: 0x06003EF9 RID: 16121 RVA: 0x001C0C79 File Offset: 0x001BEE79
		public static void Init()
		{
			ConfigSurvivorsRoleLvByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsRoleLvByRoleId.HandleId, "db_survivors.db", "select BinData from `SurvivorsRoleLv` where RoleId=?");
		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x001C0C94 File Offset: 0x001BEE94
		[NullableContext(2)]
		public static IReadOnlyList<SurvivorsRoleLv> GetConfigList(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsRoleLvByRoleId.HandleId, ConfigSurvivorsRoleLvByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsRoleLvByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				IReadOnlyList<SurvivorsRoleLv> readOnlyList = (IReadOnlyList<SurvivorsRoleLv>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSurvivorsRoleLvByRoleId.LogPair.Clear();
			ConfigSurvivorsRoleLvByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigSurvivorsRoleLvByRoleId.HandleId, 1, p0RoleId, ConfigSurvivorsRoleLvByRoleId.LogPair))
			{
				ConfigCommon.Reset(ConfigSurvivorsRoleLvByRoleId.HandleId, ConfigSurvivorsRoleLvByRoleId.LogPair);
				return null;
			}
			List<SurvivorsRoleLv> list = new List<SurvivorsRoleLv>();
			while (ConfigCommon.Step(ConfigSurvivorsRoleLvByRoleId.HandleId, false, ConfigSurvivorsRoleLvByRoleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsRoleLvByRoleId.HandleId, 0, ConfigSurvivorsRoleLvByRoleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSurvivorsRoleLvByRoleId.HandleId, ConfigSurvivorsRoleLvByRoleId.LogPair);
					return null;
				}
				SurvivorsRoleLv rootAsSurvivorsRoleLv = SurvivorsRoleLv.GetRootAsSurvivorsRoleLv(new ByteBuffer(item2));
				list.Add(rootAsSurvivorsRoleLv);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsRoleLvByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSurvivorsRoleLvByRoleId.HandleId, ConfigSurvivorsRoleLvByRoleId.LogPair);
			return list;
		}

		// Token: 0x04004943 RID: 18755
		private const string DB = "db_survivors.db";

		// Token: 0x04004944 RID: 18756
		private const string FILE = "x.幸存者_局内.xlsx";

		// Token: 0x04004945 RID: 18757
		private const string TABLE = "SurvivorsRoleLv";

		// Token: 0x04004946 RID: 18758
		private const string COMMAND = "select BinData from `SurvivorsRoleLv` where RoleId=?";

		// Token: 0x04004947 RID: 18759
		private const string KEY_PREFIX = "SurvivorsRoleLvByRoleId";

		// Token: 0x04004948 RID: 18760
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004949 RID: 18761
		private static int HandleId;
	}
}
