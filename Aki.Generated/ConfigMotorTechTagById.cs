using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005CD RID: 1485
	public class ConfigMotorTechTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022DB RID: 8923 RVA: 0x0011EA74 File Offset: 0x0011CC74
		static ConfigMotorTechTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorTechTagById.CreateStaticDefaultValue), new Action(ConfigMotorTechTagById.ResetStaticDefaultValue));
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x0011EA94 File Offset: 0x0011CC94
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorTechTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorTechTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motor.db"),
				new ValueTuple<string, object>("文件", "m.摩托车.xlsx"),
				new ValueTuple<string, object>("表名", "MotorTechTag"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorTechTag` where Id=?")
			});
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x0011EB13 File Offset: 0x0011CD13
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorTechTagById.LogPair = null;
			ConfigMotorTechTagById.HandleId = 0;
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x0011EB21 File Offset: 0x0011CD21
		public static void Init()
		{
			ConfigMotorTechTagById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorTechTagById.HandleId, "db_motor.db", "select BinData from `MotorTechTag` where Id=?");
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x0011EB3C File Offset: 0x0011CD3C
		public static MotorTechTag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorTechTagById.HandleId, ConfigMotorTechTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorTechTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorTechTag?(MotorTechTag.GetRootAsMotorTechTag(configBuffer));
				}
			}
			ConfigMotorTechTagById.LogPair.Clear();
			ConfigMotorTechTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorTechTagById.HandleId, 1, p0Id, ConfigMotorTechTagById.LogPair) || ConfigCommon.Step(ConfigMotorTechTagById.HandleId, true, ConfigMotorTechTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorTechTagById.HandleId, ConfigMotorTechTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorTechTagById.HandleId, 0, ConfigMotorTechTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorTechTagById.HandleId, ConfigMotorTechTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorTechTag rootAsMotorTechTag = MotorTechTag.GetRootAsMotorTechTag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorTechTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorTechTagById.HandleId, ConfigMotorTechTagById.LogPair);
			return new MotorTechTag?(rootAsMotorTechTag);
		}

		// Token: 0x0400287F RID: 10367
		private const string DB = "db_motor.db";

		// Token: 0x04002880 RID: 10368
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x04002881 RID: 10369
		private const string TABLE = "MotorTechTag";

		// Token: 0x04002882 RID: 10370
		private const string COMMAND = "select BinData from `MotorTechTag` where Id=?";

		// Token: 0x04002883 RID: 10371
		private const string KEY_PREFIX = "MotorTechTagById";

		// Token: 0x04002884 RID: 10372
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002885 RID: 10373
		private static int HandleId;
	}
}
