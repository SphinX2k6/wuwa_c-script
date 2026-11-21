using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000322 RID: 802
	public class ConfigFloroRanchAudioByCharacterType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012D1 RID: 4817 RVA: 0x000C7737 File Offset: 0x000C5937
		static ConfigFloroRanchAudioByCharacterType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchAudioByCharacterType.CreateStaticDefaultValue), new Action(ConfigFloroRanchAudioByCharacterType.ResetStaticDefaultValue));
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x000C7758 File Offset: 0x000C5958
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchAudioByCharacterType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchAudioByCharacterType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchAudio"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchAudio` where CharacterType=?")
			});
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x000C77D7 File Offset: 0x000C59D7
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchAudioByCharacterType.LogPair = null;
			ConfigFloroRanchAudioByCharacterType.HandleId = 0;
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x000C77E5 File Offset: 0x000C59E5
		public static void Init()
		{
			ConfigFloroRanchAudioByCharacterType.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchAudioByCharacterType.HandleId, "db_flororanch.db", "select BinData from `FloroRanchAudio` where CharacterType=?");
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x000C7800 File Offset: 0x000C5A00
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchAudio> GetConfigList(int p0CharacterType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchAudioByCharacterType.HandleId, ConfigFloroRanchAudioByCharacterType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchAudioByCharacterType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CharacterType);
				IReadOnlyList<FloroRanchAudio> readOnlyList = (IReadOnlyList<FloroRanchAudio>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFloroRanchAudioByCharacterType.LogPair.Clear();
			ConfigFloroRanchAudioByCharacterType.LogPair.Add(new ValueTuple<string, object>("CharacterType", p0CharacterType));
			if (!ConfigCommon.BindInt(ConfigFloroRanchAudioByCharacterType.HandleId, 1, p0CharacterType, ConfigFloroRanchAudioByCharacterType.LogPair))
			{
				ConfigCommon.Reset(ConfigFloroRanchAudioByCharacterType.HandleId, ConfigFloroRanchAudioByCharacterType.LogPair);
				return null;
			}
			List<FloroRanchAudio> list = new List<FloroRanchAudio>();
			while (ConfigCommon.Step(ConfigFloroRanchAudioByCharacterType.HandleId, false, ConfigFloroRanchAudioByCharacterType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchAudioByCharacterType.HandleId, 0, ConfigFloroRanchAudioByCharacterType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchAudioByCharacterType.HandleId, ConfigFloroRanchAudioByCharacterType.LogPair);
					return null;
				}
				FloroRanchAudio rootAsFloroRanchAudio = FloroRanchAudio.GetRootAsFloroRanchAudio(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchAudio);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchAudioByCharacterType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CharacterType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchAudioByCharacterType.HandleId, ConfigFloroRanchAudioByCharacterType.LogPair);
			return list;
		}

		// Token: 0x040015D2 RID: 5586
		private const string DB = "db_flororanch.db";

		// Token: 0x040015D3 RID: 5587
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040015D4 RID: 5588
		private const string TABLE = "FloroRanchAudio";

		// Token: 0x040015D5 RID: 5589
		private const string COMMAND = "select BinData from `FloroRanchAudio` where CharacterType=?";

		// Token: 0x040015D6 RID: 5590
		private const string KEY_PREFIX = "FloroRanchAudioByCharacterType";

		// Token: 0x040015D7 RID: 5591
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015D8 RID: 5592
		private static int HandleId;
	}
}
