using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A96 RID: 2710
	public class ConfigTaskMarkByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F98 RID: 16280 RVA: 0x001C4677 File Offset: 0x001C2877
		static ConfigTaskMarkByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTaskMarkByMarkId.CreateStaticDefaultValue), new Action(ConfigTaskMarkByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06003F99 RID: 16281 RVA: 0x001C4698 File Offset: 0x001C2898
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

		// Token: 0x06003F9A RID: 16282 RVA: 0x001C4717 File Offset: 0x001C2917
		public static void ResetStaticDefaultValue()
		{
			ConfigTaskMarkByMarkId.LogPair = null;
			ConfigTaskMarkByMarkId.HandleId = 0;
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x001C4725 File Offset: 0x001C2925
		public static void Init()
		{
			ConfigTaskMarkByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigTaskMarkByMarkId.HandleId, "db_map_mark.db", "select BinData from `TaskMark` where MarkId = ?");
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x001C4740 File Offset: 0x001C2940
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

		// Token: 0x04004A00 RID: 18944
		private const string DB = "db_map_mark.db";

		// Token: 0x04004A01 RID: 18945
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04004A02 RID: 18946
		private const string TABLE = "TaskMark";

		// Token: 0x04004A03 RID: 18947
		private const string COMMAND = "select BinData from `TaskMark` where MarkId = ?";

		// Token: 0x04004A04 RID: 18948
		private const string KEY_PREFIX = "TaskMarkByMarkId";

		// Token: 0x04004A05 RID: 18949
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A06 RID: 18950
		private static int HandleId;
	}
}
