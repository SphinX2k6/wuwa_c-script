using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000525 RID: 1317
	public class ConfigMapBorderByBorderId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EE9 RID: 7913 RVA: 0x0010B617 File Offset: 0x00109817
		static ConfigMapBorderByBorderId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapBorderByBorderId.CreateStaticDefaultValue), new Action(ConfigMapBorderByBorderId.ResetStaticDefaultValue));
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x0010B638 File Offset: 0x00109838
		public static void CreateStaticDefaultValue()
		{
			ConfigMapBorderByBorderId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapBorderByBorderId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map.db"),
				new ValueTuple<string, object>("文件", "d.地图.xlsx"),
				new ValueTuple<string, object>("表名", "MapBorder"),
				new ValueTuple<string, object>("语句", "select BinData from `MapBorder` where BorderId=?")
			});
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x0010B6B7 File Offset: 0x001098B7
		public static void ResetStaticDefaultValue()
		{
			ConfigMapBorderByBorderId.LogPair = null;
			ConfigMapBorderByBorderId.HandleId = 0;
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x0010B6C5 File Offset: 0x001098C5
		public static void Init()
		{
			ConfigMapBorderByBorderId.HandleId = ConfigCommon.InitDataStatement(ConfigMapBorderByBorderId.HandleId, "db_map.db", "select BinData from `MapBorder` where BorderId=?");
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x0010B6E0 File Offset: 0x001098E0
		public static MapBorder? GetConfig(int p0BorderId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapBorderByBorderId.HandleId, ConfigMapBorderByBorderId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapBorderByBorderId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BorderId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MapBorder?(MapBorder.GetRootAsMapBorder(configBuffer));
				}
			}
			ConfigMapBorderByBorderId.LogPair.Clear();
			ConfigMapBorderByBorderId.LogPair.Add(new ValueTuple<string, object>("BorderId", p0BorderId));
			if (!ConfigCommon.BindInt(ConfigMapBorderByBorderId.HandleId, 1, p0BorderId, ConfigMapBorderByBorderId.LogPair) || ConfigCommon.Step(ConfigMapBorderByBorderId.HandleId, true, ConfigMapBorderByBorderId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMapBorderByBorderId.HandleId, ConfigMapBorderByBorderId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapBorderByBorderId.HandleId, 0, ConfigMapBorderByBorderId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMapBorderByBorderId.HandleId, ConfigMapBorderByBorderId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MapBorder rootAsMapBorder = MapBorder.GetRootAsMapBorder(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapBorderByBorderId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BorderId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMapBorderByBorderId.HandleId, ConfigMapBorderByBorderId.LogPair);
			return new MapBorder?(rootAsMapBorder);
		}

		// Token: 0x040023E7 RID: 9191
		private const string DB = "db_map.db";

		// Token: 0x040023E8 RID: 9192
		private const string FILE = "d.地图.xlsx";

		// Token: 0x040023E9 RID: 9193
		private const string TABLE = "MapBorder";

		// Token: 0x040023EA RID: 9194
		private const string COMMAND = "select BinData from `MapBorder` where BorderId=?";

		// Token: 0x040023EB RID: 9195
		private const string KEY_PREFIX = "MapBorderByBorderId";

		// Token: 0x040023EC RID: 9196
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023ED RID: 9197
		private static int HandleId;
	}
}
