using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001E2 RID: 482
	public class ConfigDangoBrawlItemTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B4F RID: 2895 RVA: 0x0009D087 File Offset: 0x0009B287
		static ConfigDangoBrawlItemTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlItemTypeById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlItemTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0009D0A8 File Offset: 0x0009B2A8
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlItemTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlItemTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlItemType"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlItemType` where Id=?")
			});
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0009D127 File Offset: 0x0009B327
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlItemTypeById.LogPair = null;
			ConfigDangoBrawlItemTypeById.HandleId = 0;
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0009D135 File Offset: 0x0009B335
		public static void Init()
		{
			ConfigDangoBrawlItemTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlItemTypeById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlItemType` where Id=?");
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0009D150 File Offset: 0x0009B350
		public static DangoBrawlItemType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlItemTypeById.HandleId, ConfigDangoBrawlItemTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlItemTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlItemType?(DangoBrawlItemType.GetRootAsDangoBrawlItemType(configBuffer));
				}
			}
			ConfigDangoBrawlItemTypeById.LogPair.Clear();
			ConfigDangoBrawlItemTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlItemTypeById.HandleId, 1, p0Id, ConfigDangoBrawlItemTypeById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlItemTypeById.HandleId, true, ConfigDangoBrawlItemTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlItemTypeById.HandleId, ConfigDangoBrawlItemTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlItemTypeById.HandleId, 0, ConfigDangoBrawlItemTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlItemTypeById.HandleId, ConfigDangoBrawlItemTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlItemType rootAsDangoBrawlItemType = DangoBrawlItemType.GetRootAsDangoBrawlItemType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlItemTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlItemTypeById.HandleId, ConfigDangoBrawlItemTypeById.LogPair);
			return new DangoBrawlItemType?(rootAsDangoBrawlItemType);
		}

		// Token: 0x04000D12 RID: 3346
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D13 RID: 3347
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000D14 RID: 3348
		private const string TABLE = "DangoBrawlItemType";

		// Token: 0x04000D15 RID: 3349
		private const string COMMAND = "select BinData from `DangoBrawlItemType` where Id=?";

		// Token: 0x04000D16 RID: 3350
		private const string KEY_PREFIX = "DangoBrawlItemTypeById";

		// Token: 0x04000D17 RID: 3351
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D18 RID: 3352
		private static int HandleId;
	}
}
