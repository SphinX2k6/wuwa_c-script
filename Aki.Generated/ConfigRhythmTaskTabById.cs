using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007FF RID: 2047
	public class ConfigRhythmTaskTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600300C RID: 12300 RVA: 0x00168E30 File Offset: 0x00167030
		static ConfigRhythmTaskTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmTaskTabById.CreateStaticDefaultValue), new Action(ConfigRhythmTaskTabById.ResetStaticDefaultValue));
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x00168E50 File Offset: 0x00167050
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmTaskTabById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmTaskTabById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmTaskTab"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmTaskTab` where Id=?")
			});
		}

		// Token: 0x0600300E RID: 12302 RVA: 0x00168ECF File Offset: 0x001670CF
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmTaskTabById.LogPair = null;
			ConfigRhythmTaskTabById.HandleId = 0;
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x00168EDD File Offset: 0x001670DD
		public static void Init()
		{
			ConfigRhythmTaskTabById.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmTaskTabById.HandleId, "db_rhythmship.db", "select BinData from `RhythmTaskTab` where Id=?");
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x00168EF8 File Offset: 0x001670F8
		public static RhythmTaskTab? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmTaskTabById.HandleId, ConfigRhythmTaskTabById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmTaskTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RhythmTaskTab?(RhythmTaskTab.GetRootAsRhythmTaskTab(configBuffer));
				}
			}
			ConfigRhythmTaskTabById.LogPair.Clear();
			ConfigRhythmTaskTabById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRhythmTaskTabById.HandleId, 1, p0Id, ConfigRhythmTaskTabById.LogPair) || ConfigCommon.Step(ConfigRhythmTaskTabById.HandleId, true, ConfigRhythmTaskTabById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRhythmTaskTabById.HandleId, ConfigRhythmTaskTabById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmTaskTabById.HandleId, 0, ConfigRhythmTaskTabById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRhythmTaskTabById.HandleId, ConfigRhythmTaskTabById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RhythmTaskTab rootAsRhythmTaskTab = RhythmTaskTab.GetRootAsRhythmTaskTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmTaskTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRhythmTaskTabById.HandleId, ConfigRhythmTaskTabById.LogPair);
			return new RhythmTaskTab?(rootAsRhythmTaskTab);
		}

		// Token: 0x040037DF RID: 14303
		private const string DB = "db_rhythmship.db";

		// Token: 0x040037E0 RID: 14304
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x040037E1 RID: 14305
		private const string TABLE = "RhythmTaskTab";

		// Token: 0x040037E2 RID: 14306
		private const string COMMAND = "select BinData from `RhythmTaskTab` where Id=?";

		// Token: 0x040037E3 RID: 14307
		private const string KEY_PREFIX = "RhythmTaskTabById";

		// Token: 0x040037E4 RID: 14308
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037E5 RID: 14309
		private static int HandleId;
	}
}
