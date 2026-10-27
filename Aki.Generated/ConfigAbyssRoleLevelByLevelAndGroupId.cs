using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000026 RID: 38
	public class ConfigAbyssRoleLevelByLevelAndGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060000E4 RID: 228 RVA: 0x0005EDB0 File Offset: 0x0005CFB0
		static ConfigAbyssRoleLevelByLevelAndGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssRoleLevelByLevelAndGroupId.CreateStaticDefaultValue), new Action(ConfigAbyssRoleLevelByLevelAndGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0005EDD0 File Offset: 0x0005CFD0
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssRoleLevelByLevelAndGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssRoleLevelByLevelAndGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssRoleLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssRoleLevel` where Level=? AND GroupId=?")
			});
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0005EE4F File Offset: 0x0005D04F
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssRoleLevelByLevelAndGroupId.LogPair = null;
			ConfigAbyssRoleLevelByLevelAndGroupId.HandleId = 0;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0005EE5D File Offset: 0x0005D05D
		public static void Init()
		{
			ConfigAbyssRoleLevelByLevelAndGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssRoleLevelByLevelAndGroupId.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssRoleLevel` where Level=? AND GroupId=?");
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0005EE78 File Offset: 0x0005D078
		public static AbyssRoleLevel? GetConfig(int p0Level, int p1GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssRoleLevelByLevelAndGroupId.HandleId, ConfigAbyssRoleLevelByLevelAndGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssRoleLevelByLevelAndGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1GroupId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AbyssRoleLevel?(AbyssRoleLevel.GetRootAsAbyssRoleLevel(configBuffer));
				}
			}
			ConfigAbyssRoleLevelByLevelAndGroupId.LogPair.Clear();
			ConfigAbyssRoleLevelByLevelAndGroupId.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			ConfigAbyssRoleLevelByLevelAndGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p1GroupId));
			if (!ConfigCommon.BindInt(ConfigAbyssRoleLevelByLevelAndGroupId.HandleId, 1, p0Level, ConfigAbyssRoleLevelByLevelAndGroupId.LogPair) || !ConfigCommon.BindInt(ConfigAbyssRoleLevelByLevelAndGroupId.HandleId, 2, p1GroupId, ConfigAbyssRoleLevelByLevelAndGroupId.LogPair) || ConfigCommon.Step(ConfigAbyssRoleLevelByLevelAndGroupId.HandleId, true, ConfigAbyssRoleLevelByLevelAndGroupId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAbyssRoleLevelByLevelAndGroupId.HandleId, ConfigAbyssRoleLevelByLevelAndGroupId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssRoleLevelByLevelAndGroupId.HandleId, 0, ConfigAbyssRoleLevelByLevelAndGroupId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAbyssRoleLevelByLevelAndGroupId.HandleId, ConfigAbyssRoleLevelByLevelAndGroupId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AbyssRoleLevel rootAsAbyssRoleLevel = AbyssRoleLevel.GetRootAsAbyssRoleLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssRoleLevelByLevelAndGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1GroupId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAbyssRoleLevelByLevelAndGroupId.HandleId, ConfigAbyssRoleLevelByLevelAndGroupId.LogPair);
			return new AbyssRoleLevel?(rootAsAbyssRoleLevel);
		}

		// Token: 0x040000EE RID: 238
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x040000EF RID: 239
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x040000F0 RID: 240
		private const string TABLE = "AbyssRoleLevel";

		// Token: 0x040000F1 RID: 241
		private const string COMMAND = "select BinData from `AbyssRoleLevel` where Level=? AND GroupId=?";

		// Token: 0x040000F2 RID: 242
		private const string KEY_PREFIX = "AbyssRoleLevelByLevelAndGroupId";

		// Token: 0x040000F3 RID: 243
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040000F4 RID: 244
		private static int HandleId;
	}
}
