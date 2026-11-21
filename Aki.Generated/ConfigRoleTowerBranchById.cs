using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008ED RID: 2285
	public class ConfigRoleTowerBranchById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035A1 RID: 13729 RVA: 0x0018BE8F File Offset: 0x0018A08F
		static ConfigRoleTowerBranchById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerBranchById.CreateStaticDefaultValue), new Action(ConfigRoleTowerBranchById.ResetStaticDefaultValue));
		}

		// Token: 0x060035A2 RID: 13730 RVA: 0x0018BEB0 File Offset: 0x0018A0B0
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerBranchById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerBranchById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerBranch"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerBranch` where Id=?")
			});
		}

		// Token: 0x060035A3 RID: 13731 RVA: 0x0018BF2F File Offset: 0x0018A12F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerBranchById.LogPair = null;
			ConfigRoleTowerBranchById.HandleId = 0;
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x0018BF3D File Offset: 0x0018A13D
		public static void Init()
		{
			ConfigRoleTowerBranchById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerBranchById.HandleId, "db_roletower.db", "select BinData from `RoleTowerBranch` where Id=?");
		}

		// Token: 0x060035A5 RID: 13733 RVA: 0x0018BF58 File Offset: 0x0018A158
		public static RoleTowerBranch? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerBranchById.HandleId, ConfigRoleTowerBranchById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerBranchById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTowerBranch?(RoleTowerBranch.GetRootAsRoleTowerBranch(configBuffer));
				}
			}
			ConfigRoleTowerBranchById.LogPair.Clear();
			ConfigRoleTowerBranchById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleTowerBranchById.HandleId, 1, p0Id, ConfigRoleTowerBranchById.LogPair) || ConfigCommon.Step(ConfigRoleTowerBranchById.HandleId, true, ConfigRoleTowerBranchById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTowerBranchById.HandleId, ConfigRoleTowerBranchById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerBranchById.HandleId, 0, ConfigRoleTowerBranchById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTowerBranchById.HandleId, ConfigRoleTowerBranchById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTowerBranch rootAsRoleTowerBranch = RoleTowerBranch.GetRootAsRoleTowerBranch(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerBranchById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTowerBranchById.HandleId, ConfigRoleTowerBranchById.LogPair);
			return new RoleTowerBranch?(rootAsRoleTowerBranch);
		}

		// Token: 0x04003E61 RID: 15969
		private const string DB = "db_roletower.db";

		// Token: 0x04003E62 RID: 15970
		private const string FILE = "j.角色爬塔_关卡.xlsx";

		// Token: 0x04003E63 RID: 15971
		private const string TABLE = "RoleTowerBranch";

		// Token: 0x04003E64 RID: 15972
		private const string COMMAND = "select BinData from `RoleTowerBranch` where Id=?";

		// Token: 0x04003E65 RID: 15973
		private const string KEY_PREFIX = "RoleTowerBranchById";

		// Token: 0x04003E66 RID: 15974
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E67 RID: 15975
		private static int HandleId;
	}
}
