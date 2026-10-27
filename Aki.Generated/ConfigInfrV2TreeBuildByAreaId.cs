using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200043F RID: 1087
	public class ConfigInfrV2TreeBuildByAreaId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001984 RID: 6532 RVA: 0x000E9BDF File Offset: 0x000E7DDF
		static ConfigInfrV2TreeBuildByAreaId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrV2TreeBuildByAreaId.CreateStaticDefaultValue), new Action(ConfigInfrV2TreeBuildByAreaId.ResetStaticDefaultValue));
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x000E9C00 File Offset: 0x000E7E00
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrV2TreeBuildByAreaId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrV2TreeBuildByAreaId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_villageinfr.db"),
				new ValueTuple<string, object>("文件", "j.基建V2.xlsx"),
				new ValueTuple<string, object>("表名", "InfrV2TreeBuild"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrV2TreeBuild` where AreaId=?")
			});
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x000E9C7F File Offset: 0x000E7E7F
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrV2TreeBuildByAreaId.LogPair = null;
			ConfigInfrV2TreeBuildByAreaId.HandleId = 0;
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x000E9C8D File Offset: 0x000E7E8D
		public static void Init()
		{
			ConfigInfrV2TreeBuildByAreaId.HandleId = ConfigCommon.InitDataStatement(ConfigInfrV2TreeBuildByAreaId.HandleId, "db_villageinfr.db", "select BinData from `InfrV2TreeBuild` where AreaId=?");
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x000E9CA8 File Offset: 0x000E7EA8
		public static InfrV2TreeBuild? GetConfig(int p0AreaId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrV2TreeBuildByAreaId.HandleId, ConfigInfrV2TreeBuildByAreaId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrV2TreeBuildByAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AreaId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfrV2TreeBuild?(InfrV2TreeBuild.GetRootAsInfrV2TreeBuild(configBuffer));
				}
			}
			ConfigInfrV2TreeBuildByAreaId.LogPair.Clear();
			ConfigInfrV2TreeBuildByAreaId.LogPair.Add(new ValueTuple<string, object>("AreaId", p0AreaId));
			if (!ConfigCommon.BindInt(ConfigInfrV2TreeBuildByAreaId.HandleId, 1, p0AreaId, ConfigInfrV2TreeBuildByAreaId.LogPair) || ConfigCommon.Step(ConfigInfrV2TreeBuildByAreaId.HandleId, true, ConfigInfrV2TreeBuildByAreaId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfrV2TreeBuildByAreaId.HandleId, ConfigInfrV2TreeBuildByAreaId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrV2TreeBuildByAreaId.HandleId, 0, ConfigInfrV2TreeBuildByAreaId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfrV2TreeBuildByAreaId.HandleId, ConfigInfrV2TreeBuildByAreaId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfrV2TreeBuild rootAsInfrV2TreeBuild = InfrV2TreeBuild.GetRootAsInfrV2TreeBuild(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrV2TreeBuildByAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AreaId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfrV2TreeBuildByAreaId.HandleId, ConfigInfrV2TreeBuildByAreaId.LogPair);
			return new InfrV2TreeBuild?(rootAsInfrV2TreeBuild);
		}

		// Token: 0x04001D9D RID: 7581
		private const string DB = "db_villageinfr.db";

		// Token: 0x04001D9E RID: 7582
		private const string FILE = "j.基建V2.xlsx";

		// Token: 0x04001D9F RID: 7583
		private const string TABLE = "InfrV2TreeBuild";

		// Token: 0x04001DA0 RID: 7584
		private const string COMMAND = "select BinData from `InfrV2TreeBuild` where AreaId=?";

		// Token: 0x04001DA1 RID: 7585
		private const string KEY_PREFIX = "InfrV2TreeBuildByAreaId";

		// Token: 0x04001DA2 RID: 7586
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DA3 RID: 7587
		private static int HandleId;
	}
}
