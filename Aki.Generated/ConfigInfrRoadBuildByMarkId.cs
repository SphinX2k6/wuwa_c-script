using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000435 RID: 1077
	public class ConfigInfrRoadBuildByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001947 RID: 6471 RVA: 0x000E872C File Offset: 0x000E692C
		static ConfigInfrRoadBuildByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrRoadBuildByMarkId.CreateStaticDefaultValue), new Action(ConfigInfrRoadBuildByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x000E874C File Offset: 0x000E694C
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrRoadBuildByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrRoadBuildByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建.xlsx"),
				new ValueTuple<string, object>("表名", "InfrRoadBuild"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrRoadBuild` where MarkId=?")
			});
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x000E87CB File Offset: 0x000E69CB
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrRoadBuildByMarkId.LogPair = null;
			ConfigInfrRoadBuildByMarkId.HandleId = 0;
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x000E87D9 File Offset: 0x000E69D9
		public static void Init()
		{
			ConfigInfrRoadBuildByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigInfrRoadBuildByMarkId.HandleId, "db_infrastructure.db", "select BinData from `InfrRoadBuild` where MarkId=?");
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x000E87F4 File Offset: 0x000E69F4
		public static InfrRoadBuild? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrRoadBuildByMarkId.HandleId, ConfigInfrRoadBuildByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrRoadBuildByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfrRoadBuild?(InfrRoadBuild.GetRootAsInfrRoadBuild(configBuffer));
				}
			}
			ConfigInfrRoadBuildByMarkId.LogPair.Clear();
			ConfigInfrRoadBuildByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigInfrRoadBuildByMarkId.HandleId, 1, p0MarkId, ConfigInfrRoadBuildByMarkId.LogPair) || ConfigCommon.Step(ConfigInfrRoadBuildByMarkId.HandleId, true, ConfigInfrRoadBuildByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfrRoadBuildByMarkId.HandleId, ConfigInfrRoadBuildByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrRoadBuildByMarkId.HandleId, 0, ConfigInfrRoadBuildByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfrRoadBuildByMarkId.HandleId, ConfigInfrRoadBuildByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfrRoadBuild rootAsInfrRoadBuild = InfrRoadBuild.GetRootAsInfrRoadBuild(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrRoadBuildByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfrRoadBuildByMarkId.HandleId, ConfigInfrRoadBuildByMarkId.LogPair);
			return new InfrRoadBuild?(rootAsInfrRoadBuild);
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x000E896C File Offset: 0x000E6B6C
		[NullableContext(2)]
		public static IReadOnlyList<InfrRoadBuild> GetConfigList(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrRoadBuildByMarkId.HandleId, ConfigInfrRoadBuildByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrRoadBuildByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				IReadOnlyList<InfrRoadBuild> readOnlyList = (IReadOnlyList<InfrRoadBuild>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigInfrRoadBuildByMarkId.LogPair.Clear();
			ConfigInfrRoadBuildByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigInfrRoadBuildByMarkId.HandleId, 1, p0MarkId, ConfigInfrRoadBuildByMarkId.LogPair))
			{
				ConfigCommon.Reset(ConfigInfrRoadBuildByMarkId.HandleId, ConfigInfrRoadBuildByMarkId.LogPair);
				return null;
			}
			List<InfrRoadBuild> list = new List<InfrRoadBuild>();
			while (ConfigCommon.Step(ConfigInfrRoadBuildByMarkId.HandleId, false, ConfigInfrRoadBuildByMarkId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrRoadBuildByMarkId.HandleId, 0, ConfigInfrRoadBuildByMarkId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInfrRoadBuildByMarkId.HandleId, ConfigInfrRoadBuildByMarkId.LogPair);
					return null;
				}
				InfrRoadBuild rootAsInfrRoadBuild = InfrRoadBuild.GetRootAsInfrRoadBuild(new ByteBuffer(item2));
				list.Add(rootAsInfrRoadBuild);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrRoadBuildByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigInfrRoadBuildByMarkId.HandleId, ConfigInfrRoadBuildByMarkId.LogPair);
			return list;
		}

		// Token: 0x04001D57 RID: 7511
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D58 RID: 7512
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001D59 RID: 7513
		private const string TABLE = "InfrRoadBuild";

		// Token: 0x04001D5A RID: 7514
		private const string COMMAND = "select BinData from `InfrRoadBuild` where MarkId=?";

		// Token: 0x04001D5B RID: 7515
		private const string KEY_PREFIX = "InfrRoadBuildByMarkId";

		// Token: 0x04001D5C RID: 7516
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D5D RID: 7517
		private static int HandleId;
	}
}
