using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001C2 RID: 450
	public class ConfigCustomerServiceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A8F RID: 2703 RVA: 0x00098D23 File Offset: 0x00096F23
		static ConfigCustomerServiceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCustomerServiceById.CreateStaticDefaultValue), new Action(ConfigCustomerServiceById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00098D44 File Offset: 0x00096F44
		public static void CreateStaticDefaultValue()
		{
			ConfigCustomerServiceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCustomerServiceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_platformchannel.db"),
				new ValueTuple<string, object>("文件", "p.平台渠道.xlsx"),
				new ValueTuple<string, object>("表名", "CustomerService"),
				new ValueTuple<string, object>("语句", "select BinData from `CustomerService` where Id=?")
			});
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00098DC3 File Offset: 0x00096FC3
		public static void ResetStaticDefaultValue()
		{
			ConfigCustomerServiceById.LogPair = null;
			ConfigCustomerServiceById.HandleId = 0;
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00098DD1 File Offset: 0x00096FD1
		public static void Init()
		{
			ConfigCustomerServiceById.HandleId = ConfigCommon.InitDataStatement(ConfigCustomerServiceById.HandleId, "db_platformchannel.db", "select BinData from `CustomerService` where Id=?");
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00098DEC File Offset: 0x00096FEC
		public static CustomerService? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCustomerServiceById.HandleId, ConfigCustomerServiceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CustomerServiceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CustomerService?(CustomerService.GetRootAsCustomerService(configBuffer));
				}
			}
			ConfigCustomerServiceById.LogPair.Clear();
			ConfigCustomerServiceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCustomerServiceById.HandleId, 1, p0Id, ConfigCustomerServiceById.LogPair) || ConfigCommon.Step(ConfigCustomerServiceById.HandleId, true, ConfigCustomerServiceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCustomerServiceById.HandleId, ConfigCustomerServiceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCustomerServiceById.HandleId, 0, ConfigCustomerServiceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCustomerServiceById.HandleId, ConfigCustomerServiceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CustomerService rootAsCustomerService = CustomerService.GetRootAsCustomerService(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CustomerServiceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCustomerServiceById.HandleId, ConfigCustomerServiceById.LogPair);
			return new CustomerService?(rootAsCustomerService);
		}

		// Token: 0x04000C32 RID: 3122
		private const string DB = "db_platformchannel.db";

		// Token: 0x04000C33 RID: 3123
		private const string FILE = "p.平台渠道.xlsx";

		// Token: 0x04000C34 RID: 3124
		private const string TABLE = "CustomerService";

		// Token: 0x04000C35 RID: 3125
		private const string COMMAND = "select BinData from `CustomerService` where Id=?";

		// Token: 0x04000C36 RID: 3126
		private const string KEY_PREFIX = "CustomerServiceById";

		// Token: 0x04000C37 RID: 3127
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C38 RID: 3128
		private static int HandleId;
	}
}
