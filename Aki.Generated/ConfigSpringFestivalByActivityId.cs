using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A4E RID: 2638
	public class ConfigSpringFestivalByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DE8 RID: 15848 RVA: 0x001BA924 File Offset: 0x001B8B24
		static ConfigSpringFestivalByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalByActivityId.CreateStaticDefaultValue), new Action(ConfigSpringFestivalByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003DE9 RID: 15849 RVA: 0x001BA944 File Offset: 0x001B8B44
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

		// Token: 0x06003DEA RID: 15850 RVA: 0x001BA9C3 File Offset: 0x001B8BC3
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalByActivityId.LogPair = null;
			ConfigSpringFestivalByActivityId.HandleId = 0;
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x001BA9D1 File Offset: 0x001B8BD1
		public static void Init()
		{
			ConfigSpringFestivalByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalByActivityId.HandleId, "db_spring26.db", "select BinData from `SpringFestival` where Id=?");
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x001BA9EC File Offset: 0x001B8BEC
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

		// Token: 0x04004808 RID: 18440
		private const string DB = "db_spring26.db";

		// Token: 0x04004809 RID: 18441
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x0400480A RID: 18442
		private const string TABLE = "SpringFestival";

		// Token: 0x0400480B RID: 18443
		private const string COMMAND = "select BinData from `SpringFestival` where Id=?";

		// Token: 0x0400480C RID: 18444
		private const string KEY_PREFIX = "SpringFestivalByActivityId";

		// Token: 0x0400480D RID: 18445
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400480E RID: 18446
		private static int HandleId;
	}
}
