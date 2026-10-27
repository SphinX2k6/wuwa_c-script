using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008CF RID: 2255
	public class ConfigRoleTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034ED RID: 13549 RVA: 0x001847CB File Offset: 0x001829CB
		static ConfigRoleTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTagById.CreateStaticDefaultValue), new Action(ConfigRoleTagById.ResetStaticDefaultValue));
		}

		// Token: 0x060034EE RID: 13550 RVA: 0x001847EC File Offset: 0x001829EC
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTag"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTag` where Id=?")
			});
		}

		// Token: 0x060034EF RID: 13551 RVA: 0x0018486B File Offset: 0x00182A6B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTagById.LogPair = null;
			ConfigRoleTagById.HandleId = 0;
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x00184879 File Offset: 0x00182A79
		public static void Init()
		{
			ConfigRoleTagById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTagById.HandleId, "db_role.db", "select BinData from `RoleTag` where Id=?");
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x00184894 File Offset: 0x00182A94
		public static RoleTag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTagById.HandleId, ConfigRoleTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTag?(RoleTag.GetRootAsRoleTag(configBuffer));
				}
			}
			ConfigRoleTagById.LogPair.Clear();
			ConfigRoleTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleTagById.HandleId, 1, p0Id, ConfigRoleTagById.LogPair) || ConfigCommon.Step(ConfigRoleTagById.HandleId, true, ConfigRoleTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTagById.HandleId, ConfigRoleTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTagById.HandleId, 0, ConfigRoleTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTagById.HandleId, ConfigRoleTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTag rootAsRoleTag = RoleTag.GetRootAsRoleTag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTagById.HandleId, ConfigRoleTagById.LogPair);
			return new RoleTag?(rootAsRoleTag);
		}

		// Token: 0x04003D8F RID: 15759
		private const string DB = "db_role.db";

		// Token: 0x04003D90 RID: 15760
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003D91 RID: 15761
		private const string TABLE = "RoleTag";

		// Token: 0x04003D92 RID: 15762
		private const string COMMAND = "select BinData from `RoleTag` where Id=?";

		// Token: 0x04003D93 RID: 15763
		private const string KEY_PREFIX = "RoleTagById";

		// Token: 0x04003D94 RID: 15764
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D95 RID: 15765
		private static int HandleId;
	}
}
