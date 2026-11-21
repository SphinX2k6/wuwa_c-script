using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A18 RID: 2584
	public class ConfigSolarSchoolRoleSpineById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CA4 RID: 15524 RVA: 0x001B37A3 File Offset: 0x001B19A3
		static ConfigSolarSchoolRoleSpineById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRoleSpineById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRoleSpineById.ResetStaticDefaultValue));
		}

		// Token: 0x06003CA5 RID: 15525 RVA: 0x001B37C4 File Offset: 0x001B19C4
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRoleSpineById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRoleSpineById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_角色.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolRoleSpine"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolRoleSpine` where Id=?")
			});
		}

		// Token: 0x06003CA6 RID: 15526 RVA: 0x001B3843 File Offset: 0x001B1A43
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRoleSpineById.LogPair = null;
			ConfigSolarSchoolRoleSpineById.HandleId = 0;
		}

		// Token: 0x06003CA7 RID: 15527 RVA: 0x001B3851 File Offset: 0x001B1A51
		public static void Init()
		{
			ConfigSolarSchoolRoleSpineById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRoleSpineById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolRoleSpine` where Id=?");
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x001B386C File Offset: 0x001B1A6C
		public static SolarSchoolRoleSpine? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRoleSpineById.HandleId, ConfigSolarSchoolRoleSpineById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleSpineById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolRoleSpine?(SolarSchoolRoleSpine.GetRootAsSolarSchoolRoleSpine(configBuffer));
				}
			}
			ConfigSolarSchoolRoleSpineById.LogPair.Clear();
			ConfigSolarSchoolRoleSpineById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolRoleSpineById.HandleId, 1, p0Id, ConfigSolarSchoolRoleSpineById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolRoleSpineById.HandleId, true, ConfigSolarSchoolRoleSpineById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolRoleSpineById.HandleId, ConfigSolarSchoolRoleSpineById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRoleSpineById.HandleId, 0, ConfigSolarSchoolRoleSpineById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolRoleSpineById.HandleId, ConfigSolarSchoolRoleSpineById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolRoleSpine rootAsSolarSchoolRoleSpine = SolarSchoolRoleSpine.GetRootAsSolarSchoolRoleSpine(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleSpineById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRoleSpineById.HandleId, ConfigSolarSchoolRoleSpineById.LogPair);
			return new SolarSchoolRoleSpine?(rootAsSolarSchoolRoleSpine);
		}

		// Token: 0x0400468E RID: 18062
		private const string DB = "db_solarschool.db";

		// Token: 0x0400468F RID: 18063
		private const string FILE = "d.第二索拉_角色.xlsx";

		// Token: 0x04004690 RID: 18064
		private const string TABLE = "SolarSchoolRoleSpine";

		// Token: 0x04004691 RID: 18065
		private const string COMMAND = "select BinData from `SolarSchoolRoleSpine` where Id=?";

		// Token: 0x04004692 RID: 18066
		private const string KEY_PREFIX = "SolarSchoolRoleSpineById";

		// Token: 0x04004693 RID: 18067
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004694 RID: 18068
		private static int HandleId;
	}
}
