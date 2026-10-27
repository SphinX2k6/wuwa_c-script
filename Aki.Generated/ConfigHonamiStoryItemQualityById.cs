using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003E9 RID: 1001
	public class ConfigHonamiStoryItemQualityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600177D RID: 6013 RVA: 0x000DE627 File Offset: 0x000DC827
		static ConfigHonamiStoryItemQualityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryItemQualityById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryItemQualityById.ResetStaticDefaultValue));
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x000DE648 File Offset: 0x000DC848
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryItemQualityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryItemQualityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语道具.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryItemQuality"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryItemQuality` where Id=?")
			});
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x000DE6C7 File Offset: 0x000DC8C7
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryItemQualityById.LogPair = null;
			ConfigHonamiStoryItemQualityById.HandleId = 0;
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x000DE6D5 File Offset: 0x000DC8D5
		public static void Init()
		{
			ConfigHonamiStoryItemQualityById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryItemQualityById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryItemQuality` where Id=?");
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x000DE6F0 File Offset: 0x000DC8F0
		public static HonamiStoryItemQuality? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryItemQualityById.HandleId, ConfigHonamiStoryItemQualityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryItemQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryItemQuality?(HonamiStoryItemQuality.GetRootAsHonamiStoryItemQuality(configBuffer));
				}
			}
			ConfigHonamiStoryItemQualityById.LogPair.Clear();
			ConfigHonamiStoryItemQualityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryItemQualityById.HandleId, 1, p0Id, ConfigHonamiStoryItemQualityById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryItemQualityById.HandleId, true, ConfigHonamiStoryItemQualityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryItemQualityById.HandleId, ConfigHonamiStoryItemQualityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryItemQualityById.HandleId, 0, ConfigHonamiStoryItemQualityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryItemQualityById.HandleId, ConfigHonamiStoryItemQualityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryItemQuality rootAsHonamiStoryItemQuality = HonamiStoryItemQuality.GetRootAsHonamiStoryItemQuality(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryItemQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryItemQualityById.HandleId, ConfigHonamiStoryItemQualityById.LogPair);
			return new HonamiStoryItemQuality?(rootAsHonamiStoryItemQuality);
		}

		// Token: 0x04001B43 RID: 6979
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B44 RID: 6980
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001B45 RID: 6981
		private const string TABLE = "HonamiStoryItemQuality";

		// Token: 0x04001B46 RID: 6982
		private const string COMMAND = "select BinData from `HonamiStoryItemQuality` where Id=?";

		// Token: 0x04001B47 RID: 6983
		private const string KEY_PREFIX = "HonamiStoryItemQualityById";

		// Token: 0x04001B48 RID: 6984
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B49 RID: 6985
		private static int HandleId;
	}
}
