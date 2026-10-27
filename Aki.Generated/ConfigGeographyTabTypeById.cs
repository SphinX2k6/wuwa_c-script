using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200038C RID: 908
	public class ConfigGeographyTabTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600154E RID: 5454 RVA: 0x000D2123 File Offset: 0x000D0323
		static ConfigGeographyTabTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGeographyTabTypeById.CreateStaticDefaultValue), new Action(ConfigGeographyTabTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x000D2144 File Offset: 0x000D0344
		public static void CreateStaticDefaultValue()
		{
			ConfigGeographyTabTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGeographyTabTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "GeographyTabType"),
				new ValueTuple<string, object>("语句", "select BinData from `GeographyTabType` where Id=?")
			});
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x000D21C3 File Offset: 0x000D03C3
		public static void ResetStaticDefaultValue()
		{
			ConfigGeographyTabTypeById.LogPair = null;
			ConfigGeographyTabTypeById.HandleId = 0;
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x000D21D1 File Offset: 0x000D03D1
		public static void Init()
		{
			ConfigGeographyTabTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigGeographyTabTypeById.HandleId, "db_handbook.db", "select BinData from `GeographyTabType` where Id=?");
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x000D21EC File Offset: 0x000D03EC
		public static GeographyTabType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGeographyTabTypeById.HandleId, ConfigGeographyTabTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GeographyTabTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GeographyTabType?(GeographyTabType.GetRootAsGeographyTabType(configBuffer));
				}
			}
			ConfigGeographyTabTypeById.LogPair.Clear();
			ConfigGeographyTabTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGeographyTabTypeById.HandleId, 1, p0Id, ConfigGeographyTabTypeById.LogPair) || ConfigCommon.Step(ConfigGeographyTabTypeById.HandleId, true, ConfigGeographyTabTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGeographyTabTypeById.HandleId, ConfigGeographyTabTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGeographyTabTypeById.HandleId, 0, ConfigGeographyTabTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGeographyTabTypeById.HandleId, ConfigGeographyTabTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GeographyTabType rootAsGeographyTabType = GeographyTabType.GetRootAsGeographyTabType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GeographyTabTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGeographyTabTypeById.HandleId, ConfigGeographyTabTypeById.LogPair);
			return new GeographyTabType?(rootAsGeographyTabType);
		}

		// Token: 0x040018B8 RID: 6328
		private const string DB = "db_handbook.db";

		// Token: 0x040018B9 RID: 6329
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x040018BA RID: 6330
		private const string TABLE = "GeographyTabType";

		// Token: 0x040018BB RID: 6331
		private const string COMMAND = "select BinData from `GeographyTabType` where Id=?";

		// Token: 0x040018BC RID: 6332
		private const string KEY_PREFIX = "GeographyTabTypeById";

		// Token: 0x040018BD RID: 6333
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018BE RID: 6334
		private static int HandleId;
	}
}
