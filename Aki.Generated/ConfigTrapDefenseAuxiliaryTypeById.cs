using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A1C RID: 2588
	public class ConfigTrapDefenseAuxiliaryTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CBC RID: 15548 RVA: 0x001B1383 File Offset: 0x001AF583
		static ConfigTrapDefenseAuxiliaryTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseAuxiliaryTypeById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseAuxiliaryTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003CBD RID: 15549 RVA: 0x001B13A4 File Offset: 0x001AF5A4
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

		// Token: 0x06003CBE RID: 15550 RVA: 0x001B1423 File Offset: 0x001AF623
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseAuxiliaryTypeById.LogPair = null;
			ConfigTrapDefenseAuxiliaryTypeById.HandleId = 0;
		}

		// Token: 0x06003CBF RID: 15551 RVA: 0x001B1431 File Offset: 0x001AF631
		public static void Init()
		{
			ConfigTrapDefenseAuxiliaryTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseAuxiliaryTypeById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseAuxiliaryType` where Id=?");
		}

		// Token: 0x06003CC0 RID: 15552 RVA: 0x001B144C File Offset: 0x001AF64C
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

		// Token: 0x040046AA RID: 18090
		private const string DB = "db_trapdefense.db";

		// Token: 0x040046AB RID: 18091
		private const string FILE = "x.陷阱塔防活动_机关.xlsx";

		// Token: 0x040046AC RID: 18092
		private const string TABLE = "TrapDefenseAuxiliaryType";

		// Token: 0x040046AD RID: 18093
		private const string COMMAND = "select BinData from `TrapDefenseAuxiliaryType` where Id=?";

		// Token: 0x040046AE RID: 18094
		private const string KEY_PREFIX = "TrapDefenseAuxiliaryTypeById";

		// Token: 0x040046AF RID: 18095
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046B0 RID: 18096
		private static int HandleId;
	}
}
