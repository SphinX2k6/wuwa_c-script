using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005A8 RID: 1448
	public class ConfigMotorFightLevelTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021FD RID: 8701 RVA: 0x0011D2B8 File Offset: 0x0011B4B8
		static ConfigMotorFightLevelTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightLevelTypeById.CreateStaticDefaultValue), new Action(ConfigMotorFightLevelTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x0011D2D8 File Offset: 0x0011B4D8
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightLevelTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightLevelTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightLevelType"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightLevelType` where Id=?")
			});
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x0011D357 File Offset: 0x0011B557
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightLevelTypeById.LogPair = null;
			ConfigMotorFightLevelTypeById.HandleId = 0;
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x0011D365 File Offset: 0x0011B565
		public static void Init()
		{
			ConfigMotorFightLevelTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightLevelTypeById.HandleId, "db_motorfight.db", "select BinData from `MotorFightLevelType` where Id=?");
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x0011D380 File Offset: 0x0011B580
		public static MotorFightLevelType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightLevelTypeById.HandleId, ConfigMotorFightLevelTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightLevelTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightLevelType?(MotorFightLevelType.GetRootAsMotorFightLevelType(configBuffer));
				}
			}
			ConfigMotorFightLevelTypeById.LogPair.Clear();
			ConfigMotorFightLevelTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightLevelTypeById.HandleId, 1, p0Id, ConfigMotorFightLevelTypeById.LogPair) || ConfigCommon.Step(ConfigMotorFightLevelTypeById.HandleId, true, ConfigMotorFightLevelTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightLevelTypeById.HandleId, ConfigMotorFightLevelTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightLevelTypeById.HandleId, 0, ConfigMotorFightLevelTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightLevelTypeById.HandleId, ConfigMotorFightLevelTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightLevelType rootAsMotorFightLevelType = MotorFightLevelType.GetRootAsMotorFightLevelType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightLevelTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightLevelTypeById.HandleId, ConfigMotorFightLevelTypeById.LogPair);
			return new MotorFightLevelType?(rootAsMotorFightLevelType);
		}

		// Token: 0x0400277C RID: 10108
		private const string DB = "db_motorfight.db";

		// Token: 0x0400277D RID: 10109
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x0400277E RID: 10110
		private const string TABLE = "MotorFightLevelType";

		// Token: 0x0400277F RID: 10111
		private const string COMMAND = "select BinData from `MotorFightLevelType` where Id=?";

		// Token: 0x04002780 RID: 10112
		private const string KEY_PREFIX = "MotorFightLevelTypeById";

		// Token: 0x04002781 RID: 10113
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002782 RID: 10114
		private static int HandleId;
	}
}
