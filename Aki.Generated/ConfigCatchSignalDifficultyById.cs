using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200013D RID: 317
	public class ConfigCatchSignalDifficultyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600076F RID: 1903 RVA: 0x00083AE8 File Offset: 0x00081CE8
		static ConfigCatchSignalDifficultyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCatchSignalDifficultyById.CreateStaticDefaultValue), new Action(ConfigCatchSignalDifficultyById.ResetStaticDefaultValue));
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00083B08 File Offset: 0x00081D08
		public static void CreateStaticDefaultValue()
		{
			ConfigCatchSignalDifficultyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCatchSignalDifficultyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_catchsignaldifficulty.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/m.捕获信号玩法难度/*.csv*"),
				new ValueTuple<string, object>("表名", "CatchSignalDifficulty"),
				new ValueTuple<string, object>("语句", "select BinData from `CatchSignalDifficulty` where Id=?")
			});
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00083B87 File Offset: 0x00081D87
		public static void ResetStaticDefaultValue()
		{
			ConfigCatchSignalDifficultyById.LogPair = null;
			ConfigCatchSignalDifficultyById.HandleId = 0;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00083B95 File Offset: 0x00081D95
		public static void Init()
		{
			ConfigCatchSignalDifficultyById.HandleId = ConfigCommon.InitDataStatement(ConfigCatchSignalDifficultyById.HandleId, "db_catchsignaldifficulty.db", "select BinData from `CatchSignalDifficulty` where Id=?");
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00083BB0 File Offset: 0x00081DB0
		public static CatchSignalDifficulty? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCatchSignalDifficultyById.HandleId, ConfigCatchSignalDifficultyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CatchSignalDifficultyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CatchSignalDifficulty?(CatchSignalDifficulty.GetRootAsCatchSignalDifficulty(configBuffer));
				}
			}
			ConfigCatchSignalDifficultyById.LogPair.Clear();
			ConfigCatchSignalDifficultyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCatchSignalDifficultyById.HandleId, 1, p0Id, ConfigCatchSignalDifficultyById.LogPair) || ConfigCommon.Step(ConfigCatchSignalDifficultyById.HandleId, true, ConfigCatchSignalDifficultyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCatchSignalDifficultyById.HandleId, ConfigCatchSignalDifficultyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCatchSignalDifficultyById.HandleId, 0, ConfigCatchSignalDifficultyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCatchSignalDifficultyById.HandleId, ConfigCatchSignalDifficultyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CatchSignalDifficulty rootAsCatchSignalDifficulty = CatchSignalDifficulty.GetRootAsCatchSignalDifficulty(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CatchSignalDifficultyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCatchSignalDifficultyById.HandleId, ConfigCatchSignalDifficultyById.LogPair);
			return new CatchSignalDifficulty?(rootAsCatchSignalDifficulty);
		}

		// Token: 0x0400088F RID: 2191
		private const string DB = "db_catchsignaldifficulty.db";

		// Token: 0x04000890 RID: 2192
		private const string FILE = "k.可视化编辑/c.Csv/m.捕获信号玩法难度/*.csv*";

		// Token: 0x04000891 RID: 2193
		private const string TABLE = "CatchSignalDifficulty";

		// Token: 0x04000892 RID: 2194
		private const string COMMAND = "select BinData from `CatchSignalDifficulty` where Id=?";

		// Token: 0x04000893 RID: 2195
		private const string KEY_PREFIX = "CatchSignalDifficultyById";

		// Token: 0x04000894 RID: 2196
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000895 RID: 2197
		private static int HandleId;
	}
}
