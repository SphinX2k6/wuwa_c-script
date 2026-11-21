using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000459 RID: 1113
	public class ConfigInstanceDungeonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A20 RID: 6688 RVA: 0x000F0B9F File Offset: 0x000EED9F
		static ConfigInstanceDungeonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstanceDungeonById.CreateStaticDefaultValue), new Action(ConfigInstanceDungeonById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x000F0BC0 File Offset: 0x000EEDC0
		public static void CreateStaticDefaultValue()
		{
			ConfigInstanceDungeonById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInstanceDungeonById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_instance_dungeon.db"),
				new ValueTuple<string, object>("文件", "f.副本.xlsx"),
				new ValueTuple<string, object>("表名", "InstanceDungeon"),
				new ValueTuple<string, object>("语句", "select BinData from `InstanceDungeon` where Id=?")
			});
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x000F0C3F File Offset: 0x000EEE3F
		public static void ResetStaticDefaultValue()
		{
			ConfigInstanceDungeonById.LogPair = null;
			ConfigInstanceDungeonById.HandleId = 0;
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x000F0C4D File Offset: 0x000EEE4D
		public static void Init()
		{
			ConfigInstanceDungeonById.HandleId = ConfigCommon.InitDataStatement(ConfigInstanceDungeonById.HandleId, "db_instance_dungeon.db", "select BinData from `InstanceDungeon` where Id=?");
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x000F0C68 File Offset: 0x000EEE68
		public static InstanceDungeon? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInstanceDungeonById.HandleId, ConfigInstanceDungeonById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InstanceDungeonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InstanceDungeon?(InstanceDungeon.GetRootAsInstanceDungeon(configBuffer));
				}
			}
			ConfigInstanceDungeonById.LogPair.Clear();
			ConfigInstanceDungeonById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInstanceDungeonById.HandleId, 1, p0Id, ConfigInstanceDungeonById.LogPair) || ConfigCommon.Step(ConfigInstanceDungeonById.HandleId, true, ConfigInstanceDungeonById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInstanceDungeonById.HandleId, ConfigInstanceDungeonById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInstanceDungeonById.HandleId, 0, ConfigInstanceDungeonById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInstanceDungeonById.HandleId, ConfigInstanceDungeonById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InstanceDungeon rootAsInstanceDungeon = InstanceDungeon.GetRootAsInstanceDungeon(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InstanceDungeonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInstanceDungeonById.HandleId, ConfigInstanceDungeonById.LogPair);
			return new InstanceDungeon?(rootAsInstanceDungeon);
		}

		// Token: 0x04001E53 RID: 7763
		private const string DB = "db_instance_dungeon.db";

		// Token: 0x04001E54 RID: 7764
		private const string FILE = "f.副本.xlsx";

		// Token: 0x04001E55 RID: 7765
		private const string TABLE = "InstanceDungeon";

		// Token: 0x04001E56 RID: 7766
		private const string COMMAND = "select BinData from `InstanceDungeon` where Id=?";

		// Token: 0x04001E57 RID: 7767
		private const string KEY_PREFIX = "InstanceDungeonById";

		// Token: 0x04001E58 RID: 7768
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E59 RID: 7769
		private static int HandleId;
	}
}
