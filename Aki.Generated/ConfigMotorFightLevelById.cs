using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000590 RID: 1424
	public class ConfigMotorFightLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600216D RID: 8557 RVA: 0x00116787 File Offset: 0x00114987
		static ConfigMotorFightLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightLevelById.CreateStaticDefaultValue), new Action(ConfigMotorFightLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x001167A8 File Offset: 0x001149A8
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightLevel` where Id=?")
			});
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x00116827 File Offset: 0x00114A27
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightLevelById.LogPair = null;
			ConfigMotorFightLevelById.HandleId = 0;
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x00116835 File Offset: 0x00114A35
		public static void Init()
		{
			ConfigMotorFightLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightLevelById.HandleId, "db_motorfight.db", "select BinData from `MotorFightLevel` where Id=?");
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x00116850 File Offset: 0x00114A50
		public static MotorFightLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightLevelById.HandleId, ConfigMotorFightLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightLevel?(MotorFightLevel.GetRootAsMotorFightLevel(configBuffer));
				}
			}
			ConfigMotorFightLevelById.LogPair.Clear();
			ConfigMotorFightLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightLevelById.HandleId, 1, p0Id, ConfigMotorFightLevelById.LogPair) || ConfigCommon.Step(ConfigMotorFightLevelById.HandleId, true, ConfigMotorFightLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightLevelById.HandleId, ConfigMotorFightLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightLevelById.HandleId, 0, ConfigMotorFightLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightLevelById.HandleId, ConfigMotorFightLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightLevel rootAsMotorFightLevel = MotorFightLevel.GetRootAsMotorFightLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightLevelById.HandleId, ConfigMotorFightLevelById.LogPair);
			return new MotorFightLevel?(rootAsMotorFightLevel);
		}

		// Token: 0x040026D4 RID: 9940
		private const string DB = "db_motorfight.db";

		// Token: 0x040026D5 RID: 9941
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x040026D6 RID: 9942
		private const string TABLE = "MotorFightLevel";

		// Token: 0x040026D7 RID: 9943
		private const string COMMAND = "select BinData from `MotorFightLevel` where Id=?";

		// Token: 0x040026D8 RID: 9944
		private const string KEY_PREFIX = "MotorFightLevelById";

		// Token: 0x040026D9 RID: 9945
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026DA RID: 9946
		private static int HandleId;
	}
}
