using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009E6 RID: 2534
	public class ConfigSolarSchoolInfluenceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B78 RID: 15224 RVA: 0x001ACF0C File Offset: 0x001AB10C
		static ConfigSolarSchoolInfluenceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolInfluenceById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolInfluenceById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B79 RID: 15225 RVA: 0x001ACF2C File Offset: 0x001AB12C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolInfluenceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolInfluenceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_任务.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolInfluence"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolInfluence` where Id=?")
			});
		}

		// Token: 0x06003B7A RID: 15226 RVA: 0x001ACFAB File Offset: 0x001AB1AB
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolInfluenceById.LogPair = null;
			ConfigSolarSchoolInfluenceById.HandleId = 0;
		}

		// Token: 0x06003B7B RID: 15227 RVA: 0x001ACFB9 File Offset: 0x001AB1B9
		public static void Init()
		{
			ConfigSolarSchoolInfluenceById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolInfluenceById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolInfluence` where Id=?");
		}

		// Token: 0x06003B7C RID: 15228 RVA: 0x001ACFD4 File Offset: 0x001AB1D4
		public static SolarSchoolInfluence? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolInfluenceById.HandleId, ConfigSolarSchoolInfluenceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolInfluenceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolInfluence?(SolarSchoolInfluence.GetRootAsSolarSchoolInfluence(configBuffer));
				}
			}
			ConfigSolarSchoolInfluenceById.LogPair.Clear();
			ConfigSolarSchoolInfluenceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolInfluenceById.HandleId, 1, p0Id, ConfigSolarSchoolInfluenceById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolInfluenceById.HandleId, true, ConfigSolarSchoolInfluenceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolInfluenceById.HandleId, ConfigSolarSchoolInfluenceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolInfluenceById.HandleId, 0, ConfigSolarSchoolInfluenceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolInfluenceById.HandleId, ConfigSolarSchoolInfluenceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolInfluence rootAsSolarSchoolInfluence = SolarSchoolInfluence.GetRootAsSolarSchoolInfluence(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolInfluenceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolInfluenceById.HandleId, ConfigSolarSchoolInfluenceById.LogPair);
			return new SolarSchoolInfluence?(rootAsSolarSchoolInfluence);
		}

		// Token: 0x04004530 RID: 17712
		private const string DB = "db_solarschool.db";

		// Token: 0x04004531 RID: 17713
		private const string FILE = "d.第二索拉_任务.xlsx";

		// Token: 0x04004532 RID: 17714
		private const string TABLE = "SolarSchoolInfluence";

		// Token: 0x04004533 RID: 17715
		private const string COMMAND = "select BinData from `SolarSchoolInfluence` where Id=?";

		// Token: 0x04004534 RID: 17716
		private const string KEY_PREFIX = "SolarSchoolInfluenceById";

		// Token: 0x04004535 RID: 17717
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004536 RID: 17718
		private static int HandleId;
	}
}
