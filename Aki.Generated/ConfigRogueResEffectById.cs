using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000840 RID: 2112
	public class ConfigRogueResEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003192 RID: 12690 RVA: 0x00171B54 File Offset: 0x0016FD54
		static ConfigRogueResEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEffectById.CreateStaticDefaultValue), new Action(ConfigRogueResEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x06003193 RID: 12691 RVA: 0x00171B74 File Offset: 0x0016FD74
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResEffectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResEffectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResEffect` where Id=?")
			});
		}

		// Token: 0x06003194 RID: 12692 RVA: 0x00171BF3 File Offset: 0x0016FDF3
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEffectById.LogPair = null;
			ConfigRogueResEffectById.HandleId = 0;
		}

		// Token: 0x06003195 RID: 12693 RVA: 0x00171C01 File Offset: 0x0016FE01
		public static void Init()
		{
			ConfigRogueResEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEffectById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEffect` where Id=?");
		}

		// Token: 0x06003196 RID: 12694 RVA: 0x00171C1C File Offset: 0x0016FE1C
		public static RogueResEffect? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResEffectById.HandleId, ConfigRogueResEffectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResEffect?(RogueResEffect.GetRootAsRogueResEffect(configBuffer));
				}
			}
			ConfigRogueResEffectById.LogPair.Clear();
			ConfigRogueResEffectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResEffectById.HandleId, 1, p0Id, ConfigRogueResEffectById.LogPair) || ConfigCommon.Step(ConfigRogueResEffectById.HandleId, true, ConfigRogueResEffectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResEffectById.HandleId, ConfigRogueResEffectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResEffectById.HandleId, 0, ConfigRogueResEffectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResEffectById.HandleId, ConfigRogueResEffectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResEffect rootAsRogueResEffect = RogueResEffect.GetRootAsRogueResEffect(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResEffectById.HandleId, ConfigRogueResEffectById.LogPair);
			return new RogueResEffect?(rootAsRogueResEffect);
		}

		// Token: 0x040039A6 RID: 14758
		private const string DB = "db_permanentrogue.db";

		// Token: 0x040039A7 RID: 14759
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x040039A8 RID: 14760
		private const string TABLE = "RogueResEffect";

		// Token: 0x040039A9 RID: 14761
		private const string COMMAND = "select BinData from `RogueResEffect` where Id=?";

		// Token: 0x040039AA RID: 14762
		private const string KEY_PREFIX = "RogueResEffectById";

		// Token: 0x040039AB RID: 14763
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039AC RID: 14764
		private static int HandleId;
	}
}
