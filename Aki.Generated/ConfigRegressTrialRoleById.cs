using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007FB RID: 2043
	public class ConfigRegressTrialRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FF4 RID: 12276 RVA: 0x0016BB63 File Offset: 0x00169D63
		static ConfigRegressTrialRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressTrialRoleById.CreateStaticDefaultValue), new Action(ConfigRegressTrialRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x06002FF5 RID: 12277 RVA: 0x0016BB84 File Offset: 0x00169D84
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressTrialRoleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressTrialRoleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressTrialRole"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressTrialRole` where Id=?")
			});
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x0016BC03 File Offset: 0x00169E03
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressTrialRoleById.LogPair = null;
			ConfigRegressTrialRoleById.HandleId = 0;
		}

		// Token: 0x06002FF7 RID: 12279 RVA: 0x0016BC11 File Offset: 0x00169E11
		public static void Init()
		{
			ConfigRegressTrialRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigRegressTrialRoleById.HandleId, "db_regressactivity.db", "select BinData from `RegressTrialRole` where Id=?");
		}

		// Token: 0x06002FF8 RID: 12280 RVA: 0x0016BC2C File Offset: 0x00169E2C
		public static RegressTrialRole? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressTrialRoleById.HandleId, ConfigRegressTrialRoleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressTrialRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RegressTrialRole?(RegressTrialRole.GetRootAsRegressTrialRole(configBuffer));
				}
			}
			ConfigRegressTrialRoleById.LogPair.Clear();
			ConfigRegressTrialRoleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRegressTrialRoleById.HandleId, 1, p0Id, ConfigRegressTrialRoleById.LogPair) || ConfigCommon.Step(ConfigRegressTrialRoleById.HandleId, true, ConfigRegressTrialRoleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRegressTrialRoleById.HandleId, ConfigRegressTrialRoleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressTrialRoleById.HandleId, 0, ConfigRegressTrialRoleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRegressTrialRoleById.HandleId, ConfigRegressTrialRoleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RegressTrialRole rootAsRegressTrialRole = RegressTrialRole.GetRootAsRegressTrialRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressTrialRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRegressTrialRoleById.HandleId, ConfigRegressTrialRoleById.LogPair);
			return new RegressTrialRole?(rootAsRegressTrialRole);
		}

		// Token: 0x040037C3 RID: 14275
		private const string DB = "db_regressactivity.db";

		// Token: 0x040037C4 RID: 14276
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x040037C5 RID: 14277
		private const string TABLE = "RegressTrialRole";

		// Token: 0x040037C6 RID: 14278
		private const string COMMAND = "select BinData from `RegressTrialRole` where Id=?";

		// Token: 0x040037C7 RID: 14279
		private const string KEY_PREFIX = "RegressTrialRoleById";

		// Token: 0x040037C8 RID: 14280
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037C9 RID: 14281
		private static int HandleId;
	}
}
