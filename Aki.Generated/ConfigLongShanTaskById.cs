using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000506 RID: 1286
	public class ConfigLongShanTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E2F RID: 7727 RVA: 0x001076B8 File Offset: 0x001058B8
		static ConfigLongShanTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLongShanTaskById.CreateStaticDefaultValue), new Action(ConfigLongShanTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x001076D8 File Offset: 0x001058D8
		public static void CreateStaticDefaultValue()
		{
			ConfigLongShanTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLongShanTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_longshanactivity.db"),
				new ValueTuple<string, object>("文件", "l.龙山主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "LongShanTask"),
				new ValueTuple<string, object>("语句", "select BinData from `LongShanTask` where TaskId=?")
			});
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x00107757 File Offset: 0x00105957
		public static void ResetStaticDefaultValue()
		{
			ConfigLongShanTaskById.LogPair = null;
			ConfigLongShanTaskById.HandleId = 0;
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x00107765 File Offset: 0x00105965
		public static void Init()
		{
			ConfigLongShanTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigLongShanTaskById.HandleId, "db_longshanactivity.db", "select BinData from `LongShanTask` where TaskId=?");
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x00107780 File Offset: 0x00105980
		public static LongShanTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLongShanTaskById.HandleId, ConfigLongShanTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LongShanTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LongShanTask?(LongShanTask.GetRootAsLongShanTask(configBuffer));
				}
			}
			ConfigLongShanTaskById.LogPair.Clear();
			ConfigLongShanTaskById.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigLongShanTaskById.HandleId, 1, p0TaskId, ConfigLongShanTaskById.LogPair) || ConfigCommon.Step(ConfigLongShanTaskById.HandleId, true, ConfigLongShanTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLongShanTaskById.HandleId, ConfigLongShanTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLongShanTaskById.HandleId, 0, ConfigLongShanTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLongShanTaskById.HandleId, ConfigLongShanTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LongShanTask rootAsLongShanTask = LongShanTask.GetRootAsLongShanTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LongShanTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLongShanTaskById.HandleId, ConfigLongShanTaskById.LogPair);
			return new LongShanTask?(rootAsLongShanTask);
		}

		// Token: 0x0400230E RID: 8974
		private const string DB = "db_longshanactivity.db";

		// Token: 0x0400230F RID: 8975
		private const string FILE = "l.龙山主题活动.xlsx";

		// Token: 0x04002310 RID: 8976
		private const string TABLE = "LongShanTask";

		// Token: 0x04002311 RID: 8977
		private const string COMMAND = "select BinData from `LongShanTask` where TaskId=?";

		// Token: 0x04002312 RID: 8978
		private const string KEY_PREFIX = "LongShanTaskById";

		// Token: 0x04002313 RID: 8979
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002314 RID: 8980
		private static int HandleId;
	}
}
