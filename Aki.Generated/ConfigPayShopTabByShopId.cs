using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200065E RID: 1630
	public class ConfigPayShopTabByShopId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002644 RID: 9796 RVA: 0x00135754 File Offset: 0x00133954
		static ConfigPayShopTabByShopId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayShopTabByShopId.CreateStaticDefaultValue), new Action(ConfigPayShopTabByShopId.ResetStaticDefaultValue));
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x00135774 File Offset: 0x00133974
		public static void CreateStaticDefaultValue()
		{
			ConfigPayShopTabByShopId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPayShopTabByShopId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_payshop.db"),
				new ValueTuple<string, object>("文件", "s.商业化商城.xlsx"),
				new ValueTuple<string, object>("表名", "PayShopTab"),
				new ValueTuple<string, object>("语句", "select BinData from `PayShopTab` where ShopId=?")
			});
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x001357F3 File Offset: 0x001339F3
		public static void ResetStaticDefaultValue()
		{
			ConfigPayShopTabByShopId.LogPair = null;
			ConfigPayShopTabByShopId.HandleId = 0;
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x00135801 File Offset: 0x00133A01
		public static void Init()
		{
			ConfigPayShopTabByShopId.HandleId = ConfigCommon.InitDataStatement(ConfigPayShopTabByShopId.HandleId, "db_payshop.db", "select BinData from `PayShopTab` where ShopId=?");
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x0013581C File Offset: 0x00133A1C
		[NullableContext(2)]
		public static IReadOnlyList<PayShopTab> GetConfigList(int p0ShopId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPayShopTabByShopId.HandleId, ConfigPayShopTabByShopId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PayShopTabByShopId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ShopId);
				IReadOnlyList<PayShopTab> readOnlyList = (IReadOnlyList<PayShopTab>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPayShopTabByShopId.LogPair.Clear();
			ConfigPayShopTabByShopId.LogPair.Add(new ValueTuple<string, object>("ShopId", p0ShopId));
			if (!ConfigCommon.BindInt(ConfigPayShopTabByShopId.HandleId, 1, p0ShopId, ConfigPayShopTabByShopId.LogPair))
			{
				ConfigCommon.Reset(ConfigPayShopTabByShopId.HandleId, ConfigPayShopTabByShopId.LogPair);
				return null;
			}
			List<PayShopTab> list = new List<PayShopTab>();
			while (ConfigCommon.Step(ConfigPayShopTabByShopId.HandleId, false, ConfigPayShopTabByShopId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPayShopTabByShopId.HandleId, 0, ConfigPayShopTabByShopId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPayShopTabByShopId.HandleId, ConfigPayShopTabByShopId.LogPair);
					return null;
				}
				PayShopTab rootAsPayShopTab = PayShopTab.GetRootAsPayShopTab(new ByteBuffer(item2));
				list.Add(rootAsPayShopTab);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PayShopTabByShopId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ShopId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPayShopTabByShopId.HandleId, ConfigPayShopTabByShopId.LogPair);
			return list;
		}

		// Token: 0x04002C78 RID: 11384
		private const string DB = "db_payshop.db";

		// Token: 0x04002C79 RID: 11385
		private const string FILE = "s.商业化商城.xlsx";

		// Token: 0x04002C7A RID: 11386
		private const string TABLE = "PayShopTab";

		// Token: 0x04002C7B RID: 11387
		private const string COMMAND = "select BinData from `PayShopTab` where ShopId=?";

		// Token: 0x04002C7C RID: 11388
		private const string KEY_PREFIX = "PayShopTabByShopId";

		// Token: 0x04002C7D RID: 11389
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C7E RID: 11390
		private static int HandleId;
	}
}
