using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000703 RID: 1795
	public class ConfigPhotoWeatherById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A22 RID: 10786 RVA: 0x001477FB File Offset: 0x001459FB
		static ConfigPhotoWeatherById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoWeatherById.CreateStaticDefaultValue), new Action(ConfigPhotoWeatherById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x0014781C File Offset: 0x00145A1C
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

		// Token: 0x06002A24 RID: 10788 RVA: 0x0014789B File Offset: 0x00145A9B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoWeatherById.LogPair = null;
			ConfigPhotoWeatherById.HandleId = 0;
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x001478A9 File Offset: 0x00145AA9
		public static void Init()
		{
			ConfigPhotoWeatherById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoWeatherById.HandleId, "db_photonew.db", "select BinData from `PhotoWeather` where Id=?");
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x001478C4 File Offset: 0x00145AC4
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

		// Token: 0x040030FB RID: 12539
		private const string DB = "db_photonew.db";

		// Token: 0x040030FC RID: 12540
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x040030FD RID: 12541
		private const string TABLE = "PhotoWeather";

		// Token: 0x040030FE RID: 12542
		private const string COMMAND = "select BinData from `PhotoWeather` where Id=?";

		// Token: 0x040030FF RID: 12543
		private const string KEY_PREFIX = "PhotoWeatherById";

		// Token: 0x04003100 RID: 12544
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003101 RID: 12545
		private static int HandleId;
	}
}
