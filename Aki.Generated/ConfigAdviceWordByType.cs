using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000084 RID: 132
	public class ConfigAdviceWordByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000318 RID: 792 RVA: 0x0006E6D4 File Offset: 0x0006C8D4
		static ConfigAdviceWordByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdviceWordByType.CreateStaticDefaultValue), new Action(ConfigAdviceWordByType.ResetStaticDefaultValue));
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0006E6F4 File Offset: 0x0006C8F4
		public static void CreateStaticDefaultValue()
		{
			ConfigAdviceWordByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdviceWordByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advice.db"),
				new ValueTuple<string, object>("文件", "s.溯言.xlsx"),
				new ValueTuple<string, object>("表名", "AdviceWord"),
				new ValueTuple<string, object>("语句", "select BinData from `AdviceWord` where Type=?")
			});
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0006E773 File Offset: 0x0006C973
		public static void ResetStaticDefaultValue()
		{
			ConfigAdviceWordByType.LogPair = null;
			ConfigAdviceWordByType.HandleId = 0;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0006E781 File Offset: 0x0006C981
		public static void Init()
		{
			ConfigAdviceWordByType.HandleId = ConfigCommon.InitDataStatement(ConfigAdviceWordByType.HandleId, "db_advice.db", "select BinData from `AdviceWord` where Type=?");
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0006E79C File Offset: 0x0006C99C
		[NullableContext(2)]
		public static IReadOnlyList<AdviceWord> GetConfigList(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdviceWordByType.HandleId, ConfigAdviceWordByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdviceWordByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				IReadOnlyList<AdviceWord> readOnlyList = (IReadOnlyList<AdviceWord>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigAdviceWordByType.LogPair.Clear();
			ConfigAdviceWordByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigAdviceWordByType.HandleId, 1, p0Type, ConfigAdviceWordByType.LogPair))
			{
				ConfigCommon.Reset(ConfigAdviceWordByType.HandleId, ConfigAdviceWordByType.LogPair);
				return null;
			}
			List<AdviceWord> list = new List<AdviceWord>();
			while (ConfigCommon.Step(ConfigAdviceWordByType.HandleId, false, ConfigAdviceWordByType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdviceWordByType.HandleId, 0, ConfigAdviceWordByType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAdviceWordByType.HandleId, ConfigAdviceWordByType.LogPair);
					return null;
				}
				AdviceWord rootAsAdviceWord = AdviceWord.GetRootAsAdviceWord(new ByteBuffer(item2));
				list.Add(rootAsAdviceWord);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdviceWordByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigAdviceWordByType.HandleId, ConfigAdviceWordByType.LogPair);
			return list;
		}

		// Token: 0x04000380 RID: 896
		private const string DB = "db_advice.db";

		// Token: 0x04000381 RID: 897
		private const string FILE = "s.溯言.xlsx";

		// Token: 0x04000382 RID: 898
		private const string TABLE = "AdviceWord";

		// Token: 0x04000383 RID: 899
		private const string COMMAND = "select BinData from `AdviceWord` where Type=?";

		// Token: 0x04000384 RID: 900
		private const string KEY_PREFIX = "AdviceWordByType";

		// Token: 0x04000385 RID: 901
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000386 RID: 902
		private static int HandleId;
	}
}
