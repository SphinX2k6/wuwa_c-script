using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009EF RID: 2543
	public class ConfigTowerBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BAE RID: 15278 RVA: 0x001AB495 File Offset: 0x001A9695
		static ConfigTowerBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerBuffById.CreateStaticDefaultValue), new Action(ConfigTowerBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x001AB4B4 File Offset: 0x001A96B4
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tower.db"),
				new ValueTuple<string, object>("文件", "p.爬塔新.xlsx"),
				new ValueTuple<string, object>("表名", "TowerBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerBuff` where Id = ?")
			});
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x001AB533 File Offset: 0x001A9733
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerBuffById.LogPair = null;
			ConfigTowerBuffById.HandleId = 0;
		}

		// Token: 0x06003BB1 RID: 15281 RVA: 0x001AB541 File Offset: 0x001A9741
		public static void Init()
		{
			ConfigTowerBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerBuffById.HandleId, "db_tower.db", "select BinData from `TowerBuff` where Id = ?");
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x001AB55C File Offset: 0x001A975C
		public static TowerBuff? GetConfig(long p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerBuffById.HandleId, ConfigTowerBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TowerBuff?(TowerBuff.GetRootAsTowerBuff(configBuffer));
				}
			}
			ConfigTowerBuffById.LogPair.Clear();
			ConfigTowerBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindFloat64(ConfigTowerBuffById.HandleId, 1, (double)p0Id, ConfigTowerBuffById.LogPair) || ConfigCommon.Step(ConfigTowerBuffById.HandleId, true, ConfigTowerBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTowerBuffById.HandleId, ConfigTowerBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerBuffById.HandleId, 0, ConfigTowerBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTowerBuffById.HandleId, ConfigTowerBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TowerBuff rootAsTowerBuff = TowerBuff.GetRootAsTowerBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTowerBuffById.HandleId, ConfigTowerBuffById.LogPair);
			return new TowerBuff?(rootAsTowerBuff);
		}

		// Token: 0x0400456F RID: 17775
		private const string DB = "db_tower.db";

		// Token: 0x04004570 RID: 17776
		private const string FILE = "p.爬塔新.xlsx";

		// Token: 0x04004571 RID: 17777
		private const string TABLE = "TowerBuff";

		// Token: 0x04004572 RID: 17778
		private const string COMMAND = "select BinData from `TowerBuff` where Id = ?";

		// Token: 0x04004573 RID: 17779
		private const string KEY_PREFIX = "TowerBuffById";

		// Token: 0x04004574 RID: 17780
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004575 RID: 17781
		private static int HandleId;
	}
}
