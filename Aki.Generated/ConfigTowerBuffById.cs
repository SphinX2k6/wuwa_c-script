using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AC4 RID: 2756
	public class ConfigTowerBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060040AC RID: 16556 RVA: 0x001CA829 File Offset: 0x001C8A29
		static ConfigTowerBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerBuffById.CreateStaticDefaultValue), new Action(ConfigTowerBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x001CA848 File Offset: 0x001C8A48
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

		// Token: 0x060040AE RID: 16558 RVA: 0x001CA8C7 File Offset: 0x001C8AC7
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerBuffById.LogPair = null;
			ConfigTowerBuffById.HandleId = 0;
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x001CA8D5 File Offset: 0x001C8AD5
		public static void Init()
		{
			ConfigTowerBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerBuffById.HandleId, "db_tower.db", "select BinData from `TowerBuff` where Id = ?");
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x001CA8F0 File Offset: 0x001C8AF0
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

		// Token: 0x04004B42 RID: 19266
		private const string DB = "db_tower.db";

		// Token: 0x04004B43 RID: 19267
		private const string FILE = "p.爬塔新.xlsx";

		// Token: 0x04004B44 RID: 19268
		private const string TABLE = "TowerBuff";

		// Token: 0x04004B45 RID: 19269
		private const string COMMAND = "select BinData from `TowerBuff` where Id = ?";

		// Token: 0x04004B46 RID: 19270
		private const string KEY_PREFIX = "TowerBuffById";

		// Token: 0x04004B47 RID: 19271
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B48 RID: 19272
		private static int HandleId;
	}
}
