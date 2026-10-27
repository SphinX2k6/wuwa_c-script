using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200088E RID: 2190
	public class ConfigRoleBreachByBreachGroupIdAndBreachLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003366 RID: 13158 RVA: 0x0017BEE7 File Offset: 0x0017A0E7
		static ConfigRoleBreachByBreachGroupIdAndBreachLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleBreachByBreachGroupIdAndBreachLevel.CreateStaticDefaultValue), new Action(ConfigRoleBreachByBreachGroupIdAndBreachLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x0017BF08 File Offset: 0x0017A108
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role_level.db"),
				new ValueTuple<string, object>("文件", "j.角色升级突破.xlsx"),
				new ValueTuple<string, object>("表名", "RoleBreach"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleBreach` where BreachGroupId=? AND BreachLevel=?")
			});
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x0017BF87 File Offset: 0x0017A187
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair = null;
			ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId = 0;
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x0017BF95 File Offset: 0x0017A195
		public static void Init()
		{
			ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId = ConfigCommon.InitDataStatement(ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId, "db_role_level.db", "select BinData from `RoleBreach` where BreachGroupId=? AND BreachLevel=?");
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x0017BFB0 File Offset: 0x0017A1B0
		public static RoleBreach? GetConfig(int p0BreachGroupId, int p1BreachLevel, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId, ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RoleBreachByBreachGroupIdAndBreachLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BreachGroupId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1BreachLevel);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleBreach?(RoleBreach.GetRootAsRoleBreach(configBuffer));
				}
			}
			ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair.Clear();
			ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair.Add(new ValueTuple<string, object>("BreachGroupId", p0BreachGroupId));
			ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair.Add(new ValueTuple<string, object>("BreachLevel", p1BreachLevel));
			if (!ConfigCommon.BindInt(ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId, 1, p0BreachGroupId, ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair) || !ConfigCommon.BindInt(ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId, 2, p1BreachLevel, ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair) || ConfigCommon.Step(ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId, true, ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId, ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId, 0, ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId, ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleBreach rootAsRoleBreach = RoleBreach.GetRootAsRoleBreach(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RoleBreachByBreachGroupIdAndBreachLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BreachGroupId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1BreachLevel);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleBreachByBreachGroupIdAndBreachLevel.HandleId, ConfigRoleBreachByBreachGroupIdAndBreachLevel.LogPair);
			return new RoleBreach?(rootAsRoleBreach);
		}

		// Token: 0x04003BC8 RID: 15304
		private const string DB = "db_role_level.db";

		// Token: 0x04003BC9 RID: 15305
		private const string FILE = "j.角色升级突破.xlsx";

		// Token: 0x04003BCA RID: 15306
		private const string TABLE = "RoleBreach";

		// Token: 0x04003BCB RID: 15307
		private const string COMMAND = "select BinData from `RoleBreach` where BreachGroupId=? AND BreachLevel=?";

		// Token: 0x04003BCC RID: 15308
		private const string KEY_PREFIX = "RoleBreachByBreachGroupIdAndBreachLevel";

		// Token: 0x04003BCD RID: 15309
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BCE RID: 15310
		private static int HandleId;
	}
}
