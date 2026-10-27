using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200029F RID: 671
	public class ConfigExploreRouletteReplaceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FBF RID: 4031 RVA: 0x000B27DB File Offset: 0x000B09DB
		static ConfigExploreRouletteReplaceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreRouletteReplaceById.CreateStaticDefaultValue), new Action(ConfigExploreRouletteReplaceById.ResetStaticDefaultValue));
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x000B27FC File Offset: 0x000B09FC
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

		// Token: 0x06000FC1 RID: 4033 RVA: 0x000B287B File Offset: 0x000B0A7B
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreRouletteReplaceById.LogPair = null;
			ConfigExploreRouletteReplaceById.HandleId = 0;
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x000B2889 File Offset: 0x000B0A89
		public static void Init()
		{
			ConfigExploreRouletteReplaceById.HandleId = ConfigCommon.InitDataStatement(ConfigExploreRouletteReplaceById.HandleId, "db_explore_skill.db", "select BinData from `ExploreRouletteReplace` where Id=?");
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x000B28A4 File Offset: 0x000B0AA4
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

		// Token: 0x0400123D RID: 4669
		private const string DB = "db_explore_skill.db";

		// Token: 0x0400123E RID: 4670
		private const string FILE = "t.探索工具.xlsx";

		// Token: 0x0400123F RID: 4671
		private const string TABLE = "ExploreRouletteReplace";

		// Token: 0x04001240 RID: 4672
		private const string COMMAND = "select BinData from `ExploreRouletteReplace` where Id=?";

		// Token: 0x04001241 RID: 4673
		private const string KEY_PREFIX = "ExploreRouletteReplaceById";

		// Token: 0x04001242 RID: 4674
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001243 RID: 4675
		private static int HandleId;
	}
}
