using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006AE RID: 1710
	public class ConfigPhantomPlanParamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002824 RID: 10276 RVA: 0x0013C910 File Offset: 0x0013AB10
		static ConfigPhantomPlanParamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomPlanParamById.CreateStaticDefaultValue), new Action(ConfigPhantomPlanParamById.ResetStaticDefaultValue));
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x0013C930 File Offset: 0x0013AB30
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

		// Token: 0x06002826 RID: 10278 RVA: 0x0013C9AF File Offset: 0x0013ABAF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomPlanParamById.LogPair = null;
			ConfigPhantomPlanParamById.HandleId = 0;
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x0013C9BD File Offset: 0x0013ABBD
		public static void Init()
		{
			ConfigPhantomPlanParamById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomPlanParamById.HandleId, "db_visionrecommend.db", "select BinData from `PhantomPlanParam` where Id=?");
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x0013C9D8 File Offset: 0x0013ABD8
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

		// Token: 0x04002EA8 RID: 11944
		private const string DB = "db_visionrecommend.db";

		// Token: 0x04002EA9 RID: 11945
		private const string FILE = "h.幻象推荐.xlsx";

		// Token: 0x04002EAA RID: 11946
		private const string TABLE = "PhantomPlanParam";

		// Token: 0x04002EAB RID: 11947
		private const string COMMAND = "select BinData from `PhantomPlanParam` where Id=?";

		// Token: 0x04002EAC RID: 11948
		private const string KEY_PREFIX = "PhantomPlanParamById";

		// Token: 0x04002EAD RID: 11949
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EAE RID: 11950
		private static int HandleId;
	}
}
