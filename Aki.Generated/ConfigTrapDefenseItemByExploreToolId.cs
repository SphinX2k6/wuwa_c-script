using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B04 RID: 2820
	public class ConfigTrapDefenseItemByExploreToolId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600422C RID: 16940 RVA: 0x001D2FD3 File Offset: 0x001D11D3
		static ConfigTrapDefenseItemByExploreToolId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseItemByExploreToolId.CreateStaticDefaultValue), new Action(ConfigTrapDefenseItemByExploreToolId.ResetStaticDefaultValue));
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x001D2FF4 File Offset: 0x001D11F4
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseItemByExploreToolId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseItemByExploreToolId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_商店.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseItem"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseItem` where ExploreToolId=?")
			});
		}

		// Token: 0x0600422E RID: 16942 RVA: 0x001D3073 File Offset: 0x001D1273
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseItemByExploreToolId.LogPair = null;
			ConfigTrapDefenseItemByExploreToolId.HandleId = 0;
		}

		// Token: 0x0600422F RID: 16943 RVA: 0x001D3081 File Offset: 0x001D1281
		public static void Init()
		{
			ConfigTrapDefenseItemByExploreToolId.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseItemByExploreToolId.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseItem` where ExploreToolId=?");
		}

		// Token: 0x06004230 RID: 16944 RVA: 0x001D309C File Offset: 0x001D129C
		public static TrapDefenseItem? GetConfig(int p0ExploreToolId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseItemByExploreToolId.HandleId, ConfigTrapDefenseItemByExploreToolId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseItemByExploreToolId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ExploreToolId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseItem?(TrapDefenseItem.GetRootAsTrapDefenseItem(configBuffer));
				}
			}
			ConfigTrapDefenseItemByExploreToolId.LogPair.Clear();
			ConfigTrapDefenseItemByExploreToolId.LogPair.Add(new ValueTuple<string, object>("ExploreToolId", p0ExploreToolId));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseItemByExploreToolId.HandleId, 1, p0ExploreToolId, ConfigTrapDefenseItemByExploreToolId.LogPair) || ConfigCommon.Step(ConfigTrapDefenseItemByExploreToolId.HandleId, true, ConfigTrapDefenseItemByExploreToolId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseItemByExploreToolId.HandleId, ConfigTrapDefenseItemByExploreToolId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseItemByExploreToolId.HandleId, 0, ConfigTrapDefenseItemByExploreToolId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseItemByExploreToolId.HandleId, ConfigTrapDefenseItemByExploreToolId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseItem rootAsTrapDefenseItem = TrapDefenseItem.GetRootAsTrapDefenseItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseItemByExploreToolId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ExploreToolId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseItemByExploreToolId.HandleId, ConfigTrapDefenseItemByExploreToolId.LogPair);
			return new TrapDefenseItem?(rootAsTrapDefenseItem);
		}

		// Token: 0x04004D02 RID: 19714
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D03 RID: 19715
		private const string FILE = "x.陷阱塔防活动_商店.xlsx";

		// Token: 0x04004D04 RID: 19716
		private const string TABLE = "TrapDefenseItem";

		// Token: 0x04004D05 RID: 19717
		private const string COMMAND = "select BinData from `TrapDefenseItem` where ExploreToolId=?";

		// Token: 0x04004D06 RID: 19718
		private const string KEY_PREFIX = "TrapDefenseItemByExploreToolId";

		// Token: 0x04004D07 RID: 19719
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D08 RID: 19720
		private static int HandleId;
	}
}
