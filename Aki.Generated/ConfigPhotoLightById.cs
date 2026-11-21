using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006F8 RID: 1784
	public class ConfigPhotoLightById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029E0 RID: 10720 RVA: 0x001497BF File Offset: 0x001479BF
		static ConfigPhotoLightById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoLightById.CreateStaticDefaultValue), new Action(ConfigPhotoLightById.ResetStaticDefaultValue));
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x001497E0 File Offset: 0x001479E0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoLightById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoLightById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoLight"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoLight` where Id=?")
			});
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x0014985F File Offset: 0x00147A5F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoLightById.LogPair = null;
			ConfigPhotoLightById.HandleId = 0;
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x0014986D File Offset: 0x00147A6D
		public static void Init()
		{
			ConfigPhotoLightById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoLightById.HandleId, "db_photonew.db", "select BinData from `PhotoLight` where Id=?");
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x00149888 File Offset: 0x00147A88
		public static PhotoLight? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoLightById.HandleId, ConfigPhotoLightById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoLightById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoLight?(PhotoLight.GetRootAsPhotoLight(configBuffer));
				}
			}
			ConfigPhotoLightById.LogPair.Clear();
			ConfigPhotoLightById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoLightById.HandleId, 1, p0Id, ConfigPhotoLightById.LogPair) || ConfigCommon.Step(ConfigPhotoLightById.HandleId, true, ConfigPhotoLightById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoLightById.HandleId, ConfigPhotoLightById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoLightById.HandleId, 0, ConfigPhotoLightById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoLightById.HandleId, ConfigPhotoLightById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoLight rootAsPhotoLight = PhotoLight.GetRootAsPhotoLight(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoLightById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoLightById.HandleId, ConfigPhotoLightById.LogPair);
			return new PhotoLight?(rootAsPhotoLight);
		}

		// Token: 0x040030AE RID: 12462
		private const string DB = "db_photonew.db";

		// Token: 0x040030AF RID: 12463
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x040030B0 RID: 12464
		private const string TABLE = "PhotoLight";

		// Token: 0x040030B1 RID: 12465
		private const string COMMAND = "select BinData from `PhotoLight` where Id=?";

		// Token: 0x040030B2 RID: 12466
		private const string KEY_PREFIX = "PhotoLightById";

		// Token: 0x040030B3 RID: 12467
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030B4 RID: 12468
		private static int HandleId;
	}
}
