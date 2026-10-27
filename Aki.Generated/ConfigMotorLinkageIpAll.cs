using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005A9 RID: 1449
	public class ConfigMotorLinkageIpAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002203 RID: 8707 RVA: 0x00119EE8 File Offset: 0x001180E8
		static ConfigMotorLinkageIpAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLinkageIpAll.CreateStaticDefaultValue), new Action(ConfigMotorLinkageIpAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x00119F08 File Offset: 0x00118108
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

		// Token: 0x06002205 RID: 8709 RVA: 0x00119F87 File Offset: 0x00118187
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLinkageIpAll.LogPair = null;
			ConfigMotorLinkageIpAll.HandleId = 0;
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x00119F95 File Offset: 0x00118195
		public static void Init()
		{
			ConfigMotorLinkageIpAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLinkageIpAll.HandleId, "db_motorlinkage.db", "select BinData from `MotorLinkageIp`");
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x00119FB0 File Offset: 0x001181B0
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

		// Token: 0x04002783 RID: 10115
		private const string DB = "db_motorlinkage.db";

		// Token: 0x04002784 RID: 10116
		private const string FILE = "m.摩托车IP联动活动.xlsx";

		// Token: 0x04002785 RID: 10117
		private const string TABLE = "MotorLinkageIp";

		// Token: 0x04002786 RID: 10118
		private const string COMMAND = "select BinData from `MotorLinkageIp`";

		// Token: 0x04002787 RID: 10119
		private const string KEY_PREFIX = "MotorLinkageIpAll";

		// Token: 0x04002788 RID: 10120
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002789 RID: 10121
		private static int HandleId;
	}
}
