using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200044A RID: 1098
	public class ConfigInfrRoadBuildById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019C5 RID: 6597 RVA: 0x000EEC37 File Offset: 0x000ECE37
		static ConfigInfrRoadBuildById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrRoadBuildById.CreateStaticDefaultValue), new Action(ConfigInfrRoadBuildById.ResetStaticDefaultValue));
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x000EEC58 File Offset: 0x000ECE58
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

		// Token: 0x060019C7 RID: 6599 RVA: 0x000EECD7 File Offset: 0x000ECED7
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrRoadBuildById.LogPair = null;
			ConfigInfrRoadBuildById.HandleId = 0;
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x000EECE5 File Offset: 0x000ECEE5
		public static void Init()
		{
			ConfigInfrRoadBuildById.HandleId = ConfigCommon.InitDataStatement(ConfigInfrRoadBuildById.HandleId, "db_infrastructure.db", "select BinData from `InfrRoadBuild` where Id=?");
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x000EED00 File Offset: 0x000ECF00
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

		// Token: 0x04001DEA RID: 7658
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001DEB RID: 7659
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001DEC RID: 7660
		private const string TABLE = "InfrRoadBuild";

		// Token: 0x04001DED RID: 7661
		private const string COMMAND = "select BinData from `InfrRoadBuild` where Id=?";

		// Token: 0x04001DEE RID: 7662
		private const string KEY_PREFIX = "InfrRoadBuildById";

		// Token: 0x04001DEF RID: 7663
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DF0 RID: 7664
		private static int HandleId;
	}
}
