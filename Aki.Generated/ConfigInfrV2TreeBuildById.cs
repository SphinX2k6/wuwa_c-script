using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000440 RID: 1088
	public class ConfigInfrV2TreeBuildById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600198A RID: 6538 RVA: 0x000E9E28 File Offset: 0x000E8028
		static ConfigInfrV2TreeBuildById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrV2TreeBuildById.CreateStaticDefaultValue), new Action(ConfigInfrV2TreeBuildById.ResetStaticDefaultValue));
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x000E9E48 File Offset: 0x000E8048
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

		// Token: 0x0600198C RID: 6540 RVA: 0x000E9EC7 File Offset: 0x000E80C7
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrV2TreeBuildById.LogPair = null;
			ConfigInfrV2TreeBuildById.HandleId = 0;
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x000E9ED5 File Offset: 0x000E80D5
		public static void Init()
		{
			ConfigInfrV2TreeBuildById.HandleId = ConfigCommon.InitDataStatement(ConfigInfrV2TreeBuildById.HandleId, "db_villageinfr.db", "select BinData from `InfrV2TreeBuild` where Id=?");
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x000E9EF0 File Offset: 0x000E80F0
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

		// Token: 0x04001DA4 RID: 7588
		private const string DB = "db_villageinfr.db";

		// Token: 0x04001DA5 RID: 7589
		private const string FILE = "j.基建V2.xlsx";

		// Token: 0x04001DA6 RID: 7590
		private const string TABLE = "InfrV2TreeBuild";

		// Token: 0x04001DA7 RID: 7591
		private const string COMMAND = "select BinData from `InfrV2TreeBuild` where Id=?";

		// Token: 0x04001DA8 RID: 7592
		private const string KEY_PREFIX = "InfrV2TreeBuildById";

		// Token: 0x04001DA9 RID: 7593
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DAA RID: 7594
		private static int HandleId;
	}
}
