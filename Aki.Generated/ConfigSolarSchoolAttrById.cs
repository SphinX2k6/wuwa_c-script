using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009B4 RID: 2484
	public class ConfigSolarSchoolAttrById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A4C RID: 14924 RVA: 0x001A64F3 File Offset: 0x001A46F3
		static ConfigSolarSchoolAttrById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolAttrById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolAttrById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A4D RID: 14925 RVA: 0x001A6514 File Offset: 0x001A4714
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolAttrById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolAttrById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolAttr"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolAttr` where Id=?")
			});
		}

		// Token: 0x06003A4E RID: 14926 RVA: 0x001A6593 File Offset: 0x001A4793
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolAttrById.LogPair = null;
			ConfigSolarSchoolAttrById.HandleId = 0;
		}

		// Token: 0x06003A4F RID: 14927 RVA: 0x001A65A1 File Offset: 0x001A47A1
		public static void Init()
		{
			ConfigSolarSchoolAttrById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolAttrById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolAttr` where Id=?");
		}

		// Token: 0x06003A50 RID: 14928 RVA: 0x001A65BC File Offset: 0x001A47BC
		public static SolarSchoolAttr? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolAttrById.HandleId, ConfigSolarSchoolAttrById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolAttrById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolAttr?(SolarSchoolAttr.GetRootAsSolarSchoolAttr(configBuffer));
				}
			}
			ConfigSolarSchoolAttrById.LogPair.Clear();
			ConfigSolarSchoolAttrById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolAttrById.HandleId, 1, p0Id, ConfigSolarSchoolAttrById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolAttrById.HandleId, true, ConfigSolarSchoolAttrById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolAttrById.HandleId, ConfigSolarSchoolAttrById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolAttrById.HandleId, 0, ConfigSolarSchoolAttrById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolAttrById.HandleId, ConfigSolarSchoolAttrById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolAttr rootAsSolarSchoolAttr = SolarSchoolAttr.GetRootAsSolarSchoolAttr(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolAttrById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolAttrById.HandleId, ConfigSolarSchoolAttrById.LogPair);
			return new SolarSchoolAttr?(rootAsSolarSchoolAttr);
		}

		// Token: 0x040043D2 RID: 17362
		private const string DB = "db_solarschool.db";

		// Token: 0x040043D3 RID: 17363
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x040043D4 RID: 17364
		private const string TABLE = "SolarSchoolAttr";

		// Token: 0x040043D5 RID: 17365
		private const string COMMAND = "select BinData from `SolarSchoolAttr` where Id=?";

		// Token: 0x040043D6 RID: 17366
		private const string KEY_PREFIX = "SolarSchoolAttrById";

		// Token: 0x040043D7 RID: 17367
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043D8 RID: 17368
		private static int HandleId;
	}
}
