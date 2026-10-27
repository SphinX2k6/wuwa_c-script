using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000822 RID: 2082
	public class ConfigRogueEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030DE RID: 12510 RVA: 0x0016D960 File Offset: 0x0016BB60
		static ConfigRogueEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueEffectById.CreateStaticDefaultValue), new Action(ConfigRogueEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x0016D980 File Offset: 0x0016BB80
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueEffectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueEffectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueEffect` where Id=?")
			});
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x0016D9FF File Offset: 0x0016BBFF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueEffectById.LogPair = null;
			ConfigRogueEffectById.HandleId = 0;
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x0016DA0D File Offset: 0x0016BC0D
		public static void Init()
		{
			ConfigRogueEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueEffectById.HandleId, "db_rogue.db", "select BinData from `RogueEffect` where Id=?");
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x0016DA28 File Offset: 0x0016BC28
		public static RogueEffect? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueEffectById.HandleId, ConfigRogueEffectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueEffect?(RogueEffect.GetRootAsRogueEffect(configBuffer));
				}
			}
			ConfigRogueEffectById.LogPair.Clear();
			ConfigRogueEffectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueEffectById.HandleId, 1, p0Id, ConfigRogueEffectById.LogPair) || ConfigCommon.Step(ConfigRogueEffectById.HandleId, true, ConfigRogueEffectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueEffectById.HandleId, ConfigRogueEffectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueEffectById.HandleId, 0, ConfigRogueEffectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueEffectById.HandleId, ConfigRogueEffectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueEffect rootAsRogueEffect = RogueEffect.GetRootAsRogueEffect(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueEffectById.HandleId, ConfigRogueEffectById.LogPair);
			return new RogueEffect?(rootAsRogueEffect);
		}

		// Token: 0x040038D4 RID: 14548
		private const string DB = "db_rogue.db";

		// Token: 0x040038D5 RID: 14549
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x040038D6 RID: 14550
		private const string TABLE = "RogueEffect";

		// Token: 0x040038D7 RID: 14551
		private const string COMMAND = "select BinData from `RogueEffect` where Id=?";

		// Token: 0x040038D8 RID: 14552
		private const string KEY_PREFIX = "RogueEffectById";

		// Token: 0x040038D9 RID: 14553
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038DA RID: 14554
		private static int HandleId;
	}
}
