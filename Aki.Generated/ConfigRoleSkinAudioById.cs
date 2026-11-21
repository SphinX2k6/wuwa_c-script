using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008E0 RID: 2272
	public class ConfigRoleSkinAudioById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003553 RID: 13651 RVA: 0x0018A21B File Offset: 0x0018841B
		static ConfigRoleSkinAudioById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinAudioById.CreateStaticDefaultValue), new Action(ConfigRoleSkinAudioById.ResetStaticDefaultValue));
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x0018A23C File Offset: 0x0018843C
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

		// Token: 0x06003555 RID: 13653 RVA: 0x0018A2BB File Offset: 0x001884BB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinAudioById.LogPair = null;
			ConfigRoleSkinAudioById.HandleId = 0;
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x0018A2C9 File Offset: 0x001884C9
		public static void Init()
		{
			ConfigRoleSkinAudioById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinAudioById.HandleId, "db_audio.db", "select BinData from `RoleSkinAudio` where Id=?");
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x0018A2E4 File Offset: 0x001884E4
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

		// Token: 0x04003E06 RID: 15878
		private const string DB = "db_audio.db";

		// Token: 0x04003E07 RID: 15879
		private const string FILE = "y.音频_角色音频.xlsx";

		// Token: 0x04003E08 RID: 15880
		private const string TABLE = "RoleSkinAudio";

		// Token: 0x04003E09 RID: 15881
		private const string COMMAND = "select BinData from `RoleSkinAudio` where Id=?";

		// Token: 0x04003E0A RID: 15882
		private const string KEY_PREFIX = "RoleSkinAudioById";

		// Token: 0x04003E0B RID: 15883
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E0C RID: 15884
		private static int HandleId;
	}
}
