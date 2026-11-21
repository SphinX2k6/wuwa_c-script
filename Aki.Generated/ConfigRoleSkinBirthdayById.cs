using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008E1 RID: 2273
	public class ConfigRoleSkinBirthdayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003559 RID: 13657 RVA: 0x0018A464 File Offset: 0x00188664
		static ConfigRoleSkinBirthdayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinBirthdayById.CreateStaticDefaultValue), new Action(ConfigRoleSkinBirthdayById.ResetStaticDefaultValue));
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x0018A484 File Offset: 0x00188684
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

		// Token: 0x0600355B RID: 13659 RVA: 0x0018A503 File Offset: 0x00188703
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinBirthdayById.LogPair = null;
			ConfigRoleSkinBirthdayById.HandleId = 0;
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x0018A511 File Offset: 0x00188711
		public static void Init()
		{
			ConfigRoleSkinBirthdayById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinBirthdayById.HandleId, "db_birthday.db", "select BinData from `RoleSkinBirthday` where Id=?");
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x0018A52C File Offset: 0x0018872C
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

		// Token: 0x04003E0D RID: 15885
		private const string DB = "db_birthday.db";

		// Token: 0x04003E0E RID: 15886
		private const string FILE = "s.生日.xlsx";

		// Token: 0x04003E0F RID: 15887
		private const string TABLE = "RoleSkinBirthday";

		// Token: 0x04003E10 RID: 15888
		private const string COMMAND = "select BinData from `RoleSkinBirthday` where Id=?";

		// Token: 0x04003E11 RID: 15889
		private const string KEY_PREFIX = "RoleSkinBirthdayById";

		// Token: 0x04003E12 RID: 15890
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E13 RID: 15891
		private static int HandleId;
	}
}
