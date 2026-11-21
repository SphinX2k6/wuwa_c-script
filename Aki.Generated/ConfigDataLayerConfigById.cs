using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000209 RID: 521
	public class ConfigDataLayerConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C39 RID: 3129 RVA: 0x000A258C File Offset: 0x000A078C
		static ConfigDataLayerConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDataLayerConfigById.CreateStaticDefaultValue), new Action(ConfigDataLayerConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x000A25AC File Offset: 0x000A07AC
		public static void CreateStaticDefaultValue()
		{
			ConfigDataLayerConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDataLayerConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_datalayer.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/d.DataLayer/*.csv*"),
				new ValueTuple<string, object>("表名", "DataLayerConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `DataLayerConfig` where Id=?")
			});
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x000A262B File Offset: 0x000A082B
		public static void ResetStaticDefaultValue()
		{
			ConfigDataLayerConfigById.LogPair = null;
			ConfigDataLayerConfigById.HandleId = 0;
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x000A2639 File Offset: 0x000A0839
		public static void Init()
		{
			ConfigDataLayerConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigDataLayerConfigById.HandleId, "db_datalayer.db", "select BinData from `DataLayerConfig` where Id=?");
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x000A2654 File Offset: 0x000A0854
		public static DataLayerConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDataLayerConfigById.HandleId, ConfigDataLayerConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DataLayerConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DataLayerConfig?(DataLayerConfig.GetRootAsDataLayerConfig(configBuffer));
				}
			}
			ConfigDataLayerConfigById.LogPair.Clear();
			ConfigDataLayerConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDataLayerConfigById.HandleId, 1, p0Id, ConfigDataLayerConfigById.LogPair) || ConfigCommon.Step(ConfigDataLayerConfigById.HandleId, true, ConfigDataLayerConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDataLayerConfigById.HandleId, ConfigDataLayerConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDataLayerConfigById.HandleId, 0, ConfigDataLayerConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDataLayerConfigById.HandleId, ConfigDataLayerConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DataLayerConfig rootAsDataLayerConfig = DataLayerConfig.GetRootAsDataLayerConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DataLayerConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDataLayerConfigById.HandleId, ConfigDataLayerConfigById.LogPair);
			return new DataLayerConfig?(rootAsDataLayerConfig);
		}

		// Token: 0x04000E23 RID: 3619
		private const string DB = "db_datalayer.db";

		// Token: 0x04000E24 RID: 3620
		private const string FILE = "k.可视化编辑/c.Csv/d.DataLayer/*.csv*";

		// Token: 0x04000E25 RID: 3621
		private const string TABLE = "DataLayerConfig";

		// Token: 0x04000E26 RID: 3622
		private const string COMMAND = "select BinData from `DataLayerConfig` where Id=?";

		// Token: 0x04000E27 RID: 3623
		private const string KEY_PREFIX = "DataLayerConfigById";

		// Token: 0x04000E28 RID: 3624
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E29 RID: 3625
		private static int HandleId;
	}
}
