using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200065A RID: 1626
	public class ConfigPayShopConditionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600262C RID: 9772 RVA: 0x00134EE8 File Offset: 0x001330E8
		static ConfigPayShopConditionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayShopConditionById.CreateStaticDefaultValue), new Action(ConfigPayShopConditionById.ResetStaticDefaultValue));
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x00134F08 File Offset: 0x00133108
		public static void CreateStaticDefaultValue()
		{
			ConfigPayShopConditionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPayShopConditionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_payshop.db"),
				new ValueTuple<string, object>("文件", "s.商业化商城.xlsx"),
				new ValueTuple<string, object>("表名", "PayShopCondition"),
				new ValueTuple<string, object>("语句", "select BinData from `PayShopCondition` where Id=?")
			});
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x00134F87 File Offset: 0x00133187
		public static void ResetStaticDefaultValue()
		{
			ConfigPayShopConditionById.LogPair = null;
			ConfigPayShopConditionById.HandleId = 0;
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x00134F95 File Offset: 0x00133195
		public static void Init()
		{
			ConfigPayShopConditionById.HandleId = ConfigCommon.InitDataStatement(ConfigPayShopConditionById.HandleId, "db_payshop.db", "select BinData from `PayShopCondition` where Id=?");
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x00134FB0 File Offset: 0x001331B0
		public static PayShopCondition? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPayShopConditionById.HandleId, ConfigPayShopConditionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PayShopConditionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PayShopCondition?(PayShopCondition.GetRootAsPayShopCondition(configBuffer));
				}
			}
			ConfigPayShopConditionById.LogPair.Clear();
			ConfigPayShopConditionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPayShopConditionById.HandleId, 1, p0Id, ConfigPayShopConditionById.LogPair) || ConfigCommon.Step(ConfigPayShopConditionById.HandleId, true, ConfigPayShopConditionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPayShopConditionById.HandleId, ConfigPayShopConditionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPayShopConditionById.HandleId, 0, ConfigPayShopConditionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPayShopConditionById.HandleId, ConfigPayShopConditionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PayShopCondition rootAsPayShopCondition = PayShopCondition.GetRootAsPayShopCondition(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PayShopConditionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPayShopConditionById.HandleId, ConfigPayShopConditionById.LogPair);
			return new PayShopCondition?(rootAsPayShopCondition);
		}

		// Token: 0x04002C5C RID: 11356
		private const string DB = "db_payshop.db";

		// Token: 0x04002C5D RID: 11357
		private const string FILE = "s.商业化商城.xlsx";

		// Token: 0x04002C5E RID: 11358
		private const string TABLE = "PayShopCondition";

		// Token: 0x04002C5F RID: 11359
		private const string COMMAND = "select BinData from `PayShopCondition` where Id=?";

		// Token: 0x04002C60 RID: 11360
		private const string KEY_PREFIX = "PayShopConditionById";

		// Token: 0x04002C61 RID: 11361
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C62 RID: 11362
		private static int HandleId;
	}
}
