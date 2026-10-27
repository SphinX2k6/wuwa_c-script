using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000637 RID: 1591
	public class ConfigParkourChallengeByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600255A RID: 9562 RVA: 0x0012CD90 File Offset: 0x0012AF90
		static ConfigParkourChallengeByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigParkourChallengeByMarkId.CreateStaticDefaultValue), new Action(ConfigParkourChallengeByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x0012CDB0 File Offset: 0x0012AFB0
		public static void CreateStaticDefaultValue()
		{
			ConfigParkourChallengeByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigParkourChallengeByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_parkourchallenge.db"),
				new ValueTuple<string, object>("文件", "p.跑酷挑战.xlsx"),
				new ValueTuple<string, object>("表名", "ParkourChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `ParkourChallenge` where MarkId=?")
			});
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x0012CE2F File Offset: 0x0012B02F
		public static void ResetStaticDefaultValue()
		{
			ConfigParkourChallengeByMarkId.LogPair = null;
			ConfigParkourChallengeByMarkId.HandleId = 0;
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x0012CE3D File Offset: 0x0012B03D
		public static void Init()
		{
			ConfigParkourChallengeByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigParkourChallengeByMarkId.HandleId, "db_parkourchallenge.db", "select BinData from `ParkourChallenge` where MarkId=?");
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x0012CE58 File Offset: 0x0012B058
		public static ParkourChallenge? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigParkourChallengeByMarkId.HandleId, ConfigParkourChallengeByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ParkourChallengeByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ParkourChallenge?(ParkourChallenge.GetRootAsParkourChallenge(configBuffer));
				}
			}
			ConfigParkourChallengeByMarkId.LogPair.Clear();
			ConfigParkourChallengeByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigParkourChallengeByMarkId.HandleId, 1, p0MarkId, ConfigParkourChallengeByMarkId.LogPair) || ConfigCommon.Step(ConfigParkourChallengeByMarkId.HandleId, true, ConfigParkourChallengeByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigParkourChallengeByMarkId.HandleId, ConfigParkourChallengeByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigParkourChallengeByMarkId.HandleId, 0, ConfigParkourChallengeByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigParkourChallengeByMarkId.HandleId, ConfigParkourChallengeByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ParkourChallenge rootAsParkourChallenge = ParkourChallenge.GetRootAsParkourChallenge(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ParkourChallengeByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigParkourChallengeByMarkId.HandleId, ConfigParkourChallengeByMarkId.LogPair);
			return new ParkourChallenge?(rootAsParkourChallenge);
		}

		// Token: 0x04002B67 RID: 11111
		private const string DB = "db_parkourchallenge.db";

		// Token: 0x04002B68 RID: 11112
		private const string FILE = "p.跑酷挑战.xlsx";

		// Token: 0x04002B69 RID: 11113
		private const string TABLE = "ParkourChallenge";

		// Token: 0x04002B6A RID: 11114
		private const string COMMAND = "select BinData from `ParkourChallenge` where MarkId=?";

		// Token: 0x04002B6B RID: 11115
		private const string KEY_PREFIX = "ParkourChallengeByMarkId";

		// Token: 0x04002B6C RID: 11116
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B6D RID: 11117
		private static int HandleId;
	}
}
