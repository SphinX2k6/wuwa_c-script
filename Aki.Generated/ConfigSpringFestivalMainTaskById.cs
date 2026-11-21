using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A50 RID: 2640
	public class ConfigSpringFestivalMainTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DF4 RID: 15860 RVA: 0x001BACFF File Offset: 0x001B8EFF
		static ConfigSpringFestivalMainTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalMainTaskById.CreateStaticDefaultValue), new Action(ConfigSpringFestivalMainTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x001BAD20 File Offset: 0x001B8F20
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

		// Token: 0x06003DF6 RID: 15862 RVA: 0x001BAD9F File Offset: 0x001B8F9F
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalMainTaskById.LogPair = null;
			ConfigSpringFestivalMainTaskById.HandleId = 0;
		}

		// Token: 0x06003DF7 RID: 15863 RVA: 0x001BADAD File Offset: 0x001B8FAD
		public static void Init()
		{
			ConfigSpringFestivalMainTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalMainTaskById.HandleId, "db_spring26.db", "select BinData from `SpringFestivalMainTask` where Id=?");
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x001BADC8 File Offset: 0x001B8FC8
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

		// Token: 0x04004816 RID: 18454
		private const string DB = "db_spring26.db";

		// Token: 0x04004817 RID: 18455
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004818 RID: 18456
		private const string TABLE = "SpringFestivalMainTask";

		// Token: 0x04004819 RID: 18457
		private const string COMMAND = "select BinData from `SpringFestivalMainTask` where Id=?";

		// Token: 0x0400481A RID: 18458
		private const string KEY_PREFIX = "SpringFestivalMainTaskById";

		// Token: 0x0400481B RID: 18459
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400481C RID: 18460
		private static int HandleId;
	}
}
