using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008B3 RID: 2227
	public class ConfigRoleDevItemJumpGroupByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003444 RID: 13380 RVA: 0x0018447F File Offset: 0x0018267F
		static ConfigRoleDevItemJumpGroupByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevItemJumpGroupByItemId.CreateStaticDefaultValue), new Action(ConfigRoleDevItemJumpGroupByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06003445 RID: 13381 RVA: 0x001844A0 File Offset: 0x001826A0
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

		// Token: 0x06003446 RID: 13382 RVA: 0x0018451F File Offset: 0x0018271F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevItemJumpGroupByItemId.LogPair = null;
			ConfigRoleDevItemJumpGroupByItemId.HandleId = 0;
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x0018452D File Offset: 0x0018272D
		public static void Init()
		{
			ConfigRoleDevItemJumpGroupByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevItemJumpGroupByItemId.HandleId, "db_roledev.db", "select BinData from `RoleDevItemJumpGroup` where ItemId=?");
		}

		// Token: 0x06003448 RID: 13384 RVA: 0x00184548 File Offset: 0x00182748
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

		// Token: 0x04003CCB RID: 15563
		private const string DB = "db_roledev.db";

		// Token: 0x04003CCC RID: 15564
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003CCD RID: 15565
		private const string TABLE = "RoleDevItemJumpGroup";

		// Token: 0x04003CCE RID: 15566
		private const string COMMAND = "select BinData from `RoleDevItemJumpGroup` where ItemId=?";

		// Token: 0x04003CCF RID: 15567
		private const string KEY_PREFIX = "RoleDevItemJumpGroupByItemId";

		// Token: 0x04003CD0 RID: 15568
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CD1 RID: 15569
		private static int HandleId;
	}
}
