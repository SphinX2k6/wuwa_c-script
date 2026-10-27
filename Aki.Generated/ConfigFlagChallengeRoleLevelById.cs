using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000303 RID: 771
	public class ConfigFlagChallengeRoleLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001217 RID: 4631 RVA: 0x000BFD79 File Offset: 0x000BDF79
		static ConfigFlagChallengeRoleLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeRoleLevelById.CreateStaticDefaultValue), new Action(ConfigFlagChallengeRoleLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x000BFD98 File Offset: 0x000BDF98
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

		// Token: 0x06001219 RID: 4633 RVA: 0x000BFE17 File Offset: 0x000BE017
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeRoleLevelById.LogPair = null;
			ConfigFlagChallengeRoleLevelById.HandleId = 0;
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x000BFE25 File Offset: 0x000BE025
		public static void Init()
		{
			ConfigFlagChallengeRoleLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeRoleLevelById.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeRoleLevel` where Id=?");
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x000BFE40 File Offset: 0x000BE040
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

		// Token: 0x040014F9 RID: 5369
		private const string DB = "db_flagchallenge.db";

		// Token: 0x040014FA RID: 5370
		private const string FILE = "c.插旗活动局内.xlsx";

		// Token: 0x040014FB RID: 5371
		private const string TABLE = "FlagChallengeRoleLevel";

		// Token: 0x040014FC RID: 5372
		private const string COMMAND = "select BinData from `FlagChallengeRoleLevel` where Id=?";

		// Token: 0x040014FD RID: 5373
		private const string KEY_PREFIX = "FlagChallengeRoleLevelById";

		// Token: 0x040014FE RID: 5374
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014FF RID: 5375
		private static int HandleId;
	}
}
