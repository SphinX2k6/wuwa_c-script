using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002B3 RID: 691
	public class ConfigExploreRouletteReplaceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001037 RID: 4151 RVA: 0x000B8A9F File Offset: 0x000B6C9F
		static ConfigExploreRouletteReplaceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreRouletteReplaceById.CreateStaticDefaultValue), new Action(ConfigExploreRouletteReplaceById.ResetStaticDefaultValue));
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x000B8AC0 File Offset: 0x000B6CC0
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreRouletteReplaceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreRouletteReplaceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_explore_skill.db"),
				new ValueTuple<string, object>("文件", "t.探索工具.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreRouletteReplace"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreRouletteReplace` where Id=?")
			});
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x000B8B3F File Offset: 0x000B6D3F
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreRouletteReplaceById.LogPair = null;
			ConfigExploreRouletteReplaceById.HandleId = 0;
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x000B8B4D File Offset: 0x000B6D4D
		public static void Init()
		{
			ConfigExploreRouletteReplaceById.HandleId = ConfigCommon.InitDataStatement(ConfigExploreRouletteReplaceById.HandleId, "db_explore_skill.db", "select BinData from `ExploreRouletteReplace` where Id=?");
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x000B8B68 File Offset: 0x000B6D68
		public static ExploreRouletteReplace? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreRouletteReplaceById.HandleId, ConfigExploreRouletteReplaceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreRouletteReplaceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ExploreRouletteReplace?(ExploreRouletteReplace.GetRootAsExploreRouletteReplace(configBuffer));
				}
			}
			ConfigExploreRouletteReplaceById.LogPair.Clear();
			ConfigExploreRouletteReplaceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigExploreRouletteReplaceById.HandleId, 1, p0Id, ConfigExploreRouletteReplaceById.LogPair) || ConfigCommon.Step(ConfigExploreRouletteReplaceById.HandleId, true, ConfigExploreRouletteReplaceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExploreRouletteReplaceById.HandleId, ConfigExploreRouletteReplaceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreRouletteReplaceById.HandleId, 0, ConfigExploreRouletteReplaceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExploreRouletteReplaceById.HandleId, ConfigExploreRouletteReplaceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExploreRouletteReplace rootAsExploreRouletteReplace = ExploreRouletteReplace.GetRootAsExploreRouletteReplace(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreRouletteReplaceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExploreRouletteReplaceById.HandleId, ConfigExploreRouletteReplaceById.LogPair);
			return new ExploreRouletteReplace?(rootAsExploreRouletteReplace);
		}

		// Token: 0x040012C9 RID: 4809
		private const string DB = "db_explore_skill.db";

		// Token: 0x040012CA RID: 4810
		private const string FILE = "t.探索工具.xlsx";

		// Token: 0x040012CB RID: 4811
		private const string TABLE = "ExploreRouletteReplace";

		// Token: 0x040012CC RID: 4812
		private const string COMMAND = "select BinData from `ExploreRouletteReplace` where Id=?";

		// Token: 0x040012CD RID: 4813
		private const string KEY_PREFIX = "ExploreRouletteReplaceById";

		// Token: 0x040012CE RID: 4814
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012CF RID: 4815
		private static int HandleId;
	}
}
