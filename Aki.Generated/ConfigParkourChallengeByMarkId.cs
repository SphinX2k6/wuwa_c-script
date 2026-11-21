using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200064F RID: 1615
	public class ConfigParkourChallengeByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025EA RID: 9706 RVA: 0x0013380C File Offset: 0x00131A0C
		static ConfigParkourChallengeByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigParkourChallengeByMarkId.CreateStaticDefaultValue), new Action(ConfigParkourChallengeByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x0013382C File Offset: 0x00131A2C
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

		// Token: 0x060025EC RID: 9708 RVA: 0x001338AB File Offset: 0x00131AAB
		public static void ResetStaticDefaultValue()
		{
			ConfigParkourChallengeByMarkId.LogPair = null;
			ConfigParkourChallengeByMarkId.HandleId = 0;
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x001338B9 File Offset: 0x00131AB9
		public static void Init()
		{
			ConfigParkourChallengeByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigParkourChallengeByMarkId.HandleId, "db_parkourchallenge.db", "select BinData from `ParkourChallenge` where MarkId=?");
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x001338D4 File Offset: 0x00131AD4
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

		// Token: 0x04002C0F RID: 11279
		private const string DB = "db_parkourchallenge.db";

		// Token: 0x04002C10 RID: 11280
		private const string FILE = "p.跑酷挑战.xlsx";

		// Token: 0x04002C11 RID: 11281
		private const string TABLE = "ParkourChallenge";

		// Token: 0x04002C12 RID: 11282
		private const string COMMAND = "select BinData from `ParkourChallenge` where MarkId=?";

		// Token: 0x04002C13 RID: 11283
		private const string KEY_PREFIX = "ParkourChallengeByMarkId";

		// Token: 0x04002C14 RID: 11284
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C15 RID: 11285
		private static int HandleId;
	}
}
