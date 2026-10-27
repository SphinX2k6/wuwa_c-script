using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200097B RID: 2427
	public class ConfigSpringFestivalMainTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038F6 RID: 14582 RVA: 0x0019B96B File Offset: 0x00199B6B
		static ConfigSpringFestivalMainTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalMainTaskById.CreateStaticDefaultValue), new Action(ConfigSpringFestivalMainTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x060038F7 RID: 14583 RVA: 0x0019B98C File Offset: 0x00199B8C
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalMainTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalMainTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalMainTask"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalMainTask` where Id=?")
			});
		}

		// Token: 0x060038F8 RID: 14584 RVA: 0x0019BA0B File Offset: 0x00199C0B
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalMainTaskById.LogPair = null;
			ConfigSpringFestivalMainTaskById.HandleId = 0;
		}

		// Token: 0x060038F9 RID: 14585 RVA: 0x0019BA19 File Offset: 0x00199C19
		public static void Init()
		{
			ConfigSpringFestivalMainTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalMainTaskById.HandleId, "db_spring26.db", "select BinData from `SpringFestivalMainTask` where Id=?");
		}

		// Token: 0x060038FA RID: 14586 RVA: 0x0019BA34 File Offset: 0x00199C34
		public static SpringFestivalMainTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalMainTaskById.HandleId, ConfigSpringFestivalMainTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalMainTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpringFestivalMainTask?(SpringFestivalMainTask.GetRootAsSpringFestivalMainTask(configBuffer));
				}
			}
			ConfigSpringFestivalMainTaskById.LogPair.Clear();
			ConfigSpringFestivalMainTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpringFestivalMainTaskById.HandleId, 1, p0Id, ConfigSpringFestivalMainTaskById.LogPair) || ConfigCommon.Step(ConfigSpringFestivalMainTaskById.HandleId, true, ConfigSpringFestivalMainTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpringFestivalMainTaskById.HandleId, ConfigSpringFestivalMainTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalMainTaskById.HandleId, 0, ConfigSpringFestivalMainTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpringFestivalMainTaskById.HandleId, ConfigSpringFestivalMainTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpringFestivalMainTask rootAsSpringFestivalMainTask = SpringFestivalMainTask.GetRootAsSpringFestivalMainTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalMainTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpringFestivalMainTaskById.HandleId, ConfigSpringFestivalMainTaskById.LogPair);
			return new SpringFestivalMainTask?(rootAsSpringFestivalMainTask);
		}

		// Token: 0x04004243 RID: 16963
		private const string DB = "db_spring26.db";

		// Token: 0x04004244 RID: 16964
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004245 RID: 16965
		private const string TABLE = "SpringFestivalMainTask";

		// Token: 0x04004246 RID: 16966
		private const string COMMAND = "select BinData from `SpringFestivalMainTask` where Id=?";

		// Token: 0x04004247 RID: 16967
		private const string KEY_PREFIX = "SpringFestivalMainTaskById";

		// Token: 0x04004248 RID: 16968
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004249 RID: 16969
		private static int HandleId;
	}
}
