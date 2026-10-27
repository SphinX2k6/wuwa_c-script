using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009A2 RID: 2466
	public class ConfigSurvivorsRoleByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039E0 RID: 14816 RVA: 0x001A0F28 File Offset: 0x0019F128
		static ConfigSurvivorsRoleByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsRoleByActivityId.CreateStaticDefaultValue), new Action(ConfigSurvivorsRoleByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060039E1 RID: 14817 RVA: 0x001A0F48 File Offset: 0x0019F148
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

		// Token: 0x060039E2 RID: 14818 RVA: 0x001A0FC7 File Offset: 0x0019F1C7
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsRoleByActivityId.LogPair = null;
			ConfigSurvivorsRoleByActivityId.HandleId = 0;
		}

		// Token: 0x060039E3 RID: 14819 RVA: 0x001A0FD5 File Offset: 0x0019F1D5
		public static void Init()
		{
			ConfigSurvivorsRoleByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsRoleByActivityId.HandleId, "db_survivors.db", "select BinData from `SurvivorsRole` where ActivityId=?");
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x001A0FF0 File Offset: 0x0019F1F0
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

		// Token: 0x04004354 RID: 17236
		private const string DB = "db_survivors.db";

		// Token: 0x04004355 RID: 17237
		private const string FILE = "x.幸存者_局内.xlsx";

		// Token: 0x04004356 RID: 17238
		private const string TABLE = "SurvivorsRole";

		// Token: 0x04004357 RID: 17239
		private const string COMMAND = "select BinData from `SurvivorsRole` where ActivityId=?";

		// Token: 0x04004358 RID: 17240
		private const string KEY_PREFIX = "SurvivorsRoleByActivityId";

		// Token: 0x04004359 RID: 17241
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400435A RID: 17242
		private static int HandleId;
	}
}
