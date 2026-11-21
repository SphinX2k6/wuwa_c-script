using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000526 RID: 1318
	public class ConfigMapBorderByBorderIdAndMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EEF RID: 7919 RVA: 0x0010B860 File Offset: 0x00109A60
		static ConfigMapBorderByBorderIdAndMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapBorderByBorderIdAndMapId.CreateStaticDefaultValue), new Action(ConfigMapBorderByBorderIdAndMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x0010B880 File Offset: 0x00109A80
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

		// Token: 0x06001EF1 RID: 7921 RVA: 0x0010B8FF File Offset: 0x00109AFF
		public static void ResetStaticDefaultValue()
		{
			ConfigMapBorderByBorderIdAndMapId.LogPair = null;
			ConfigMapBorderByBorderIdAndMapId.HandleId = 0;
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x0010B90D File Offset: 0x00109B0D
		public static void Init()
		{
			ConfigMapBorderByBorderIdAndMapId.HandleId = ConfigCommon.InitDataStatement(ConfigMapBorderByBorderIdAndMapId.HandleId, "db_map.db", "select BinData from `MapBorder` where BorderId=? and MapId=?");
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x0010B928 File Offset: 0x00109B28
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

		// Token: 0x040023EE RID: 9198
		private const string DB = "db_map.db";

		// Token: 0x040023EF RID: 9199
		private const string FILE = "d.地图.xlsx";

		// Token: 0x040023F0 RID: 9200
		private const string TABLE = "MapBorder";

		// Token: 0x040023F1 RID: 9201
		private const string COMMAND = "select BinData from `MapBorder` where BorderId=? and MapId=?";

		// Token: 0x040023F2 RID: 9202
		private const string KEY_PREFIX = "MapBorderByBorderIdAndMapId";

		// Token: 0x040023F3 RID: 9203
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023F4 RID: 9204
		private static int HandleId;
	}
}
