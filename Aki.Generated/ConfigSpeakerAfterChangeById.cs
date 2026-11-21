using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A3D RID: 2621
	public class ConfigSpeakerAfterChangeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D82 RID: 15746 RVA: 0x001B8493 File Offset: 0x001B6693
		static ConfigSpeakerAfterChangeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpeakerAfterChangeById.CreateStaticDefaultValue), new Action(ConfigSpeakerAfterChangeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x001B84B4 File Offset: 0x001B66B4
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

		// Token: 0x06003D84 RID: 15748 RVA: 0x001B8533 File Offset: 0x001B6733
		public static void ResetStaticDefaultValue()
		{
			ConfigSpeakerAfterChangeById.LogPair = null;
			ConfigSpeakerAfterChangeById.HandleId = 0;
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x001B8541 File Offset: 0x001B6741
		public static void Init()
		{
			ConfigSpeakerAfterChangeById.HandleId = ConfigCommon.InitDataStatement(ConfigSpeakerAfterChangeById.HandleId, "db_phonemsg.db", "select BinData from `SpeakerAfterChange` where Id=?");
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x001B855C File Offset: 0x001B675C
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

		// Token: 0x04004791 RID: 18321
		private const string DB = "db_phonemsg.db";

		// Token: 0x04004792 RID: 18322
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04004793 RID: 18323
		private const string TABLE = "SpeakerAfterChange";

		// Token: 0x04004794 RID: 18324
		private const string COMMAND = "select BinData from `SpeakerAfterChange` where Id=?";

		// Token: 0x04004795 RID: 18325
		private const string KEY_PREFIX = "SpeakerAfterChangeById";

		// Token: 0x04004796 RID: 18326
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004797 RID: 18327
		private static int HandleId;
	}
}
