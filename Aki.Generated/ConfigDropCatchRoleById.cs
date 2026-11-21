using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000250 RID: 592
	public class ConfigDropCatchRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DE4 RID: 3556 RVA: 0x000AB9DC File Offset: 0x000A9BDC
		static ConfigDropCatchRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropCatchRoleById.CreateStaticDefaultValue), new Action(ConfigDropCatchRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x000AB9FC File Offset: 0x000A9BFC
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

		// Token: 0x06000DE6 RID: 3558 RVA: 0x000ABA7B File Offset: 0x000A9C7B
		public static void ResetStaticDefaultValue()
		{
			ConfigDropCatchRoleById.LogPair = null;
			ConfigDropCatchRoleById.HandleId = 0;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x000ABA89 File Offset: 0x000A9C89
		public static void Init()
		{
			ConfigDropCatchRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigDropCatchRoleById.HandleId, "db_dropcatch.db", "select BinData from `DropCatchRole` where Id=?");
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x000ABAA4 File Offset: 0x000A9CA4
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

		// Token: 0x04001014 RID: 4116
		private const string DB = "db_dropcatch.db";

		// Token: 0x04001015 RID: 4117
		private const string FILE = "j.接金币活动.xlsx";

		// Token: 0x04001016 RID: 4118
		private const string TABLE = "DropCatchRole";

		// Token: 0x04001017 RID: 4119
		private const string COMMAND = "select BinData from `DropCatchRole` where Id=?";

		// Token: 0x04001018 RID: 4120
		private const string KEY_PREFIX = "DropCatchRoleById";

		// Token: 0x04001019 RID: 4121
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400101A RID: 4122
		private static int HandleId;
	}
}
