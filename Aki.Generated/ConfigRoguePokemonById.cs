using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200082B RID: 2091
	public class ConfigRoguePokemonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003114 RID: 12564 RVA: 0x0016EDE8 File Offset: 0x0016CFE8
		static ConfigRoguePokemonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoguePokemonById.CreateStaticDefaultValue), new Action(ConfigRoguePokemonById.ResetStaticDefaultValue));
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x0016EE08 File Offset: 0x0016D008
		public static void CreateStaticDefaultValue()
		{
			ConfigRoguePokemonById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoguePokemonById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RoguePokemon"),
				new ValueTuple<string, object>("语句", "select BinData from `RoguePokemon` where Id=?")
			});
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x0016EE87 File Offset: 0x0016D087
		public static void ResetStaticDefaultValue()
		{
			ConfigRoguePokemonById.LogPair = null;
			ConfigRoguePokemonById.HandleId = 0;
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x0016EE95 File Offset: 0x0016D095
		public static void Init()
		{
			ConfigRoguePokemonById.HandleId = ConfigCommon.InitDataStatement(ConfigRoguePokemonById.HandleId, "db_rogue.db", "select BinData from `RoguePokemon` where Id=?");
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x0016EEB0 File Offset: 0x0016D0B0
		public static RoguePokemon? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoguePokemonById.HandleId, ConfigRoguePokemonById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoguePokemonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoguePokemon?(RoguePokemon.GetRootAsRoguePokemon(configBuffer));
				}
			}
			ConfigRoguePokemonById.LogPair.Clear();
			ConfigRoguePokemonById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoguePokemonById.HandleId, 1, p0Id, ConfigRoguePokemonById.LogPair) || ConfigCommon.Step(ConfigRoguePokemonById.HandleId, true, ConfigRoguePokemonById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoguePokemonById.HandleId, ConfigRoguePokemonById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoguePokemonById.HandleId, 0, ConfigRoguePokemonById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoguePokemonById.HandleId, ConfigRoguePokemonById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoguePokemon rootAsRoguePokemon = RoguePokemon.GetRootAsRoguePokemon(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoguePokemonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoguePokemonById.HandleId, ConfigRoguePokemonById.LogPair);
			return new RoguePokemon?(rootAsRoguePokemon);
		}

		// Token: 0x04003913 RID: 14611
		private const string DB = "db_rogue.db";

		// Token: 0x04003914 RID: 14612
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003915 RID: 14613
		private const string TABLE = "RoguePokemon";

		// Token: 0x04003916 RID: 14614
		private const string COMMAND = "select BinData from `RoguePokemon` where Id=?";

		// Token: 0x04003917 RID: 14615
		private const string KEY_PREFIX = "RoguePokemonById";

		// Token: 0x04003918 RID: 14616
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003919 RID: 14617
		private static int HandleId;
	}
}
