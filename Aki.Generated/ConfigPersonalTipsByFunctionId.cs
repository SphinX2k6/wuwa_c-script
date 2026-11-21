using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000668 RID: 1640
	public class ConfigPersonalTipsByFunctionId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002680 RID: 9856 RVA: 0x00136D61 File Offset: 0x00134F61
		static ConfigPersonalTipsByFunctionId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPersonalTipsByFunctionId.CreateStaticDefaultValue), new Action(ConfigPersonalTipsByFunctionId.ResetStaticDefaultValue));
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x00136D80 File Offset: 0x00134F80
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

		// Token: 0x06002682 RID: 9858 RVA: 0x00136DFF File Offset: 0x00134FFF
		public static void ResetStaticDefaultValue()
		{
			ConfigPersonalTipsByFunctionId.LogPair = null;
			ConfigPersonalTipsByFunctionId.HandleId = 0;
		}

		// Token: 0x06002683 RID: 9859 RVA: 0x00136E0D File Offset: 0x0013500D
		public static void Init()
		{
			ConfigPersonalTipsByFunctionId.HandleId = ConfigCommon.InitDataStatement(ConfigPersonalTipsByFunctionId.HandleId, "db_personal.db", "select BinData from `PersonalTips` where FunctionId=?");
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x00136E28 File Offset: 0x00135028
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

		// Token: 0x04002CBE RID: 11454
		private const string DB = "db_personal.db";

		// Token: 0x04002CBF RID: 11455
		private const string FILE = "g.个性化弹窗.xlsx";

		// Token: 0x04002CC0 RID: 11456
		private const string TABLE = "PersonalTips";

		// Token: 0x04002CC1 RID: 11457
		private const string COMMAND = "select BinData from `PersonalTips` where FunctionId=?";

		// Token: 0x04002CC2 RID: 11458
		private const string KEY_PREFIX = "PersonalTipsByFunctionId";

		// Token: 0x04002CC3 RID: 11459
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CC4 RID: 11460
		private static int HandleId;
	}
}
