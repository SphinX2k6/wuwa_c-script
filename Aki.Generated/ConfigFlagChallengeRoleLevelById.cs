using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000318 RID: 792
	public class ConfigFlagChallengeRoleLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001295 RID: 4757 RVA: 0x000C6285 File Offset: 0x000C4485
		static ConfigFlagChallengeRoleLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeRoleLevelById.CreateStaticDefaultValue), new Action(ConfigFlagChallengeRoleLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x000C62A4 File Offset: 0x000C44A4
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagChallengeRoleLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagChallengeRoleLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flagchallenge.db"),
				new ValueTuple<string, object>("文件", "c.插旗活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "FlagChallengeRoleLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagChallengeRoleLevel` where Id=?")
			});
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x000C6323 File Offset: 0x000C4523
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeRoleLevelById.LogPair = null;
			ConfigFlagChallengeRoleLevelById.HandleId = 0;
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x000C6331 File Offset: 0x000C4531
		public static void Init()
		{
			ConfigFlagChallengeRoleLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeRoleLevelById.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeRoleLevel` where Id=?");
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x000C634C File Offset: 0x000C454C
		public static FlagChallengeRoleLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagChallengeRoleLevelById.HandleId, ConfigFlagChallengeRoleLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeRoleLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FlagChallengeRoleLevel?(FlagChallengeRoleLevel.GetRootAsFlagChallengeRoleLevel(configBuffer));
				}
			}
			ConfigFlagChallengeRoleLevelById.LogPair.Clear();
			ConfigFlagChallengeRoleLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFlagChallengeRoleLevelById.HandleId, 1, p0Id, ConfigFlagChallengeRoleLevelById.LogPair) || ConfigCommon.Step(ConfigFlagChallengeRoleLevelById.HandleId, true, ConfigFlagChallengeRoleLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFlagChallengeRoleLevelById.HandleId, ConfigFlagChallengeRoleLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagChallengeRoleLevelById.HandleId, 0, ConfigFlagChallengeRoleLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFlagChallengeRoleLevelById.HandleId, ConfigFlagChallengeRoleLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FlagChallengeRoleLevel rootAsFlagChallengeRoleLevel = FlagChallengeRoleLevel.GetRootAsFlagChallengeRoleLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeRoleLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFlagChallengeRoleLevelById.HandleId, ConfigFlagChallengeRoleLevelById.LogPair);
			return new FlagChallengeRoleLevel?(rootAsFlagChallengeRoleLevel);
		}

		// Token: 0x0400158C RID: 5516
		private const string DB = "db_flagchallenge.db";

		// Token: 0x0400158D RID: 5517
		private const string FILE = "c.插旗活动局内.xlsx";

		// Token: 0x0400158E RID: 5518
		private const string TABLE = "FlagChallengeRoleLevel";

		// Token: 0x0400158F RID: 5519
		private const string COMMAND = "select BinData from `FlagChallengeRoleLevel` where Id=?";

		// Token: 0x04001590 RID: 5520
		private const string KEY_PREFIX = "FlagChallengeRoleLevelById";

		// Token: 0x04001591 RID: 5521
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001592 RID: 5522
		private static int HandleId;
	}
}
