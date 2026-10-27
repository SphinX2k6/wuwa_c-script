using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200047E RID: 1150
	public class ConfigKujiAwardsGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AFE RID: 6910 RVA: 0x000F1EFB File Offset: 0x000F00FB
		static ConfigKujiAwardsGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKujiAwardsGroupById.CreateStaticDefaultValue), new Action(ConfigKujiAwardsGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x000F1F1C File Offset: 0x000F011C
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

		// Token: 0x06001B00 RID: 6912 RVA: 0x000F1F9B File Offset: 0x000F019B
		public static void ResetStaticDefaultValue()
		{
			ConfigKujiAwardsGroupById.LogPair = null;
			ConfigKujiAwardsGroupById.HandleId = 0;
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x000F1FA9 File Offset: 0x000F01A9
		public static void Init()
		{
			ConfigKujiAwardsGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigKujiAwardsGroupById.HandleId, "db_wuwukuji.db", "select BinData from `KujiAwardsGroup` where Id=?");
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x000F1FC4 File Offset: 0x000F01C4
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

		// Token: 0x04001F56 RID: 8022
		private const string DB = "db_wuwukuji.db";

		// Token: 0x04001F57 RID: 8023
		private const string FILE = "w.呜呜一番赏.xlsx";

		// Token: 0x04001F58 RID: 8024
		private const string TABLE = "KujiAwardsGroup";

		// Token: 0x04001F59 RID: 8025
		private const string COMMAND = "select BinData from `KujiAwardsGroup` where Id=?";

		// Token: 0x04001F5A RID: 8026
		private const string KEY_PREFIX = "KujiAwardsGroupById";

		// Token: 0x04001F5B RID: 8027
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F5C RID: 8028
		private static int HandleId;
	}
}
