using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002AB RID: 683
	public class ConfigExploreProgressById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001007 RID: 4103 RVA: 0x000B7A9B File Offset: 0x000B5C9B
		static ConfigExploreProgressById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreProgressById.CreateStaticDefaultValue), new Action(ConfigExploreProgressById.ResetStaticDefaultValue));
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x000B7ABC File Offset: 0x000B5CBC
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreProgressById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreProgressById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_explore_progress.db"),
				new ValueTuple<string, object>("文件", "t.探索度.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreProgress"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreProgress` where Id=?")
			});
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x000B7B3B File Offset: 0x000B5D3B
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreProgressById.LogPair = null;
			ConfigExploreProgressById.HandleId = 0;
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x000B7B49 File Offset: 0x000B5D49
		public static void Init()
		{
			ConfigExploreProgressById.HandleId = ConfigCommon.InitDataStatement(ConfigExploreProgressById.HandleId, "db_explore_progress.db", "select BinData from `ExploreProgress` where Id=?");
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x000B7B64 File Offset: 0x000B5D64
		public static ExploreProgress? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreProgressById.HandleId, ConfigExploreProgressById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreProgressById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ExploreProgress?(ExploreProgress.GetRootAsExploreProgress(configBuffer));
				}
			}
			ConfigExploreProgressById.LogPair.Clear();
			ConfigExploreProgressById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigExploreProgressById.HandleId, 1, p0Id, ConfigExploreProgressById.LogPair) || ConfigCommon.Step(ConfigExploreProgressById.HandleId, true, ConfigExploreProgressById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExploreProgressById.HandleId, ConfigExploreProgressById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreProgressById.HandleId, 0, ConfigExploreProgressById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExploreProgressById.HandleId, ConfigExploreProgressById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExploreProgress rootAsExploreProgress = ExploreProgress.GetRootAsExploreProgress(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreProgressById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExploreProgressById.HandleId, ConfigExploreProgressById.LogPair);
			return new ExploreProgress?(rootAsExploreProgress);
		}

		// Token: 0x04001291 RID: 4753
		private const string DB = "db_explore_progress.db";

		// Token: 0x04001292 RID: 4754
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x04001293 RID: 4755
		private const string TABLE = "ExploreProgress";

		// Token: 0x04001294 RID: 4756
		private const string COMMAND = "select BinData from `ExploreProgress` where Id=?";

		// Token: 0x04001295 RID: 4757
		private const string KEY_PREFIX = "ExploreProgressById";

		// Token: 0x04001296 RID: 4758
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001297 RID: 4759
		private static int HandleId;
	}
}
