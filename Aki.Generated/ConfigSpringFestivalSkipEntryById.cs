using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A59 RID: 2649
	public class ConfigSpringFestivalSkipEntryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E2A RID: 15914 RVA: 0x001BC147 File Offset: 0x001BA347
		static ConfigSpringFestivalSkipEntryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalSkipEntryById.CreateStaticDefaultValue), new Action(ConfigSpringFestivalSkipEntryById.ResetStaticDefaultValue));
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x001BC168 File Offset: 0x001BA368
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalSkipEntryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalSkipEntryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalSkipEntry"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalSkipEntry` where Id=?")
			});
		}

		// Token: 0x06003E2C RID: 15916 RVA: 0x001BC1E7 File Offset: 0x001BA3E7
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalSkipEntryById.LogPair = null;
			ConfigSpringFestivalSkipEntryById.HandleId = 0;
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x001BC1F5 File Offset: 0x001BA3F5
		public static void Init()
		{
			ConfigSpringFestivalSkipEntryById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalSkipEntryById.HandleId, "db_spring26.db", "select BinData from `SpringFestivalSkipEntry` where Id=?");
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x001BC210 File Offset: 0x001BA410
		public static SpringFestivalSkipEntry? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalSkipEntryById.HandleId, ConfigSpringFestivalSkipEntryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalSkipEntryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpringFestivalSkipEntry?(SpringFestivalSkipEntry.GetRootAsSpringFestivalSkipEntry(configBuffer));
				}
			}
			ConfigSpringFestivalSkipEntryById.LogPair.Clear();
			ConfigSpringFestivalSkipEntryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpringFestivalSkipEntryById.HandleId, 1, p0Id, ConfigSpringFestivalSkipEntryById.LogPair) || ConfigCommon.Step(ConfigSpringFestivalSkipEntryById.HandleId, true, ConfigSpringFestivalSkipEntryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpringFestivalSkipEntryById.HandleId, ConfigSpringFestivalSkipEntryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalSkipEntryById.HandleId, 0, ConfigSpringFestivalSkipEntryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpringFestivalSkipEntryById.HandleId, ConfigSpringFestivalSkipEntryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpringFestivalSkipEntry rootAsSpringFestivalSkipEntry = SpringFestivalSkipEntry.GetRootAsSpringFestivalSkipEntry(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalSkipEntryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpringFestivalSkipEntryById.HandleId, ConfigSpringFestivalSkipEntryById.LogPair);
			return new SpringFestivalSkipEntry?(rootAsSpringFestivalSkipEntry);
		}

		// Token: 0x04004855 RID: 18517
		private const string DB = "db_spring26.db";

		// Token: 0x04004856 RID: 18518
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004857 RID: 18519
		private const string TABLE = "SpringFestivalSkipEntry";

		// Token: 0x04004858 RID: 18520
		private const string COMMAND = "select BinData from `SpringFestivalSkipEntry` where Id=?";

		// Token: 0x04004859 RID: 18521
		private const string KEY_PREFIX = "SpringFestivalSkipEntryById";

		// Token: 0x0400485A RID: 18522
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400485B RID: 18523
		private static int HandleId;
	}
}
