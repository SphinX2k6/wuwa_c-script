using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000154 RID: 340
	public class ConfigCharacterPreloadById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007F9 RID: 2041 RVA: 0x0008A5D7 File Offset: 0x000887D7
		static ConfigCharacterPreloadById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCharacterPreloadById.CreateStaticDefaultValue), new Action(ConfigCharacterPreloadById.ResetStaticDefaultValue));
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x0008A5F8 File Offset: 0x000887F8
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

		// Token: 0x060007FB RID: 2043 RVA: 0x0008A677 File Offset: 0x00088877
		public static void ResetStaticDefaultValue()
		{
			ConfigCharacterPreloadById.LogPair = null;
			ConfigCharacterPreloadById.HandleId = 0;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x0008A685 File Offset: 0x00088885
		public static void Init()
		{
			ConfigCharacterPreloadById.HandleId = ConfigCommon.InitDataStatement(ConfigCharacterPreloadById.HandleId, "db_character_preload.db", "select BinData from `CharacterPreload` where Id=?");
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0008A6A0 File Offset: 0x000888A0
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

		// Token: 0x04000930 RID: 2352
		private const string DB = "db_character_preload.db";

		// Token: 0x04000931 RID: 2353
		private const string FILE = "Preload/CharacterPreload.csv";

		// Token: 0x04000932 RID: 2354
		private const string TABLE = "CharacterPreload";

		// Token: 0x04000933 RID: 2355
		private const string COMMAND = "select BinData from `CharacterPreload` where Id=?";

		// Token: 0x04000934 RID: 2356
		private const string KEY_PREFIX = "CharacterPreloadById";

		// Token: 0x04000935 RID: 2357
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000936 RID: 2358
		private static int HandleId;
	}
}
