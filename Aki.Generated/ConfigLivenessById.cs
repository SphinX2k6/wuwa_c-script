using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004E2 RID: 1250
	public class ConfigLivenessById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D57 RID: 7511 RVA: 0x000FF10B File Offset: 0x000FD30B
		static ConfigLivenessById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLivenessById.CreateStaticDefaultValue), new Action(ConfigLivenessById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x000FF12C File Offset: 0x000FD32C
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

		// Token: 0x06001D59 RID: 7513 RVA: 0x000FF1AB File Offset: 0x000FD3AB
		public static void ResetStaticDefaultValue()
		{
			ConfigLivenessById.LogPair = null;
			ConfigLivenessById.HandleId = 0;
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x000FF1B9 File Offset: 0x000FD3B9
		public static void Init()
		{
			ConfigLivenessById.HandleId = ConfigCommon.InitDataStatement(ConfigLivenessById.HandleId, "db_daily_activity.db", "select BinData from `Liveness` where Id=?");
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x000FF1D4 File Offset: 0x000FD3D4
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

		// Token: 0x04002212 RID: 8722
		private const string DB = "db_daily_activity.db";

		// Token: 0x04002213 RID: 8723
		private const string FILE = "h.活跃度.xlsx";

		// Token: 0x04002214 RID: 8724
		private const string TABLE = "Liveness";

		// Token: 0x04002215 RID: 8725
		private const string COMMAND = "select BinData from `Liveness` where Id=?";

		// Token: 0x04002216 RID: 8726
		private const string KEY_PREFIX = "LivenessById";

		// Token: 0x04002217 RID: 8727
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002218 RID: 8728
		private static int HandleId;
	}
}
