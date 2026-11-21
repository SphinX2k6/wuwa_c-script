using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000083 RID: 131
	public class ConfigAdviceWordById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000312 RID: 786 RVA: 0x0006E48B File Offset: 0x0006C68B
		static ConfigAdviceWordById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdviceWordById.CreateStaticDefaultValue), new Action(ConfigAdviceWordById.ResetStaticDefaultValue));
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0006E4AC File Offset: 0x0006C6AC
		public static void CreateStaticDefaultValue()
		{
			ConfigAdviceWordById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdviceWordById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advice.db"),
				new ValueTuple<string, object>("文件", "s.溯言.xlsx"),
				new ValueTuple<string, object>("表名", "AdviceWord"),
				new ValueTuple<string, object>("语句", "select BinData from `AdviceWord` where Id=?")
			});
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0006E52B File Offset: 0x0006C72B
		public static void ResetStaticDefaultValue()
		{
			ConfigAdviceWordById.LogPair = null;
			ConfigAdviceWordById.HandleId = 0;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0006E539 File Offset: 0x0006C739
		public static void Init()
		{
			ConfigAdviceWordById.HandleId = ConfigCommon.InitDataStatement(ConfigAdviceWordById.HandleId, "db_advice.db", "select BinData from `AdviceWord` where Id=?");
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0006E554 File Offset: 0x0006C754
		public static AdviceWord? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdviceWordById.HandleId, ConfigAdviceWordById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdviceWordById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdviceWord?(AdviceWord.GetRootAsAdviceWord(configBuffer));
				}
			}
			ConfigAdviceWordById.LogPair.Clear();
			ConfigAdviceWordById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAdviceWordById.HandleId, 1, p0Id, ConfigAdviceWordById.LogPair) || ConfigCommon.Step(ConfigAdviceWordById.HandleId, true, ConfigAdviceWordById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdviceWordById.HandleId, ConfigAdviceWordById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdviceWordById.HandleId, 0, ConfigAdviceWordById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdviceWordById.HandleId, ConfigAdviceWordById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdviceWord rootAsAdviceWord = AdviceWord.GetRootAsAdviceWord(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdviceWordById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdviceWordById.HandleId, ConfigAdviceWordById.LogPair);
			return new AdviceWord?(rootAsAdviceWord);
		}

		// Token: 0x04000379 RID: 889
		private const string DB = "db_advice.db";

		// Token: 0x0400037A RID: 890
		private const string FILE = "s.溯言.xlsx";

		// Token: 0x0400037B RID: 891
		private const string TABLE = "AdviceWord";

		// Token: 0x0400037C RID: 892
		private const string COMMAND = "select BinData from `AdviceWord` where Id=?";

		// Token: 0x0400037D RID: 893
		private const string KEY_PREFIX = "AdviceWordById";

		// Token: 0x0400037E RID: 894
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400037F RID: 895
		private static int HandleId;
	}
}
