using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200007F RID: 127
	public class ConfigAdviceParamsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002FA RID: 762 RVA: 0x0006DCD4 File Offset: 0x0006BED4
		static ConfigAdviceParamsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdviceParamsById.CreateStaticDefaultValue), new Action(ConfigAdviceParamsById.ResetStaticDefaultValue));
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0006DCF4 File Offset: 0x0006BEF4
		public static void CreateStaticDefaultValue()
		{
			ConfigAdviceParamsById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdviceParamsById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advice.db"),
				new ValueTuple<string, object>("文件", "s.溯言.xlsx"),
				new ValueTuple<string, object>("表名", "AdviceParams"),
				new ValueTuple<string, object>("语句", "select BinData from `AdviceParams` where Id=?")
			});
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0006DD73 File Offset: 0x0006BF73
		public static void ResetStaticDefaultValue()
		{
			ConfigAdviceParamsById.LogPair = null;
			ConfigAdviceParamsById.HandleId = 0;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0006DD81 File Offset: 0x0006BF81
		public static void Init()
		{
			ConfigAdviceParamsById.HandleId = ConfigCommon.InitDataStatement(ConfigAdviceParamsById.HandleId, "db_advice.db", "select BinData from `AdviceParams` where Id=?");
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0006DD9C File Offset: 0x0006BF9C
		public static AdviceParams? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdviceParamsById.HandleId, ConfigAdviceParamsById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdviceParamsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdviceParams?(AdviceParams.GetRootAsAdviceParams(configBuffer));
				}
			}
			ConfigAdviceParamsById.LogPair.Clear();
			ConfigAdviceParamsById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAdviceParamsById.HandleId, 1, p0Id, ConfigAdviceParamsById.LogPair) || ConfigCommon.Step(ConfigAdviceParamsById.HandleId, true, ConfigAdviceParamsById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdviceParamsById.HandleId, ConfigAdviceParamsById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdviceParamsById.HandleId, 0, ConfigAdviceParamsById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdviceParamsById.HandleId, ConfigAdviceParamsById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdviceParams rootAsAdviceParams = AdviceParams.GetRootAsAdviceParams(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdviceParamsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdviceParamsById.HandleId, ConfigAdviceParamsById.LogPair);
			return new AdviceParams?(rootAsAdviceParams);
		}

		// Token: 0x0400035D RID: 861
		private const string DB = "db_advice.db";

		// Token: 0x0400035E RID: 862
		private const string FILE = "s.溯言.xlsx";

		// Token: 0x0400035F RID: 863
		private const string TABLE = "AdviceParams";

		// Token: 0x04000360 RID: 864
		private const string COMMAND = "select BinData from `AdviceParams` where Id=?";

		// Token: 0x04000361 RID: 865
		private const string KEY_PREFIX = "AdviceParamsById";

		// Token: 0x04000362 RID: 866
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000363 RID: 867
		private static int HandleId;
	}
}
