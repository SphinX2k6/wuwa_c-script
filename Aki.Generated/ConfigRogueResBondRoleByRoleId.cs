using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000835 RID: 2101
	public class ConfigRogueResBondRoleByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003150 RID: 12624 RVA: 0x001702EF File Offset: 0x0016E4EF
		static ConfigRogueResBondRoleByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResBondRoleByRoleId.CreateStaticDefaultValue), new Action(ConfigRogueResBondRoleByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x00170310 File Offset: 0x0016E510
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResBondRoleByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResBondRoleByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResBondRole"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResBondRole` where RoleId=?")
			});
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x0017038F File Offset: 0x0016E58F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResBondRoleByRoleId.LogPair = null;
			ConfigRogueResBondRoleByRoleId.HandleId = 0;
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x0017039D File Offset: 0x0016E59D
		public static void Init()
		{
			ConfigRogueResBondRoleByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResBondRoleByRoleId.HandleId, "db_permanentrogue.db", "select BinData from `RogueResBondRole` where RoleId=?");
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x001703B8 File Offset: 0x0016E5B8
		public static RogueResBondRole? GetConfig(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResBondRoleByRoleId.HandleId, ConfigRogueResBondRoleByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResBondRoleByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResBondRole?(RogueResBondRole.GetRootAsRogueResBondRole(configBuffer));
				}
			}
			ConfigRogueResBondRoleByRoleId.LogPair.Clear();
			ConfigRogueResBondRoleByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigRogueResBondRoleByRoleId.HandleId, 1, p0RoleId, ConfigRogueResBondRoleByRoleId.LogPair) || ConfigCommon.Step(ConfigRogueResBondRoleByRoleId.HandleId, true, ConfigRogueResBondRoleByRoleId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResBondRoleByRoleId.HandleId, ConfigRogueResBondRoleByRoleId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResBondRoleByRoleId.HandleId, 0, ConfigRogueResBondRoleByRoleId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResBondRoleByRoleId.HandleId, ConfigRogueResBondRoleByRoleId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResBondRole rootAsRogueResBondRole = RogueResBondRole.GetRootAsRogueResBondRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResBondRoleByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResBondRoleByRoleId.HandleId, ConfigRogueResBondRoleByRoleId.LogPair);
			return new RogueResBondRole?(rootAsRogueResBondRole);
		}

		// Token: 0x04003959 RID: 14681
		private const string DB = "db_permanentrogue.db";

		// Token: 0x0400395A RID: 14682
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x0400395B RID: 14683
		private const string TABLE = "RogueResBondRole";

		// Token: 0x0400395C RID: 14684
		private const string COMMAND = "select BinData from `RogueResBondRole` where RoleId=?";

		// Token: 0x0400395D RID: 14685
		private const string KEY_PREFIX = "RogueResBondRoleByRoleId";

		// Token: 0x0400395E RID: 14686
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400395F RID: 14687
		private static int HandleId;
	}
}
