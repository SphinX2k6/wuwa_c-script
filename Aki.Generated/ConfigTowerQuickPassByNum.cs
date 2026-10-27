using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A04 RID: 2564
	public class ConfigTowerQuickPassByNum : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C2C RID: 15404 RVA: 0x001AE024 File Offset: 0x001AC224
		static ConfigTowerQuickPassByNum()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerQuickPassByNum.CreateStaticDefaultValue), new Action(ConfigTowerQuickPassByNum.ResetStaticDefaultValue));
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x001AE044 File Offset: 0x001AC244
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

		// Token: 0x06003C2E RID: 15406 RVA: 0x001AE0C3 File Offset: 0x001AC2C3
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerQuickPassByNum.LogPair = null;
			ConfigTowerQuickPassByNum.HandleId = 0;
		}

		// Token: 0x06003C2F RID: 15407 RVA: 0x001AE0D1 File Offset: 0x001AC2D1
		public static void Init()
		{
			ConfigTowerQuickPassByNum.HandleId = ConfigCommon.InitDataStatement(ConfigTowerQuickPassByNum.HandleId, "db_tower.db", "select BinData from `TowerQuickPass` where Num = ?");
		}

		// Token: 0x06003C30 RID: 15408 RVA: 0x001AE0EC File Offset: 0x001AC2EC
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

		// Token: 0x04004602 RID: 17922
		private const string DB = "db_tower.db";

		// Token: 0x04004603 RID: 17923
		private const string FILE = "p.爬塔新.xlsx";

		// Token: 0x04004604 RID: 17924
		private const string TABLE = "TowerQuickPass";

		// Token: 0x04004605 RID: 17925
		private const string COMMAND = "select BinData from `TowerQuickPass` where Num = ?";

		// Token: 0x04004606 RID: 17926
		private const string KEY_PREFIX = "TowerQuickPassByNum";

		// Token: 0x04004607 RID: 17927
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004608 RID: 17928
		private static int HandleId;
	}
}
