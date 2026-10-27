using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200005E RID: 94
	public class ConfigAdventureTaskChapterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000234 RID: 564 RVA: 0x0006621F File Offset: 0x0006441F
		static ConfigAdventureTaskChapterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdventureTaskChapterById.CreateStaticDefaultValue), new Action(ConfigAdventureTaskChapterById.ResetStaticDefaultValue));
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00066240 File Offset: 0x00064440
		public static void CreateStaticDefaultValue()
		{
			ConfigAdventureTaskChapterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdventureTaskChapterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventuretask.db"),
				new ValueTuple<string, object>("文件", "k.开拓任务.xlsx"),
				new ValueTuple<string, object>("表名", "AdventureTaskChapter"),
				new ValueTuple<string, object>("语句", "select BinData from `AdventureTaskChapter` where Id=?")
			});
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000662BF File Offset: 0x000644BF
		public static void ResetStaticDefaultValue()
		{
			ConfigAdventureTaskChapterById.LogPair = null;
			ConfigAdventureTaskChapterById.HandleId = 0;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000662CD File Offset: 0x000644CD
		public static void Init()
		{
			ConfigAdventureTaskChapterById.HandleId = ConfigCommon.InitDataStatement(ConfigAdventureTaskChapterById.HandleId, "db_adventuretask.db", "select BinData from `AdventureTaskChapter` where Id=?");
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000662E8 File Offset: 0x000644E8
		public static AdventureTaskChapter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdventureTaskChapterById.HandleId, ConfigAdventureTaskChapterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdventureTaskChapterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdventureTaskChapter?(AdventureTaskChapter.GetRootAsAdventureTaskChapter(configBuffer));
				}
			}
			ConfigAdventureTaskChapterById.LogPair.Clear();
			ConfigAdventureTaskChapterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAdventureTaskChapterById.HandleId, 1, p0Id, ConfigAdventureTaskChapterById.LogPair) || ConfigCommon.Step(ConfigAdventureTaskChapterById.HandleId, true, ConfigAdventureTaskChapterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdventureTaskChapterById.HandleId, ConfigAdventureTaskChapterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdventureTaskChapterById.HandleId, 0, ConfigAdventureTaskChapterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdventureTaskChapterById.HandleId, ConfigAdventureTaskChapterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdventureTaskChapter rootAsAdventureTaskChapter = AdventureTaskChapter.GetRootAsAdventureTaskChapter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdventureTaskChapterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdventureTaskChapterById.HandleId, ConfigAdventureTaskChapterById.LogPair);
			return new AdventureTaskChapter?(rootAsAdventureTaskChapter);
		}

		// Token: 0x04000276 RID: 630
		private const string DB = "db_adventuretask.db";

		// Token: 0x04000277 RID: 631
		private const string FILE = "k.开拓任务.xlsx";

		// Token: 0x04000278 RID: 632
		private const string TABLE = "AdventureTaskChapter";

		// Token: 0x04000279 RID: 633
		private const string COMMAND = "select BinData from `AdventureTaskChapter` where Id=?";

		// Token: 0x0400027A RID: 634
		private const string KEY_PREFIX = "AdventureTaskChapterById";

		// Token: 0x0400027B RID: 635
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400027C RID: 636
		private static int HandleId;
	}
}
