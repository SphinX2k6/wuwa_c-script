using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000150 RID: 336
	public class ConfigCharacterAudioConfigByIdWithDefaultId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007E1 RID: 2017 RVA: 0x00089C68 File Offset: 0x00087E68
		static ConfigCharacterAudioConfigByIdWithDefaultId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCharacterAudioConfigByIdWithDefaultId.CreateStaticDefaultValue), new Action(ConfigCharacterAudioConfigByIdWithDefaultId.ResetStaticDefaultValue));
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00089C88 File Offset: 0x00087E88
		public static void CreateStaticDefaultValue()
		{
			ConfigCharacterAudioConfigByIdWithDefaultId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCharacterAudioConfigByIdWithDefaultId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_entity_audio.db"),
				new ValueTuple<string, object>("文件", "y.音频组件配置.xlsx"),
				new ValueTuple<string, object>("表名", "CharacterAudioConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `CharacterAudioConfig` where id = ? AND (SELECT count(0) from `CharacterAudioConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `CharacterAudioConfig` WHERE id = ?) >0;")
			});
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00089D07 File Offset: 0x00087F07
		public static void ResetStaticDefaultValue()
		{
			ConfigCharacterAudioConfigByIdWithDefaultId.LogPair = null;
			ConfigCharacterAudioConfigByIdWithDefaultId.HandleId = 0;
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00089D15 File Offset: 0x00087F15
		public static void Init()
		{
			ConfigCharacterAudioConfigByIdWithDefaultId.HandleId = ConfigCommon.InitDataStatement(ConfigCharacterAudioConfigByIdWithDefaultId.HandleId, "db_entity_audio.db", "select BinData from `CharacterAudioConfig` where id = ? AND (SELECT count(0) from `CharacterAudioConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `CharacterAudioConfig` WHERE id = ?) >0;");
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00089D30 File Offset: 0x00087F30
		public static CharacterAudioConfig? GetConfig(int p0Id, int p1Id, int p2Id, int p3Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCharacterAudioConfigByIdWithDefaultId.HandleId, ConfigCharacterAudioConfigByIdWithDefaultId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 5);
				defaultInterpolatedStringHandler.AppendFormatted("CharacterAudioConfigByIdWithDefaultId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p3Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CharacterAudioConfig?(CharacterAudioConfig.GetRootAsCharacterAudioConfig(configBuffer));
				}
			}
			ConfigCharacterAudioConfigByIdWithDefaultId.LogPair.Clear();
			ConfigCharacterAudioConfigByIdWithDefaultId.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			ConfigCharacterAudioConfigByIdWithDefaultId.LogPair.Add(new ValueTuple<string, object>("Id", p1Id));
			ConfigCharacterAudioConfigByIdWithDefaultId.LogPair.Add(new ValueTuple<string, object>("Id", p2Id));
			ConfigCharacterAudioConfigByIdWithDefaultId.LogPair.Add(new ValueTuple<string, object>("Id", p3Id));
			if (!ConfigCommon.BindInt(ConfigCharacterAudioConfigByIdWithDefaultId.HandleId, 1, p0Id, ConfigCharacterAudioConfigByIdWithDefaultId.LogPair) || !ConfigCommon.BindInt(ConfigCharacterAudioConfigByIdWithDefaultId.HandleId, 2, p1Id, ConfigCharacterAudioConfigByIdWithDefaultId.LogPair) || !ConfigCommon.BindInt(ConfigCharacterAudioConfigByIdWithDefaultId.HandleId, 3, p2Id, ConfigCharacterAudioConfigByIdWithDefaultId.LogPair) || !ConfigCommon.BindInt(ConfigCharacterAudioConfigByIdWithDefaultId.HandleId, 4, p3Id, ConfigCharacterAudioConfigByIdWithDefaultId.LogPair) || ConfigCommon.Step(ConfigCharacterAudioConfigByIdWithDefaultId.HandleId, true, ConfigCharacterAudioConfigByIdWithDefaultId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCharacterAudioConfigByIdWithDefaultId.HandleId, ConfigCharacterAudioConfigByIdWithDefaultId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCharacterAudioConfigByIdWithDefaultId.HandleId, 0, ConfigCharacterAudioConfigByIdWithDefaultId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCharacterAudioConfigByIdWithDefaultId.HandleId, ConfigCharacterAudioConfigByIdWithDefaultId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CharacterAudioConfig rootAsCharacterAudioConfig = CharacterAudioConfig.GetRootAsCharacterAudioConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 5);
				defaultInterpolatedStringHandler.AppendFormatted("CharacterAudioConfigByIdWithDefaultId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p3Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCharacterAudioConfigByIdWithDefaultId.HandleId, ConfigCharacterAudioConfigByIdWithDefaultId.LogPair);
			return new CharacterAudioConfig?(rootAsCharacterAudioConfig);
		}

		// Token: 0x04000914 RID: 2324
		private const string DB = "db_entity_audio.db";

		// Token: 0x04000915 RID: 2325
		private const string FILE = "y.音频组件配置.xlsx";

		// Token: 0x04000916 RID: 2326
		private const string TABLE = "CharacterAudioConfig";

		// Token: 0x04000917 RID: 2327
		private const string COMMAND = "select BinData from `CharacterAudioConfig` where id = ? AND (SELECT count(0) from `CharacterAudioConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `CharacterAudioConfig` WHERE id = ?) >0;";

		// Token: 0x04000918 RID: 2328
		private const string KEY_PREFIX = "CharacterAudioConfigByIdWithDefaultId";

		// Token: 0x04000919 RID: 2329
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400091A RID: 2330
		private static int HandleId;
	}
}
