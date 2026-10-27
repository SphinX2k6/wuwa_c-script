using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000999 RID: 2457
	public class ConfigSurvivorsDeathrattleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039AA RID: 14762 RVA: 0x0019FAC0 File Offset: 0x0019DCC0
		static ConfigSurvivorsDeathrattleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsDeathrattleById.CreateStaticDefaultValue), new Action(ConfigSurvivorsDeathrattleById.ResetStaticDefaultValue));
		}

		// Token: 0x060039AB RID: 14763 RVA: 0x0019FAE0 File Offset: 0x0019DCE0
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsDeathrattleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsDeathrattleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsDeathrattle"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsDeathrattle` where Id=?")
			});
		}

		// Token: 0x060039AC RID: 14764 RVA: 0x0019FB5F File Offset: 0x0019DD5F
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsDeathrattleById.LogPair = null;
			ConfigSurvivorsDeathrattleById.HandleId = 0;
		}

		// Token: 0x060039AD RID: 14765 RVA: 0x0019FB6D File Offset: 0x0019DD6D
		public static void Init()
		{
			ConfigSurvivorsDeathrattleById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsDeathrattleById.HandleId, "db_survivors.db", "select BinData from `SurvivorsDeathrattle` where Id=?");
		}

		// Token: 0x060039AE RID: 14766 RVA: 0x0019FB88 File Offset: 0x0019DD88
		public static SurvivorsDeathrattle? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsDeathrattleById.HandleId, ConfigSurvivorsDeathrattleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsDeathrattleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsDeathrattle?(SurvivorsDeathrattle.GetRootAsSurvivorsDeathrattle(configBuffer));
				}
			}
			ConfigSurvivorsDeathrattleById.LogPair.Clear();
			ConfigSurvivorsDeathrattleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsDeathrattleById.HandleId, 1, p0Id, ConfigSurvivorsDeathrattleById.LogPair) || ConfigCommon.Step(ConfigSurvivorsDeathrattleById.HandleId, true, ConfigSurvivorsDeathrattleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsDeathrattleById.HandleId, ConfigSurvivorsDeathrattleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsDeathrattleById.HandleId, 0, ConfigSurvivorsDeathrattleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsDeathrattleById.HandleId, ConfigSurvivorsDeathrattleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsDeathrattle rootAsSurvivorsDeathrattle = SurvivorsDeathrattle.GetRootAsSurvivorsDeathrattle(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsDeathrattleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsDeathrattleById.HandleId, ConfigSurvivorsDeathrattleById.LogPair);
			return new SurvivorsDeathrattle?(rootAsSurvivorsDeathrattle);
		}

		// Token: 0x04004315 RID: 17173
		private const string DB = "db_survivors.db";

		// Token: 0x04004316 RID: 17174
		private const string FILE = "x.幸存者_怪物.xlsx";

		// Token: 0x04004317 RID: 17175
		private const string TABLE = "SurvivorsDeathrattle";

		// Token: 0x04004318 RID: 17176
		private const string COMMAND = "select BinData from `SurvivorsDeathrattle` where Id=?";

		// Token: 0x04004319 RID: 17177
		private const string KEY_PREFIX = "SurvivorsDeathrattleById";

		// Token: 0x0400431A RID: 17178
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400431B RID: 17179
		private static int HandleId;
	}
}
