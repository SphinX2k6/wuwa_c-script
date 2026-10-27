using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000182 RID: 386
	public class ConfigComicDisplayConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600090D RID: 2317 RVA: 0x0008C998 File Offset: 0x0008AB98
		static ConfigComicDisplayConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigComicDisplayConfigById.CreateStaticDefaultValue), new Action(ConfigComicDisplayConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0008C9B8 File Offset: 0x0008ABB8
		public static void CreateStaticDefaultValue()
		{
			ConfigComicDisplayConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigComicDisplayConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_comic.db"),
				new ValueTuple<string, object>("文件", "m.漫画.xlsx"),
				new ValueTuple<string, object>("表名", "ComicDisplayConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `ComicDisplayConfig` where Id=?")
			});
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0008CA37 File Offset: 0x0008AC37
		public static void ResetStaticDefaultValue()
		{
			ConfigComicDisplayConfigById.LogPair = null;
			ConfigComicDisplayConfigById.HandleId = 0;
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0008CA45 File Offset: 0x0008AC45
		public static void Init()
		{
			ConfigComicDisplayConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigComicDisplayConfigById.HandleId, "db_comic.db", "select BinData from `ComicDisplayConfig` where Id=?");
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0008CA60 File Offset: 0x0008AC60
		public static ComicDisplayConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigComicDisplayConfigById.HandleId, ConfigComicDisplayConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ComicDisplayConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ComicDisplayConfig?(ComicDisplayConfig.GetRootAsComicDisplayConfig(configBuffer));
				}
			}
			ConfigComicDisplayConfigById.LogPair.Clear();
			ConfigComicDisplayConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigComicDisplayConfigById.HandleId, 1, p0Id, ConfigComicDisplayConfigById.LogPair) || ConfigCommon.Step(ConfigComicDisplayConfigById.HandleId, true, ConfigComicDisplayConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigComicDisplayConfigById.HandleId, ConfigComicDisplayConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigComicDisplayConfigById.HandleId, 0, ConfigComicDisplayConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigComicDisplayConfigById.HandleId, ConfigComicDisplayConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ComicDisplayConfig rootAsComicDisplayConfig = ComicDisplayConfig.GetRootAsComicDisplayConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ComicDisplayConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigComicDisplayConfigById.HandleId, ConfigComicDisplayConfigById.LogPair);
			return new ComicDisplayConfig?(rootAsComicDisplayConfig);
		}

		// Token: 0x04000A72 RID: 2674
		private const string DB = "db_comic.db";

		// Token: 0x04000A73 RID: 2675
		private const string FILE = "m.漫画.xlsx";

		// Token: 0x04000A74 RID: 2676
		private const string TABLE = "ComicDisplayConfig";

		// Token: 0x04000A75 RID: 2677
		private const string COMMAND = "select BinData from `ComicDisplayConfig` where Id=?";

		// Token: 0x04000A76 RID: 2678
		private const string KEY_PREFIX = "ComicDisplayConfigById";

		// Token: 0x04000A77 RID: 2679
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A78 RID: 2680
		private static int HandleId;
	}
}
