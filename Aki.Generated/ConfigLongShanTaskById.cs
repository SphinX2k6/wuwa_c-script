using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004F0 RID: 1264
	public class ConfigLongShanTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DAB RID: 7595 RVA: 0x00100F64 File Offset: 0x000FF164
		static ConfigLongShanTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLongShanTaskById.CreateStaticDefaultValue), new Action(ConfigLongShanTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x00100F84 File Offset: 0x000FF184
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

		// Token: 0x06001DAD RID: 7597 RVA: 0x00101003 File Offset: 0x000FF203
		public static void ResetStaticDefaultValue()
		{
			ConfigLongShanTaskById.LogPair = null;
			ConfigLongShanTaskById.HandleId = 0;
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00101011 File Offset: 0x000FF211
		public static void Init()
		{
			ConfigLongShanTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigLongShanTaskById.HandleId, "db_longshanactivity.db", "select BinData from `LongShanTask` where TaskId=?");
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x0010102C File Offset: 0x000FF22C
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

		// Token: 0x04002274 RID: 8820
		private const string DB = "db_longshanactivity.db";

		// Token: 0x04002275 RID: 8821
		private const string FILE = "l.龙山主题活动.xlsx";

		// Token: 0x04002276 RID: 8822
		private const string TABLE = "LongShanTask";

		// Token: 0x04002277 RID: 8823
		private const string COMMAND = "select BinData from `LongShanTask` where TaskId=?";

		// Token: 0x04002278 RID: 8824
		private const string KEY_PREFIX = "LongShanTaskById";

		// Token: 0x04002279 RID: 8825
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400227A RID: 8826
		private static int HandleId;
	}
}
