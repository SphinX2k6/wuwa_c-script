using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000062 RID: 98
	public class ConfigAdventureRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600024C RID: 588 RVA: 0x0006A31B File Offset: 0x0006851B
		static ConfigAdventureRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdventureRoleById.CreateStaticDefaultValue), new Action(ConfigAdventureRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0006A33C File Offset: 0x0006853C
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

		// Token: 0x0600024E RID: 590 RVA: 0x0006A3BB File Offset: 0x000685BB
		public static void ResetStaticDefaultValue()
		{
			ConfigAdventureRoleById.LogPair = null;
			ConfigAdventureRoleById.HandleId = 0;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0006A3C9 File Offset: 0x000685C9
		public static void Init()
		{
			ConfigAdventureRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigAdventureRoleById.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `AdventureRole` where RoleId=?");
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0006A3E4 File Offset: 0x000685E4
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

		// Token: 0x04000292 RID: 658
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x04000293 RID: 659
		private const string FILE = "x.新手开拓任务活动.xlsx";

		// Token: 0x04000294 RID: 660
		private const string TABLE = "AdventureRole";

		// Token: 0x04000295 RID: 661
		private const string COMMAND = "select BinData from `AdventureRole` where RoleId=?";

		// Token: 0x04000296 RID: 662
		private const string KEY_PREFIX = "AdventureRoleById";

		// Token: 0x04000297 RID: 663
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000298 RID: 664
		private static int HandleId;
	}
}
