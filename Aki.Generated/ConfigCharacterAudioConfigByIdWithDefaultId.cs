using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000141 RID: 321
	public class ConfigCharacterAudioConfigByIdWithDefaultId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000787 RID: 1927 RVA: 0x00084304 File Offset: 0x00082504
		static ConfigCharacterAudioConfigByIdWithDefaultId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCharacterAudioConfigByIdWithDefaultId.CreateStaticDefaultValue), new Action(ConfigCharacterAudioConfigByIdWithDefaultId.ResetStaticDefaultValue));
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00084324 File Offset: 0x00082524
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

		// Token: 0x06000789 RID: 1929 RVA: 0x000843A3 File Offset: 0x000825A3
		public static void ResetStaticDefaultValue()
		{
			ConfigCharacterAudioConfigByIdWithDefaultId.LogPair = null;
			ConfigCharacterAudioConfigByIdWithDefaultId.HandleId = 0;
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x000843B1 File Offset: 0x000825B1
		public static void Init()
		{
			ConfigCharacterAudioConfigByIdWithDefaultId.HandleId = ConfigCommon.InitDataStatement(ConfigCharacterAudioConfigByIdWithDefaultId.HandleId, "db_entity_audio.db", "select BinData from `CharacterAudioConfig` where id = ? AND (SELECT count(0) from `CharacterAudioConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `CharacterAudioConfig` WHERE id = ?) >0;");
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x000843CC File Offset: 0x000825CC
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

		// Token: 0x040008AB RID: 2219
		private const string DB = "db_entity_audio.db";

		// Token: 0x040008AC RID: 2220
		private const string FILE = "y.音频组件配置.xlsx";

		// Token: 0x040008AD RID: 2221
		private const string TABLE = "CharacterAudioConfig";

		// Token: 0x040008AE RID: 2222
		private const string COMMAND = "select BinData from `CharacterAudioConfig` where id = ? AND (SELECT count(0) from `CharacterAudioConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `CharacterAudioConfig` WHERE id = ?) >0;";

		// Token: 0x040008AF RID: 2223
		private const string KEY_PREFIX = "CharacterAudioConfigByIdWithDefaultId";

		// Token: 0x040008B0 RID: 2224
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008B1 RID: 2225
		private static int HandleId;
	}
}
