using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A40 RID: 2624
	public class ConfigSpeakerChangeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D94 RID: 15764 RVA: 0x001B8AB7 File Offset: 0x001B6CB7
		static ConfigSpeakerChangeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpeakerChangeById.CreateStaticDefaultValue), new Action(ConfigSpeakerChangeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D95 RID: 15765 RVA: 0x001B8AD8 File Offset: 0x001B6CD8
		public static void CreateStaticDefaultValue()
		{
			ConfigSpeakerChangeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpeakerChangeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "SpeakerChange"),
				new ValueTuple<string, object>("语句", "select BinData from `SpeakerChange` where Id=?")
			});
		}

		// Token: 0x06003D96 RID: 15766 RVA: 0x001B8B57 File Offset: 0x001B6D57
		public static void ResetStaticDefaultValue()
		{
			ConfigSpeakerChangeById.LogPair = null;
			ConfigSpeakerChangeById.HandleId = 0;
		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x001B8B65 File Offset: 0x001B6D65
		public static void Init()
		{
			ConfigSpeakerChangeById.HandleId = ConfigCommon.InitDataStatement(ConfigSpeakerChangeById.HandleId, "db_phonemsg.db", "select BinData from `SpeakerChange` where Id=?");
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x001B8B80 File Offset: 0x001B6D80
		public static SpeakerChange? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpeakerChangeById.HandleId, ConfigSpeakerChangeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpeakerChangeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpeakerChange?(SpeakerChange.GetRootAsSpeakerChange(configBuffer));
				}
			}
			ConfigSpeakerChangeById.LogPair.Clear();
			ConfigSpeakerChangeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpeakerChangeById.HandleId, 1, p0Id, ConfigSpeakerChangeById.LogPair) || ConfigCommon.Step(ConfigSpeakerChangeById.HandleId, true, ConfigSpeakerChangeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpeakerChangeById.HandleId, ConfigSpeakerChangeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpeakerChangeById.HandleId, 0, ConfigSpeakerChangeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpeakerChangeById.HandleId, ConfigSpeakerChangeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpeakerChange rootAsSpeakerChange = SpeakerChange.GetRootAsSpeakerChange(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpeakerChangeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpeakerChangeById.HandleId, ConfigSpeakerChangeById.LogPair);
			return new SpeakerChange?(rootAsSpeakerChange);
		}

		// Token: 0x040047A6 RID: 18342
		private const string DB = "db_phonemsg.db";

		// Token: 0x040047A7 RID: 18343
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x040047A8 RID: 18344
		private const string TABLE = "SpeakerChange";

		// Token: 0x040047A9 RID: 18345
		private const string COMMAND = "select BinData from `SpeakerChange` where Id=?";

		// Token: 0x040047AA RID: 18346
		private const string KEY_PREFIX = "SpeakerChangeById";

		// Token: 0x040047AB RID: 18347
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047AC RID: 18348
		private static int HandleId;
	}
}
