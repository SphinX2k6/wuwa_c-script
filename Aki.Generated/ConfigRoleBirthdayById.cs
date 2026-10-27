using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200088B RID: 2187
	public class ConfigRoleBirthdayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003354 RID: 13140 RVA: 0x0017B86F File Offset: 0x00179A6F
		static ConfigRoleBirthdayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleBirthdayById.CreateStaticDefaultValue), new Action(ConfigRoleBirthdayById.ResetStaticDefaultValue));
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x0017B890 File Offset: 0x00179A90
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleBirthdayById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleBirthdayById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_birthday.db"),
				new ValueTuple<string, object>("文件", "s.生日.xlsx"),
				new ValueTuple<string, object>("表名", "RoleBirthday"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleBirthday` where RoleId=?")
			});
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x0017B90F File Offset: 0x00179B0F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleBirthdayById.LogPair = null;
			ConfigRoleBirthdayById.HandleId = 0;
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x0017B91D File Offset: 0x00179B1D
		public static void Init()
		{
			ConfigRoleBirthdayById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleBirthdayById.HandleId, "db_birthday.db", "select BinData from `RoleBirthday` where RoleId=?");
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x0017B938 File Offset: 0x00179B38
		public static RoleBirthday? GetConfig(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleBirthdayById.HandleId, ConfigRoleBirthdayById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleBirthdayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleBirthday?(RoleBirthday.GetRootAsRoleBirthday(configBuffer));
				}
			}
			ConfigRoleBirthdayById.LogPair.Clear();
			ConfigRoleBirthdayById.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigRoleBirthdayById.HandleId, 1, p0RoleId, ConfigRoleBirthdayById.LogPair) || ConfigCommon.Step(ConfigRoleBirthdayById.HandleId, true, ConfigRoleBirthdayById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleBirthdayById.HandleId, ConfigRoleBirthdayById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleBirthdayById.HandleId, 0, ConfigRoleBirthdayById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleBirthdayById.HandleId, ConfigRoleBirthdayById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleBirthday rootAsRoleBirthday = RoleBirthday.GetRootAsRoleBirthday(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleBirthdayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleBirthdayById.HandleId, ConfigRoleBirthdayById.LogPair);
			return new RoleBirthday?(rootAsRoleBirthday);
		}

		// Token: 0x04003BB3 RID: 15283
		private const string DB = "db_birthday.db";

		// Token: 0x04003BB4 RID: 15284
		private const string FILE = "s.生日.xlsx";

		// Token: 0x04003BB5 RID: 15285
		private const string TABLE = "RoleBirthday";

		// Token: 0x04003BB6 RID: 15286
		private const string COMMAND = "select BinData from `RoleBirthday` where RoleId=?";

		// Token: 0x04003BB7 RID: 15287
		private const string KEY_PREFIX = "RoleBirthdayById";

		// Token: 0x04003BB8 RID: 15288
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BB9 RID: 15289
		private static int HandleId;
	}
}
