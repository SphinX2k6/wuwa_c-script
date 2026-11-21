using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200081B RID: 2075
	public class ConfigRhythmTaskTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030B4 RID: 12468 RVA: 0x00170118 File Offset: 0x0016E318
		static ConfigRhythmTaskTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmTaskTabById.CreateStaticDefaultValue), new Action(ConfigRhythmTaskTabById.ResetStaticDefaultValue));
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x00170138 File Offset: 0x0016E338
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmTaskTabById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmTaskTabById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmTaskTab"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmTaskTab` where Id=?")
			});
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x001701B7 File Offset: 0x0016E3B7
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmTaskTabById.LogPair = null;
			ConfigRhythmTaskTabById.HandleId = 0;
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x001701C5 File Offset: 0x0016E3C5
		public static void Init()
		{
			ConfigRhythmTaskTabById.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmTaskTabById.HandleId, "db_rhythmship.db", "select BinData from `RhythmTaskTab` where Id=?");
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x001701E0 File Offset: 0x0016E3E0
		public static RhythmTaskTab? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmTaskTabById.HandleId, ConfigRhythmTaskTabById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmTaskTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RhythmTaskTab?(RhythmTaskTab.GetRootAsRhythmTaskTab(configBuffer));
				}
			}
			ConfigRhythmTaskTabById.LogPair.Clear();
			ConfigRhythmTaskTabById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRhythmTaskTabById.HandleId, 1, p0Id, ConfigRhythmTaskTabById.LogPair) || ConfigCommon.Step(ConfigRhythmTaskTabById.HandleId, true, ConfigRhythmTaskTabById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRhythmTaskTabById.HandleId, ConfigRhythmTaskTabById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmTaskTabById.HandleId, 0, ConfigRhythmTaskTabById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRhythmTaskTabById.HandleId, ConfigRhythmTaskTabById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RhythmTaskTab rootAsRhythmTaskTab = RhythmTaskTab.GetRootAsRhythmTaskTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmTaskTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRhythmTaskTabById.HandleId, ConfigRhythmTaskTabById.LogPair);
			return new RhythmTaskTab?(rootAsRhythmTaskTab);
		}

		// Token: 0x040038A3 RID: 14499
		private const string DB = "db_rhythmship.db";

		// Token: 0x040038A4 RID: 14500
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x040038A5 RID: 14501
		private const string TABLE = "RhythmTaskTab";

		// Token: 0x040038A6 RID: 14502
		private const string COMMAND = "select BinData from `RhythmTaskTab` where Id=?";

		// Token: 0x040038A7 RID: 14503
		private const string KEY_PREFIX = "RhythmTaskTabById";

		// Token: 0x040038A8 RID: 14504
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038A9 RID: 14505
		private static int HandleId;
	}
}
