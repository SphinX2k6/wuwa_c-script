using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008D8 RID: 2264
	public class ConfigRoleQualityInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003523 RID: 13603 RVA: 0x001890B1 File Offset: 0x001872B1
		static ConfigRoleQualityInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleQualityInfoById.CreateStaticDefaultValue), new Action(ConfigRoleQualityInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06003524 RID: 13604 RVA: 0x001890D0 File Offset: 0x001872D0
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleQualityInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleQualityInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleQualityInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleQualityInfo` where Id=?")
			});
		}

		// Token: 0x06003525 RID: 13605 RVA: 0x0018914F File Offset: 0x0018734F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleQualityInfoById.LogPair = null;
			ConfigRoleQualityInfoById.HandleId = 0;
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x0018915D File Offset: 0x0018735D
		public static void Init()
		{
			ConfigRoleQualityInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleQualityInfoById.HandleId, "db_role.db", "select BinData from `RoleQualityInfo` where Id=?");
		}

		// Token: 0x06003527 RID: 13607 RVA: 0x00189178 File Offset: 0x00187378
		public static RoleQualityInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleQualityInfoById.HandleId, ConfigRoleQualityInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleQualityInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleQualityInfo?(RoleQualityInfo.GetRootAsRoleQualityInfo(configBuffer));
				}
			}
			ConfigRoleQualityInfoById.LogPair.Clear();
			ConfigRoleQualityInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleQualityInfoById.HandleId, 1, p0Id, ConfigRoleQualityInfoById.LogPair) || ConfigCommon.Step(ConfigRoleQualityInfoById.HandleId, true, ConfigRoleQualityInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleQualityInfoById.HandleId, ConfigRoleQualityInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleQualityInfoById.HandleId, 0, ConfigRoleQualityInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleQualityInfoById.HandleId, ConfigRoleQualityInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleQualityInfo rootAsRoleQualityInfo = RoleQualityInfo.GetRootAsRoleQualityInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleQualityInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleQualityInfoById.HandleId, ConfigRoleQualityInfoById.LogPair);
			return new RoleQualityInfo?(rootAsRoleQualityInfo);
		}

		// Token: 0x04003DCE RID: 15822
		private const string DB = "db_role.db";

		// Token: 0x04003DCF RID: 15823
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003DD0 RID: 15824
		private const string TABLE = "RoleQualityInfo";

		// Token: 0x04003DD1 RID: 15825
		private const string COMMAND = "select BinData from `RoleQualityInfo` where Id=?";

		// Token: 0x04003DD2 RID: 15826
		private const string KEY_PREFIX = "RoleQualityInfoById";

		// Token: 0x04003DD3 RID: 15827
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DD4 RID: 15828
		private static int HandleId;
	}
}
