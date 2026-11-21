using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000659 RID: 1625
	public class ConfigPayShopById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002626 RID: 9766 RVA: 0x00134C9F File Offset: 0x00132E9F
		static ConfigPayShopById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayShopById.CreateStaticDefaultValue), new Action(ConfigPayShopById.ResetStaticDefaultValue));
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x00134CC0 File Offset: 0x00132EC0
		public static void CreateStaticDefaultValue()
		{
			ConfigPayShopById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPayShopById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_payshop.db"),
				new ValueTuple<string, object>("文件", "s.商业化商城.xlsx"),
				new ValueTuple<string, object>("表名", "PayShop"),
				new ValueTuple<string, object>("语句", "select BinData from `PayShop` where Id=?")
			});
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x00134D3F File Offset: 0x00132F3F
		public static void ResetStaticDefaultValue()
		{
			ConfigPayShopById.LogPair = null;
			ConfigPayShopById.HandleId = 0;
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x00134D4D File Offset: 0x00132F4D
		public static void Init()
		{
			ConfigPayShopById.HandleId = ConfigCommon.InitDataStatement(ConfigPayShopById.HandleId, "db_payshop.db", "select BinData from `PayShop` where Id=?");
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x00134D68 File Offset: 0x00132F68
		public static PayShop? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPayShopById.HandleId, ConfigPayShopById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PayShopById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PayShop?(PayShop.GetRootAsPayShop(configBuffer));
				}
			}
			ConfigPayShopById.LogPair.Clear();
			ConfigPayShopById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPayShopById.HandleId, 1, p0Id, ConfigPayShopById.LogPair) || ConfigCommon.Step(ConfigPayShopById.HandleId, true, ConfigPayShopById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPayShopById.HandleId, ConfigPayShopById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPayShopById.HandleId, 0, ConfigPayShopById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPayShopById.HandleId, ConfigPayShopById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PayShop rootAsPayShop = PayShop.GetRootAsPayShop(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PayShopById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPayShopById.HandleId, ConfigPayShopById.LogPair);
			return new PayShop?(rootAsPayShop);
		}

		// Token: 0x04002C55 RID: 11349
		private const string DB = "db_payshop.db";

		// Token: 0x04002C56 RID: 11350
		private const string FILE = "s.商业化商城.xlsx";

		// Token: 0x04002C57 RID: 11351
		private const string TABLE = "PayShop";

		// Token: 0x04002C58 RID: 11352
		private const string COMMAND = "select BinData from `PayShop` where Id=?";

		// Token: 0x04002C59 RID: 11353
		private const string KEY_PREFIX = "PayShopById";

		// Token: 0x04002C5A RID: 11354
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C5B RID: 11355
		private static int HandleId;
	}
}
