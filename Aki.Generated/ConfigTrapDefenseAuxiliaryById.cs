using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A1A RID: 2586
	public class ConfigTrapDefenseAuxiliaryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CB0 RID: 15536 RVA: 0x001B0FA8 File Offset: 0x001AF1A8
		static ConfigTrapDefenseAuxiliaryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseAuxiliaryById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseAuxiliaryById.ResetStaticDefaultValue));
		}

		// Token: 0x06003CB1 RID: 15537 RVA: 0x001B0FC8 File Offset: 0x001AF1C8
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseAuxiliaryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseAuxiliaryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_机关.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseAuxiliary"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseAuxiliary` where Id=?")
			});
		}

		// Token: 0x06003CB2 RID: 15538 RVA: 0x001B1047 File Offset: 0x001AF247
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseAuxiliaryById.LogPair = null;
			ConfigTrapDefenseAuxiliaryById.HandleId = 0;
		}

		// Token: 0x06003CB3 RID: 15539 RVA: 0x001B1055 File Offset: 0x001AF255
		public static void Init()
		{
			ConfigTrapDefenseAuxiliaryById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseAuxiliaryById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseAuxiliary` where Id=?");
		}

		// Token: 0x06003CB4 RID: 15540 RVA: 0x001B1070 File Offset: 0x001AF270
		public static TrapDefenseAuxiliary? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseAuxiliaryById.HandleId, ConfigTrapDefenseAuxiliaryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseAuxiliaryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseAuxiliary?(TrapDefenseAuxiliary.GetRootAsTrapDefenseAuxiliary(configBuffer));
				}
			}
			ConfigTrapDefenseAuxiliaryById.LogPair.Clear();
			ConfigTrapDefenseAuxiliaryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseAuxiliaryById.HandleId, 1, p0Id, ConfigTrapDefenseAuxiliaryById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseAuxiliaryById.HandleId, true, ConfigTrapDefenseAuxiliaryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseAuxiliaryById.HandleId, ConfigTrapDefenseAuxiliaryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseAuxiliaryById.HandleId, 0, ConfigTrapDefenseAuxiliaryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseAuxiliaryById.HandleId, ConfigTrapDefenseAuxiliaryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseAuxiliary rootAsTrapDefenseAuxiliary = TrapDefenseAuxiliary.GetRootAsTrapDefenseAuxiliary(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseAuxiliaryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseAuxiliaryById.HandleId, ConfigTrapDefenseAuxiliaryById.LogPair);
			return new TrapDefenseAuxiliary?(rootAsTrapDefenseAuxiliary);
		}

		// Token: 0x0400469C RID: 18076
		private const string DB = "db_trapdefense.db";

		// Token: 0x0400469D RID: 18077
		private const string FILE = "x.陷阱塔防活动_机关.xlsx";

		// Token: 0x0400469E RID: 18078
		private const string TABLE = "TrapDefenseAuxiliary";

		// Token: 0x0400469F RID: 18079
		private const string COMMAND = "select BinData from `TrapDefenseAuxiliary` where Id=?";

		// Token: 0x040046A0 RID: 18080
		private const string KEY_PREFIX = "TrapDefenseAuxiliaryById";

		// Token: 0x040046A1 RID: 18081
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046A2 RID: 18082
		private static int HandleId;
	}
}
