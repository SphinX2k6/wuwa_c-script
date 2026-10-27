using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008C5 RID: 2245
	public class ConfigRoleSkinBirthdayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034B1 RID: 13489 RVA: 0x0018317C File Offset: 0x0018137C
		static ConfigRoleSkinBirthdayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinBirthdayById.CreateStaticDefaultValue), new Action(ConfigRoleSkinBirthdayById.ResetStaticDefaultValue));
		}

		// Token: 0x060034B2 RID: 13490 RVA: 0x0018319C File Offset: 0x0018139C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleSkinBirthdayById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleSkinBirthdayById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_birthday.db"),
				new ValueTuple<string, object>("文件", "s.生日.xlsx"),
				new ValueTuple<string, object>("表名", "RoleSkinBirthday"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleSkinBirthday` where Id=?")
			});
		}

		// Token: 0x060034B3 RID: 13491 RVA: 0x0018321B File Offset: 0x0018141B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinBirthdayById.LogPair = null;
			ConfigRoleSkinBirthdayById.HandleId = 0;
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x00183229 File Offset: 0x00181429
		public static void Init()
		{
			ConfigRoleSkinBirthdayById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinBirthdayById.HandleId, "db_birthday.db", "select BinData from `RoleSkinBirthday` where Id=?");
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x00183244 File Offset: 0x00181444
		public static RoleSkinBirthday? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleSkinBirthdayById.HandleId, ConfigRoleSkinBirthdayById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinBirthdayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleSkinBirthday?(RoleSkinBirthday.GetRootAsRoleSkinBirthday(configBuffer));
				}
			}
			ConfigRoleSkinBirthdayById.LogPair.Clear();
			ConfigRoleSkinBirthdayById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleSkinBirthdayById.HandleId, 1, p0Id, ConfigRoleSkinBirthdayById.LogPair) || ConfigCommon.Step(ConfigRoleSkinBirthdayById.HandleId, true, ConfigRoleSkinBirthdayById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleSkinBirthdayById.HandleId, ConfigRoleSkinBirthdayById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleSkinBirthdayById.HandleId, 0, ConfigRoleSkinBirthdayById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleSkinBirthdayById.HandleId, ConfigRoleSkinBirthdayById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleSkinBirthday rootAsRoleSkinBirthday = RoleSkinBirthday.GetRootAsRoleSkinBirthday(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinBirthdayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleSkinBirthdayById.HandleId, ConfigRoleSkinBirthdayById.LogPair);
			return new RoleSkinBirthday?(rootAsRoleSkinBirthday);
		}

		// Token: 0x04003D49 RID: 15689
		private const string DB = "db_birthday.db";

		// Token: 0x04003D4A RID: 15690
		private const string FILE = "s.生日.xlsx";

		// Token: 0x04003D4B RID: 15691
		private const string TABLE = "RoleSkinBirthday";

		// Token: 0x04003D4C RID: 15692
		private const string COMMAND = "select BinData from `RoleSkinBirthday` where Id=?";

		// Token: 0x04003D4D RID: 15693
		private const string KEY_PREFIX = "RoleSkinBirthdayById";

		// Token: 0x04003D4E RID: 15694
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D4F RID: 15695
		private static int HandleId;
	}
}
