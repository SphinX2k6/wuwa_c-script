using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002B5 RID: 693
	public class ConfigFavorLevelByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001043 RID: 4163 RVA: 0x000B55AB File Offset: 0x000B37AB
		static ConfigFavorLevelByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFavorLevelByLevel.CreateStaticDefaultValue), new Action(ConfigFavorLevelByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x000B55CC File Offset: 0x000B37CC
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

		// Token: 0x06001045 RID: 4165 RVA: 0x000B564B File Offset: 0x000B384B
		public static void ResetStaticDefaultValue()
		{
			ConfigFavorLevelByLevel.LogPair = null;
			ConfigFavorLevelByLevel.HandleId = 0;
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x000B5659 File Offset: 0x000B3859
		public static void Init()
		{
			ConfigFavorLevelByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigFavorLevelByLevel.HandleId, "db_favor.db", "select BinData from `FavorLevel` where Level=?");
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x000B5674 File Offset: 0x000B3874
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

		// Token: 0x040012D7 RID: 4823
		private const string DB = "db_favor.db";

		// Token: 0x040012D8 RID: 4824
		private const string FILE = "h.好感度.xlsx";

		// Token: 0x040012D9 RID: 4825
		private const string TABLE = "FavorLevel";

		// Token: 0x040012DA RID: 4826
		private const string COMMAND = "select BinData from `FavorLevel` where Level=?";

		// Token: 0x040012DB RID: 4827
		private const string KEY_PREFIX = "FavorLevelByLevel";

		// Token: 0x040012DC RID: 4828
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012DD RID: 4829
		private static int HandleId;
	}
}
