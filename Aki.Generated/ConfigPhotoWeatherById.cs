using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200071B RID: 1819
	public class ConfigPhotoWeatherById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AB2 RID: 10930 RVA: 0x0014E277 File Offset: 0x0014C477
		static ConfigPhotoWeatherById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoWeatherById.CreateStaticDefaultValue), new Action(ConfigPhotoWeatherById.ResetStaticDefaultValue));
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x0014E298 File Offset: 0x0014C498
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoWeatherById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoWeatherById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoWeather"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoWeather` where Id=?")
			});
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x0014E317 File Offset: 0x0014C517
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoWeatherById.LogPair = null;
			ConfigPhotoWeatherById.HandleId = 0;
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x0014E325 File Offset: 0x0014C525
		public static void Init()
		{
			ConfigPhotoWeatherById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoWeatherById.HandleId, "db_photonew.db", "select BinData from `PhotoWeather` where Id=?");
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x0014E340 File Offset: 0x0014C540
		public static PhotoWeather? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoWeatherById.HandleId, ConfigPhotoWeatherById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoWeatherById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoWeather?(PhotoWeather.GetRootAsPhotoWeather(configBuffer));
				}
			}
			ConfigPhotoWeatherById.LogPair.Clear();
			ConfigPhotoWeatherById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoWeatherById.HandleId, 1, p0Id, ConfigPhotoWeatherById.LogPair) || ConfigCommon.Step(ConfigPhotoWeatherById.HandleId, true, ConfigPhotoWeatherById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoWeatherById.HandleId, ConfigPhotoWeatherById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoWeatherById.HandleId, 0, ConfigPhotoWeatherById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoWeatherById.HandleId, ConfigPhotoWeatherById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoWeather rootAsPhotoWeather = PhotoWeather.GetRootAsPhotoWeather(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoWeatherById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoWeatherById.HandleId, ConfigPhotoWeatherById.LogPair);
			return new PhotoWeather?(rootAsPhotoWeather);
		}

		// Token: 0x040031A3 RID: 12707
		private const string DB = "db_photonew.db";

		// Token: 0x040031A4 RID: 12708
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x040031A5 RID: 12709
		private const string TABLE = "PhotoWeather";

		// Token: 0x040031A6 RID: 12710
		private const string COMMAND = "select BinData from `PhotoWeather` where Id=?";

		// Token: 0x040031A7 RID: 12711
		private const string KEY_PREFIX = "PhotoWeatherById";

		// Token: 0x040031A8 RID: 12712
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031A9 RID: 12713
		private static int HandleId;
	}
}
