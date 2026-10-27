using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000642 RID: 1602
	public class ConfigPayShopConditionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600259C RID: 9628 RVA: 0x0012E46C File Offset: 0x0012C66C
		static ConfigPayShopConditionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayShopConditionById.CreateStaticDefaultValue), new Action(ConfigPayShopConditionById.ResetStaticDefaultValue));
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x0012E48C File Offset: 0x0012C68C
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

		// Token: 0x0600259E RID: 9630 RVA: 0x0012E50B File Offset: 0x0012C70B
		public static void ResetStaticDefaultValue()
		{
			ConfigPayShopConditionById.LogPair = null;
			ConfigPayShopConditionById.HandleId = 0;
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x0012E519 File Offset: 0x0012C719
		public static void Init()
		{
			ConfigPayShopConditionById.HandleId = ConfigCommon.InitDataStatement(ConfigPayShopConditionById.HandleId, "db_payshop.db", "select BinData from `PayShopCondition` where Id=?");
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x0012E534 File Offset: 0x0012C734
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

		// Token: 0x04002BB4 RID: 11188
		private const string DB = "db_payshop.db";

		// Token: 0x04002BB5 RID: 11189
		private const string FILE = "s.商业化商城.xlsx";

		// Token: 0x04002BB6 RID: 11190
		private const string TABLE = "PayShopCondition";

		// Token: 0x04002BB7 RID: 11191
		private const string COMMAND = "select BinData from `PayShopCondition` where Id=?";

		// Token: 0x04002BB8 RID: 11192
		private const string KEY_PREFIX = "PayShopConditionById";

		// Token: 0x04002BB9 RID: 11193
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BBA RID: 11194
		private static int HandleId;
	}
}
