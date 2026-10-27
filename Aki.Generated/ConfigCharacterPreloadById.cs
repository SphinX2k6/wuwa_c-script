using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000145 RID: 325
	public class ConfigCharacterPreloadById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600079F RID: 1951 RVA: 0x00084C73 File Offset: 0x00082E73
		static ConfigCharacterPreloadById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCharacterPreloadById.CreateStaticDefaultValue), new Action(ConfigCharacterPreloadById.ResetStaticDefaultValue));
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00084C94 File Offset: 0x00082E94
		public static void CreateStaticDefaultValue()
		{
			ConfigCharacterPreloadById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCharacterPreloadById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_character_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/CharacterPreload.csv"),
				new ValueTuple<string, object>("表名", "CharacterPreload"),
				new ValueTuple<string, object>("语句", "select BinData from `CharacterPreload` where Id=?")
			});
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00084D13 File Offset: 0x00082F13
		public static void ResetStaticDefaultValue()
		{
			ConfigCharacterPreloadById.LogPair = null;
			ConfigCharacterPreloadById.HandleId = 0;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00084D21 File Offset: 0x00082F21
		public static void Init()
		{
			ConfigCharacterPreloadById.HandleId = ConfigCommon.InitDataStatement(ConfigCharacterPreloadById.HandleId, "db_character_preload.db", "select BinData from `CharacterPreload` where Id=?");
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00084D3C File Offset: 0x00082F3C
		public static CharacterPreload? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCharacterPreloadById.HandleId, ConfigCharacterPreloadById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CharacterPreloadById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CharacterPreload?(CharacterPreload.GetRootAsCharacterPreload(configBuffer));
				}
			}
			ConfigCharacterPreloadById.LogPair.Clear();
			ConfigCharacterPreloadById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCharacterPreloadById.HandleId, 1, p0Id, ConfigCharacterPreloadById.LogPair) || ConfigCommon.Step(ConfigCharacterPreloadById.HandleId, true, ConfigCharacterPreloadById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCharacterPreloadById.HandleId, ConfigCharacterPreloadById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCharacterPreloadById.HandleId, 0, ConfigCharacterPreloadById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCharacterPreloadById.HandleId, ConfigCharacterPreloadById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CharacterPreload rootAsCharacterPreload = CharacterPreload.GetRootAsCharacterPreload(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CharacterPreloadById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCharacterPreloadById.HandleId, ConfigCharacterPreloadById.LogPair);
			return new CharacterPreload?(rootAsCharacterPreload);
		}

		// Token: 0x040008C7 RID: 2247
		private const string DB = "db_character_preload.db";

		// Token: 0x040008C8 RID: 2248
		private const string FILE = "Preload/CharacterPreload.csv";

		// Token: 0x040008C9 RID: 2249
		private const string TABLE = "CharacterPreload";

		// Token: 0x040008CA RID: 2250
		private const string COMMAND = "select BinData from `CharacterPreload` where Id=?";

		// Token: 0x040008CB RID: 2251
		private const string KEY_PREFIX = "CharacterPreloadById";

		// Token: 0x040008CC RID: 2252
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008CD RID: 2253
		private static int HandleId;
	}
}
