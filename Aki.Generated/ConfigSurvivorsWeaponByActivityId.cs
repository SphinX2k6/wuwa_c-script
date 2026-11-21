using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A87 RID: 2695
	public class ConfigSurvivorsWeaponByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F3E RID: 16190 RVA: 0x001C2627 File Offset: 0x001C0827
		static ConfigSurvivorsWeaponByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsWeaponByActivityId.CreateStaticDefaultValue), new Action(ConfigSurvivorsWeaponByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x001C2648 File Offset: 0x001C0848
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

		// Token: 0x06003F40 RID: 16192 RVA: 0x001C26C7 File Offset: 0x001C08C7
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsWeaponByActivityId.LogPair = null;
			ConfigSurvivorsWeaponByActivityId.HandleId = 0;
		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x001C26D5 File Offset: 0x001C08D5
		public static void Init()
		{
			ConfigSurvivorsWeaponByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsWeaponByActivityId.HandleId, "db_survivors.db", "select BinData from `SurvivorsWeapon` where ActivityId=?");
		}

		// Token: 0x06003F42 RID: 16194 RVA: 0x001C26F0 File Offset: 0x001C08F0
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

		// Token: 0x04004997 RID: 18839
		private const string DB = "db_survivors.db";

		// Token: 0x04004998 RID: 18840
		private const string FILE = "x.幸存者_局内.xlsx";

		// Token: 0x04004999 RID: 18841
		private const string TABLE = "SurvivorsWeapon";

		// Token: 0x0400499A RID: 18842
		private const string COMMAND = "select BinData from `SurvivorsWeapon` where ActivityId=?";

		// Token: 0x0400499B RID: 18843
		private const string KEY_PREFIX = "SurvivorsWeaponByActivityId";

		// Token: 0x0400499C RID: 18844
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400499D RID: 18845
		private static int HandleId;
	}
}
