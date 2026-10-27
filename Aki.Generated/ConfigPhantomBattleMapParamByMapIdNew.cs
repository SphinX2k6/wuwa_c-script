using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200067D RID: 1661
	public class ConfigPhantomBattleMapParamByMapIdNew : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026FE RID: 9982 RVA: 0x00136318 File Offset: 0x00134518
		static ConfigPhantomBattleMapParamByMapIdNew()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleMapParamByMapIdNew.CreateStaticDefaultValue), new Action(ConfigPhantomBattleMapParamByMapIdNew.ResetStaticDefaultValue));
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x00136338 File Offset: 0x00134538
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

		// Token: 0x06002700 RID: 9984 RVA: 0x001363B7 File Offset: 0x001345B7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleMapParamByMapIdNew.LogPair = null;
			ConfigPhantomBattleMapParamByMapIdNew.HandleId = 0;
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x001363C5 File Offset: 0x001345C5
		public static void Init()
		{
			ConfigPhantomBattleMapParamByMapIdNew.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleMapParamByMapIdNew.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleMapParam` where MapId=?");
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x001363E0 File Offset: 0x001345E0
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

		// Token: 0x04002D51 RID: 11601
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D52 RID: 11602
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D53 RID: 11603
		private const string TABLE = "PhantomBattleMapParam";

		// Token: 0x04002D54 RID: 11604
		private const string COMMAND = "select BinData from `PhantomBattleMapParam` where MapId=?";

		// Token: 0x04002D55 RID: 11605
		private const string KEY_PREFIX = "PhantomBattleMapParamByMapIdNew";

		// Token: 0x04002D56 RID: 11606
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D57 RID: 11607
		private static int HandleId;
	}
}
