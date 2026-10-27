using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000516 RID: 1302
	public class ConfigMapMarkByEntityConfigId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E8F RID: 7823 RVA: 0x00105E3B File Offset: 0x0010403B
		static ConfigMapMarkByEntityConfigId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkByEntityConfigId.CreateStaticDefaultValue), new Action(ConfigMapMarkByEntityConfigId.ResetStaticDefaultValue));
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x00105E5C File Offset: 0x0010405C
		public static void CreateStaticDefaultValue()
		{
			ConfigMapMarkByEntityConfigId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapMarkByEntityConfigId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "MapMark"),
				new ValueTuple<string, object>("语句", "select BinData from `MapMark` where EntityConfigId=?")
			});
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x00105EDB File Offset: 0x001040DB
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkByEntityConfigId.LogPair = null;
			ConfigMapMarkByEntityConfigId.HandleId = 0;
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x00105EE9 File Offset: 0x001040E9
		public static void Init()
		{
			ConfigMapMarkByEntityConfigId.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkByEntityConfigId.HandleId, "db_map_mark.db", "select BinData from `MapMark` where EntityConfigId=?");
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x00105F04 File Offset: 0x00104104
		public static MapMark? GetConfig(int p0EntityConfigId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapMarkByEntityConfigId.HandleId, ConfigMapMarkByEntityConfigId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapMarkByEntityConfigId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EntityConfigId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MapMark?(MapMark.GetRootAsMapMark(configBuffer));
				}
			}
			ConfigMapMarkByEntityConfigId.LogPair.Clear();
			ConfigMapMarkByEntityConfigId.LogPair.Add(new ValueTuple<string, object>("EntityConfigId", p0EntityConfigId));
			if (!ConfigCommon.BindInt(ConfigMapMarkByEntityConfigId.HandleId, 1, p0EntityConfigId, ConfigMapMarkByEntityConfigId.LogPair) || ConfigCommon.Step(ConfigMapMarkByEntityConfigId.HandleId, true, ConfigMapMarkByEntityConfigId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMapMarkByEntityConfigId.HandleId, ConfigMapMarkByEntityConfigId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapMarkByEntityConfigId.HandleId, 0, ConfigMapMarkByEntityConfigId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMapMarkByEntityConfigId.HandleId, ConfigMapMarkByEntityConfigId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MapMark rootAsMapMark = MapMark.GetRootAsMapMark(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapMarkByEntityConfigId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EntityConfigId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMapMarkByEntityConfigId.HandleId, ConfigMapMarkByEntityConfigId.LogPair);
			return new MapMark?(rootAsMapMark);
		}

		// Token: 0x0400237E RID: 9086
		private const string DB = "db_map_mark.db";

		// Token: 0x0400237F RID: 9087
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04002380 RID: 9088
		private const string TABLE = "MapMark";

		// Token: 0x04002381 RID: 9089
		private const string COMMAND = "select BinData from `MapMark` where EntityConfigId=?";

		// Token: 0x04002382 RID: 9090
		private const string KEY_PREFIX = "MapMarkByEntityConfigId";

		// Token: 0x04002383 RID: 9091
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002384 RID: 9092
		private static int HandleId;
	}
}
