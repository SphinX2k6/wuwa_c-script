using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003A2 RID: 930
	public class ConfigGeographyTabTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015D2 RID: 5586 RVA: 0x000D8877 File Offset: 0x000D6A77
		static ConfigGeographyTabTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGeographyTabTypeById.CreateStaticDefaultValue), new Action(ConfigGeographyTabTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x000D8898 File Offset: 0x000D6A98
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

		// Token: 0x060015D4 RID: 5588 RVA: 0x000D8917 File Offset: 0x000D6B17
		public static void ResetStaticDefaultValue()
		{
			ConfigGeographyTabTypeById.LogPair = null;
			ConfigGeographyTabTypeById.HandleId = 0;
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x000D8925 File Offset: 0x000D6B25
		public static void Init()
		{
			ConfigGeographyTabTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigGeographyTabTypeById.HandleId, "db_handbook.db", "select BinData from `GeographyTabType` where Id=?");
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x000D8940 File Offset: 0x000D6B40
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

		// Token: 0x04001952 RID: 6482
		private const string DB = "db_handbook.db";

		// Token: 0x04001953 RID: 6483
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04001954 RID: 6484
		private const string TABLE = "GeographyTabType";

		// Token: 0x04001955 RID: 6485
		private const string COMMAND = "select BinData from `GeographyTabType` where Id=?";

		// Token: 0x04001956 RID: 6486
		private const string KEY_PREFIX = "GeographyTabTypeById";

		// Token: 0x04001957 RID: 6487
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001958 RID: 6488
		private static int HandleId;
	}
}
