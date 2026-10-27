using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200063D RID: 1597
	public class ConfigPayGiftById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600257E RID: 9598 RVA: 0x0012DA6B File Offset: 0x0012BC6B
		static ConfigPayGiftById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayGiftById.CreateStaticDefaultValue), new Action(ConfigPayGiftById.ResetStaticDefaultValue));
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x0012DA8C File Offset: 0x0012BC8C
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

		// Token: 0x06002580 RID: 9600 RVA: 0x0012DB0B File Offset: 0x0012BD0B
		public static void ResetStaticDefaultValue()
		{
			ConfigPayGiftById.LogPair = null;
			ConfigPayGiftById.HandleId = 0;
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x0012DB19 File Offset: 0x0012BD19
		public static void Init()
		{
			ConfigPayGiftById.HandleId = ConfigCommon.InitDataStatement(ConfigPayGiftById.HandleId, "db_paycurrency.db", "select BinData from `PayGift` where Id=?");
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x0012DB34 File Offset: 0x0012BD34
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

		// Token: 0x04002B91 RID: 11153
		private const string DB = "db_paycurrency.db";

		// Token: 0x04002B92 RID: 11154
		private const string FILE = "c.充值.xlsx";

		// Token: 0x04002B93 RID: 11155
		private const string TABLE = "PayGift";

		// Token: 0x04002B94 RID: 11156
		private const string COMMAND = "select BinData from `PayGift` where Id=?";

		// Token: 0x04002B95 RID: 11157
		private const string KEY_PREFIX = "PayGiftById";

		// Token: 0x04002B96 RID: 11158
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B97 RID: 11159
		private static int HandleId;
	}
}
