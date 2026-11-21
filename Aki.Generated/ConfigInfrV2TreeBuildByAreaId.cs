using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000455 RID: 1109
	public class ConfigInfrV2TreeBuildByAreaId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A08 RID: 6664 RVA: 0x000F0333 File Offset: 0x000EE533
		static ConfigInfrV2TreeBuildByAreaId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrV2TreeBuildByAreaId.CreateStaticDefaultValue), new Action(ConfigInfrV2TreeBuildByAreaId.ResetStaticDefaultValue));
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x000F0354 File Offset: 0x000EE554
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

		// Token: 0x06001A0A RID: 6666 RVA: 0x000F03D3 File Offset: 0x000EE5D3
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrV2TreeBuildByAreaId.LogPair = null;
			ConfigInfrV2TreeBuildByAreaId.HandleId = 0;
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x000F03E1 File Offset: 0x000EE5E1
		public static void Init()
		{
			ConfigInfrV2TreeBuildByAreaId.HandleId = ConfigCommon.InitDataStatement(ConfigInfrV2TreeBuildByAreaId.HandleId, "db_villageinfr.db", "select BinData from `InfrV2TreeBuild` where AreaId=?");
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x000F03FC File Offset: 0x000EE5FC
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

		// Token: 0x04001E37 RID: 7735
		private const string DB = "db_villageinfr.db";

		// Token: 0x04001E38 RID: 7736
		private const string FILE = "j.基建V2.xlsx";

		// Token: 0x04001E39 RID: 7737
		private const string TABLE = "InfrV2TreeBuild";

		// Token: 0x04001E3A RID: 7738
		private const string COMMAND = "select BinData from `InfrV2TreeBuild` where AreaId=?";

		// Token: 0x04001E3B RID: 7739
		private const string KEY_PREFIX = "InfrV2TreeBuildByAreaId";

		// Token: 0x04001E3C RID: 7740
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E3D RID: 7741
		private static int HandleId;
	}
}
