using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000183 RID: 387
	public class ConfigComicPrefabConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000913 RID: 2323 RVA: 0x0008CBE0 File Offset: 0x0008ADE0
		static ConfigComicPrefabConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigComicPrefabConfigById.CreateStaticDefaultValue), new Action(ConfigComicPrefabConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0008CC00 File Offset: 0x0008AE00
		public static void CreateStaticDefaultValue()
		{
			ConfigComicPrefabConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigComicPrefabConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_comic.db"),
				new ValueTuple<string, object>("文件", "m.漫画.xlsx"),
				new ValueTuple<string, object>("表名", "ComicPrefabConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `ComicPrefabConfig` where Id=?")
			});
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0008CC7F File Offset: 0x0008AE7F
		public static void ResetStaticDefaultValue()
		{
			ConfigComicPrefabConfigById.LogPair = null;
			ConfigComicPrefabConfigById.HandleId = 0;
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0008CC8D File Offset: 0x0008AE8D
		public static void Init()
		{
			ConfigComicPrefabConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigComicPrefabConfigById.HandleId, "db_comic.db", "select BinData from `ComicPrefabConfig` where Id=?");
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0008CCA8 File Offset: 0x0008AEA8
		public static ComicPrefabConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigComicPrefabConfigById.HandleId, ConfigComicPrefabConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ComicPrefabConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ComicPrefabConfig?(ComicPrefabConfig.GetRootAsComicPrefabConfig(configBuffer));
				}
			}
			ConfigComicPrefabConfigById.LogPair.Clear();
			ConfigComicPrefabConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigComicPrefabConfigById.HandleId, 1, p0Id, ConfigComicPrefabConfigById.LogPair) || ConfigCommon.Step(ConfigComicPrefabConfigById.HandleId, true, ConfigComicPrefabConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigComicPrefabConfigById.HandleId, ConfigComicPrefabConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigComicPrefabConfigById.HandleId, 0, ConfigComicPrefabConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigComicPrefabConfigById.HandleId, ConfigComicPrefabConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ComicPrefabConfig rootAsComicPrefabConfig = ComicPrefabConfig.GetRootAsComicPrefabConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ComicPrefabConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigComicPrefabConfigById.HandleId, ConfigComicPrefabConfigById.LogPair);
			return new ComicPrefabConfig?(rootAsComicPrefabConfig);
		}

		// Token: 0x04000A79 RID: 2681
		private const string DB = "db_comic.db";

		// Token: 0x04000A7A RID: 2682
		private const string FILE = "m.漫画.xlsx";

		// Token: 0x04000A7B RID: 2683
		private const string TABLE = "ComicPrefabConfig";

		// Token: 0x04000A7C RID: 2684
		private const string COMMAND = "select BinData from `ComicPrefabConfig` where Id=?";

		// Token: 0x04000A7D RID: 2685
		private const string KEY_PREFIX = "ComicPrefabConfigById";

		// Token: 0x04000A7E RID: 2686
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A7F RID: 2687
		private static int HandleId;
	}
}
