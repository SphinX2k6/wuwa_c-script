using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000312 RID: 786
	public class ConfigFlagChallengeRoleBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001271 RID: 4721 RVA: 0x000C544B File Offset: 0x000C364B
		static ConfigFlagChallengeRoleBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeRoleBuffById.CreateStaticDefaultValue), new Action(ConfigFlagChallengeRoleBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x000C546C File Offset: 0x000C366C
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagChallengeRoleBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagChallengeRoleBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flagchallenge.db"),
				new ValueTuple<string, object>("文件", "c.插旗活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "FlagChallengeRoleBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagChallengeRoleBuff` where Id=?")
			});
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x000C54EB File Offset: 0x000C36EB
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeRoleBuffById.LogPair = null;
			ConfigFlagChallengeRoleBuffById.HandleId = 0;
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x000C54F9 File Offset: 0x000C36F9
		public static void Init()
		{
			ConfigFlagChallengeRoleBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeRoleBuffById.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeRoleBuff` where Id=?");
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x000C5514 File Offset: 0x000C3714
		public static FlagChallengeRoleBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagChallengeRoleBuffById.HandleId, ConfigFlagChallengeRoleBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeRoleBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FlagChallengeRoleBuff?(FlagChallengeRoleBuff.GetRootAsFlagChallengeRoleBuff(configBuffer));
				}
			}
			ConfigFlagChallengeRoleBuffById.LogPair.Clear();
			ConfigFlagChallengeRoleBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFlagChallengeRoleBuffById.HandleId, 1, p0Id, ConfigFlagChallengeRoleBuffById.LogPair) || ConfigCommon.Step(ConfigFlagChallengeRoleBuffById.HandleId, true, ConfigFlagChallengeRoleBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFlagChallengeRoleBuffById.HandleId, ConfigFlagChallengeRoleBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagChallengeRoleBuffById.HandleId, 0, ConfigFlagChallengeRoleBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFlagChallengeRoleBuffById.HandleId, ConfigFlagChallengeRoleBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FlagChallengeRoleBuff rootAsFlagChallengeRoleBuff = FlagChallengeRoleBuff.GetRootAsFlagChallengeRoleBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeRoleBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFlagChallengeRoleBuffById.HandleId, ConfigFlagChallengeRoleBuffById.LogPair);
			return new FlagChallengeRoleBuff?(rootAsFlagChallengeRoleBuff);
		}

		// Token: 0x04001562 RID: 5474
		private const string DB = "db_flagchallenge.db";

		// Token: 0x04001563 RID: 5475
		private const string FILE = "c.插旗活动局内.xlsx";

		// Token: 0x04001564 RID: 5476
		private const string TABLE = "FlagChallengeRoleBuff";

		// Token: 0x04001565 RID: 5477
		private const string COMMAND = "select BinData from `FlagChallengeRoleBuff` where Id=?";

		// Token: 0x04001566 RID: 5478
		private const string KEY_PREFIX = "FlagChallengeRoleBuffById";

		// Token: 0x04001567 RID: 5479
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001568 RID: 5480
		private static int HandleId;
	}
}
