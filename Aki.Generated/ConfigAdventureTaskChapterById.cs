using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000066 RID: 102
	public class ConfigAdventureTaskChapterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000264 RID: 612 RVA: 0x0006AAD3 File Offset: 0x00068CD3
		static ConfigAdventureTaskChapterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdventureTaskChapterById.CreateStaticDefaultValue), new Action(ConfigAdventureTaskChapterById.ResetStaticDefaultValue));
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0006AAF4 File Offset: 0x00068CF4
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

		// Token: 0x06000266 RID: 614 RVA: 0x0006AB73 File Offset: 0x00068D73
		public static void ResetStaticDefaultValue()
		{
			ConfigAdventureTaskChapterById.LogPair = null;
			ConfigAdventureTaskChapterById.HandleId = 0;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0006AB81 File Offset: 0x00068D81
		public static void Init()
		{
			ConfigAdventureTaskChapterById.HandleId = ConfigCommon.InitDataStatement(ConfigAdventureTaskChapterById.HandleId, "db_adventuretask.db", "select BinData from `AdventureTaskChapter` where Id=?");
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0006AB9C File Offset: 0x00068D9C
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

		// Token: 0x040002AE RID: 686
		private const string DB = "db_adventuretask.db";

		// Token: 0x040002AF RID: 687
		private const string FILE = "k.开拓任务.xlsx";

		// Token: 0x040002B0 RID: 688
		private const string TABLE = "AdventureTaskChapter";

		// Token: 0x040002B1 RID: 689
		private const string COMMAND = "select BinData from `AdventureTaskChapter` where Id=?";

		// Token: 0x040002B2 RID: 690
		private const string KEY_PREFIX = "AdventureTaskChapterById";

		// Token: 0x040002B3 RID: 691
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002B4 RID: 692
		private static int HandleId;
	}
}
