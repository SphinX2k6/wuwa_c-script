using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005A8 RID: 1448
	public class ConfigMotorLevelHintById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021FD RID: 8701 RVA: 0x00119C9F File Offset: 0x00117E9F
		static ConfigMotorLevelHintById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLevelHintById.CreateStaticDefaultValue), new Action(ConfigMotorLevelHintById.ResetStaticDefaultValue));
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x00119CC0 File Offset: 0x00117EC0
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorLevelHintById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorLevelHintById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motor.db"),
				new ValueTuple<string, object>("文件", "m.摩托车.xlsx"),
				new ValueTuple<string, object>("表名", "MotorLevelHint"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorLevelHint` where Id=?")
			});
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x00119D3F File Offset: 0x00117F3F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLevelHintById.LogPair = null;
			ConfigMotorLevelHintById.HandleId = 0;
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x00119D4D File Offset: 0x00117F4D
		public static void Init()
		{
			ConfigMotorLevelHintById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLevelHintById.HandleId, "db_motor.db", "select BinData from `MotorLevelHint` where Id=?");
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x00119D68 File Offset: 0x00117F68
		public static MotorLevelHint? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorLevelHintById.HandleId, ConfigMotorLevelHintById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorLevelHintById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorLevelHint?(MotorLevelHint.GetRootAsMotorLevelHint(configBuffer));
				}
			}
			ConfigMotorLevelHintById.LogPair.Clear();
			ConfigMotorLevelHintById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorLevelHintById.HandleId, 1, p0Id, ConfigMotorLevelHintById.LogPair) || ConfigCommon.Step(ConfigMotorLevelHintById.HandleId, true, ConfigMotorLevelHintById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorLevelHintById.HandleId, ConfigMotorLevelHintById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorLevelHintById.HandleId, 0, ConfigMotorLevelHintById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorLevelHintById.HandleId, ConfigMotorLevelHintById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorLevelHint rootAsMotorLevelHint = MotorLevelHint.GetRootAsMotorLevelHint(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorLevelHintById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorLevelHintById.HandleId, ConfigMotorLevelHintById.LogPair);
			return new MotorLevelHint?(rootAsMotorLevelHint);
		}

		// Token: 0x0400277C RID: 10108
		private const string DB = "db_motor.db";

		// Token: 0x0400277D RID: 10109
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x0400277E RID: 10110
		private const string TABLE = "MotorLevelHint";

		// Token: 0x0400277F RID: 10111
		private const string COMMAND = "select BinData from `MotorLevelHint` where Id=?";

		// Token: 0x04002780 RID: 10112
		private const string KEY_PREFIX = "MotorLevelHintById";

		// Token: 0x04002781 RID: 10113
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002782 RID: 10114
		private static int HandleId;
	}
}
