using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008F4 RID: 2292
	public class ConfigRoleTowerFloorById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035CB RID: 13771 RVA: 0x0018CCFF File Offset: 0x0018AEFF
		static ConfigRoleTowerFloorById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerFloorById.CreateStaticDefaultValue), new Action(ConfigRoleTowerFloorById.ResetStaticDefaultValue));
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x0018CD20 File Offset: 0x0018AF20
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerFloorById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerFloorById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerFloor"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerFloor` where Id=?")
			});
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x0018CD9F File Offset: 0x0018AF9F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerFloorById.LogPair = null;
			ConfigRoleTowerFloorById.HandleId = 0;
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x0018CDAD File Offset: 0x0018AFAD
		public static void Init()
		{
			ConfigRoleTowerFloorById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerFloorById.HandleId, "db_roletower.db", "select BinData from `RoleTowerFloor` where Id=?");
		}

		// Token: 0x060035CF RID: 13775 RVA: 0x0018CDC8 File Offset: 0x0018AFC8
		public static RoleTowerFloor? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerFloorById.HandleId, ConfigRoleTowerFloorById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerFloorById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTowerFloor?(RoleTowerFloor.GetRootAsRoleTowerFloor(configBuffer));
				}
			}
			ConfigRoleTowerFloorById.LogPair.Clear();
			ConfigRoleTowerFloorById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleTowerFloorById.HandleId, 1, p0Id, ConfigRoleTowerFloorById.LogPair) || ConfigCommon.Step(ConfigRoleTowerFloorById.HandleId, true, ConfigRoleTowerFloorById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTowerFloorById.HandleId, ConfigRoleTowerFloorById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerFloorById.HandleId, 0, ConfigRoleTowerFloorById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTowerFloorById.HandleId, ConfigRoleTowerFloorById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTowerFloor rootAsRoleTowerFloor = RoleTowerFloor.GetRootAsRoleTowerFloor(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerFloorById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTowerFloorById.HandleId, ConfigRoleTowerFloorById.LogPair);
			return new RoleTowerFloor?(rootAsRoleTowerFloor);
		}

		// Token: 0x04003E92 RID: 16018
		private const string DB = "db_roletower.db";

		// Token: 0x04003E93 RID: 16019
		private const string FILE = "j.角色爬塔_关卡.xlsx";

		// Token: 0x04003E94 RID: 16020
		private const string TABLE = "RoleTowerFloor";

		// Token: 0x04003E95 RID: 16021
		private const string COMMAND = "select BinData from `RoleTowerFloor` where Id=?";

		// Token: 0x04003E96 RID: 16022
		private const string KEY_PREFIX = "RoleTowerFloorById";

		// Token: 0x04003E97 RID: 16023
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E98 RID: 16024
		private static int HandleId;
	}
}
