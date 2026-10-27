using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A07 RID: 2567
	public class ConfigTowerTargetById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C3E RID: 15422 RVA: 0x001AE6EB File Offset: 0x001AC8EB
		static ConfigTowerTargetById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerTargetById.CreateStaticDefaultValue), new Action(ConfigTowerTargetById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C3F RID: 15423 RVA: 0x001AE70C File Offset: 0x001AC90C
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerTargetById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerTargetById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tower.db"),
				new ValueTuple<string, object>("文件", "p.爬塔新.xlsx"),
				new ValueTuple<string, object>("表名", "TowerTarget"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerTarget` where Id = ?")
			});
		}

		// Token: 0x06003C40 RID: 15424 RVA: 0x001AE78B File Offset: 0x001AC98B
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerTargetById.LogPair = null;
			ConfigTowerTargetById.HandleId = 0;
		}

		// Token: 0x06003C41 RID: 15425 RVA: 0x001AE799 File Offset: 0x001AC999
		public static void Init()
		{
			ConfigTowerTargetById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerTargetById.HandleId, "db_tower.db", "select BinData from `TowerTarget` where Id = ?");
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x001AE7B4 File Offset: 0x001AC9B4
		public static TowerTarget? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerTargetById.HandleId, ConfigTowerTargetById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerTargetById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TowerTarget?(TowerTarget.GetRootAsTowerTarget(configBuffer));
				}
			}
			ConfigTowerTargetById.LogPair.Clear();
			ConfigTowerTargetById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTowerTargetById.HandleId, 1, p0Id, ConfigTowerTargetById.LogPair) || ConfigCommon.Step(ConfigTowerTargetById.HandleId, true, ConfigTowerTargetById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTowerTargetById.HandleId, ConfigTowerTargetById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerTargetById.HandleId, 0, ConfigTowerTargetById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTowerTargetById.HandleId, ConfigTowerTargetById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TowerTarget rootAsTowerTarget = TowerTarget.GetRootAsTowerTarget(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerTargetById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTowerTargetById.HandleId, ConfigTowerTargetById.LogPair);
			return new TowerTarget?(rootAsTowerTarget);
		}

		// Token: 0x04004617 RID: 17943
		private const string DB = "db_tower.db";

		// Token: 0x04004618 RID: 17944
		private const string FILE = "p.爬塔新.xlsx";

		// Token: 0x04004619 RID: 17945
		private const string TABLE = "TowerTarget";

		// Token: 0x0400461A RID: 17946
		private const string COMMAND = "select BinData from `TowerTarget` where Id = ?";

		// Token: 0x0400461B RID: 17947
		private const string KEY_PREFIX = "TowerTargetById";

		// Token: 0x0400461C RID: 17948
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400461D RID: 17949
		private static int HandleId;
	}
}
