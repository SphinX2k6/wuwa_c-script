using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000297 RID: 663
	public class ConfigExploreProgressById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F8F RID: 3983 RVA: 0x000B17D7 File Offset: 0x000AF9D7
		static ConfigExploreProgressById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreProgressById.CreateStaticDefaultValue), new Action(ConfigExploreProgressById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x000B17F8 File Offset: 0x000AF9F8
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

		// Token: 0x06000F91 RID: 3985 RVA: 0x000B1877 File Offset: 0x000AFA77
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreProgressById.LogPair = null;
			ConfigExploreProgressById.HandleId = 0;
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x000B1885 File Offset: 0x000AFA85
		public static void Init()
		{
			ConfigExploreProgressById.HandleId = ConfigCommon.InitDataStatement(ConfigExploreProgressById.HandleId, "db_explore_progress.db", "select BinData from `ExploreProgress` where Id=?");
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x000B18A0 File Offset: 0x000AFAA0
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

		// Token: 0x04001205 RID: 4613
		private const string DB = "db_explore_progress.db";

		// Token: 0x04001206 RID: 4614
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x04001207 RID: 4615
		private const string TABLE = "ExploreProgress";

		// Token: 0x04001208 RID: 4616
		private const string COMMAND = "select BinData from `ExploreProgress` where Id=?";

		// Token: 0x04001209 RID: 4617
		private const string KEY_PREFIX = "ExploreProgressById";

		// Token: 0x0400120A RID: 4618
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400120B RID: 4619
		private static int HandleId;
	}
}
