using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A02 RID: 2562
	public class ConfigTowerGuideById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C20 RID: 15392 RVA: 0x001ADB94 File Offset: 0x001ABD94
		static ConfigTowerGuideById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTowerGuideById.CreateStaticDefaultValue), new Action(ConfigTowerGuideById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x001ADBB4 File Offset: 0x001ABDB4
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

		// Token: 0x06003C22 RID: 15394 RVA: 0x001ADC33 File Offset: 0x001ABE33
		public static void ResetStaticDefaultValue()
		{
			ConfigTowerGuideById.LogPair = null;
			ConfigTowerGuideById.HandleId = 0;
		}

		// Token: 0x06003C23 RID: 15395 RVA: 0x001ADC41 File Offset: 0x001ABE41
		public static void Init()
		{
			ConfigTowerGuideById.HandleId = ConfigCommon.InitDataStatement(ConfigTowerGuideById.HandleId, "db_towerguide.db", "select BinData from `TowerGuide` where Id = ?");
		}

		// Token: 0x06003C24 RID: 15396 RVA: 0x001ADC5C File Offset: 0x001ABE5C
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

		// Token: 0x040045F4 RID: 17908
		private const string DB = "db_towerguide.db";

		// Token: 0x040045F5 RID: 17909
		private const string FILE = "p.爬塔引导活动.xlsx";

		// Token: 0x040045F6 RID: 17910
		private const string TABLE = "TowerGuide";

		// Token: 0x040045F7 RID: 17911
		private const string COMMAND = "select BinData from `TowerGuide` where Id = ?";

		// Token: 0x040045F8 RID: 17912
		private const string KEY_PREFIX = "TowerGuideById";

		// Token: 0x040045F9 RID: 17913
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045FA RID: 17914
		private static int HandleId;
	}
}
