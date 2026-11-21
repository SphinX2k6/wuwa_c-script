using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200080A RID: 2058
	public class ConfigRhythmBgById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600304E RID: 12366 RVA: 0x0016DCC0 File Offset: 0x0016BEC0
		static ConfigRhythmBgById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmBgById.CreateStaticDefaultValue), new Action(ConfigRhythmBgById.ResetStaticDefaultValue));
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x0016DCE0 File Offset: 0x0016BEE0
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmBgById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmBgById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmBg"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmBg` where Id=?")
			});
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x0016DD5F File Offset: 0x0016BF5F
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmBgById.LogPair = null;
			ConfigRhythmBgById.HandleId = 0;
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x0016DD6D File Offset: 0x0016BF6D
		public static void Init()
		{
			ConfigRhythmBgById.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmBgById.HandleId, "db_rhythmship.db", "select BinData from `RhythmBg` where Id=?");
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x0016DD88 File Offset: 0x0016BF88
		public static RhythmBg? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmBgById.HandleId, ConfigRhythmBgById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmBgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RhythmBg?(RhythmBg.GetRootAsRhythmBg(configBuffer));
				}
			}
			ConfigRhythmBgById.LogPair.Clear();
			ConfigRhythmBgById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRhythmBgById.HandleId, 1, p0Id, ConfigRhythmBgById.LogPair) || ConfigCommon.Step(ConfigRhythmBgById.HandleId, true, ConfigRhythmBgById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRhythmBgById.HandleId, ConfigRhythmBgById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmBgById.HandleId, 0, ConfigRhythmBgById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRhythmBgById.HandleId, ConfigRhythmBgById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RhythmBg rootAsRhythmBg = RhythmBg.GetRootAsRhythmBg(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmBgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRhythmBgById.HandleId, ConfigRhythmBgById.LogPair);
			return new RhythmBg?(rootAsRhythmBg);
		}

		// Token: 0x0400382C RID: 14380
		private const string DB = "db_rhythmship.db";

		// Token: 0x0400382D RID: 14381
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x0400382E RID: 14382
		private const string TABLE = "RhythmBg";

		// Token: 0x0400382F RID: 14383
		private const string COMMAND = "select BinData from `RhythmBg` where Id=?";

		// Token: 0x04003830 RID: 14384
		private const string KEY_PREFIX = "RhythmBgById";

		// Token: 0x04003831 RID: 14385
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003832 RID: 14386
		private static int HandleId;
	}
}
