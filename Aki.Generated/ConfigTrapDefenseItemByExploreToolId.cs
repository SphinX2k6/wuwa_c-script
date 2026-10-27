using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A2F RID: 2607
	public class ConfigTrapDefenseItemByExploreToolId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D2E RID: 15662 RVA: 0x001B3C3F File Offset: 0x001B1E3F
		static ConfigTrapDefenseItemByExploreToolId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseItemByExploreToolId.CreateStaticDefaultValue), new Action(ConfigTrapDefenseItemByExploreToolId.ResetStaticDefaultValue));
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x001B3C60 File Offset: 0x001B1E60
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

		// Token: 0x06003D30 RID: 15664 RVA: 0x001B3CDF File Offset: 0x001B1EDF
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseItemByExploreToolId.LogPair = null;
			ConfigTrapDefenseItemByExploreToolId.HandleId = 0;
		}

		// Token: 0x06003D31 RID: 15665 RVA: 0x001B3CED File Offset: 0x001B1EED
		public static void Init()
		{
			ConfigTrapDefenseItemByExploreToolId.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseItemByExploreToolId.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseItem` where ExploreToolId=?");
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x001B3D08 File Offset: 0x001B1F08
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

		// Token: 0x0400472F RID: 18223
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004730 RID: 18224
		private const string FILE = "x.陷阱塔防活动_商店.xlsx";

		// Token: 0x04004731 RID: 18225
		private const string TABLE = "TrapDefenseItem";

		// Token: 0x04004732 RID: 18226
		private const string COMMAND = "select BinData from `TrapDefenseItem` where ExploreToolId=?";

		// Token: 0x04004733 RID: 18227
		private const string KEY_PREFIX = "TrapDefenseItemByExploreToolId";

		// Token: 0x04004734 RID: 18228
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004735 RID: 18229
		private static int HandleId;
	}
}
