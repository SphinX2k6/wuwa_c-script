using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200050F RID: 1295
	public class ConfigMapBorderByBorderId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E65 RID: 7781 RVA: 0x00104EC3 File Offset: 0x001030C3
		static ConfigMapBorderByBorderId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapBorderByBorderId.CreateStaticDefaultValue), new Action(ConfigMapBorderByBorderId.ResetStaticDefaultValue));
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x00104EE4 File Offset: 0x001030E4
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

		// Token: 0x06001E67 RID: 7783 RVA: 0x00104F63 File Offset: 0x00103163
		public static void ResetStaticDefaultValue()
		{
			ConfigMapBorderByBorderId.LogPair = null;
			ConfigMapBorderByBorderId.HandleId = 0;
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x00104F71 File Offset: 0x00103171
		public static void Init()
		{
			ConfigMapBorderByBorderId.HandleId = ConfigCommon.InitDataStatement(ConfigMapBorderByBorderId.HandleId, "db_map.db", "select BinData from `MapBorder` where BorderId=?");
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x00104F8C File Offset: 0x0010318C
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

		// Token: 0x0400234D RID: 9037
		private const string DB = "db_map.db";

		// Token: 0x0400234E RID: 9038
		private const string FILE = "d.地图.xlsx";

		// Token: 0x0400234F RID: 9039
		private const string TABLE = "MapBorder";

		// Token: 0x04002350 RID: 9040
		private const string COMMAND = "select BinData from `MapBorder` where BorderId=?";

		// Token: 0x04002351 RID: 9041
		private const string KEY_PREFIX = "MapBorderByBorderId";

		// Token: 0x04002352 RID: 9042
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002353 RID: 9043
		private static int HandleId;
	}
}
