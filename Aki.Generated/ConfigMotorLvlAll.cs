using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005B0 RID: 1456
	public class ConfigMotorLvlAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600222D RID: 8749 RVA: 0x0011ACB4 File Offset: 0x00118EB4
		static ConfigMotorLvlAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLvlAll.CreateStaticDefaultValue), new Action(ConfigMotorLvlAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x0011ACD4 File Offset: 0x00118ED4
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorLvlAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorLvlAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motor.db"),
				new ValueTuple<string, object>("文件", "m.摩托车.xlsx"),
				new ValueTuple<string, object>("表名", "MotorLvl"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorLvl`")
			});
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x0011AD53 File Offset: 0x00118F53
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLvlAll.LogPair = null;
			ConfigMotorLvlAll.HandleId = 0;
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x0011AD61 File Offset: 0x00118F61
		public static void Init()
		{
			ConfigMotorLvlAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLvlAll.HandleId, "db_motor.db", "select BinData from `MotorLvl`");
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x0011AD7C File Offset: 0x00118F7C
		[NullableContext(2)]
		public static IReadOnlyList<MotorLvl> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorLvlAll.HandleId, ConfigMotorLvlAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorLvl> readOnlyList = (IReadOnlyList<MotorLvl>)ConfigCommon.GetConfig("MotorLvlAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorLvl> list = new List<MotorLvl>();
			while (ConfigCommon.Step(ConfigMotorLvlAll.HandleId, false, ConfigMotorLvlAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorLvlAll.HandleId, 0, ConfigMotorLvlAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorLvlAll.HandleId, ConfigMotorLvlAll.LogPair);
					return null;
				}
				MotorLvl rootAsMotorLvl = MotorLvl.GetRootAsMotorLvl(new ByteBuffer(item2));
				list.Add(rootAsMotorLvl);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorLvlAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorLvlAll.HandleId, ConfigMotorLvlAll.LogPair);
			return list;
		}

		// Token: 0x040027B4 RID: 10164
		private const string DB = "db_motor.db";

		// Token: 0x040027B5 RID: 10165
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x040027B6 RID: 10166
		private const string TABLE = "MotorLvl";

		// Token: 0x040027B7 RID: 10167
		private const string COMMAND = "select BinData from `MotorLvl`";

		// Token: 0x040027B8 RID: 10168
		private const string KEY_PREFIX = "MotorLvlAll";

		// Token: 0x040027B9 RID: 10169
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027BA RID: 10170
		private static int HandleId;
	}
}
