using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ACE RID: 2766
	public class ConfigTowerDefencePhantomById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060040E8 RID: 16616 RVA: 0x001CBC17 File Offset: 0x001C9E17
		static ConfigTowerDefencePhantomById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerDefencePhantomById.CreateStaticDefaultValue), new Action(ConfigTowerDefencePhantomById.ResetStaticDefaultValue));
		}

		// Token: 0x060040E9 RID: 16617 RVA: 0x001CBC38 File Offset: 0x001C9E38
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerDefencePhantomById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerDefencePhantomById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_towerdefense.db"),
				new ValueTuple<string, object>("文件", "l.联机塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TowerDefencePhantom"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerDefencePhantom` where Id = ?")
			});
		}

		// Token: 0x060040EA RID: 16618 RVA: 0x001CBCB7 File Offset: 0x001C9EB7
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerDefencePhantomById.LogPair = null;
			ConfigTowerDefencePhantomById.HandleId = 0;
		}

		// Token: 0x060040EB RID: 16619 RVA: 0x001CBCC5 File Offset: 0x001C9EC5
		public static void Init()
		{
			ConfigTowerDefencePhantomById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerDefencePhantomById.HandleId, "db_towerdefense.db", "select BinData from `TowerDefencePhantom` where Id = ?");
		}

		// Token: 0x060040EC RID: 16620 RVA: 0x001CBCE0 File Offset: 0x001C9EE0
		public static TowerDefencePhantom? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerDefencePhantomById.HandleId, ConfigTowerDefencePhantomById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDefencePhantomById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TowerDefencePhantom?(TowerDefencePhantom.GetRootAsTowerDefencePhantom(configBuffer));
				}
			}
			ConfigTowerDefencePhantomById.LogPair.Clear();
			ConfigTowerDefencePhantomById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTowerDefencePhantomById.HandleId, 1, p0Id, ConfigTowerDefencePhantomById.LogPair) || ConfigCommon.Step(ConfigTowerDefencePhantomById.HandleId, true, ConfigTowerDefencePhantomById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTowerDefencePhantomById.HandleId, ConfigTowerDefencePhantomById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerDefencePhantomById.HandleId, 0, ConfigTowerDefencePhantomById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTowerDefencePhantomById.HandleId, ConfigTowerDefencePhantomById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TowerDefencePhantom rootAsTowerDefencePhantom = TowerDefencePhantom.GetRootAsTowerDefencePhantom(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerDefencePhantomById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTowerDefencePhantomById.HandleId, ConfigTowerDefencePhantomById.LogPair);
			return new TowerDefencePhantom?(rootAsTowerDefencePhantom);
		}

		// Token: 0x04004B88 RID: 19336
		private const string DB = "db_towerdefense.db";

		// Token: 0x04004B89 RID: 19337
		private const string FILE = "l.联机塔防活动.xlsx";

		// Token: 0x04004B8A RID: 19338
		private const string TABLE = "TowerDefencePhantom";

		// Token: 0x04004B8B RID: 19339
		private const string COMMAND = "select BinData from `TowerDefencePhantom` where Id = ?";

		// Token: 0x04004B8C RID: 19340
		private const string KEY_PREFIX = "TowerDefencePhantomById";

		// Token: 0x04004B8D RID: 19341
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B8E RID: 19342
		private static int HandleId;
	}
}
