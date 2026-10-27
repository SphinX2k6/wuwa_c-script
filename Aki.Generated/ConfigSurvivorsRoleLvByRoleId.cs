using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009A6 RID: 2470
	public class ConfigSurvivorsRoleLvByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039F8 RID: 14840 RVA: 0x001A1838 File Offset: 0x0019FA38
		static ConfigSurvivorsRoleLvByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsRoleLvByRoleId.CreateStaticDefaultValue), new Action(ConfigSurvivorsRoleLvByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x060039F9 RID: 14841 RVA: 0x001A1858 File Offset: 0x0019FA58
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsRoleLvByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsRoleLvByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局内.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsRoleLv"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsRoleLv` where RoleId=?")
			});
		}

		// Token: 0x060039FA RID: 14842 RVA: 0x001A18D7 File Offset: 0x0019FAD7
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsRoleLvByRoleId.LogPair = null;
			ConfigSurvivorsRoleLvByRoleId.HandleId = 0;
		}

		// Token: 0x060039FB RID: 14843 RVA: 0x001A18E5 File Offset: 0x0019FAE5
		public static void Init()
		{
			ConfigSurvivorsRoleLvByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsRoleLvByRoleId.HandleId, "db_survivors.db", "select BinData from `SurvivorsRoleLv` where RoleId=?");
		}

		// Token: 0x060039FC RID: 14844 RVA: 0x001A1900 File Offset: 0x0019FB00
		[NullableContext(2)]
		public static IReadOnlyList<SurvivorsRoleLv> GetConfigList(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsRoleLvByRoleId.HandleId, ConfigSurvivorsRoleLvByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsRoleLvByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				IReadOnlyList<SurvivorsRoleLv> readOnlyList = (IReadOnlyList<SurvivorsRoleLv>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSurvivorsRoleLvByRoleId.LogPair.Clear();
			ConfigSurvivorsRoleLvByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigSurvivorsRoleLvByRoleId.HandleId, 1, p0RoleId, ConfigSurvivorsRoleLvByRoleId.LogPair))
			{
				ConfigCommon.Reset(ConfigSurvivorsRoleLvByRoleId.HandleId, ConfigSurvivorsRoleLvByRoleId.LogPair);
				return null;
			}
			List<SurvivorsRoleLv> list = new List<SurvivorsRoleLv>();
			while (ConfigCommon.Step(ConfigSurvivorsRoleLvByRoleId.HandleId, false, ConfigSurvivorsRoleLvByRoleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsRoleLvByRoleId.HandleId, 0, ConfigSurvivorsRoleLvByRoleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSurvivorsRoleLvByRoleId.HandleId, ConfigSurvivorsRoleLvByRoleId.LogPair);
					return null;
				}
				SurvivorsRoleLv rootAsSurvivorsRoleLv = SurvivorsRoleLv.GetRootAsSurvivorsRoleLv(new ByteBuffer(item2));
				list.Add(rootAsSurvivorsRoleLv);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsRoleLvByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSurvivorsRoleLvByRoleId.HandleId, ConfigSurvivorsRoleLvByRoleId.LogPair);
			return list;
		}

		// Token: 0x04004370 RID: 17264
		private const string DB = "db_survivors.db";

		// Token: 0x04004371 RID: 17265
		private const string FILE = "x.幸存者_局内.xlsx";

		// Token: 0x04004372 RID: 17266
		private const string TABLE = "SurvivorsRoleLv";

		// Token: 0x04004373 RID: 17267
		private const string COMMAND = "select BinData from `SurvivorsRoleLv` where RoleId=?";

		// Token: 0x04004374 RID: 17268
		private const string KEY_PREFIX = "SurvivorsRoleLvByRoleId";

		// Token: 0x04004375 RID: 17269
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004376 RID: 17270
		private static int HandleId;
	}
}
