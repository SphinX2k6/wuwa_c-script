using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200007B RID: 123
	public class ConfigAdviceWordById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002E2 RID: 738 RVA: 0x00069BD7 File Offset: 0x00067DD7
		static ConfigAdviceWordById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdviceWordById.CreateStaticDefaultValue), new Action(ConfigAdviceWordById.ResetStaticDefaultValue));
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00069BF8 File Offset: 0x00067DF8
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

		// Token: 0x060002E4 RID: 740 RVA: 0x00069C77 File Offset: 0x00067E77
		public static void ResetStaticDefaultValue()
		{
			ConfigAdviceWordById.LogPair = null;
			ConfigAdviceWordById.HandleId = 0;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00069C85 File Offset: 0x00067E85
		public static void Init()
		{
			ConfigAdviceWordById.HandleId = ConfigCommon.InitDataStatement(ConfigAdviceWordById.HandleId, "db_advice.db", "select BinData from `AdviceWord` where Id=?");
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00069CA0 File Offset: 0x00067EA0
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

		// Token: 0x04000341 RID: 833
		private const string DB = "db_advice.db";

		// Token: 0x04000342 RID: 834
		private const string FILE = "s.溯言.xlsx";

		// Token: 0x04000343 RID: 835
		private const string TABLE = "AdviceWord";

		// Token: 0x04000344 RID: 836
		private const string COMMAND = "select BinData from `AdviceWord` where Id=?";

		// Token: 0x04000345 RID: 837
		private const string KEY_PREFIX = "AdviceWordById";

		// Token: 0x04000346 RID: 838
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000347 RID: 839
		private static int HandleId;
	}
}
