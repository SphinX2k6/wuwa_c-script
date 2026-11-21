using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000176 RID: 374
	public class ConfigCiacconaGalChapterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008C5 RID: 2245 RVA: 0x0008E983 File Offset: 0x0008CB83
		static ConfigCiacconaGalChapterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaGalChapterById.CreateStaticDefaultValue), new Action(ConfigCiacconaGalChapterById.ResetStaticDefaultValue));
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0008E9A4 File Offset: 0x0008CBA4
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

		// Token: 0x060008C7 RID: 2247 RVA: 0x0008EA23 File Offset: 0x0008CC23
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaGalChapterById.LogPair = null;
			ConfigCiacconaGalChapterById.HandleId = 0;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0008EA31 File Offset: 0x0008CC31
		public static void Init()
		{
			ConfigCiacconaGalChapterById.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaGalChapterById.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaGalChapter` where Id=?");
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0008EA4C File Offset: 0x0008CC4C
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

		// Token: 0x04000A1E RID: 2590
		private const string DB = "db_ciacconagal.db";

		// Token: 0x04000A1F RID: 2591
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x04000A20 RID: 2592
		private const string TABLE = "CiacconaGalChapter";

		// Token: 0x04000A21 RID: 2593
		private const string COMMAND = "select BinData from `CiacconaGalChapter` where Id=?";

		// Token: 0x04000A22 RID: 2594
		private const string KEY_PREFIX = "CiacconaGalChapterById";

		// Token: 0x04000A23 RID: 2595
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A24 RID: 2596
		private static int HandleId;
	}
}
