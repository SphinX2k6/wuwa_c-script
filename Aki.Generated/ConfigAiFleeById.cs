using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000085 RID: 133
	public class ConfigAiFleeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600031E RID: 798 RVA: 0x0006B1E4 File Offset: 0x000693E4
		static ConfigAiFleeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiFleeById.CreateStaticDefaultValue), new Action(ConfigAiFleeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0006B204 File Offset: 0x00069404
		public static void CreateStaticDefaultValue()
		{
			ConfigAiFleeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAiFleeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ai.db"),
				new ValueTuple<string, object>("文件", "a.AI逃跑.xlsx"),
				new ValueTuple<string, object>("表名", "AiFlee"),
				new ValueTuple<string, object>("语句", "select BinData from `AiFlee` where id=?")
			});
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0006B283 File Offset: 0x00069483
		public static void ResetStaticDefaultValue()
		{
			ConfigAiFleeById.LogPair = null;
			ConfigAiFleeById.HandleId = 0;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0006B291 File Offset: 0x00069491
		public static void Init()
		{
			ConfigAiFleeById.HandleId = ConfigCommon.InitDataStatement(ConfigAiFleeById.HandleId, "db_ai.db", "select BinData from `AiFlee` where id=?");
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0006B2AC File Offset: 0x000694AC
		public static AiFlee? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAiFleeById.HandleId, ConfigAiFleeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiFleeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AiFlee?(AiFlee.GetRootAsAiFlee(configBuffer));
				}
			}
			ConfigAiFleeById.LogPair.Clear();
			ConfigAiFleeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAiFleeById.HandleId, 1, p0Id, ConfigAiFleeById.LogPair) || ConfigCommon.Step(ConfigAiFleeById.HandleId, true, ConfigAiFleeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAiFleeById.HandleId, ConfigAiFleeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAiFleeById.HandleId, 0, ConfigAiFleeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAiFleeById.HandleId, ConfigAiFleeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AiFlee rootAsAiFlee = AiFlee.GetRootAsAiFlee(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiFleeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAiFleeById.HandleId, ConfigAiFleeById.LogPair);
			return new AiFlee?(rootAsAiFlee);
		}

		// Token: 0x04000387 RID: 903
		private const string DB = "db_ai.db";

		// Token: 0x04000388 RID: 904
		private const string FILE = "a.AI逃跑.xlsx";

		// Token: 0x04000389 RID: 905
		private const string TABLE = "AiFlee";

		// Token: 0x0400038A RID: 906
		private const string COMMAND = "select BinData from `AiFlee` where id=?";

		// Token: 0x0400038B RID: 907
		private const string KEY_PREFIX = "AiFleeById";

		// Token: 0x0400038C RID: 908
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400038D RID: 909
		private static int HandleId;
	}
}
