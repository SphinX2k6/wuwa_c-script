using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B05 RID: 2821
	public class ConfigTrapDefenseItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004232 RID: 16946 RVA: 0x001D321C File Offset: 0x001D141C
		static ConfigTrapDefenseItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseItemById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06004233 RID: 16947 RVA: 0x001D323C File Offset: 0x001D143C
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_商店.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseItem"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseItem` where Id=?")
			});
		}

		// Token: 0x06004234 RID: 16948 RVA: 0x001D32BB File Offset: 0x001D14BB
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseItemById.LogPair = null;
			ConfigTrapDefenseItemById.HandleId = 0;
		}

		// Token: 0x06004235 RID: 16949 RVA: 0x001D32C9 File Offset: 0x001D14C9
		public static void Init()
		{
			ConfigTrapDefenseItemById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseItemById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseItem` where Id=?");
		}

		// Token: 0x06004236 RID: 16950 RVA: 0x001D32E4 File Offset: 0x001D14E4
		public static TrapDefenseItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseItemById.HandleId, ConfigTrapDefenseItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseItem?(TrapDefenseItem.GetRootAsTrapDefenseItem(configBuffer));
				}
			}
			ConfigTrapDefenseItemById.LogPair.Clear();
			ConfigTrapDefenseItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseItemById.HandleId, 1, p0Id, ConfigTrapDefenseItemById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseItemById.HandleId, true, ConfigTrapDefenseItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseItemById.HandleId, ConfigTrapDefenseItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseItemById.HandleId, 0, ConfigTrapDefenseItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseItemById.HandleId, ConfigTrapDefenseItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseItem rootAsTrapDefenseItem = TrapDefenseItem.GetRootAsTrapDefenseItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseItemById.HandleId, ConfigTrapDefenseItemById.LogPair);
			return new TrapDefenseItem?(rootAsTrapDefenseItem);
		}

		// Token: 0x04004D09 RID: 19721
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D0A RID: 19722
		private const string FILE = "x.陷阱塔防活动_商店.xlsx";

		// Token: 0x04004D0B RID: 19723
		private const string TABLE = "TrapDefenseItem";

		// Token: 0x04004D0C RID: 19724
		private const string COMMAND = "select BinData from `TrapDefenseItem` where Id=?";

		// Token: 0x04004D0D RID: 19725
		private const string KEY_PREFIX = "TrapDefenseItemById";

		// Token: 0x04004D0E RID: 19726
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D0F RID: 19727
		private static int HandleId;
	}
}
