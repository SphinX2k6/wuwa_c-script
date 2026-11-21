using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000DB RID: 219
	public class ConfigBabelTowerBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000523 RID: 1315 RVA: 0x0007A537 File Offset: 0x00078737
		static ConfigBabelTowerBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerBuffById.CreateStaticDefaultValue), new Action(ConfigBabelTowerBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0007A558 File Offset: 0x00078758
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerBuff` where Id=?")
			});
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0007A5D7 File Offset: 0x000787D7
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerBuffById.LogPair = null;
			ConfigBabelTowerBuffById.HandleId = 0;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0007A5E5 File Offset: 0x000787E5
		public static void Init()
		{
			ConfigBabelTowerBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerBuffById.HandleId, "db_babeltower.db", "select BinData from `BabelTowerBuff` where Id=?");
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0007A600 File Offset: 0x00078800
		public static BabelTowerBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerBuffById.HandleId, ConfigBabelTowerBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BabelTowerBuff?(BabelTowerBuff.GetRootAsBabelTowerBuff(configBuffer));
				}
			}
			ConfigBabelTowerBuffById.LogPair.Clear();
			ConfigBabelTowerBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBabelTowerBuffById.HandleId, 1, p0Id, ConfigBabelTowerBuffById.LogPair) || ConfigCommon.Step(ConfigBabelTowerBuffById.HandleId, true, ConfigBabelTowerBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBabelTowerBuffById.HandleId, ConfigBabelTowerBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerBuffById.HandleId, 0, ConfigBabelTowerBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBabelTowerBuffById.HandleId, ConfigBabelTowerBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BabelTowerBuff rootAsBabelTowerBuff = BabelTowerBuff.GetRootAsBabelTowerBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBabelTowerBuffById.HandleId, ConfigBabelTowerBuffById.LogPair);
			return new BabelTowerBuff?(rootAsBabelTowerBuff);
		}

		// Token: 0x040005E1 RID: 1505
		private const string DB = "db_babeltower.db";

		// Token: 0x040005E2 RID: 1506
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x040005E3 RID: 1507
		private const string TABLE = "BabelTowerBuff";

		// Token: 0x040005E4 RID: 1508
		private const string COMMAND = "select BinData from `BabelTowerBuff` where Id=?";

		// Token: 0x040005E5 RID: 1509
		private const string KEY_PREFIX = "BabelTowerBuffById";

		// Token: 0x040005E6 RID: 1510
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005E7 RID: 1511
		private static int HandleId;
	}
}
