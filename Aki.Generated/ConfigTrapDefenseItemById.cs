using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A30 RID: 2608
	public class ConfigTrapDefenseItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D34 RID: 15668 RVA: 0x001B3E88 File Offset: 0x001B2088
		static ConfigTrapDefenseItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseItemById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x001B3EA8 File Offset: 0x001B20A8
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

		// Token: 0x06003D36 RID: 15670 RVA: 0x001B3F27 File Offset: 0x001B2127
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseItemById.LogPair = null;
			ConfigTrapDefenseItemById.HandleId = 0;
		}

		// Token: 0x06003D37 RID: 15671 RVA: 0x001B3F35 File Offset: 0x001B2135
		public static void Init()
		{
			ConfigTrapDefenseItemById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseItemById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseItem` where Id=?");
		}

		// Token: 0x06003D38 RID: 15672 RVA: 0x001B3F50 File Offset: 0x001B2150
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

		// Token: 0x04004736 RID: 18230
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004737 RID: 18231
		private const string FILE = "x.陷阱塔防活动_商店.xlsx";

		// Token: 0x04004738 RID: 18232
		private const string TABLE = "TrapDefenseItem";

		// Token: 0x04004739 RID: 18233
		private const string COMMAND = "select BinData from `TrapDefenseItem` where Id=?";

		// Token: 0x0400473A RID: 18234
		private const string KEY_PREFIX = "TrapDefenseItemById";

		// Token: 0x0400473B RID: 18235
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400473C RID: 18236
		private static int HandleId;
	}
}
