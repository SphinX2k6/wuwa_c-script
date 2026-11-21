using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000E0 RID: 224
	public class ConfigBabelTowerDeTermById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000541 RID: 1345 RVA: 0x0007AF27 File Offset: 0x00079127
		static ConfigBabelTowerDeTermById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerDeTermById.CreateStaticDefaultValue), new Action(ConfigBabelTowerDeTermById.ResetStaticDefaultValue));
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0007AF48 File Offset: 0x00079148
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerDeTermById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerDeTermById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerDeTerm"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerDeTerm` where Id=?")
			});
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0007AFC7 File Offset: 0x000791C7
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerDeTermById.LogPair = null;
			ConfigBabelTowerDeTermById.HandleId = 0;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0007AFD5 File Offset: 0x000791D5
		public static void Init()
		{
			ConfigBabelTowerDeTermById.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerDeTermById.HandleId, "db_babeltower.db", "select BinData from `BabelTowerDeTerm` where Id=?");
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0007AFF0 File Offset: 0x000791F0
		public static BabelTowerDeTerm? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerDeTermById.HandleId, ConfigBabelTowerDeTermById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerDeTermById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BabelTowerDeTerm?(BabelTowerDeTerm.GetRootAsBabelTowerDeTerm(configBuffer));
				}
			}
			ConfigBabelTowerDeTermById.LogPair.Clear();
			ConfigBabelTowerDeTermById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBabelTowerDeTermById.HandleId, 1, p0Id, ConfigBabelTowerDeTermById.LogPair) || ConfigCommon.Step(ConfigBabelTowerDeTermById.HandleId, true, ConfigBabelTowerDeTermById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBabelTowerDeTermById.HandleId, ConfigBabelTowerDeTermById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerDeTermById.HandleId, 0, ConfigBabelTowerDeTermById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBabelTowerDeTermById.HandleId, ConfigBabelTowerDeTermById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BabelTowerDeTerm rootAsBabelTowerDeTerm = BabelTowerDeTerm.GetRootAsBabelTowerDeTerm(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerDeTermById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBabelTowerDeTermById.HandleId, ConfigBabelTowerDeTermById.LogPair);
			return new BabelTowerDeTerm?(rootAsBabelTowerDeTerm);
		}

		// Token: 0x04000604 RID: 1540
		private const string DB = "db_babeltower.db";

		// Token: 0x04000605 RID: 1541
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x04000606 RID: 1542
		private const string TABLE = "BabelTowerDeTerm";

		// Token: 0x04000607 RID: 1543
		private const string COMMAND = "select BinData from `BabelTowerDeTerm` where Id=?";

		// Token: 0x04000608 RID: 1544
		private const string KEY_PREFIX = "BabelTowerDeTermById";

		// Token: 0x04000609 RID: 1545
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400060A RID: 1546
		private static int HandleId;
	}
}
