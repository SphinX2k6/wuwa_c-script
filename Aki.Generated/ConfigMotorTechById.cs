using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005CA RID: 1482
	public class ConfigMotorTechById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022C9 RID: 8905 RVA: 0x0011E3AB File Offset: 0x0011C5AB
		static ConfigMotorTechById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorTechById.CreateStaticDefaultValue), new Action(ConfigMotorTechById.ResetStaticDefaultValue));
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x0011E3CC File Offset: 0x0011C5CC
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

		// Token: 0x060022CB RID: 8907 RVA: 0x0011E44B File Offset: 0x0011C64B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorTechById.LogPair = null;
			ConfigMotorTechById.HandleId = 0;
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x0011E459 File Offset: 0x0011C659
		public static void Init()
		{
			ConfigMotorTechById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorTechById.HandleId, "db_motor.db", "select BinData from `MotorTech` where Id=?");
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x0011E474 File Offset: 0x0011C674
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

		// Token: 0x0400286A RID: 10346
		private const string DB = "db_motor.db";

		// Token: 0x0400286B RID: 10347
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x0400286C RID: 10348
		private const string TABLE = "MotorTech";

		// Token: 0x0400286D RID: 10349
		private const string COMMAND = "select BinData from `MotorTech` where Id=?";

		// Token: 0x0400286E RID: 10350
		private const string KEY_PREFIX = "MotorTechById";

		// Token: 0x0400286F RID: 10351
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002870 RID: 10352
		private static int HandleId;
	}
}
