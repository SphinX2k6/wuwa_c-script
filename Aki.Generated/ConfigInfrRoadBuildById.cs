using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000434 RID: 1076
	public class ConfigInfrRoadBuildById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001941 RID: 6465 RVA: 0x000E84E3 File Offset: 0x000E66E3
		static ConfigInfrRoadBuildById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrRoadBuildById.CreateStaticDefaultValue), new Action(ConfigInfrRoadBuildById.ResetStaticDefaultValue));
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x000E8504 File Offset: 0x000E6704
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrRoadBuildById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrRoadBuildById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建.xlsx"),
				new ValueTuple<string, object>("表名", "InfrRoadBuild"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrRoadBuild` where Id=?")
			});
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x000E8583 File Offset: 0x000E6783
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrRoadBuildById.LogPair = null;
			ConfigInfrRoadBuildById.HandleId = 0;
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x000E8591 File Offset: 0x000E6791
		public static void Init()
		{
			ConfigInfrRoadBuildById.HandleId = ConfigCommon.InitDataStatement(ConfigInfrRoadBuildById.HandleId, "db_infrastructure.db", "select BinData from `InfrRoadBuild` where Id=?");
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x000E85AC File Offset: 0x000E67AC
		public static InfrRoadBuild? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrRoadBuildById.HandleId, ConfigInfrRoadBuildById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrRoadBuildById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfrRoadBuild?(InfrRoadBuild.GetRootAsInfrRoadBuild(configBuffer));
				}
			}
			ConfigInfrRoadBuildById.LogPair.Clear();
			ConfigInfrRoadBuildById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInfrRoadBuildById.HandleId, 1, p0Id, ConfigInfrRoadBuildById.LogPair) || ConfigCommon.Step(ConfigInfrRoadBuildById.HandleId, true, ConfigInfrRoadBuildById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfrRoadBuildById.HandleId, ConfigInfrRoadBuildById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrRoadBuildById.HandleId, 0, ConfigInfrRoadBuildById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfrRoadBuildById.HandleId, ConfigInfrRoadBuildById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfrRoadBuild rootAsInfrRoadBuild = InfrRoadBuild.GetRootAsInfrRoadBuild(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrRoadBuildById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfrRoadBuildById.HandleId, ConfigInfrRoadBuildById.LogPair);
			return new InfrRoadBuild?(rootAsInfrRoadBuild);
		}

		// Token: 0x04001D50 RID: 7504
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D51 RID: 7505
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001D52 RID: 7506
		private const string TABLE = "InfrRoadBuild";

		// Token: 0x04001D53 RID: 7507
		private const string COMMAND = "select BinData from `InfrRoadBuild` where Id=?";

		// Token: 0x04001D54 RID: 7508
		private const string KEY_PREFIX = "InfrRoadBuildById";

		// Token: 0x04001D55 RID: 7509
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D56 RID: 7510
		private static int HandleId;
	}
}
