using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009BB RID: 2491
	public class ConfigSolarSchoolBehaviorById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A76 RID: 14966 RVA: 0x001A7353 File Offset: 0x001A5553
		static ConfigSolarSchoolBehaviorById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolBehaviorById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolBehaviorById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A77 RID: 14967 RVA: 0x001A7374 File Offset: 0x001A5574
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolBehaviorById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolBehaviorById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolBehavior"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolBehavior` where Id=?")
			});
		}

		// Token: 0x06003A78 RID: 14968 RVA: 0x001A73F3 File Offset: 0x001A55F3
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolBehaviorById.LogPair = null;
			ConfigSolarSchoolBehaviorById.HandleId = 0;
		}

		// Token: 0x06003A79 RID: 14969 RVA: 0x001A7401 File Offset: 0x001A5601
		public static void Init()
		{
			ConfigSolarSchoolBehaviorById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolBehaviorById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolBehavior` where Id=?");
		}

		// Token: 0x06003A7A RID: 14970 RVA: 0x001A741C File Offset: 0x001A561C
		public static SolarSchoolBehavior? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolBehaviorById.HandleId, ConfigSolarSchoolBehaviorById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolBehaviorById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolBehavior?(SolarSchoolBehavior.GetRootAsSolarSchoolBehavior(configBuffer));
				}
			}
			ConfigSolarSchoolBehaviorById.LogPair.Clear();
			ConfigSolarSchoolBehaviorById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolBehaviorById.HandleId, 1, p0Id, ConfigSolarSchoolBehaviorById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolBehaviorById.HandleId, true, ConfigSolarSchoolBehaviorById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolBehaviorById.HandleId, ConfigSolarSchoolBehaviorById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolBehaviorById.HandleId, 0, ConfigSolarSchoolBehaviorById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolBehaviorById.HandleId, ConfigSolarSchoolBehaviorById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolBehavior rootAsSolarSchoolBehavior = SolarSchoolBehavior.GetRootAsSolarSchoolBehavior(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolBehaviorById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolBehaviorById.HandleId, ConfigSolarSchoolBehaviorById.LogPair);
			return new SolarSchoolBehavior?(rootAsSolarSchoolBehavior);
		}

		// Token: 0x04004403 RID: 17411
		private const string DB = "db_solarschool.db";

		// Token: 0x04004404 RID: 17412
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x04004405 RID: 17413
		private const string TABLE = "SolarSchoolBehavior";

		// Token: 0x04004406 RID: 17414
		private const string COMMAND = "select BinData from `SolarSchoolBehavior` where Id=?";

		// Token: 0x04004407 RID: 17415
		private const string KEY_PREFIX = "SolarSchoolBehaviorById";

		// Token: 0x04004408 RID: 17416
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004409 RID: 17417
		private static int HandleId;
	}
}
