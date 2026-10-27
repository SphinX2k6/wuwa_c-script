using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000F2 RID: 242
	public class ConfigBirthDayTextByDateAndType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005AD RID: 1453 RVA: 0x00079C88 File Offset: 0x00077E88
		static ConfigBirthDayTextByDateAndType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBirthDayTextByDateAndType.CreateStaticDefaultValue), new Action(ConfigBirthDayTextByDateAndType.ResetStaticDefaultValue));
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00079CA8 File Offset: 0x00077EA8
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

		// Token: 0x060005AF RID: 1455 RVA: 0x00079D27 File Offset: 0x00077F27
		public static void ResetStaticDefaultValue()
		{
			ConfigBirthDayTextByDateAndType.LogPair = null;
			ConfigBirthDayTextByDateAndType.HandleId = 0;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00079D35 File Offset: 0x00077F35
		public static void Init()
		{
			ConfigBirthDayTextByDateAndType.HandleId = ConfigCommon.InitDataStatement(ConfigBirthDayTextByDateAndType.HandleId, "db_birthday.db", "select BinData from `BirthDayText` where Date=? And DateType=?");
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00079D50 File Offset: 0x00077F50
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

		// Token: 0x04000682 RID: 1666
		private const string DB = "db_birthday.db";

		// Token: 0x04000683 RID: 1667
		private const string FILE = "s.生日.xlsx";

		// Token: 0x04000684 RID: 1668
		private const string TABLE = "BirthDayText";

		// Token: 0x04000685 RID: 1669
		private const string COMMAND = "select BinData from `BirthDayText` where Date=? And DateType=?";

		// Token: 0x04000686 RID: 1670
		private const string KEY_PREFIX = "BirthDayTextByDateAndType";

		// Token: 0x04000687 RID: 1671
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000688 RID: 1672
		private static int HandleId;
	}
}
