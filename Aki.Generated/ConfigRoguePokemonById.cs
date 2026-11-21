using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000847 RID: 2119
	public class ConfigRoguePokemonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031BC RID: 12732 RVA: 0x001760D0 File Offset: 0x001742D0
		static ConfigRoguePokemonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoguePokemonById.CreateStaticDefaultValue), new Action(ConfigRoguePokemonById.ResetStaticDefaultValue));
		}

		// Token: 0x060031BD RID: 12733 RVA: 0x001760F0 File Offset: 0x001742F0
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

		// Token: 0x060031BE RID: 12734 RVA: 0x0017616F File Offset: 0x0017436F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoguePokemonById.LogPair = null;
			ConfigRoguePokemonById.HandleId = 0;
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x0017617D File Offset: 0x0017437D
		public static void Init()
		{
			ConfigRoguePokemonById.HandleId = ConfigCommon.InitDataStatement(ConfigRoguePokemonById.HandleId, "db_rogue.db", "select BinData from `RoguePokemon` where Id=?");
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x00176198 File Offset: 0x00174398
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

		// Token: 0x040039D7 RID: 14807
		private const string DB = "db_rogue.db";

		// Token: 0x040039D8 RID: 14808
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x040039D9 RID: 14809
		private const string TABLE = "RoguePokemon";

		// Token: 0x040039DA RID: 14810
		private const string COMMAND = "select BinData from `RoguePokemon` where Id=?";

		// Token: 0x040039DB RID: 14811
		private const string KEY_PREFIX = "RoguePokemonById";

		// Token: 0x040039DC RID: 14812
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039DD RID: 14813
		private static int HandleId;
	}
}
