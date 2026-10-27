using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002F8 RID: 760
	public class ConfigFlagChallengeAreaByLevelId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011D5 RID: 4565 RVA: 0x000BE4AC File Offset: 0x000BC6AC
		static ConfigFlagChallengeAreaByLevelId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeAreaByLevelId.CreateStaticDefaultValue), new Action(ConfigFlagChallengeAreaByLevelId.ResetStaticDefaultValue));
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x000BE4CC File Offset: 0x000BC6CC
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

		// Token: 0x060011D7 RID: 4567 RVA: 0x000BE54B File Offset: 0x000BC74B
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeAreaByLevelId.LogPair = null;
			ConfigFlagChallengeAreaByLevelId.HandleId = 0;
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x000BE559 File Offset: 0x000BC759
		public static void Init()
		{
			ConfigFlagChallengeAreaByLevelId.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeAreaByLevelId.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeArea` where LevelId=?");
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x000BE574 File Offset: 0x000BC774
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

		// Token: 0x040014AC RID: 5292
		private const string DB = "db_flagchallenge.db";

		// Token: 0x040014AD RID: 5293
		private const string FILE = "c.插旗活动局外.xlsx";

		// Token: 0x040014AE RID: 5294
		private const string TABLE = "FlagChallengeArea";

		// Token: 0x040014AF RID: 5295
		private const string COMMAND = "select BinData from `FlagChallengeArea` where LevelId=?";

		// Token: 0x040014B0 RID: 5296
		private const string KEY_PREFIX = "FlagChallengeAreaByLevelId";

		// Token: 0x040014B1 RID: 5297
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014B2 RID: 5298
		private static int HandleId;
	}
}
