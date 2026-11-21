using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AEF RID: 2799
	public class ConfigTrapDefenseAuxiliaryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060041AE RID: 16814 RVA: 0x001D033C File Offset: 0x001CE53C
		static ConfigTrapDefenseAuxiliaryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseAuxiliaryById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseAuxiliaryById.ResetStaticDefaultValue));
		}

		// Token: 0x060041AF RID: 16815 RVA: 0x001D035C File Offset: 0x001CE55C
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

		// Token: 0x060041B0 RID: 16816 RVA: 0x001D03DB File Offset: 0x001CE5DB
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseAuxiliaryById.LogPair = null;
			ConfigTrapDefenseAuxiliaryById.HandleId = 0;
		}

		// Token: 0x060041B1 RID: 16817 RVA: 0x001D03E9 File Offset: 0x001CE5E9
		public static void Init()
		{
			ConfigTrapDefenseAuxiliaryById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseAuxiliaryById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseAuxiliary` where Id=?");
		}

		// Token: 0x060041B2 RID: 16818 RVA: 0x001D0404 File Offset: 0x001CE604
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

		// Token: 0x04004C6F RID: 19567
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004C70 RID: 19568
		private const string FILE = "x.陷阱塔防活动_机关.xlsx";

		// Token: 0x04004C71 RID: 19569
		private const string TABLE = "TrapDefenseAuxiliary";

		// Token: 0x04004C72 RID: 19570
		private const string COMMAND = "select BinData from `TrapDefenseAuxiliary` where Id=?";

		// Token: 0x04004C73 RID: 19571
		private const string KEY_PREFIX = "TrapDefenseAuxiliaryById";

		// Token: 0x04004C74 RID: 19572
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C75 RID: 19573
		private static int HandleId;
	}
}
