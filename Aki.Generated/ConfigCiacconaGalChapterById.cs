using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000166 RID: 358
	public class ConfigCiacconaGalChapterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000865 RID: 2149 RVA: 0x00088E27 File Offset: 0x00087027
		static ConfigCiacconaGalChapterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaGalChapterById.CreateStaticDefaultValue), new Action(ConfigCiacconaGalChapterById.ResetStaticDefaultValue));
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00088E48 File Offset: 0x00087048
		public static void CreateStaticDefaultValue()
		{
			ConfigCiacconaGalChapterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCiacconaGalChapterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ciacconagal.db"),
				new ValueTuple<string, object>("文件", "x.夏空活动.xlsx"),
				new ValueTuple<string, object>("表名", "CiacconaGalChapter"),
				new ValueTuple<string, object>("语句", "select BinData from `CiacconaGalChapter` where Id=?")
			});
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00088EC7 File Offset: 0x000870C7
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaGalChapterById.LogPair = null;
			ConfigCiacconaGalChapterById.HandleId = 0;
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00088ED5 File Offset: 0x000870D5
		public static void Init()
		{
			ConfigCiacconaGalChapterById.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaGalChapterById.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaGalChapter` where Id=?");
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00088EF0 File Offset: 0x000870F0
		public static CiacconaGalChapter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCiacconaGalChapterById.HandleId, ConfigCiacconaGalChapterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaGalChapterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CiacconaGalChapter?(CiacconaGalChapter.GetRootAsCiacconaGalChapter(configBuffer));
				}
			}
			ConfigCiacconaGalChapterById.LogPair.Clear();
			ConfigCiacconaGalChapterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCiacconaGalChapterById.HandleId, 1, p0Id, ConfigCiacconaGalChapterById.LogPair) || ConfigCommon.Step(ConfigCiacconaGalChapterById.HandleId, true, ConfigCiacconaGalChapterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCiacconaGalChapterById.HandleId, ConfigCiacconaGalChapterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCiacconaGalChapterById.HandleId, 0, ConfigCiacconaGalChapterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCiacconaGalChapterById.HandleId, ConfigCiacconaGalChapterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CiacconaGalChapter rootAsCiacconaGalChapter = CiacconaGalChapter.GetRootAsCiacconaGalChapter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaGalChapterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCiacconaGalChapterById.HandleId, ConfigCiacconaGalChapterById.LogPair);
			return new CiacconaGalChapter?(rootAsCiacconaGalChapter);
		}

		// Token: 0x040009AE RID: 2478
		private const string DB = "db_ciacconagal.db";

		// Token: 0x040009AF RID: 2479
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x040009B0 RID: 2480
		private const string TABLE = "CiacconaGalChapter";

		// Token: 0x040009B1 RID: 2481
		private const string COMMAND = "select BinData from `CiacconaGalChapter` where Id=?";

		// Token: 0x040009B2 RID: 2482
		private const string KEY_PREFIX = "CiacconaGalChapterById";

		// Token: 0x040009B3 RID: 2483
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009B4 RID: 2484
		private static int HandleId;
	}
}
