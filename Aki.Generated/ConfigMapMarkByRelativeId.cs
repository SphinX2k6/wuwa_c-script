using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200051A RID: 1306
	public class ConfigMapMarkByRelativeId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EA7 RID: 7847 RVA: 0x0010673C File Offset: 0x0010493C
		static ConfigMapMarkByRelativeId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkByRelativeId.CreateStaticDefaultValue), new Action(ConfigMapMarkByRelativeId.ResetStaticDefaultValue));
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x0010675C File Offset: 0x0010495C
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

		// Token: 0x06001EA9 RID: 7849 RVA: 0x001067DB File Offset: 0x001049DB
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkByRelativeId.LogPair = null;
			ConfigMapMarkByRelativeId.HandleId = 0;
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x001067E9 File Offset: 0x001049E9
		public static void Init()
		{
			ConfigMapMarkByRelativeId.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkByRelativeId.HandleId, "db_map_mark.db", "select BinData from `MapMark` where RelativeId=? and MapId=?");
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x00106804 File Offset: 0x00104A04
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

		// Token: 0x0400239A RID: 9114
		private const string DB = "db_map_mark.db";

		// Token: 0x0400239B RID: 9115
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x0400239C RID: 9116
		private const string TABLE = "MapMark";

		// Token: 0x0400239D RID: 9117
		private const string COMMAND = "select BinData from `MapMark` where RelativeId=? and MapId=?";

		// Token: 0x0400239E RID: 9118
		private const string KEY_PREFIX = "MapMarkByRelativeId";

		// Token: 0x0400239F RID: 9119
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023A0 RID: 9120
		private static int HandleId;
	}
}
