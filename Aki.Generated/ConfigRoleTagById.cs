using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008EB RID: 2283
	public class ConfigRoleTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003595 RID: 13717 RVA: 0x0018BAB3 File Offset: 0x00189CB3
		static ConfigRoleTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTagById.CreateStaticDefaultValue), new Action(ConfigRoleTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06003596 RID: 13718 RVA: 0x0018BAD4 File Offset: 0x00189CD4
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

		// Token: 0x06003597 RID: 13719 RVA: 0x0018BB53 File Offset: 0x00189D53
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTagById.LogPair = null;
			ConfigRoleTagById.HandleId = 0;
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x0018BB61 File Offset: 0x00189D61
		public static void Init()
		{
			ConfigRoleTagById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTagById.HandleId, "db_role.db", "select BinData from `RoleTag` where Id=?");
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x0018BB7C File Offset: 0x00189D7C
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

		// Token: 0x04003E53 RID: 15955
		private const string DB = "db_role.db";

		// Token: 0x04003E54 RID: 15956
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003E55 RID: 15957
		private const string TABLE = "RoleTag";

		// Token: 0x04003E56 RID: 15958
		private const string COMMAND = "select BinData from `RoleTag` where Id=?";

		// Token: 0x04003E57 RID: 15959
		private const string KEY_PREFIX = "RoleTagById";

		// Token: 0x04003E58 RID: 15960
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E59 RID: 15961
		private static int HandleId;
	}
}
