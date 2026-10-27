using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200030E RID: 782
	public class ConfigFloroRanchAudioById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001259 RID: 4697 RVA: 0x000C1463 File Offset: 0x000BF663
		static ConfigFloroRanchAudioById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchAudioById.CreateStaticDefaultValue), new Action(ConfigFloroRanchAudioById.ResetStaticDefaultValue));
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x000C1484 File Offset: 0x000BF684
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchAudioById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchAudioById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchAudio"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchAudio` where Id=?")
			});
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x000C1503 File Offset: 0x000BF703
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchAudioById.LogPair = null;
			ConfigFloroRanchAudioById.HandleId = 0;
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x000C1511 File Offset: 0x000BF711
		public static void Init()
		{
			ConfigFloroRanchAudioById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchAudioById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchAudio` where Id=?");
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x000C152C File Offset: 0x000BF72C
		public static FloroRanchAudio? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchAudioById.HandleId, ConfigFloroRanchAudioById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchAudioById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchAudio?(FloroRanchAudio.GetRootAsFloroRanchAudio(configBuffer));
				}
			}
			ConfigFloroRanchAudioById.LogPair.Clear();
			ConfigFloroRanchAudioById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchAudioById.HandleId, 1, p0Id, ConfigFloroRanchAudioById.LogPair) || ConfigCommon.Step(ConfigFloroRanchAudioById.HandleId, true, ConfigFloroRanchAudioById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchAudioById.HandleId, ConfigFloroRanchAudioById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchAudioById.HandleId, 0, ConfigFloroRanchAudioById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchAudioById.HandleId, ConfigFloroRanchAudioById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchAudio rootAsFloroRanchAudio = FloroRanchAudio.GetRootAsFloroRanchAudio(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchAudioById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchAudioById.HandleId, ConfigFloroRanchAudioById.LogPair);
			return new FloroRanchAudio?(rootAsFloroRanchAudio);
		}

		// Token: 0x04001546 RID: 5446
		private const string DB = "db_flororanch.db";

		// Token: 0x04001547 RID: 5447
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001548 RID: 5448
		private const string TABLE = "FloroRanchAudio";

		// Token: 0x04001549 RID: 5449
		private const string COMMAND = "select BinData from `FloroRanchAudio` where Id=?";

		// Token: 0x0400154A RID: 5450
		private const string KEY_PREFIX = "FloroRanchAudioById";

		// Token: 0x0400154B RID: 5451
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400154C RID: 5452
		private static int HandleId;
	}
}
