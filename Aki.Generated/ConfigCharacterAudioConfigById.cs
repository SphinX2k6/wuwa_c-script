using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200014F RID: 335
	public class ConfigCharacterAudioConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007DB RID: 2011 RVA: 0x00089A1F File Offset: 0x00087C1F
		static ConfigCharacterAudioConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCharacterAudioConfigById.CreateStaticDefaultValue), new Action(ConfigCharacterAudioConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00089A40 File Offset: 0x00087C40
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

		// Token: 0x060007DD RID: 2013 RVA: 0x00089ABF File Offset: 0x00087CBF
		public static void ResetStaticDefaultValue()
		{
			ConfigCharacterAudioConfigById.LogPair = null;
			ConfigCharacterAudioConfigById.HandleId = 0;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00089ACD File Offset: 0x00087CCD
		public static void Init()
		{
			ConfigCharacterAudioConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigCharacterAudioConfigById.HandleId, "db_entity_audio.db", "select BinData from `CharacterAudioConfig` where Id=?");
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00089AE8 File Offset: 0x00087CE8
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

		// Token: 0x0400090D RID: 2317
		private const string DB = "db_entity_audio.db";

		// Token: 0x0400090E RID: 2318
		private const string FILE = "y.音频组件配置.xlsx";

		// Token: 0x0400090F RID: 2319
		private const string TABLE = "CharacterAudioConfig";

		// Token: 0x04000910 RID: 2320
		private const string COMMAND = "select BinData from `CharacterAudioConfig` where Id=?";

		// Token: 0x04000911 RID: 2321
		private const string KEY_PREFIX = "CharacterAudioConfigById";

		// Token: 0x04000912 RID: 2322
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000913 RID: 2323
		private static int HandleId;
	}
}
