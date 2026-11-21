using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000081 RID: 129
	public class ConfigAdviceSentenceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000306 RID: 774 RVA: 0x0006E0AF File Offset: 0x0006C2AF
		static ConfigAdviceSentenceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdviceSentenceById.CreateStaticDefaultValue), new Action(ConfigAdviceSentenceById.ResetStaticDefaultValue));
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0006E0D0 File Offset: 0x0006C2D0
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

		// Token: 0x06000308 RID: 776 RVA: 0x0006E14F File Offset: 0x0006C34F
		public static void ResetStaticDefaultValue()
		{
			ConfigAdviceSentenceById.LogPair = null;
			ConfigAdviceSentenceById.HandleId = 0;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0006E15D File Offset: 0x0006C35D
		public static void Init()
		{
			ConfigAdviceSentenceById.HandleId = ConfigCommon.InitDataStatement(ConfigAdviceSentenceById.HandleId, "db_advice.db", "select BinData from `AdviceSentence` where Id=?");
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0006E178 File Offset: 0x0006C378
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

		// Token: 0x0400036B RID: 875
		private const string DB = "db_advice.db";

		// Token: 0x0400036C RID: 876
		private const string FILE = "s.溯言.xlsx";

		// Token: 0x0400036D RID: 877
		private const string TABLE = "AdviceSentence";

		// Token: 0x0400036E RID: 878
		private const string COMMAND = "select BinData from `AdviceSentence` where Id=?";

		// Token: 0x0400036F RID: 879
		private const string KEY_PREFIX = "AdviceSentenceById";

		// Token: 0x04000370 RID: 880
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000371 RID: 881
		private static int HandleId;
	}
}
