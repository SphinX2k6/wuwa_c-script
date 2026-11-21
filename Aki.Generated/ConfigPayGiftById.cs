using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000655 RID: 1621
	public class ConfigPayGiftById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600260E RID: 9742 RVA: 0x001344E7 File Offset: 0x001326E7
		static ConfigPayGiftById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayGiftById.CreateStaticDefaultValue), new Action(ConfigPayGiftById.ResetStaticDefaultValue));
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x00134508 File Offset: 0x00132708
		public static void CreateStaticDefaultValue()
		{
			ConfigPayGiftById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPayGiftById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_paycurrency.db"),
				new ValueTuple<string, object>("文件", "c.充值.xlsx"),
				new ValueTuple<string, object>("表名", "PayGift"),
				new ValueTuple<string, object>("语句", "select BinData from `PayGift` where Id=?")
			});
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x00134587 File Offset: 0x00132787
		public static void ResetStaticDefaultValue()
		{
			ConfigPayGiftById.LogPair = null;
			ConfigPayGiftById.HandleId = 0;
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x00134595 File Offset: 0x00132795
		public static void Init()
		{
			ConfigPayGiftById.HandleId = ConfigCommon.InitDataStatement(ConfigPayGiftById.HandleId, "db_paycurrency.db", "select BinData from `PayGift` where Id=?");
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x001345B0 File Offset: 0x001327B0
		public static PayGift? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPayGiftById.HandleId, ConfigPayGiftById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PayGiftById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PayGift?(PayGift.GetRootAsPayGift(configBuffer));
				}
			}
			ConfigPayGiftById.LogPair.Clear();
			ConfigPayGiftById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPayGiftById.HandleId, 1, p0Id, ConfigPayGiftById.LogPair) || ConfigCommon.Step(ConfigPayGiftById.HandleId, true, ConfigPayGiftById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPayGiftById.HandleId, ConfigPayGiftById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPayGiftById.HandleId, 0, ConfigPayGiftById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPayGiftById.HandleId, ConfigPayGiftById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PayGift rootAsPayGift = PayGift.GetRootAsPayGift(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PayGiftById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPayGiftById.HandleId, ConfigPayGiftById.LogPair);
			return new PayGift?(rootAsPayGift);
		}

		// Token: 0x04002C39 RID: 11321
		private const string DB = "db_paycurrency.db";

		// Token: 0x04002C3A RID: 11322
		private const string FILE = "c.充值.xlsx";

		// Token: 0x04002C3B RID: 11323
		private const string TABLE = "PayGift";

		// Token: 0x04002C3C RID: 11324
		private const string COMMAND = "select BinData from `PayGift` where Id=?";

		// Token: 0x04002C3D RID: 11325
		private const string KEY_PREFIX = "PayGiftById";

		// Token: 0x04002C3E RID: 11326
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C3F RID: 11327
		private static int HandleId;
	}
}
