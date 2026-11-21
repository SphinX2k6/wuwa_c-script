using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B7A RID: 2938
	public class ConfigWuWuWeekTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060044F1 RID: 17649 RVA: 0x001E32AC File Offset: 0x001E14AC
		static ConfigWuWuWeekTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWuWuWeekTaskById.CreateStaticDefaultValue), new Action(ConfigWuWuWeekTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x060044F2 RID: 17650 RVA: 0x001E32CC File Offset: 0x001E14CC
		public static void CreateStaticDefaultValue()
		{
			ConfigWuWuWeekTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWuWuWeekTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_wuwutask.db"),
				new ValueTuple<string, object>("文件", "w.呜呜签到.xlsx"),
				new ValueTuple<string, object>("表名", "WuWuWeekTask"),
				new ValueTuple<string, object>("语句", "select BinData from `WuWuWeekTask` where Id=?")
			});
		}

		// Token: 0x060044F3 RID: 17651 RVA: 0x001E334B File Offset: 0x001E154B
		public static void ResetStaticDefaultValue()
		{
			ConfigWuWuWeekTaskById.LogPair = null;
			ConfigWuWuWeekTaskById.HandleId = 0;
		}

		// Token: 0x060044F4 RID: 17652 RVA: 0x001E3359 File Offset: 0x001E1559
		public static void Init()
		{
			ConfigWuWuWeekTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigWuWuWeekTaskById.HandleId, "db_wuwutask.db", "select BinData from `WuWuWeekTask` where Id=?");
		}

		// Token: 0x060044F5 RID: 17653 RVA: 0x001E3374 File Offset: 0x001E1574
		public static WuWuWeekTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWuWuWeekTaskById.HandleId, ConfigWuWuWeekTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WuWuWeekTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WuWuWeekTask?(WuWuWeekTask.GetRootAsWuWuWeekTask(configBuffer));
				}
			}
			ConfigWuWuWeekTaskById.LogPair.Clear();
			ConfigWuWuWeekTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWuWuWeekTaskById.HandleId, 1, p0Id, ConfigWuWuWeekTaskById.LogPair) || ConfigCommon.Step(ConfigWuWuWeekTaskById.HandleId, true, ConfigWuWuWeekTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWuWuWeekTaskById.HandleId, ConfigWuWuWeekTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWuWuWeekTaskById.HandleId, 0, ConfigWuWuWeekTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWuWuWeekTaskById.HandleId, ConfigWuWuWeekTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WuWuWeekTask rootAsWuWuWeekTask = WuWuWeekTask.GetRootAsWuWuWeekTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WuWuWeekTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWuWuWeekTaskById.HandleId, ConfigWuWuWeekTaskById.LogPair);
			return new WuWuWeekTask?(rootAsWuWuWeekTask);
		}

		// Token: 0x0400503C RID: 20540
		private const string DB = "db_wuwutask.db";

		// Token: 0x0400503D RID: 20541
		private const string FILE = "w.呜呜签到.xlsx";

		// Token: 0x0400503E RID: 20542
		private const string TABLE = "WuWuWeekTask";

		// Token: 0x0400503F RID: 20543
		private const string COMMAND = "select BinData from `WuWuWeekTask` where Id=?";

		// Token: 0x04005040 RID: 20544
		private const string KEY_PREFIX = "WuWuWeekTaskById";

		// Token: 0x04005041 RID: 20545
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04005042 RID: 20546
		private static int HandleId;
	}
}
