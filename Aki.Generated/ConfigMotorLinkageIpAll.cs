using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005C0 RID: 1472
	public class ConfigMotorLinkageIpAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600228D RID: 8845 RVA: 0x001207D0 File Offset: 0x0011E9D0
		static ConfigMotorLinkageIpAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLinkageIpAll.CreateStaticDefaultValue), new Action(ConfigMotorLinkageIpAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x001207F0 File Offset: 0x0011E9F0
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorLinkageIpAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorLinkageIpAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorlinkage.db"),
				new ValueTuple<string, object>("文件", "m.摩托车IP联动活动.xlsx"),
				new ValueTuple<string, object>("表名", "MotorLinkageIp"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorLinkageIp`")
			});
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x0012086F File Offset: 0x0011EA6F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLinkageIpAll.LogPair = null;
			ConfigMotorLinkageIpAll.HandleId = 0;
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x0012087D File Offset: 0x0011EA7D
		public static void Init()
		{
			ConfigMotorLinkageIpAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLinkageIpAll.HandleId, "db_motorlinkage.db", "select BinData from `MotorLinkageIp`");
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x00120898 File Offset: 0x0011EA98
		[NullableContext(2)]
		public static IReadOnlyList<MotorLinkageIp> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorLinkageIpAll.HandleId, ConfigMotorLinkageIpAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorLinkageIp> readOnlyList = (IReadOnlyList<MotorLinkageIp>)ConfigCommon.GetConfig("MotorLinkageIpAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorLinkageIp> list = new List<MotorLinkageIp>();
			while (ConfigCommon.Step(ConfigMotorLinkageIpAll.HandleId, false, ConfigMotorLinkageIpAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorLinkageIpAll.HandleId, 0, ConfigMotorLinkageIpAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorLinkageIpAll.HandleId, ConfigMotorLinkageIpAll.LogPair);
					return null;
				}
				MotorLinkageIp rootAsMotorLinkageIp = MotorLinkageIp.GetRootAsMotorLinkageIp(new ByteBuffer(item2));
				list.Add(rootAsMotorLinkageIp);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorLinkageIpAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorLinkageIpAll.HandleId, ConfigMotorLinkageIpAll.LogPair);
			return list;
		}

		// Token: 0x04002824 RID: 10276
		private const string DB = "db_motorlinkage.db";

		// Token: 0x04002825 RID: 10277
		private const string FILE = "m.摩托车IP联动活动.xlsx";

		// Token: 0x04002826 RID: 10278
		private const string TABLE = "MotorLinkageIp";

		// Token: 0x04002827 RID: 10279
		private const string COMMAND = "select BinData from `MotorLinkageIp`";

		// Token: 0x04002828 RID: 10280
		private const string KEY_PREFIX = "MotorLinkageIpAll";

		// Token: 0x04002829 RID: 10281
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400282A RID: 10282
		private static int HandleId;
	}
}
