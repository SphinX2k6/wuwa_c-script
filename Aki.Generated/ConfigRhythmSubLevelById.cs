using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007FA RID: 2042
	public class ConfigRhythmSubLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FEE RID: 12270 RVA: 0x00168247 File Offset: 0x00166447
		static ConfigRhythmSubLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmSubLevelById.CreateStaticDefaultValue), new Action(ConfigRhythmSubLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x00168268 File Offset: 0x00166468
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmSubLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmSubLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmSubLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmSubLevel` where Id=?")
			});
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x001682E7 File Offset: 0x001664E7
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmSubLevelById.LogPair = null;
			ConfigRhythmSubLevelById.HandleId = 0;
		}

		// Token: 0x06002FF1 RID: 12273 RVA: 0x001682F5 File Offset: 0x001664F5
		public static void Init()
		{
			ConfigRhythmSubLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmSubLevelById.HandleId, "db_rhythmship.db", "select BinData from `RhythmSubLevel` where Id=?");
		}

		// Token: 0x06002FF2 RID: 12274 RVA: 0x00168310 File Offset: 0x00166510
		public static RhythmSubLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmSubLevelById.HandleId, ConfigRhythmSubLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmSubLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RhythmSubLevel?(RhythmSubLevel.GetRootAsRhythmSubLevel(configBuffer));
				}
			}
			ConfigRhythmSubLevelById.LogPair.Clear();
			ConfigRhythmSubLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRhythmSubLevelById.HandleId, 1, p0Id, ConfigRhythmSubLevelById.LogPair) || ConfigCommon.Step(ConfigRhythmSubLevelById.HandleId, true, ConfigRhythmSubLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRhythmSubLevelById.HandleId, ConfigRhythmSubLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmSubLevelById.HandleId, 0, ConfigRhythmSubLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRhythmSubLevelById.HandleId, ConfigRhythmSubLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RhythmSubLevel rootAsRhythmSubLevel = RhythmSubLevel.GetRootAsRhythmSubLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmSubLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRhythmSubLevelById.HandleId, ConfigRhythmSubLevelById.LogPair);
			return new RhythmSubLevel?(rootAsRhythmSubLevel);
		}

		// Token: 0x040037BC RID: 14268
		private const string DB = "db_rhythmship.db";

		// Token: 0x040037BD RID: 14269
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x040037BE RID: 14270
		private const string TABLE = "RhythmSubLevel";

		// Token: 0x040037BF RID: 14271
		private const string COMMAND = "select BinData from `RhythmSubLevel` where Id=?";

		// Token: 0x040037C0 RID: 14272
		private const string KEY_PREFIX = "RhythmSubLevelById";

		// Token: 0x040037C1 RID: 14273
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037C2 RID: 14274
		private static int HandleId;
	}
}
