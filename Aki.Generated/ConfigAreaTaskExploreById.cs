using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000AC RID: 172
	public class ConfigAreaTaskExploreById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000409 RID: 1033 RVA: 0x00070827 File Offset: 0x0006EA27
		static ConfigAreaTaskExploreById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaTaskExploreById.CreateStaticDefaultValue), new Action(ConfigAreaTaskExploreById.ResetStaticDefaultValue));
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00070848 File Offset: 0x0006EA48
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaTaskExploreById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaTaskExploreById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_explore_progress.db"),
				new ValueTuple<string, object>("文件", "t.探索度.xlsx"),
				new ValueTuple<string, object>("表名", "AreaTaskExplore"),
				new ValueTuple<string, object>("语句", "select BinData from `AreaTaskExplore` where Id=?")
			});
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000708C7 File Offset: 0x0006EAC7
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaTaskExploreById.LogPair = null;
			ConfigAreaTaskExploreById.HandleId = 0;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x000708D5 File Offset: 0x0006EAD5
		public static void Init()
		{
			ConfigAreaTaskExploreById.HandleId = ConfigCommon.InitDataStatement(ConfigAreaTaskExploreById.HandleId, "db_explore_progress.db", "select BinData from `AreaTaskExplore` where Id=?");
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x000708F0 File Offset: 0x0006EAF0
		public static AreaTaskExplore? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaTaskExploreById.HandleId, ConfigAreaTaskExploreById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaTaskExploreById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AreaTaskExplore?(AreaTaskExplore.GetRootAsAreaTaskExplore(configBuffer));
				}
			}
			ConfigAreaTaskExploreById.LogPair.Clear();
			ConfigAreaTaskExploreById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAreaTaskExploreById.HandleId, 1, p0Id, ConfigAreaTaskExploreById.LogPair) || ConfigCommon.Step(ConfigAreaTaskExploreById.HandleId, true, ConfigAreaTaskExploreById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAreaTaskExploreById.HandleId, ConfigAreaTaskExploreById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaTaskExploreById.HandleId, 0, ConfigAreaTaskExploreById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAreaTaskExploreById.HandleId, ConfigAreaTaskExploreById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AreaTaskExplore rootAsAreaTaskExplore = AreaTaskExplore.GetRootAsAreaTaskExplore(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaTaskExploreById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAreaTaskExploreById.HandleId, ConfigAreaTaskExploreById.LogPair);
			return new AreaTaskExplore?(rootAsAreaTaskExplore);
		}

		// Token: 0x04000498 RID: 1176
		private const string DB = "db_explore_progress.db";

		// Token: 0x04000499 RID: 1177
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x0400049A RID: 1178
		private const string TABLE = "AreaTaskExplore";

		// Token: 0x0400049B RID: 1179
		private const string COMMAND = "select BinData from `AreaTaskExplore` where Id=?";

		// Token: 0x0400049C RID: 1180
		private const string KEY_PREFIX = "AreaTaskExploreById";

		// Token: 0x0400049D RID: 1181
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400049E RID: 1182
		private static int HandleId;
	}
}
