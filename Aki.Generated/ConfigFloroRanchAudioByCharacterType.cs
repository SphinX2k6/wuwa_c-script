using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200030D RID: 781
	public class ConfigFloroRanchAudioByCharacterType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001253 RID: 4691 RVA: 0x000C122B File Offset: 0x000BF42B
		static ConfigFloroRanchAudioByCharacterType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchAudioByCharacterType.CreateStaticDefaultValue), new Action(ConfigFloroRanchAudioByCharacterType.ResetStaticDefaultValue));
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x000C124C File Offset: 0x000BF44C
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

		// Token: 0x06001255 RID: 4693 RVA: 0x000C12CB File Offset: 0x000BF4CB
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchAudioByCharacterType.LogPair = null;
			ConfigFloroRanchAudioByCharacterType.HandleId = 0;
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x000C12D9 File Offset: 0x000BF4D9
		public static void Init()
		{
			ConfigFloroRanchAudioByCharacterType.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchAudioByCharacterType.HandleId, "db_flororanch.db", "select BinData from `FloroRanchAudio` where CharacterType=?");
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x000C12F4 File Offset: 0x000BF4F4
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

		// Token: 0x0400153F RID: 5439
		private const string DB = "db_flororanch.db";

		// Token: 0x04001540 RID: 5440
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001541 RID: 5441
		private const string TABLE = "FloroRanchAudio";

		// Token: 0x04001542 RID: 5442
		private const string COMMAND = "select BinData from `FloroRanchAudio` where CharacterType=?";

		// Token: 0x04001543 RID: 5443
		private const string KEY_PREFIX = "FloroRanchAudioByCharacterType";

		// Token: 0x04001544 RID: 5444
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001545 RID: 5445
		private static int HandleId;
	}
}
