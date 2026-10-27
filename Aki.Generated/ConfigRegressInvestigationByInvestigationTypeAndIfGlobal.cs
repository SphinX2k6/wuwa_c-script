using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007D3 RID: 2003
	public class ConfigRegressInvestigationByInvestigationTypeAndIfGlobal : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F04 RID: 12036 RVA: 0x00162F7F File Offset: 0x0016117F
		static ConfigRegressInvestigationByInvestigationTypeAndIfGlobal()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.CreateStaticDefaultValue), new Action(ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.ResetStaticDefaultValue));
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x00162FA0 File Offset: 0x001611A0
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressInvestigation"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressInvestigation` where InvestigationType=? And IfGlobal=?")
			});
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x0016301F File Offset: 0x0016121F
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.LogPair = null;
			ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.HandleId = 0;
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x0016302D File Offset: 0x0016122D
		public static void Init()
		{
			ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.HandleId = ConfigCommon.InitDataStatement(ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.HandleId, "db_regressactivity.db", "select BinData from `RegressInvestigation` where InvestigationType=? And IfGlobal=?");
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x00163048 File Offset: 0x00161248
		public static RegressInvestigation? GetConfig(int p0InvestigationType, bool p1IfGlobal, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.HandleId, ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RegressInvestigationByInvestigationTypeAndIfGlobal");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InvestigationType);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(p1IfGlobal);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RegressInvestigation?(RegressInvestigation.GetRootAsRegressInvestigation(configBuffer));
				}
			}
			ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.LogPair.Clear();
			ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.LogPair.Add(new ValueTuple<string, object>("InvestigationType", p0InvestigationType));
			ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.LogPair.Add(new ValueTuple<string, object>("IfGlobal", p1IfGlobal));
			if (!ConfigCommon.BindInt(ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.HandleId, 1, p0InvestigationType, ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.LogPair) || !ConfigCommon.BindBool(ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.HandleId, 2, p1IfGlobal, ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.LogPair) || ConfigCommon.Step(ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.HandleId, true, ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.HandleId, ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.HandleId, 0, ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.HandleId, ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RegressInvestigation rootAsRegressInvestigation = RegressInvestigation.GetRootAsRegressInvestigation(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RegressInvestigationByInvestigationTypeAndIfGlobal");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InvestigationType);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(p1IfGlobal);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.HandleId, ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.LogPair);
			return new RegressInvestigation?(rootAsRegressInvestigation);
		}

		// Token: 0x040036AB RID: 13995
		private const string DB = "db_regressactivity.db";

		// Token: 0x040036AC RID: 13996
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x040036AD RID: 13997
		private const string TABLE = "RegressInvestigation";

		// Token: 0x040036AE RID: 13998
		private const string COMMAND = "select BinData from `RegressInvestigation` where InvestigationType=? And IfGlobal=?";

		// Token: 0x040036AF RID: 13999
		private const string KEY_PREFIX = "RegressInvestigationByInvestigationTypeAndIfGlobal";

		// Token: 0x040036B0 RID: 14000
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036B1 RID: 14001
		private static int HandleId;
	}
}
