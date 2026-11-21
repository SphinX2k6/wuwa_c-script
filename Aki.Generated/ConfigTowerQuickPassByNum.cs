using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AD9 RID: 2777
	public class ConfigTowerQuickPassByNum : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600412A RID: 16682 RVA: 0x001CD3B8 File Offset: 0x001CB5B8
		static ConfigTowerQuickPassByNum()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerQuickPassByNum.CreateStaticDefaultValue), new Action(ConfigTowerQuickPassByNum.ResetStaticDefaultValue));
		}

		// Token: 0x0600412B RID: 16683 RVA: 0x001CD3D8 File Offset: 0x001CB5D8
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerQuickPassByNum.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerQuickPassByNum.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tower.db"),
				new ValueTuple<string, object>("文件", "p.爬塔新.xlsx"),
				new ValueTuple<string, object>("表名", "TowerQuickPass"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerQuickPass` where Num = ?")
			});
		}

		// Token: 0x0600412C RID: 16684 RVA: 0x001CD457 File Offset: 0x001CB657
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerQuickPassByNum.LogPair = null;
			ConfigTowerQuickPassByNum.HandleId = 0;
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x001CD465 File Offset: 0x001CB665
		public static void Init()
		{
			ConfigTowerQuickPassByNum.HandleId = ConfigCommon.InitDataStatement(ConfigTowerQuickPassByNum.HandleId, "db_tower.db", "select BinData from `TowerQuickPass` where Num = ?");
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x001CD480 File Offset: 0x001CB680
		public static TowerQuickPass? GetConfig(int p0Num, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerQuickPassByNum.HandleId, ConfigTowerQuickPassByNum.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerQuickPassByNum");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Num);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TowerQuickPass?(TowerQuickPass.GetRootAsTowerQuickPass(configBuffer));
				}
			}
			ConfigTowerQuickPassByNum.LogPair.Clear();
			ConfigTowerQuickPassByNum.LogPair.Add(new ValueTuple<string, object>("Num", p0Num));
			if (!ConfigCommon.BindInt(ConfigTowerQuickPassByNum.HandleId, 1, p0Num, ConfigTowerQuickPassByNum.LogPair) || ConfigCommon.Step(ConfigTowerQuickPassByNum.HandleId, true, ConfigTowerQuickPassByNum.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTowerQuickPassByNum.HandleId, ConfigTowerQuickPassByNum.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerQuickPassByNum.HandleId, 0, ConfigTowerQuickPassByNum.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTowerQuickPassByNum.HandleId, ConfigTowerQuickPassByNum.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TowerQuickPass rootAsTowerQuickPass = TowerQuickPass.GetRootAsTowerQuickPass(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerQuickPassByNum");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Num);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTowerQuickPassByNum.HandleId, ConfigTowerQuickPassByNum.LogPair);
			return new TowerQuickPass?(rootAsTowerQuickPass);
		}

		// Token: 0x04004BD5 RID: 19413
		private const string DB = "db_tower.db";

		// Token: 0x04004BD6 RID: 19414
		private const string FILE = "p.爬塔新.xlsx";

		// Token: 0x04004BD7 RID: 19415
		private const string TABLE = "TowerQuickPass";

		// Token: 0x04004BD8 RID: 19416
		private const string COMMAND = "select BinData from `TowerQuickPass` where Num = ?";

		// Token: 0x04004BD9 RID: 19417
		private const string KEY_PREFIX = "TowerQuickPassByNum";

		// Token: 0x04004BDA RID: 19418
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004BDB RID: 19419
		private static int HandleId;
	}
}
