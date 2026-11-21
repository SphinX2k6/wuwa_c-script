using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A3E RID: 2622
	public class ConfigSpeakerById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D88 RID: 15752 RVA: 0x001B86DC File Offset: 0x001B68DC
		static ConfigSpeakerById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpeakerById.CreateStaticDefaultValue), new Action(ConfigSpeakerById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D89 RID: 15753 RVA: 0x001B86FC File Offset: 0x001B68FC
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

		// Token: 0x06003D8A RID: 15754 RVA: 0x001B877B File Offset: 0x001B697B
		public static void ResetStaticDefaultValue()
		{
			ConfigSpeakerById.LogPair = null;
			ConfigSpeakerById.HandleId = 0;
		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x001B8789 File Offset: 0x001B6989
		public static void Init()
		{
			ConfigSpeakerById.HandleId = ConfigCommon.InitDataStatement(ConfigSpeakerById.HandleId, "db_speaker.db", "select BinData from `Speaker` where Id=?");
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x001B87A4 File Offset: 0x001B69A4
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

		// Token: 0x04004798 RID: 18328
		private const string DB = "db_speaker.db";

		// Token: 0x04004799 RID: 18329
		private const string FILE = "k.可视化编辑/c.Csv/d.对话人/*.csv*";

		// Token: 0x0400479A RID: 18330
		private const string TABLE = "Speaker";

		// Token: 0x0400479B RID: 18331
		private const string COMMAND = "select BinData from `Speaker` where Id=?";

		// Token: 0x0400479C RID: 18332
		private const string KEY_PREFIX = "SpeakerById";

		// Token: 0x0400479D RID: 18333
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400479E RID: 18334
		private static int HandleId;
	}
}
