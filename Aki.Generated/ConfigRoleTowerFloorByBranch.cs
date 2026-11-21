using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008F2 RID: 2290
	public class ConfigRoleTowerFloorByBranch : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035BF RID: 13759 RVA: 0x0018C87F File Offset: 0x0018AA7F
		static ConfigRoleTowerFloorByBranch()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerFloorByBranch.CreateStaticDefaultValue), new Action(ConfigRoleTowerFloorByBranch.ResetStaticDefaultValue));
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x0018C8A0 File Offset: 0x0018AAA0
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerFloorByBranch.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerFloorByBranch.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerFloor"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerFloor` where Branch=?")
			});
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x0018C91F File Offset: 0x0018AB1F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerFloorByBranch.LogPair = null;
			ConfigRoleTowerFloorByBranch.HandleId = 0;
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x0018C92D File Offset: 0x0018AB2D
		public static void Init()
		{
			ConfigRoleTowerFloorByBranch.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerFloorByBranch.HandleId, "db_roletower.db", "select BinData from `RoleTowerFloor` where Branch=?");
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x0018C948 File Offset: 0x0018AB48
		public static RoleTowerFloor? GetConfig(int p0Branch, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerFloorByBranch.HandleId, ConfigRoleTowerFloorByBranch.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerFloorByBranch");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Branch);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTowerFloor?(RoleTowerFloor.GetRootAsRoleTowerFloor(configBuffer));
				}
			}
			ConfigRoleTowerFloorByBranch.LogPair.Clear();
			ConfigRoleTowerFloorByBranch.LogPair.Add(new ValueTuple<string, object>("Branch", p0Branch));
			if (!ConfigCommon.BindInt(ConfigRoleTowerFloorByBranch.HandleId, 1, p0Branch, ConfigRoleTowerFloorByBranch.LogPair) || ConfigCommon.Step(ConfigRoleTowerFloorByBranch.HandleId, true, ConfigRoleTowerFloorByBranch.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTowerFloorByBranch.HandleId, ConfigRoleTowerFloorByBranch.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerFloorByBranch.HandleId, 0, ConfigRoleTowerFloorByBranch.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTowerFloorByBranch.HandleId, ConfigRoleTowerFloorByBranch.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTowerFloor rootAsRoleTowerFloor = RoleTowerFloor.GetRootAsRoleTowerFloor(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerFloorByBranch");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Branch);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTowerFloorByBranch.HandleId, ConfigRoleTowerFloorByBranch.LogPair);
			return new RoleTowerFloor?(rootAsRoleTowerFloor);
		}

		// Token: 0x04003E84 RID: 16004
		private const string DB = "db_roletower.db";

		// Token: 0x04003E85 RID: 16005
		private const string FILE = "j.角色爬塔_关卡.xlsx";

		// Token: 0x04003E86 RID: 16006
		private const string TABLE = "RoleTowerFloor";

		// Token: 0x04003E87 RID: 16007
		private const string COMMAND = "select BinData from `RoleTowerFloor` where Branch=?";

		// Token: 0x04003E88 RID: 16008
		private const string KEY_PREFIX = "RoleTowerFloorByBranch";

		// Token: 0x04003E89 RID: 16009
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E8A RID: 16010
		private static int HandleId;
	}
}
