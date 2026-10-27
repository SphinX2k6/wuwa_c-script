using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200038E RID: 910
	public class ConfigGeographyTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600155A RID: 5466 RVA: 0x000D24FF File Offset: 0x000D06FF
		static ConfigGeographyTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGeographyTypeById.CreateStaticDefaultValue), new Action(ConfigGeographyTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x000D2520 File Offset: 0x000D0720
		public static void CreateStaticDefaultValue()
		{
			ConfigGeographyTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGeographyTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "GeographyType"),
				new ValueTuple<string, object>("语句", "select BinData from `GeographyType` where Id=?")
			});
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x000D259F File Offset: 0x000D079F
		public static void ResetStaticDefaultValue()
		{
			ConfigGeographyTypeById.LogPair = null;
			ConfigGeographyTypeById.HandleId = 0;
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x000D25AD File Offset: 0x000D07AD
		public static void Init()
		{
			ConfigGeographyTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigGeographyTypeById.HandleId, "db_handbook.db", "select BinData from `GeographyType` where Id=?");
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x000D25C8 File Offset: 0x000D07C8
		public static GeographyType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGeographyTypeById.HandleId, ConfigGeographyTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GeographyTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GeographyType?(GeographyType.GetRootAsGeographyType(configBuffer));
				}
			}
			ConfigGeographyTypeById.LogPair.Clear();
			ConfigGeographyTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGeographyTypeById.HandleId, 1, p0Id, ConfigGeographyTypeById.LogPair) || ConfigCommon.Step(ConfigGeographyTypeById.HandleId, true, ConfigGeographyTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGeographyTypeById.HandleId, ConfigGeographyTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGeographyTypeById.HandleId, 0, ConfigGeographyTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGeographyTypeById.HandleId, ConfigGeographyTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GeographyType rootAsGeographyType = GeographyType.GetRootAsGeographyType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GeographyTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGeographyTypeById.HandleId, ConfigGeographyTypeById.LogPair);
			return new GeographyType?(rootAsGeographyType);
		}

		// Token: 0x040018C6 RID: 6342
		private const string DB = "db_handbook.db";

		// Token: 0x040018C7 RID: 6343
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x040018C8 RID: 6344
		private const string TABLE = "GeographyType";

		// Token: 0x040018C9 RID: 6345
		private const string COMMAND = "select BinData from `GeographyType` where Id=?";

		// Token: 0x040018CA RID: 6346
		private const string KEY_PREFIX = "GeographyTypeById";

		// Token: 0x040018CB RID: 6347
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018CC RID: 6348
		private static int HandleId;
	}
}
