using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200052C RID: 1324
	public class ConfigMapMarkByEntityConfigId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F13 RID: 7955 RVA: 0x0010C58F File Offset: 0x0010A78F
		static ConfigMapMarkByEntityConfigId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkByEntityConfigId.CreateStaticDefaultValue), new Action(ConfigMapMarkByEntityConfigId.ResetStaticDefaultValue));
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x0010C5B0 File Offset: 0x0010A7B0
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

		// Token: 0x06001F15 RID: 7957 RVA: 0x0010C62F File Offset: 0x0010A82F
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkByEntityConfigId.LogPair = null;
			ConfigMapMarkByEntityConfigId.HandleId = 0;
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x0010C63D File Offset: 0x0010A83D
		public static void Init()
		{
			ConfigMapMarkByEntityConfigId.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkByEntityConfigId.HandleId, "db_map_mark.db", "select BinData from `MapMark` where EntityConfigId=?");
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x0010C658 File Offset: 0x0010A858
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

		// Token: 0x04002418 RID: 9240
		private const string DB = "db_map_mark.db";

		// Token: 0x04002419 RID: 9241
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x0400241A RID: 9242
		private const string TABLE = "MapMark";

		// Token: 0x0400241B RID: 9243
		private const string COMMAND = "select BinData from `MapMark` where EntityConfigId=?";

		// Token: 0x0400241C RID: 9244
		private const string KEY_PREFIX = "MapMarkByEntityConfigId";

		// Token: 0x0400241D RID: 9245
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400241E RID: 9246
		private static int HandleId;
	}
}
