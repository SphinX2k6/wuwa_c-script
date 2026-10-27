using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000443 RID: 1091
	public class ConfigInstanceDungeonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600199C RID: 6556 RVA: 0x000EA44B File Offset: 0x000E864B
		static ConfigInstanceDungeonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstanceDungeonById.CreateStaticDefaultValue), new Action(ConfigInstanceDungeonById.ResetStaticDefaultValue));
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x000EA46C File Offset: 0x000E866C
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

		// Token: 0x0600199E RID: 6558 RVA: 0x000EA4EB File Offset: 0x000E86EB
		public static void ResetStaticDefaultValue()
		{
			ConfigInstanceDungeonById.LogPair = null;
			ConfigInstanceDungeonById.HandleId = 0;
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x000EA4F9 File Offset: 0x000E86F9
		public static void Init()
		{
			ConfigInstanceDungeonById.HandleId = ConfigCommon.InitDataStatement(ConfigInstanceDungeonById.HandleId, "db_instance_dungeon.db", "select BinData from `InstanceDungeon` where Id=?");
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x000EA514 File Offset: 0x000E8714
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

		// Token: 0x04001DB9 RID: 7609
		private const string DB = "db_instance_dungeon.db";

		// Token: 0x04001DBA RID: 7610
		private const string FILE = "f.副本.xlsx";

		// Token: 0x04001DBB RID: 7611
		private const string TABLE = "InstanceDungeon";

		// Token: 0x04001DBC RID: 7612
		private const string COMMAND = "select BinData from `InstanceDungeon` where Id=?";

		// Token: 0x04001DBD RID: 7613
		private const string KEY_PREFIX = "InstanceDungeonById";

		// Token: 0x04001DBE RID: 7614
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DBF RID: 7615
		private static int HandleId;
	}
}
