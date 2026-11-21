using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000194 RID: 404
	public class ConfigComicDisplayConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000979 RID: 2425 RVA: 0x000928D0 File Offset: 0x00090AD0
		static ConfigComicDisplayConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigComicDisplayConfigById.CreateStaticDefaultValue), new Action(ConfigComicDisplayConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x000928F0 File Offset: 0x00090AF0
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

		// Token: 0x0600097B RID: 2427 RVA: 0x0009296F File Offset: 0x00090B6F
		public static void ResetStaticDefaultValue()
		{
			ConfigComicDisplayConfigById.LogPair = null;
			ConfigComicDisplayConfigById.HandleId = 0;
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0009297D File Offset: 0x00090B7D
		public static void Init()
		{
			ConfigComicDisplayConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigComicDisplayConfigById.HandleId, "db_comic.db", "select BinData from `ComicDisplayConfig` where Id=?");
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00092998 File Offset: 0x00090B98
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

		// Token: 0x04000AF0 RID: 2800
		private const string DB = "db_comic.db";

		// Token: 0x04000AF1 RID: 2801
		private const string FILE = "m.漫画.xlsx";

		// Token: 0x04000AF2 RID: 2802
		private const string TABLE = "ComicDisplayConfig";

		// Token: 0x04000AF3 RID: 2803
		private const string COMMAND = "select BinData from `ComicDisplayConfig` where Id=?";

		// Token: 0x04000AF4 RID: 2804
		private const string KEY_PREFIX = "ComicDisplayConfigById";

		// Token: 0x04000AF5 RID: 2805
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000AF6 RID: 2806
		private static int HandleId;
	}
}
