using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000969 RID: 2409
	public class ConfigSpeakerById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600388A RID: 14474 RVA: 0x00199348 File Offset: 0x00197548
		static ConfigSpeakerById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpeakerById.CreateStaticDefaultValue), new Action(ConfigSpeakerById.ResetStaticDefaultValue));
		}

		// Token: 0x0600388B RID: 14475 RVA: 0x00199368 File Offset: 0x00197568
		public static void CreateStaticDefaultValue()
		{
			ConfigSpeakerById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpeakerById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_speaker.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/d.对话人/*.csv*"),
				new ValueTuple<string, object>("表名", "Speaker"),
				new ValueTuple<string, object>("语句", "select BinData from `Speaker` where Id=?")
			});
		}

		// Token: 0x0600388C RID: 14476 RVA: 0x001993E7 File Offset: 0x001975E7
		public static void ResetStaticDefaultValue()
		{
			ConfigSpeakerById.LogPair = null;
			ConfigSpeakerById.HandleId = 0;
		}

		// Token: 0x0600388D RID: 14477 RVA: 0x001993F5 File Offset: 0x001975F5
		public static void Init()
		{
			ConfigSpeakerById.HandleId = ConfigCommon.InitDataStatement(ConfigSpeakerById.HandleId, "db_speaker.db", "select BinData from `Speaker` where Id=?");
		}

		// Token: 0x0600388E RID: 14478 RVA: 0x00199410 File Offset: 0x00197610
		public static Speaker? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpeakerById.HandleId, ConfigSpeakerById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpeakerById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Speaker?(Speaker.GetRootAsSpeaker(configBuffer));
				}
			}
			ConfigSpeakerById.LogPair.Clear();
			ConfigSpeakerById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpeakerById.HandleId, 1, p0Id, ConfigSpeakerById.LogPair) || ConfigCommon.Step(ConfigSpeakerById.HandleId, true, ConfigSpeakerById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpeakerById.HandleId, ConfigSpeakerById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpeakerById.HandleId, 0, ConfigSpeakerById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpeakerById.HandleId, ConfigSpeakerById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Speaker rootAsSpeaker = Speaker.GetRootAsSpeaker(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpeakerById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpeakerById.HandleId, ConfigSpeakerById.LogPair);
			return new Speaker?(rootAsSpeaker);
		}

		// Token: 0x040041C5 RID: 16837
		private const string DB = "db_speaker.db";

		// Token: 0x040041C6 RID: 16838
		private const string FILE = "k.可视化编辑/c.Csv/d.对话人/*.csv*";

		// Token: 0x040041C7 RID: 16839
		private const string TABLE = "Speaker";

		// Token: 0x040041C8 RID: 16840
		private const string COMMAND = "select BinData from `Speaker` where Id=?";

		// Token: 0x040041C9 RID: 16841
		private const string KEY_PREFIX = "SpeakerById";

		// Token: 0x040041CA RID: 16842
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041CB RID: 16843
		private static int HandleId;
	}
}
