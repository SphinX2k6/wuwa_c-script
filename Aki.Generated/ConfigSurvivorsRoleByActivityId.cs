using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A77 RID: 2679
	public class ConfigSurvivorsRoleByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EDE RID: 16094 RVA: 0x001C02BC File Offset: 0x001BE4BC
		static ConfigSurvivorsRoleByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsRoleByActivityId.CreateStaticDefaultValue), new Action(ConfigSurvivorsRoleByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x001C02DC File Offset: 0x001BE4DC
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsRoleByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsRoleByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局内.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsRole"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsRole` where ActivityId=?")
			});
		}

		// Token: 0x06003EE0 RID: 16096 RVA: 0x001C035B File Offset: 0x001BE55B
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsRoleByActivityId.LogPair = null;
			ConfigSurvivorsRoleByActivityId.HandleId = 0;
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x001C0369 File Offset: 0x001BE569
		public static void Init()
		{
			ConfigSurvivorsRoleByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsRoleByActivityId.HandleId, "db_survivors.db", "select BinData from `SurvivorsRole` where ActivityId=?");
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x001C0384 File Offset: 0x001BE584
		[NullableContext(2)]
		public static IReadOnlyList<SurvivorsRole> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsRoleByActivityId.HandleId, ConfigSurvivorsRoleByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsRoleByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SurvivorsRole> readOnlyList = (IReadOnlyList<SurvivorsRole>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSurvivorsRoleByActivityId.LogPair.Clear();
			ConfigSurvivorsRoleByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSurvivorsRoleByActivityId.HandleId, 1, p0ActivityId, ConfigSurvivorsRoleByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSurvivorsRoleByActivityId.HandleId, ConfigSurvivorsRoleByActivityId.LogPair);
				return null;
			}
			List<SurvivorsRole> list = new List<SurvivorsRole>();
			while (ConfigCommon.Step(ConfigSurvivorsRoleByActivityId.HandleId, false, ConfigSurvivorsRoleByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsRoleByActivityId.HandleId, 0, ConfigSurvivorsRoleByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSurvivorsRoleByActivityId.HandleId, ConfigSurvivorsRoleByActivityId.LogPair);
					return null;
				}
				SurvivorsRole rootAsSurvivorsRole = SurvivorsRole.GetRootAsSurvivorsRole(new ByteBuffer(item2));
				list.Add(rootAsSurvivorsRole);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsRoleByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSurvivorsRoleByActivityId.HandleId, ConfigSurvivorsRoleByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004927 RID: 18727
		private const string DB = "db_survivors.db";

		// Token: 0x04004928 RID: 18728
		private const string FILE = "x.幸存者_局内.xlsx";

		// Token: 0x04004929 RID: 18729
		private const string TABLE = "SurvivorsRole";

		// Token: 0x0400492A RID: 18730
		private const string COMMAND = "select BinData from `SurvivorsRole` where ActivityId=?";

		// Token: 0x0400492B RID: 18731
		private const string KEY_PREFIX = "SurvivorsRoleByActivityId";

		// Token: 0x0400492C RID: 18732
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400492D RID: 18733
		private static int HandleId;
	}
}
