using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AD0 RID: 2768
	public class ConfigTowerDefencePhantomLevelByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060040F4 RID: 16628 RVA: 0x001CBFF3 File Offset: 0x001CA1F3
		static ConfigTowerDefencePhantomLevelByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefencePhantomLevelByGroupId.CreateStaticDefaultValue), new Action(ConfigTowerDefencePhantomLevelByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060040F5 RID: 16629 RVA: 0x001CC014 File Offset: 0x001CA214
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

		// Token: 0x060040F6 RID: 16630 RVA: 0x001CC093 File Offset: 0x001CA293
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefencePhantomLevelByGroupId.LogPair = null;
			ConfigTowerDefencePhantomLevelByGroupId.HandleId = 0;
		}

		// Token: 0x060040F7 RID: 16631 RVA: 0x001CC0A1 File Offset: 0x001CA2A1
		public static void Init()
		{
			ConfigTowerDefencePhantomLevelByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefencePhantomLevelByGroupId.HandleId, "db_towerdefense.db", "select BinData from `TowerDefencePhantomLevel` where GroupId = ?");
		}

		// Token: 0x060040F8 RID: 16632 RVA: 0x001CC0BC File Offset: 0x001CA2BC
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

		// Token: 0x04004B96 RID: 19350
		private const string DB = "db_towerdefense.db";

		// Token: 0x04004B97 RID: 19351
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x04004B98 RID: 19352
		private const string TABLE = "TowerDefencePhantomLevel";

		// Token: 0x04004B99 RID: 19353
		private const string COMMAND = "select BinData from `TowerDefencePhantomLevel` where GroupId = ?";

		// Token: 0x04004B9A RID: 19354
		private const string KEY_PREFIX = "TowerDefencePhantomLevelByGroupId";

		// Token: 0x04004B9B RID: 19355
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B9C RID: 19356
		private static int HandleId;
	}
}
