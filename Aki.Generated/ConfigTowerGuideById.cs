using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AD7 RID: 2775
	public class ConfigTowerGuideById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600411E RID: 16670 RVA: 0x001CCF28 File Offset: 0x001CB128
		static ConfigTowerGuideById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerGuideById.CreateStaticDefaultValue), new Action(ConfigTowerGuideById.ResetStaticDefaultValue));
		}

		// Token: 0x0600411F RID: 16671 RVA: 0x001CCF48 File Offset: 0x001CB148
		public static void CreateStaticDefaultValue()
		{
			ConfigTowerGuideById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTowerGuideById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_towerguide.db"),
				new ValueTuple<string, object>("文件", "p.爬塔引导活动.xlsx"),
				new ValueTuple<string, object>("表名", "TowerGuide"),
				new ValueTuple<string, object>("语句", "select BinData from `TowerGuide` where Id = ?")
			});
		}

		// Token: 0x06004120 RID: 16672 RVA: 0x001CCFC7 File Offset: 0x001CB1C7
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerGuideById.LogPair = null;
			ConfigTowerGuideById.HandleId = 0;
		}

		// Token: 0x06004121 RID: 16673 RVA: 0x001CCFD5 File Offset: 0x001CB1D5
		public static void Init()
		{
			ConfigTowerGuideById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerGuideById.HandleId, "db_towerguide.db", "select BinData from `TowerGuide` where Id = ?");
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x001CCFF0 File Offset: 0x001CB1F0
		public static TowerGuide? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTowerGuideById.HandleId, ConfigTowerGuideById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerGuideById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TowerGuide?(TowerGuide.GetRootAsTowerGuide(configBuffer));
				}
			}
			ConfigTowerGuideById.LogPair.Clear();
			ConfigTowerGuideById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTowerGuideById.HandleId, 1, p0Id, ConfigTowerGuideById.LogPair) || ConfigCommon.Step(ConfigTowerGuideById.HandleId, true, ConfigTowerGuideById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTowerGuideById.HandleId, ConfigTowerGuideById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTowerGuideById.HandleId, 0, ConfigTowerGuideById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTowerGuideById.HandleId, ConfigTowerGuideById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TowerGuide rootAsTowerGuide = TowerGuide.GetRootAsTowerGuide(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TowerGuideById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTowerGuideById.HandleId, ConfigTowerGuideById.LogPair);
			return new TowerGuide?(rootAsTowerGuide);
		}

		// Token: 0x04004BC7 RID: 19399
		private const string DB = "db_towerguide.db";

		// Token: 0x04004BC8 RID: 19400
		private const string FILE = "p.爬塔引导活动.xlsx";

		// Token: 0x04004BC9 RID: 19401
		private const string TABLE = "TowerGuide";

		// Token: 0x04004BCA RID: 19402
		private const string COMMAND = "select BinData from `TowerGuide` where Id = ?";

		// Token: 0x04004BCB RID: 19403
		private const string KEY_PREFIX = "TowerGuideById";

		// Token: 0x04004BCC RID: 19404
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004BCD RID: 19405
		private static int HandleId;
	}
}
