using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008AB RID: 2219
	public class ConfigRoleDescriptionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003414 RID: 13332 RVA: 0x0018346D File Offset: 0x0018166D
		static ConfigRoleDescriptionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDescriptionById.CreateStaticDefaultValue), new Action(ConfigRoleDescriptionById.ResetStaticDefaultValue));
		}

		// Token: 0x06003415 RID: 13333 RVA: 0x0018348C File Offset: 0x0018168C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDescriptionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDescriptionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledescription.db"),
				new ValueTuple<string, object>("文件", "j.角色介绍.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDescription"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDescription` where Id=?")
			});
		}

		// Token: 0x06003416 RID: 13334 RVA: 0x0018350B File Offset: 0x0018170B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDescriptionById.LogPair = null;
			ConfigRoleDescriptionById.HandleId = 0;
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x00183519 File Offset: 0x00181719
		public static void Init()
		{
			ConfigRoleDescriptionById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDescriptionById.HandleId, "db_roledescription.db", "select BinData from `RoleDescription` where Id=?");
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x00183534 File Offset: 0x00181734
		public static RoleDescription? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDescriptionById.HandleId, ConfigRoleDescriptionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDescriptionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleDescription?(RoleDescription.GetRootAsRoleDescription(configBuffer));
				}
			}
			ConfigRoleDescriptionById.LogPair.Clear();
			ConfigRoleDescriptionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleDescriptionById.HandleId, 1, p0Id, ConfigRoleDescriptionById.LogPair) || ConfigCommon.Step(ConfigRoleDescriptionById.HandleId, true, ConfigRoleDescriptionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleDescriptionById.HandleId, ConfigRoleDescriptionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDescriptionById.HandleId, 0, ConfigRoleDescriptionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleDescriptionById.HandleId, ConfigRoleDescriptionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleDescription rootAsRoleDescription = RoleDescription.GetRootAsRoleDescription(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDescriptionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleDescriptionById.HandleId, ConfigRoleDescriptionById.LogPair);
			return new RoleDescription?(rootAsRoleDescription);
		}

		// Token: 0x04003C93 RID: 15507
		private const string DB = "db_roledescription.db";

		// Token: 0x04003C94 RID: 15508
		private const string FILE = "j.角色介绍.xlsx";

		// Token: 0x04003C95 RID: 15509
		private const string TABLE = "RoleDescription";

		// Token: 0x04003C96 RID: 15510
		private const string COMMAND = "select BinData from `RoleDescription` where Id=?";

		// Token: 0x04003C97 RID: 15511
		private const string KEY_PREFIX = "RoleDescriptionById";

		// Token: 0x04003C98 RID: 15512
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C99 RID: 15513
		private static int HandleId;
	}
}
