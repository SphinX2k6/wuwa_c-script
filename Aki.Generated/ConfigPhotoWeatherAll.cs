using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200071A RID: 1818
	public class ConfigPhotoWeatherAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AAC RID: 10924 RVA: 0x0014E0E4 File Offset: 0x0014C2E4
		static ConfigPhotoWeatherAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoWeatherAll.CreateStaticDefaultValue), new Action(ConfigPhotoWeatherAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x0014E104 File Offset: 0x0014C304
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

		// Token: 0x06002AAE RID: 10926 RVA: 0x0014E183 File Offset: 0x0014C383
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoWeatherAll.LogPair = null;
			ConfigPhotoWeatherAll.HandleId = 0;
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x0014E191 File Offset: 0x0014C391
		public static void Init()
		{
			ConfigPhotoWeatherAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoWeatherAll.HandleId, "db_photonew.db", "select BinData from `PhotoWeather`");
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x0014E1AC File Offset: 0x0014C3AC
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

		// Token: 0x0400319C RID: 12700
		private const string DB = "db_photonew.db";

		// Token: 0x0400319D RID: 12701
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x0400319E RID: 12702
		private const string TABLE = "PhotoWeather";

		// Token: 0x0400319F RID: 12703
		private const string COMMAND = "select BinData from `PhotoWeather`";

		// Token: 0x040031A0 RID: 12704
		private const string KEY_PREFIX = "PhotoWeatherAll";

		// Token: 0x040031A1 RID: 12705
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031A2 RID: 12706
		private static int HandleId;
	}
}
