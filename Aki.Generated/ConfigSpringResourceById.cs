using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A5F RID: 2655
	public class ConfigSpringResourceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E4E RID: 15950 RVA: 0x001BCD8F File Offset: 0x001BAF8F
		static ConfigSpringResourceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringResourceById.CreateStaticDefaultValue), new Action(ConfigSpringResourceById.ResetStaticDefaultValue));
		}

		// Token: 0x06003E4F RID: 15951 RVA: 0x001BCDB0 File Offset: 0x001BAFB0
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

		// Token: 0x06003E50 RID: 15952 RVA: 0x001BCE2F File Offset: 0x001BB02F
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringResourceById.LogPair = null;
			ConfigSpringResourceById.HandleId = 0;
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x001BCE3D File Offset: 0x001BB03D
		public static void Init()
		{
			ConfigSpringResourceById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringResourceById.HandleId, "db_sprintsign.db", "select BinData from `SpringResource` where Id=?");
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x001BCE58 File Offset: 0x001BB058
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

		// Token: 0x0400487F RID: 18559
		private const string DB = "db_sprintsign.db";

		// Token: 0x04004880 RID: 18560
		private const string FILE = "c.2.0春节签到.xlsx";

		// Token: 0x04004881 RID: 18561
		private const string TABLE = "SpringResource";

		// Token: 0x04004882 RID: 18562
		private const string COMMAND = "select BinData from `SpringResource` where Id=?";

		// Token: 0x04004883 RID: 18563
		private const string KEY_PREFIX = "SpringResourceById";

		// Token: 0x04004884 RID: 18564
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004885 RID: 18565
		private static int HandleId;
	}
}
