using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005D1 RID: 1489
	public class ConfigMowTowerBuffReById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022F3 RID: 8947 RVA: 0x0011F22B File Offset: 0x0011D42B
		static ConfigMowTowerBuffReById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMowTowerBuffReById.CreateStaticDefaultValue), new Action(ConfigMowTowerBuffReById.ResetStaticDefaultValue));
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x0011F24C File Offset: 0x0011D44C
		public static void CreateStaticDefaultValue()
		{
			ConfigMowTowerBuffReById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMowTowerBuffReById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mowtower.db"),
				new ValueTuple<string, object>("文件", "g.割草爬塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "MowTowerBuffRe"),
				new ValueTuple<string, object>("语句", "select BinData from `MowTowerBuffRe` where Id=?")
			});
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x0011F2CB File Offset: 0x0011D4CB
		public static void ResetStaticDefaultValue()
		{
			ConfigMowTowerBuffReById.LogPair = null;
			ConfigMowTowerBuffReById.HandleId = 0;
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x0011F2D9 File Offset: 0x0011D4D9
		public static void Init()
		{
			ConfigMowTowerBuffReById.HandleId = ConfigCommon.InitDataStatement(ConfigMowTowerBuffReById.HandleId, "db_mowtower.db", "select BinData from `MowTowerBuffRe` where Id=?");
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x0011F2F4 File Offset: 0x0011D4F4
		public static MowTowerBuffRe? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMowTowerBuffReById.HandleId, ConfigMowTowerBuffReById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MowTowerBuffReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MowTowerBuffRe?(MowTowerBuffRe.GetRootAsMowTowerBuffRe(configBuffer));
				}
			}
			ConfigMowTowerBuffReById.LogPair.Clear();
			ConfigMowTowerBuffReById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMowTowerBuffReById.HandleId, 1, p0Id, ConfigMowTowerBuffReById.LogPair) || ConfigCommon.Step(ConfigMowTowerBuffReById.HandleId, true, ConfigMowTowerBuffReById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMowTowerBuffReById.HandleId, ConfigMowTowerBuffReById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMowTowerBuffReById.HandleId, 0, ConfigMowTowerBuffReById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMowTowerBuffReById.HandleId, ConfigMowTowerBuffReById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MowTowerBuffRe rootAsMowTowerBuffRe = MowTowerBuffRe.GetRootAsMowTowerBuffRe(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MowTowerBuffReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMowTowerBuffReById.HandleId, ConfigMowTowerBuffReById.LogPair);
			return new MowTowerBuffRe?(rootAsMowTowerBuffRe);
		}

		// Token: 0x0400289B RID: 10395
		private const string DB = "db_mowtower.db";

		// Token: 0x0400289C RID: 10396
		private const string FILE = "g.割草爬塔活动.xlsx";

		// Token: 0x0400289D RID: 10397
		private const string TABLE = "MowTowerBuffRe";

		// Token: 0x0400289E RID: 10398
		private const string COMMAND = "select BinData from `MowTowerBuffRe` where Id=?";

		// Token: 0x0400289F RID: 10399
		private const string KEY_PREFIX = "MowTowerBuffReById";

		// Token: 0x040028A0 RID: 10400
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028A1 RID: 10401
		private static int HandleId;
	}
}
