using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001C0 RID: 448
	public class ConfigCouponById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A83 RID: 2691 RVA: 0x000988A4 File Offset: 0x00096AA4
		static ConfigCouponById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCouponById.CreateStaticDefaultValue), new Action(ConfigCouponById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x000988C4 File Offset: 0x00096AC4
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

		// Token: 0x06000A85 RID: 2693 RVA: 0x00098943 File Offset: 0x00096B43
		public static void ResetStaticDefaultValue()
		{
			ConfigCouponById.LogPair = null;
			ConfigCouponById.HandleId = 0;
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00098951 File Offset: 0x00096B51
		public static void Init()
		{
			ConfigCouponById.HandleId = ConfigCommon.InitDataStatement(ConfigCouponById.HandleId, "db_item.db", "select BinData from `Coupon` where Id=?");
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0009896C File Offset: 0x00096B6C
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

		// Token: 0x04000C24 RID: 3108
		private const string DB = "db_item.db";

		// Token: 0x04000C25 RID: 3109
		private const string FILE = "d.道具.xlsx";

		// Token: 0x04000C26 RID: 3110
		private const string TABLE = "Coupon";

		// Token: 0x04000C27 RID: 3111
		private const string COMMAND = "select BinData from `Coupon` where Id=?";

		// Token: 0x04000C28 RID: 3112
		private const string KEY_PREFIX = "CouponById";

		// Token: 0x04000C29 RID: 3113
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C2A RID: 3114
		private static int HandleId;
	}
}
