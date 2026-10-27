using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003E0 RID: 992
	public class ConfigHonamiStoryBuffTempById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001747 RID: 5959 RVA: 0x000DD264 File Offset: 0x000DB464
		static ConfigHonamiStoryBuffTempById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryBuffTempById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryBuffTempById.ResetStaticDefaultValue));
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x000DD284 File Offset: 0x000DB484
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryBuffTempById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryBuffTempById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语道具.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryBuffTemp"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryBuffTemp` where Id=?")
			});
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x000DD303 File Offset: 0x000DB503
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryBuffTempById.LogPair = null;
			ConfigHonamiStoryBuffTempById.HandleId = 0;
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x000DD311 File Offset: 0x000DB511
		public static void Init()
		{
			ConfigHonamiStoryBuffTempById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryBuffTempById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryBuffTemp` where Id=?");
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x000DD32C File Offset: 0x000DB52C
		public static HonamiStoryBuffTemp? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryBuffTempById.HandleId, ConfigHonamiStoryBuffTempById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryBuffTempById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryBuffTemp?(HonamiStoryBuffTemp.GetRootAsHonamiStoryBuffTemp(configBuffer));
				}
			}
			ConfigHonamiStoryBuffTempById.LogPair.Clear();
			ConfigHonamiStoryBuffTempById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryBuffTempById.HandleId, 1, p0Id, ConfigHonamiStoryBuffTempById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryBuffTempById.HandleId, true, ConfigHonamiStoryBuffTempById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryBuffTempById.HandleId, ConfigHonamiStoryBuffTempById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryBuffTempById.HandleId, 0, ConfigHonamiStoryBuffTempById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryBuffTempById.HandleId, ConfigHonamiStoryBuffTempById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryBuffTemp rootAsHonamiStoryBuffTemp = HonamiStoryBuffTemp.GetRootAsHonamiStoryBuffTemp(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryBuffTempById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryBuffTempById.HandleId, ConfigHonamiStoryBuffTempById.LogPair);
			return new HonamiStoryBuffTemp?(rootAsHonamiStoryBuffTemp);
		}

		// Token: 0x04001B04 RID: 6916
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B05 RID: 6917
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001B06 RID: 6918
		private const string TABLE = "HonamiStoryBuffTemp";

		// Token: 0x04001B07 RID: 6919
		private const string COMMAND = "select BinData from `HonamiStoryBuffTemp` where Id=?";

		// Token: 0x04001B08 RID: 6920
		private const string KEY_PREFIX = "HonamiStoryBuffTempById";

		// Token: 0x04001B09 RID: 6921
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B0A RID: 6922
		private static int HandleId;
	}
}
