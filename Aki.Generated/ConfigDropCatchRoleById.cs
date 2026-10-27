using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200023E RID: 574
	public class ConfigDropCatchRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D78 RID: 3448 RVA: 0x000A5AA4 File Offset: 0x000A3CA4
		static ConfigDropCatchRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropCatchRoleById.CreateStaticDefaultValue), new Action(ConfigDropCatchRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x000A5AC4 File Offset: 0x000A3CC4
		public static void CreateStaticDefaultValue()
		{
			ConfigDropCatchRoleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDropCatchRoleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dropcatch.db"),
				new ValueTuple<string, object>("文件", "j.接金币活动.xlsx"),
				new ValueTuple<string, object>("表名", "DropCatchRole"),
				new ValueTuple<string, object>("语句", "select BinData from `DropCatchRole` where Id=?")
			});
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x000A5B43 File Offset: 0x000A3D43
		public static void ResetStaticDefaultValue()
		{
			ConfigDropCatchRoleById.LogPair = null;
			ConfigDropCatchRoleById.HandleId = 0;
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x000A5B51 File Offset: 0x000A3D51
		public static void Init()
		{
			ConfigDropCatchRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigDropCatchRoleById.HandleId, "db_dropcatch.db", "select BinData from `DropCatchRole` where Id=?");
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x000A5B6C File Offset: 0x000A3D6C
		public static DropCatchRole? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDropCatchRoleById.HandleId, ConfigDropCatchRoleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DropCatchRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DropCatchRole?(DropCatchRole.GetRootAsDropCatchRole(configBuffer));
				}
			}
			ConfigDropCatchRoleById.LogPair.Clear();
			ConfigDropCatchRoleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDropCatchRoleById.HandleId, 1, p0Id, ConfigDropCatchRoleById.LogPair) || ConfigCommon.Step(ConfigDropCatchRoleById.HandleId, true, ConfigDropCatchRoleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDropCatchRoleById.HandleId, ConfigDropCatchRoleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDropCatchRoleById.HandleId, 0, ConfigDropCatchRoleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDropCatchRoleById.HandleId, ConfigDropCatchRoleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DropCatchRole rootAsDropCatchRole = DropCatchRole.GetRootAsDropCatchRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DropCatchRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDropCatchRoleById.HandleId, ConfigDropCatchRoleById.LogPair);
			return new DropCatchRole?(rootAsDropCatchRole);
		}

		// Token: 0x04000F96 RID: 3990
		private const string DB = "db_dropcatch.db";

		// Token: 0x04000F97 RID: 3991
		private const string FILE = "j.接金币活动.xlsx";

		// Token: 0x04000F98 RID: 3992
		private const string TABLE = "DropCatchRole";

		// Token: 0x04000F99 RID: 3993
		private const string COMMAND = "select BinData from `DropCatchRole` where Id=?";

		// Token: 0x04000F9A RID: 3994
		private const string KEY_PREFIX = "DropCatchRoleById";

		// Token: 0x04000F9B RID: 3995
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F9C RID: 3996
		private static int HandleId;
	}
}
