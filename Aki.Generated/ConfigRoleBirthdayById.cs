using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008A7 RID: 2215
	public class ConfigRoleBirthdayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033FC RID: 13308 RVA: 0x00182B57 File Offset: 0x00180D57
		static ConfigRoleBirthdayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleBirthdayById.CreateStaticDefaultValue), new Action(ConfigRoleBirthdayById.ResetStaticDefaultValue));
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x00182B78 File Offset: 0x00180D78
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

		// Token: 0x060033FE RID: 13310 RVA: 0x00182BF7 File Offset: 0x00180DF7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleBirthdayById.LogPair = null;
			ConfigRoleBirthdayById.HandleId = 0;
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x00182C05 File Offset: 0x00180E05
		public static void Init()
		{
			ConfigRoleBirthdayById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleBirthdayById.HandleId, "db_birthday.db", "select BinData from `RoleBirthday` where RoleId=?");
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x00182C20 File Offset: 0x00180E20
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

		// Token: 0x04003C77 RID: 15479
		private const string DB = "db_birthday.db";

		// Token: 0x04003C78 RID: 15480
		private const string FILE = "s.生日.xlsx";

		// Token: 0x04003C79 RID: 15481
		private const string TABLE = "RoleBirthday";

		// Token: 0x04003C7A RID: 15482
		private const string COMMAND = "select BinData from `RoleBirthday` where RoleId=?";

		// Token: 0x04003C7B RID: 15483
		private const string KEY_PREFIX = "RoleBirthdayById";

		// Token: 0x04003C7C RID: 15484
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C7D RID: 15485
		private static int HandleId;
	}
}
