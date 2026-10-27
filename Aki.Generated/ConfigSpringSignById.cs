using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200098E RID: 2446
	public class ConfigSpringSignById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003968 RID: 14696 RVA: 0x0019E1A3 File Offset: 0x0019C3A3
		static ConfigSpringSignById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringSignById.CreateStaticDefaultValue), new Action(ConfigSpringSignById.ResetStaticDefaultValue));
		}

		// Token: 0x06003969 RID: 14697 RVA: 0x0019E1C4 File Offset: 0x0019C3C4
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

		// Token: 0x0600396A RID: 14698 RVA: 0x0019E243 File Offset: 0x0019C443
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringSignById.LogPair = null;
			ConfigSpringSignById.HandleId = 0;
		}

		// Token: 0x0600396B RID: 14699 RVA: 0x0019E251 File Offset: 0x0019C451
		public static void Init()
		{
			ConfigSpringSignById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringSignById.HandleId, "db_sprintsign.db", "select BinData from `SpringSign` where Id=?");
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x0019E26C File Offset: 0x0019C46C
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

		// Token: 0x040042C8 RID: 17096
		private const string DB = "db_sprintsign.db";

		// Token: 0x040042C9 RID: 17097
		private const string FILE = "c.2.0春节签到.xlsx";

		// Token: 0x040042CA RID: 17098
		private const string TABLE = "SpringSign";

		// Token: 0x040042CB RID: 17099
		private const string COMMAND = "select BinData from `SpringSign` where Id=?";

		// Token: 0x040042CC RID: 17100
		private const string KEY_PREFIX = "SpringSignById";

		// Token: 0x040042CD RID: 17101
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042CE RID: 17102
		private static int HandleId;
	}
}
