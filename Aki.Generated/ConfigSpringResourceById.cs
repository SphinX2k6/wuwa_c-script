using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200098A RID: 2442
	public class ConfigSpringResourceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003950 RID: 14672 RVA: 0x0019D9FB File Offset: 0x0019BBFB
		static ConfigSpringResourceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringResourceById.CreateStaticDefaultValue), new Action(ConfigSpringResourceById.ResetStaticDefaultValue));
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x0019DA1C File Offset: 0x0019BC1C
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringResourceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringResourceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sprintsign.db"),
				new ValueTuple<string, object>("文件", "c.2.0春节签到.xlsx"),
				new ValueTuple<string, object>("表名", "SpringResource"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringResource` where Id=?")
			});
		}

		// Token: 0x06003952 RID: 14674 RVA: 0x0019DA9B File Offset: 0x0019BC9B
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringResourceById.LogPair = null;
			ConfigSpringResourceById.HandleId = 0;
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x0019DAA9 File Offset: 0x0019BCA9
		public static void Init()
		{
			ConfigSpringResourceById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringResourceById.HandleId, "db_sprintsign.db", "select BinData from `SpringResource` where Id=?");
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x0019DAC4 File Offset: 0x0019BCC4
		public static SpringResource? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringResourceById.HandleId, ConfigSpringResourceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringResourceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpringResource?(SpringResource.GetRootAsSpringResource(configBuffer));
				}
			}
			ConfigSpringResourceById.LogPair.Clear();
			ConfigSpringResourceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpringResourceById.HandleId, 1, p0Id, ConfigSpringResourceById.LogPair) || ConfigCommon.Step(ConfigSpringResourceById.HandleId, true, ConfigSpringResourceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpringResourceById.HandleId, ConfigSpringResourceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringResourceById.HandleId, 0, ConfigSpringResourceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpringResourceById.HandleId, ConfigSpringResourceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpringResource rootAsSpringResource = SpringResource.GetRootAsSpringResource(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringResourceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpringResourceById.HandleId, ConfigSpringResourceById.LogPair);
			return new SpringResource?(rootAsSpringResource);
		}

		// Token: 0x040042AC RID: 17068
		private const string DB = "db_sprintsign.db";

		// Token: 0x040042AD RID: 17069
		private const string FILE = "c.2.0春节签到.xlsx";

		// Token: 0x040042AE RID: 17070
		private const string TABLE = "SpringResource";

		// Token: 0x040042AF RID: 17071
		private const string COMMAND = "select BinData from `SpringResource` where Id=?";

		// Token: 0x040042B0 RID: 17072
		private const string KEY_PREFIX = "SpringResourceById";

		// Token: 0x040042B1 RID: 17073
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042B2 RID: 17074
		private static int HandleId;
	}
}
