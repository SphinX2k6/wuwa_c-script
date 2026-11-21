using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005E5 RID: 1509
	public class ConfigMotorTechTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600236B RID: 9067 RVA: 0x001254F0 File Offset: 0x001236F0
		static ConfigMotorTechTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorTechTagById.CreateStaticDefaultValue), new Action(ConfigMotorTechTagById.ResetStaticDefaultValue));
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x00125510 File Offset: 0x00123710
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

		// Token: 0x0600236D RID: 9069 RVA: 0x0012558F File Offset: 0x0012378F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorTechTagById.LogPair = null;
			ConfigMotorTechTagById.HandleId = 0;
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x0012559D File Offset: 0x0012379D
		public static void Init()
		{
			ConfigMotorTechTagById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorTechTagById.HandleId, "db_motor.db", "select BinData from `MotorTechTag` where Id=?");
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x001255B8 File Offset: 0x001237B8
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

		// Token: 0x04002927 RID: 10535
		private const string DB = "db_motor.db";

		// Token: 0x04002928 RID: 10536
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x04002929 RID: 10537
		private const string TABLE = "MotorTechTag";

		// Token: 0x0400292A RID: 10538
		private const string COMMAND = "select BinData from `MotorTechTag` where Id=?";

		// Token: 0x0400292B RID: 10539
		private const string KEY_PREFIX = "MotorTechTagById";

		// Token: 0x0400292C RID: 10540
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400292D RID: 10541
		private static int HandleId;
	}
}
