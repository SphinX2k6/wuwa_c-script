using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002FD RID: 765
	public class ConfigFlagChallengeRoleBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011F3 RID: 4595 RVA: 0x000BEF3F File Offset: 0x000BD13F
		static ConfigFlagChallengeRoleBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeRoleBuffById.CreateStaticDefaultValue), new Action(ConfigFlagChallengeRoleBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x000BEF60 File Offset: 0x000BD160
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

		// Token: 0x060011F5 RID: 4597 RVA: 0x000BEFDF File Offset: 0x000BD1DF
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeRoleBuffById.LogPair = null;
			ConfigFlagChallengeRoleBuffById.HandleId = 0;
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x000BEFED File Offset: 0x000BD1ED
		public static void Init()
		{
			ConfigFlagChallengeRoleBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeRoleBuffById.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeRoleBuff` where Id=?");
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x000BF008 File Offset: 0x000BD208
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

		// Token: 0x040014CF RID: 5327
		private const string DB = "db_flagchallenge.db";

		// Token: 0x040014D0 RID: 5328
		private const string FILE = "c.插旗活动局内.xlsx";

		// Token: 0x040014D1 RID: 5329
		private const string TABLE = "FlagChallengeRoleBuff";

		// Token: 0x040014D2 RID: 5330
		private const string COMMAND = "select BinData from `FlagChallengeRoleBuff` where Id=?";

		// Token: 0x040014D3 RID: 5331
		private const string KEY_PREFIX = "FlagChallengeRoleBuffById";

		// Token: 0x040014D4 RID: 5332
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014D5 RID: 5333
		private static int HandleId;
	}
}
