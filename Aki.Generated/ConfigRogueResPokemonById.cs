using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200086D RID: 2157
	public class ConfigRogueResPokemonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032A0 RID: 12960 RVA: 0x0017B34C File Offset: 0x0017954C
		static ConfigRogueResPokemonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResPokemonById.CreateStaticDefaultValue), new Action(ConfigRogueResPokemonById.ResetStaticDefaultValue));
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x0017B36C File Offset: 0x0017956C
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResPokemonById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResPokemonById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResPokemon"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResPokemon` where Id=?")
			});
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x0017B3EB File Offset: 0x001795EB
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResPokemonById.LogPair = null;
			ConfigRogueResPokemonById.HandleId = 0;
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x0017B3F9 File Offset: 0x001795F9
		public static void Init()
		{
			ConfigRogueResPokemonById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResPokemonById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResPokemon` where Id=?");
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x0017B414 File Offset: 0x00179614
		public static RogueResPokemon? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResPokemonById.HandleId, ConfigRogueResPokemonById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResPokemonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResPokemon?(RogueResPokemon.GetRootAsRogueResPokemon(configBuffer));
				}
			}
			ConfigRogueResPokemonById.LogPair.Clear();
			ConfigRogueResPokemonById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResPokemonById.HandleId, 1, p0Id, ConfigRogueResPokemonById.LogPair) || ConfigCommon.Step(ConfigRogueResPokemonById.HandleId, true, ConfigRogueResPokemonById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResPokemonById.HandleId, ConfigRogueResPokemonById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResPokemonById.HandleId, 0, ConfigRogueResPokemonById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResPokemonById.HandleId, ConfigRogueResPokemonById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResPokemon rootAsRogueResPokemon = RogueResPokemon.GetRootAsRogueResPokemon(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResPokemonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResPokemonById.HandleId, ConfigRogueResPokemonById.LogPair);
			return new RogueResPokemon?(rootAsRogueResPokemon);
		}

		// Token: 0x04003AE1 RID: 15073
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003AE2 RID: 15074
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003AE3 RID: 15075
		private const string TABLE = "RogueResPokemon";

		// Token: 0x04003AE4 RID: 15076
		private const string COMMAND = "select BinData from `RogueResPokemon` where Id=?";

		// Token: 0x04003AE5 RID: 15077
		private const string KEY_PREFIX = "RogueResPokemonById";

		// Token: 0x04003AE6 RID: 15078
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AE7 RID: 15079
		private static int HandleId;
	}
}
