using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005D3 RID: 1491
	public class ConfigMowTowerLevelsReById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022FF RID: 8959 RVA: 0x0011F607 File Offset: 0x0011D807
		static ConfigMowTowerLevelsReById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMowTowerLevelsReById.CreateStaticDefaultValue), new Action(ConfigMowTowerLevelsReById.ResetStaticDefaultValue));
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x0011F628 File Offset: 0x0011D828
		public static void CreateStaticDefaultValue()
		{
			ConfigMowTowerLevelsReById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMowTowerLevelsReById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mowtower.db"),
				new ValueTuple<string, object>("文件", "g.割草爬塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "MowTowerLevelsRe"),
				new ValueTuple<string, object>("语句", "select BinData from `MowTowerLevelsRe` where Id=?")
			});
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x0011F6A7 File Offset: 0x0011D8A7
		public static void ResetStaticDefaultValue()
		{
			ConfigMowTowerLevelsReById.LogPair = null;
			ConfigMowTowerLevelsReById.HandleId = 0;
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x0011F6B5 File Offset: 0x0011D8B5
		public static void Init()
		{
			ConfigMowTowerLevelsReById.HandleId = ConfigCommon.InitDataStatement(ConfigMowTowerLevelsReById.HandleId, "db_mowtower.db", "select BinData from `MowTowerLevelsRe` where Id=?");
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x0011F6D0 File Offset: 0x0011D8D0
		public static MowTowerLevelsRe? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMowTowerLevelsReById.HandleId, ConfigMowTowerLevelsReById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MowTowerLevelsReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MowTowerLevelsRe?(MowTowerLevelsRe.GetRootAsMowTowerLevelsRe(configBuffer));
				}
			}
			ConfigMowTowerLevelsReById.LogPair.Clear();
			ConfigMowTowerLevelsReById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMowTowerLevelsReById.HandleId, 1, p0Id, ConfigMowTowerLevelsReById.LogPair) || ConfigCommon.Step(ConfigMowTowerLevelsReById.HandleId, true, ConfigMowTowerLevelsReById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMowTowerLevelsReById.HandleId, ConfigMowTowerLevelsReById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMowTowerLevelsReById.HandleId, 0, ConfigMowTowerLevelsReById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMowTowerLevelsReById.HandleId, ConfigMowTowerLevelsReById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MowTowerLevelsRe rootAsMowTowerLevelsRe = MowTowerLevelsRe.GetRootAsMowTowerLevelsRe(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MowTowerLevelsReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMowTowerLevelsReById.HandleId, ConfigMowTowerLevelsReById.LogPair);
			return new MowTowerLevelsRe?(rootAsMowTowerLevelsRe);
		}

		// Token: 0x040028A9 RID: 10409
		private const string DB = "db_mowtower.db";

		// Token: 0x040028AA RID: 10410
		private const string FILE = "g.割草爬塔活动.xlsx";

		// Token: 0x040028AB RID: 10411
		private const string TABLE = "MowTowerLevelsRe";

		// Token: 0x040028AC RID: 10412
		private const string COMMAND = "select BinData from `MowTowerLevelsRe` where Id=?";

		// Token: 0x040028AD RID: 10413
		private const string KEY_PREFIX = "MowTowerLevelsReById";

		// Token: 0x040028AE RID: 10414
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028AF RID: 10415
		private static int HandleId;
	}
}
