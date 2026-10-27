using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008E2 RID: 2274
	public class ConfigRoverRogueBlessRoleByUnlockInsId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600355F RID: 13663 RVA: 0x00187054 File Offset: 0x00185254
		static ConfigRoverRogueBlessRoleByUnlockInsId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueBlessRoleByUnlockInsId.CreateStaticDefaultValue), new Action(ConfigRoverRogueBlessRoleByUnlockInsId.ResetStaticDefaultValue));
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x00187074 File Offset: 0x00185274
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueBlessRoleByUnlockInsId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueBlessRoleByUnlockInsId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueBlessRole"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueBlessRole` where UnlockInsId=?")
			});
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x001870F3 File Offset: 0x001852F3
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueBlessRoleByUnlockInsId.LogPair = null;
			ConfigRoverRogueBlessRoleByUnlockInsId.HandleId = 0;
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x00187101 File Offset: 0x00185301
		public static void Init()
		{
			ConfigRoverRogueBlessRoleByUnlockInsId.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueBlessRoleByUnlockInsId.HandleId, "db_roverlike.db", "select BinData from `RoverRogueBlessRole` where UnlockInsId=?");
		}

		// Token: 0x06003563 RID: 13667 RVA: 0x0018711C File Offset: 0x0018531C
		[NullableContext(2)]
		public static IReadOnlyList<RoverRogueBlessRole> GetConfigList(int p0UnlockInsId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueBlessRoleByUnlockInsId.HandleId, ConfigRoverRogueBlessRoleByUnlockInsId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueBlessRoleByUnlockInsId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0UnlockInsId);
				IReadOnlyList<RoverRogueBlessRole> readOnlyList = (IReadOnlyList<RoverRogueBlessRole>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoverRogueBlessRoleByUnlockInsId.LogPair.Clear();
			ConfigRoverRogueBlessRoleByUnlockInsId.LogPair.Add(new ValueTuple<string, object>("UnlockInsId", p0UnlockInsId));
			if (!ConfigCommon.BindInt(ConfigRoverRogueBlessRoleByUnlockInsId.HandleId, 1, p0UnlockInsId, ConfigRoverRogueBlessRoleByUnlockInsId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoverRogueBlessRoleByUnlockInsId.HandleId, ConfigRoverRogueBlessRoleByUnlockInsId.LogPair);
				return null;
			}
			List<RoverRogueBlessRole> list = new List<RoverRogueBlessRole>();
			while (ConfigCommon.Step(ConfigRoverRogueBlessRoleByUnlockInsId.HandleId, false, ConfigRoverRogueBlessRoleByUnlockInsId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueBlessRoleByUnlockInsId.HandleId, 0, ConfigRoverRogueBlessRoleByUnlockInsId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoverRogueBlessRoleByUnlockInsId.HandleId, ConfigRoverRogueBlessRoleByUnlockInsId.LogPair);
					return null;
				}
				RoverRogueBlessRole rootAsRoverRogueBlessRole = RoverRogueBlessRole.GetRootAsRoverRogueBlessRole(new ByteBuffer(item2));
				list.Add(rootAsRoverRogueBlessRole);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueBlessRoleByUnlockInsId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0UnlockInsId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoverRogueBlessRoleByUnlockInsId.HandleId, ConfigRoverRogueBlessRoleByUnlockInsId.LogPair);
			return list;
		}

		// Token: 0x04003E14 RID: 15892
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E15 RID: 15893
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x04003E16 RID: 15894
		private const string TABLE = "RoverRogueBlessRole";

		// Token: 0x04003E17 RID: 15895
		private const string COMMAND = "select BinData from `RoverRogueBlessRole` where UnlockInsId=?";

		// Token: 0x04003E18 RID: 15896
		private const string KEY_PREFIX = "RoverRogueBlessRoleByUnlockInsId";

		// Token: 0x04003E19 RID: 15897
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E1A RID: 15898
		private static int HandleId;
	}
}
