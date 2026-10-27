using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000024 RID: 36
	public class ConfigAbyssRoleLevelByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060000D8 RID: 216 RVA: 0x0005E92F File Offset: 0x0005CB2F
		static ConfigAbyssRoleLevelByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssRoleLevelByGroupId.CreateStaticDefaultValue), new Action(ConfigAbyssRoleLevelByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0005E950 File Offset: 0x0005CB50
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssRoleLevelByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssRoleLevelByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssRoleLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssRoleLevel` where GroupId=?")
			});
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0005E9CF File Offset: 0x0005CBCF
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssRoleLevelByGroupId.LogPair = null;
			ConfigAbyssRoleLevelByGroupId.HandleId = 0;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0005E9DD File Offset: 0x0005CBDD
		public static void Init()
		{
			ConfigAbyssRoleLevelByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssRoleLevelByGroupId.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssRoleLevel` where GroupId=?");
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0005E9F8 File Offset: 0x0005CBF8
		[NullableContext(2)]
		public static IReadOnlyList<AbyssRoleLevel> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssRoleLevelByGroupId.HandleId, ConfigAbyssRoleLevelByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssRoleLevelByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<AbyssRoleLevel> readOnlyList = (IReadOnlyList<AbyssRoleLevel>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigAbyssRoleLevelByGroupId.LogPair.Clear();
			ConfigAbyssRoleLevelByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigAbyssRoleLevelByGroupId.HandleId, 1, p0GroupId, ConfigAbyssRoleLevelByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigAbyssRoleLevelByGroupId.HandleId, ConfigAbyssRoleLevelByGroupId.LogPair);
				return null;
			}
			List<AbyssRoleLevel> list = new List<AbyssRoleLevel>();
			while (ConfigCommon.Step(ConfigAbyssRoleLevelByGroupId.HandleId, false, ConfigAbyssRoleLevelByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssRoleLevelByGroupId.HandleId, 0, ConfigAbyssRoleLevelByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAbyssRoleLevelByGroupId.HandleId, ConfigAbyssRoleLevelByGroupId.LogPair);
					return null;
				}
				AbyssRoleLevel rootAsAbyssRoleLevel = AbyssRoleLevel.GetRootAsAbyssRoleLevel(new ByteBuffer(item2));
				list.Add(rootAsAbyssRoleLevel);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssRoleLevelByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigAbyssRoleLevelByGroupId.HandleId, ConfigAbyssRoleLevelByGroupId.LogPair);
			return list;
		}

		// Token: 0x040000E0 RID: 224
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x040000E1 RID: 225
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x040000E2 RID: 226
		private const string TABLE = "AbyssRoleLevel";

		// Token: 0x040000E3 RID: 227
		private const string COMMAND = "select BinData from `AbyssRoleLevel` where GroupId=?";

		// Token: 0x040000E4 RID: 228
		private const string KEY_PREFIX = "AbyssRoleLevelByGroupId";

		// Token: 0x040000E5 RID: 229
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040000E6 RID: 230
		private static int HandleId;
	}
}
