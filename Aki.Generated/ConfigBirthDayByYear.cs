using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000F1 RID: 241
	public class ConfigBirthDayByYear : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005A7 RID: 1447 RVA: 0x00079A40 File Offset: 0x00077C40
		static ConfigBirthDayByYear()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBirthDayByYear.CreateStaticDefaultValue), new Action(ConfigBirthDayByYear.ResetStaticDefaultValue));
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00079A60 File Offset: 0x00077C60
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

		// Token: 0x060005A9 RID: 1449 RVA: 0x00079ADF File Offset: 0x00077CDF
		public static void ResetStaticDefaultValue()
		{
			ConfigBirthDayByYear.LogPair = null;
			ConfigBirthDayByYear.HandleId = 0;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00079AED File Offset: 0x00077CED
		public static void Init()
		{
			ConfigBirthDayByYear.HandleId = ConfigCommon.InitDataStatement(ConfigBirthDayByYear.HandleId, "db_birthday.db", "select BinData from `BirthDay` where LimitYear=?");
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00079B08 File Offset: 0x00077D08
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

		// Token: 0x0400067B RID: 1659
		private const string DB = "db_birthday.db";

		// Token: 0x0400067C RID: 1660
		private const string FILE = "s.生日.xlsx";

		// Token: 0x0400067D RID: 1661
		private const string TABLE = "BirthDay";

		// Token: 0x0400067E RID: 1662
		private const string COMMAND = "select BinData from `BirthDay` where LimitYear=?";

		// Token: 0x0400067F RID: 1663
		private const string KEY_PREFIX = "BirthDayByYear";

		// Token: 0x04000680 RID: 1664
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000681 RID: 1665
		private static int HandleId;
	}
}
