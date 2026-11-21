using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200045B RID: 1115
	public class ConfigInstanceDungeonEntranceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A2C RID: 6700 RVA: 0x000F0F7B File Offset: 0x000EF17B
		static ConfigInstanceDungeonEntranceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstanceDungeonEntranceById.CreateStaticDefaultValue), new Action(ConfigInstanceDungeonEntranceById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x000F0F9C File Offset: 0x000EF19C
		public static void CreateStaticDefaultValue()
		{
			ConfigInstanceDungeonEntranceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInstanceDungeonEntranceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_instance_dungeon.db"),
				new ValueTuple<string, object>("文件", "f.副本.xlsx"),
				new ValueTuple<string, object>("表名", "InstanceDungeonEntrance"),
				new ValueTuple<string, object>("语句", "select BinData from `InstanceDungeonEntrance` where Id=?")
			});
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x000F101B File Offset: 0x000EF21B
		public static void ResetStaticDefaultValue()
		{
			ConfigInstanceDungeonEntranceById.LogPair = null;
			ConfigInstanceDungeonEntranceById.HandleId = 0;
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x000F1029 File Offset: 0x000EF229
		public static void Init()
		{
			ConfigInstanceDungeonEntranceById.HandleId = ConfigCommon.InitDataStatement(ConfigInstanceDungeonEntranceById.HandleId, "db_instance_dungeon.db", "select BinData from `InstanceDungeonEntrance` where Id=?");
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x000F1044 File Offset: 0x000EF244
		public static InstanceDungeonEntrance? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInstanceDungeonEntranceById.HandleId, ConfigInstanceDungeonEntranceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InstanceDungeonEntranceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InstanceDungeonEntrance?(InstanceDungeonEntrance.GetRootAsInstanceDungeonEntrance(configBuffer));
				}
			}
			ConfigInstanceDungeonEntranceById.LogPair.Clear();
			ConfigInstanceDungeonEntranceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInstanceDungeonEntranceById.HandleId, 1, p0Id, ConfigInstanceDungeonEntranceById.LogPair) || ConfigCommon.Step(ConfigInstanceDungeonEntranceById.HandleId, true, ConfigInstanceDungeonEntranceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInstanceDungeonEntranceById.HandleId, ConfigInstanceDungeonEntranceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInstanceDungeonEntranceById.HandleId, 0, ConfigInstanceDungeonEntranceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInstanceDungeonEntranceById.HandleId, ConfigInstanceDungeonEntranceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InstanceDungeonEntrance rootAsInstanceDungeonEntrance = InstanceDungeonEntrance.GetRootAsInstanceDungeonEntrance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InstanceDungeonEntranceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInstanceDungeonEntranceById.HandleId, ConfigInstanceDungeonEntranceById.LogPair);
			return new InstanceDungeonEntrance?(rootAsInstanceDungeonEntrance);
		}

		// Token: 0x04001E61 RID: 7777
		private const string DB = "db_instance_dungeon.db";

		// Token: 0x04001E62 RID: 7778
		private const string FILE = "f.副本.xlsx";

		// Token: 0x04001E63 RID: 7779
		private const string TABLE = "InstanceDungeonEntrance";

		// Token: 0x04001E64 RID: 7780
		private const string COMMAND = "select BinData from `InstanceDungeonEntrance` where Id=?";

		// Token: 0x04001E65 RID: 7781
		private const string KEY_PREFIX = "InstanceDungeonEntranceById";

		// Token: 0x04001E66 RID: 7782
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E67 RID: 7783
		private static int HandleId;
	}
}
