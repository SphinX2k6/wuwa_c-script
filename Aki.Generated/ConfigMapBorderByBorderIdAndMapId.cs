using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000510 RID: 1296
	public class ConfigMapBorderByBorderIdAndMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E6B RID: 7787 RVA: 0x0010510C File Offset: 0x0010330C
		static ConfigMapBorderByBorderIdAndMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapBorderByBorderIdAndMapId.CreateStaticDefaultValue), new Action(ConfigMapBorderByBorderIdAndMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x0010512C File Offset: 0x0010332C
		public static void CreateStaticDefaultValue()
		{
			ConfigMapBorderByBorderIdAndMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapBorderByBorderIdAndMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map.db"),
				new ValueTuple<string, object>("文件", "d.地图.xlsx"),
				new ValueTuple<string, object>("表名", "MapBorder"),
				new ValueTuple<string, object>("语句", "select BinData from `MapBorder` where BorderId=? and MapId=?")
			});
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x001051AB File Offset: 0x001033AB
		public static void ResetStaticDefaultValue()
		{
			ConfigMapBorderByBorderIdAndMapId.LogPair = null;
			ConfigMapBorderByBorderIdAndMapId.HandleId = 0;
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x001051B9 File Offset: 0x001033B9
		public static void Init()
		{
			ConfigMapBorderByBorderIdAndMapId.HandleId = ConfigCommon.InitDataStatement(ConfigMapBorderByBorderIdAndMapId.HandleId, "db_map.db", "select BinData from `MapBorder` where BorderId=? and MapId=?");
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x001051D4 File Offset: 0x001033D4
		public static MapBorder? GetConfig(int p0BorderId, int p1MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapBorderByBorderIdAndMapId.HandleId, ConfigMapBorderByBorderIdAndMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("MapBorderByBorderIdAndMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BorderId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1MapId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MapBorder?(MapBorder.GetRootAsMapBorder(configBuffer));
				}
			}
			ConfigMapBorderByBorderIdAndMapId.LogPair.Clear();
			ConfigMapBorderByBorderIdAndMapId.LogPair.Add(new ValueTuple<string, object>("BorderId", p0BorderId));
			ConfigMapBorderByBorderIdAndMapId.LogPair.Add(new ValueTuple<string, object>("MapId", p1MapId));
			if (!ConfigCommon.BindInt(ConfigMapBorderByBorderIdAndMapId.HandleId, 1, p0BorderId, ConfigMapBorderByBorderIdAndMapId.LogPair) || !ConfigCommon.BindInt(ConfigMapBorderByBorderIdAndMapId.HandleId, 2, p1MapId, ConfigMapBorderByBorderIdAndMapId.LogPair) || ConfigCommon.Step(ConfigMapBorderByBorderIdAndMapId.HandleId, true, ConfigMapBorderByBorderIdAndMapId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMapBorderByBorderIdAndMapId.HandleId, ConfigMapBorderByBorderIdAndMapId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapBorderByBorderIdAndMapId.HandleId, 0, ConfigMapBorderByBorderIdAndMapId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMapBorderByBorderIdAndMapId.HandleId, ConfigMapBorderByBorderIdAndMapId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MapBorder rootAsMapBorder = MapBorder.GetRootAsMapBorder(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("MapBorderByBorderIdAndMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BorderId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1MapId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMapBorderByBorderIdAndMapId.HandleId, ConfigMapBorderByBorderIdAndMapId.LogPair);
			return new MapBorder?(rootAsMapBorder);
		}

		// Token: 0x04002354 RID: 9044
		private const string DB = "db_map.db";

		// Token: 0x04002355 RID: 9045
		private const string FILE = "d.地图.xlsx";

		// Token: 0x04002356 RID: 9046
		private const string TABLE = "MapBorder";

		// Token: 0x04002357 RID: 9047
		private const string COMMAND = "select BinData from `MapBorder` where BorderId=? and MapId=?";

		// Token: 0x04002358 RID: 9048
		private const string KEY_PREFIX = "MapBorderByBorderIdAndMapId";

		// Token: 0x04002359 RID: 9049
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400235A RID: 9050
		private static int HandleId;
	}
}
