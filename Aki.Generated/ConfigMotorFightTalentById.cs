using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200059C RID: 1436
	public class ConfigMotorFightTalentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021B5 RID: 8629 RVA: 0x00118213 File Offset: 0x00116413
		static ConfigMotorFightTalentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightTalentById.CreateStaticDefaultValue), new Action(ConfigMotorFightTalentById.ResetStaticDefaultValue));
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x00118234 File Offset: 0x00116434
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightTalentById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightTalentById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightTalent"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightTalent` where Id=?")
			});
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x001182B3 File Offset: 0x001164B3
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightTalentById.LogPair = null;
			ConfigMotorFightTalentById.HandleId = 0;
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x001182C1 File Offset: 0x001164C1
		public static void Init()
		{
			ConfigMotorFightTalentById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightTalentById.HandleId, "db_motorfight.db", "select BinData from `MotorFightTalent` where Id=?");
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x001182DC File Offset: 0x001164DC
		public static MotorFightTalent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightTalentById.HandleId, ConfigMotorFightTalentById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightTalentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightTalent?(MotorFightTalent.GetRootAsMotorFightTalent(configBuffer));
				}
			}
			ConfigMotorFightTalentById.LogPair.Clear();
			ConfigMotorFightTalentById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightTalentById.HandleId, 1, p0Id, ConfigMotorFightTalentById.LogPair) || ConfigCommon.Step(ConfigMotorFightTalentById.HandleId, true, ConfigMotorFightTalentById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightTalentById.HandleId, ConfigMotorFightTalentById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightTalentById.HandleId, 0, ConfigMotorFightTalentById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightTalentById.HandleId, ConfigMotorFightTalentById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightTalent rootAsMotorFightTalent = MotorFightTalent.GetRootAsMotorFightTalent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightTalentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightTalentById.HandleId, ConfigMotorFightTalentById.LogPair);
			return new MotorFightTalent?(rootAsMotorFightTalent);
		}

		// Token: 0x04002728 RID: 10024
		private const string DB = "db_motorfight.db";

		// Token: 0x04002729 RID: 10025
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x0400272A RID: 10026
		private const string TABLE = "MotorFightTalent";

		// Token: 0x0400272B RID: 10027
		private const string COMMAND = "select BinData from `MotorFightTalent` where Id=?";

		// Token: 0x0400272C RID: 10028
		private const string KEY_PREFIX = "MotorFightTalentById";

		// Token: 0x0400272D RID: 10029
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400272E RID: 10030
		private static int HandleId;
	}
}
