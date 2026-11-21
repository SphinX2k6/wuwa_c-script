using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000086 RID: 134
	public class ConfigAdviceWordTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000324 RID: 804 RVA: 0x0006EA9F File Offset: 0x0006CC9F
		static ConfigAdviceWordTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdviceWordTypeById.CreateStaticDefaultValue), new Action(ConfigAdviceWordTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0006EAC0 File Offset: 0x0006CCC0
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

		// Token: 0x06000326 RID: 806 RVA: 0x0006EB3F File Offset: 0x0006CD3F
		public static void ResetStaticDefaultValue()
		{
			ConfigAdviceWordTypeById.LogPair = null;
			ConfigAdviceWordTypeById.HandleId = 0;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0006EB4D File Offset: 0x0006CD4D
		public static void Init()
		{
			ConfigAdviceWordTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigAdviceWordTypeById.HandleId, "db_advice.db", "select BinData from `AdviceWordType` where Id=?");
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0006EB68 File Offset: 0x0006CD68
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

		// Token: 0x0400038E RID: 910
		private const string DB = "db_advice.db";

		// Token: 0x0400038F RID: 911
		private const string FILE = "s.溯言.xlsx";

		// Token: 0x04000390 RID: 912
		private const string TABLE = "AdviceWordType";

		// Token: 0x04000391 RID: 913
		private const string COMMAND = "select BinData from `AdviceWordType` where Id=?";

		// Token: 0x04000392 RID: 914
		private const string KEY_PREFIX = "AdviceWordTypeById";

		// Token: 0x04000393 RID: 915
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000394 RID: 916
		private static int HandleId;
	}
}
