using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007EF RID: 2031
	public class ConfigRegressInvestigationByInvestigationTypeAndIfGlobal : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FAC RID: 12204 RVA: 0x0016A267 File Offset: 0x00168467
		static ConfigRegressInvestigationByInvestigationTypeAndIfGlobal()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.CreateStaticDefaultValue), new Action(ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.ResetStaticDefaultValue));
		}

		// Token: 0x06002FAD RID: 12205 RVA: 0x0016A288 File Offset: 0x00168488
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

		// Token: 0x06002FAE RID: 12206 RVA: 0x0016A307 File Offset: 0x00168507
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.LogPair = null;
			ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.HandleId = 0;
		}

		// Token: 0x06002FAF RID: 12207 RVA: 0x0016A315 File Offset: 0x00168515
		public static void Init()
		{
			ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.HandleId = ConfigCommon.InitDataStatement(ConfigRegressInvestigationByInvestigationTypeAndIfGlobal.HandleId, "db_regressactivity.db", "select BinData from `RegressInvestigation` where InvestigationType=? And IfGlobal=?");
		}

		// Token: 0x06002FB0 RID: 12208 RVA: 0x0016A330 File Offset: 0x00168530
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

		// Token: 0x0400376F RID: 14191
		private const string DB = "db_regressactivity.db";

		// Token: 0x04003770 RID: 14192
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x04003771 RID: 14193
		private const string TABLE = "RegressInvestigation";

		// Token: 0x04003772 RID: 14194
		private const string COMMAND = "select BinData from `RegressInvestigation` where InvestigationType=? And IfGlobal=?";

		// Token: 0x04003773 RID: 14195
		private const string KEY_PREFIX = "RegressInvestigationByInvestigationTypeAndIfGlobal";

		// Token: 0x04003774 RID: 14196
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003775 RID: 14197
		private static int HandleId;
	}
}
