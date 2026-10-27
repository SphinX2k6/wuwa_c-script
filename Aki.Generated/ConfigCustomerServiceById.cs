using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001B0 RID: 432
	public class ConfigCustomerServiceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A23 RID: 2595 RVA: 0x00092DEB File Offset: 0x00090FEB
		static ConfigCustomerServiceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCustomerServiceById.CreateStaticDefaultValue), new Action(ConfigCustomerServiceById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00092E0C File Offset: 0x0009100C
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

		// Token: 0x06000A25 RID: 2597 RVA: 0x00092E8B File Offset: 0x0009108B
		public static void ResetStaticDefaultValue()
		{
			ConfigCustomerServiceById.LogPair = null;
			ConfigCustomerServiceById.HandleId = 0;
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00092E99 File Offset: 0x00091099
		public static void Init()
		{
			ConfigCustomerServiceById.HandleId = ConfigCommon.InitDataStatement(ConfigCustomerServiceById.HandleId, "db_platformchannel.db", "select BinData from `CustomerService` where Id=?");
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00092EB4 File Offset: 0x000910B4
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

		// Token: 0x04000BB4 RID: 2996
		private const string DB = "db_platformchannel.db";

		// Token: 0x04000BB5 RID: 2997
		private const string FILE = "p.平台渠道.xlsx";

		// Token: 0x04000BB6 RID: 2998
		private const string TABLE = "CustomerService";

		// Token: 0x04000BB7 RID: 2999
		private const string COMMAND = "select BinData from `CustomerService` where Id=?";

		// Token: 0x04000BB8 RID: 3000
		private const string KEY_PREFIX = "CustomerServiceById";

		// Token: 0x04000BB9 RID: 3001
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BBA RID: 3002
		private static int HandleId;
	}
}
