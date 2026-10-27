using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200096B RID: 2411
	public class ConfigSpeakerChangeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003896 RID: 14486 RVA: 0x00199723 File Offset: 0x00197923
		static ConfigSpeakerChangeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpeakerChangeById.CreateStaticDefaultValue), new Action(ConfigSpeakerChangeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003897 RID: 14487 RVA: 0x00199744 File Offset: 0x00197944
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

		// Token: 0x06003898 RID: 14488 RVA: 0x001997C3 File Offset: 0x001979C3
		public static void ResetStaticDefaultValue()
		{
			ConfigSpeakerChangeById.LogPair = null;
			ConfigSpeakerChangeById.HandleId = 0;
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x001997D1 File Offset: 0x001979D1
		public static void Init()
		{
			ConfigSpeakerChangeById.HandleId = ConfigCommon.InitDataStatement(ConfigSpeakerChangeById.HandleId, "db_phonemsg.db", "select BinData from `SpeakerChange` where Id=?");
		}

		// Token: 0x0600389A RID: 14490 RVA: 0x001997EC File Offset: 0x001979EC
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

		// Token: 0x040041D3 RID: 16851
		private const string DB = "db_phonemsg.db";

		// Token: 0x040041D4 RID: 16852
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x040041D5 RID: 16853
		private const string TABLE = "SpeakerChange";

		// Token: 0x040041D6 RID: 16854
		private const string COMMAND = "select BinData from `SpeakerChange` where Id=?";

		// Token: 0x040041D7 RID: 16855
		private const string KEY_PREFIX = "SpeakerChangeById";

		// Token: 0x040041D8 RID: 16856
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041D9 RID: 16857
		private static int HandleId;
	}
}
