using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000968 RID: 2408
	public class ConfigSpeakerAfterChangeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003884 RID: 14468 RVA: 0x001990FF File Offset: 0x001972FF
		static ConfigSpeakerAfterChangeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpeakerAfterChangeById.CreateStaticDefaultValue), new Action(ConfigSpeakerAfterChangeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003885 RID: 14469 RVA: 0x00199120 File Offset: 0x00197320
		public static void CreateStaticDefaultValue()
		{
			ConfigSpeakerAfterChangeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpeakerAfterChangeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "SpeakerAfterChange"),
				new ValueTuple<string, object>("语句", "select BinData from `SpeakerAfterChange` where Id=?")
			});
		}

		// Token: 0x06003886 RID: 14470 RVA: 0x0019919F File Offset: 0x0019739F
		public static void ResetStaticDefaultValue()
		{
			ConfigSpeakerAfterChangeById.LogPair = null;
			ConfigSpeakerAfterChangeById.HandleId = 0;
		}

		// Token: 0x06003887 RID: 14471 RVA: 0x001991AD File Offset: 0x001973AD
		public static void Init()
		{
			ConfigSpeakerAfterChangeById.HandleId = ConfigCommon.InitDataStatement(ConfigSpeakerAfterChangeById.HandleId, "db_phonemsg.db", "select BinData from `SpeakerAfterChange` where Id=?");
		}

		// Token: 0x06003888 RID: 14472 RVA: 0x001991C8 File Offset: 0x001973C8
		public static SpeakerAfterChange? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpeakerAfterChangeById.HandleId, ConfigSpeakerAfterChangeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpeakerAfterChangeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpeakerAfterChange?(SpeakerAfterChange.GetRootAsSpeakerAfterChange(configBuffer));
				}
			}
			ConfigSpeakerAfterChangeById.LogPair.Clear();
			ConfigSpeakerAfterChangeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpeakerAfterChangeById.HandleId, 1, p0Id, ConfigSpeakerAfterChangeById.LogPair) || ConfigCommon.Step(ConfigSpeakerAfterChangeById.HandleId, true, ConfigSpeakerAfterChangeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpeakerAfterChangeById.HandleId, ConfigSpeakerAfterChangeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpeakerAfterChangeById.HandleId, 0, ConfigSpeakerAfterChangeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpeakerAfterChangeById.HandleId, ConfigSpeakerAfterChangeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpeakerAfterChange rootAsSpeakerAfterChange = SpeakerAfterChange.GetRootAsSpeakerAfterChange(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpeakerAfterChangeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpeakerAfterChangeById.HandleId, ConfigSpeakerAfterChangeById.LogPair);
			return new SpeakerAfterChange?(rootAsSpeakerAfterChange);
		}

		// Token: 0x040041BE RID: 16830
		private const string DB = "db_phonemsg.db";

		// Token: 0x040041BF RID: 16831
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x040041C0 RID: 16832
		private const string TABLE = "SpeakerAfterChange";

		// Token: 0x040041C1 RID: 16833
		private const string COMMAND = "select BinData from `SpeakerAfterChange` where Id=?";

		// Token: 0x040041C2 RID: 16834
		private const string KEY_PREFIX = "SpeakerAfterChangeById";

		// Token: 0x040041C3 RID: 16835
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041C4 RID: 16836
		private static int HandleId;
	}
}
