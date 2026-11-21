using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B6C RID: 2924
	public class ConfigWeeklyFrameAwardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600449D RID: 17565 RVA: 0x001E15EB File Offset: 0x001DF7EB
		static ConfigWeeklyFrameAwardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeeklyFrameAwardById.CreateStaticDefaultValue), new Action(ConfigWeeklyFrameAwardById.ResetStaticDefaultValue));
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x001E160C File Offset: 0x001DF80C
		public static void CreateStaticDefaultValue()
		{
			ConfigWeeklyFrameAwardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeeklyFrameAwardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklychallenge.db"),
				new ValueTuple<string, object>("文件", "z.周常框架.xlsx"),
				new ValueTuple<string, object>("表名", "WeeklyFrameAward"),
				new ValueTuple<string, object>("语句", "select BinData from `WeeklyFrameAward` where Id = ?")
			});
		}

		// Token: 0x0600449F RID: 17567 RVA: 0x001E168B File Offset: 0x001DF88B
		public static void ResetStaticDefaultValue()
		{
			ConfigWeeklyFrameAwardById.LogPair = null;
			ConfigWeeklyFrameAwardById.HandleId = 0;
		}

		// Token: 0x060044A0 RID: 17568 RVA: 0x001E1699 File Offset: 0x001DF899
		public static void Init()
		{
			ConfigWeeklyFrameAwardById.HandleId = ConfigCommon.InitDataStatement(ConfigWeeklyFrameAwardById.HandleId, "db_weeklychallenge.db", "select BinData from `WeeklyFrameAward` where Id = ?");
		}

		// Token: 0x060044A1 RID: 17569 RVA: 0x001E16B4 File Offset: 0x001DF8B4
		public static WeeklyFrameAward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeeklyFrameAwardById.HandleId, ConfigWeeklyFrameAwardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeeklyFrameAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeeklyFrameAward?(WeeklyFrameAward.GetRootAsWeeklyFrameAward(configBuffer));
				}
			}
			ConfigWeeklyFrameAwardById.LogPair.Clear();
			ConfigWeeklyFrameAwardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWeeklyFrameAwardById.HandleId, 1, p0Id, ConfigWeeklyFrameAwardById.LogPair) || ConfigCommon.Step(ConfigWeeklyFrameAwardById.HandleId, true, ConfigWeeklyFrameAwardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeeklyFrameAwardById.HandleId, ConfigWeeklyFrameAwardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeeklyFrameAwardById.HandleId, 0, ConfigWeeklyFrameAwardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeeklyFrameAwardById.HandleId, ConfigWeeklyFrameAwardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeeklyFrameAward rootAsWeeklyFrameAward = WeeklyFrameAward.GetRootAsWeeklyFrameAward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeeklyFrameAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeeklyFrameAwardById.HandleId, ConfigWeeklyFrameAwardById.LogPair);
			return new WeeklyFrameAward?(rootAsWeeklyFrameAward);
		}

		// Token: 0x04004FDA RID: 20442
		private const string DB = "db_weeklychallenge.db";

		// Token: 0x04004FDB RID: 20443
		private const string FILE = "z.周常框架.xlsx";

		// Token: 0x04004FDC RID: 20444
		private const string TABLE = "WeeklyFrameAward";

		// Token: 0x04004FDD RID: 20445
		private const string COMMAND = "select BinData from `WeeklyFrameAward` where Id = ?";

		// Token: 0x04004FDE RID: 20446
		private const string KEY_PREFIX = "WeeklyFrameAwardById";

		// Token: 0x04004FDF RID: 20447
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004FE0 RID: 20448
		private static int HandleId;
	}
}
