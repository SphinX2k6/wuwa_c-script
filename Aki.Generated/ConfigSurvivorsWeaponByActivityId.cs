using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009B2 RID: 2482
	public class ConfigSurvivorsWeaponByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A40 RID: 14912 RVA: 0x001A3293 File Offset: 0x001A1493
		static ConfigSurvivorsWeaponByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsWeaponByActivityId.CreateStaticDefaultValue), new Action(ConfigSurvivorsWeaponByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x001A32B4 File Offset: 0x001A14B4
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsWeaponByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsWeaponByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局内.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsWeapon"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsWeapon` where ActivityId=?")
			});
		}

		// Token: 0x06003A42 RID: 14914 RVA: 0x001A3333 File Offset: 0x001A1533
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsWeaponByActivityId.LogPair = null;
			ConfigSurvivorsWeaponByActivityId.HandleId = 0;
		}

		// Token: 0x06003A43 RID: 14915 RVA: 0x001A3341 File Offset: 0x001A1541
		public static void Init()
		{
			ConfigSurvivorsWeaponByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsWeaponByActivityId.HandleId, "db_survivors.db", "select BinData from `SurvivorsWeapon` where ActivityId=?");
		}

		// Token: 0x06003A44 RID: 14916 RVA: 0x001A335C File Offset: 0x001A155C
		[NullableContext(2)]
		public static IReadOnlyList<SurvivorsWeapon> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsWeaponByActivityId.HandleId, ConfigSurvivorsWeaponByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsWeaponByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SurvivorsWeapon> readOnlyList = (IReadOnlyList<SurvivorsWeapon>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSurvivorsWeaponByActivityId.LogPair.Clear();
			ConfigSurvivorsWeaponByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSurvivorsWeaponByActivityId.HandleId, 1, p0ActivityId, ConfigSurvivorsWeaponByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSurvivorsWeaponByActivityId.HandleId, ConfigSurvivorsWeaponByActivityId.LogPair);
				return null;
			}
			List<SurvivorsWeapon> list = new List<SurvivorsWeapon>();
			while (ConfigCommon.Step(ConfigSurvivorsWeaponByActivityId.HandleId, false, ConfigSurvivorsWeaponByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsWeaponByActivityId.HandleId, 0, ConfigSurvivorsWeaponByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSurvivorsWeaponByActivityId.HandleId, ConfigSurvivorsWeaponByActivityId.LogPair);
					return null;
				}
				SurvivorsWeapon rootAsSurvivorsWeapon = SurvivorsWeapon.GetRootAsSurvivorsWeapon(new ByteBuffer(item2));
				list.Add(rootAsSurvivorsWeapon);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsWeaponByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSurvivorsWeaponByActivityId.HandleId, ConfigSurvivorsWeaponByActivityId.LogPair);
			return list;
		}

		// Token: 0x040043C4 RID: 17348
		private const string DB = "db_survivors.db";

		// Token: 0x040043C5 RID: 17349
		private const string FILE = "x.幸存者_局内.xlsx";

		// Token: 0x040043C6 RID: 17350
		private const string TABLE = "SurvivorsWeapon";

		// Token: 0x040043C7 RID: 17351
		private const string COMMAND = "select BinData from `SurvivorsWeapon` where ActivityId=?";

		// Token: 0x040043C8 RID: 17352
		private const string KEY_PREFIX = "SurvivorsWeaponByActivityId";

		// Token: 0x040043C9 RID: 17353
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043CA RID: 17354
		private static int HandleId;
	}
}
