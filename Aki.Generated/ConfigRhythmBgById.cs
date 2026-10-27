using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007EE RID: 2030
	public class ConfigRhythmBgById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FA6 RID: 12198 RVA: 0x001669D8 File Offset: 0x00164BD8
		static ConfigRhythmBgById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmBgById.CreateStaticDefaultValue), new Action(ConfigRhythmBgById.ResetStaticDefaultValue));
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x001669F8 File Offset: 0x00164BF8
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

		// Token: 0x06002FA8 RID: 12200 RVA: 0x00166A77 File Offset: 0x00164C77
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmBgById.LogPair = null;
			ConfigRhythmBgById.HandleId = 0;
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x00166A85 File Offset: 0x00164C85
		public static void Init()
		{
			ConfigRhythmBgById.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmBgById.HandleId, "db_rhythmship.db", "select BinData from `RhythmBg` where Id=?");
		}

		// Token: 0x06002FAA RID: 12202 RVA: 0x00166AA0 File Offset: 0x00164CA0
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

		// Token: 0x04003768 RID: 14184
		private const string DB = "db_rhythmship.db";

		// Token: 0x04003769 RID: 14185
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x0400376A RID: 14186
		private const string TABLE = "RhythmBg";

		// Token: 0x0400376B RID: 14187
		private const string COMMAND = "select BinData from `RhythmBg` where Id=?";

		// Token: 0x0400376C RID: 14188
		private const string KEY_PREFIX = "RhythmBgById";

		// Token: 0x0400376D RID: 14189
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400376E RID: 14190
		private static int HandleId;
	}
}
