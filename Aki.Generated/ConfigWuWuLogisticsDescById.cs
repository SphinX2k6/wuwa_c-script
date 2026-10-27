using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AA2 RID: 2722
	public class ConfigWuWuLogisticsDescById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FE1 RID: 16353 RVA: 0x001C38F3 File Offset: 0x001C1AF3
		static ConfigWuWuLogisticsDescById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWuWuLogisticsDescById.CreateStaticDefaultValue), new Action(ConfigWuWuLogisticsDescById.ResetStaticDefaultValue));
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x001C3914 File Offset: 0x001C1B14
		public static void CreateStaticDefaultValue()
		{
			ConfigWuWuLogisticsDescById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWuWuLogisticsDescById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_wuwutask.db"),
				new ValueTuple<string, object>("文件", "w.呜呜签到.xlsx"),
				new ValueTuple<string, object>("表名", "WuWuLogisticsDesc"),
				new ValueTuple<string, object>("语句", "select BinData from `WuWuLogisticsDesc` where Id=?")
			});
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x001C3993 File Offset: 0x001C1B93
		public static void ResetStaticDefaultValue()
		{
			ConfigWuWuLogisticsDescById.LogPair = null;
			ConfigWuWuLogisticsDescById.HandleId = 0;
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x001C39A1 File Offset: 0x001C1BA1
		public static void Init()
		{
			ConfigWuWuLogisticsDescById.HandleId = ConfigCommon.InitDataStatement(ConfigWuWuLogisticsDescById.HandleId, "db_wuwutask.db", "select BinData from `WuWuLogisticsDesc` where Id=?");
		}

		// Token: 0x06003FE5 RID: 16357 RVA: 0x001C39BC File Offset: 0x001C1BBC
		public static WuWuLogisticsDesc? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWuWuLogisticsDescById.HandleId, ConfigWuWuLogisticsDescById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WuWuLogisticsDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WuWuLogisticsDesc?(WuWuLogisticsDesc.GetRootAsWuWuLogisticsDesc(configBuffer));
				}
			}
			ConfigWuWuLogisticsDescById.LogPair.Clear();
			ConfigWuWuLogisticsDescById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWuWuLogisticsDescById.HandleId, 1, p0Id, ConfigWuWuLogisticsDescById.LogPair) || ConfigCommon.Step(ConfigWuWuLogisticsDescById.HandleId, true, ConfigWuWuLogisticsDescById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWuWuLogisticsDescById.HandleId, ConfigWuWuLogisticsDescById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWuWuLogisticsDescById.HandleId, 0, ConfigWuWuLogisticsDescById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWuWuLogisticsDescById.HandleId, ConfigWuWuLogisticsDescById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WuWuLogisticsDesc rootAsWuWuLogisticsDesc = WuWuLogisticsDesc.GetRootAsWuWuLogisticsDesc(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WuWuLogisticsDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWuWuLogisticsDescById.HandleId, ConfigWuWuLogisticsDescById.LogPair);
			return new WuWuLogisticsDesc?(rootAsWuWuLogisticsDesc);
		}

		// Token: 0x04004A54 RID: 19028
		private const string DB = "db_wuwutask.db";

		// Token: 0x04004A55 RID: 19029
		private const string FILE = "w.呜呜签到.xlsx";

		// Token: 0x04004A56 RID: 19030
		private const string TABLE = "WuWuLogisticsDesc";

		// Token: 0x04004A57 RID: 19031
		private const string COMMAND = "select BinData from `WuWuLogisticsDesc` where Id=?";

		// Token: 0x04004A58 RID: 19032
		private const string KEY_PREFIX = "WuWuLogisticsDescById";

		// Token: 0x04004A59 RID: 19033
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A5A RID: 19034
		private static int HandleId;
	}
}
