using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005C3 RID: 1475
	public class ConfigMotorLinkageQuestByIp : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600229F RID: 8863 RVA: 0x00120D3F File Offset: 0x0011EF3F
		static ConfigMotorLinkageQuestByIp()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLinkageQuestByIp.CreateStaticDefaultValue), new Action(ConfigMotorLinkageQuestByIp.ResetStaticDefaultValue));
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x00120D60 File Offset: 0x0011EF60
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorLinkageQuestByIp.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorLinkageQuestByIp.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorlinkage.db"),
				new ValueTuple<string, object>("文件", "m.摩托车IP联动活动.xlsx"),
				new ValueTuple<string, object>("表名", "MotorLinkageQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorLinkageQuest` where Ip=?")
			});
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x00120DDF File Offset: 0x0011EFDF
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLinkageQuestByIp.LogPair = null;
			ConfigMotorLinkageQuestByIp.HandleId = 0;
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x00120DED File Offset: 0x0011EFED
		public static void Init()
		{
			ConfigMotorLinkageQuestByIp.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLinkageQuestByIp.HandleId, "db_motorlinkage.db", "select BinData from `MotorLinkageQuest` where Ip=?");
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x00120E08 File Offset: 0x0011F008
		[NullableContext(2)]
		public static IReadOnlyList<MotorLinkageQuest> GetConfigList(int p0Ip, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorLinkageQuestByIp.HandleId, ConfigMotorLinkageQuestByIp.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorLinkageQuestByIp");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Ip);
				IReadOnlyList<MotorLinkageQuest> readOnlyList = (IReadOnlyList<MotorLinkageQuest>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMotorLinkageQuestByIp.LogPair.Clear();
			ConfigMotorLinkageQuestByIp.LogPair.Add(new ValueTuple<string, object>("Ip", p0Ip));
			if (!ConfigCommon.BindInt(ConfigMotorLinkageQuestByIp.HandleId, 1, p0Ip, ConfigMotorLinkageQuestByIp.LogPair))
			{
				ConfigCommon.Reset(ConfigMotorLinkageQuestByIp.HandleId, ConfigMotorLinkageQuestByIp.LogPair);
				return null;
			}
			List<MotorLinkageQuest> list = new List<MotorLinkageQuest>();
			while (ConfigCommon.Step(ConfigMotorLinkageQuestByIp.HandleId, false, ConfigMotorLinkageQuestByIp.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorLinkageQuestByIp.HandleId, 0, ConfigMotorLinkageQuestByIp.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorLinkageQuestByIp.HandleId, ConfigMotorLinkageQuestByIp.LogPair);
					return null;
				}
				MotorLinkageQuest rootAsMotorLinkageQuest = MotorLinkageQuest.GetRootAsMotorLinkageQuest(new ByteBuffer(item2));
				list.Add(rootAsMotorLinkageQuest);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorLinkageQuestByIp");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Ip);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorLinkageQuestByIp.HandleId, ConfigMotorLinkageQuestByIp.LogPair);
			return list;
		}

		// Token: 0x04002839 RID: 10297
		private const string DB = "db_motorlinkage.db";

		// Token: 0x0400283A RID: 10298
		private const string FILE = "m.摩托车IP联动活动.xlsx";

		// Token: 0x0400283B RID: 10299
		private const string TABLE = "MotorLinkageQuest";

		// Token: 0x0400283C RID: 10300
		private const string COMMAND = "select BinData from `MotorLinkageQuest` where Ip=?";

		// Token: 0x0400283D RID: 10301
		private const string KEY_PREFIX = "MotorLinkageQuestByIp";

		// Token: 0x0400283E RID: 10302
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400283F RID: 10303
		private static int HandleId;
	}
}
