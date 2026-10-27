using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000140 RID: 320
	public class ConfigCharacterAudioConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000781 RID: 1921 RVA: 0x000840BB File Offset: 0x000822BB
		static ConfigCharacterAudioConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCharacterAudioConfigById.CreateStaticDefaultValue), new Action(ConfigCharacterAudioConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x000840DC File Offset: 0x000822DC
		public static void CreateStaticDefaultValue()
		{
			ConfigCharacterAudioConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCharacterAudioConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_entity_audio.db"),
				new ValueTuple<string, object>("文件", "y.音频组件配置.xlsx"),
				new ValueTuple<string, object>("表名", "CharacterAudioConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `CharacterAudioConfig` where Id=?")
			});
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0008415B File Offset: 0x0008235B
		public static void ResetStaticDefaultValue()
		{
			ConfigCharacterAudioConfigById.LogPair = null;
			ConfigCharacterAudioConfigById.HandleId = 0;
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00084169 File Offset: 0x00082369
		public static void Init()
		{
			ConfigCharacterAudioConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigCharacterAudioConfigById.HandleId, "db_entity_audio.db", "select BinData from `CharacterAudioConfig` where Id=?");
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00084184 File Offset: 0x00082384
		public static CharacterAudioConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCharacterAudioConfigById.HandleId, ConfigCharacterAudioConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CharacterAudioConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CharacterAudioConfig?(CharacterAudioConfig.GetRootAsCharacterAudioConfig(configBuffer));
				}
			}
			ConfigCharacterAudioConfigById.LogPair.Clear();
			ConfigCharacterAudioConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCharacterAudioConfigById.HandleId, 1, p0Id, ConfigCharacterAudioConfigById.LogPair) || ConfigCommon.Step(ConfigCharacterAudioConfigById.HandleId, true, ConfigCharacterAudioConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCharacterAudioConfigById.HandleId, ConfigCharacterAudioConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCharacterAudioConfigById.HandleId, 0, ConfigCharacterAudioConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCharacterAudioConfigById.HandleId, ConfigCharacterAudioConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CharacterAudioConfig rootAsCharacterAudioConfig = CharacterAudioConfig.GetRootAsCharacterAudioConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CharacterAudioConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCharacterAudioConfigById.HandleId, ConfigCharacterAudioConfigById.LogPair);
			return new CharacterAudioConfig?(rootAsCharacterAudioConfig);
		}

		// Token: 0x040008A4 RID: 2212
		private const string DB = "db_entity_audio.db";

		// Token: 0x040008A5 RID: 2213
		private const string FILE = "y.音频组件配置.xlsx";

		// Token: 0x040008A6 RID: 2214
		private const string TABLE = "CharacterAudioConfig";

		// Token: 0x040008A7 RID: 2215
		private const string COMMAND = "select BinData from `CharacterAudioConfig` where Id=?";

		// Token: 0x040008A8 RID: 2216
		private const string KEY_PREFIX = "CharacterAudioConfigById";

		// Token: 0x040008A9 RID: 2217
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008AA RID: 2218
		private static int HandleId;
	}
}
