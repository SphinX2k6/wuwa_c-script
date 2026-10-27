using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000646 RID: 1606
	public class ConfigPayShopTabByShopId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025B4 RID: 9652 RVA: 0x0012ECD8 File Offset: 0x0012CED8
		static ConfigPayShopTabByShopId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayShopTabByShopId.CreateStaticDefaultValue), new Action(ConfigPayShopTabByShopId.ResetStaticDefaultValue));
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x0012ECF8 File Offset: 0x0012CEF8
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

		// Token: 0x060025B6 RID: 9654 RVA: 0x0012ED77 File Offset: 0x0012CF77
		public static void ResetStaticDefaultValue()
		{
			ConfigPayShopTabByShopId.LogPair = null;
			ConfigPayShopTabByShopId.HandleId = 0;
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x0012ED85 File Offset: 0x0012CF85
		public static void Init()
		{
			ConfigPayShopTabByShopId.HandleId = ConfigCommon.InitDataStatement(ConfigPayShopTabByShopId.HandleId, "db_payshop.db", "select BinData from `PayShopTab` where ShopId=?");
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x0012EDA0 File Offset: 0x0012CFA0
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

		// Token: 0x04002BD0 RID: 11216
		private const string DB = "db_payshop.db";

		// Token: 0x04002BD1 RID: 11217
		private const string FILE = "s.商业化商城.xlsx";

		// Token: 0x04002BD2 RID: 11218
		private const string TABLE = "PayShopTab";

		// Token: 0x04002BD3 RID: 11219
		private const string COMMAND = "select BinData from `PayShopTab` where ShopId=?";

		// Token: 0x04002BD4 RID: 11220
		private const string KEY_PREFIX = "PayShopTabByShopId";

		// Token: 0x04002BD5 RID: 11221
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BD6 RID: 11222
		private static int HandleId;
	}
}
