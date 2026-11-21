using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003A4 RID: 932
	public class ConfigGeographyTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015DE RID: 5598 RVA: 0x000D8C53 File Offset: 0x000D6E53
		static ConfigGeographyTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGeographyTypeById.CreateStaticDefaultValue), new Action(ConfigGeographyTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x000D8C74 File Offset: 0x000D6E74
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

		// Token: 0x060015E0 RID: 5600 RVA: 0x000D8CF3 File Offset: 0x000D6EF3
		public static void ResetStaticDefaultValue()
		{
			ConfigGeographyTypeById.LogPair = null;
			ConfigGeographyTypeById.HandleId = 0;
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x000D8D01 File Offset: 0x000D6F01
		public static void Init()
		{
			ConfigGeographyTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigGeographyTypeById.HandleId, "db_handbook.db", "select BinData from `GeographyType` where Id=?");
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x000D8D1C File Offset: 0x000D6F1C
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

		// Token: 0x04001960 RID: 6496
		private const string DB = "db_handbook.db";

		// Token: 0x04001961 RID: 6497
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04001962 RID: 6498
		private const string TABLE = "GeographyType";

		// Token: 0x04001963 RID: 6499
		private const string COMMAND = "select BinData from `GeographyType` where Id=?";

		// Token: 0x04001964 RID: 6500
		private const string KEY_PREFIX = "GeographyTypeById";

		// Token: 0x04001965 RID: 6501
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001966 RID: 6502
		private static int HandleId;
	}
}
