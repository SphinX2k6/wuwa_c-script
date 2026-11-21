using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000743 RID: 1859
	public class ConfigPinballRoleConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BA2 RID: 11170 RVA: 0x001537F3 File Offset: 0x001519F3
		static ConfigPinballRoleConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballRoleConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigPinballRoleConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x00153814 File Offset: 0x00151A14
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballRoleConfigByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballRoleConfigByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_角色.xlsx"),
				new ValueTuple<string, object>("表名", "PinballRoleConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballRoleConfig` where ActivityId=?")
			});
		}

		// Token: 0x06002BA4 RID: 11172 RVA: 0x00153893 File Offset: 0x00151A93
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballRoleConfigByActivityId.LogPair = null;
			ConfigPinballRoleConfigByActivityId.HandleId = 0;
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x001538A1 File Offset: 0x00151AA1
		public static void Init()
		{
			ConfigPinballRoleConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPinballRoleConfigByActivityId.HandleId, "db_pinballbattle.db", "select BinData from `PinballRoleConfig` where ActivityId=?");
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x001538BC File Offset: 0x00151ABC
		[NullableContext(2)]
		public static IReadOnlyList<PinballRoleConfig> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballRoleConfigByActivityId.HandleId, ConfigPinballRoleConfigByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballRoleConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<PinballRoleConfig> readOnlyList = (IReadOnlyList<PinballRoleConfig>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPinballRoleConfigByActivityId.LogPair.Clear();
			ConfigPinballRoleConfigByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigPinballRoleConfigByActivityId.HandleId, 1, p0ActivityId, ConfigPinballRoleConfigByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigPinballRoleConfigByActivityId.HandleId, ConfigPinballRoleConfigByActivityId.LogPair);
				return null;
			}
			List<PinballRoleConfig> list = new List<PinballRoleConfig>();
			while (ConfigCommon.Step(ConfigPinballRoleConfigByActivityId.HandleId, false, ConfigPinballRoleConfigByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballRoleConfigByActivityId.HandleId, 0, ConfigPinballRoleConfigByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPinballRoleConfigByActivityId.HandleId, ConfigPinballRoleConfigByActivityId.LogPair);
					return null;
				}
				PinballRoleConfig rootAsPinballRoleConfig = PinballRoleConfig.GetRootAsPinballRoleConfig(new ByteBuffer(item2));
				list.Add(rootAsPinballRoleConfig);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballRoleConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPinballRoleConfigByActivityId.HandleId, ConfigPinballRoleConfigByActivityId.LogPair);
			return list;
		}

		// Token: 0x040032BB RID: 12987
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040032BC RID: 12988
		private const string FILE = "x.星弹奇游_角色.xlsx";

		// Token: 0x040032BD RID: 12989
		private const string TABLE = "PinballRoleConfig";

		// Token: 0x040032BE RID: 12990
		private const string COMMAND = "select BinData from `PinballRoleConfig` where ActivityId=?";

		// Token: 0x040032BF RID: 12991
		private const string KEY_PREFIX = "PinballRoleConfigByActivityId";

		// Token: 0x040032C0 RID: 12992
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032C1 RID: 12993
		private static int HandleId;
	}
}
