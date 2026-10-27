using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005AC RID: 1452
	public class ConfigMotorLinkageQuestByIp : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002215 RID: 8725 RVA: 0x0011A457 File Offset: 0x00118657
		static ConfigMotorLinkageQuestByIp()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLinkageQuestByIp.CreateStaticDefaultValue), new Action(ConfigMotorLinkageQuestByIp.ResetStaticDefaultValue));
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x0011A478 File Offset: 0x00118678
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

		// Token: 0x06002217 RID: 8727 RVA: 0x0011A4F7 File Offset: 0x001186F7
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLinkageQuestByIp.LogPair = null;
			ConfigMotorLinkageQuestByIp.HandleId = 0;
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x0011A505 File Offset: 0x00118705
		public static void Init()
		{
			ConfigMotorLinkageQuestByIp.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLinkageQuestByIp.HandleId, "db_motorlinkage.db", "select BinData from `MotorLinkageQuest` where Ip=?");
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x0011A520 File Offset: 0x00118720
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

		// Token: 0x04002798 RID: 10136
		private const string DB = "db_motorlinkage.db";

		// Token: 0x04002799 RID: 10137
		private const string FILE = "m.摩托车IP联动活动.xlsx";

		// Token: 0x0400279A RID: 10138
		private const string TABLE = "MotorLinkageQuest";

		// Token: 0x0400279B RID: 10139
		private const string COMMAND = "select BinData from `MotorLinkageQuest` where Ip=?";

		// Token: 0x0400279C RID: 10140
		private const string KEY_PREFIX = "MotorLinkageQuestByIp";

		// Token: 0x0400279D RID: 10141
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400279E RID: 10142
		private static int HandleId;
	}
}
