using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A19 RID: 2585
	public class ConfigTrapDefenseAttributeShowById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CAA RID: 15530 RVA: 0x001B0D60 File Offset: 0x001AEF60
		static ConfigTrapDefenseAttributeShowById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseAttributeShowById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseAttributeShowById.ResetStaticDefaultValue));
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x001B0D80 File Offset: 0x001AEF80
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

		// Token: 0x06003CAC RID: 15532 RVA: 0x001B0DFF File Offset: 0x001AEFFF
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseAttributeShowById.LogPair = null;
			ConfigTrapDefenseAttributeShowById.HandleId = 0;
		}

		// Token: 0x06003CAD RID: 15533 RVA: 0x001B0E0D File Offset: 0x001AF00D
		public static void Init()
		{
			ConfigTrapDefenseAttributeShowById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseAttributeShowById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseAttributeShow` where Id=?");
		}

		// Token: 0x06003CAE RID: 15534 RVA: 0x001B0E28 File Offset: 0x001AF028
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

		// Token: 0x04004695 RID: 18069
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004696 RID: 18070
		private const string FILE = "x.陷阱塔防活动_机关.xlsx";

		// Token: 0x04004697 RID: 18071
		private const string TABLE = "TrapDefenseAttributeShow";

		// Token: 0x04004698 RID: 18072
		private const string COMMAND = "select BinData from `TrapDefenseAttributeShow` where Id=?";

		// Token: 0x04004699 RID: 18073
		private const string KEY_PREFIX = "TrapDefenseAttributeShowById";

		// Token: 0x0400469A RID: 18074
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400469B RID: 18075
		private static int HandleId;
	}
}
