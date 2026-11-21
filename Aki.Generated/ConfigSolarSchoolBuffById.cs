using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009BF RID: 2495
	public class ConfigSolarSchoolBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A8E RID: 14990 RVA: 0x001A7BB0 File Offset: 0x001A5DB0
		static ConfigSolarSchoolBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolBuffById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x001A7BD0 File Offset: 0x001A5DD0
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolBuff` where Id=?")
			});
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x001A7C4F File Offset: 0x001A5E4F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolBuffById.LogPair = null;
			ConfigSolarSchoolBuffById.HandleId = 0;
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x001A7C5D File Offset: 0x001A5E5D
		public static void Init()
		{
			ConfigSolarSchoolBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolBuffById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolBuff` where Id=?");
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x001A7C78 File Offset: 0x001A5E78
		public static SolarSchoolBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolBuffById.HandleId, ConfigSolarSchoolBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolBuff?(SolarSchoolBuff.GetRootAsSolarSchoolBuff(configBuffer));
				}
			}
			ConfigSolarSchoolBuffById.LogPair.Clear();
			ConfigSolarSchoolBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolBuffById.HandleId, 1, p0Id, ConfigSolarSchoolBuffById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolBuffById.HandleId, true, ConfigSolarSchoolBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolBuffById.HandleId, ConfigSolarSchoolBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolBuffById.HandleId, 0, ConfigSolarSchoolBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolBuffById.HandleId, ConfigSolarSchoolBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolBuff rootAsSolarSchoolBuff = SolarSchoolBuff.GetRootAsSolarSchoolBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolBuffById.HandleId, ConfigSolarSchoolBuffById.LogPair);
			return new SolarSchoolBuff?(rootAsSolarSchoolBuff);
		}

		// Token: 0x0400441F RID: 17439
		private const string DB = "db_solarschool.db";

		// Token: 0x04004420 RID: 17440
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x04004421 RID: 17441
		private const string TABLE = "SolarSchoolBuff";

		// Token: 0x04004422 RID: 17442
		private const string COMMAND = "select BinData from `SolarSchoolBuff` where Id=?";

		// Token: 0x04004423 RID: 17443
		private const string KEY_PREFIX = "SolarSchoolBuffById";

		// Token: 0x04004424 RID: 17444
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004425 RID: 17445
		private static int HandleId;
	}
}
