using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001F7 RID: 503
	public class ConfigDataLayerConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BCD RID: 3021 RVA: 0x0009C654 File Offset: 0x0009A854
		static ConfigDataLayerConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDataLayerConfigById.CreateStaticDefaultValue), new Action(ConfigDataLayerConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0009C674 File Offset: 0x0009A874
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

		// Token: 0x06000BCF RID: 3023 RVA: 0x0009C6F3 File Offset: 0x0009A8F3
		public static void ResetStaticDefaultValue()
		{
			ConfigDataLayerConfigById.LogPair = null;
			ConfigDataLayerConfigById.HandleId = 0;
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0009C701 File Offset: 0x0009A901
		public static void Init()
		{
			ConfigDataLayerConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigDataLayerConfigById.HandleId, "db_datalayer.db", "select BinData from `DataLayerConfig` where Id=?");
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0009C71C File Offset: 0x0009A91C
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

		// Token: 0x04000DA5 RID: 3493
		private const string DB = "db_datalayer.db";

		// Token: 0x04000DA6 RID: 3494
		private const string FILE = "k.可视化编辑/c.Csv/d.DataLayer/*.csv*";

		// Token: 0x04000DA7 RID: 3495
		private const string TABLE = "DataLayerConfig";

		// Token: 0x04000DA8 RID: 3496
		private const string COMMAND = "select BinData from `DataLayerConfig` where Id=?";

		// Token: 0x04000DA9 RID: 3497
		private const string KEY_PREFIX = "DataLayerConfigById";

		// Token: 0x04000DAA RID: 3498
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DAB RID: 3499
		private static int HandleId;
	}
}
