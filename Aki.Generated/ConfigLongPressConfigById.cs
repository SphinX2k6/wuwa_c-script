using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004EA RID: 1258
	public class ConfigLongPressConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D87 RID: 7559 RVA: 0x001001D4 File Offset: 0x000FE3D4
		static ConfigLongPressConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLongPressConfigById.CreateStaticDefaultValue), new Action(ConfigLongPressConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x001001F4 File Offset: 0x000FE3F4
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

		// Token: 0x06001D89 RID: 7561 RVA: 0x00100273 File Offset: 0x000FE473
		public static void ResetStaticDefaultValue()
		{
			ConfigLongPressConfigById.LogPair = null;
			ConfigLongPressConfigById.HandleId = 0;
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x00100281 File Offset: 0x000FE481
		public static void Init()
		{
			ConfigLongPressConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigLongPressConfigById.HandleId, "db_longpress_config.db", "select BinData from `LongPressConfig` where Id = ?");
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x0010029C File Offset: 0x000FE49C
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

		// Token: 0x0400224A RID: 8778
		private const string DB = "db_longpress_config.db";

		// Token: 0x0400224B RID: 8779
		private const string FILE = "c.长按组件配置.xlsx";

		// Token: 0x0400224C RID: 8780
		private const string TABLE = "LongPressConfig";

		// Token: 0x0400224D RID: 8781
		private const string COMMAND = "select BinData from `LongPressConfig` where Id = ?";

		// Token: 0x0400224E RID: 8782
		private const string KEY_PREFIX = "LongPressConfigById";

		// Token: 0x0400224F RID: 8783
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002250 RID: 8784
		private static int HandleId;
	}
}
