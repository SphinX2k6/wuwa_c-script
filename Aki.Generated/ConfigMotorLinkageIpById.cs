using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005AA RID: 1450
	public class ConfigMotorLinkageIpById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002209 RID: 8713 RVA: 0x0011A07B File Offset: 0x0011827B
		static ConfigMotorLinkageIpById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLinkageIpById.CreateStaticDefaultValue), new Action(ConfigMotorLinkageIpById.ResetStaticDefaultValue));
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x0011A09C File Offset: 0x0011829C
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorLinkageIpById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorLinkageIpById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorlinkage.db"),
				new ValueTuple<string, object>("文件", "m.摩托车IP联动活动.xlsx"),
				new ValueTuple<string, object>("表名", "MotorLinkageIp"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorLinkageIp` where Id=?")
			});
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x0011A11B File Offset: 0x0011831B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLinkageIpById.LogPair = null;
			ConfigMotorLinkageIpById.HandleId = 0;
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x0011A129 File Offset: 0x00118329
		public static void Init()
		{
			ConfigMotorLinkageIpById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLinkageIpById.HandleId, "db_motorlinkage.db", "select BinData from `MotorLinkageIp` where Id=?");
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x0011A144 File Offset: 0x00118344
		public static MotorLinkageIp? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorLinkageIpById.HandleId, ConfigMotorLinkageIpById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorLinkageIpById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorLinkageIp?(MotorLinkageIp.GetRootAsMotorLinkageIp(configBuffer));
				}
			}
			ConfigMotorLinkageIpById.LogPair.Clear();
			ConfigMotorLinkageIpById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorLinkageIpById.HandleId, 1, p0Id, ConfigMotorLinkageIpById.LogPair) || ConfigCommon.Step(ConfigMotorLinkageIpById.HandleId, true, ConfigMotorLinkageIpById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorLinkageIpById.HandleId, ConfigMotorLinkageIpById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorLinkageIpById.HandleId, 0, ConfigMotorLinkageIpById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorLinkageIpById.HandleId, ConfigMotorLinkageIpById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorLinkageIp rootAsMotorLinkageIp = MotorLinkageIp.GetRootAsMotorLinkageIp(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorLinkageIpById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorLinkageIpById.HandleId, ConfigMotorLinkageIpById.LogPair);
			return new MotorLinkageIp?(rootAsMotorLinkageIp);
		}

		// Token: 0x0400278A RID: 10122
		private const string DB = "db_motorlinkage.db";

		// Token: 0x0400278B RID: 10123
		private const string FILE = "m.摩托车IP联动活动.xlsx";

		// Token: 0x0400278C RID: 10124
		private const string TABLE = "MotorLinkageIp";

		// Token: 0x0400278D RID: 10125
		private const string COMMAND = "select BinData from `MotorLinkageIp` where Id=?";

		// Token: 0x0400278E RID: 10126
		private const string KEY_PREFIX = "MotorLinkageIpById";

		// Token: 0x0400278F RID: 10127
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002790 RID: 10128
		private static int HandleId;
	}
}
