using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200014C RID: 332
	public class ConfigCatchSignalDifficultyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007C9 RID: 1993 RVA: 0x0008944C File Offset: 0x0008764C
		static ConfigCatchSignalDifficultyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCatchSignalDifficultyById.CreateStaticDefaultValue), new Action(ConfigCatchSignalDifficultyById.ResetStaticDefaultValue));
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0008946C File Offset: 0x0008766C
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

		// Token: 0x060007CB RID: 1995 RVA: 0x000894EB File Offset: 0x000876EB
		public static void ResetStaticDefaultValue()
		{
			ConfigCatchSignalDifficultyById.LogPair = null;
			ConfigCatchSignalDifficultyById.HandleId = 0;
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x000894F9 File Offset: 0x000876F9
		public static void Init()
		{
			ConfigCatchSignalDifficultyById.HandleId = ConfigCommon.InitDataStatement(ConfigCatchSignalDifficultyById.HandleId, "db_catchsignaldifficulty.db", "select BinData from `CatchSignalDifficulty` where Id=?");
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00089514 File Offset: 0x00087714
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

		// Token: 0x040008F8 RID: 2296
		private const string DB = "db_catchsignaldifficulty.db";

		// Token: 0x040008F9 RID: 2297
		private const string FILE = "k.可视化编辑/c.Csv/m.捕获信号玩法难度/*.csv*";

		// Token: 0x040008FA RID: 2298
		private const string TABLE = "CatchSignalDifficulty";

		// Token: 0x040008FB RID: 2299
		private const string COMMAND = "select BinData from `CatchSignalDifficulty` where Id=?";

		// Token: 0x040008FC RID: 2300
		private const string KEY_PREFIX = "CatchSignalDifficultyById";

		// Token: 0x040008FD RID: 2301
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008FE RID: 2302
		private static int HandleId;
	}
}
