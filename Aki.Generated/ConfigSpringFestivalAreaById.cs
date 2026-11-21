using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A4C RID: 2636
	public class ConfigSpringFestivalAreaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DDC RID: 15836 RVA: 0x001BA493 File Offset: 0x001B8693
		static ConfigSpringFestivalAreaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalAreaById.CreateStaticDefaultValue), new Action(ConfigSpringFestivalAreaById.ResetStaticDefaultValue));
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x001BA4B4 File Offset: 0x001B86B4
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalAreaById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalAreaById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalArea"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalArea` where Id=?")
			});
		}

		// Token: 0x06003DDE RID: 15838 RVA: 0x001BA533 File Offset: 0x001B8733
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalAreaById.LogPair = null;
			ConfigSpringFestivalAreaById.HandleId = 0;
		}

		// Token: 0x06003DDF RID: 15839 RVA: 0x001BA541 File Offset: 0x001B8741
		public static void Init()
		{
			ConfigSpringFestivalAreaById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalAreaById.HandleId, "db_spring26.db", "select BinData from `SpringFestivalArea` where Id=?");
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x001BA55C File Offset: 0x001B875C
		public static SpringFestivalArea? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalAreaById.HandleId, ConfigSpringFestivalAreaById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpringFestivalArea?(SpringFestivalArea.GetRootAsSpringFestivalArea(configBuffer));
				}
			}
			ConfigSpringFestivalAreaById.LogPair.Clear();
			ConfigSpringFestivalAreaById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpringFestivalAreaById.HandleId, 1, p0Id, ConfigSpringFestivalAreaById.LogPair) || ConfigCommon.Step(ConfigSpringFestivalAreaById.HandleId, true, ConfigSpringFestivalAreaById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpringFestivalAreaById.HandleId, ConfigSpringFestivalAreaById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalAreaById.HandleId, 0, ConfigSpringFestivalAreaById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpringFestivalAreaById.HandleId, ConfigSpringFestivalAreaById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpringFestivalArea rootAsSpringFestivalArea = SpringFestivalArea.GetRootAsSpringFestivalArea(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpringFestivalAreaById.HandleId, ConfigSpringFestivalAreaById.LogPair);
			return new SpringFestivalArea?(rootAsSpringFestivalArea);
		}

		// Token: 0x040047FA RID: 18426
		private const string DB = "db_spring26.db";

		// Token: 0x040047FB RID: 18427
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x040047FC RID: 18428
		private const string TABLE = "SpringFestivalArea";

		// Token: 0x040047FD RID: 18429
		private const string COMMAND = "select BinData from `SpringFestivalArea` where Id=?";

		// Token: 0x040047FE RID: 18430
		private const string KEY_PREFIX = "SpringFestivalAreaById";

		// Token: 0x040047FF RID: 18431
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004800 RID: 18432
		private static int HandleId;
	}
}
