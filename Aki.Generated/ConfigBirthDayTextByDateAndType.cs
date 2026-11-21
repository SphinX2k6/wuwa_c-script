using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000101 RID: 257
	public class ConfigBirthDayTextByDateAndType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000607 RID: 1543 RVA: 0x0007F5EC File Offset: 0x0007D7EC
		static ConfigBirthDayTextByDateAndType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBirthDayTextByDateAndType.CreateStaticDefaultValue), new Action(ConfigBirthDayTextByDateAndType.ResetStaticDefaultValue));
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0007F60C File Offset: 0x0007D80C
		public static void CreateStaticDefaultValue()
		{
			ConfigBirthDayTextByDateAndType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBirthDayTextByDateAndType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_birthday.db"),
				new ValueTuple<string, object>("文件", "s.生日.xlsx"),
				new ValueTuple<string, object>("表名", "BirthDayText"),
				new ValueTuple<string, object>("语句", "select BinData from `BirthDayText` where Date=? And DateType=?")
			});
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0007F68B File Offset: 0x0007D88B
		public static void ResetStaticDefaultValue()
		{
			ConfigBirthDayTextByDateAndType.LogPair = null;
			ConfigBirthDayTextByDateAndType.HandleId = 0;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0007F699 File Offset: 0x0007D899
		public static void Init()
		{
			ConfigBirthDayTextByDateAndType.HandleId = ConfigCommon.InitDataStatement(ConfigBirthDayTextByDateAndType.HandleId, "db_birthday.db", "select BinData from `BirthDayText` where Date=? And DateType=?");
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0007F6B4 File Offset: 0x0007D8B4
		public static BirthDayText? GetConfig(int p0Date, int p1DateType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBirthDayTextByDateAndType.HandleId, ConfigBirthDayTextByDateAndType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("BirthDayTextByDateAndType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Date);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1DateType);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BirthDayText?(BirthDayText.GetRootAsBirthDayText(configBuffer));
				}
			}
			ConfigBirthDayTextByDateAndType.LogPair.Clear();
			ConfigBirthDayTextByDateAndType.LogPair.Add(new ValueTuple<string, object>("Date", p0Date));
			ConfigBirthDayTextByDateAndType.LogPair.Add(new ValueTuple<string, object>("DateType", p1DateType));
			if (!ConfigCommon.BindInt(ConfigBirthDayTextByDateAndType.HandleId, 1, p0Date, ConfigBirthDayTextByDateAndType.LogPair) || !ConfigCommon.BindInt(ConfigBirthDayTextByDateAndType.HandleId, 2, p1DateType, ConfigBirthDayTextByDateAndType.LogPair) || ConfigCommon.Step(ConfigBirthDayTextByDateAndType.HandleId, true, ConfigBirthDayTextByDateAndType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBirthDayTextByDateAndType.HandleId, ConfigBirthDayTextByDateAndType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBirthDayTextByDateAndType.HandleId, 0, ConfigBirthDayTextByDateAndType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBirthDayTextByDateAndType.HandleId, ConfigBirthDayTextByDateAndType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BirthDayText rootAsBirthDayText = BirthDayText.GetRootAsBirthDayText(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("BirthDayTextByDateAndType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Date);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1DateType);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBirthDayTextByDateAndType.HandleId, ConfigBirthDayTextByDateAndType.LogPair);
			return new BirthDayText?(rootAsBirthDayText);
		}

		// Token: 0x040006EB RID: 1771
		private const string DB = "db_birthday.db";

		// Token: 0x040006EC RID: 1772
		private const string FILE = "s.生日.xlsx";

		// Token: 0x040006ED RID: 1773
		private const string TABLE = "BirthDayText";

		// Token: 0x040006EE RID: 1774
		private const string COMMAND = "select BinData from `BirthDayText` where Date=? And DateType=?";

		// Token: 0x040006EF RID: 1775
		private const string KEY_PREFIX = "BirthDayTextByDateAndType";

		// Token: 0x040006F0 RID: 1776
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006F1 RID: 1777
		private static int HandleId;
	}
}
