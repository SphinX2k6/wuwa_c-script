using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AF8 RID: 2808
	public class ConfigTrapDefenseBdById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060041E4 RID: 16868 RVA: 0x001D16A1 File Offset: 0x001CF8A1
		static ConfigTrapDefenseBdById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBdById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBdById.ResetStaticDefaultValue));
		}

		// Token: 0x060041E5 RID: 16869 RVA: 0x001D16C0 File Offset: 0x001CF8C0
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseBdById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseBdById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_增益.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseBd"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseBd` where Id=?")
			});
		}

		// Token: 0x060041E6 RID: 16870 RVA: 0x001D173F File Offset: 0x001CF93F
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBdById.LogPair = null;
			ConfigTrapDefenseBdById.HandleId = 0;
		}

		// Token: 0x060041E7 RID: 16871 RVA: 0x001D174D File Offset: 0x001CF94D
		public static void Init()
		{
			ConfigTrapDefenseBdById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBdById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBd` where Id=?");
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x001D1768 File Offset: 0x001CF968
		public static TrapDefenseBd? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseBdById.HandleId, ConfigTrapDefenseBdById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBdById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseBd?(TrapDefenseBd.GetRootAsTrapDefenseBd(configBuffer));
				}
			}
			ConfigTrapDefenseBdById.LogPair.Clear();
			ConfigTrapDefenseBdById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseBdById.HandleId, 1, p0Id, ConfigTrapDefenseBdById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseBdById.HandleId, true, ConfigTrapDefenseBdById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseBdById.HandleId, ConfigTrapDefenseBdById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseBdById.HandleId, 0, ConfigTrapDefenseBdById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseBdById.HandleId, ConfigTrapDefenseBdById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseBd rootAsTrapDefenseBd = TrapDefenseBd.GetRootAsTrapDefenseBd(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBdById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseBdById.HandleId, ConfigTrapDefenseBdById.LogPair);
			return new TrapDefenseBd?(rootAsTrapDefenseBd);
		}

		// Token: 0x04004CAE RID: 19630
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004CAF RID: 19631
		private const string FILE = "x.陷阱塔防活动_增益.xlsx";

		// Token: 0x04004CB0 RID: 19632
		private const string TABLE = "TrapDefenseBd";

		// Token: 0x04004CB1 RID: 19633
		private const string COMMAND = "select BinData from `TrapDefenseBd` where Id=?";

		// Token: 0x04004CB2 RID: 19634
		private const string KEY_PREFIX = "TrapDefenseBdById";

		// Token: 0x04004CB3 RID: 19635
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004CB4 RID: 19636
		private static int HandleId;
	}
}
