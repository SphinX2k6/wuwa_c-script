using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000457 RID: 1111
	public class ConfigInfrV2TreeBuildByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A14 RID: 6676 RVA: 0x000F07C4 File Offset: 0x000EE9C4
		static ConfigInfrV2TreeBuildByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrV2TreeBuildByMarkId.CreateStaticDefaultValue), new Action(ConfigInfrV2TreeBuildByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x000F07E4 File Offset: 0x000EE9E4
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrV2TreeBuildByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrV2TreeBuildByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_villageinfr.db"),
				new ValueTuple<string, object>("文件", "j.基建V2.xlsx"),
				new ValueTuple<string, object>("表名", "InfrV2TreeBuild"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrV2TreeBuild` where MarkId=?")
			});
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x000F0863 File Offset: 0x000EEA63
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrV2TreeBuildByMarkId.LogPair = null;
			ConfigInfrV2TreeBuildByMarkId.HandleId = 0;
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x000F0871 File Offset: 0x000EEA71
		public static void Init()
		{
			ConfigInfrV2TreeBuildByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigInfrV2TreeBuildByMarkId.HandleId, "db_villageinfr.db", "select BinData from `InfrV2TreeBuild` where MarkId=?");
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x000F088C File Offset: 0x000EEA8C
		public static InfrV2TreeBuild? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrV2TreeBuildByMarkId.HandleId, ConfigInfrV2TreeBuildByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrV2TreeBuildByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfrV2TreeBuild?(InfrV2TreeBuild.GetRootAsInfrV2TreeBuild(configBuffer));
				}
			}
			ConfigInfrV2TreeBuildByMarkId.LogPair.Clear();
			ConfigInfrV2TreeBuildByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigInfrV2TreeBuildByMarkId.HandleId, 1, p0MarkId, ConfigInfrV2TreeBuildByMarkId.LogPair) || ConfigCommon.Step(ConfigInfrV2TreeBuildByMarkId.HandleId, true, ConfigInfrV2TreeBuildByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfrV2TreeBuildByMarkId.HandleId, ConfigInfrV2TreeBuildByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrV2TreeBuildByMarkId.HandleId, 0, ConfigInfrV2TreeBuildByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfrV2TreeBuildByMarkId.HandleId, ConfigInfrV2TreeBuildByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfrV2TreeBuild rootAsInfrV2TreeBuild = InfrV2TreeBuild.GetRootAsInfrV2TreeBuild(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrV2TreeBuildByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfrV2TreeBuildByMarkId.HandleId, ConfigInfrV2TreeBuildByMarkId.LogPair);
			return new InfrV2TreeBuild?(rootAsInfrV2TreeBuild);
		}

		// Token: 0x04001E45 RID: 7749
		private const string DB = "db_villageinfr.db";

		// Token: 0x04001E46 RID: 7750
		private const string FILE = "j.基建V2.xlsx";

		// Token: 0x04001E47 RID: 7751
		private const string TABLE = "InfrV2TreeBuild";

		// Token: 0x04001E48 RID: 7752
		private const string COMMAND = "select BinData from `InfrV2TreeBuild` where MarkId=?";

		// Token: 0x04001E49 RID: 7753
		private const string KEY_PREFIX = "InfrV2TreeBuildByMarkId";

		// Token: 0x04001E4A RID: 7754
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E4B RID: 7755
		private static int HandleId;
	}
}
