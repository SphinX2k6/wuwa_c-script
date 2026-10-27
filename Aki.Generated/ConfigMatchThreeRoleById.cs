using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000536 RID: 1334
	public class ConfigMatchThreeRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F4F RID: 8015 RVA: 0x0010A437 File Offset: 0x00108637
		static ConfigMatchThreeRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeRoleById.CreateStaticDefaultValue), new Action(ConfigMatchThreeRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x0010A458 File Offset: 0x00108658
		public static void CreateStaticDefaultValue()
		{
			ConfigMatchThreeRoleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMatchThreeRoleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitymatchthree.db"),
				new ValueTuple<string, object>("文件", "s.三消活动.xlsx"),
				new ValueTuple<string, object>("表名", "MatchThreeRole"),
				new ValueTuple<string, object>("语句", "select BinData from `MatchThreeRole` where Id=?")
			});
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x0010A4D7 File Offset: 0x001086D7
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeRoleById.LogPair = null;
			ConfigMatchThreeRoleById.HandleId = 0;
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x0010A4E5 File Offset: 0x001086E5
		public static void Init()
		{
			ConfigMatchThreeRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeRoleById.HandleId, "db_activitymatchthree.db", "select BinData from `MatchThreeRole` where Id=?");
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x0010A500 File Offset: 0x00108700
		public static MatchThreeRole? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMatchThreeRoleById.HandleId, ConfigMatchThreeRoleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MatchThreeRole?(MatchThreeRole.GetRootAsMatchThreeRole(configBuffer));
				}
			}
			ConfigMatchThreeRoleById.LogPair.Clear();
			ConfigMatchThreeRoleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMatchThreeRoleById.HandleId, 1, p0Id, ConfigMatchThreeRoleById.LogPair) || ConfigCommon.Step(ConfigMatchThreeRoleById.HandleId, true, ConfigMatchThreeRoleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMatchThreeRoleById.HandleId, ConfigMatchThreeRoleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMatchThreeRoleById.HandleId, 0, ConfigMatchThreeRoleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMatchThreeRoleById.HandleId, ConfigMatchThreeRoleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MatchThreeRole rootAsMatchThreeRole = MatchThreeRole.GetRootAsMatchThreeRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMatchThreeRoleById.HandleId, ConfigMatchThreeRoleById.LogPair);
			return new MatchThreeRole?(rootAsMatchThreeRole);
		}

		// Token: 0x0400245E RID: 9310
		private const string DB = "db_activitymatchthree.db";

		// Token: 0x0400245F RID: 9311
		private const string FILE = "s.三消活动.xlsx";

		// Token: 0x04002460 RID: 9312
		private const string TABLE = "MatchThreeRole";

		// Token: 0x04002461 RID: 9313
		private const string COMMAND = "select BinData from `MatchThreeRole` where Id=?";

		// Token: 0x04002462 RID: 9314
		private const string KEY_PREFIX = "MatchThreeRoleById";

		// Token: 0x04002463 RID: 9315
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002464 RID: 9316
		private static int HandleId;
	}
}
