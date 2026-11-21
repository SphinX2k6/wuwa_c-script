using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009E5 RID: 2533
	public class ConfigSolarSchoolGalleryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B72 RID: 15218 RVA: 0x001ACCC3 File Offset: 0x001AAEC3
		static ConfigSolarSchoolGalleryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolGalleryById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolGalleryById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x001ACCE4 File Offset: 0x001AAEE4
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolGalleryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolGalleryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_局外结局.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolGallery"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolGallery` where Id=?")
			});
		}

		// Token: 0x06003B74 RID: 15220 RVA: 0x001ACD63 File Offset: 0x001AAF63
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolGalleryById.LogPair = null;
			ConfigSolarSchoolGalleryById.HandleId = 0;
		}

		// Token: 0x06003B75 RID: 15221 RVA: 0x001ACD71 File Offset: 0x001AAF71
		public static void Init()
		{
			ConfigSolarSchoolGalleryById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolGalleryById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolGallery` where Id=?");
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x001ACD8C File Offset: 0x001AAF8C
		public static SolarSchoolGallery? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolGalleryById.HandleId, ConfigSolarSchoolGalleryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolGalleryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolGallery?(SolarSchoolGallery.GetRootAsSolarSchoolGallery(configBuffer));
				}
			}
			ConfigSolarSchoolGalleryById.LogPair.Clear();
			ConfigSolarSchoolGalleryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolGalleryById.HandleId, 1, p0Id, ConfigSolarSchoolGalleryById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolGalleryById.HandleId, true, ConfigSolarSchoolGalleryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolGalleryById.HandleId, ConfigSolarSchoolGalleryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolGalleryById.HandleId, 0, ConfigSolarSchoolGalleryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolGalleryById.HandleId, ConfigSolarSchoolGalleryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolGallery rootAsSolarSchoolGallery = SolarSchoolGallery.GetRootAsSolarSchoolGallery(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolGalleryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolGalleryById.HandleId, ConfigSolarSchoolGalleryById.LogPair);
			return new SolarSchoolGallery?(rootAsSolarSchoolGallery);
		}

		// Token: 0x04004529 RID: 17705
		private const string DB = "db_solarschool.db";

		// Token: 0x0400452A RID: 17706
		private const string FILE = "d.第二索拉_局外结局.xlsx";

		// Token: 0x0400452B RID: 17707
		private const string TABLE = "SolarSchoolGallery";

		// Token: 0x0400452C RID: 17708
		private const string COMMAND = "select BinData from `SolarSchoolGallery` where Id=?";

		// Token: 0x0400452D RID: 17709
		private const string KEY_PREFIX = "SolarSchoolGalleryById";

		// Token: 0x0400452E RID: 17710
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400452F RID: 17711
		private static int HandleId;
	}
}
