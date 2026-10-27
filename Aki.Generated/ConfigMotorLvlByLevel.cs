using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005B1 RID: 1457
	public class ConfigMotorLvlByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002233 RID: 8755 RVA: 0x0011AE47 File Offset: 0x00119047
		static ConfigMotorLvlByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLvlByLevel.CreateStaticDefaultValue), new Action(ConfigMotorLvlByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x0011AE68 File Offset: 0x00119068
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

		// Token: 0x06002235 RID: 8757 RVA: 0x0011AEE7 File Offset: 0x001190E7
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLvlByLevel.LogPair = null;
			ConfigMotorLvlByLevel.HandleId = 0;
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x0011AEF5 File Offset: 0x001190F5
		public static void Init()
		{
			ConfigMotorLvlByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLvlByLevel.HandleId, "db_motor.db", "select BinData from `MotorLvl` where Level=?");
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x0011AF10 File Offset: 0x00119110
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

		// Token: 0x040027BB RID: 10171
		private const string DB = "db_motor.db";

		// Token: 0x040027BC RID: 10172
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x040027BD RID: 10173
		private const string TABLE = "MotorLvl";

		// Token: 0x040027BE RID: 10174
		private const string COMMAND = "select BinData from `MotorLvl` where Level=?";

		// Token: 0x040027BF RID: 10175
		private const string KEY_PREFIX = "MotorLvlByLevel";

		// Token: 0x040027C0 RID: 10176
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027C1 RID: 10177
		private static int HandleId;
	}
}
