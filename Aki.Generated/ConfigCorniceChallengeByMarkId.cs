using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001BC RID: 444
	public class ConfigCorniceChallengeByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A6B RID: 2667 RVA: 0x00098038 File Offset: 0x00096238
		static ConfigCorniceChallengeByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCorniceChallengeByMarkId.CreateStaticDefaultValue), new Action(ConfigCorniceChallengeByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00098058 File Offset: 0x00096258
		public static void CreateStaticDefaultValue()
		{
			ConfigCorniceChallengeByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCorniceChallengeByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cornicechallenge.db"),
				new ValueTuple<string, object>("文件", "s.数据收集异常活动.xlsx"),
				new ValueTuple<string, object>("表名", "CorniceChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `CorniceChallenge` where MarkId=?")
			});
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x000980D7 File Offset: 0x000962D7
		public static void ResetStaticDefaultValue()
		{
			ConfigCorniceChallengeByMarkId.LogPair = null;
			ConfigCorniceChallengeByMarkId.HandleId = 0;
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x000980E5 File Offset: 0x000962E5
		public static void Init()
		{
			ConfigCorniceChallengeByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigCorniceChallengeByMarkId.HandleId, "db_cornicechallenge.db", "select BinData from `CorniceChallenge` where MarkId=?");
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00098100 File Offset: 0x00096300
		public static CorniceChallenge? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCorniceChallengeByMarkId.HandleId, ConfigCorniceChallengeByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CorniceChallengeByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CorniceChallenge?(CorniceChallenge.GetRootAsCorniceChallenge(configBuffer));
				}
			}
			ConfigCorniceChallengeByMarkId.LogPair.Clear();
			ConfigCorniceChallengeByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigCorniceChallengeByMarkId.HandleId, 1, p0MarkId, ConfigCorniceChallengeByMarkId.LogPair) || ConfigCommon.Step(ConfigCorniceChallengeByMarkId.HandleId, true, ConfigCorniceChallengeByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCorniceChallengeByMarkId.HandleId, ConfigCorniceChallengeByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCorniceChallengeByMarkId.HandleId, 0, ConfigCorniceChallengeByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCorniceChallengeByMarkId.HandleId, ConfigCorniceChallengeByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CorniceChallenge rootAsCorniceChallenge = CorniceChallenge.GetRootAsCorniceChallenge(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CorniceChallengeByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCorniceChallengeByMarkId.HandleId, ConfigCorniceChallengeByMarkId.LogPair);
			return new CorniceChallenge?(rootAsCorniceChallenge);
		}

		// Token: 0x04000C08 RID: 3080
		private const string DB = "db_cornicechallenge.db";

		// Token: 0x04000C09 RID: 3081
		private const string FILE = "s.数据收集异常活动.xlsx";

		// Token: 0x04000C0A RID: 3082
		private const string TABLE = "CorniceChallenge";

		// Token: 0x04000C0B RID: 3083
		private const string COMMAND = "select BinData from `CorniceChallenge` where MarkId=?";

		// Token: 0x04000C0C RID: 3084
		private const string KEY_PREFIX = "CorniceChallengeByMarkId";

		// Token: 0x04000C0D RID: 3085
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C0E RID: 3086
		private static int HandleId;
	}
}
