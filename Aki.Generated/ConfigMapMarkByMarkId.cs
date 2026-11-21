using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200052F RID: 1327
	public class ConfigMapMarkByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F25 RID: 7973 RVA: 0x0010CC47 File Offset: 0x0010AE47
		static ConfigMapMarkByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkByMarkId.CreateStaticDefaultValue), new Action(ConfigMapMarkByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x0010CC68 File Offset: 0x0010AE68
		public static void CreateStaticDefaultValue()
		{
			ConfigMapMarkByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapMarkByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "MapMark"),
				new ValueTuple<string, object>("语句", "select BinData from `MapMark` where MarkId=?")
			});
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x0010CCE7 File Offset: 0x0010AEE7
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkByMarkId.LogPair = null;
			ConfigMapMarkByMarkId.HandleId = 0;
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x0010CCF5 File Offset: 0x0010AEF5
		public static void Init()
		{
			ConfigMapMarkByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkByMarkId.HandleId, "db_map_mark.db", "select BinData from `MapMark` where MarkId=?");
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x0010CD10 File Offset: 0x0010AF10
		public static MapMark? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapMarkByMarkId.HandleId, ConfigMapMarkByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapMarkByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MapMark?(MapMark.GetRootAsMapMark(configBuffer));
				}
			}
			ConfigMapMarkByMarkId.LogPair.Clear();
			ConfigMapMarkByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigMapMarkByMarkId.HandleId, 1, p0MarkId, ConfigMapMarkByMarkId.LogPair) || ConfigCommon.Step(ConfigMapMarkByMarkId.HandleId, true, ConfigMapMarkByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMapMarkByMarkId.HandleId, ConfigMapMarkByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapMarkByMarkId.HandleId, 0, ConfigMapMarkByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMapMarkByMarkId.HandleId, ConfigMapMarkByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MapMark rootAsMapMark = MapMark.GetRootAsMapMark(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapMarkByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMapMarkByMarkId.HandleId, ConfigMapMarkByMarkId.LogPair);
			return new MapMark?(rootAsMapMark);
		}

		// Token: 0x0400242D RID: 9261
		private const string DB = "db_map_mark.db";

		// Token: 0x0400242E RID: 9262
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x0400242F RID: 9263
		private const string TABLE = "MapMark";

		// Token: 0x04002430 RID: 9264
		private const string COMMAND = "select BinData from `MapMark` where MarkId=?";

		// Token: 0x04002431 RID: 9265
		private const string KEY_PREFIX = "MapMarkByMarkId";

		// Token: 0x04002432 RID: 9266
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002433 RID: 9267
		private static int HandleId;
	}
}
