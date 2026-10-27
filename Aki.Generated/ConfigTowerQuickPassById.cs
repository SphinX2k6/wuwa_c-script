using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A03 RID: 2563
	public class ConfigTowerQuickPassById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C26 RID: 15398 RVA: 0x001ADDDC File Offset: 0x001ABFDC
		static ConfigTowerQuickPassById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerQuickPassById.CreateStaticDefaultValue), new Action(ConfigTowerQuickPassById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x001ADDFC File Offset: 0x001ABFFC
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

		// Token: 0x06003C28 RID: 15400 RVA: 0x001ADE7B File Offset: 0x001AC07B
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerQuickPassById.LogPair = null;
			ConfigTowerQuickPassById.HandleId = 0;
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x001ADE89 File Offset: 0x001AC089
		public static void Init()
		{
			ConfigTowerQuickPassById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerQuickPassById.HandleId, "db_tower.db", "select BinData from `TowerQuickPass` where Id = ?");
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x001ADEA4 File Offset: 0x001AC0A4
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

		// Token: 0x040045FB RID: 17915
		private const string DB = "db_tower.db";

		// Token: 0x040045FC RID: 17916
		private const string FILE = "p.爬塔新.xlsx";

		// Token: 0x040045FD RID: 17917
		private const string TABLE = "TowerQuickPass";

		// Token: 0x040045FE RID: 17918
		private const string COMMAND = "select BinData from `TowerQuickPass` where Id = ?";

		// Token: 0x040045FF RID: 17919
		private const string KEY_PREFIX = "TowerQuickPassById";

		// Token: 0x04004600 RID: 17920
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004601 RID: 17921
		private static int HandleId;
	}
}
