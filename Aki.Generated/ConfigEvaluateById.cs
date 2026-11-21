using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200029C RID: 668
	public class ConfigEvaluateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FAD RID: 4013 RVA: 0x000B59FC File Offset: 0x000B3BFC
		static ConfigEvaluateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEvaluateById.CreateStaticDefaultValue), new Action(ConfigEvaluateById.ResetStaticDefaultValue));
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x000B5A1C File Offset: 0x000B3C1C
		public static void CreateStaticDefaultValue()
		{
			ConfigEvaluateById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEvaluateById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "Evaluate"),
				new ValueTuple<string, object>("语句", "select BinData from `Evaluate` where Id=?")
			});
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x000B5A9B File Offset: 0x000B3C9B
		public static void ResetStaticDefaultValue()
		{
			ConfigEvaluateById.LogPair = null;
			ConfigEvaluateById.HandleId = 0;
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x000B5AA9 File Offset: 0x000B3CA9
		public static void Init()
		{
			ConfigEvaluateById.HandleId = ConfigCommon.InitDataStatement(ConfigEvaluateById.HandleId, "db_moonchasing.db", "select BinData from `Evaluate` where Id=?");
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x000B5AC4 File Offset: 0x000B3CC4
		public static Evaluate? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEvaluateById.HandleId, ConfigEvaluateById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EvaluateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Evaluate?(Evaluate.GetRootAsEvaluate(configBuffer));
				}
			}
			ConfigEvaluateById.LogPair.Clear();
			ConfigEvaluateById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigEvaluateById.HandleId, 1, p0Id, ConfigEvaluateById.LogPair) || ConfigCommon.Step(ConfigEvaluateById.HandleId, true, ConfigEvaluateById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEvaluateById.HandleId, ConfigEvaluateById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEvaluateById.HandleId, 0, ConfigEvaluateById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEvaluateById.HandleId, ConfigEvaluateById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Evaluate rootAsEvaluate = Evaluate.GetRootAsEvaluate(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EvaluateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEvaluateById.HandleId, ConfigEvaluateById.LogPair);
			return new Evaluate?(rootAsEvaluate);
		}

		// Token: 0x04001228 RID: 4648
		private const string DB = "db_moonchasing.db";

		// Token: 0x04001229 RID: 4649
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x0400122A RID: 4650
		private const string TABLE = "Evaluate";

		// Token: 0x0400122B RID: 4651
		private const string COMMAND = "select BinData from `Evaluate` where Id=?";

		// Token: 0x0400122C RID: 4652
		private const string KEY_PREFIX = "EvaluateById";

		// Token: 0x0400122D RID: 4653
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400122E RID: 4654
		private static int HandleId;
	}
}
