using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000321 RID: 801
	public class ConfigFloroRanchRarityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012CB RID: 4811 RVA: 0x000C3A0B File Offset: 0x000C1C0B
		static ConfigFloroRanchRarityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchRarityById.CreateStaticDefaultValue), new Action(ConfigFloroRanchRarityById.ResetStaticDefaultValue));
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x000C3A2C File Offset: 0x000C1C2C
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchRarityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchRarityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchRarity"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchRarity` where Id=?")
			});
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x000C3AAB File Offset: 0x000C1CAB
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchRarityById.LogPair = null;
			ConfigFloroRanchRarityById.HandleId = 0;
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x000C3AB9 File Offset: 0x000C1CB9
		public static void Init()
		{
			ConfigFloroRanchRarityById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchRarityById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchRarity` where Id=?");
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x000C3AD4 File Offset: 0x000C1CD4
		public static FloroRanchRarity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchRarityById.HandleId, ConfigFloroRanchRarityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchRarityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchRarity?(FloroRanchRarity.GetRootAsFloroRanchRarity(configBuffer));
				}
			}
			ConfigFloroRanchRarityById.LogPair.Clear();
			ConfigFloroRanchRarityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchRarityById.HandleId, 1, p0Id, ConfigFloroRanchRarityById.LogPair) || ConfigCommon.Step(ConfigFloroRanchRarityById.HandleId, true, ConfigFloroRanchRarityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchRarityById.HandleId, ConfigFloroRanchRarityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchRarityById.HandleId, 0, ConfigFloroRanchRarityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchRarityById.HandleId, ConfigFloroRanchRarityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchRarity rootAsFloroRanchRarity = FloroRanchRarity.GetRootAsFloroRanchRarity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchRarityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchRarityById.HandleId, ConfigFloroRanchRarityById.LogPair);
			return new FloroRanchRarity?(rootAsFloroRanchRarity);
		}

		// Token: 0x040015CB RID: 5579
		private const string DB = "db_flororanch.db";

		// Token: 0x040015CC RID: 5580
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040015CD RID: 5581
		private const string TABLE = "FloroRanchRarity";

		// Token: 0x040015CE RID: 5582
		private const string COMMAND = "select BinData from `FloroRanchRarity` where Id=?";

		// Token: 0x040015CF RID: 5583
		private const string KEY_PREFIX = "FloroRanchRarityById";

		// Token: 0x040015D0 RID: 5584
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015D1 RID: 5585
		private static int HandleId;
	}
}
