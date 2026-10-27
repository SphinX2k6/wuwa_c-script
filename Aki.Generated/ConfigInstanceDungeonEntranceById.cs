using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000445 RID: 1093
	public class ConfigInstanceDungeonEntranceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019A8 RID: 6568 RVA: 0x000EA827 File Offset: 0x000E8A27
		static ConfigInstanceDungeonEntranceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstanceDungeonEntranceById.CreateStaticDefaultValue), new Action(ConfigInstanceDungeonEntranceById.ResetStaticDefaultValue));
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x000EA848 File Offset: 0x000E8A48
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

		// Token: 0x060019AA RID: 6570 RVA: 0x000EA8C7 File Offset: 0x000E8AC7
		public static void ResetStaticDefaultValue()
		{
			ConfigInstanceDungeonEntranceById.LogPair = null;
			ConfigInstanceDungeonEntranceById.HandleId = 0;
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x000EA8D5 File Offset: 0x000E8AD5
		public static void Init()
		{
			ConfigInstanceDungeonEntranceById.HandleId = ConfigCommon.InitDataStatement(ConfigInstanceDungeonEntranceById.HandleId, "db_instance_dungeon.db", "select BinData from `InstanceDungeonEntrance` where Id=?");
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x000EA8F0 File Offset: 0x000E8AF0
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

		// Token: 0x04001DC7 RID: 7623
		private const string DB = "db_instance_dungeon.db";

		// Token: 0x04001DC8 RID: 7624
		private const string FILE = "f.副本.xlsx";

		// Token: 0x04001DC9 RID: 7625
		private const string TABLE = "InstanceDungeonEntrance";

		// Token: 0x04001DCA RID: 7626
		private const string COMMAND = "select BinData from `InstanceDungeonEntrance` where Id=?";

		// Token: 0x04001DCB RID: 7627
		private const string KEY_PREFIX = "InstanceDungeonEntranceById";

		// Token: 0x04001DCC RID: 7628
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DCD RID: 7629
		private static int HandleId;
	}
}
