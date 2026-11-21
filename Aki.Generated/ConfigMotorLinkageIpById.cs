using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005C1 RID: 1473
	public class ConfigMotorLinkageIpById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002293 RID: 8851 RVA: 0x00120963 File Offset: 0x0011EB63
		static ConfigMotorLinkageIpById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLinkageIpById.CreateStaticDefaultValue), new Action(ConfigMotorLinkageIpById.ResetStaticDefaultValue));
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x00120984 File Offset: 0x0011EB84
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

		// Token: 0x06002295 RID: 8853 RVA: 0x00120A03 File Offset: 0x0011EC03
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLinkageIpById.LogPair = null;
			ConfigMotorLinkageIpById.HandleId = 0;
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x00120A11 File Offset: 0x0011EC11
		public static void Init()
		{
			ConfigMotorLinkageIpById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLinkageIpById.HandleId, "db_motorlinkage.db", "select BinData from `MotorLinkageIp` where Id=?");
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x00120A2C File Offset: 0x0011EC2C
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

		// Token: 0x0400282B RID: 10283
		private const string DB = "db_motorlinkage.db";

		// Token: 0x0400282C RID: 10284
		private const string FILE = "m.摩托车IP联动活动.xlsx";

		// Token: 0x0400282D RID: 10285
		private const string TABLE = "MotorLinkageIp";

		// Token: 0x0400282E RID: 10286
		private const string COMMAND = "select BinData from `MotorLinkageIp` where Id=?";

		// Token: 0x0400282F RID: 10287
		private const string KEY_PREFIX = "MotorLinkageIpById";

		// Token: 0x04002830 RID: 10288
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002831 RID: 10289
		private static int HandleId;
	}
}
