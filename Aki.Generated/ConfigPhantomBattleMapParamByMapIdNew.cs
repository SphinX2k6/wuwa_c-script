using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000695 RID: 1685
	public class ConfigPhantomBattleMapParamByMapIdNew : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600278E RID: 10126 RVA: 0x0013CD94 File Offset: 0x0013AF94
		static ConfigPhantomBattleMapParamByMapIdNew()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleMapParamByMapIdNew.CreateStaticDefaultValue), new Action(ConfigPhantomBattleMapParamByMapIdNew.ResetStaticDefaultValue));
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x0013CDB4 File Offset: 0x0013AFB4
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleMapParamByMapIdNew.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleMapParamByMapIdNew.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleMapParam"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleMapParam` where MapId=?")
			});
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x0013CE33 File Offset: 0x0013B033
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleMapParamByMapIdNew.LogPair = null;
			ConfigPhantomBattleMapParamByMapIdNew.HandleId = 0;
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x0013CE41 File Offset: 0x0013B041
		public static void Init()
		{
			ConfigPhantomBattleMapParamByMapIdNew.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleMapParamByMapIdNew.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleMapParam` where MapId=?");
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x0013CE5C File Offset: 0x0013B05C
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleMapParam> GetConfigList(int p0MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleMapParamByMapIdNew.HandleId, ConfigPhantomBattleMapParamByMapIdNew.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleMapParamByMapIdNew");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				IReadOnlyList<PhantomBattleMapParam> readOnlyList = (IReadOnlyList<PhantomBattleMapParam>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomBattleMapParamByMapIdNew.LogPair.Clear();
			ConfigPhantomBattleMapParamByMapIdNew.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleMapParamByMapIdNew.HandleId, 1, p0MapId, ConfigPhantomBattleMapParamByMapIdNew.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomBattleMapParamByMapIdNew.HandleId, ConfigPhantomBattleMapParamByMapIdNew.LogPair);
				return null;
			}
			List<PhantomBattleMapParam> list = new List<PhantomBattleMapParam>();
			while (ConfigCommon.Step(ConfigPhantomBattleMapParamByMapIdNew.HandleId, false, ConfigPhantomBattleMapParamByMapIdNew.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleMapParamByMapIdNew.HandleId, 0, ConfigPhantomBattleMapParamByMapIdNew.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleMapParamByMapIdNew.HandleId, ConfigPhantomBattleMapParamByMapIdNew.LogPair);
					return null;
				}
				PhantomBattleMapParam rootAsPhantomBattleMapParam = PhantomBattleMapParam.GetRootAsPhantomBattleMapParam(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleMapParam);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleMapParamByMapIdNew");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleMapParamByMapIdNew.HandleId, ConfigPhantomBattleMapParamByMapIdNew.LogPair);
			return list;
		}

		// Token: 0x04002DF9 RID: 11769
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002DFA RID: 11770
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002DFB RID: 11771
		private const string TABLE = "PhantomBattleMapParam";

		// Token: 0x04002DFC RID: 11772
		private const string COMMAND = "select BinData from `PhantomBattleMapParam` where MapId=?";

		// Token: 0x04002DFD RID: 11773
		private const string KEY_PREFIX = "PhantomBattleMapParamByMapIdNew";

		// Token: 0x04002DFE RID: 11774
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DFF RID: 11775
		private static int HandleId;
	}
}
