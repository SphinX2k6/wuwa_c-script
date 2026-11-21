using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200065F RID: 1631
	public class ConfigPayShopTabByShopIdAndTabId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600264A RID: 9802 RVA: 0x0013598B File Offset: 0x00133B8B
		static ConfigPayShopTabByShopIdAndTabId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayShopTabByShopIdAndTabId.CreateStaticDefaultValue), new Action(ConfigPayShopTabByShopIdAndTabId.ResetStaticDefaultValue));
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x001359AC File Offset: 0x00133BAC
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

		// Token: 0x0600264C RID: 9804 RVA: 0x00135A2B File Offset: 0x00133C2B
		public static void ResetStaticDefaultValue()
		{
			ConfigPayShopTabByShopIdAndTabId.LogPair = null;
			ConfigPayShopTabByShopIdAndTabId.HandleId = 0;
		}

		// Token: 0x0600264D RID: 9805 RVA: 0x00135A39 File Offset: 0x00133C39
		public static void Init()
		{
			ConfigPayShopTabByShopIdAndTabId.HandleId = ConfigCommon.InitDataStatement(ConfigPayShopTabByShopIdAndTabId.HandleId, "db_payshop.db", "select BinData from `PayShopTab` where ShopId=? And TabId=?");
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x00135A54 File Offset: 0x00133C54
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

		// Token: 0x04002C7F RID: 11391
		private const string DB = "db_payshop.db";

		// Token: 0x04002C80 RID: 11392
		private const string FILE = "s.商业化商城.xlsx";

		// Token: 0x04002C81 RID: 11393
		private const string TABLE = "PayShopTab";

		// Token: 0x04002C82 RID: 11394
		private const string COMMAND = "select BinData from `PayShopTab` where ShopId=? And TabId=?";

		// Token: 0x04002C83 RID: 11395
		private const string KEY_PREFIX = "PayShopTabByShopIdAndTabId";

		// Token: 0x04002C84 RID: 11396
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C85 RID: 11397
		private static int HandleId;
	}
}
