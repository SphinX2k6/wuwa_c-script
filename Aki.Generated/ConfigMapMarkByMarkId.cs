using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000519 RID: 1305
	public class ConfigMapMarkByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EA1 RID: 7841 RVA: 0x001064F3 File Offset: 0x001046F3
		static ConfigMapMarkByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkByMarkId.CreateStaticDefaultValue), new Action(ConfigMapMarkByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00106514 File Offset: 0x00104714
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

		// Token: 0x06001EA3 RID: 7843 RVA: 0x00106593 File Offset: 0x00104793
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkByMarkId.LogPair = null;
			ConfigMapMarkByMarkId.HandleId = 0;
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x001065A1 File Offset: 0x001047A1
		public static void Init()
		{
			ConfigMapMarkByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkByMarkId.HandleId, "db_map_mark.db", "select BinData from `MapMark` where MarkId=?");
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x001065BC File Offset: 0x001047BC
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

		// Token: 0x04002393 RID: 9107
		private const string DB = "db_map_mark.db";

		// Token: 0x04002394 RID: 9108
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04002395 RID: 9109
		private const string TABLE = "MapMark";

		// Token: 0x04002396 RID: 9110
		private const string COMMAND = "select BinData from `MapMark` where MarkId=?";

		// Token: 0x04002397 RID: 9111
		private const string KEY_PREFIX = "MapMarkByMarkId";

		// Token: 0x04002398 RID: 9112
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002399 RID: 9113
		private static int HandleId;
	}
}
