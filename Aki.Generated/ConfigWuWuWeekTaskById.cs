using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AA5 RID: 2725
	public class ConfigWuWuWeekTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FF3 RID: 16371 RVA: 0x001C3F18 File Offset: 0x001C2118
		static ConfigWuWuWeekTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWuWuWeekTaskById.CreateStaticDefaultValue), new Action(ConfigWuWuWeekTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06003FF4 RID: 16372 RVA: 0x001C3F38 File Offset: 0x001C2138
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

		// Token: 0x06003FF5 RID: 16373 RVA: 0x001C3FB7 File Offset: 0x001C21B7
		public static void ResetStaticDefaultValue()
		{
			ConfigWuWuWeekTaskById.LogPair = null;
			ConfigWuWuWeekTaskById.HandleId = 0;
		}

		// Token: 0x06003FF6 RID: 16374 RVA: 0x001C3FC5 File Offset: 0x001C21C5
		public static void Init()
		{
			ConfigWuWuWeekTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigWuWuWeekTaskById.HandleId, "db_wuwutask.db", "select BinData from `WuWuWeekTask` where Id=?");
		}

		// Token: 0x06003FF7 RID: 16375 RVA: 0x001C3FE0 File Offset: 0x001C21E0
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

		// Token: 0x04004A69 RID: 19049
		private const string DB = "db_wuwutask.db";

		// Token: 0x04004A6A RID: 19050
		private const string FILE = "w.呜呜签到.xlsx";

		// Token: 0x04004A6B RID: 19051
		private const string TABLE = "WuWuWeekTask";

		// Token: 0x04004A6C RID: 19052
		private const string COMMAND = "select BinData from `WuWuWeekTask` where Id=?";

		// Token: 0x04004A6D RID: 19053
		private const string KEY_PREFIX = "WuWuWeekTaskById";

		// Token: 0x04004A6E RID: 19054
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A6F RID: 19055
		private static int HandleId;
	}
}
