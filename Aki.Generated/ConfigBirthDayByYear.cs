using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000100 RID: 256
	public class ConfigBirthDayByYear : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000601 RID: 1537 RVA: 0x0007F3A4 File Offset: 0x0007D5A4
		static ConfigBirthDayByYear()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBirthDayByYear.CreateStaticDefaultValue), new Action(ConfigBirthDayByYear.ResetStaticDefaultValue));
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0007F3C4 File Offset: 0x0007D5C4
		public static void CreateStaticDefaultValue()
		{
			ConfigBirthDayByYear.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBirthDayByYear.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_birthday.db"),
				new ValueTuple<string, object>("文件", "s.生日.xlsx"),
				new ValueTuple<string, object>("表名", "BirthDay"),
				new ValueTuple<string, object>("语句", "select BinData from `BirthDay` where LimitYear=?")
			});
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0007F443 File Offset: 0x0007D643
		public static void ResetStaticDefaultValue()
		{
			ConfigBirthDayByYear.LogPair = null;
			ConfigBirthDayByYear.HandleId = 0;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0007F451 File Offset: 0x0007D651
		public static void Init()
		{
			ConfigBirthDayByYear.HandleId = ConfigCommon.InitDataStatement(ConfigBirthDayByYear.HandleId, "db_birthday.db", "select BinData from `BirthDay` where LimitYear=?");
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0007F46C File Offset: 0x0007D66C
		public static BirthDay? GetConfig(int p0LimitYear, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBirthDayByYear.HandleId, ConfigBirthDayByYear.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BirthDayByYear");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LimitYear);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BirthDay?(BirthDay.GetRootAsBirthDay(configBuffer));
				}
			}
			ConfigBirthDayByYear.LogPair.Clear();
			ConfigBirthDayByYear.LogPair.Add(new ValueTuple<string, object>("LimitYear", p0LimitYear));
			if (!ConfigCommon.BindInt(ConfigBirthDayByYear.HandleId, 1, p0LimitYear, ConfigBirthDayByYear.LogPair) || ConfigCommon.Step(ConfigBirthDayByYear.HandleId, true, ConfigBirthDayByYear.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBirthDayByYear.HandleId, ConfigBirthDayByYear.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBirthDayByYear.HandleId, 0, ConfigBirthDayByYear.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBirthDayByYear.HandleId, ConfigBirthDayByYear.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BirthDay rootAsBirthDay = BirthDay.GetRootAsBirthDay(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BirthDayByYear");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LimitYear);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBirthDayByYear.HandleId, ConfigBirthDayByYear.LogPair);
			return new BirthDay?(rootAsBirthDay);
		}

		// Token: 0x040006E4 RID: 1764
		private const string DB = "db_birthday.db";

		// Token: 0x040006E5 RID: 1765
		private const string FILE = "s.生日.xlsx";

		// Token: 0x040006E6 RID: 1766
		private const string TABLE = "BirthDay";

		// Token: 0x040006E7 RID: 1767
		private const string COMMAND = "select BinData from `BirthDay` where LimitYear=?";

		// Token: 0x040006E8 RID: 1768
		private const string KEY_PREFIX = "BirthDayByYear";

		// Token: 0x040006E9 RID: 1769
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006EA RID: 1770
		private static int HandleId;
	}
}
