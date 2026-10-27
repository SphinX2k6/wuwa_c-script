using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000841 RID: 2113
	public class ConfigRogueResEffectTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003198 RID: 12696 RVA: 0x00171D9C File Offset: 0x0016FF9C
		static ConfigRogueResEffectTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEffectTagById.CreateStaticDefaultValue), new Action(ConfigRogueResEffectTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06003199 RID: 12697 RVA: 0x00171DBC File Offset: 0x0016FFBC
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResEffectTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResEffectTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResEffectTag"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResEffectTag` where Id=?")
			});
		}

		// Token: 0x0600319A RID: 12698 RVA: 0x00171E3B File Offset: 0x0017003B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEffectTagById.LogPair = null;
			ConfigRogueResEffectTagById.HandleId = 0;
		}

		// Token: 0x0600319B RID: 12699 RVA: 0x00171E49 File Offset: 0x00170049
		public static void Init()
		{
			ConfigRogueResEffectTagById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEffectTagById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEffectTag` where Id=?");
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x00171E64 File Offset: 0x00170064
		public static RogueResEffectTag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResEffectTagById.HandleId, ConfigRogueResEffectTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEffectTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResEffectTag?(RogueResEffectTag.GetRootAsRogueResEffectTag(configBuffer));
				}
			}
			ConfigRogueResEffectTagById.LogPair.Clear();
			ConfigRogueResEffectTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResEffectTagById.HandleId, 1, p0Id, ConfigRogueResEffectTagById.LogPair) || ConfigCommon.Step(ConfigRogueResEffectTagById.HandleId, true, ConfigRogueResEffectTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResEffectTagById.HandleId, ConfigRogueResEffectTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResEffectTagById.HandleId, 0, ConfigRogueResEffectTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResEffectTagById.HandleId, ConfigRogueResEffectTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResEffectTag rootAsRogueResEffectTag = RogueResEffectTag.GetRootAsRogueResEffectTag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEffectTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResEffectTagById.HandleId, ConfigRogueResEffectTagById.LogPair);
			return new RogueResEffectTag?(rootAsRogueResEffectTag);
		}

		// Token: 0x040039AD RID: 14765
		private const string DB = "db_permanentrogue.db";

		// Token: 0x040039AE RID: 14766
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x040039AF RID: 14767
		private const string TABLE = "RogueResEffectTag";

		// Token: 0x040039B0 RID: 14768
		private const string COMMAND = "select BinData from `RogueResEffectTag` where Id=?";

		// Token: 0x040039B1 RID: 14769
		private const string KEY_PREFIX = "RogueResEffectTagById";

		// Token: 0x040039B2 RID: 14770
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039B3 RID: 14771
		private static int HandleId;
	}
}
