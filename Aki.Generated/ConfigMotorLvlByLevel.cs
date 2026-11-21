using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005C8 RID: 1480
	public class ConfigMotorLvlByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022BD RID: 8893 RVA: 0x0012172F File Offset: 0x0011F92F
		static ConfigMotorLvlByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLvlByLevel.CreateStaticDefaultValue), new Action(ConfigMotorLvlByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x00121750 File Offset: 0x0011F950
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorLvlByLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorLvlByLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motor.db"),
				new ValueTuple<string, object>("文件", "m.摩托车.xlsx"),
				new ValueTuple<string, object>("表名", "MotorLvl"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorLvl` where Level=?")
			});
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x001217CF File Offset: 0x0011F9CF
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLvlByLevel.LogPair = null;
			ConfigMotorLvlByLevel.HandleId = 0;
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x001217DD File Offset: 0x0011F9DD
		public static void Init()
		{
			ConfigMotorLvlByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLvlByLevel.HandleId, "db_motor.db", "select BinData from `MotorLvl` where Level=?");
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x001217F8 File Offset: 0x0011F9F8
		public static MotorLvl? GetConfig(int p0Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorLvlByLevel.HandleId, ConfigMotorLvlByLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorLvlByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorLvl?(MotorLvl.GetRootAsMotorLvl(configBuffer));
				}
			}
			ConfigMotorLvlByLevel.LogPair.Clear();
			ConfigMotorLvlByLevel.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			if (!ConfigCommon.BindInt(ConfigMotorLvlByLevel.HandleId, 1, p0Level, ConfigMotorLvlByLevel.LogPair) || ConfigCommon.Step(ConfigMotorLvlByLevel.HandleId, true, ConfigMotorLvlByLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorLvlByLevel.HandleId, ConfigMotorLvlByLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorLvlByLevel.HandleId, 0, ConfigMotorLvlByLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorLvlByLevel.HandleId, ConfigMotorLvlByLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorLvl rootAsMotorLvl = MotorLvl.GetRootAsMotorLvl(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorLvlByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorLvlByLevel.HandleId, ConfigMotorLvlByLevel.LogPair);
			return new MotorLvl?(rootAsMotorLvl);
		}

		// Token: 0x0400285C RID: 10332
		private const string DB = "db_motor.db";

		// Token: 0x0400285D RID: 10333
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x0400285E RID: 10334
		private const string TABLE = "MotorLvl";

		// Token: 0x0400285F RID: 10335
		private const string COMMAND = "select BinData from `MotorLvl` where Level=?";

		// Token: 0x04002860 RID: 10336
		private const string KEY_PREFIX = "MotorLvlByLevel";

		// Token: 0x04002861 RID: 10337
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002862 RID: 10338
		private static int HandleId;
	}
}
