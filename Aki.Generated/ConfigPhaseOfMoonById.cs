using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006BC RID: 1724
	public class ConfigPhaseOfMoonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002878 RID: 10360 RVA: 0x0013E60F File Offset: 0x0013C80F
		static ConfigPhaseOfMoonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhaseOfMoonById.CreateStaticDefaultValue), new Action(ConfigPhaseOfMoonById.ResetStaticDefaultValue));
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x0013E630 File Offset: 0x0013C830
		public static void CreateStaticDefaultValue()
		{
			ConfigPhaseOfMoonById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhaseOfMoonById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonsignin.db"),
				new ValueTuple<string, object>("文件", "y.月相活动.xlsx"),
				new ValueTuple<string, object>("表名", "PhaseOfMoon"),
				new ValueTuple<string, object>("语句", "select BinData from `PhaseOfMoon` where Id=?")
			});
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x0013E6AF File Offset: 0x0013C8AF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhaseOfMoonById.LogPair = null;
			ConfigPhaseOfMoonById.HandleId = 0;
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x0013E6BD File Offset: 0x0013C8BD
		public static void Init()
		{
			ConfigPhaseOfMoonById.HandleId = ConfigCommon.InitDataStatement(ConfigPhaseOfMoonById.HandleId, "db_moonsignin.db", "select BinData from `PhaseOfMoon` where Id=?");
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x0013E6D8 File Offset: 0x0013C8D8
		public static PhaseOfMoon? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhaseOfMoonById.HandleId, ConfigPhaseOfMoonById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhaseOfMoonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhaseOfMoon?(PhaseOfMoon.GetRootAsPhaseOfMoon(configBuffer));
				}
			}
			ConfigPhaseOfMoonById.LogPair.Clear();
			ConfigPhaseOfMoonById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhaseOfMoonById.HandleId, 1, p0Id, ConfigPhaseOfMoonById.LogPair) || ConfigCommon.Step(ConfigPhaseOfMoonById.HandleId, true, ConfigPhaseOfMoonById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhaseOfMoonById.HandleId, ConfigPhaseOfMoonById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhaseOfMoonById.HandleId, 0, ConfigPhaseOfMoonById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhaseOfMoonById.HandleId, ConfigPhaseOfMoonById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhaseOfMoon rootAsPhaseOfMoon = PhaseOfMoon.GetRootAsPhaseOfMoon(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhaseOfMoonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhaseOfMoonById.HandleId, ConfigPhaseOfMoonById.LogPair);
			return new PhaseOfMoon?(rootAsPhaseOfMoon);
		}

		// Token: 0x04002F0A RID: 12042
		private const string DB = "db_moonsignin.db";

		// Token: 0x04002F0B RID: 12043
		private const string FILE = "y.月相活动.xlsx";

		// Token: 0x04002F0C RID: 12044
		private const string TABLE = "PhaseOfMoon";

		// Token: 0x04002F0D RID: 12045
		private const string COMMAND = "select BinData from `PhaseOfMoon` where Id=?";

		// Token: 0x04002F0E RID: 12046
		private const string KEY_PREFIX = "PhaseOfMoonById";

		// Token: 0x04002F0F RID: 12047
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F10 RID: 12048
		private static int HandleId;
	}
}
