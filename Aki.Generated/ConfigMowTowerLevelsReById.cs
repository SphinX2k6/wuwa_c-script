using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005EB RID: 1515
	public class ConfigMowTowerLevelsReById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600238F RID: 9103 RVA: 0x00126083 File Offset: 0x00124283
		static ConfigMowTowerLevelsReById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMowTowerLevelsReById.CreateStaticDefaultValue), new Action(ConfigMowTowerLevelsReById.ResetStaticDefaultValue));
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x001260A4 File Offset: 0x001242A4
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

		// Token: 0x06002391 RID: 9105 RVA: 0x00126123 File Offset: 0x00124323
		public static void ResetStaticDefaultValue()
		{
			ConfigMowTowerLevelsReById.LogPair = null;
			ConfigMowTowerLevelsReById.HandleId = 0;
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x00126131 File Offset: 0x00124331
		public static void Init()
		{
			ConfigMowTowerLevelsReById.HandleId = ConfigCommon.InitDataStatement(ConfigMowTowerLevelsReById.HandleId, "db_mowtower.db", "select BinData from `MowTowerLevelsRe` where Id=?");
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x0012614C File Offset: 0x0012434C
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

		// Token: 0x04002951 RID: 10577
		private const string DB = "db_mowtower.db";

		// Token: 0x04002952 RID: 10578
		private const string FILE = "g.割草爬塔活动.xlsx";

		// Token: 0x04002953 RID: 10579
		private const string TABLE = "MowTowerLevelsRe";

		// Token: 0x04002954 RID: 10580
		private const string COMMAND = "select BinData from `MowTowerLevelsRe` where Id=?";

		// Token: 0x04002955 RID: 10581
		private const string KEY_PREFIX = "MowTowerLevelsReById";

		// Token: 0x04002956 RID: 10582
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002957 RID: 10583
		private static int HandleId;
	}
}
