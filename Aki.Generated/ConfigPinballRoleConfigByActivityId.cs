using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200072B RID: 1835
	public class ConfigPinballRoleConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B12 RID: 11026 RVA: 0x0014CD77 File Offset: 0x0014AF77
		static ConfigPinballRoleConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballRoleConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigPinballRoleConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x0014CD98 File Offset: 0x0014AF98
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

		// Token: 0x06002B14 RID: 11028 RVA: 0x0014CE17 File Offset: 0x0014B017
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballRoleConfigByActivityId.LogPair = null;
			ConfigPinballRoleConfigByActivityId.HandleId = 0;
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x0014CE25 File Offset: 0x0014B025
		public static void Init()
		{
			ConfigPinballRoleConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPinballRoleConfigByActivityId.HandleId, "db_pinballbattle.db", "select BinData from `PinballRoleConfig` where ActivityId=?");
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x0014CE40 File Offset: 0x0014B040
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

		// Token: 0x04003213 RID: 12819
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003214 RID: 12820
		private const string FILE = "x.星弹奇游_角色.xlsx";

		// Token: 0x04003215 RID: 12821
		private const string TABLE = "PinballRoleConfig";

		// Token: 0x04003216 RID: 12822
		private const string COMMAND = "select BinData from `PinballRoleConfig` where ActivityId=?";

		// Token: 0x04003217 RID: 12823
		private const string KEY_PREFIX = "PinballRoleConfigByActivityId";

		// Token: 0x04003218 RID: 12824
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003219 RID: 12825
		private static int HandleId;
	}
}
