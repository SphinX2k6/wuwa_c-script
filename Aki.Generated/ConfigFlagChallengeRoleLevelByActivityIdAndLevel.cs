using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000302 RID: 770
	public class ConfigFlagChallengeRoleLevelByActivityIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001211 RID: 4625 RVA: 0x000BFADB File Offset: 0x000BDCDB
		static ConfigFlagChallengeRoleLevelByActivityIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeRoleLevelByActivityIdAndLevel.CreateStaticDefaultValue), new Action(ConfigFlagChallengeRoleLevelByActivityIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x000BFAFC File Offset: 0x000BDCFC
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagChallengeRoleLevelByActivityIdAndLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagChallengeRoleLevelByActivityIdAndLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flagchallenge.db"),
				new ValueTuple<string, object>("文件", "c.插旗活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "FlagChallengeRoleLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagChallengeRoleLevel` where ActivityId=? AND Level=?")
			});
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x000BFB7B File Offset: 0x000BDD7B
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeRoleLevelByActivityIdAndLevel.LogPair = null;
			ConfigFlagChallengeRoleLevelByActivityIdAndLevel.HandleId = 0;
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x000BFB89 File Offset: 0x000BDD89
		public static void Init()
		{
			ConfigFlagChallengeRoleLevelByActivityIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeRoleLevelByActivityIdAndLevel.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeRoleLevel` where ActivityId=? AND Level=?");
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x000BFBA4 File Offset: 0x000BDDA4
		public static FlagChallengeRoleLevel? GetConfig(int p0ActivityId, int p1Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagChallengeRoleLevelByActivityIdAndLevel.HandleId, ConfigFlagChallengeRoleLevelByActivityIdAndLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeRoleLevelByActivityIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FlagChallengeRoleLevel?(FlagChallengeRoleLevel.GetRootAsFlagChallengeRoleLevel(configBuffer));
				}
			}
			ConfigFlagChallengeRoleLevelByActivityIdAndLevel.LogPair.Clear();
			ConfigFlagChallengeRoleLevelByActivityIdAndLevel.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			ConfigFlagChallengeRoleLevelByActivityIdAndLevel.LogPair.Add(new ValueTuple<string, object>("Level", p1Level));
			if (!ConfigCommon.BindInt(ConfigFlagChallengeRoleLevelByActivityIdAndLevel.HandleId, 1, p0ActivityId, ConfigFlagChallengeRoleLevelByActivityIdAndLevel.LogPair) || !ConfigCommon.BindInt(ConfigFlagChallengeRoleLevelByActivityIdAndLevel.HandleId, 2, p1Level, ConfigFlagChallengeRoleLevelByActivityIdAndLevel.LogPair) || ConfigCommon.Step(ConfigFlagChallengeRoleLevelByActivityIdAndLevel.HandleId, true, ConfigFlagChallengeRoleLevelByActivityIdAndLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFlagChallengeRoleLevelByActivityIdAndLevel.HandleId, ConfigFlagChallengeRoleLevelByActivityIdAndLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagChallengeRoleLevelByActivityIdAndLevel.HandleId, 0, ConfigFlagChallengeRoleLevelByActivityIdAndLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFlagChallengeRoleLevelByActivityIdAndLevel.HandleId, ConfigFlagChallengeRoleLevelByActivityIdAndLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FlagChallengeRoleLevel rootAsFlagChallengeRoleLevel = FlagChallengeRoleLevel.GetRootAsFlagChallengeRoleLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeRoleLevelByActivityIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFlagChallengeRoleLevelByActivityIdAndLevel.HandleId, ConfigFlagChallengeRoleLevelByActivityIdAndLevel.LogPair);
			return new FlagChallengeRoleLevel?(rootAsFlagChallengeRoleLevel);
		}

		// Token: 0x040014F2 RID: 5362
		private const string DB = "db_flagchallenge.db";

		// Token: 0x040014F3 RID: 5363
		private const string FILE = "c.插旗活动局内.xlsx";

		// Token: 0x040014F4 RID: 5364
		private const string TABLE = "FlagChallengeRoleLevel";

		// Token: 0x040014F5 RID: 5365
		private const string COMMAND = "select BinData from `FlagChallengeRoleLevel` where ActivityId=? AND Level=?";

		// Token: 0x040014F6 RID: 5366
		private const string KEY_PREFIX = "FlagChallengeRoleLevelByActivityIdAndLevel";

		// Token: 0x040014F7 RID: 5367
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014F8 RID: 5368
		private static int HandleId;
	}
}
