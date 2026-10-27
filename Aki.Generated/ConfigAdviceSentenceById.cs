using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000079 RID: 121
	public class ConfigAdviceSentenceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002D6 RID: 726 RVA: 0x000697FB File Offset: 0x000679FB
		static ConfigAdviceSentenceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdviceSentenceById.CreateStaticDefaultValue), new Action(ConfigAdviceSentenceById.ResetStaticDefaultValue));
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0006981C File Offset: 0x00067A1C
		public static void CreateStaticDefaultValue()
		{
			ConfigAdviceSentenceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdviceSentenceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advice.db"),
				new ValueTuple<string, object>("文件", "s.溯言.xlsx"),
				new ValueTuple<string, object>("表名", "AdviceSentence"),
				new ValueTuple<string, object>("语句", "select BinData from `AdviceSentence` where Id=?")
			});
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0006989B File Offset: 0x00067A9B
		public static void ResetStaticDefaultValue()
		{
			ConfigAdviceSentenceById.LogPair = null;
			ConfigAdviceSentenceById.HandleId = 0;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000698A9 File Offset: 0x00067AA9
		public static void Init()
		{
			ConfigAdviceSentenceById.HandleId = ConfigCommon.InitDataStatement(ConfigAdviceSentenceById.HandleId, "db_advice.db", "select BinData from `AdviceSentence` where Id=?");
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000698C4 File Offset: 0x00067AC4
		public static AdviceSentence? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdviceSentenceById.HandleId, ConfigAdviceSentenceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdviceSentenceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdviceSentence?(AdviceSentence.GetRootAsAdviceSentence(configBuffer));
				}
			}
			ConfigAdviceSentenceById.LogPair.Clear();
			ConfigAdviceSentenceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAdviceSentenceById.HandleId, 1, p0Id, ConfigAdviceSentenceById.LogPair) || ConfigCommon.Step(ConfigAdviceSentenceById.HandleId, true, ConfigAdviceSentenceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdviceSentenceById.HandleId, ConfigAdviceSentenceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdviceSentenceById.HandleId, 0, ConfigAdviceSentenceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdviceSentenceById.HandleId, ConfigAdviceSentenceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdviceSentence rootAsAdviceSentence = AdviceSentence.GetRootAsAdviceSentence(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdviceSentenceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdviceSentenceById.HandleId, ConfigAdviceSentenceById.LogPair);
			return new AdviceSentence?(rootAsAdviceSentence);
		}

		// Token: 0x04000333 RID: 819
		private const string DB = "db_advice.db";

		// Token: 0x04000334 RID: 820
		private const string FILE = "s.溯言.xlsx";

		// Token: 0x04000335 RID: 821
		private const string TABLE = "AdviceSentence";

		// Token: 0x04000336 RID: 822
		private const string COMMAND = "select BinData from `AdviceSentence` where Id=?";

		// Token: 0x04000337 RID: 823
		private const string KEY_PREFIX = "AdviceSentenceById";

		// Token: 0x04000338 RID: 824
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000339 RID: 825
		private static int HandleId;
	}
}
