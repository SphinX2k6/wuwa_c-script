using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000B4 RID: 180
	public class ConfigAreaTaskExploreById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000439 RID: 1081 RVA: 0x000750DB File Offset: 0x000732DB
		static ConfigAreaTaskExploreById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaTaskExploreById.CreateStaticDefaultValue), new Action(ConfigAreaTaskExploreById.ResetStaticDefaultValue));
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000750FC File Offset: 0x000732FC
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

		// Token: 0x0600043B RID: 1083 RVA: 0x0007517B File Offset: 0x0007337B
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaTaskExploreById.LogPair = null;
			ConfigAreaTaskExploreById.HandleId = 0;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00075189 File Offset: 0x00073389
		public static void Init()
		{
			ConfigAreaTaskExploreById.HandleId = ConfigCommon.InitDataStatement(ConfigAreaTaskExploreById.HandleId, "db_explore_progress.db", "select BinData from `AreaTaskExplore` where Id=?");
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000751A4 File Offset: 0x000733A4
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

		// Token: 0x040004D0 RID: 1232
		private const string DB = "db_explore_progress.db";

		// Token: 0x040004D1 RID: 1233
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x040004D2 RID: 1234
		private const string TABLE = "AreaTaskExplore";

		// Token: 0x040004D3 RID: 1235
		private const string COMMAND = "select BinData from `AreaTaskExplore` where Id=?";

		// Token: 0x040004D4 RID: 1236
		private const string KEY_PREFIX = "AreaTaskExploreById";

		// Token: 0x040004D5 RID: 1237
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004D6 RID: 1238
		private static int HandleId;
	}
}
