using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000456 RID: 1110
	public class ConfigInfrV2TreeBuildById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A0E RID: 6670 RVA: 0x000F057C File Offset: 0x000EE77C
		static ConfigInfrV2TreeBuildById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrV2TreeBuildById.CreateStaticDefaultValue), new Action(ConfigInfrV2TreeBuildById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x000F059C File Offset: 0x000EE79C
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrV2TreeBuildById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrV2TreeBuildById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_villageinfr.db"),
				new ValueTuple<string, object>("文件", "j.基建V2.xlsx"),
				new ValueTuple<string, object>("表名", "InfrV2TreeBuild"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrV2TreeBuild` where Id=?")
			});
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x000F061B File Offset: 0x000EE81B
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrV2TreeBuildById.LogPair = null;
			ConfigInfrV2TreeBuildById.HandleId = 0;
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x000F0629 File Offset: 0x000EE829
		public static void Init()
		{
			ConfigInfrV2TreeBuildById.HandleId = ConfigCommon.InitDataStatement(ConfigInfrV2TreeBuildById.HandleId, "db_villageinfr.db", "select BinData from `InfrV2TreeBuild` where Id=?");
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x000F0644 File Offset: 0x000EE844
		public static InfrV2TreeBuild? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrV2TreeBuildById.HandleId, ConfigInfrV2TreeBuildById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrV2TreeBuildById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfrV2TreeBuild?(InfrV2TreeBuild.GetRootAsInfrV2TreeBuild(configBuffer));
				}
			}
			ConfigInfrV2TreeBuildById.LogPair.Clear();
			ConfigInfrV2TreeBuildById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInfrV2TreeBuildById.HandleId, 1, p0Id, ConfigInfrV2TreeBuildById.LogPair) || ConfigCommon.Step(ConfigInfrV2TreeBuildById.HandleId, true, ConfigInfrV2TreeBuildById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfrV2TreeBuildById.HandleId, ConfigInfrV2TreeBuildById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrV2TreeBuildById.HandleId, 0, ConfigInfrV2TreeBuildById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfrV2TreeBuildById.HandleId, ConfigInfrV2TreeBuildById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfrV2TreeBuild rootAsInfrV2TreeBuild = InfrV2TreeBuild.GetRootAsInfrV2TreeBuild(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrV2TreeBuildById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfrV2TreeBuildById.HandleId, ConfigInfrV2TreeBuildById.LogPair);
			return new InfrV2TreeBuild?(rootAsInfrV2TreeBuild);
		}

		// Token: 0x04001E3E RID: 7742
		private const string DB = "db_villageinfr.db";

		// Token: 0x04001E3F RID: 7743
		private const string FILE = "j.基建V2.xlsx";

		// Token: 0x04001E40 RID: 7744
		private const string TABLE = "InfrV2TreeBuild";

		// Token: 0x04001E41 RID: 7745
		private const string COMMAND = "select BinData from `InfrV2TreeBuild` where Id=?";

		// Token: 0x04001E42 RID: 7746
		private const string KEY_PREFIX = "InfrV2TreeBuildById";

		// Token: 0x04001E43 RID: 7747
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E44 RID: 7748
		private static int HandleId;
	}
}
