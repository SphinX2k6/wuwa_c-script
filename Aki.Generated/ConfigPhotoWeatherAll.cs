using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000702 RID: 1794
	public class ConfigPhotoWeatherAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A1C RID: 10780 RVA: 0x00147668 File Offset: 0x00145868
		static ConfigPhotoWeatherAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoWeatherAll.CreateStaticDefaultValue), new Action(ConfigPhotoWeatherAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x00147688 File Offset: 0x00145888
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoWeatherAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoWeatherAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoWeather"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoWeather`")
			});
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x00147707 File Offset: 0x00145907
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoWeatherAll.LogPair = null;
			ConfigPhotoWeatherAll.HandleId = 0;
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x00147715 File Offset: 0x00145915
		public static void Init()
		{
			ConfigPhotoWeatherAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoWeatherAll.HandleId, "db_photonew.db", "select BinData from `PhotoWeather`");
		}

		// Token: 0x06002A20 RID: 10784 RVA: 0x00147730 File Offset: 0x00145930
		[NullableContext(2)]
		public static IReadOnlyList<PhotoWeather> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoWeatherAll.HandleId, ConfigPhotoWeatherAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotoWeather> readOnlyList = (IReadOnlyList<PhotoWeather>)ConfigCommon.GetConfig("PhotoWeatherAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotoWeather> list = new List<PhotoWeather>();
			while (ConfigCommon.Step(ConfigPhotoWeatherAll.HandleId, false, ConfigPhotoWeatherAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoWeatherAll.HandleId, 0, ConfigPhotoWeatherAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoWeatherAll.HandleId, ConfigPhotoWeatherAll.LogPair);
					return null;
				}
				PhotoWeather rootAsPhotoWeather = PhotoWeather.GetRootAsPhotoWeather(new ByteBuffer(item2));
				list.Add(rootAsPhotoWeather);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotoWeatherAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoWeatherAll.HandleId, ConfigPhotoWeatherAll.LogPair);
			return list;
		}

		// Token: 0x040030F4 RID: 12532
		private const string DB = "db_photonew.db";

		// Token: 0x040030F5 RID: 12533
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x040030F6 RID: 12534
		private const string TABLE = "PhotoWeather";

		// Token: 0x040030F7 RID: 12535
		private const string COMMAND = "select BinData from `PhotoWeather`";

		// Token: 0x040030F8 RID: 12536
		private const string KEY_PREFIX = "PhotoWeatherAll";

		// Token: 0x040030F9 RID: 12537
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030FA RID: 12538
		private static int HandleId;
	}
}
