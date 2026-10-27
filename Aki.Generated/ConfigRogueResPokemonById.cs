using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000851 RID: 2129
	public class ConfigRogueResPokemonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031F8 RID: 12792 RVA: 0x00174064 File Offset: 0x00172264
		static ConfigRogueResPokemonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResPokemonById.CreateStaticDefaultValue), new Action(ConfigRogueResPokemonById.ResetStaticDefaultValue));
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x00174084 File Offset: 0x00172284
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

		// Token: 0x060031FA RID: 12794 RVA: 0x00174103 File Offset: 0x00172303
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResPokemonById.LogPair = null;
			ConfigRogueResPokemonById.HandleId = 0;
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x00174111 File Offset: 0x00172311
		public static void Init()
		{
			ConfigRogueResPokemonById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResPokemonById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResPokemon` where Id=?");
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x0017412C File Offset: 0x0017232C
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

		// Token: 0x04003A1D RID: 14877
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A1E RID: 14878
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A1F RID: 14879
		private const string TABLE = "RogueResPokemon";

		// Token: 0x04003A20 RID: 14880
		private const string COMMAND = "select BinData from `RogueResPokemon` where Id=?";

		// Token: 0x04003A21 RID: 14881
		private const string KEY_PREFIX = "RogueResPokemonById";

		// Token: 0x04003A22 RID: 14882
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A23 RID: 14883
		private static int HandleId;
	}
}
