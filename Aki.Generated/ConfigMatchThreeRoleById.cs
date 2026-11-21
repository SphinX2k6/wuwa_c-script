using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200054C RID: 1356
	public class ConfigMatchThreeRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FD3 RID: 8147 RVA: 0x00110B8B File Offset: 0x0010ED8B
		static ConfigMatchThreeRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeRoleById.CreateStaticDefaultValue), new Action(ConfigMatchThreeRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x00110BAC File Offset: 0x0010EDAC
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

		// Token: 0x06001FD5 RID: 8149 RVA: 0x00110C2B File Offset: 0x0010EE2B
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeRoleById.LogPair = null;
			ConfigMatchThreeRoleById.HandleId = 0;
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x00110C39 File Offset: 0x0010EE39
		public static void Init()
		{
			ConfigMatchThreeRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeRoleById.HandleId, "db_activitymatchthree.db", "select BinData from `MatchThreeRole` where Id=?");
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x00110C54 File Offset: 0x0010EE54
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

		// Token: 0x040024F8 RID: 9464
		private const string DB = "db_activitymatchthree.db";

		// Token: 0x040024F9 RID: 9465
		private const string FILE = "s.三消活动.xlsx";

		// Token: 0x040024FA RID: 9466
		private const string TABLE = "MatchThreeRole";

		// Token: 0x040024FB RID: 9467
		private const string COMMAND = "select BinData from `MatchThreeRole` where Id=?";

		// Token: 0x040024FC RID: 9468
		private const string KEY_PREFIX = "MatchThreeRoleById";

		// Token: 0x040024FD RID: 9469
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024FE RID: 9470
		private static int HandleId;
	}
}
