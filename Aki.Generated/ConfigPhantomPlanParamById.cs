using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006C6 RID: 1734
	public class ConfigPhantomPlanParamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028B4 RID: 10420 RVA: 0x0014338C File Offset: 0x0014158C
		static ConfigPhantomPlanParamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomPlanParamById.CreateStaticDefaultValue), new Action(ConfigPhantomPlanParamById.ResetStaticDefaultValue));
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x001433AC File Offset: 0x001415AC
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomPlanParamById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomPlanParamById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_visionrecommend.db"),
				new ValueTuple<string, object>("文件", "h.幻象推荐.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomPlanParam"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomPlanParam` where Id=?")
			});
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x0014342B File Offset: 0x0014162B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomPlanParamById.LogPair = null;
			ConfigPhantomPlanParamById.HandleId = 0;
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x00143439 File Offset: 0x00141639
		public static void Init()
		{
			ConfigPhantomPlanParamById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomPlanParamById.HandleId, "db_visionrecommend.db", "select BinData from `PhantomPlanParam` where Id=?");
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x00143454 File Offset: 0x00141654
		public static PhantomPlanParam? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomPlanParamById.HandleId, ConfigPhantomPlanParamById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomPlanParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomPlanParam?(PhantomPlanParam.GetRootAsPhantomPlanParam(configBuffer));
				}
			}
			ConfigPhantomPlanParamById.LogPair.Clear();
			ConfigPhantomPlanParamById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomPlanParamById.HandleId, 1, p0Id, ConfigPhantomPlanParamById.LogPair) || ConfigCommon.Step(ConfigPhantomPlanParamById.HandleId, true, ConfigPhantomPlanParamById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomPlanParamById.HandleId, ConfigPhantomPlanParamById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomPlanParamById.HandleId, 0, ConfigPhantomPlanParamById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomPlanParamById.HandleId, ConfigPhantomPlanParamById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomPlanParam rootAsPhantomPlanParam = PhantomPlanParam.GetRootAsPhantomPlanParam(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomPlanParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomPlanParamById.HandleId, ConfigPhantomPlanParamById.LogPair);
			return new PhantomPlanParam?(rootAsPhantomPlanParam);
		}

		// Token: 0x04002F50 RID: 12112
		private const string DB = "db_visionrecommend.db";

		// Token: 0x04002F51 RID: 12113
		private const string FILE = "h.幻象推荐.xlsx";

		// Token: 0x04002F52 RID: 12114
		private const string TABLE = "PhantomPlanParam";

		// Token: 0x04002F53 RID: 12115
		private const string COMMAND = "select BinData from `PhantomPlanParam` where Id=?";

		// Token: 0x04002F54 RID: 12116
		private const string KEY_PREFIX = "PhantomPlanParamById";

		// Token: 0x04002F55 RID: 12117
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F56 RID: 12118
		private static int HandleId;
	}
}
