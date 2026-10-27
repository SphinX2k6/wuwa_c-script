using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000979 RID: 2425
	public class ConfigSpringFestivalByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038EA RID: 14570 RVA: 0x0019B590 File Offset: 0x00199790
		static ConfigSpringFestivalByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalByActivityId.CreateStaticDefaultValue), new Action(ConfigSpringFestivalByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060038EB RID: 14571 RVA: 0x0019B5B0 File Offset: 0x001997B0
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestival"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestival` where Id=?")
			});
		}

		// Token: 0x060038EC RID: 14572 RVA: 0x0019B62F File Offset: 0x0019982F
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalByActivityId.LogPair = null;
			ConfigSpringFestivalByActivityId.HandleId = 0;
		}

		// Token: 0x060038ED RID: 14573 RVA: 0x0019B63D File Offset: 0x0019983D
		public static void Init()
		{
			ConfigSpringFestivalByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalByActivityId.HandleId, "db_spring26.db", "select BinData from `SpringFestival` where Id=?");
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x0019B658 File Offset: 0x00199858
		public static SpringFestival? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalByActivityId.HandleId, ConfigSpringFestivalByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpringFestival?(SpringFestival.GetRootAsSpringFestival(configBuffer));
				}
			}
			ConfigSpringFestivalByActivityId.LogPair.Clear();
			ConfigSpringFestivalByActivityId.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpringFestivalByActivityId.HandleId, 1, p0Id, ConfigSpringFestivalByActivityId.LogPair) || ConfigCommon.Step(ConfigSpringFestivalByActivityId.HandleId, true, ConfigSpringFestivalByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpringFestivalByActivityId.HandleId, ConfigSpringFestivalByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalByActivityId.HandleId, 0, ConfigSpringFestivalByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpringFestivalByActivityId.HandleId, ConfigSpringFestivalByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpringFestival rootAsSpringFestival = SpringFestival.GetRootAsSpringFestival(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpringFestivalByActivityId.HandleId, ConfigSpringFestivalByActivityId.LogPair);
			return new SpringFestival?(rootAsSpringFestival);
		}

		// Token: 0x04004235 RID: 16949
		private const string DB = "db_spring26.db";

		// Token: 0x04004236 RID: 16950
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004237 RID: 16951
		private const string TABLE = "SpringFestival";

		// Token: 0x04004238 RID: 16952
		private const string COMMAND = "select BinData from `SpringFestival` where Id=?";

		// Token: 0x04004239 RID: 16953
		private const string KEY_PREFIX = "SpringFestivalByActivityId";

		// Token: 0x0400423A RID: 16954
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400423B RID: 16955
		private static int HandleId;
	}
}
