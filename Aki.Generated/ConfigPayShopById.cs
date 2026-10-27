using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000641 RID: 1601
	public class ConfigPayShopById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002596 RID: 9622 RVA: 0x0012E223 File Offset: 0x0012C423
		static ConfigPayShopById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayShopById.CreateStaticDefaultValue), new Action(ConfigPayShopById.ResetStaticDefaultValue));
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x0012E244 File Offset: 0x0012C444
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

		// Token: 0x06002598 RID: 9624 RVA: 0x0012E2C3 File Offset: 0x0012C4C3
		public static void ResetStaticDefaultValue()
		{
			ConfigPayShopById.LogPair = null;
			ConfigPayShopById.HandleId = 0;
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x0012E2D1 File Offset: 0x0012C4D1
		public static void Init()
		{
			ConfigPayShopById.HandleId = ConfigCommon.InitDataStatement(ConfigPayShopById.HandleId, "db_payshop.db", "select BinData from `PayShop` where Id=?");
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x0012E2EC File Offset: 0x0012C4EC
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

		// Token: 0x04002BAD RID: 11181
		private const string DB = "db_payshop.db";

		// Token: 0x04002BAE RID: 11182
		private const string FILE = "s.商业化商城.xlsx";

		// Token: 0x04002BAF RID: 11183
		private const string TABLE = "PayShop";

		// Token: 0x04002BB0 RID: 11184
		private const string COMMAND = "select BinData from `PayShop` where Id=?";

		// Token: 0x04002BB1 RID: 11185
		private const string KEY_PREFIX = "PayShopById";

		// Token: 0x04002BB2 RID: 11186
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BB3 RID: 11187
		private static int HandleId;
	}
}
