using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000530 RID: 1328
	public class ConfigMapMarkByRelativeId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F2B RID: 7979 RVA: 0x0010CE90 File Offset: 0x0010B090
		static ConfigMapMarkByRelativeId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkByRelativeId.CreateStaticDefaultValue), new Action(ConfigMapMarkByRelativeId.ResetStaticDefaultValue));
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x0010CEB0 File Offset: 0x0010B0B0
		public static void CreateStaticDefaultValue()
		{
			ConfigMapMarkByRelativeId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapMarkByRelativeId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "MapMark"),
				new ValueTuple<string, object>("语句", "select BinData from `MapMark` where RelativeId=? and MapId=?")
			});
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x0010CF2F File Offset: 0x0010B12F
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkByRelativeId.LogPair = null;
			ConfigMapMarkByRelativeId.HandleId = 0;
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x0010CF3D File Offset: 0x0010B13D
		public static void Init()
		{
			ConfigMapMarkByRelativeId.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkByRelativeId.HandleId, "db_map_mark.db", "select BinData from `MapMark` where RelativeId=? and MapId=?");
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x0010CF58 File Offset: 0x0010B158
		public static MapMark? GetConfig(int p0RelativeId, int p1MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapMarkByRelativeId.HandleId, ConfigMapMarkByRelativeId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("MapMarkByRelativeId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RelativeId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1MapId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MapMark?(MapMark.GetRootAsMapMark(configBuffer));
				}
			}
			ConfigMapMarkByRelativeId.LogPair.Clear();
			ConfigMapMarkByRelativeId.LogPair.Add(new ValueTuple<string, object>("RelativeId", p0RelativeId));
			ConfigMapMarkByRelativeId.LogPair.Add(new ValueTuple<string, object>("MapId", p1MapId));
			if (!ConfigCommon.BindInt(ConfigMapMarkByRelativeId.HandleId, 1, p0RelativeId, ConfigMapMarkByRelativeId.LogPair) || !ConfigCommon.BindInt(ConfigMapMarkByRelativeId.HandleId, 2, p1MapId, ConfigMapMarkByRelativeId.LogPair) || ConfigCommon.Step(ConfigMapMarkByRelativeId.HandleId, true, ConfigMapMarkByRelativeId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMapMarkByRelativeId.HandleId, ConfigMapMarkByRelativeId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapMarkByRelativeId.HandleId, 0, ConfigMapMarkByRelativeId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMapMarkByRelativeId.HandleId, ConfigMapMarkByRelativeId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MapMark rootAsMapMark = MapMark.GetRootAsMapMark(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("MapMarkByRelativeId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RelativeId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1MapId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMapMarkByRelativeId.HandleId, ConfigMapMarkByRelativeId.LogPair);
			return new MapMark?(rootAsMapMark);
		}

		// Token: 0x04002434 RID: 9268
		private const string DB = "db_map_mark.db";

		// Token: 0x04002435 RID: 9269
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04002436 RID: 9270
		private const string TABLE = "MapMark";

		// Token: 0x04002437 RID: 9271
		private const string COMMAND = "select BinData from `MapMark` where RelativeId=? and MapId=?";

		// Token: 0x04002438 RID: 9272
		private const string KEY_PREFIX = "MapMarkByRelativeId";

		// Token: 0x04002439 RID: 9273
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400243A RID: 9274
		private static int HandleId;
	}
}
