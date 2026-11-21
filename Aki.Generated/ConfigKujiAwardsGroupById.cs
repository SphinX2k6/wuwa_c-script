using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000494 RID: 1172
	public class ConfigKujiAwardsGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B82 RID: 7042 RVA: 0x000F864F File Offset: 0x000F684F
		static ConfigKujiAwardsGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKujiAwardsGroupById.CreateStaticDefaultValue), new Action(ConfigKujiAwardsGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x000F8670 File Offset: 0x000F6870
		public static void CreateStaticDefaultValue()
		{
			ConfigKujiAwardsGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKujiAwardsGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_wuwukuji.db"),
				new ValueTuple<string, object>("文件", "w.呜呜一番赏.xlsx"),
				new ValueTuple<string, object>("表名", "KujiAwardsGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `KujiAwardsGroup` where Id=?")
			});
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x000F86EF File Offset: 0x000F68EF
		public static void ResetStaticDefaultValue()
		{
			ConfigKujiAwardsGroupById.LogPair = null;
			ConfigKujiAwardsGroupById.HandleId = 0;
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x000F86FD File Offset: 0x000F68FD
		public static void Init()
		{
			ConfigKujiAwardsGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigKujiAwardsGroupById.HandleId, "db_wuwukuji.db", "select BinData from `KujiAwardsGroup` where Id=?");
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x000F8718 File Offset: 0x000F6918
		public static KujiAwardsGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKujiAwardsGroupById.HandleId, ConfigKujiAwardsGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KujiAwardsGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KujiAwardsGroup?(KujiAwardsGroup.GetRootAsKujiAwardsGroup(configBuffer));
				}
			}
			ConfigKujiAwardsGroupById.LogPair.Clear();
			ConfigKujiAwardsGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKujiAwardsGroupById.HandleId, 1, p0Id, ConfigKujiAwardsGroupById.LogPair) || ConfigCommon.Step(ConfigKujiAwardsGroupById.HandleId, true, ConfigKujiAwardsGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKujiAwardsGroupById.HandleId, ConfigKujiAwardsGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKujiAwardsGroupById.HandleId, 0, ConfigKujiAwardsGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKujiAwardsGroupById.HandleId, ConfigKujiAwardsGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KujiAwardsGroup rootAsKujiAwardsGroup = KujiAwardsGroup.GetRootAsKujiAwardsGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KujiAwardsGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKujiAwardsGroupById.HandleId, ConfigKujiAwardsGroupById.LogPair);
			return new KujiAwardsGroup?(rootAsKujiAwardsGroup);
		}

		// Token: 0x04001FF0 RID: 8176
		private const string DB = "db_wuwukuji.db";

		// Token: 0x04001FF1 RID: 8177
		private const string FILE = "w.呜呜一番赏.xlsx";

		// Token: 0x04001FF2 RID: 8178
		private const string TABLE = "KujiAwardsGroup";

		// Token: 0x04001FF3 RID: 8179
		private const string COMMAND = "select BinData from `KujiAwardsGroup` where Id=?";

		// Token: 0x04001FF4 RID: 8180
		private const string KEY_PREFIX = "KujiAwardsGroupById";

		// Token: 0x04001FF5 RID: 8181
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FF6 RID: 8182
		private static int HandleId;
	}
}
