using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AEE RID: 2798
	public class ConfigTrapDefenseAttributeShowById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060041A8 RID: 16808 RVA: 0x001D00F4 File Offset: 0x001CE2F4
		static ConfigTrapDefenseAttributeShowById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseAttributeShowById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseAttributeShowById.ResetStaticDefaultValue));
		}

		// Token: 0x060041A9 RID: 16809 RVA: 0x001D0114 File Offset: 0x001CE314
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseAttributeShowById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseAttributeShowById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_机关.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseAttributeShow"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseAttributeShow` where Id=?")
			});
		}

		// Token: 0x060041AA RID: 16810 RVA: 0x001D0193 File Offset: 0x001CE393
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseAttributeShowById.LogPair = null;
			ConfigTrapDefenseAttributeShowById.HandleId = 0;
		}

		// Token: 0x060041AB RID: 16811 RVA: 0x001D01A1 File Offset: 0x001CE3A1
		public static void Init()
		{
			ConfigTrapDefenseAttributeShowById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseAttributeShowById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseAttributeShow` where Id=?");
		}

		// Token: 0x060041AC RID: 16812 RVA: 0x001D01BC File Offset: 0x001CE3BC
		public static TrapDefenseAttributeShow? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseAttributeShowById.HandleId, ConfigTrapDefenseAttributeShowById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseAttributeShowById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseAttributeShow?(TrapDefenseAttributeShow.GetRootAsTrapDefenseAttributeShow(configBuffer));
				}
			}
			ConfigTrapDefenseAttributeShowById.LogPair.Clear();
			ConfigTrapDefenseAttributeShowById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseAttributeShowById.HandleId, 1, p0Id, ConfigTrapDefenseAttributeShowById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseAttributeShowById.HandleId, true, ConfigTrapDefenseAttributeShowById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseAttributeShowById.HandleId, ConfigTrapDefenseAttributeShowById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseAttributeShowById.HandleId, 0, ConfigTrapDefenseAttributeShowById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseAttributeShowById.HandleId, ConfigTrapDefenseAttributeShowById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseAttributeShow rootAsTrapDefenseAttributeShow = TrapDefenseAttributeShow.GetRootAsTrapDefenseAttributeShow(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseAttributeShowById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseAttributeShowById.HandleId, ConfigTrapDefenseAttributeShowById.LogPair);
			return new TrapDefenseAttributeShow?(rootAsTrapDefenseAttributeShow);
		}

		// Token: 0x04004C68 RID: 19560
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004C69 RID: 19561
		private const string FILE = "x.陷阱塔防活动_机关.xlsx";

		// Token: 0x04004C6A RID: 19562
		private const string TABLE = "TrapDefenseAttributeShow";

		// Token: 0x04004C6B RID: 19563
		private const string COMMAND = "select BinData from `TrapDefenseAttributeShow` where Id=?";

		// Token: 0x04004C6C RID: 19564
		private const string KEY_PREFIX = "TrapDefenseAttributeShowById";

		// Token: 0x04004C6D RID: 19565
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C6E RID: 19566
		private static int HandleId;
	}
}
