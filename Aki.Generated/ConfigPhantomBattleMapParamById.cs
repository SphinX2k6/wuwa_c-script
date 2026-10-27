using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200067B RID: 1659
	public class ConfigPhantomBattleMapParamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026F2 RID: 9970 RVA: 0x00135E87 File Offset: 0x00134087
		static ConfigPhantomBattleMapParamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleMapParamById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleMapParamById.ResetStaticDefaultValue));
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x00135EA8 File Offset: 0x001340A8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleMapParamById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleMapParamById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleMapParam"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleMapParam` where Id=?")
			});
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x00135F27 File Offset: 0x00134127
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleMapParamById.LogPair = null;
			ConfigPhantomBattleMapParamById.HandleId = 0;
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x00135F35 File Offset: 0x00134135
		public static void Init()
		{
			ConfigPhantomBattleMapParamById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleMapParamById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleMapParam` where Id=?");
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x00135F50 File Offset: 0x00134150
		public static PhantomBattleMapParam? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleMapParamById.HandleId, ConfigPhantomBattleMapParamById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleMapParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleMapParam?(PhantomBattleMapParam.GetRootAsPhantomBattleMapParam(configBuffer));
				}
			}
			ConfigPhantomBattleMapParamById.LogPair.Clear();
			ConfigPhantomBattleMapParamById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleMapParamById.HandleId, 1, p0Id, ConfigPhantomBattleMapParamById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleMapParamById.HandleId, true, ConfigPhantomBattleMapParamById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleMapParamById.HandleId, ConfigPhantomBattleMapParamById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleMapParamById.HandleId, 0, ConfigPhantomBattleMapParamById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleMapParamById.HandleId, ConfigPhantomBattleMapParamById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleMapParam rootAsPhantomBattleMapParam = PhantomBattleMapParam.GetRootAsPhantomBattleMapParam(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleMapParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleMapParamById.HandleId, ConfigPhantomBattleMapParamById.LogPair);
			return new PhantomBattleMapParam?(rootAsPhantomBattleMapParam);
		}

		// Token: 0x04002D43 RID: 11587
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D44 RID: 11588
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D45 RID: 11589
		private const string TABLE = "PhantomBattleMapParam";

		// Token: 0x04002D46 RID: 11590
		private const string COMMAND = "select BinData from `PhantomBattleMapParam` where Id=?";

		// Token: 0x04002D47 RID: 11591
		private const string KEY_PREFIX = "PhantomBattleMapParamById";

		// Token: 0x04002D48 RID: 11592
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D49 RID: 11593
		private static int HandleId;
	}
}
