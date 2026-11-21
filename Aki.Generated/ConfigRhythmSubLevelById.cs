using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000816 RID: 2070
	public class ConfigRhythmSubLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003096 RID: 12438 RVA: 0x0016F52F File Offset: 0x0016D72F
		static ConfigRhythmSubLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmSubLevelById.CreateStaticDefaultValue), new Action(ConfigRhythmSubLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x0016F550 File Offset: 0x0016D750
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmSubLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmSubLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmSubLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmSubLevel` where Id=?")
			});
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x0016F5CF File Offset: 0x0016D7CF
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmSubLevelById.LogPair = null;
			ConfigRhythmSubLevelById.HandleId = 0;
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x0016F5DD File Offset: 0x0016D7DD
		public static void Init()
		{
			ConfigRhythmSubLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmSubLevelById.HandleId, "db_rhythmship.db", "select BinData from `RhythmSubLevel` where Id=?");
		}

		// Token: 0x0600309A RID: 12442 RVA: 0x0016F5F8 File Offset: 0x0016D7F8
		public static RhythmSubLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmSubLevelById.HandleId, ConfigRhythmSubLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmSubLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RhythmSubLevel?(RhythmSubLevel.GetRootAsRhythmSubLevel(configBuffer));
				}
			}
			ConfigRhythmSubLevelById.LogPair.Clear();
			ConfigRhythmSubLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRhythmSubLevelById.HandleId, 1, p0Id, ConfigRhythmSubLevelById.LogPair) || ConfigCommon.Step(ConfigRhythmSubLevelById.HandleId, true, ConfigRhythmSubLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRhythmSubLevelById.HandleId, ConfigRhythmSubLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmSubLevelById.HandleId, 0, ConfigRhythmSubLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRhythmSubLevelById.HandleId, ConfigRhythmSubLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RhythmSubLevel rootAsRhythmSubLevel = RhythmSubLevel.GetRootAsRhythmSubLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmSubLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRhythmSubLevelById.HandleId, ConfigRhythmSubLevelById.LogPair);
			return new RhythmSubLevel?(rootAsRhythmSubLevel);
		}

		// Token: 0x04003880 RID: 14464
		private const string DB = "db_rhythmship.db";

		// Token: 0x04003881 RID: 14465
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x04003882 RID: 14466
		private const string TABLE = "RhythmSubLevel";

		// Token: 0x04003883 RID: 14467
		private const string COMMAND = "select BinData from `RhythmSubLevel` where Id=?";

		// Token: 0x04003884 RID: 14468
		private const string KEY_PREFIX = "RhythmSubLevelById";

		// Token: 0x04003885 RID: 14469
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003886 RID: 14470
		private static int HandleId;
	}
}
