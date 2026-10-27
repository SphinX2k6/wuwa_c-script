using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200005A RID: 90
	public class ConfigAdventureRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600021C RID: 540 RVA: 0x00065A67 File Offset: 0x00063C67
		static ConfigAdventureRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdventureRoleById.CreateStaticDefaultValue), new Action(ConfigAdventureRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00065A88 File Offset: 0x00063C88
		public static void CreateStaticDefaultValue()
		{
			ConfigAdventureRoleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdventureRoleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newplayersupportactivityv2.db"),
				new ValueTuple<string, object>("文件", "x.新手开拓任务活动.xlsx"),
				new ValueTuple<string, object>("表名", "AdventureRole"),
				new ValueTuple<string, object>("语句", "select BinData from `AdventureRole` where RoleId=?")
			});
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00065B07 File Offset: 0x00063D07
		public static void ResetStaticDefaultValue()
		{
			ConfigAdventureRoleById.LogPair = null;
			ConfigAdventureRoleById.HandleId = 0;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00065B15 File Offset: 0x00063D15
		public static void Init()
		{
			ConfigAdventureRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigAdventureRoleById.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `AdventureRole` where RoleId=?");
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00065B30 File Offset: 0x00063D30
		public static AdventureRole? GetConfig(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdventureRoleById.HandleId, ConfigAdventureRoleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdventureRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdventureRole?(AdventureRole.GetRootAsAdventureRole(configBuffer));
				}
			}
			ConfigAdventureRoleById.LogPair.Clear();
			ConfigAdventureRoleById.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigAdventureRoleById.HandleId, 1, p0RoleId, ConfigAdventureRoleById.LogPair) || ConfigCommon.Step(ConfigAdventureRoleById.HandleId, true, ConfigAdventureRoleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdventureRoleById.HandleId, ConfigAdventureRoleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdventureRoleById.HandleId, 0, ConfigAdventureRoleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdventureRoleById.HandleId, ConfigAdventureRoleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdventureRole rootAsAdventureRole = AdventureRole.GetRootAsAdventureRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdventureRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdventureRoleById.HandleId, ConfigAdventureRoleById.LogPair);
			return new AdventureRole?(rootAsAdventureRole);
		}

		// Token: 0x0400025A RID: 602
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x0400025B RID: 603
		private const string FILE = "x.新手开拓任务活动.xlsx";

		// Token: 0x0400025C RID: 604
		private const string TABLE = "AdventureRole";

		// Token: 0x0400025D RID: 605
		private const string COMMAND = "select BinData from `AdventureRole` where RoleId=?";

		// Token: 0x0400025E RID: 606
		private const string KEY_PREFIX = "AdventureRoleById";

		// Token: 0x0400025F RID: 607
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000260 RID: 608
		private static int HandleId;
	}
}
