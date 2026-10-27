using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A99 RID: 2713
	public class ConfigWeeklyFrameHelpById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FAB RID: 16299 RVA: 0x001C2633 File Offset: 0x001C0833
		static ConfigWeeklyFrameHelpById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeeklyFrameHelpById.CreateStaticDefaultValue), new Action(ConfigWeeklyFrameHelpById.ResetStaticDefaultValue));
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x001C2654 File Offset: 0x001C0854
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

		// Token: 0x06003FAD RID: 16301 RVA: 0x001C26D3 File Offset: 0x001C08D3
		public static void ResetStaticDefaultValue()
		{
			ConfigWeeklyFrameHelpById.LogPair = null;
			ConfigWeeklyFrameHelpById.HandleId = 0;
		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x001C26E1 File Offset: 0x001C08E1
		public static void Init()
		{
			ConfigWeeklyFrameHelpById.HandleId = ConfigCommon.InitDataStatement(ConfigWeeklyFrameHelpById.HandleId, "db_weeklychallenge.db", "select BinData from `WeeklyFrameHelp` where Id = ?");
		}

		// Token: 0x06003FAF RID: 16303 RVA: 0x001C26FC File Offset: 0x001C08FC
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

		// Token: 0x04004A15 RID: 18965
		private const string DB = "db_weeklychallenge.db";

		// Token: 0x04004A16 RID: 18966
		private const string FILE = "z.周常框架.xlsx";

		// Token: 0x04004A17 RID: 18967
		private const string TABLE = "WeeklyFrameHelp";

		// Token: 0x04004A18 RID: 18968
		private const string COMMAND = "select BinData from `WeeklyFrameHelp` where Id = ?";

		// Token: 0x04004A19 RID: 18969
		private const string KEY_PREFIX = "WeeklyFrameHelpById";

		// Token: 0x04004A1A RID: 18970
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A1B RID: 18971
		private static int HandleId;
	}
}
