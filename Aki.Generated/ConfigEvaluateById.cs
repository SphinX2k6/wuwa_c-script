using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000288 RID: 648
	public class ConfigEvaluateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F35 RID: 3893 RVA: 0x000AF738 File Offset: 0x000AD938
		static ConfigEvaluateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEvaluateById.CreateStaticDefaultValue), new Action(ConfigEvaluateById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x000AF758 File Offset: 0x000AD958
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

		// Token: 0x06000F37 RID: 3895 RVA: 0x000AF7D7 File Offset: 0x000AD9D7
		public static void ResetStaticDefaultValue()
		{
			ConfigEvaluateById.LogPair = null;
			ConfigEvaluateById.HandleId = 0;
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x000AF7E5 File Offset: 0x000AD9E5
		public static void Init()
		{
			ConfigEvaluateById.HandleId = ConfigCommon.InitDataStatement(ConfigEvaluateById.HandleId, "db_moonchasing.db", "select BinData from `Evaluate` where Id=?");
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x000AF800 File Offset: 0x000ADA00
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

		// Token: 0x0400119C RID: 4508
		private const string DB = "db_moonchasing.db";

		// Token: 0x0400119D RID: 4509
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x0400119E RID: 4510
		private const string TABLE = "Evaluate";

		// Token: 0x0400119F RID: 4511
		private const string COMMAND = "select BinData from `Evaluate` where Id=?";

		// Token: 0x040011A0 RID: 4512
		private const string KEY_PREFIX = "EvaluateById";

		// Token: 0x040011A1 RID: 4513
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011A2 RID: 4514
		private static int HandleId;
	}
}
