using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000C4 RID: 196
	public class ConfigAutoRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000499 RID: 1177 RVA: 0x00077367 File Offset: 0x00075567
		static ConfigAutoRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAutoRoleById.CreateStaticDefaultValue), new Action(ConfigAutoRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00077388 File Offset: 0x00075588
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

		// Token: 0x0600049B RID: 1179 RVA: 0x00077407 File Offset: 0x00075607
		public static void ResetStaticDefaultValue()
		{
			ConfigAutoRoleById.LogPair = null;
			ConfigAutoRoleById.HandleId = 0;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00077415 File Offset: 0x00075615
		public static void Init()
		{
			ConfigAutoRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigAutoRoleById.HandleId, "db_role.db", "select BinData from `AutoRole` where Id = ?");
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00077430 File Offset: 0x00075630
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

		// Token: 0x04000540 RID: 1344
		private const string DB = "db_role.db";

		// Token: 0x04000541 RID: 1345
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04000542 RID: 1346
		private const string TABLE = "AutoRole";

		// Token: 0x04000543 RID: 1347
		private const string COMMAND = "select BinData from `AutoRole` where Id = ?";

		// Token: 0x04000544 RID: 1348
		private const string KEY_PREFIX = "AutoRoleById";

		// Token: 0x04000545 RID: 1349
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000546 RID: 1350
		private static int HandleId;
	}
}
