using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000998 RID: 2456
	public class ConfigSurvivorsComboById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039A4 RID: 14756 RVA: 0x0019F878 File Offset: 0x0019DA78
		static ConfigSurvivorsComboById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsComboById.CreateStaticDefaultValue), new Action(ConfigSurvivorsComboById.ResetStaticDefaultValue));
		}

		// Token: 0x060039A5 RID: 14757 RVA: 0x0019F898 File Offset: 0x0019DA98
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

		// Token: 0x060039A6 RID: 14758 RVA: 0x0019F917 File Offset: 0x0019DB17
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsComboById.LogPair = null;
			ConfigSurvivorsComboById.HandleId = 0;
		}

		// Token: 0x060039A7 RID: 14759 RVA: 0x0019F925 File Offset: 0x0019DB25
		public static void Init()
		{
			ConfigSurvivorsComboById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsComboById.HandleId, "db_survivors.db", "select BinData from `SurvivorsCombo` where Id=?");
		}

		// Token: 0x060039A8 RID: 14760 RVA: 0x0019F940 File Offset: 0x0019DB40
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

		// Token: 0x0400430E RID: 17166
		private const string DB = "db_survivors.db";

		// Token: 0x0400430F RID: 17167
		private const string FILE = "x.幸存者_关卡.xlsx";

		// Token: 0x04004310 RID: 17168
		private const string TABLE = "SurvivorsCombo";

		// Token: 0x04004311 RID: 17169
		private const string COMMAND = "select BinData from `SurvivorsCombo` where Id=?";

		// Token: 0x04004312 RID: 17170
		private const string KEY_PREFIX = "SurvivorsComboById";

		// Token: 0x04004313 RID: 17171
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004314 RID: 17172
		private static int HandleId;
	}
}
