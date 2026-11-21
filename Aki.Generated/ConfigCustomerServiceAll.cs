using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001C1 RID: 449
	public class ConfigCustomerServiceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A89 RID: 2697 RVA: 0x00098AEC File Offset: 0x00096CEC
		static ConfigCustomerServiceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCustomerServiceAll.CreateStaticDefaultValue), new Action(ConfigCustomerServiceAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00098B0C File Offset: 0x00096D0C
		public static void CreateStaticDefaultValue()
		{
			ConfigCustomerServiceAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCustomerServiceAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_platformchannel.db"),
				new ValueTuple<string, object>("文件", "p.平台渠道.xlsx"),
				new ValueTuple<string, object>("表名", "CustomerService"),
				new ValueTuple<string, object>("语句", "select BinData from `CustomerService` where PackageType!=?")
			});
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00098B8B File Offset: 0x00096D8B
		public static void ResetStaticDefaultValue()
		{
			ConfigCustomerServiceAll.LogPair = null;
			ConfigCustomerServiceAll.HandleId = 0;
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00098B99 File Offset: 0x00096D99
		public static void Init()
		{
			ConfigCustomerServiceAll.HandleId = ConfigCommon.InitDataStatement(ConfigCustomerServiceAll.HandleId, "db_platformchannel.db", "select BinData from `CustomerService` where PackageType!=?");
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00098BB4 File Offset: 0x00096DB4
		[NullableContext(2)]
		public static IReadOnlyList<CustomerService> GetConfigList(int p0PackageType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCustomerServiceAll.HandleId, ConfigCustomerServiceAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CustomerServiceAll");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PackageType);
				IReadOnlyList<CustomerService> readOnlyList = (IReadOnlyList<CustomerService>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigCustomerServiceAll.LogPair.Clear();
			ConfigCustomerServiceAll.LogPair.Add(new ValueTuple<string, object>("PackageType", p0PackageType));
			if (!ConfigCommon.BindInt(ConfigCustomerServiceAll.HandleId, 1, p0PackageType, ConfigCustomerServiceAll.LogPair))
			{
				ConfigCommon.Reset(ConfigCustomerServiceAll.HandleId, ConfigCustomerServiceAll.LogPair);
				return null;
			}
			List<CustomerService> list = new List<CustomerService>();
			while (ConfigCommon.Step(ConfigCustomerServiceAll.HandleId, false, ConfigCustomerServiceAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCustomerServiceAll.HandleId, 0, ConfigCustomerServiceAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCustomerServiceAll.HandleId, ConfigCustomerServiceAll.LogPair);
					return null;
				}
				CustomerService rootAsCustomerService = CustomerService.GetRootAsCustomerService(new ByteBuffer(item2));
				list.Add(rootAsCustomerService);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CustomerServiceAll");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PackageType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigCustomerServiceAll.HandleId, ConfigCustomerServiceAll.LogPair);
			return list;
		}

		// Token: 0x04000C2B RID: 3115
		private const string DB = "db_platformchannel.db";

		// Token: 0x04000C2C RID: 3116
		private const string FILE = "p.平台渠道.xlsx";

		// Token: 0x04000C2D RID: 3117
		private const string TABLE = "CustomerService";

		// Token: 0x04000C2E RID: 3118
		private const string COMMAND = "select BinData from `CustomerService` where PackageType!=?";

		// Token: 0x04000C2F RID: 3119
		private const string KEY_PREFIX = "CustomerServiceAll";

		// Token: 0x04000C30 RID: 3120
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C31 RID: 3121
		private static int HandleId;
	}
}
