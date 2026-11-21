using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200085C RID: 2140
	public class ConfigRogueResEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600323A RID: 12858 RVA: 0x00178E3C File Offset: 0x0017703C
		static ConfigRogueResEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEffectById.CreateStaticDefaultValue), new Action(ConfigRogueResEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x0600323B RID: 12859 RVA: 0x00178E5C File Offset: 0x0017705C
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

		// Token: 0x0600323C RID: 12860 RVA: 0x00178EDB File Offset: 0x001770DB
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEffectById.LogPair = null;
			ConfigRogueResEffectById.HandleId = 0;
		}

		// Token: 0x0600323D RID: 12861 RVA: 0x00178EE9 File Offset: 0x001770E9
		public static void Init()
		{
			ConfigRogueResEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEffectById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEffect` where Id=?");
		}

		// Token: 0x0600323E RID: 12862 RVA: 0x00178F04 File Offset: 0x00177104
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

		// Token: 0x04003A6A RID: 14954
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A6B RID: 14955
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A6C RID: 14956
		private const string TABLE = "RogueResEffect";

		// Token: 0x04003A6D RID: 14957
		private const string COMMAND = "select BinData from `RogueResEffect` where Id=?";

		// Token: 0x04003A6E RID: 14958
		private const string KEY_PREFIX = "RogueResEffectById";

		// Token: 0x04003A6F RID: 14959
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A70 RID: 14960
		private static int HandleId;
	}
}
