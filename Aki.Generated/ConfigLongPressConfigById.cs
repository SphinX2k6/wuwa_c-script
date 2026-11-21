using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000500 RID: 1280
	public class ConfigLongPressConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E0B RID: 7691 RVA: 0x00106928 File Offset: 0x00104B28
		static ConfigLongPressConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLongPressConfigById.CreateStaticDefaultValue), new Action(ConfigLongPressConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x00106948 File Offset: 0x00104B48
		public static void CreateStaticDefaultValue()
		{
			ConfigLongPressConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLongPressConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_longpress_config.db"),
				new ValueTuple<string, object>("文件", "c.长按组件配置.xlsx"),
				new ValueTuple<string, object>("表名", "LongPressConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `LongPressConfig` where Id = ?")
			});
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x001069C7 File Offset: 0x00104BC7
		public static void ResetStaticDefaultValue()
		{
			ConfigLongPressConfigById.LogPair = null;
			ConfigLongPressConfigById.HandleId = 0;
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x001069D5 File Offset: 0x00104BD5
		public static void Init()
		{
			ConfigLongPressConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigLongPressConfigById.HandleId, "db_longpress_config.db", "select BinData from `LongPressConfig` where Id = ?");
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x001069F0 File Offset: 0x00104BF0
		public static LongPressConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLongPressConfigById.HandleId, ConfigLongPressConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LongPressConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LongPressConfig?(LongPressConfig.GetRootAsLongPressConfig(configBuffer));
				}
			}
			ConfigLongPressConfigById.LogPair.Clear();
			ConfigLongPressConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLongPressConfigById.HandleId, 1, p0Id, ConfigLongPressConfigById.LogPair) || ConfigCommon.Step(ConfigLongPressConfigById.HandleId, true, ConfigLongPressConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLongPressConfigById.HandleId, ConfigLongPressConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLongPressConfigById.HandleId, 0, ConfigLongPressConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLongPressConfigById.HandleId, ConfigLongPressConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LongPressConfig rootAsLongPressConfig = LongPressConfig.GetRootAsLongPressConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LongPressConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLongPressConfigById.HandleId, ConfigLongPressConfigById.LogPair);
			return new LongPressConfig?(rootAsLongPressConfig);
		}

		// Token: 0x040022E4 RID: 8932
		private const string DB = "db_longpress_config.db";

		// Token: 0x040022E5 RID: 8933
		private const string FILE = "c.长按组件配置.xlsx";

		// Token: 0x040022E6 RID: 8934
		private const string TABLE = "LongPressConfig";

		// Token: 0x040022E7 RID: 8935
		private const string COMMAND = "select BinData from `LongPressConfig` where Id = ?";

		// Token: 0x040022E8 RID: 8936
		private const string KEY_PREFIX = "LongPressConfigById";

		// Token: 0x040022E9 RID: 8937
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022EA RID: 8938
		private static int HandleId;
	}
}
