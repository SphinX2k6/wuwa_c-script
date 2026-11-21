using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000694 RID: 1684
	public class ConfigPhantomBattleMapParamByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002788 RID: 10120 RVA: 0x0013CB4C File Offset: 0x0013AD4C
		static ConfigPhantomBattleMapParamByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleMapParamByMapId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleMapParamByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x0013CB6C File Offset: 0x0013AD6C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleMapParamByMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleMapParamByMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleMapParam"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleMapParam` where MapId=?")
			});
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x0013CBEB File Offset: 0x0013ADEB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleMapParamByMapId.LogPair = null;
			ConfigPhantomBattleMapParamByMapId.HandleId = 0;
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x0013CBF9 File Offset: 0x0013ADF9
		public static void Init()
		{
			ConfigPhantomBattleMapParamByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleMapParamByMapId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleMapParam` where MapId=?");
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x0013CC14 File Offset: 0x0013AE14
		public static PhantomBattleMapParam? GetConfig(int p0MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleMapParamByMapId.HandleId, ConfigPhantomBattleMapParamByMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleMapParamByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleMapParam?(PhantomBattleMapParam.GetRootAsPhantomBattleMapParam(configBuffer));
				}
			}
			ConfigPhantomBattleMapParamByMapId.LogPair.Clear();
			ConfigPhantomBattleMapParamByMapId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleMapParamByMapId.HandleId, 1, p0MapId, ConfigPhantomBattleMapParamByMapId.LogPair) || ConfigCommon.Step(ConfigPhantomBattleMapParamByMapId.HandleId, true, ConfigPhantomBattleMapParamByMapId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleMapParamByMapId.HandleId, ConfigPhantomBattleMapParamByMapId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleMapParamByMapId.HandleId, 0, ConfigPhantomBattleMapParamByMapId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleMapParamByMapId.HandleId, ConfigPhantomBattleMapParamByMapId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleMapParam rootAsPhantomBattleMapParam = PhantomBattleMapParam.GetRootAsPhantomBattleMapParam(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleMapParamByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleMapParamByMapId.HandleId, ConfigPhantomBattleMapParamByMapId.LogPair);
			return new PhantomBattleMapParam?(rootAsPhantomBattleMapParam);
		}

		// Token: 0x04002DF2 RID: 11762
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002DF3 RID: 11763
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002DF4 RID: 11764
		private const string TABLE = "PhantomBattleMapParam";

		// Token: 0x04002DF5 RID: 11765
		private const string COMMAND = "select BinData from `PhantomBattleMapParam` where MapId=?";

		// Token: 0x04002DF6 RID: 11766
		private const string KEY_PREFIX = "PhantomBattleMapParamByMapId";

		// Token: 0x04002DF7 RID: 11767
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DF8 RID: 11768
		private static int HandleId;
	}
}
