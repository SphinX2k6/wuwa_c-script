using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000088 RID: 136
	public class ConfigAiBaseById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000330 RID: 816 RVA: 0x0006EF30 File Offset: 0x0006D130
		static ConfigAiBaseById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiBaseById.CreateStaticDefaultValue), new Action(ConfigAiBaseById.ResetStaticDefaultValue));
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0006EF50 File Offset: 0x0006D150
		public static void CreateStaticDefaultValue()
		{
			ConfigAiBaseById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAiBaseById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ai.db"),
				new ValueTuple<string, object>("文件", "a.AI基础.xlsx"),
				new ValueTuple<string, object>("表名", "AiBase"),
				new ValueTuple<string, object>("语句", "select BinData from `AiBase` where Id=?")
			});
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0006EFCF File Offset: 0x0006D1CF
		public static void ResetStaticDefaultValue()
		{
			ConfigAiBaseById.LogPair = null;
			ConfigAiBaseById.HandleId = 0;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0006EFDD File Offset: 0x0006D1DD
		public static void Init()
		{
			ConfigAiBaseById.HandleId = ConfigCommon.InitDataStatement(ConfigAiBaseById.HandleId, "db_ai.db", "select BinData from `AiBase` where Id=?");
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0006EFF8 File Offset: 0x0006D1F8
		public static AiBase? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAiBaseById.HandleId, ConfigAiBaseById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiBaseById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AiBase?(AiBase.GetRootAsAiBase(configBuffer));
				}
			}
			ConfigAiBaseById.LogPair.Clear();
			ConfigAiBaseById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAiBaseById.HandleId, 1, p0Id, ConfigAiBaseById.LogPair) || ConfigCommon.Step(ConfigAiBaseById.HandleId, true, ConfigAiBaseById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAiBaseById.HandleId, ConfigAiBaseById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAiBaseById.HandleId, 0, ConfigAiBaseById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAiBaseById.HandleId, ConfigAiBaseById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AiBase rootAsAiBase = AiBase.GetRootAsAiBase(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiBaseById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAiBaseById.HandleId, ConfigAiBaseById.LogPair);
			return new AiBase?(rootAsAiBase);
		}

		// Token: 0x0400039C RID: 924
		private const string DB = "db_ai.db";

		// Token: 0x0400039D RID: 925
		private const string FILE = "a.AI基础.xlsx";

		// Token: 0x0400039E RID: 926
		private const string TABLE = "AiBase";

		// Token: 0x0400039F RID: 927
		private const string COMMAND = "select BinData from `AiBase` where Id=?";

		// Token: 0x040003A0 RID: 928
		private const string KEY_PREFIX = "AiBaseById";

		// Token: 0x040003A1 RID: 929
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003A2 RID: 930
		private static int HandleId;
	}
}
