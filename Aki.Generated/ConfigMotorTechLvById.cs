using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005E4 RID: 1508
	public class ConfigMotorTechLvById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002365 RID: 9061 RVA: 0x001252A7 File Offset: 0x001234A7
		static ConfigMotorTechLvById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorTechLvById.CreateStaticDefaultValue), new Action(ConfigMotorTechLvById.ResetStaticDefaultValue));
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x001252C8 File Offset: 0x001234C8
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorTechLvById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorTechLvById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motor.db"),
				new ValueTuple<string, object>("文件", "m.摩托车.xlsx"),
				new ValueTuple<string, object>("表名", "MotorTechLv"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorTechLv` where Id=?")
			});
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x00125347 File Offset: 0x00123547
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorTechLvById.LogPair = null;
			ConfigMotorTechLvById.HandleId = 0;
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x00125355 File Offset: 0x00123555
		public static void Init()
		{
			ConfigMotorTechLvById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorTechLvById.HandleId, "db_motor.db", "select BinData from `MotorTechLv` where Id=?");
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x00125370 File Offset: 0x00123570
		public static MotorTechLv? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorTechLvById.HandleId, ConfigMotorTechLvById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorTechLvById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorTechLv?(MotorTechLv.GetRootAsMotorTechLv(configBuffer));
				}
			}
			ConfigMotorTechLvById.LogPair.Clear();
			ConfigMotorTechLvById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorTechLvById.HandleId, 1, p0Id, ConfigMotorTechLvById.LogPair) || ConfigCommon.Step(ConfigMotorTechLvById.HandleId, true, ConfigMotorTechLvById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorTechLvById.HandleId, ConfigMotorTechLvById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorTechLvById.HandleId, 0, ConfigMotorTechLvById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorTechLvById.HandleId, ConfigMotorTechLvById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorTechLv rootAsMotorTechLv = MotorTechLv.GetRootAsMotorTechLv(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorTechLvById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorTechLvById.HandleId, ConfigMotorTechLvById.LogPair);
			return new MotorTechLv?(rootAsMotorTechLv);
		}

		// Token: 0x04002920 RID: 10528
		private const string DB = "db_motor.db";

		// Token: 0x04002921 RID: 10529
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x04002922 RID: 10530
		private const string TABLE = "MotorTechLv";

		// Token: 0x04002923 RID: 10531
		private const string COMMAND = "select BinData from `MotorTechLv` where Id=?";

		// Token: 0x04002924 RID: 10532
		private const string KEY_PREFIX = "MotorTechLvById";

		// Token: 0x04002925 RID: 10533
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002926 RID: 10534
		private static int HandleId;
	}
}
