using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000EF RID: 239
	public class ConfigBirthDayByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600059B RID: 1435 RVA: 0x000795B0 File Offset: 0x000777B0
		static ConfigBirthDayByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBirthDayByItemId.CreateStaticDefaultValue), new Action(ConfigBirthDayByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x000795D0 File Offset: 0x000777D0
		public static void CreateStaticDefaultValue()
		{
			ConfigBirthDayByItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBirthDayByItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_birthday.db"),
				new ValueTuple<string, object>("文件", "s.生日.xlsx"),
				new ValueTuple<string, object>("表名", "BirthDay"),
				new ValueTuple<string, object>("语句", "select BinData from `BirthDay` where BirthDayCardItemId=?")
			});
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0007964F File Offset: 0x0007784F
		public static void ResetStaticDefaultValue()
		{
			ConfigBirthDayByItemId.LogPair = null;
			ConfigBirthDayByItemId.HandleId = 0;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0007965D File Offset: 0x0007785D
		public static void Init()
		{
			ConfigBirthDayByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigBirthDayByItemId.HandleId, "db_birthday.db", "select BinData from `BirthDay` where BirthDayCardItemId=?");
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00079678 File Offset: 0x00077878
		public static BirthDay? GetConfig(int p0BirthDayCardItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBirthDayByItemId.HandleId, ConfigBirthDayByItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BirthDayByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BirthDayCardItemId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BirthDay?(BirthDay.GetRootAsBirthDay(configBuffer));
				}
			}
			ConfigBirthDayByItemId.LogPair.Clear();
			ConfigBirthDayByItemId.LogPair.Add(new ValueTuple<string, object>("BirthDayCardItemId", p0BirthDayCardItemId));
			if (!ConfigCommon.BindInt(ConfigBirthDayByItemId.HandleId, 1, p0BirthDayCardItemId, ConfigBirthDayByItemId.LogPair) || ConfigCommon.Step(ConfigBirthDayByItemId.HandleId, true, ConfigBirthDayByItemId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBirthDayByItemId.HandleId, ConfigBirthDayByItemId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBirthDayByItemId.HandleId, 0, ConfigBirthDayByItemId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBirthDayByItemId.HandleId, ConfigBirthDayByItemId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BirthDay rootAsBirthDay = BirthDay.GetRootAsBirthDay(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BirthDayByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BirthDayCardItemId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBirthDayByItemId.HandleId, ConfigBirthDayByItemId.LogPair);
			return new BirthDay?(rootAsBirthDay);
		}

		// Token: 0x0400066D RID: 1645
		private const string DB = "db_birthday.db";

		// Token: 0x0400066E RID: 1646
		private const string FILE = "s.生日.xlsx";

		// Token: 0x0400066F RID: 1647
		private const string TABLE = "BirthDay";

		// Token: 0x04000670 RID: 1648
		private const string COMMAND = "select BinData from `BirthDay` where BirthDayCardItemId=?";

		// Token: 0x04000671 RID: 1649
		private const string KEY_PREFIX = "BirthDayByItemId";

		// Token: 0x04000672 RID: 1650
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000673 RID: 1651
		private static int HandleId;
	}
}
