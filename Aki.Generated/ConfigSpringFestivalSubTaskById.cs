using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000986 RID: 2438
	public class ConfigSpringFestivalSubTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003938 RID: 14648 RVA: 0x0019D18F File Offset: 0x0019B38F
		static ConfigSpringFestivalSubTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalSubTaskById.CreateStaticDefaultValue), new Action(ConfigSpringFestivalSubTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06003939 RID: 14649 RVA: 0x0019D1B0 File Offset: 0x0019B3B0
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalSubTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalSubTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalSubTask"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalSubTask` where Id=?")
			});
		}

		// Token: 0x0600393A RID: 14650 RVA: 0x0019D22F File Offset: 0x0019B42F
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalSubTaskById.LogPair = null;
			ConfigSpringFestivalSubTaskById.HandleId = 0;
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x0019D23D File Offset: 0x0019B43D
		public static void Init()
		{
			ConfigSpringFestivalSubTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalSubTaskById.HandleId, "db_spring26.db", "select BinData from `SpringFestivalSubTask` where Id=?");
		}

		// Token: 0x0600393C RID: 14652 RVA: 0x0019D258 File Offset: 0x0019B458
		public static SpringFestivalSubTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalSubTaskById.HandleId, ConfigSpringFestivalSubTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalSubTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpringFestivalSubTask?(SpringFestivalSubTask.GetRootAsSpringFestivalSubTask(configBuffer));
				}
			}
			ConfigSpringFestivalSubTaskById.LogPair.Clear();
			ConfigSpringFestivalSubTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpringFestivalSubTaskById.HandleId, 1, p0Id, ConfigSpringFestivalSubTaskById.LogPair) || ConfigCommon.Step(ConfigSpringFestivalSubTaskById.HandleId, true, ConfigSpringFestivalSubTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpringFestivalSubTaskById.HandleId, ConfigSpringFestivalSubTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalSubTaskById.HandleId, 0, ConfigSpringFestivalSubTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpringFestivalSubTaskById.HandleId, ConfigSpringFestivalSubTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpringFestivalSubTask rootAsSpringFestivalSubTask = SpringFestivalSubTask.GetRootAsSpringFestivalSubTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalSubTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpringFestivalSubTaskById.HandleId, ConfigSpringFestivalSubTaskById.LogPair);
			return new SpringFestivalSubTask?(rootAsSpringFestivalSubTask);
		}

		// Token: 0x04004290 RID: 17040
		private const string DB = "db_spring26.db";

		// Token: 0x04004291 RID: 17041
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004292 RID: 17042
		private const string TABLE = "SpringFestivalSubTask";

		// Token: 0x04004293 RID: 17043
		private const string COMMAND = "select BinData from `SpringFestivalSubTask` where Id=?";

		// Token: 0x04004294 RID: 17044
		private const string KEY_PREFIX = "SpringFestivalSubTaskById";

		// Token: 0x04004295 RID: 17045
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004296 RID: 17046
		private static int HandleId;
	}
}
