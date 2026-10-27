using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000924 RID: 2340
	public class ConfigShopFixedByShopId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036EB RID: 14059 RVA: 0x0018FD94 File Offset: 0x0018DF94
		static ConfigShopFixedByShopId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigShopFixedByShopId.CreateStaticDefaultValue), new Action(ConfigShopFixedByShopId.ResetStaticDefaultValue));
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x0018FDB4 File Offset: 0x0018DFB4
		public static void CreateStaticDefaultValue()
		{
			ConfigShopFixedByShopId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigShopFixedByShopId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shop.db"),
				new ValueTuple<string, object>("文件", "s.商城.xlsx"),
				new ValueTuple<string, object>("表名", "ShopFixed"),
				new ValueTuple<string, object>("语句", "select BinData from `ShopFixed` where ShopId = ?")
			});
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x0018FE33 File Offset: 0x0018E033
		public static void ResetStaticDefaultValue()
		{
			ConfigShopFixedByShopId.LogPair = null;
			ConfigShopFixedByShopId.HandleId = 0;
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x0018FE41 File Offset: 0x0018E041
		public static void Init()
		{
			ConfigShopFixedByShopId.HandleId = ConfigCommon.InitDataStatement(ConfigShopFixedByShopId.HandleId, "db_shop.db", "select BinData from `ShopFixed` where ShopId = ?");
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x0018FE5C File Offset: 0x0018E05C
		[NullableContext(2)]
		public static IReadOnlyList<ShopFixed> GetConfigList(int p0ShopId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigShopFixedByShopId.HandleId, ConfigShopFixedByShopId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ShopFixedByShopId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ShopId);
				IReadOnlyList<ShopFixed> readOnlyList = (IReadOnlyList<ShopFixed>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigShopFixedByShopId.LogPair.Clear();
			ConfigShopFixedByShopId.LogPair.Add(new ValueTuple<string, object>("ShopId", p0ShopId));
			if (!ConfigCommon.BindInt(ConfigShopFixedByShopId.HandleId, 1, p0ShopId, ConfigShopFixedByShopId.LogPair))
			{
				ConfigCommon.Reset(ConfigShopFixedByShopId.HandleId, ConfigShopFixedByShopId.LogPair);
				return null;
			}
			List<ShopFixed> list = new List<ShopFixed>();
			while (ConfigCommon.Step(ConfigShopFixedByShopId.HandleId, false, ConfigShopFixedByShopId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigShopFixedByShopId.HandleId, 0, ConfigShopFixedByShopId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigShopFixedByShopId.HandleId, ConfigShopFixedByShopId.LogPair);
					return null;
				}
				ShopFixed rootAsShopFixed = ShopFixed.GetRootAsShopFixed(new ByteBuffer(item2));
				list.Add(rootAsShopFixed);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ShopFixedByShopId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ShopId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigShopFixedByShopId.HandleId, ConfigShopFixedByShopId.LogPair);
			return list;
		}

		// Token: 0x04003FE2 RID: 16354
		private const string DB = "db_shop.db";

		// Token: 0x04003FE3 RID: 16355
		private const string FILE = "s.商城.xlsx";

		// Token: 0x04003FE4 RID: 16356
		private const string TABLE = "ShopFixed";

		// Token: 0x04003FE5 RID: 16357
		private const string COMMAND = "select BinData from `ShopFixed` where ShopId = ?";

		// Token: 0x04003FE6 RID: 16358
		private const string KEY_PREFIX = "ShopFixedByShopId";

		// Token: 0x04003FE7 RID: 16359
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FE8 RID: 16360
		private static int HandleId;
	}
}
