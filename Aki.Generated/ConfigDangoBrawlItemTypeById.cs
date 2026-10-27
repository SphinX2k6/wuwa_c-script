using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001D0 RID: 464
	public class ConfigDangoBrawlItemTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AE3 RID: 2787 RVA: 0x0009714F File Offset: 0x0009534F
		static ConfigDangoBrawlItemTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlItemTypeById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlItemTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00097170 File Offset: 0x00095370
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

		// Token: 0x06000AE5 RID: 2789 RVA: 0x000971EF File Offset: 0x000953EF
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlItemTypeById.LogPair = null;
			ConfigDangoBrawlItemTypeById.HandleId = 0;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x000971FD File Offset: 0x000953FD
		public static void Init()
		{
			ConfigDangoBrawlItemTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlItemTypeById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlItemType` where Id=?");
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00097218 File Offset: 0x00095418
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

		// Token: 0x04000C94 RID: 3220
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000C95 RID: 3221
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000C96 RID: 3222
		private const string TABLE = "DangoBrawlItemType";

		// Token: 0x04000C97 RID: 3223
		private const string COMMAND = "select BinData from `DangoBrawlItemType` where Id=?";

		// Token: 0x04000C98 RID: 3224
		private const string KEY_PREFIX = "DangoBrawlItemTypeById";

		// Token: 0x04000C99 RID: 3225
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C9A RID: 3226
		private static int HandleId;
	}
}
