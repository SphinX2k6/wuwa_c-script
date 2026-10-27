using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A40 RID: 2624
	public class ConfigTrapDefenseSpecialCellById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D94 RID: 15764 RVA: 0x001B5F63 File Offset: 0x001B4163
		static ConfigTrapDefenseSpecialCellById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseSpecialCellById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseSpecialCellById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D95 RID: 15765 RVA: 0x001B5F84 File Offset: 0x001B4184
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseSpecialCellById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseSpecialCellById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_特殊地块.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseSpecialCell"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseSpecialCell` where Id=?")
			});
		}

		// Token: 0x06003D96 RID: 15766 RVA: 0x001B6003 File Offset: 0x001B4203
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseSpecialCellById.LogPair = null;
			ConfigTrapDefenseSpecialCellById.HandleId = 0;
		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x001B6011 File Offset: 0x001B4211
		public static void Init()
		{
			ConfigTrapDefenseSpecialCellById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseSpecialCellById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseSpecialCell` where Id=?");
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x001B602C File Offset: 0x001B422C
		public static TrapDefenseSpecialCell? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseSpecialCellById.HandleId, ConfigTrapDefenseSpecialCellById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseSpecialCellById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseSpecialCell?(TrapDefenseSpecialCell.GetRootAsTrapDefenseSpecialCell(configBuffer));
				}
			}
			ConfigTrapDefenseSpecialCellById.LogPair.Clear();
			ConfigTrapDefenseSpecialCellById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseSpecialCellById.HandleId, 1, p0Id, ConfigTrapDefenseSpecialCellById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseSpecialCellById.HandleId, true, ConfigTrapDefenseSpecialCellById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseSpecialCellById.HandleId, ConfigTrapDefenseSpecialCellById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseSpecialCellById.HandleId, 0, ConfigTrapDefenseSpecialCellById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseSpecialCellById.HandleId, ConfigTrapDefenseSpecialCellById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseSpecialCell rootAsTrapDefenseSpecialCell = TrapDefenseSpecialCell.GetRootAsTrapDefenseSpecialCell(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseSpecialCellById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseSpecialCellById.HandleId, ConfigTrapDefenseSpecialCellById.LogPair);
			return new TrapDefenseSpecialCell?(rootAsTrapDefenseSpecialCell);
		}

		// Token: 0x040047A6 RID: 18342
		private const string DB = "db_trapdefense.db";

		// Token: 0x040047A7 RID: 18343
		private const string FILE = "x.陷阱塔防活动_特殊地块.xlsx";

		// Token: 0x040047A8 RID: 18344
		private const string TABLE = "TrapDefenseSpecialCell";

		// Token: 0x040047A9 RID: 18345
		private const string COMMAND = "select BinData from `TrapDefenseSpecialCell` where Id=?";

		// Token: 0x040047AA RID: 18346
		private const string KEY_PREFIX = "TrapDefenseSpecialCellById";

		// Token: 0x040047AB RID: 18347
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047AC RID: 18348
		private static int HandleId;
	}
}
