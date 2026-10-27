using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001AE RID: 430
	public class ConfigCouponById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A17 RID: 2583 RVA: 0x0009296C File Offset: 0x00090B6C
		static ConfigCouponById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCouponById.CreateStaticDefaultValue), new Action(ConfigCouponById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0009298C File Offset: 0x00090B8C
		public static void CreateStaticDefaultValue()
		{
			ConfigCouponById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCouponById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_item.db"),
				new ValueTuple<string, object>("文件", "d.道具.xlsx"),
				new ValueTuple<string, object>("表名", "Coupon"),
				new ValueTuple<string, object>("语句", "select BinData from `Coupon` where Id=?")
			});
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00092A0B File Offset: 0x00090C0B
		public static void ResetStaticDefaultValue()
		{
			ConfigCouponById.LogPair = null;
			ConfigCouponById.HandleId = 0;
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00092A19 File Offset: 0x00090C19
		public static void Init()
		{
			ConfigCouponById.HandleId = ConfigCommon.InitDataStatement(ConfigCouponById.HandleId, "db_item.db", "select BinData from `Coupon` where Id=?");
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00092A34 File Offset: 0x00090C34
		public static Coupon? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCouponById.HandleId, ConfigCouponById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CouponById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Coupon?(Coupon.GetRootAsCoupon(configBuffer));
				}
			}
			ConfigCouponById.LogPair.Clear();
			ConfigCouponById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCouponById.HandleId, 1, p0Id, ConfigCouponById.LogPair) || ConfigCommon.Step(ConfigCouponById.HandleId, true, ConfigCouponById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCouponById.HandleId, ConfigCouponById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCouponById.HandleId, 0, ConfigCouponById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCouponById.HandleId, ConfigCouponById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Coupon rootAsCoupon = Coupon.GetRootAsCoupon(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CouponById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCouponById.HandleId, ConfigCouponById.LogPair);
			return new Coupon?(rootAsCoupon);
		}

		// Token: 0x04000BA6 RID: 2982
		private const string DB = "db_item.db";

		// Token: 0x04000BA7 RID: 2983
		private const string FILE = "d.道具.xlsx";

		// Token: 0x04000BA8 RID: 2984
		private const string TABLE = "Coupon";

		// Token: 0x04000BA9 RID: 2985
		private const string COMMAND = "select BinData from `Coupon` where Id=?";

		// Token: 0x04000BAA RID: 2986
		private const string KEY_PREFIX = "CouponById";

		// Token: 0x04000BAB RID: 2987
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BAC RID: 2988
		private static int HandleId;
	}
}
