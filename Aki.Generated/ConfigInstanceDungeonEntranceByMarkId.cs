using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200045C RID: 1116
	public class ConfigInstanceDungeonEntranceByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A32 RID: 6706 RVA: 0x000F11C4 File Offset: 0x000EF3C4
		static ConfigInstanceDungeonEntranceByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstanceDungeonEntranceByMarkId.CreateStaticDefaultValue), new Action(ConfigInstanceDungeonEntranceByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x000F11E4 File Offset: 0x000EF3E4
		public static void CreateStaticDefaultValue()
		{
			ConfigInstanceDungeonEntranceByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInstanceDungeonEntranceByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_instance_dungeon.db"),
				new ValueTuple<string, object>("文件", "f.副本.xlsx"),
				new ValueTuple<string, object>("表名", "InstanceDungeonEntrance"),
				new ValueTuple<string, object>("语句", "select BinData from `InstanceDungeonEntrance` where MarkId=?")
			});
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x000F1263 File Offset: 0x000EF463
		public static void ResetStaticDefaultValue()
		{
			ConfigInstanceDungeonEntranceByMarkId.LogPair = null;
			ConfigInstanceDungeonEntranceByMarkId.HandleId = 0;
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x000F1271 File Offset: 0x000EF471
		public static void Init()
		{
			ConfigInstanceDungeonEntranceByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigInstanceDungeonEntranceByMarkId.HandleId, "db_instance_dungeon.db", "select BinData from `InstanceDungeonEntrance` where MarkId=?");
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x000F128C File Offset: 0x000EF48C
		public static InstanceDungeonEntrance? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInstanceDungeonEntranceByMarkId.HandleId, ConfigInstanceDungeonEntranceByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InstanceDungeonEntranceByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InstanceDungeonEntrance?(InstanceDungeonEntrance.GetRootAsInstanceDungeonEntrance(configBuffer));
				}
			}
			ConfigInstanceDungeonEntranceByMarkId.LogPair.Clear();
			ConfigInstanceDungeonEntranceByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigInstanceDungeonEntranceByMarkId.HandleId, 1, p0MarkId, ConfigInstanceDungeonEntranceByMarkId.LogPair) || ConfigCommon.Step(ConfigInstanceDungeonEntranceByMarkId.HandleId, true, ConfigInstanceDungeonEntranceByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInstanceDungeonEntranceByMarkId.HandleId, ConfigInstanceDungeonEntranceByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInstanceDungeonEntranceByMarkId.HandleId, 0, ConfigInstanceDungeonEntranceByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInstanceDungeonEntranceByMarkId.HandleId, ConfigInstanceDungeonEntranceByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InstanceDungeonEntrance rootAsInstanceDungeonEntrance = InstanceDungeonEntrance.GetRootAsInstanceDungeonEntrance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InstanceDungeonEntranceByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInstanceDungeonEntranceByMarkId.HandleId, ConfigInstanceDungeonEntranceByMarkId.LogPair);
			return new InstanceDungeonEntrance?(rootAsInstanceDungeonEntrance);
		}

		// Token: 0x04001E68 RID: 7784
		private const string DB = "db_instance_dungeon.db";

		// Token: 0x04001E69 RID: 7785
		private const string FILE = "f.副本.xlsx";

		// Token: 0x04001E6A RID: 7786
		private const string TABLE = "InstanceDungeonEntrance";

		// Token: 0x04001E6B RID: 7787
		private const string COMMAND = "select BinData from `InstanceDungeonEntrance` where MarkId=?";

		// Token: 0x04001E6C RID: 7788
		private const string KEY_PREFIX = "InstanceDungeonEntranceByMarkId";

		// Token: 0x04001E6D RID: 7789
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E6E RID: 7790
		private static int HandleId;
	}
}
