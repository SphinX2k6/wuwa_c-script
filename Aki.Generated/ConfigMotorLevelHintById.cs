using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005BF RID: 1471
	public class ConfigMotorLevelHintById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002287 RID: 8839 RVA: 0x00120587 File Offset: 0x0011E787
		static ConfigMotorLevelHintById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLevelHintById.CreateStaticDefaultValue), new Action(ConfigMotorLevelHintById.ResetStaticDefaultValue));
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x001205A8 File Offset: 0x0011E7A8
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

		// Token: 0x06002289 RID: 8841 RVA: 0x00120627 File Offset: 0x0011E827
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLevelHintById.LogPair = null;
			ConfigMotorLevelHintById.HandleId = 0;
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x00120635 File Offset: 0x0011E835
		public static void Init()
		{
			ConfigMotorLevelHintById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLevelHintById.HandleId, "db_motor.db", "select BinData from `MotorLevelHint` where Id=?");
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x00120650 File Offset: 0x0011E850
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

		// Token: 0x0400281D RID: 10269
		private const string DB = "db_motor.db";

		// Token: 0x0400281E RID: 10270
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x0400281F RID: 10271
		private const string TABLE = "MotorLevelHint";

		// Token: 0x04002820 RID: 10272
		private const string COMMAND = "select BinData from `MotorLevelHint` where Id=?";

		// Token: 0x04002821 RID: 10273
		private const string KEY_PREFIX = "MotorLevelHintById";

		// Token: 0x04002822 RID: 10274
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002823 RID: 10275
		private static int HandleId;
	}
}
