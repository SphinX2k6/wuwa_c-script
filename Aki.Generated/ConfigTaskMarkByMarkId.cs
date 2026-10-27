using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009C1 RID: 2497
	public class ConfigTaskMarkByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A9A RID: 15002 RVA: 0x001A52E3 File Offset: 0x001A34E3
		static ConfigTaskMarkByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTaskMarkByMarkId.CreateStaticDefaultValue), new Action(ConfigTaskMarkByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06003A9B RID: 15003 RVA: 0x001A5304 File Offset: 0x001A3504
		public static void CreateStaticDefaultValue()
		{
			ConfigTaskMarkByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTaskMarkByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "TaskMark"),
				new ValueTuple<string, object>("语句", "select BinData from `TaskMark` where MarkId = ?")
			});
		}

		// Token: 0x06003A9C RID: 15004 RVA: 0x001A5383 File Offset: 0x001A3583
		public static void ResetStaticDefaultValue()
		{
			ConfigTaskMarkByMarkId.LogPair = null;
			ConfigTaskMarkByMarkId.HandleId = 0;
		}

		// Token: 0x06003A9D RID: 15005 RVA: 0x001A5391 File Offset: 0x001A3591
		public static void Init()
		{
			ConfigTaskMarkByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigTaskMarkByMarkId.HandleId, "db_map_mark.db", "select BinData from `TaskMark` where MarkId = ?");
		}

		// Token: 0x06003A9E RID: 15006 RVA: 0x001A53AC File Offset: 0x001A35AC
		public static TaskMark? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTaskMarkByMarkId.HandleId, ConfigTaskMarkByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TaskMarkByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TaskMark?(TaskMark.GetRootAsTaskMark(configBuffer));
				}
			}
			ConfigTaskMarkByMarkId.LogPair.Clear();
			ConfigTaskMarkByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigTaskMarkByMarkId.HandleId, 1, p0MarkId, ConfigTaskMarkByMarkId.LogPair) || ConfigCommon.Step(ConfigTaskMarkByMarkId.HandleId, true, ConfigTaskMarkByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTaskMarkByMarkId.HandleId, ConfigTaskMarkByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTaskMarkByMarkId.HandleId, 0, ConfigTaskMarkByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTaskMarkByMarkId.HandleId, ConfigTaskMarkByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TaskMark rootAsTaskMark = TaskMark.GetRootAsTaskMark(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TaskMarkByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTaskMarkByMarkId.HandleId, ConfigTaskMarkByMarkId.LogPair);
			return new TaskMark?(rootAsTaskMark);
		}

		// Token: 0x0400442D RID: 17453
		private const string DB = "db_map_mark.db";

		// Token: 0x0400442E RID: 17454
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x0400442F RID: 17455
		private const string TABLE = "TaskMark";

		// Token: 0x04004430 RID: 17456
		private const string COMMAND = "select BinData from `TaskMark` where MarkId = ?";

		// Token: 0x04004431 RID: 17457
		private const string KEY_PREFIX = "TaskMarkByMarkId";

		// Token: 0x04004432 RID: 17458
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004433 RID: 17459
		private static int HandleId;
	}
}
