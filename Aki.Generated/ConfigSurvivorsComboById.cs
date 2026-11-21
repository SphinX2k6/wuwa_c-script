using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A6D RID: 2669
	public class ConfigSurvivorsComboById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EA2 RID: 16034 RVA: 0x001BEC0C File Offset: 0x001BCE0C
		static ConfigSurvivorsComboById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsComboById.CreateStaticDefaultValue), new Action(ConfigSurvivorsComboById.ResetStaticDefaultValue));
		}

		// Token: 0x06003EA3 RID: 16035 RVA: 0x001BEC2C File Offset: 0x001BCE2C
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsComboById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsComboById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsCombo"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsCombo` where Id=?")
			});
		}

		// Token: 0x06003EA4 RID: 16036 RVA: 0x001BECAB File Offset: 0x001BCEAB
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsComboById.LogPair = null;
			ConfigSurvivorsComboById.HandleId = 0;
		}

		// Token: 0x06003EA5 RID: 16037 RVA: 0x001BECB9 File Offset: 0x001BCEB9
		public static void Init()
		{
			ConfigSurvivorsComboById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsComboById.HandleId, "db_survivors.db", "select BinData from `SurvivorsCombo` where Id=?");
		}

		// Token: 0x06003EA6 RID: 16038 RVA: 0x001BECD4 File Offset: 0x001BCED4
		public static SurvivorsCombo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsComboById.HandleId, ConfigSurvivorsComboById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsComboById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsCombo?(SurvivorsCombo.GetRootAsSurvivorsCombo(configBuffer));
				}
			}
			ConfigSurvivorsComboById.LogPair.Clear();
			ConfigSurvivorsComboById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsComboById.HandleId, 1, p0Id, ConfigSurvivorsComboById.LogPair) || ConfigCommon.Step(ConfigSurvivorsComboById.HandleId, true, ConfigSurvivorsComboById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsComboById.HandleId, ConfigSurvivorsComboById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsComboById.HandleId, 0, ConfigSurvivorsComboById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsComboById.HandleId, ConfigSurvivorsComboById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsCombo rootAsSurvivorsCombo = SurvivorsCombo.GetRootAsSurvivorsCombo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsComboById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsComboById.HandleId, ConfigSurvivorsComboById.LogPair);
			return new SurvivorsCombo?(rootAsSurvivorsCombo);
		}

		// Token: 0x040048E1 RID: 18657
		private const string DB = "db_survivors.db";

		// Token: 0x040048E2 RID: 18658
		private const string FILE = "x.幸存者_关卡.xlsx";

		// Token: 0x040048E3 RID: 18659
		private const string TABLE = "SurvivorsCombo";

		// Token: 0x040048E4 RID: 18660
		private const string COMMAND = "select BinData from `SurvivorsCombo` where Id=?";

		// Token: 0x040048E5 RID: 18661
		private const string KEY_PREFIX = "SurvivorsComboById";

		// Token: 0x040048E6 RID: 18662
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048E7 RID: 18663
		private static int HandleId;
	}
}
