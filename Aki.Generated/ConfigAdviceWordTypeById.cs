using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200007E RID: 126
	public class ConfigAdviceWordTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002F4 RID: 756 RVA: 0x0006A1EB File Offset: 0x000683EB
		static ConfigAdviceWordTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdviceWordTypeById.CreateStaticDefaultValue), new Action(ConfigAdviceWordTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0006A20C File Offset: 0x0006840C
		public static void CreateStaticDefaultValue()
		{
			ConfigAdviceWordTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdviceWordTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advice.db"),
				new ValueTuple<string, object>("文件", "s.溯言.xlsx"),
				new ValueTuple<string, object>("表名", "AdviceWordType"),
				new ValueTuple<string, object>("语句", "select BinData from `AdviceWordType` where Id=?")
			});
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0006A28B File Offset: 0x0006848B
		public static void ResetStaticDefaultValue()
		{
			ConfigAdviceWordTypeById.LogPair = null;
			ConfigAdviceWordTypeById.HandleId = 0;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0006A299 File Offset: 0x00068499
		public static void Init()
		{
			ConfigAdviceWordTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigAdviceWordTypeById.HandleId, "db_advice.db", "select BinData from `AdviceWordType` where Id=?");
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0006A2B4 File Offset: 0x000684B4
		public static AdviceWordType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdviceWordTypeById.HandleId, ConfigAdviceWordTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdviceWordTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdviceWordType?(AdviceWordType.GetRootAsAdviceWordType(configBuffer));
				}
			}
			ConfigAdviceWordTypeById.LogPair.Clear();
			ConfigAdviceWordTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAdviceWordTypeById.HandleId, 1, p0Id, ConfigAdviceWordTypeById.LogPair) || ConfigCommon.Step(ConfigAdviceWordTypeById.HandleId, true, ConfigAdviceWordTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdviceWordTypeById.HandleId, ConfigAdviceWordTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdviceWordTypeById.HandleId, 0, ConfigAdviceWordTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdviceWordTypeById.HandleId, ConfigAdviceWordTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdviceWordType rootAsAdviceWordType = AdviceWordType.GetRootAsAdviceWordType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdviceWordTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdviceWordTypeById.HandleId, ConfigAdviceWordTypeById.LogPair);
			return new AdviceWordType?(rootAsAdviceWordType);
		}

		// Token: 0x04000356 RID: 854
		private const string DB = "db_advice.db";

		// Token: 0x04000357 RID: 855
		private const string FILE = "s.溯言.xlsx";

		// Token: 0x04000358 RID: 856
		private const string TABLE = "AdviceWordType";

		// Token: 0x04000359 RID: 857
		private const string COMMAND = "select BinData from `AdviceWordType` where Id=?";

		// Token: 0x0400035A RID: 858
		private const string KEY_PREFIX = "AdviceWordTypeById";

		// Token: 0x0400035B RID: 859
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400035C RID: 860
		private static int HandleId;
	}
}
