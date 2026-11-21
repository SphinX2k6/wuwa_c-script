using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A6E RID: 2670
	public class ConfigSurvivorsDeathrattleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EA8 RID: 16040 RVA: 0x001BEE54 File Offset: 0x001BD054
		static ConfigSurvivorsDeathrattleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsDeathrattleById.CreateStaticDefaultValue), new Action(ConfigSurvivorsDeathrattleById.ResetStaticDefaultValue));
		}

		// Token: 0x06003EA9 RID: 16041 RVA: 0x001BEE74 File Offset: 0x001BD074
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

		// Token: 0x06003EAA RID: 16042 RVA: 0x001BEEF3 File Offset: 0x001BD0F3
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsDeathrattleById.LogPair = null;
			ConfigSurvivorsDeathrattleById.HandleId = 0;
		}

		// Token: 0x06003EAB RID: 16043 RVA: 0x001BEF01 File Offset: 0x001BD101
		public static void Init()
		{
			ConfigSurvivorsDeathrattleById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsDeathrattleById.HandleId, "db_survivors.db", "select BinData from `SurvivorsDeathrattle` where Id=?");
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x001BEF1C File Offset: 0x001BD11C
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

		// Token: 0x040048E8 RID: 18664
		private const string DB = "db_survivors.db";

		// Token: 0x040048E9 RID: 18665
		private const string FILE = "x.幸存者_怪物.xlsx";

		// Token: 0x040048EA RID: 18666
		private const string TABLE = "SurvivorsDeathrattle";

		// Token: 0x040048EB RID: 18667
		private const string COMMAND = "select BinData from `SurvivorsDeathrattle` where Id=?";

		// Token: 0x040048EC RID: 18668
		private const string KEY_PREFIX = "SurvivorsDeathrattleById";

		// Token: 0x040048ED RID: 18669
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048EE RID: 18670
		private static int HandleId;
	}
}
