using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000317 RID: 791
	public class ConfigFlagChallengeRoleLevelByActivityIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600128F RID: 4751 RVA: 0x000C5FE7 File Offset: 0x000C41E7
		static ConfigFlagChallengeRoleLevelByActivityIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeRoleLevelByActivityIdAndLevel.CreateStaticDefaultValue), new Action(ConfigFlagChallengeRoleLevelByActivityIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x000C6008 File Offset: 0x000C4208
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

		// Token: 0x06001291 RID: 4753 RVA: 0x000C6087 File Offset: 0x000C4287
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeRoleLevelByActivityIdAndLevel.LogPair = null;
			ConfigFlagChallengeRoleLevelByActivityIdAndLevel.HandleId = 0;
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x000C6095 File Offset: 0x000C4295
		public static void Init()
		{
			ConfigFlagChallengeRoleLevelByActivityIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeRoleLevelByActivityIdAndLevel.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeRoleLevel` where ActivityId=? AND Level=?");
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x000C60B0 File Offset: 0x000C42B0
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

		// Token: 0x04001585 RID: 5509
		private const string DB = "db_flagchallenge.db";

		// Token: 0x04001586 RID: 5510
		private const string FILE = "c.插旗活动局内.xlsx";

		// Token: 0x04001587 RID: 5511
		private const string TABLE = "FlagChallengeRoleLevel";

		// Token: 0x04001588 RID: 5512
		private const string COMMAND = "select BinData from `FlagChallengeRoleLevel` where ActivityId=? AND Level=?";

		// Token: 0x04001589 RID: 5513
		private const string KEY_PREFIX = "FlagChallengeRoleLevelByActivityIdAndLevel";

		// Token: 0x0400158A RID: 5514
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400158B RID: 5515
		private static int HandleId;
	}
}
