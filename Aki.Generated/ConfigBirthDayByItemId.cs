using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000FE RID: 254
	public class ConfigBirthDayByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005F5 RID: 1525 RVA: 0x0007EF14 File Offset: 0x0007D114
		static ConfigBirthDayByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBirthDayByItemId.CreateStaticDefaultValue), new Action(ConfigBirthDayByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0007EF34 File Offset: 0x0007D134
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

		// Token: 0x060005F7 RID: 1527 RVA: 0x0007EFB3 File Offset: 0x0007D1B3
		public static void ResetStaticDefaultValue()
		{
			ConfigBirthDayByItemId.LogPair = null;
			ConfigBirthDayByItemId.HandleId = 0;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0007EFC1 File Offset: 0x0007D1C1
		public static void Init()
		{
			ConfigBirthDayByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigBirthDayByItemId.HandleId, "db_birthday.db", "select BinData from `BirthDay` where BirthDayCardItemId=?");
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0007EFDC File Offset: 0x0007D1DC
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

		// Token: 0x040006D6 RID: 1750
		private const string DB = "db_birthday.db";

		// Token: 0x040006D7 RID: 1751
		private const string FILE = "s.生日.xlsx";

		// Token: 0x040006D8 RID: 1752
		private const string TABLE = "BirthDay";

		// Token: 0x040006D9 RID: 1753
		private const string COMMAND = "select BinData from `BirthDay` where BirthDayCardItemId=?";

		// Token: 0x040006DA RID: 1754
		private const string KEY_PREFIX = "BirthDayByItemId";

		// Token: 0x040006DB RID: 1755
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006DC RID: 1756
		private static int HandleId;
	}
}
