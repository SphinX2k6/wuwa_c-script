using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000650 RID: 1616
	public class ConfigPersonalTipsByFunctionId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025F0 RID: 9712 RVA: 0x001302E5 File Offset: 0x0012E4E5
		static ConfigPersonalTipsByFunctionId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPersonalTipsByFunctionId.CreateStaticDefaultValue), new Action(ConfigPersonalTipsByFunctionId.ResetStaticDefaultValue));
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x00130304 File Offset: 0x0012E504
		public static void CreateStaticDefaultValue()
		{
			ConfigPersonalTipsByFunctionId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPersonalTipsByFunctionId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_personal.db"),
				new ValueTuple<string, object>("文件", "g.个性化弹窗.xlsx"),
				new ValueTuple<string, object>("表名", "PersonalTips"),
				new ValueTuple<string, object>("语句", "select BinData from `PersonalTips` where FunctionId=?")
			});
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x00130383 File Offset: 0x0012E583
		public static void ResetStaticDefaultValue()
		{
			ConfigPersonalTipsByFunctionId.LogPair = null;
			ConfigPersonalTipsByFunctionId.HandleId = 0;
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x00130391 File Offset: 0x0012E591
		public static void Init()
		{
			ConfigPersonalTipsByFunctionId.HandleId = ConfigCommon.InitDataStatement(ConfigPersonalTipsByFunctionId.HandleId, "db_personal.db", "select BinData from `PersonalTips` where FunctionId=?");
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x001303AC File Offset: 0x0012E5AC
		[NullableContext(2)]
		public static IReadOnlyList<PersonalTips> GetConfigList(int p0FunctionId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPersonalTipsByFunctionId.HandleId, ConfigPersonalTipsByFunctionId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PersonalTipsByFunctionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FunctionId);
				IReadOnlyList<PersonalTips> readOnlyList = (IReadOnlyList<PersonalTips>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPersonalTipsByFunctionId.LogPair.Clear();
			ConfigPersonalTipsByFunctionId.LogPair.Add(new ValueTuple<string, object>("FunctionId", p0FunctionId));
			if (!ConfigCommon.BindInt(ConfigPersonalTipsByFunctionId.HandleId, 1, p0FunctionId, ConfigPersonalTipsByFunctionId.LogPair))
			{
				ConfigCommon.Reset(ConfigPersonalTipsByFunctionId.HandleId, ConfigPersonalTipsByFunctionId.LogPair);
				return null;
			}
			List<PersonalTips> list = new List<PersonalTips>();
			while (ConfigCommon.Step(ConfigPersonalTipsByFunctionId.HandleId, false, ConfigPersonalTipsByFunctionId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPersonalTipsByFunctionId.HandleId, 0, ConfigPersonalTipsByFunctionId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPersonalTipsByFunctionId.HandleId, ConfigPersonalTipsByFunctionId.LogPair);
					return null;
				}
				PersonalTips rootAsPersonalTips = PersonalTips.GetRootAsPersonalTips(new ByteBuffer(item2));
				list.Add(rootAsPersonalTips);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PersonalTipsByFunctionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FunctionId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPersonalTipsByFunctionId.HandleId, ConfigPersonalTipsByFunctionId.LogPair);
			return list;
		}

		// Token: 0x04002C16 RID: 11286
		private const string DB = "db_personal.db";

		// Token: 0x04002C17 RID: 11287
		private const string FILE = "g.个性化弹窗.xlsx";

		// Token: 0x04002C18 RID: 11288
		private const string TABLE = "PersonalTips";

		// Token: 0x04002C19 RID: 11289
		private const string COMMAND = "select BinData from `PersonalTips` where FunctionId=?";

		// Token: 0x04002C1A RID: 11290
		private const string KEY_PREFIX = "PersonalTipsByFunctionId";

		// Token: 0x04002C1B RID: 11291
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C1C RID: 11292
		private static int HandleId;
	}
}
