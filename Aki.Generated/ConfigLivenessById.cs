using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004F8 RID: 1272
	public class ConfigLivenessById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DDB RID: 7643 RVA: 0x0010585F File Offset: 0x00103A5F
		static ConfigLivenessById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLivenessById.CreateStaticDefaultValue), new Action(ConfigLivenessById.ResetStaticDefaultValue));
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x00105880 File Offset: 0x00103A80
		public static void CreateStaticDefaultValue()
		{
			ConfigLivenessById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLivenessById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_daily_activity.db"),
				new ValueTuple<string, object>("文件", "h.活跃度.xlsx"),
				new ValueTuple<string, object>("表名", "Liveness"),
				new ValueTuple<string, object>("语句", "select BinData from `Liveness` where Id=?")
			});
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x001058FF File Offset: 0x00103AFF
		public static void ResetStaticDefaultValue()
		{
			ConfigLivenessById.LogPair = null;
			ConfigLivenessById.HandleId = 0;
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x0010590D File Offset: 0x00103B0D
		public static void Init()
		{
			ConfigLivenessById.HandleId = ConfigCommon.InitDataStatement(ConfigLivenessById.HandleId, "db_daily_activity.db", "select BinData from `Liveness` where Id=?");
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x00105928 File Offset: 0x00103B28
		public static Liveness? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLivenessById.HandleId, ConfigLivenessById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LivenessById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Liveness?(Liveness.GetRootAsLiveness(configBuffer));
				}
			}
			ConfigLivenessById.LogPair.Clear();
			ConfigLivenessById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLivenessById.HandleId, 1, p0Id, ConfigLivenessById.LogPair) || ConfigCommon.Step(ConfigLivenessById.HandleId, true, ConfigLivenessById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLivenessById.HandleId, ConfigLivenessById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLivenessById.HandleId, 0, ConfigLivenessById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLivenessById.HandleId, ConfigLivenessById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Liveness rootAsLiveness = Liveness.GetRootAsLiveness(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LivenessById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLivenessById.HandleId, ConfigLivenessById.LogPair);
			return new Liveness?(rootAsLiveness);
		}

		// Token: 0x040022AC RID: 8876
		private const string DB = "db_daily_activity.db";

		// Token: 0x040022AD RID: 8877
		private const string FILE = "h.活跃度.xlsx";

		// Token: 0x040022AE RID: 8878
		private const string TABLE = "Liveness";

		// Token: 0x040022AF RID: 8879
		private const string COMMAND = "select BinData from `Liveness` where Id=?";

		// Token: 0x040022B0 RID: 8880
		private const string KEY_PREFIX = "LivenessById";

		// Token: 0x040022B1 RID: 8881
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022B2 RID: 8882
		private static int HandleId;
	}
}
