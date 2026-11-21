using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B16 RID: 2838
	public class ConfigTrapDefenseSpecialCellTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004298 RID: 17048 RVA: 0x001D5540 File Offset: 0x001D3740
		static ConfigTrapDefenseSpecialCellTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseSpecialCellTypeById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseSpecialCellTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06004299 RID: 17049 RVA: 0x001D5560 File Offset: 0x001D3760
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseSpecialCellTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseSpecialCellTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_特殊地块.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseSpecialCellType"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseSpecialCellType` where Id=?")
			});
		}

		// Token: 0x0600429A RID: 17050 RVA: 0x001D55DF File Offset: 0x001D37DF
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseSpecialCellTypeById.LogPair = null;
			ConfigTrapDefenseSpecialCellTypeById.HandleId = 0;
		}

		// Token: 0x0600429B RID: 17051 RVA: 0x001D55ED File Offset: 0x001D37ED
		public static void Init()
		{
			ConfigTrapDefenseSpecialCellTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseSpecialCellTypeById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseSpecialCellType` where Id=?");
		}

		// Token: 0x0600429C RID: 17052 RVA: 0x001D5608 File Offset: 0x001D3808
		public static TrapDefenseSpecialCellType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseSpecialCellTypeById.HandleId, ConfigTrapDefenseSpecialCellTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseSpecialCellTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseSpecialCellType?(TrapDefenseSpecialCellType.GetRootAsTrapDefenseSpecialCellType(configBuffer));
				}
			}
			ConfigTrapDefenseSpecialCellTypeById.LogPair.Clear();
			ConfigTrapDefenseSpecialCellTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseSpecialCellTypeById.HandleId, 1, p0Id, ConfigTrapDefenseSpecialCellTypeById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseSpecialCellTypeById.HandleId, true, ConfigTrapDefenseSpecialCellTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseSpecialCellTypeById.HandleId, ConfigTrapDefenseSpecialCellTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseSpecialCellTypeById.HandleId, 0, ConfigTrapDefenseSpecialCellTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseSpecialCellTypeById.HandleId, ConfigTrapDefenseSpecialCellTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseSpecialCellType rootAsTrapDefenseSpecialCellType = TrapDefenseSpecialCellType.GetRootAsTrapDefenseSpecialCellType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseSpecialCellTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseSpecialCellTypeById.HandleId, ConfigTrapDefenseSpecialCellTypeById.LogPair);
			return new TrapDefenseSpecialCellType?(rootAsTrapDefenseSpecialCellType);
		}

		// Token: 0x04004D80 RID: 19840
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D81 RID: 19841
		private const string FILE = "x.陷阱塔防活动_特殊地块.xlsx";

		// Token: 0x04004D82 RID: 19842
		private const string TABLE = "TrapDefenseSpecialCellType";

		// Token: 0x04004D83 RID: 19843
		private const string COMMAND = "select BinData from `TrapDefenseSpecialCellType` where Id=?";

		// Token: 0x04004D84 RID: 19844
		private const string KEY_PREFIX = "TrapDefenseSpecialCellTypeById";

		// Token: 0x04004D85 RID: 19845
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D86 RID: 19846
		private static int HandleId;
	}
}
