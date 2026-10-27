using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000647 RID: 1607
	public class ConfigPayShopTabByShopIdAndTabId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025BA RID: 9658 RVA: 0x0012EF0F File Offset: 0x0012D10F
		static ConfigPayShopTabByShopIdAndTabId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayShopTabByShopIdAndTabId.CreateStaticDefaultValue), new Action(ConfigPayShopTabByShopIdAndTabId.ResetStaticDefaultValue));
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x0012EF30 File Offset: 0x0012D130
		public static void CreateStaticDefaultValue()
		{
			ConfigPayShopTabByShopIdAndTabId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPayShopTabByShopIdAndTabId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_payshop.db"),
				new ValueTuple<string, object>("文件", "s.商业化商城.xlsx"),
				new ValueTuple<string, object>("表名", "PayShopTab"),
				new ValueTuple<string, object>("语句", "select BinData from `PayShopTab` where ShopId=? And TabId=?")
			});
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x0012EFAF File Offset: 0x0012D1AF
		public static void ResetStaticDefaultValue()
		{
			ConfigPayShopTabByShopIdAndTabId.LogPair = null;
			ConfigPayShopTabByShopIdAndTabId.HandleId = 0;
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x0012EFBD File Offset: 0x0012D1BD
		public static void Init()
		{
			ConfigPayShopTabByShopIdAndTabId.HandleId = ConfigCommon.InitDataStatement(ConfigPayShopTabByShopIdAndTabId.HandleId, "db_payshop.db", "select BinData from `PayShopTab` where ShopId=? And TabId=?");
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x0012EFD8 File Offset: 0x0012D1D8
		public static PayShopTab? GetConfig(int p0ShopId, int p1TabId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPayShopTabByShopIdAndTabId.HandleId, ConfigPayShopTabByShopIdAndTabId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PayShopTabByShopIdAndTabId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ShopId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1TabId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PayShopTab?(PayShopTab.GetRootAsPayShopTab(configBuffer));
				}
			}
			ConfigPayShopTabByShopIdAndTabId.LogPair.Clear();
			ConfigPayShopTabByShopIdAndTabId.LogPair.Add(new ValueTuple<string, object>("ShopId", p0ShopId));
			ConfigPayShopTabByShopIdAndTabId.LogPair.Add(new ValueTuple<string, object>("TabId", p1TabId));
			if (!ConfigCommon.BindInt(ConfigPayShopTabByShopIdAndTabId.HandleId, 1, p0ShopId, ConfigPayShopTabByShopIdAndTabId.LogPair) || !ConfigCommon.BindInt(ConfigPayShopTabByShopIdAndTabId.HandleId, 2, p1TabId, ConfigPayShopTabByShopIdAndTabId.LogPair) || ConfigCommon.Step(ConfigPayShopTabByShopIdAndTabId.HandleId, true, ConfigPayShopTabByShopIdAndTabId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPayShopTabByShopIdAndTabId.HandleId, ConfigPayShopTabByShopIdAndTabId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPayShopTabByShopIdAndTabId.HandleId, 0, ConfigPayShopTabByShopIdAndTabId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPayShopTabByShopIdAndTabId.HandleId, ConfigPayShopTabByShopIdAndTabId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PayShopTab rootAsPayShopTab = PayShopTab.GetRootAsPayShopTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PayShopTabByShopIdAndTabId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ShopId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1TabId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPayShopTabByShopIdAndTabId.HandleId, ConfigPayShopTabByShopIdAndTabId.LogPair);
			return new PayShopTab?(rootAsPayShopTab);
		}

		// Token: 0x04002BD7 RID: 11223
		private const string DB = "db_payshop.db";

		// Token: 0x04002BD8 RID: 11224
		private const string FILE = "s.商业化商城.xlsx";

		// Token: 0x04002BD9 RID: 11225
		private const string TABLE = "PayShopTab";

		// Token: 0x04002BDA RID: 11226
		private const string COMMAND = "select BinData from `PayShopTab` where ShopId=? And TabId=?";

		// Token: 0x04002BDB RID: 11227
		private const string KEY_PREFIX = "PayShopTabByShopIdAndTabId";

		// Token: 0x04002BDC RID: 11228
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BDD RID: 11229
		private static int HandleId;
	}
}
