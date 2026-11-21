using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005E2 RID: 1506
	public class ConfigMotorTechById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002359 RID: 9049 RVA: 0x00124E27 File Offset: 0x00123027
		static ConfigMotorTechById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorTechById.CreateStaticDefaultValue), new Action(ConfigMotorTechById.ResetStaticDefaultValue));
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x00124E48 File Offset: 0x00123048
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorTechById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorTechById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motor.db"),
				new ValueTuple<string, object>("文件", "m.摩托车.xlsx"),
				new ValueTuple<string, object>("表名", "MotorTech"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorTech` where Id=?")
			});
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x00124EC7 File Offset: 0x001230C7
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorTechById.LogPair = null;
			ConfigMotorTechById.HandleId = 0;
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x00124ED5 File Offset: 0x001230D5
		public static void Init()
		{
			ConfigMotorTechById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorTechById.HandleId, "db_motor.db", "select BinData from `MotorTech` where Id=?");
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x00124EF0 File Offset: 0x001230F0
		public static MotorTech? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorTechById.HandleId, ConfigMotorTechById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorTechById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorTech?(MotorTech.GetRootAsMotorTech(configBuffer));
				}
			}
			ConfigMotorTechById.LogPair.Clear();
			ConfigMotorTechById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorTechById.HandleId, 1, p0Id, ConfigMotorTechById.LogPair) || ConfigCommon.Step(ConfigMotorTechById.HandleId, true, ConfigMotorTechById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorTechById.HandleId, ConfigMotorTechById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorTechById.HandleId, 0, ConfigMotorTechById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorTechById.HandleId, ConfigMotorTechById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorTech rootAsMotorTech = MotorTech.GetRootAsMotorTech(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorTechById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorTechById.HandleId, ConfigMotorTechById.LogPair);
			return new MotorTech?(rootAsMotorTech);
		}

		// Token: 0x04002912 RID: 10514
		private const string DB = "db_motor.db";

		// Token: 0x04002913 RID: 10515
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x04002914 RID: 10516
		private const string TABLE = "MotorTech";

		// Token: 0x04002915 RID: 10517
		private const string COMMAND = "select BinData from `MotorTech` where Id=?";

		// Token: 0x04002916 RID: 10518
		private const string KEY_PREFIX = "MotorTechById";

		// Token: 0x04002917 RID: 10519
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002918 RID: 10520
		private static int HandleId;
	}
}
