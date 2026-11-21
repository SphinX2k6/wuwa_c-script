using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AD8 RID: 2776
	public class ConfigTowerQuickPassById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004124 RID: 16676 RVA: 0x001CD170 File Offset: 0x001CB370
		static ConfigTowerQuickPassById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerQuickPassById.CreateStaticDefaultValue), new Action(ConfigTowerQuickPassById.ResetStaticDefaultValue));
		}

		// Token: 0x06004125 RID: 16677 RVA: 0x001CD190 File Offset: 0x001CB390
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerQuickPassById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerQuickPassById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tower.db"),
				new ValueTuple<string, object>("文件", "p.爬塔新.xlsx"),
				new ValueTuple<string, object>("表名", "TowerQuickPass"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerQuickPass` where Id = ?")
			});
		}

		// Token: 0x06004126 RID: 16678 RVA: 0x001CD20F File Offset: 0x001CB40F
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerQuickPassById.LogPair = null;
			ConfigTowerQuickPassById.HandleId = 0;
		}

		// Token: 0x06004127 RID: 16679 RVA: 0x001CD21D File Offset: 0x001CB41D
		public static void Init()
		{
			ConfigTowerQuickPassById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerQuickPassById.HandleId, "db_tower.db", "select BinData from `TowerQuickPass` where Id = ?");
		}

		// Token: 0x06004128 RID: 16680 RVA: 0x001CD238 File Offset: 0x001CB438
		public static TowerQuickPass? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerQuickPassById.HandleId, ConfigTowerQuickPassById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerQuickPassById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TowerQuickPass?(TowerQuickPass.GetRootAsTowerQuickPass(configBuffer));
				}
			}
			ConfigTowerQuickPassById.LogPair.Clear();
			ConfigTowerQuickPassById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTowerQuickPassById.HandleId, 1, p0Id, ConfigTowerQuickPassById.LogPair) || ConfigCommon.Step(ConfigTowerQuickPassById.HandleId, true, ConfigTowerQuickPassById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTowerQuickPassById.HandleId, ConfigTowerQuickPassById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerQuickPassById.HandleId, 0, ConfigTowerQuickPassById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTowerQuickPassById.HandleId, ConfigTowerQuickPassById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TowerQuickPass rootAsTowerQuickPass = TowerQuickPass.GetRootAsTowerQuickPass(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerQuickPassById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTowerQuickPassById.HandleId, ConfigTowerQuickPassById.LogPair);
			return new TowerQuickPass?(rootAsTowerQuickPass);
		}

		// Token: 0x04004BCE RID: 19406
		private const string DB = "db_tower.db";

		// Token: 0x04004BCF RID: 19407
		private const string FILE = "p.爬塔新.xlsx";

		// Token: 0x04004BD0 RID: 19408
		private const string TABLE = "TowerQuickPass";

		// Token: 0x04004BD1 RID: 19409
		private const string COMMAND = "select BinData from `TowerQuickPass` where Id = ?";

		// Token: 0x04004BD2 RID: 19410
		private const string KEY_PREFIX = "TowerQuickPassById";

		// Token: 0x04004BD3 RID: 19411
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004BD4 RID: 19412
		private static int HandleId;
	}
}
