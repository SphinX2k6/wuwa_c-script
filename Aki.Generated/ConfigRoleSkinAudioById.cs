using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008C4 RID: 2244
	public class ConfigRoleSkinAudioById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034AB RID: 13483 RVA: 0x00182F33 File Offset: 0x00181133
		static ConfigRoleSkinAudioById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinAudioById.CreateStaticDefaultValue), new Action(ConfigRoleSkinAudioById.ResetStaticDefaultValue));
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x00182F54 File Offset: 0x00181154
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleSkinAudioById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleSkinAudioById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_audio.db"),
				new ValueTuple<string, object>("文件", "y.音频_角色音频.xlsx"),
				new ValueTuple<string, object>("表名", "RoleSkinAudio"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleSkinAudio` where Id=?")
			});
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x00182FD3 File Offset: 0x001811D3
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinAudioById.LogPair = null;
			ConfigRoleSkinAudioById.HandleId = 0;
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x00182FE1 File Offset: 0x001811E1
		public static void Init()
		{
			ConfigRoleSkinAudioById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinAudioById.HandleId, "db_audio.db", "select BinData from `RoleSkinAudio` where Id=?");
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x00182FFC File Offset: 0x001811FC
		public static RoleSkinAudio? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleSkinAudioById.HandleId, ConfigRoleSkinAudioById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinAudioById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleSkinAudio?(RoleSkinAudio.GetRootAsRoleSkinAudio(configBuffer));
				}
			}
			ConfigRoleSkinAudioById.LogPair.Clear();
			ConfigRoleSkinAudioById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleSkinAudioById.HandleId, 1, p0Id, ConfigRoleSkinAudioById.LogPair) || ConfigCommon.Step(ConfigRoleSkinAudioById.HandleId, true, ConfigRoleSkinAudioById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleSkinAudioById.HandleId, ConfigRoleSkinAudioById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleSkinAudioById.HandleId, 0, ConfigRoleSkinAudioById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleSkinAudioById.HandleId, ConfigRoleSkinAudioById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleSkinAudio rootAsRoleSkinAudio = RoleSkinAudio.GetRootAsRoleSkinAudio(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinAudioById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleSkinAudioById.HandleId, ConfigRoleSkinAudioById.LogPair);
			return new RoleSkinAudio?(rootAsRoleSkinAudio);
		}

		// Token: 0x04003D42 RID: 15682
		private const string DB = "db_audio.db";

		// Token: 0x04003D43 RID: 15683
		private const string FILE = "y.音频_角色音频.xlsx";

		// Token: 0x04003D44 RID: 15684
		private const string TABLE = "RoleSkinAudio";

		// Token: 0x04003D45 RID: 15685
		private const string COMMAND = "select BinData from `RoleSkinAudio` where Id=?";

		// Token: 0x04003D46 RID: 15686
		private const string KEY_PREFIX = "RoleSkinAudioById";

		// Token: 0x04003D47 RID: 15687
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D48 RID: 15688
		private static int HandleId;
	}
}
