using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002BB RID: 699
	public class ConfigExploreTypeByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001067 RID: 4199 RVA: 0x000B9AC4 File Offset: 0x000B7CC4
		static ConfigExploreTypeByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreTypeByType.CreateStaticDefaultValue), new Action(ConfigExploreTypeByType.ResetStaticDefaultValue));
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x000B9AE4 File Offset: 0x000B7CE4
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreTypeByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreTypeByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_explore_progress.db"),
				new ValueTuple<string, object>("文件", "t.探索度.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreType"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreType` where ExploreTypeKey=?")
			});
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x000B9B63 File Offset: 0x000B7D63
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreTypeByType.LogPair = null;
			ConfigExploreTypeByType.HandleId = 0;
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x000B9B71 File Offset: 0x000B7D71
		public static void Init()
		{
			ConfigExploreTypeByType.HandleId = ConfigCommon.InitDataStatement(ConfigExploreTypeByType.HandleId, "db_explore_progress.db", "select BinData from `ExploreType` where ExploreTypeKey=?");
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x000B9B8C File Offset: 0x000B7D8C
		public static ExploreType? GetConfig(int p0ExploreTypeKey, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreTypeByType.HandleId, ConfigExploreTypeByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreTypeByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ExploreTypeKey);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ExploreType?(ExploreType.GetRootAsExploreType(configBuffer));
				}
			}
			ConfigExploreTypeByType.LogPair.Clear();
			ConfigExploreTypeByType.LogPair.Add(new ValueTuple<string, object>("ExploreTypeKey", p0ExploreTypeKey));
			if (!ConfigCommon.BindInt(ConfigExploreTypeByType.HandleId, 1, p0ExploreTypeKey, ConfigExploreTypeByType.LogPair) || ConfigCommon.Step(ConfigExploreTypeByType.HandleId, true, ConfigExploreTypeByType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExploreTypeByType.HandleId, ConfigExploreTypeByType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreTypeByType.HandleId, 0, ConfigExploreTypeByType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExploreTypeByType.HandleId, ConfigExploreTypeByType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExploreType rootAsExploreType = ExploreType.GetRootAsExploreType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreTypeByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ExploreTypeKey);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExploreTypeByType.HandleId, ConfigExploreTypeByType.LogPair);
			return new ExploreType?(rootAsExploreType);
		}

		// Token: 0x04001301 RID: 4865
		private const string DB = "db_explore_progress.db";

		// Token: 0x04001302 RID: 4866
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x04001303 RID: 4867
		private const string TABLE = "ExploreType";

		// Token: 0x04001304 RID: 4868
		private const string COMMAND = "select BinData from `ExploreType` where ExploreTypeKey=?";

		// Token: 0x04001305 RID: 4869
		private const string KEY_PREFIX = "ExploreTypeByType";

		// Token: 0x04001306 RID: 4870
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001307 RID: 4871
		private static int HandleId;
	}
}
