using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000BC RID: 188
	public class ConfigAutoRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000469 RID: 1129 RVA: 0x00072AB3 File Offset: 0x00070CB3
		static ConfigAutoRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAutoRoleById.CreateStaticDefaultValue), new Action(ConfigAutoRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00072AD4 File Offset: 0x00070CD4
		public static void CreateStaticDefaultValue()
		{
			ConfigAutoRoleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAutoRoleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "AutoRole"),
				new ValueTuple<string, object>("语句", "select BinData from `AutoRole` where Id = ?")
			});
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00072B53 File Offset: 0x00070D53
		public static void ResetStaticDefaultValue()
		{
			ConfigAutoRoleById.LogPair = null;
			ConfigAutoRoleById.HandleId = 0;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00072B61 File Offset: 0x00070D61
		public static void Init()
		{
			ConfigAutoRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigAutoRoleById.HandleId, "db_role.db", "select BinData from `AutoRole` where Id = ?");
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00072B7C File Offset: 0x00070D7C
		public static AutoRole? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAutoRoleById.HandleId, ConfigAutoRoleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AutoRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AutoRole?(AutoRole.GetRootAsAutoRole(configBuffer));
				}
			}
			ConfigAutoRoleById.LogPair.Clear();
			ConfigAutoRoleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAutoRoleById.HandleId, 1, p0Id, ConfigAutoRoleById.LogPair) || ConfigCommon.Step(ConfigAutoRoleById.HandleId, true, ConfigAutoRoleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAutoRoleById.HandleId, ConfigAutoRoleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAutoRoleById.HandleId, 0, ConfigAutoRoleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAutoRoleById.HandleId, ConfigAutoRoleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AutoRole rootAsAutoRole = AutoRole.GetRootAsAutoRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AutoRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAutoRoleById.HandleId, ConfigAutoRoleById.LogPair);
			return new AutoRole?(rootAsAutoRole);
		}

		// Token: 0x04000508 RID: 1288
		private const string DB = "db_role.db";

		// Token: 0x04000509 RID: 1289
		private const string FILE = "j.角色.xlsx";

		// Token: 0x0400050A RID: 1290
		private const string TABLE = "AutoRole";

		// Token: 0x0400050B RID: 1291
		private const string COMMAND = "select BinData from `AutoRole` where Id = ?";

		// Token: 0x0400050C RID: 1292
		private const string KEY_PREFIX = "AutoRoleById";

		// Token: 0x0400050D RID: 1293
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400050E RID: 1294
		private static int HandleId;
	}
}
