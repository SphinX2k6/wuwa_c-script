using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000151 RID: 337
	public class ConfigCharacterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007E7 RID: 2023 RVA: 0x00089FB4 File Offset: 0x000881B4
		static ConfigCharacterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCharacterById.CreateStaticDefaultValue), new Action(ConfigCharacterById.ResetStaticDefaultValue));
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00089FD4 File Offset: 0x000881D4
		public static void CreateStaticDefaultValue()
		{
			ConfigCharacterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCharacterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "Character"),
				new ValueTuple<string, object>("语句", "select BinData from `Character` where Id=?")
			});
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0008A053 File Offset: 0x00088253
		public static void ResetStaticDefaultValue()
		{
			ConfigCharacterById.LogPair = null;
			ConfigCharacterById.HandleId = 0;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0008A061 File Offset: 0x00088261
		public static void Init()
		{
			ConfigCharacterById.HandleId = ConfigCommon.InitDataStatement(ConfigCharacterById.HandleId, "db_moonchasing.db", "select BinData from `Character` where Id=?");
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0008A07C File Offset: 0x0008827C
		public static Character? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCharacterById.HandleId, ConfigCharacterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CharacterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Character?(Character.GetRootAsCharacter(configBuffer));
				}
			}
			ConfigCharacterById.LogPair.Clear();
			ConfigCharacterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCharacterById.HandleId, 1, p0Id, ConfigCharacterById.LogPair) || ConfigCommon.Step(ConfigCharacterById.HandleId, true, ConfigCharacterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCharacterById.HandleId, ConfigCharacterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCharacterById.HandleId, 0, ConfigCharacterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCharacterById.HandleId, ConfigCharacterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Character rootAsCharacter = Character.GetRootAsCharacter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CharacterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCharacterById.HandleId, ConfigCharacterById.LogPair);
			return new Character?(rootAsCharacter);
		}

		// Token: 0x0400091B RID: 2331
		private const string DB = "db_moonchasing.db";

		// Token: 0x0400091C RID: 2332
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x0400091D RID: 2333
		private const string TABLE = "Character";

		// Token: 0x0400091E RID: 2334
		private const string COMMAND = "select BinData from `Character` where Id=?";

		// Token: 0x0400091F RID: 2335
		private const string KEY_PREFIX = "CharacterById";

		// Token: 0x04000920 RID: 2336
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000921 RID: 2337
		private static int HandleId;
	}
}
