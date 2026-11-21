using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200044B RID: 1099
	public class ConfigInfrRoadBuildByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019CB RID: 6603 RVA: 0x000EEE80 File Offset: 0x000ED080
		static ConfigInfrRoadBuildByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrRoadBuildByMarkId.CreateStaticDefaultValue), new Action(ConfigInfrRoadBuildByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x000EEEA0 File Offset: 0x000ED0A0
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

		// Token: 0x060019CD RID: 6605 RVA: 0x000EEF1F File Offset: 0x000ED11F
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrRoadBuildByMarkId.LogPair = null;
			ConfigInfrRoadBuildByMarkId.HandleId = 0;
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x000EEF2D File Offset: 0x000ED12D
		public static void Init()
		{
			ConfigInfrRoadBuildByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigInfrRoadBuildByMarkId.HandleId, "db_infrastructure.db", "select BinData from `InfrRoadBuild` where MarkId=?");
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x000EEF48 File Offset: 0x000ED148
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

		// Token: 0x060019D0 RID: 6608 RVA: 0x000EF0C0 File Offset: 0x000ED2C0
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

		// Token: 0x04001DF1 RID: 7665
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001DF2 RID: 7666
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001DF3 RID: 7667
		private const string TABLE = "InfrRoadBuild";

		// Token: 0x04001DF4 RID: 7668
		private const string COMMAND = "select BinData from `InfrRoadBuild` where MarkId=?";

		// Token: 0x04001DF5 RID: 7669
		private const string KEY_PREFIX = "InfrRoadBuildByMarkId";

		// Token: 0x04001DF6 RID: 7670
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DF7 RID: 7671
		private static int HandleId;
	}
}
