using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200081A RID: 2074
	public class ConfigRhythmTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030AE RID: 12462 RVA: 0x0016FECF File Offset: 0x0016E0CF
		static ConfigRhythmTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmTaskById.CreateStaticDefaultValue), new Action(ConfigRhythmTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x0016FEF0 File Offset: 0x0016E0F0
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmTask"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmTask` where Id=?")
			});
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x0016FF6F File Offset: 0x0016E16F
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmTaskById.LogPair = null;
			ConfigRhythmTaskById.HandleId = 0;
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x0016FF7D File Offset: 0x0016E17D
		public static void Init()
		{
			ConfigRhythmTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmTaskById.HandleId, "db_rhythmship.db", "select BinData from `RhythmTask` where Id=?");
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x0016FF98 File Offset: 0x0016E198
		public static RhythmTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmTaskById.HandleId, ConfigRhythmTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RhythmTask?(RhythmTask.GetRootAsRhythmTask(configBuffer));
				}
			}
			ConfigRhythmTaskById.LogPair.Clear();
			ConfigRhythmTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRhythmTaskById.HandleId, 1, p0Id, ConfigRhythmTaskById.LogPair) || ConfigCommon.Step(ConfigRhythmTaskById.HandleId, true, ConfigRhythmTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRhythmTaskById.HandleId, ConfigRhythmTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmTaskById.HandleId, 0, ConfigRhythmTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRhythmTaskById.HandleId, ConfigRhythmTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RhythmTask rootAsRhythmTask = RhythmTask.GetRootAsRhythmTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRhythmTaskById.HandleId, ConfigRhythmTaskById.LogPair);
			return new RhythmTask?(rootAsRhythmTask);
		}

		// Token: 0x0400389C RID: 14492
		private const string DB = "db_rhythmship.db";

		// Token: 0x0400389D RID: 14493
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x0400389E RID: 14494
		private const string TABLE = "RhythmTask";

		// Token: 0x0400389F RID: 14495
		private const string COMMAND = "select BinData from `RhythmTask` where Id=?";

		// Token: 0x040038A0 RID: 14496
		private const string KEY_PREFIX = "RhythmTaskById";

		// Token: 0x040038A1 RID: 14497
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038A2 RID: 14498
		private static int HandleId;
	}
}
