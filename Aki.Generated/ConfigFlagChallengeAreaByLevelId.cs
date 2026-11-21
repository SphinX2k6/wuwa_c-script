using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200030D RID: 781
	public class ConfigFlagChallengeAreaByLevelId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001253 RID: 4691 RVA: 0x000C49B8 File Offset: 0x000C2BB8
		static ConfigFlagChallengeAreaByLevelId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeAreaByLevelId.CreateStaticDefaultValue), new Action(ConfigFlagChallengeAreaByLevelId.ResetStaticDefaultValue));
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x000C49D8 File Offset: 0x000C2BD8
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagChallengeAreaByLevelId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagChallengeAreaByLevelId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flagchallenge.db"),
				new ValueTuple<string, object>("文件", "c.插旗活动局外.xlsx"),
				new ValueTuple<string, object>("表名", "FlagChallengeArea"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagChallengeArea` where LevelId=?")
			});
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x000C4A57 File Offset: 0x000C2C57
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeAreaByLevelId.LogPair = null;
			ConfigFlagChallengeAreaByLevelId.HandleId = 0;
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x000C4A65 File Offset: 0x000C2C65
		public static void Init()
		{
			ConfigFlagChallengeAreaByLevelId.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeAreaByLevelId.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeArea` where LevelId=?");
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x000C4A80 File Offset: 0x000C2C80
		[NullableContext(2)]
		public static IReadOnlyList<FlagChallengeArea> GetConfigList(int p0LevelId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagChallengeAreaByLevelId.HandleId, ConfigFlagChallengeAreaByLevelId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeAreaByLevelId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LevelId);
				IReadOnlyList<FlagChallengeArea> readOnlyList = (IReadOnlyList<FlagChallengeArea>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFlagChallengeAreaByLevelId.LogPair.Clear();
			ConfigFlagChallengeAreaByLevelId.LogPair.Add(new ValueTuple<string, object>("LevelId", p0LevelId));
			if (!ConfigCommon.BindInt(ConfigFlagChallengeAreaByLevelId.HandleId, 1, p0LevelId, ConfigFlagChallengeAreaByLevelId.LogPair))
			{
				ConfigCommon.Reset(ConfigFlagChallengeAreaByLevelId.HandleId, ConfigFlagChallengeAreaByLevelId.LogPair);
				return null;
			}
			List<FlagChallengeArea> list = new List<FlagChallengeArea>();
			while (ConfigCommon.Step(ConfigFlagChallengeAreaByLevelId.HandleId, false, ConfigFlagChallengeAreaByLevelId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagChallengeAreaByLevelId.HandleId, 0, ConfigFlagChallengeAreaByLevelId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFlagChallengeAreaByLevelId.HandleId, ConfigFlagChallengeAreaByLevelId.LogPair);
					return null;
				}
				FlagChallengeArea rootAsFlagChallengeArea = FlagChallengeArea.GetRootAsFlagChallengeArea(new ByteBuffer(item2));
				list.Add(rootAsFlagChallengeArea);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeAreaByLevelId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LevelId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFlagChallengeAreaByLevelId.HandleId, ConfigFlagChallengeAreaByLevelId.LogPair);
			return list;
		}

		// Token: 0x0400153F RID: 5439
		private const string DB = "db_flagchallenge.db";

		// Token: 0x04001540 RID: 5440
		private const string FILE = "c.插旗活动局外.xlsx";

		// Token: 0x04001541 RID: 5441
		private const string TABLE = "FlagChallengeArea";

		// Token: 0x04001542 RID: 5442
		private const string COMMAND = "select BinData from `FlagChallengeArea` where LevelId=?";

		// Token: 0x04001543 RID: 5443
		private const string KEY_PREFIX = "FlagChallengeAreaByLevelId";

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
