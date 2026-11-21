using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A5B RID: 2651
	public class ConfigSpringFestivalSubTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E36 RID: 15926 RVA: 0x001BC523 File Offset: 0x001BA723
		static ConfigSpringFestivalSubTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalSubTaskById.CreateStaticDefaultValue), new Action(ConfigSpringFestivalSubTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06003E37 RID: 15927 RVA: 0x001BC544 File Offset: 0x001BA744
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

		// Token: 0x06003E38 RID: 15928 RVA: 0x001BC5C3 File Offset: 0x001BA7C3
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalSubTaskById.LogPair = null;
			ConfigSpringFestivalSubTaskById.HandleId = 0;
		}

		// Token: 0x06003E39 RID: 15929 RVA: 0x001BC5D1 File Offset: 0x001BA7D1
		public static void Init()
		{
			ConfigSpringFestivalSubTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalSubTaskById.HandleId, "db_spring26.db", "select BinData from `SpringFestivalSubTask` where Id=?");
		}

		// Token: 0x06003E3A RID: 15930 RVA: 0x001BC5EC File Offset: 0x001BA7EC
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

		// Token: 0x04004863 RID: 18531
		private const string DB = "db_spring26.db";

		// Token: 0x04004864 RID: 18532
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004865 RID: 18533
		private const string TABLE = "SpringFestivalSubTask";

		// Token: 0x04004866 RID: 18534
		private const string COMMAND = "select BinData from `SpringFestivalSubTask` where Id=?";

		// Token: 0x04004867 RID: 18535
		private const string KEY_PREFIX = "SpringFestivalSubTaskById";

		// Token: 0x04004868 RID: 18536
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004869 RID: 18537
		private static int HandleId;
	}
}
