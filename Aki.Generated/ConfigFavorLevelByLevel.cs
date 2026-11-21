using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002CA RID: 714
	public class ConfigFavorLevelByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010C1 RID: 4289 RVA: 0x000BBAB7 File Offset: 0x000B9CB7
		static ConfigFavorLevelByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFavorLevelByLevel.CreateStaticDefaultValue), new Action(ConfigFavorLevelByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x000BBAD8 File Offset: 0x000B9CD8
		public static void CreateStaticDefaultValue()
		{
			ConfigFavorLevelByLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFavorLevelByLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_favor.db"),
				new ValueTuple<string, object>("文件", "h.好感度.xlsx"),
				new ValueTuple<string, object>("表名", "FavorLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `FavorLevel` where Level=?")
			});
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x000BBB57 File Offset: 0x000B9D57
		public static void ResetStaticDefaultValue()
		{
			ConfigFavorLevelByLevel.LogPair = null;
			ConfigFavorLevelByLevel.HandleId = 0;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x000BBB65 File Offset: 0x000B9D65
		public static void Init()
		{
			ConfigFavorLevelByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigFavorLevelByLevel.HandleId, "db_favor.db", "select BinData from `FavorLevel` where Level=?");
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x000BBB80 File Offset: 0x000B9D80
		public static FavorLevel? GetConfig(int p0Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFavorLevelByLevel.HandleId, ConfigFavorLevelByLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FavorLevelByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FavorLevel?(FavorLevel.GetRootAsFavorLevel(configBuffer));
				}
			}
			ConfigFavorLevelByLevel.LogPair.Clear();
			ConfigFavorLevelByLevel.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			if (!ConfigCommon.BindInt(ConfigFavorLevelByLevel.HandleId, 1, p0Level, ConfigFavorLevelByLevel.LogPair) || ConfigCommon.Step(ConfigFavorLevelByLevel.HandleId, true, ConfigFavorLevelByLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFavorLevelByLevel.HandleId, ConfigFavorLevelByLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFavorLevelByLevel.HandleId, 0, ConfigFavorLevelByLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFavorLevelByLevel.HandleId, ConfigFavorLevelByLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FavorLevel rootAsFavorLevel = FavorLevel.GetRootAsFavorLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FavorLevelByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFavorLevelByLevel.HandleId, ConfigFavorLevelByLevel.LogPair);
			return new FavorLevel?(rootAsFavorLevel);
		}

		// Token: 0x0400136A RID: 4970
		private const string DB = "db_favor.db";

		// Token: 0x0400136B RID: 4971
		private const string FILE = "h.好感度.xlsx";

		// Token: 0x0400136C RID: 4972
		private const string TABLE = "FavorLevel";

		// Token: 0x0400136D RID: 4973
		private const string COMMAND = "select BinData from `FavorLevel` where Level=?";

		// Token: 0x0400136E RID: 4974
		private const string KEY_PREFIX = "FavorLevelByLevel";

		// Token: 0x0400136F RID: 4975
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001370 RID: 4976
		private static int HandleId;
	}
}
