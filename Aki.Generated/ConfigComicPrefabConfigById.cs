using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000195 RID: 405
	public class ConfigComicPrefabConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600097F RID: 2431 RVA: 0x00092B18 File Offset: 0x00090D18
		static ConfigComicPrefabConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigComicPrefabConfigById.CreateStaticDefaultValue), new Action(ConfigComicPrefabConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00092B38 File Offset: 0x00090D38
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

		// Token: 0x06000981 RID: 2433 RVA: 0x00092BB7 File Offset: 0x00090DB7
		public static void ResetStaticDefaultValue()
		{
			ConfigComicPrefabConfigById.LogPair = null;
			ConfigComicPrefabConfigById.HandleId = 0;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00092BC5 File Offset: 0x00090DC5
		public static void Init()
		{
			ConfigComicPrefabConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigComicPrefabConfigById.HandleId, "db_comic.db", "select BinData from `ComicPrefabConfig` where Id=?");
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00092BE0 File Offset: 0x00090DE0
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

		// Token: 0x04000AF7 RID: 2807
		private const string DB = "db_comic.db";

		// Token: 0x04000AF8 RID: 2808
		private const string FILE = "m.漫画.xlsx";

		// Token: 0x04000AF9 RID: 2809
		private const string TABLE = "ComicPrefabConfig";

		// Token: 0x04000AFA RID: 2810
		private const string COMMAND = "select BinData from `ComicPrefabConfig` where Id=?";

		// Token: 0x04000AFB RID: 2811
		private const string KEY_PREFIX = "ComicPrefabConfigById";

		// Token: 0x04000AFC RID: 2812
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000AFD RID: 2813
		private static int HandleId;
	}
}
