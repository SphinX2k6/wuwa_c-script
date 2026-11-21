using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006D4 RID: 1748
	public class ConfigPhaseOfMoonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002908 RID: 10504 RVA: 0x0014508B File Offset: 0x0014328B
		static ConfigPhaseOfMoonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhaseOfMoonById.CreateStaticDefaultValue), new Action(ConfigPhaseOfMoonById.ResetStaticDefaultValue));
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x001450AC File Offset: 0x001432AC
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

		// Token: 0x0600290A RID: 10506 RVA: 0x0014512B File Offset: 0x0014332B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhaseOfMoonById.LogPair = null;
			ConfigPhaseOfMoonById.HandleId = 0;
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x00145139 File Offset: 0x00143339
		public static void Init()
		{
			ConfigPhaseOfMoonById.HandleId = ConfigCommon.InitDataStatement(ConfigPhaseOfMoonById.HandleId, "db_moonsignin.db", "select BinData from `PhaseOfMoon` where Id=?");
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x00145154 File Offset: 0x00143354
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

		// Token: 0x04002FB2 RID: 12210
		private const string DB = "db_moonsignin.db";

		// Token: 0x04002FB3 RID: 12211
		private const string FILE = "y.月相活动.xlsx";

		// Token: 0x04002FB4 RID: 12212
		private const string TABLE = "PhaseOfMoon";

		// Token: 0x04002FB5 RID: 12213
		private const string COMMAND = "select BinData from `PhaseOfMoon` where Id=?";

		// Token: 0x04002FB6 RID: 12214
		private const string KEY_PREFIX = "PhaseOfMoonById";

		// Token: 0x04002FB7 RID: 12215
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FB8 RID: 12216
		private static int HandleId;
	}
}
