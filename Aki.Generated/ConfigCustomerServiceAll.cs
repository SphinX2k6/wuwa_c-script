using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001AF RID: 431
	public class ConfigCustomerServiceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A1D RID: 2589 RVA: 0x00092BB4 File Offset: 0x00090DB4
		static ConfigCustomerServiceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCustomerServiceAll.CreateStaticDefaultValue), new Action(ConfigCustomerServiceAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00092BD4 File Offset: 0x00090DD4
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

		// Token: 0x06000A1F RID: 2591 RVA: 0x00092C53 File Offset: 0x00090E53
		public static void ResetStaticDefaultValue()
		{
			ConfigCustomerServiceAll.LogPair = null;
			ConfigCustomerServiceAll.HandleId = 0;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00092C61 File Offset: 0x00090E61
		public static void Init()
		{
			ConfigCustomerServiceAll.HandleId = ConfigCommon.InitDataStatement(ConfigCustomerServiceAll.HandleId, "db_platformchannel.db", "select BinData from `CustomerService` where PackageType!=?");
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00092C7C File Offset: 0x00090E7C
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

		// Token: 0x04000BAD RID: 2989
		private const string DB = "db_platformchannel.db";

		// Token: 0x04000BAE RID: 2990
		private const string FILE = "p.平台渠道.xlsx";

		// Token: 0x04000BAF RID: 2991
		private const string TABLE = "CustomerService";

		// Token: 0x04000BB0 RID: 2992
		private const string COMMAND = "select BinData from `CustomerService` where PackageType!=?";

		// Token: 0x04000BB1 RID: 2993
		private const string KEY_PREFIX = "CustomerServiceAll";

		// Token: 0x04000BB2 RID: 2994
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BB3 RID: 2995
		private static int HandleId;
	}
}
