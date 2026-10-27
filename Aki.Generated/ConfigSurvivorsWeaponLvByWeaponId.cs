using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009B6 RID: 2486
	public class ConfigSurvivorsWeaponLvByWeaponId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A58 RID: 14936 RVA: 0x001A3BA4 File Offset: 0x001A1DA4
		static ConfigSurvivorsWeaponLvByWeaponId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsWeaponLvByWeaponId.CreateStaticDefaultValue), new Action(ConfigSurvivorsWeaponLvByWeaponId.ResetStaticDefaultValue));
		}

		// Token: 0x06003A59 RID: 14937 RVA: 0x001A3BC4 File Offset: 0x001A1DC4
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsWeaponLvByWeaponId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsWeaponLvByWeaponId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局内.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsWeaponLv"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsWeaponLv` where WeaponId=?")
			});
		}

		// Token: 0x06003A5A RID: 14938 RVA: 0x001A3C43 File Offset: 0x001A1E43
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsWeaponLvByWeaponId.LogPair = null;
			ConfigSurvivorsWeaponLvByWeaponId.HandleId = 0;
		}

		// Token: 0x06003A5B RID: 14939 RVA: 0x001A3C51 File Offset: 0x001A1E51
		public static void Init()
		{
			ConfigSurvivorsWeaponLvByWeaponId.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsWeaponLvByWeaponId.HandleId, "db_survivors.db", "select BinData from `SurvivorsWeaponLv` where WeaponId=?");
		}

		// Token: 0x06003A5C RID: 14940 RVA: 0x001A3C6C File Offset: 0x001A1E6C
		[NullableContext(2)]
		public static IReadOnlyList<SurvivorsWeaponLv> GetConfigList(int p0WeaponId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsWeaponLvByWeaponId.HandleId, ConfigSurvivorsWeaponLvByWeaponId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsWeaponLvByWeaponId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0WeaponId);
				IReadOnlyList<SurvivorsWeaponLv> readOnlyList = (IReadOnlyList<SurvivorsWeaponLv>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSurvivorsWeaponLvByWeaponId.LogPair.Clear();
			ConfigSurvivorsWeaponLvByWeaponId.LogPair.Add(new ValueTuple<string, object>("WeaponId", p0WeaponId));
			if (!ConfigCommon.BindInt(ConfigSurvivorsWeaponLvByWeaponId.HandleId, 1, p0WeaponId, ConfigSurvivorsWeaponLvByWeaponId.LogPair))
			{
				ConfigCommon.Reset(ConfigSurvivorsWeaponLvByWeaponId.HandleId, ConfigSurvivorsWeaponLvByWeaponId.LogPair);
				return null;
			}
			List<SurvivorsWeaponLv> list = new List<SurvivorsWeaponLv>();
			while (ConfigCommon.Step(ConfigSurvivorsWeaponLvByWeaponId.HandleId, false, ConfigSurvivorsWeaponLvByWeaponId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsWeaponLvByWeaponId.HandleId, 0, ConfigSurvivorsWeaponLvByWeaponId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSurvivorsWeaponLvByWeaponId.HandleId, ConfigSurvivorsWeaponLvByWeaponId.LogPair);
					return null;
				}
				SurvivorsWeaponLv rootAsSurvivorsWeaponLv = SurvivorsWeaponLv.GetRootAsSurvivorsWeaponLv(new ByteBuffer(item2));
				list.Add(rootAsSurvivorsWeaponLv);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsWeaponLvByWeaponId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0WeaponId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSurvivorsWeaponLvByWeaponId.HandleId, ConfigSurvivorsWeaponLvByWeaponId.LogPair);
			return list;
		}

		// Token: 0x040043E0 RID: 17376
		private const string DB = "db_survivors.db";

		// Token: 0x040043E1 RID: 17377
		private const string FILE = "x.幸存者_局内.xlsx";

		// Token: 0x040043E2 RID: 17378
		private const string TABLE = "SurvivorsWeaponLv";

		// Token: 0x040043E3 RID: 17379
		private const string COMMAND = "select BinData from `SurvivorsWeaponLv` where WeaponId=?";

		// Token: 0x040043E4 RID: 17380
		private const string KEY_PREFIX = "SurvivorsWeaponLvByWeaponId";

		// Token: 0x040043E5 RID: 17381
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043E6 RID: 17382
		private static int HandleId;
	}
}
