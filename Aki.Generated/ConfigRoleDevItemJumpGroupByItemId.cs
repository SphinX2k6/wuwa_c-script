using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000897 RID: 2199
	public class ConfigRoleDevItemJumpGroupByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600339C RID: 13212 RVA: 0x0017D197 File Offset: 0x0017B397
		static ConfigRoleDevItemJumpGroupByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevItemJumpGroupByItemId.CreateStaticDefaultValue), new Action(ConfigRoleDevItemJumpGroupByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x0017D1B8 File Offset: 0x0017B3B8
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevItemJumpGroupByItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevItemJumpGroupByItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevItemJumpGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevItemJumpGroup` where ItemId=?")
			});
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x0017D237 File Offset: 0x0017B437
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevItemJumpGroupByItemId.LogPair = null;
			ConfigRoleDevItemJumpGroupByItemId.HandleId = 0;
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x0017D245 File Offset: 0x0017B445
		public static void Init()
		{
			ConfigRoleDevItemJumpGroupByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevItemJumpGroupByItemId.HandleId, "db_roledev.db", "select BinData from `RoleDevItemJumpGroup` where ItemId=?");
		}

		// Token: 0x060033A0 RID: 13216 RVA: 0x0017D260 File Offset: 0x0017B460
		public static RoleDevItemJumpGroup? GetConfig(int p0ItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevItemJumpGroupByItemId.HandleId, ConfigRoleDevItemJumpGroupByItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevItemJumpGroupByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleDevItemJumpGroup?(RoleDevItemJumpGroup.GetRootAsRoleDevItemJumpGroup(configBuffer));
				}
			}
			ConfigRoleDevItemJumpGroupByItemId.LogPair.Clear();
			ConfigRoleDevItemJumpGroupByItemId.LogPair.Add(new ValueTuple<string, object>("ItemId", p0ItemId));
			if (!ConfigCommon.BindInt(ConfigRoleDevItemJumpGroupByItemId.HandleId, 1, p0ItemId, ConfigRoleDevItemJumpGroupByItemId.LogPair) || ConfigCommon.Step(ConfigRoleDevItemJumpGroupByItemId.HandleId, true, ConfigRoleDevItemJumpGroupByItemId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleDevItemJumpGroupByItemId.HandleId, ConfigRoleDevItemJumpGroupByItemId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevItemJumpGroupByItemId.HandleId, 0, ConfigRoleDevItemJumpGroupByItemId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleDevItemJumpGroupByItemId.HandleId, ConfigRoleDevItemJumpGroupByItemId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleDevItemJumpGroup rootAsRoleDevItemJumpGroup = RoleDevItemJumpGroup.GetRootAsRoleDevItemJumpGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevItemJumpGroupByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleDevItemJumpGroupByItemId.HandleId, ConfigRoleDevItemJumpGroupByItemId.LogPair);
			return new RoleDevItemJumpGroup?(rootAsRoleDevItemJumpGroup);
		}

		// Token: 0x04003C07 RID: 15367
		private const string DB = "db_roledev.db";

		// Token: 0x04003C08 RID: 15368
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003C09 RID: 15369
		private const string TABLE = "RoleDevItemJumpGroup";

		// Token: 0x04003C0A RID: 15370
		private const string COMMAND = "select BinData from `RoleDevItemJumpGroup` where ItemId=?";

		// Token: 0x04003C0B RID: 15371
		private const string KEY_PREFIX = "RoleDevItemJumpGroupByItemId";

		// Token: 0x04003C0C RID: 15372
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C0D RID: 15373
		private static int HandleId;
	}
}
