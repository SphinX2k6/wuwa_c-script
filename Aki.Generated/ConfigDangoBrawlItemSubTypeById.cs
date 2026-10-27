using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001CE RID: 462
	public class ConfigDangoBrawlItemSubTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AD7 RID: 2775 RVA: 0x00096D73 File Offset: 0x00094F73
		static ConfigDangoBrawlItemSubTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlItemSubTypeById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlItemSubTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00096D94 File Offset: 0x00094F94
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlItemSubTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlItemSubTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlItemSubType"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlItemSubType` where Id=?")
			});
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00096E13 File Offset: 0x00095013
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlItemSubTypeById.LogPair = null;
			ConfigDangoBrawlItemSubTypeById.HandleId = 0;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00096E21 File Offset: 0x00095021
		public static void Init()
		{
			ConfigDangoBrawlItemSubTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlItemSubTypeById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlItemSubType` where Id=?");
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00096E3C File Offset: 0x0009503C
		public static DangoBrawlItemSubType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlItemSubTypeById.HandleId, ConfigDangoBrawlItemSubTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlItemSubTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlItemSubType?(DangoBrawlItemSubType.GetRootAsDangoBrawlItemSubType(configBuffer));
				}
			}
			ConfigDangoBrawlItemSubTypeById.LogPair.Clear();
			ConfigDangoBrawlItemSubTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlItemSubTypeById.HandleId, 1, p0Id, ConfigDangoBrawlItemSubTypeById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlItemSubTypeById.HandleId, true, ConfigDangoBrawlItemSubTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlItemSubTypeById.HandleId, ConfigDangoBrawlItemSubTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlItemSubTypeById.HandleId, 0, ConfigDangoBrawlItemSubTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlItemSubTypeById.HandleId, ConfigDangoBrawlItemSubTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlItemSubType rootAsDangoBrawlItemSubType = DangoBrawlItemSubType.GetRootAsDangoBrawlItemSubType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlItemSubTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlItemSubTypeById.HandleId, ConfigDangoBrawlItemSubTypeById.LogPair);
			return new DangoBrawlItemSubType?(rootAsDangoBrawlItemSubType);
		}

		// Token: 0x04000C86 RID: 3206
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000C87 RID: 3207
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000C88 RID: 3208
		private const string TABLE = "DangoBrawlItemSubType";

		// Token: 0x04000C89 RID: 3209
		private const string COMMAND = "select BinData from `DangoBrawlItemSubType` where Id=?";

		// Token: 0x04000C8A RID: 3210
		private const string KEY_PREFIX = "DangoBrawlItemSubTypeById";

		// Token: 0x04000C8B RID: 3211
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C8C RID: 3212
		private static int HandleId;
	}
}
