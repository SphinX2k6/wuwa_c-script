using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A63 RID: 2659
	public class ConfigSpringSignById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E66 RID: 15974 RVA: 0x001BD537 File Offset: 0x001BB737
		static ConfigSpringSignById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringSignById.CreateStaticDefaultValue), new Action(ConfigSpringSignById.ResetStaticDefaultValue));
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x001BD558 File Offset: 0x001BB758
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringSignById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringSignById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sprintsign.db"),
				new ValueTuple<string, object>("文件", "c.2.0春节签到.xlsx"),
				new ValueTuple<string, object>("表名", "SpringSign"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringSign` where Id=?")
			});
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x001BD5D7 File Offset: 0x001BB7D7
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringSignById.LogPair = null;
			ConfigSpringSignById.HandleId = 0;
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x001BD5E5 File Offset: 0x001BB7E5
		public static void Init()
		{
			ConfigSpringSignById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringSignById.HandleId, "db_sprintsign.db", "select BinData from `SpringSign` where Id=?");
		}

		// Token: 0x06003E6A RID: 15978 RVA: 0x001BD600 File Offset: 0x001BB800
		public static SpringSign? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringSignById.HandleId, ConfigSpringSignById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringSignById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpringSign?(SpringSign.GetRootAsSpringSign(configBuffer));
				}
			}
			ConfigSpringSignById.LogPair.Clear();
			ConfigSpringSignById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpringSignById.HandleId, 1, p0Id, ConfigSpringSignById.LogPair) || ConfigCommon.Step(ConfigSpringSignById.HandleId, true, ConfigSpringSignById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpringSignById.HandleId, ConfigSpringSignById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringSignById.HandleId, 0, ConfigSpringSignById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpringSignById.HandleId, ConfigSpringSignById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpringSign rootAsSpringSign = SpringSign.GetRootAsSpringSign(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringSignById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpringSignById.HandleId, ConfigSpringSignById.LogPair);
			return new SpringSign?(rootAsSpringSign);
		}

		// Token: 0x0400489B RID: 18587
		private const string DB = "db_sprintsign.db";

		// Token: 0x0400489C RID: 18588
		private const string FILE = "c.2.0春节签到.xlsx";

		// Token: 0x0400489D RID: 18589
		private const string TABLE = "SpringSign";

		// Token: 0x0400489E RID: 18590
		private const string COMMAND = "select BinData from `SpringSign` where Id=?";

		// Token: 0x0400489F RID: 18591
		private const string KEY_PREFIX = "SpringSignById";

		// Token: 0x040048A0 RID: 18592
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048A1 RID: 18593
		private static int HandleId;
	}
}
