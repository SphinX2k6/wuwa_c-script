using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B6E RID: 2926
	public class ConfigWeeklyFrameHelpById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060044A9 RID: 17577 RVA: 0x001E19C7 File Offset: 0x001DFBC7
		static ConfigWeeklyFrameHelpById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeeklyFrameHelpById.CreateStaticDefaultValue), new Action(ConfigWeeklyFrameHelpById.ResetStaticDefaultValue));
		}

		// Token: 0x060044AA RID: 17578 RVA: 0x001E19E8 File Offset: 0x001DFBE8
		public static void CreateStaticDefaultValue()
		{
			ConfigWeeklyFrameHelpById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeeklyFrameHelpById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklychallenge.db"),
				new ValueTuple<string, object>("文件", "z.周常框架.xlsx"),
				new ValueTuple<string, object>("表名", "WeeklyFrameHelp"),
				new ValueTuple<string, object>("语句", "select BinData from `WeeklyFrameHelp` where Id = ?")
			});
		}

		// Token: 0x060044AB RID: 17579 RVA: 0x001E1A67 File Offset: 0x001DFC67
		public static void ResetStaticDefaultValue()
		{
			ConfigWeeklyFrameHelpById.LogPair = null;
			ConfigWeeklyFrameHelpById.HandleId = 0;
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x001E1A75 File Offset: 0x001DFC75
		public static void Init()
		{
			ConfigWeeklyFrameHelpById.HandleId = ConfigCommon.InitDataStatement(ConfigWeeklyFrameHelpById.HandleId, "db_weeklychallenge.db", "select BinData from `WeeklyFrameHelp` where Id = ?");
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x001E1A90 File Offset: 0x001DFC90
		public static WeeklyFrameHelp? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeeklyFrameHelpById.HandleId, ConfigWeeklyFrameHelpById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeeklyFrameHelpById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeeklyFrameHelp?(WeeklyFrameHelp.GetRootAsWeeklyFrameHelp(configBuffer));
				}
			}
			ConfigWeeklyFrameHelpById.LogPair.Clear();
			ConfigWeeklyFrameHelpById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWeeklyFrameHelpById.HandleId, 1, p0Id, ConfigWeeklyFrameHelpById.LogPair) || ConfigCommon.Step(ConfigWeeklyFrameHelpById.HandleId, true, ConfigWeeklyFrameHelpById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeeklyFrameHelpById.HandleId, ConfigWeeklyFrameHelpById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeeklyFrameHelpById.HandleId, 0, ConfigWeeklyFrameHelpById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeeklyFrameHelpById.HandleId, ConfigWeeklyFrameHelpById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeeklyFrameHelp rootAsWeeklyFrameHelp = WeeklyFrameHelp.GetRootAsWeeklyFrameHelp(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeeklyFrameHelpById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeeklyFrameHelpById.HandleId, ConfigWeeklyFrameHelpById.LogPair);
			return new WeeklyFrameHelp?(rootAsWeeklyFrameHelp);
		}

		// Token: 0x04004FE8 RID: 20456
		private const string DB = "db_weeklychallenge.db";

		// Token: 0x04004FE9 RID: 20457
		private const string FILE = "z.周常框架.xlsx";

		// Token: 0x04004FEA RID: 20458
		private const string TABLE = "WeeklyFrameHelp";

		// Token: 0x04004FEB RID: 20459
		private const string COMMAND = "select BinData from `WeeklyFrameHelp` where Id = ?";

		// Token: 0x04004FEC RID: 20460
		private const string KEY_PREFIX = "WeeklyFrameHelpById";

		// Token: 0x04004FED RID: 20461
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004FEE RID: 20462
		private static int HandleId;
	}
}
