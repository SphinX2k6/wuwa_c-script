using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000591 RID: 1425
	public class ConfigMotorFightLevelTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002173 RID: 8563 RVA: 0x001169D0 File Offset: 0x00114BD0
		static ConfigMotorFightLevelTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightLevelTypeById.CreateStaticDefaultValue), new Action(ConfigMotorFightLevelTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x001169F0 File Offset: 0x00114BF0
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

		// Token: 0x06002175 RID: 8565 RVA: 0x00116A6F File Offset: 0x00114C6F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightLevelTypeById.LogPair = null;
			ConfigMotorFightLevelTypeById.HandleId = 0;
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x00116A7D File Offset: 0x00114C7D
		public static void Init()
		{
			ConfigMotorFightLevelTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightLevelTypeById.HandleId, "db_motorfight.db", "select BinData from `MotorFightLevelType` where Id=?");
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x00116A98 File Offset: 0x00114C98
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

		// Token: 0x040026DB RID: 9947
		private const string DB = "db_motorfight.db";

		// Token: 0x040026DC RID: 9948
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x040026DD RID: 9949
		private const string TABLE = "MotorFightLevelType";

		// Token: 0x040026DE RID: 9950
		private const string COMMAND = "select BinData from `MotorFightLevelType` where Id=?";

		// Token: 0x040026DF RID: 9951
		private const string KEY_PREFIX = "MotorFightLevelTypeById";

		// Token: 0x040026E0 RID: 9952
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026E1 RID: 9953
		private static int HandleId;
	}
}
