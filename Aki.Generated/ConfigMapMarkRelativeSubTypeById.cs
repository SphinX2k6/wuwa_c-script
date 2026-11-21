using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000536 RID: 1334
	public class ConfigMapMarkRelativeSubTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F4F RID: 8015 RVA: 0x0010DB80 File Offset: 0x0010BD80
		static ConfigMapMarkRelativeSubTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkRelativeSubTypeById.CreateStaticDefaultValue), new Action(ConfigMapMarkRelativeSubTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x0010DBA0 File Offset: 0x0010BDA0
		public static void CreateStaticDefaultValue()
		{
			ConfigMapMarkRelativeSubTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapMarkRelativeSubTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "MapMarkRelativeSubType"),
				new ValueTuple<string, object>("语句", "select BinData from `MapMarkRelativeSubType` where Id=?")
			});
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x0010DC1F File Offset: 0x0010BE1F
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkRelativeSubTypeById.LogPair = null;
			ConfigMapMarkRelativeSubTypeById.HandleId = 0;
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x0010DC2D File Offset: 0x0010BE2D
		public static void Init()
		{
			ConfigMapMarkRelativeSubTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkRelativeSubTypeById.HandleId, "db_map_mark.db", "select BinData from `MapMarkRelativeSubType` where Id=?");
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x0010DC48 File Offset: 0x0010BE48
		public static MapMarkRelativeSubType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapMarkRelativeSubTypeById.HandleId, ConfigMapMarkRelativeSubTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapMarkRelativeSubTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MapMarkRelativeSubType?(MapMarkRelativeSubType.GetRootAsMapMarkRelativeSubType(configBuffer));
				}
			}
			ConfigMapMarkRelativeSubTypeById.LogPair.Clear();
			ConfigMapMarkRelativeSubTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMapMarkRelativeSubTypeById.HandleId, 1, p0Id, ConfigMapMarkRelativeSubTypeById.LogPair) || ConfigCommon.Step(ConfigMapMarkRelativeSubTypeById.HandleId, true, ConfigMapMarkRelativeSubTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMapMarkRelativeSubTypeById.HandleId, ConfigMapMarkRelativeSubTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapMarkRelativeSubTypeById.HandleId, 0, ConfigMapMarkRelativeSubTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMapMarkRelativeSubTypeById.HandleId, ConfigMapMarkRelativeSubTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MapMarkRelativeSubType rootAsMapMarkRelativeSubType = MapMarkRelativeSubType.GetRootAsMapMarkRelativeSubType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapMarkRelativeSubTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMapMarkRelativeSubTypeById.HandleId, ConfigMapMarkRelativeSubTypeById.LogPair);
			return new MapMarkRelativeSubType?(rootAsMapMarkRelativeSubType);
		}

		// Token: 0x0400245E RID: 9310
		private const string DB = "db_map_mark.db";

		// Token: 0x0400245F RID: 9311
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04002460 RID: 9312
		private const string TABLE = "MapMarkRelativeSubType";

		// Token: 0x04002461 RID: 9313
		private const string COMMAND = "select BinData from `MapMarkRelativeSubType` where Id=?";

		// Token: 0x04002462 RID: 9314
		private const string KEY_PREFIX = "MapMarkRelativeSubTypeById";

		// Token: 0x04002463 RID: 9315
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002464 RID: 9316
		private static int HandleId;
	}
}
