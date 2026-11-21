using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AF1 RID: 2801
	public class ConfigTrapDefenseAuxiliaryTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060041BA RID: 16826 RVA: 0x001D0717 File Offset: 0x001CE917
		static ConfigTrapDefenseAuxiliaryTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseAuxiliaryTypeById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseAuxiliaryTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060041BB RID: 16827 RVA: 0x001D0738 File Offset: 0x001CE938
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseAuxiliaryTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseAuxiliaryTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_机关.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseAuxiliaryType"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseAuxiliaryType` where Id=?")
			});
		}

		// Token: 0x060041BC RID: 16828 RVA: 0x001D07B7 File Offset: 0x001CE9B7
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseAuxiliaryTypeById.LogPair = null;
			ConfigTrapDefenseAuxiliaryTypeById.HandleId = 0;
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x001D07C5 File Offset: 0x001CE9C5
		public static void Init()
		{
			ConfigTrapDefenseAuxiliaryTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseAuxiliaryTypeById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseAuxiliaryType` where Id=?");
		}

		// Token: 0x060041BE RID: 16830 RVA: 0x001D07E0 File Offset: 0x001CE9E0
		public static TrapDefenseAuxiliaryType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseAuxiliaryTypeById.HandleId, ConfigTrapDefenseAuxiliaryTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseAuxiliaryTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseAuxiliaryType?(TrapDefenseAuxiliaryType.GetRootAsTrapDefenseAuxiliaryType(configBuffer));
				}
			}
			ConfigTrapDefenseAuxiliaryTypeById.LogPair.Clear();
			ConfigTrapDefenseAuxiliaryTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseAuxiliaryTypeById.HandleId, 1, p0Id, ConfigTrapDefenseAuxiliaryTypeById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseAuxiliaryTypeById.HandleId, true, ConfigTrapDefenseAuxiliaryTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseAuxiliaryTypeById.HandleId, ConfigTrapDefenseAuxiliaryTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseAuxiliaryTypeById.HandleId, 0, ConfigTrapDefenseAuxiliaryTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseAuxiliaryTypeById.HandleId, ConfigTrapDefenseAuxiliaryTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseAuxiliaryType rootAsTrapDefenseAuxiliaryType = TrapDefenseAuxiliaryType.GetRootAsTrapDefenseAuxiliaryType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseAuxiliaryTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseAuxiliaryTypeById.HandleId, ConfigTrapDefenseAuxiliaryTypeById.LogPair);
			return new TrapDefenseAuxiliaryType?(rootAsTrapDefenseAuxiliaryType);
		}

		// Token: 0x04004C7D RID: 19581
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004C7E RID: 19582
		private const string FILE = "x.陷阱塔防活动_机关.xlsx";

		// Token: 0x04004C7F RID: 19583
		private const string TABLE = "TrapDefenseAuxiliaryType";

		// Token: 0x04004C80 RID: 19584
		private const string COMMAND = "select BinData from `TrapDefenseAuxiliaryType` where Id=?";

		// Token: 0x04004C81 RID: 19585
		private const string KEY_PREFIX = "TrapDefenseAuxiliaryTypeById";

		// Token: 0x04004C82 RID: 19586
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C83 RID: 19587
		private static int HandleId;
	}
}
