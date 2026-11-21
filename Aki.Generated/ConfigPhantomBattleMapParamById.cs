using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000693 RID: 1683
	public class ConfigPhantomBattleMapParamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002782 RID: 10114 RVA: 0x0013C903 File Offset: 0x0013AB03
		static ConfigPhantomBattleMapParamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleMapParamById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleMapParamById.ResetStaticDefaultValue));
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x0013C924 File Offset: 0x0013AB24
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

		// Token: 0x06002784 RID: 10116 RVA: 0x0013C9A3 File Offset: 0x0013ABA3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleMapParamById.LogPair = null;
			ConfigPhantomBattleMapParamById.HandleId = 0;
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x0013C9B1 File Offset: 0x0013ABB1
		public static void Init()
		{
			ConfigPhantomBattleMapParamById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleMapParamById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleMapParam` where Id=?");
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x0013C9CC File Offset: 0x0013ABCC
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

		// Token: 0x04002DEB RID: 11755
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002DEC RID: 11756
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002DED RID: 11757
		private const string TABLE = "PhantomBattleMapParam";

		// Token: 0x04002DEE RID: 11758
		private const string COMMAND = "select BinData from `PhantomBattleMapParam` where Id=?";

		// Token: 0x04002DEF RID: 11759
		private const string KEY_PREFIX = "PhantomBattleMapParamById";

		// Token: 0x04002DF0 RID: 11760
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DF1 RID: 11761
		private static int HandleId;
	}
}
