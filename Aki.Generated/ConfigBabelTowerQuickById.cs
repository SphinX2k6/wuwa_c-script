using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000E9 RID: 233
	public class ConfigBabelTowerQuickById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000577 RID: 1399 RVA: 0x0007C1D7 File Offset: 0x0007A3D7
		static ConfigBabelTowerQuickById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerQuickById.CreateStaticDefaultValue), new Action(ConfigBabelTowerQuickById.ResetStaticDefaultValue));
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0007C1F8 File Offset: 0x0007A3F8
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerQuickById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerQuickById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerQuick"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerQuick` where Id=?")
			});
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0007C277 File Offset: 0x0007A477
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerQuickById.LogPair = null;
			ConfigBabelTowerQuickById.HandleId = 0;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0007C285 File Offset: 0x0007A485
		public static void Init()
		{
			ConfigBabelTowerQuickById.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerQuickById.HandleId, "db_babeltower.db", "select BinData from `BabelTowerQuick` where Id=?");
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0007C2A0 File Offset: 0x0007A4A0
		public static BabelTowerQuick? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerQuickById.HandleId, ConfigBabelTowerQuickById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerQuickById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BabelTowerQuick?(BabelTowerQuick.GetRootAsBabelTowerQuick(configBuffer));
				}
			}
			ConfigBabelTowerQuickById.LogPair.Clear();
			ConfigBabelTowerQuickById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBabelTowerQuickById.HandleId, 1, p0Id, ConfigBabelTowerQuickById.LogPair) || ConfigCommon.Step(ConfigBabelTowerQuickById.HandleId, true, ConfigBabelTowerQuickById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBabelTowerQuickById.HandleId, ConfigBabelTowerQuickById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerQuickById.HandleId, 0, ConfigBabelTowerQuickById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBabelTowerQuickById.HandleId, ConfigBabelTowerQuickById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BabelTowerQuick rootAsBabelTowerQuick = BabelTowerQuick.GetRootAsBabelTowerQuick(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerQuickById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBabelTowerQuickById.HandleId, ConfigBabelTowerQuickById.LogPair);
			return new BabelTowerQuick?(rootAsBabelTowerQuick);
		}

		// Token: 0x04000643 RID: 1603
		private const string DB = "db_babeltower.db";

		// Token: 0x04000644 RID: 1604
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x04000645 RID: 1605
		private const string TABLE = "BabelTowerQuick";

		// Token: 0x04000646 RID: 1606
		private const string COMMAND = "select BinData from `BabelTowerQuick` where Id=?";

		// Token: 0x04000647 RID: 1607
		private const string KEY_PREFIX = "BabelTowerQuickById";

		// Token: 0x04000648 RID: 1608
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000649 RID: 1609
		private static int HandleId;
	}
}
