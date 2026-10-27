using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009FB RID: 2555
	public class ConfigTowerDefencePhantomLevelByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BF6 RID: 15350 RVA: 0x001ACC5F File Offset: 0x001AAE5F
		static ConfigTowerDefencePhantomLevelByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefencePhantomLevelByGroupId.CreateStaticDefaultValue), new Action(ConfigTowerDefencePhantomLevelByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06003BF7 RID: 15351 RVA: 0x001ACC80 File Offset: 0x001AAE80
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerDefencePhantomLevelByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerDefencePhantomLevelByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_towerdefense.db"),
				new ValueTuple<string, object>("文件", "l.联机塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TowerDefencePhantomLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerDefencePhantomLevel` where GroupId = ?")
			});
		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x001ACCFF File Offset: 0x001AAEFF
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefencePhantomLevelByGroupId.LogPair = null;
			ConfigTowerDefencePhantomLevelByGroupId.HandleId = 0;
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x001ACD0D File Offset: 0x001AAF0D
		public static void Init()
		{
			ConfigTowerDefencePhantomLevelByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefencePhantomLevelByGroupId.HandleId, "db_towerdefense.db", "select BinData from `TowerDefencePhantomLevel` where GroupId = ?");
		}

		// Token: 0x06003BFA RID: 15354 RVA: 0x001ACD28 File Offset: 0x001AAF28
		[NullableContext(2)]
		public static IReadOnlyList<TowerDefencePhantomLevel> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerDefencePhantomLevelByGroupId.HandleId, ConfigTowerDefencePhantomLevelByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDefencePhantomLevelByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<TowerDefencePhantomLevel> readOnlyList = (IReadOnlyList<TowerDefencePhantomLevel>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTowerDefencePhantomLevelByGroupId.LogPair.Clear();
			ConfigTowerDefencePhantomLevelByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigTowerDefencePhantomLevelByGroupId.HandleId, 1, p0GroupId, ConfigTowerDefencePhantomLevelByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigTowerDefencePhantomLevelByGroupId.HandleId, ConfigTowerDefencePhantomLevelByGroupId.LogPair);
				return null;
			}
			List<TowerDefencePhantomLevel> list = new List<TowerDefencePhantomLevel>();
			while (ConfigCommon.Step(ConfigTowerDefencePhantomLevelByGroupId.HandleId, false, ConfigTowerDefencePhantomLevelByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerDefencePhantomLevelByGroupId.HandleId, 0, ConfigTowerDefencePhantomLevelByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTowerDefencePhantomLevelByGroupId.HandleId, ConfigTowerDefencePhantomLevelByGroupId.LogPair);
					return null;
				}
				TowerDefencePhantomLevel rootAsTowerDefencePhantomLevel = TowerDefencePhantomLevel.GetRootAsTowerDefencePhantomLevel(new ByteBuffer(item2));
				list.Add(rootAsTowerDefencePhantomLevel);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDefencePhantomLevelByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTowerDefencePhantomLevelByGroupId.HandleId, ConfigTowerDefencePhantomLevelByGroupId.LogPair);
			return list;
		}

		// Token: 0x040045C3 RID: 17859
		private const string DB = "db_towerdefense.db";

		// Token: 0x040045C4 RID: 17860
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x040045C5 RID: 17861
		private const string TABLE = "TowerDefencePhantomLevel";

		// Token: 0x040045C6 RID: 17862
		private const string COMMAND = "select BinData from `TowerDefencePhantomLevel` where GroupId = ?";

		// Token: 0x040045C7 RID: 17863
		private const string KEY_PREFIX = "TowerDefencePhantomLevelByGroupId";

		// Token: 0x040045C8 RID: 17864
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045C9 RID: 17865
		private static int HandleId;
	}
}
