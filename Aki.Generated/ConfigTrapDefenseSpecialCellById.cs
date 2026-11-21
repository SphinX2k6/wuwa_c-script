using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B15 RID: 2837
	public class ConfigTrapDefenseSpecialCellById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004292 RID: 17042 RVA: 0x001D52F7 File Offset: 0x001D34F7
		static ConfigTrapDefenseSpecialCellById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseSpecialCellById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseSpecialCellById.ResetStaticDefaultValue));
		}

		// Token: 0x06004293 RID: 17043 RVA: 0x001D5318 File Offset: 0x001D3518
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

		// Token: 0x06004294 RID: 17044 RVA: 0x001D5397 File Offset: 0x001D3597
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseSpecialCellById.LogPair = null;
			ConfigTrapDefenseSpecialCellById.HandleId = 0;
		}

		// Token: 0x06004295 RID: 17045 RVA: 0x001D53A5 File Offset: 0x001D35A5
		public static void Init()
		{
			ConfigTrapDefenseSpecialCellById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseSpecialCellById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseSpecialCell` where Id=?");
		}

		// Token: 0x06004296 RID: 17046 RVA: 0x001D53C0 File Offset: 0x001D35C0
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

		// Token: 0x04004D79 RID: 19833
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D7A RID: 19834
		private const string FILE = "x.陷阱塔防活动_特殊地块.xlsx";

		// Token: 0x04004D7B RID: 19835
		private const string TABLE = "TrapDefenseSpecialCell";

		// Token: 0x04004D7C RID: 19836
		private const string COMMAND = "select BinData from `TrapDefenseSpecialCell` where Id=?";

		// Token: 0x04004D7D RID: 19837
		private const string KEY_PREFIX = "TrapDefenseSpecialCellById";

		// Token: 0x04004D7E RID: 19838
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D7F RID: 19839
		private static int HandleId;
	}
}
