using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000142 RID: 322
	public class ConfigCharacterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600078D RID: 1933 RVA: 0x00084650 File Offset: 0x00082850
		static ConfigCharacterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCharacterById.CreateStaticDefaultValue), new Action(ConfigCharacterById.ResetStaticDefaultValue));
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00084670 File Offset: 0x00082870
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

		// Token: 0x0600078F RID: 1935 RVA: 0x000846EF File Offset: 0x000828EF
		public static void ResetStaticDefaultValue()
		{
			ConfigCharacterById.LogPair = null;
			ConfigCharacterById.HandleId = 0;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x000846FD File Offset: 0x000828FD
		public static void Init()
		{
			ConfigCharacterById.HandleId = ConfigCommon.InitDataStatement(ConfigCharacterById.HandleId, "db_moonchasing.db", "select BinData from `Character` where Id=?");
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00084718 File Offset: 0x00082918
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

		// Token: 0x040008B2 RID: 2226
		private const string DB = "db_moonchasing.db";

		// Token: 0x040008B3 RID: 2227
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x040008B4 RID: 2228
		private const string TABLE = "Character";

		// Token: 0x040008B5 RID: 2229
		private const string COMMAND = "select BinData from `Character` where Id=?";

		// Token: 0x040008B6 RID: 2230
		private const string KEY_PREFIX = "CharacterById";

		// Token: 0x040008B7 RID: 2231
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008B8 RID: 2232
		private static int HandleId;
	}
}
